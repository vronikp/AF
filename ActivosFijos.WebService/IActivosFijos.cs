using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ActivosFijosServices
{
    [ServiceContract]
    public interface IActivosFijosService
    {
        // Methods
        [OperationContract]
        Activo CargarActivo(string Activo_Codigo, string Serie);
        [OperationContract]
        bool ActivoInventariado(int Activo_Codigo, int Parame_PeriodoInventario, int Pardet_PeriodoInventario);
        [OperationContract]
        string GuardarInventarioDet(string mUsuario, Inventario mInventario, Activo mActivo, int mCustodio, int mParame_Ubicacion, int mPardet_Ubicacion);
        [OperationContract]
        bool IniciarSesion(string mUsuario, string mContrasena);
        [OperationContract]
        Inventario[] InventariosActivos();
        [OperationContract]
        Caracteristica[] ListaCaracteristicas(int parame_tipo, int pardet_tipo);
        [OperationContract]
        Empleado[] ListaEmpleados(String parcial);
        [OperationContract]
        Factura[] ListaFacturas(int _proveedor);
        [OperationContract]
        Proveedor[] ListaProveedores();
        [OperationContract]
        Parametro[] ParametroList(int parame_codigo, int parame_padre, int pardet_padre, String filtro);
        [OperationContract]
        Parametro[] ParametroTreeList(int parame_inicio, int pardet_inicio, int parame_fin, bool solo_visibles);
    }


    [DataContract]
    public class Parametro
    {
        // Properties
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public int Parame_Codigo { get; set; }
        [DataMember]
        public int Pardet_Secuencia { get; set; }
    }

    [DataContract]
    public class Caracteristica
    {
        // Properties
        [DataMember]
        public string ActCar_Descripcion { get; set; }
        [DataMember]
        public string CaracteristicaText { get; set; }
        [DataMember]
        public bool esNuevo { get; set; }
        [DataMember]
        public int Parame_Caracteristica { get; set; }
        [DataMember]
        public int Pardet_Caracteristica { get; set; }
    }

    [DataContract]
    public class Inventario
    {
        // Properties
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public DateTime Invent_Fecha { get; set; }
        [DataMember]
        public int Parame_EstadoInventario { get; set; }
        [DataMember]
        public int Parame_PeriodoInventario { get; set; }
        [DataMember]
        public int Parame_Ubicacion { get; set; }
        [DataMember]
        public int Pardet_EstadoInventario { get; set; }
        [DataMember]
        public int Pardet_PeriodoInventario { get; set; }
        [DataMember]
        public int Pardet_Ubicacion { get; set; }
    }

    [DataContract]
    public class Empleado
    {
        // Properties
        [DataMember]
        public int Emplea_Custodio { get; set; }
        [DataMember]
        public string NombreCompleto { get; set; }
    }

    [DataContract]
    public class Activo
    {
        // Properties
        [DataMember]
        public int Activo_Codigo { get; set; }
        [DataMember]
        public string Activo_CodigoAux { get; set; }
        [DataMember]
        public string Activo_CodigoBarra { get; set; }
        [DataMember]
        public string Activo_Descripcion { get; set; }
        [DataMember]
        public DateTime Activo_FechaBaja { get; set; }
        [DataMember]
        public DateTime Activo_FechaCompra { get; set; }
        [DataMember]
        public DateTime Activo_FechaIngreso { get; set; }
        [DataMember]
        public DateTime Activo_FechaUso { get; set; }
        [DataMember]
        public string Activo_Modelo { get; set; }
        [DataMember]
        public string Activo_Observacion { get; set; }
        [DataMember]
        public string Activo_ResponsableMantenimiento { get; set; }
        [DataMember]
        public string Activo_Serie { get; set; }
        [DataMember]
        public Caracteristica[] Caracteristicas { get; set; }
        [DataMember]
        public int Entida_Custodio { get; set; }
        [DataMember]
        public int Entida_Proveedor { get; set; }
        [DataMember]
        public bool esNuevo { get; set; }
        [DataMember]
        public int Factura_Codigo { get; set; }
        [DataMember]
        public int Parame_CentroCosto { get; set; }
        [DataMember]
        public int Parame_ClaseActivo { get; set; }
        [DataMember]
        public int Parame_EstadoActivo { get; set; }
        [DataMember]
        public int Parame_EstadoDepreciacion { get; set; }
        [DataMember]
        public int Parame_Marca { get; set; }
        [DataMember]
        public int Parame_TipoBajaActivo { get; set; }
        [DataMember]
        public int Pardet_CentroCosto { get; set; }
        [DataMember]
        public int Pardet_ClaseActivo { get; set; }
        [DataMember]
        public int Pardet_EstadoActivo { get; set; }
        [DataMember]
        public int Pardet_EstadoDepreciacion { get; set; }
        [DataMember]
        public int Pardet_Grupo { get; set; }
        [DataMember]
        public int Pardet_Marca { get; set; }
        [DataMember]
        public int Pardet_Tipo { get; set; }
        [DataMember]
        public int Pardet_TipoBajaActivo { get; set; }
        [DataMember]
        public int Pardet_Ubicacion { get; set; }
    }

    [DataContract]
    public class Proveedor
    {
        // Properties
        [DataMember]
        public string NombreCompleto { get; set; }
        [DataMember]
        public int Provee_Codigo { get; set; }
    }

    [DataContract]
    public class Factura
    {
        // Properties
        [DataMember]
        public int Factura_Codigo { get; set; }
        [DataMember]
        public string Proveedor { get; set; }
    }

}
