using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Reflection;

namespace ActivosFijos
{
    public partial class frmConexion : Form
    {
        public frmConexion(String servidor)
        {
            InitializeComponent();
            this.txtServidor.Text = servidor;
        }
        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string file = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "conexion.xml";
            XDocument doc = new XDocument();
            
            XElement xRoot = new XElement("Root");
            doc.Add(xRoot);

            XElement servidor = new XElement("Servidor");
            servidor.SetValue(txtServidor.Text);
            xRoot.Add(servidor);

            doc.Save(file);

            string fileConfig = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "configuracion.xml";
            XDocument docConfig = new XDocument();

            XElement xRootConfig = new XElement("Root");
            docConfig.Add(xRootConfig);

            XElement config = new XElement("Configuracion");
            config.SetValue(txtConfiguracion.Text);
            xRootConfig.Add(config);

            if (txtConfiguracion.Text != "")
            {
                docConfig.Save(fileConfig);
            }

            this.Close();
        }
    }
}