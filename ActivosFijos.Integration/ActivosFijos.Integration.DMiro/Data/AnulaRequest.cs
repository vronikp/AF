using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class AnulaRequest
    {
        public string pv_asiento_app { get; set; }
        public int pn_anio { get; set; }
        public int pn_asiento { get; set; }
        public string pv_sistema { get; set; }

        public AnulaRequest() { }

        public AnulaRequest(string _pv_asiento_app, int _pn_anio, int _pn_asiento, string _pv_sistema)
        {
            this.pv_asiento_app = _pv_asiento_app;
            this.pn_anio = _pn_anio;
            this.pn_asiento = _pn_asiento;
            this.pv_sistema = _pv_sistema;
        }
    }
}
