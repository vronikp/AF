using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration
{
    public enum EnumTipoIntegracion
    {
        DMiro
    }

    public class Asiento
    {
        public static bool Generar(string tipoIntegracion, DataTable ds, out string Result)
        {
            Result = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro.ToString()) {
                return DMiro.Asiento.Generar(ds, out Result);
            }
            return false;
        }

        public static bool GenerarCabecera(string tipoIntegracion, DataTable ds,  out string Result, out string NumeroAsiento)
        {
            Result = null;
            NumeroAsiento = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro.ToString())
            {
                return DMiro.Asiento.GenerarCabecera(ds, out Result, out NumeroAsiento);
            }
            return false;
        }

        public static bool GenerarDetalle(string tipoIntegracion, DataTable ds, out string Result)
        {
            Result = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro.ToString())
            {
                return DMiro.Asiento.Generar(ds, out Result);
            }
            return false;
        }
    }
}
