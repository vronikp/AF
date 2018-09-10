using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.TopazMiddleWare
{
    public class TopazMiddleWareResponse
    {
        public String serviceName { get; set; }
        public int errorCode { get; set; }
        public String error { get; set; }
        public Boolean status { get; set; }
        public DmInsertaAsientos Sw_DmInsertaAsientos { get; set; }
    }

    public class DmInsertaAsientos
    {
        public DmInsertaAsiento Sw_DmInsertaAsiento { get; set; }
    }

    public class DmInsertaAsiento
    {
        public int asiento { get; set; }
        public String error { get; set; }
    }
}
