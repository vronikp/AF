using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class AutenticacionRequest
    {
        [XmlRoot(ElementName = "authentication")]
        public class Authentication
        {
            [XmlElement(ElementName = "type")]
            public string Type { get; set; }
            [XmlElement(ElementName = "userName")]
            public string UserName { get; set; }
            [XmlElement(ElementName = "password")]
            public string Password { get; set; }
            [XmlElement(ElementName = "sessionID")]
            public string SessionID { get; set; }
        }

        [XmlRoot(ElementName = "xmlJBankExecutionParameters")]
        public class XmlJBankExecutionParameters
        {
            [XmlElement(ElementName = "authentication")]
            public Authentication Authentication { get; set; }
        }
    }
}