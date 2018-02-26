using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class CierreResponse
    {
        [XmlRoot(ElementName = "Sw_DmCierreAsiento")]
        public class Sw_DmCierreAsiento
        {
            [XmlElement(ElementName = "pn_error")]
            public string Pn_error { get; set; }
            [XmlElement(ElementName = "pv_error")]
            public string Pv_error { get; set; }
        }

        [XmlRoot(ElementName = "Sw_DmCierreAsientos")]
        public class Sw_DmCierreAsientos
        {
            [XmlElement(ElementName = "Sw_DmCierreAsiento")]
            public Sw_DmCierreAsiento Sw_DmCierreAsiento { get; set; }
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
            [XmlElement(ElementName = "Sw_DmCierreAsientos")]
            public Sw_DmCierreAsientos Sw_DmCierreAsientos { get; set; }
        }

    }
}
