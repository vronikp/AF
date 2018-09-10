using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class CabeceraRequest
    {
        public string pv_asiento_app { get; set; }
        public int pn_anio { get; set; }
        public string pv_glosa { get; set; }
        public string pv_sistema { get; set; }

        public CabeceraRequest() { }

        public CabeceraRequest(string _pv_asiento_app, int _pn_anio, string _pv_glosa, string _pv_sistema)
        {
            this.pv_asiento_app = _pv_asiento_app;
            this.pn_anio = _pn_anio;
            this.pv_glosa = _pv_glosa;
            this.pv_sistema = _pv_sistema;
        }
    }
}
