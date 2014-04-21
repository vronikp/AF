using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;
using System.Xml.Linq;
using System.Collections;
using Infoware.Datos;
using ActivosFijos.Reglas;
using System.Reflection;
using System.Web;
using Infoware.Reglas.General;
using ActivosFijos.WebService.Properties;

namespace ActivosFijosServices
{
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple, InstanceContextMode=InstanceContextMode.PerSession)]
    public class ActivosFijosService : IActivosFijosService
    {
        // Fields
        private OperadorDatosList mOperadorDatosList;
        // Methods
        public ActivosFijosService()
        {
            this.mOperadorDatosList = OperadorDatosList.dexml(Settings.Default.RutaConexion);
        }

        private void ArmarArbol(ref WWTSParametroDetList list, WWTSParametroDetList iniciolist, int parame_fin, bool solo_visibles)
        {
            foreach (WWTSParametroDet det in iniciolist)
            {
                if (det.Parame_Codigo == parame_fin)
                {
                    if (!solo_visibles || (solo_visibles && det.Pardet_DatoBit1)){
                        list.Add(det);
                    }
                }
                else
                {
                    this.ArmarArbol(ref list, 
                        WWTSParametroDetList.ObtenerLista(this.mOperadorDatosList[0], 
                            Enumerados.EnumParametros.Nulo, WWTSParametroDetList.enumTipoObjeto.Nada, det), 
                        parame_fin, solo_visibles);
                }
            }
        }

        public bool ActivoInventariado(int mCodigo, int mParame_PeriodoInventario, int mPardet_PeriodoInventario)
        {
            return ActivosFijos.Reglas.Activo.EstaEnInventario(this.mOperadorDatosList[0], mCodigo, new WWTSParametroDet(this.mOperadorDatosList[0], mParame_PeriodoInventario, mPardet_PeriodoInventario));
        }

        public Activo CargarActivo(string mCodigoBarra, string mSerie)
        {
            ActivosFijos.Reglas.Activo activo;
            try
            {
                if (string.IsNullOrWhiteSpace(mCodigoBarra))
                {
                    activo = ActivoList.ObtenerLista(this.mOperadorDatosList[0], "", "", mSerie,
                        "", null, null, "", null, null, null, null, null, true, -1, DateTime.Now, DateTime.Now, null)[0];
                }
                else
                {
                    activo = new ActivosFijos.Reglas.Activo(this.mOperadorDatosList[0], mCodigoBarra);
                }
            }
            catch
            {
                activo = new ActivosFijos.Reglas.Activo(this.mOperadorDatosList[0], true)
                {
                    Activo_CodigoBarra = mCodigoBarra
                };
            }
            Activo activo2 = new Activo
            {
                esNuevo = activo.EsNuevo,
                Activo_Codigo = activo.Activo_Codigo,
                Activo_CodigoBarra = activo.Activo_CodigoBarra,
                Activo_CodigoAux = activo.Activo_CodigoAux,
                Activo_Serie = activo.Activo_Serie,
                Parame_ClaseActivo = activo.Parame_ClaseActivo,
                Pardet_ClaseActivo = activo.Pardet_ClaseActivo,
                Activo_Descripcion = activo.Activo_Descripcion,
                Parame_Marca = activo.Parame_Marca,
                Pardet_Marca = activo.Pardet_Marca,
                Activo_Modelo = activo.Activo_Modelo,
                Activo_Observacion = activo.Activo_Observacion,
                Parame_EstadoDepreciacion = activo.Parame_EstadoDepreciacion,
                Pardet_EstadoDepreciacion = activo.Pardet_EstadoDepreciacion,
                Parame_EstadoActivo = activo.Parame_EstadoActivo,
                Pardet_EstadoActivo = activo.Pardet_EstadoActivo,
                Activo_ResponsableMantenimiento = activo.Activo_ResponsableMantenimiento,
                Activo_FechaIngreso = activo.Activo_FechaIngreso,
                Activo_FechaCompra = activo.Activo_FechaCompra,
                Activo_FechaUso = activo.Activo_FechaUso,
                Parame_CentroCosto = activo.Parame_CentroCosto,
                Pardet_CentroCosto = activo.Pardet_CentroCosto,
                Factura_Codigo = activo.Factura_Codigo,
                Activo_FechaBaja = activo.Activo_FechaBaja,
                Parame_TipoBajaActivo = activo.Parame_TipoBajaActivo,
                Pardet_TipoBajaActivo = activo.Pardet_TipoBajaActivo
            };
            if (activo.Facturaactivo == null)
            {
                activo2.Entida_Proveedor = 0;
            }
            else
            {
                activo2.Entida_Proveedor = activo.Facturaactivo.Entida_Proveedor;
            }
            activo2.Caracteristicas = new Caracteristica[activo.Caracteristicas.Count];
            int index = 0;
            foreach (ActivoCaracteristica caracteristica in activo.Caracteristicas)
            {
                activo2.Caracteristicas[index] = new Caracteristica
                {
                    Parame_Caracteristica = caracteristica.Parame_Caracteristica,
                    Pardet_Caracteristica = caracteristica.Pardet_Caracteristica,
                    CaracteristicaText = caracteristica.CaracteristicaString,
                    ActCar_Descripcion = caracteristica.ActCar_Descripcion,
                    esNuevo = caracteristica.EsNuevo
                };
                index++;
            }
            if (activo.PardetGrupoActivo != null)
            {
                activo2.Pardet_Grupo = activo.PardetGrupoActivo.Pardet_Secuencia;
            }
            if (activo.PardetTipoActivo != null)
            {
                activo2.Pardet_Tipo = activo.PardetTipoActivo.Pardet_Secuencia;
            }
            return activo2;
        }

        public string GuardarInventarioDet(string mUsuario, Inventario mInventario, Activo mActivo, int mCustodio, 
            int mParame_Ubicacion, int mPardet_Ubicacion)
        {
            ActivosFijos.Reglas.Activo activo;
            WWTSUsuario usuario = new WWTSUsuario(this.mOperadorDatosList[0], mUsuario);
            Restriccion restriccion = new Restriccion(this.mOperadorDatosList[0],
                new Infoware.Reglas.General.ParametroDet(this.mOperadorDatosList[0],
                    new Infoware.Reglas.General.Parametro(this.mOperadorDatosList[0], (int)Enumerados.EnumParametros.Opciones), 
                    (int)Enumerados.EnumOpciones.InventariarDesdePDA), usuario);
            int estadoinventario = (int)Enumerados.enumEstadoInventarioActivo.NoInventariado;
            if (mActivo.esNuevo)
            {
                activo = new ActivosFijos.Reglas.Activo(this.mOperadorDatosList[0], true);
                estadoinventario = (int)Enumerados.enumEstadoInventarioActivo.EncontradoNuevo;
            }
            else
            {
                activo = new ActivosFijos.Reglas.Activo(this.mOperadorDatosList[0], mActivo.Activo_Codigo);
                estadoinventario = (int)Enumerados.enumEstadoInventarioActivo.EncontradoExistente;
            }
            activo.Activo_CodigoBarra = mActivo.Activo_CodigoBarra;
            activo.Activo_CodigoAux = mActivo.Activo_CodigoAux;
            activo.Activo_Serie = mActivo.Activo_Serie;
            activo.Parame_ClaseActivo = mActivo.Parame_ClaseActivo;
            activo.Pardet_ClaseActivo = mActivo.Pardet_ClaseActivo;
            activo.Activo_Descripcion = mActivo.Activo_Descripcion;
            activo.Parame_Marca = mActivo.Parame_Marca;
            activo.Pardet_Marca = mActivo.Pardet_Marca;
            activo.Activo_Modelo = mActivo.Activo_Modelo;
            activo.Activo_Observacion = mActivo.Activo_Observacion;
            activo.Parame_EstadoDepreciacion = mActivo.Parame_EstadoDepreciacion;
            activo.Pardet_EstadoDepreciacion = mActivo.Pardet_EstadoDepreciacion;
            activo.Parame_EstadoActivo = mActivo.Parame_EstadoActivo;
            activo.Pardet_EstadoActivo = mActivo.Pardet_EstadoActivo;
            activo.Activo_ResponsableMantenimiento = mActivo.Activo_ResponsableMantenimiento;
            activo.Activo_FechaIngreso = mActivo.Activo_FechaIngreso;
            activo.Activo_FechaCompra = mActivo.Activo_FechaCompra;
            activo.Activo_FechaUso = mActivo.Activo_FechaUso;
            activo.Parame_CentroCosto = mActivo.Parame_CentroCosto;
            activo.Pardet_CentroCosto = mActivo.Pardet_CentroCosto;
            activo.Factura_Codigo = mActivo.Factura_Codigo;
            activo.Activo_FechaBaja = mActivo.Activo_FechaBaja;
            activo.Parame_TipoBajaActivo = mActivo.Parame_TipoBajaActivo;
            activo.Pardet_TipoBajaActivo = mActivo.Pardet_TipoBajaActivo;
            foreach (Caracteristica caracteristica in mActivo.Caracteristicas)
            {
                ActivoCaracteristica item = new ActivoCaracteristica(this.mOperadorDatosList[0], caracteristica.esNuevo)
                {
                    Parame_Caracteristica = (int)Enumerados.EnumParametros.CaracteristicaActivo,
                    Pardet_Caracteristica = caracteristica.Pardet_Caracteristica,
                    ActCar_Descripcion = caracteristica.ActCar_Descripcion
                };
                activo.Caracteristicas.Add(item);
            }
            bool flag = false;
            if (mActivo.esNuevo)
            {
                flag = activo.Guardar(new WWTSParametroDet(this.mOperadorDatosList[0], mParame_Ubicacion, mPardet_Ubicacion), 
                    new ActivosFijos.Reglas.Empleado(this.mOperadorDatosList[0], mCustodio), 0, 0, 0,
                    new WWTSParametroDet(this.mOperadorDatosList[0], (int)Enumerados.EnumParametros.TipoEmpleado, 
                        (int)Enumerados.enumTipoEmpleado.Custodio));
            }
            else
            {
                flag = activo.Guardar(null, null, 0, 0, 0, null);
            }
            if (flag)
            {
                Auditoria.Registrar_Auditoria(restriccion, 
                    mActivo.esNuevo ? Auditoria.enumTipoAccion.Adicion : Auditoria.enumTipoAccion.Modificacion, 
                    "Actualización activo (" + activo.CodigoBarra + ") " + activo.Descripcion);
                InventarioDet det;
                try
                {
                    det = new InventarioDet(this.mOperadorDatosList[0], mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, 
                        mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario, mActivo.Activo_Codigo);
                    estadoinventario = (int)Enumerados.enumEstadoInventarioActivo.Inventariado;
                }
                catch
                {
                    det = new InventarioDet(this.mOperadorDatosList[0], true)
                    {
                        Parame_Ubicacion = mInventario.Parame_Ubicacion,
                        Pardet_Ubicacion = mInventario.Pardet_Ubicacion,
                        Parame_PeriodoInventario = mInventario.Parame_PeriodoInventario,
                        Pardet_PeriodoInventario = mInventario.Pardet_PeriodoInventario,
                        Activo_Codigo = activo.Activo_Codigo
                    };
                }
                det.Parame_EstadoInventario = (int)Enumerados.EnumParametros.EstadoInventarioActivo;
                det.Pardet_EstadoInventario = estadoinventario;
                det.Usuari_CodigoPDA = mUsuario;
                
                bool esNuevo = det.EsNuevo;
                flag = det.Guardar(mCustodio, mParame_Ubicacion, mPardet_Ubicacion);
                if (flag)
                {
                    Auditoria.Registrar_Auditoria(restriccion, 
                        esNuevo ? Auditoria.enumTipoAccion.Adicion : Auditoria.enumTipoAccion.Modificacion, 
                        "Registro de inventario (" + activo.CodigoBarra + ") " + activo.Descripcion);
                }
            }
            if (!flag)
            {
                return ("Error " + this.mOperadorDatosList[0].MsgError);
            }
            return "";
        }

        public bool IniciarSesion(string mUsuario, string mContrasena)
        {
            bool result = false;
            try
            {
                WWTSUsuario usuario = new WWTSUsuario(this.mOperadorDatosList[0], mUsuario);
                result = usuario.VerificarPassword(mContrasena);
                if (result)
                {
                    ParametroDet det = new ParametroDet(this.mOperadorDatosList[0], 
                        (int)Enumerados.EnumParametros.Opciones, (int)Enumerados.EnumOpciones.InventariarDesdePDA);
                    Restriccion restriccion = new Restriccion(this.mOperadorDatosList[0], det, usuario);
                    result = restriccion.Restri_Modificacion;
                }
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public Inventario[] InventariosActivos()
        {
            InventarioList list = InventarioList.ObtenerListaActivos(this.mOperadorDatosList[0], null, null);
            Inventario[] result = new Inventario[list.Count];
            int index = 0;
            foreach (ActivosFijos.Reglas.Inventario inventario in list)
            {
                result[index] = new Inventario { 
                    Parame_PeriodoInventario = inventario.Parame_PeriodoInventario, 
                    Pardet_PeriodoInventario = inventario.Pardet_PeriodoInventario, 
                    Parame_Ubicacion = inventario.Parame_Ubicacion, 
                    Pardet_Ubicacion = inventario.Pardet_Ubicacion, 
                    Descripcion = inventario.Descripcion, 
                    Invent_Fecha = inventario.Invent_Fecha, 
                    Parame_EstadoInventario = inventario.Parame_EstadoInventario, 
                    Pardet_EstadoInventario = inventario.Pardet_EstadoInventario };
                index++;
            }
            return result;
        }

        public Caracteristica[] ListaCaracteristicas(int parame_tipo, int pardet_tipo)
        {
            WWTSParametroDet det = new WWTSParametroDet(this.mOperadorDatosList[0], parame_tipo, pardet_tipo);
            WWTSParametroDetList list = WWTSParametroDetList.ObtenerLista(this.mOperadorDatosList[0], 
                Enumerados.EnumParametros.CaracteristicaActivo, WWTSParametroDetList.enumTipoObjeto.Nada, det);
            Caracteristica[] caracteristicaArray = new Caracteristica[list.Count];
            int index = 0;
            foreach (WWTSParametroDet det2 in list)
            {
                caracteristicaArray[index] = new Caracteristica { 
                    Parame_Caracteristica = det2.Parame_Codigo, 
                    Pardet_Caracteristica = det2.Pardet_Secuencia, 
                    CaracteristicaText = det2.Pardet_Descripcion, 
                    esNuevo = true, 
                    ActCar_Descripcion = "" };
                index++;
            }
            return caracteristicaArray;
        }

        public Empleado[] ListaEmpleados(String parcial)
        {
            WWTSParametroDet det = new WWTSParametroDet(this.mOperadorDatosList[0], 
                (int)Enumerados.EnumParametros.TipoEmpleado, (int)Enumerados.enumTipoEmpleado.Custodio);
            EmpleadoList list = EmpleadoList.ObtenerLista(this.mOperadorDatosList[0], det, true, parcial);
            Empleado[] result = new Empleado[list.Count];
            int index = 0;
            foreach (ActivosFijos.Reglas.Empleado empleado in list)
            {
                result[index] = new Empleado { 
                    Emplea_Custodio = empleado.Entida_Codigo, 
                    NombreCompleto = empleado.NombreCompleto };
                index++;
            }
            return result;
        }

        public Factura[] ListaFacturas(int _proveedor)
        {
            FacturaActivoList list = FacturaActivoList.ObtenerLista(new ActivosFijos.Reglas.Proveedor(this.mOperadorDatosList[0], _proveedor));
            Factura[] result = new Factura[list.Count];
            int index = 0;
            foreach (FacturaActivo activo in list)
            {
                result[index] = new Factura { 
                    Factura_Codigo = activo.Factura_Codigo, 
                    Proveedor = activo.FacturaNumero };
                index++;
            }
            return result;
        }

        public Proveedor[] ListaProveedores()
        {
            ProveedorList list = ProveedorList.ObtenerLista(this.mOperadorDatosList[0]);
            Proveedor[] result = new Proveedor[list.Count];
            int index = 0;
            foreach (ActivosFijos.Reglas.Proveedor proveedor in list)
            {
                result[index] = new Proveedor { 
                    Provee_Codigo = proveedor.Entida_Codigo, 
                    NombreCompleto = proveedor.NombreCompleto };
                index++;
            }
            return result;
        }

        public Parametro[] ParametroList(int parame_codigo, int parame_padre, int pardet_padre, String filtro)
        {
            WWTSParametroDet pardet = null;
            if ((parame_padre != 0) && (pardet_padre != 0))
            {
                pardet = new WWTSParametroDet(this.mOperadorDatosList[0], parame_padre, pardet_padre);
            }
            WWTSParametroDetList list = WWTSParametroDetList.ObtenerLista(this.mOperadorDatosList[0], 
                (Enumerados.EnumParametros)parame_codigo, WWTSParametroDetList.enumTipoObjeto.Nada, pardet, filtro);
            Parametro[] result = new Parametro[list.Count];
            int index = 0;
            foreach (WWTSParametroDet det2 in list)
            {
                result[index] = new Parametro {
                    Parame_Codigo = det2.Parame_Codigo, 
                    Pardet_Secuencia = det2.Pardet_Secuencia, 
                    Descripcion = det2.Descripcion };
                index++;
            }
            return result;
        }

        public Parametro[] ParametroTreeList(int parame_inicio, int pardet_inicio, int parame_fin, bool solo_visibles)
        {
            WWTSParametroDetList iniciolist = new WWTSParametroDetList();
            if (pardet_inicio != 0)
            {
                iniciolist.Add(new WWTSParametroDet(this.mOperadorDatosList[0], parame_inicio, pardet_inicio));
            }
            else
            {
                iniciolist = WWTSParametroDetList.ObtenerLista(this.mOperadorDatosList[0], (Enumerados.EnumParametros)parame_inicio);
            }
            WWTSParametroDetList list = new WWTSParametroDetList();
            this.ArmarArbol(ref list, iniciolist, parame_fin, solo_visibles);
            Parametro[] result = new Parametro[list.Count];
            int index = 0;
            foreach (WWTSParametroDet det in list)
            {
                result[index] = new Parametro { 
                    Parame_Codigo = det.Parame_Codigo, 
                    Pardet_Secuencia = det.Pardet_Secuencia, 
                    Descripcion = det.DescripcionLarga };
                index++;
            }
            return result;
        }

    }
}
