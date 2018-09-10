using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class CabeceraRequestAnt
    {
        [XmlRoot(ElementName = "xmlJBankField")]
        public class XmlJBankField
        {
            [XmlElement(ElementName = "fieldName")]
            public string FieldName { get; set; }
            [XmlElement(ElementName = "fieldValue")]
            public string FieldValue { get; set; }
        }

        [XmlRoot(ElementName = "xmlJBankFields")]
        public class XmlJBankFields
        {
            [XmlElement(ElementName = "xmlJBankField")]
            public List<XmlJBankField> XmlJBankField { get; set; }
        }

        [XmlRoot(ElementName = "xmlJBankService")]
        public class XmlJBankService
        {
            [XmlElement(ElementName = "serviceName")]
            public string ServiceName { get; set; }
            [XmlElement(ElementName = "xmlJBankFields")]
            public XmlJBankFields XmlJBankFields { get; set; }
        }

        [XmlRoot(ElementName = "xmlJBankRequest")]
        public class XmlJBankRequest
        {
            [XmlElement(ElementName = "xmlJBankService")]
            public XmlJBankService XmlJBankService { get; set; }
        }
    }
}
