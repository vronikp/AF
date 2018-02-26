using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class DetalleResponse
    {
        [XmlRoot(ElementName = "Sw_DmInsertaDetalle")]
        public class Sw_DmInsertaDetalle
        {
            [XmlElement(ElementName = "pn_error")]
            public string Pn_error { get; set; }
            [XmlElement(ElementName = "pv_error")]
            public string Pv_error { get; set; }
        }

        [XmlRoot(ElementName = "Sw_DmInsertaDetalles")]
        public class Sw_DmInsertaDetalles
        {
            [XmlElement(ElementName = "Sw_DmInsertaDetalle")]
            public Sw_DmInsertaDetalle Sw_DmInsertaDetalle { get; set; }
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
            [XmlElement(ElementName = "Sw_DmInsertaDetalles")]
            public Sw_DmInsertaDetalles Sw_DmInsertaDetalles { get; set; }
        }

    }
}
