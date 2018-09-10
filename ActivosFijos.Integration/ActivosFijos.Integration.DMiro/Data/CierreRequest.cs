using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class CierreRequest
    {
        public int pn_asiento { get; set; }

        public CierreRequest() { }

        public CierreRequest(int _pn_asiento)
        {
            this.pn_asiento = _pn_asiento;
        }
    }
}
