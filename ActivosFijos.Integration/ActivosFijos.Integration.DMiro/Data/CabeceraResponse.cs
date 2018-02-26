using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class CabeceraResponse
    {
        [XmlRoot(ElementName = "Sw_DmInsertaAsiento")]
        public class Sw_DmInsertaAsiento
        {
            [XmlElement(ElementName = "pn_asiento")]
            public string Pn_asiento { get; set; }
            [XmlElement(ElementName = "pv_error")]
            public string Pv_error { get; set; }
        }

        [XmlRoot(ElementName = "Sw_DmInsertaAsientos")]
        public class Sw_DmInsertaAsientos
        {
            [XmlElement(ElementName = "Sw_DmInsertaAsiento")]
            public Sw_DmInsertaAsiento Sw_DmInsertaAsiento { get; set; }
        }

        [XmlRoot(ElementName = "TopazMiddleWareResponse")]
        public class TopazMiddleWareResponse
        {
            [XmlElement(ElementName = "serviceName")]
            public string ServiceName { get; set; }
            [XmlElement(ElementName = "errorCode")]
            public string ErrorCode { get; set; }
            [XmlElement(ElementName = "error")]
            public string Error { get; set; }
            [XmlElement(ElementName = "status")]
            public string Status { get; set; }
            [XmlElement(ElementName = "Sw_DmInsertaAsientos")]
            public Sw_DmInsertaAsientos Sw_DmInsertaAsientos { get; set; }
        }
    }
}
