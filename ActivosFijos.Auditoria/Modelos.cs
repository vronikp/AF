using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ActivosFijos
{
    public class Usuario
    {
        public string Usuari_Codigo { get; set; }
        public string Usuari_Descripcion { get; set; }

        public Usuario()
        {
        }

        public Usuario(string _Usuari_Codigo, string _Usuari_Descripcion)
        {
            Usuari_Codigo = _Usuari_Codigo;
            Usuari_Descripcion = _Usuari_Descripcion;
        }
    }

    public class Parametro
    {
        public int Parame_Codigo { get; set; }
        public int Pardet_Secuencia { get; set; }
        public string Nombre { get; set; }

        public Parametro(int _Parame_Codigo, int _Pardet_Secuencia, string _Nombre)
        {
            Parame_Codigo = _Parame_Codigo;
            Pardet_Secuencia = _Pardet_Secuencia;
            Nombre = _Nombre;
        }
    }

    public class Empleado
    {
        public int Emplea_Custodio { get; set; }
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }

        public Empleado(int _Emplea_Custodio, string _NombreCompleto, string _Identificacion)
        {
            Emplea_Custodio = _Emplea_Custodio;
            NombreCompleto = _NombreCompleto;
            Identificacion = _Identificacion;
        }
    }

    public class Activo
    {
        public int Emplea_Custodio { get; set; }
        public string Custodio { get; set; }
        public int Pardet_Ubicacion { get; set; }
        public string Ubicacion { get; set; }
        public Boolean InvDet_esCambioCustodio { get; set; }
        public Boolean InvDet_esCambioUbicacion { get; set; }
        public DateTime Usuari_FechaHoraRegistro { get; set; }
        public string Usuari_CodigoPDA { get; set; }
        public string CodigoBarras { get; set; }
        public string Clase { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int Pardet_EstadoActivo { get; set; }
        public string EstadoActivo { get; set; }
        public int Pardet_EstadoInventario { get; set; }
        public string EstadoInventario { get; set; }

        /*public Empleado EmpleaCustodio { get; set; }
        public Parametro PardetUbicacion { get; set; }
        public Parametro PardetEstadoActivo { get; set; }
        public Parametro PardetEstadoInventario { get; set; }*/

        public Activo()
        {
        }

        public Activo(int _Emplea_Custodio, string _Custodio, int _Pardet_Ubicacion, string _Ubicacion,
            Boolean _InvDet_esCambioCustodio, Boolean _InvDet_esCambioUbicacion, DateTime _Usuari_FechaHoraRegistro, 
            string _Usuari_CodigoPDA, string _CodigoBarras, string _Clase, string _Descripcion,
            string _Marca, string _Modelo, string _Serie, int _Pardet_EstadoActivo, string _EstadoActivo,
            int _Pardet_EstadoInventario, string _EstadoInventario)
        {
            Emplea_Custodio = _Emplea_Custodio;
            Custodio = _Custodio;
            Pardet_Ubicacion = _Pardet_Ubicacion;
            Ubicacion = _Ubicacion;
            InvDet_esCambioCustodio = _InvDet_esCambioCustodio;
            InvDet_esCambioUbicacion = _InvDet_esCambioUbicacion;
            Usuari_FechaHoraRegistro = _Usuari_FechaHoraRegistro;
            Usuari_CodigoPDA = _Usuari_CodigoPDA;
            CodigoBarras = _CodigoBarras;
            Clase = _Clase;
            Descripcion = _Descripcion;
            Marca = _Marca;
            Modelo = _Modelo;
            Serie = _Serie;
            Pardet_EstadoActivo = _Pardet_EstadoActivo;
            EstadoActivo = _EstadoActivo;
            Pardet_EstadoInventario = _Pardet_EstadoInventario;
            EstadoInventario = _EstadoInventario;
        }
    }

    public class Inventario
    {
        public Parametro Periodo { get; set; }
        public Parametro UbicacionInv { get; set; }


        public Inventario(Parametro _Periodo, Parametro _UbicacionInv)
        {
            Periodo = _Periodo;
            UbicacionInv = _UbicacionInv;
        }
    }
}
