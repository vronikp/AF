using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml.Linq;
using System.ServiceModel;


namespace ActivosFijos
{
    class Configuracion
    {
        public string ArchivoConfiguracion {get; set;}
        public bool puedeModificar {get; set;}
        public bool puedeVerNoInv { get; set; }
        public bool puedeIngresarNuevo { get; set; }
        public string MensajeError  {get; set;}

        public Configuracion()
        {
            Reload();
        }
        public void Reload()
        {
            ArchivoConfiguracion = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, 
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "configuracion.xml";
            loadConfig(ArchivoConfiguracion);
        }



        private void loadConfig(string arch_conf)
        {
            try
            {
                XDocument doc = XDocument.Load(arch_conf);
                string config =  doc.Root.Element("Configuracion").Value;

                
                switch (config)
                {
                    case "FrAn1115":
                        puedeVerNoInv = true; 
                        puedeModificar = true;
                        puedeIngresarNuevo = true;
                        break;
                    case "FrAn0005":
                        puedeVerNoInv = false;
                        puedeModificar = false;
                        puedeIngresarNuevo = false;
                        break;
                    case "FrAn0015":
                        puedeVerNoInv = false;
                        puedeModificar = false;
                        puedeIngresarNuevo = true;
                        break;
                    case "FrAn0105":
                        puedeVerNoInv = false;
                        puedeModificar = true;
                        puedeIngresarNuevo = false;
                        break;
                    case "FrAn0115":
                        puedeVerNoInv = false;
                        puedeModificar = true;
                        puedeIngresarNuevo = true;
                        break;
                    case "FrAn1005":
                        puedeVerNoInv = false;
                        puedeModificar = false;
                        puedeIngresarNuevo = false;
                        break;
                    case "FrAn1015":
                        puedeVerNoInv = true;
                        puedeModificar = false;
                        puedeIngresarNuevo = true;
                        break;
                    case "FrAn1105":
                        puedeVerNoInv = true;
                        puedeModificar = true;
                        puedeIngresarNuevo = false;
                        break;
                    default:
                        puedeVerNoInv = false;
                        puedeModificar = false;
                        puedeIngresarNuevo = false;
                        break;
                }
            }
            catch
            {
                //return null;
            }
        }

    }
}
