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
        public static bool Generar(EnumTipoIntegracion tipoIntegracion, DataTable ds, out string Result)
        {
            Result = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro) {
                return DMiro.Asiento.Generar(ds, out Result);
            }
            return false;
        }

        public static bool GenerarCabecera(EnumTipoIntegracion tipoIntegracion, DataTable ds, out string Result)
        {
            Result = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro)
            {
                return DMiro.Asiento.Generar(ds, out Result);
            }
            return false;
        }

        public static bool GenerarDetalle(EnumTipoIntegracion tipoIntegracion, DataTable ds, out string Result)
        {
            Result = null;
            if (tipoIntegracion == EnumTipoIntegracion.DMiro)
            {
                return DMiro.Asiento.Generar(ds, out Result);
            }
            return false;
        }
    }
}
