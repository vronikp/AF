using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml.Linq;
using System.ServiceModel;

namespace ActivosFijos
{
    class Conexion
    {
        public string ArchivoConfiguracion {get; set;}
        public string URL {get; set;}
        public string Servidor { get; set; }
        public string MensajeError  {get; set;}

        public Conexion()
        {
            Reload();
        }
        public void Reload()
        {
            ArchivoConfiguracion = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, 
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "conexion.xml";
            Servidor = loadURL(ArchivoConfiguracion);
            URL = string.Format("http://{0}/ActivosFijos.svc", Servidor);
        }
        public ActivosFijosServiceClient Cliente()
        {
            ActivosFijosServiceClient client;
            try
            {
                string remoteAddress = ActivosFijosServiceClient.EndpointAddress.Uri.ToString();
                remoteAddress = URL;
                EndpointAddress endpoint = new EndpointAddress(remoteAddress);
                client = new ActivosFijosServiceClient(new BasicHttpBinding(), endpoint);
            }
            catch (Exception ex) {
                MensajeError = ex.Message;
                client = null;
            }
            return client;
        }

        private string loadURL(string arch_conf)
        {
            try
            {
                XDocument doc = XDocument.Load(arch_conf);
                return doc.Root.Element("Servidor").Value;
            }
            catch
            {
                return null;
            }
        }
    }
}
