using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Xml.Linq;

namespace ActivosFijos
{
    public partial class frmInicioSesion : Form
    {
        private Conexion mConexion = new Conexion();
        private ActivosFijosServiceClient cliente;
        
        public frmInicioSesion()
        {
            InitializeComponent();
            Connect();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            bool result = false;
            try
            {
                result = cliente.IniciarSesion(txtUsuario.Text, txtContrasena.Text);
                if (result)
                {
                    frmInventario f = new frmInventario(txtUsuario.Text);
                    f.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
            }
            MessageBox.Show("Error al iniciar sesión, revise que el usuario y contraseña sean correctos y que tenga permisos suficientes", "Error");
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            cliente = mConexion.Cliente();
            while (!File.Exists(mConexion.ArchivoConfiguracion) | cliente == null)
            {
                frmConexion f = new frmConexion("");
                f.ShowDialog();
                mConexion.Reload();
                cliente = mConexion.Cliente();
            }
            this.btnSeleccionar.Enabled = true;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            String servidor = "";
            if (cliente != null){
                servidor = mConexion.Servidor;
            }
            frmConexion f = new frmConexion(servidor);
            f.ShowDialog();
            mConexion.Reload();
            Connect();
        }
    }
}