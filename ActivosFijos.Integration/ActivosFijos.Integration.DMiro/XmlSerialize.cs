using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ActivosFijos.Integration.DMiro
{
    public static class XmlSerialize
    {
        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

        public static T Deserialize<T>(this string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                try
                {
                    var xmldeserializer = new XmlSerializer(typeof(T));
                    MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(value));

                    T resultingMessage = (T)xmldeserializer.Deserialize(memStream);
                    return resultingMessage;
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred", ex);
                }
            }
            return default(T);
        }
    }
}
