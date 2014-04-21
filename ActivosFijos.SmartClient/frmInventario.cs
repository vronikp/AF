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
    public partial class frmInventario : Form
    {
        private Conexion mConexion = new Conexion();
        private ActivosFijosServiceClient cliente;
        private Inventario[] mInventarios;
        private string mUsuario;

        public frmInventario(string _Usuario)
        {
            InitializeComponent();
            mUsuario = _Usuario;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            frmIniciarToma f = new frmIniciarToma(mUsuario, (Inventario) cboInventarios.SelectedItem);
            f.ShowDialog();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            this.btnSeleccionar.Enabled = false;
            cliente = mConexion.Cliente();
            while (!File.Exists(mConexion.ArchivoConfiguracion) | cliente == null)
            {
                frmConexion f = new frmConexion("");
                f.ShowDialog();
                mConexion.Reload();
                cliente = mConexion.Cliente();
            }
            try
            {
                mInventarios = cliente.InventariosActivos();
                cboInventarios.Items.Clear();
                cboInventarios.DataSource = mInventarios;
                cboInventarios.DisplayMember = "Descripcion";

                this.btnSeleccionar.Enabled = (mInventarios != null && mInventarios.Length > 0);
            }
            catch (Exception){}
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            String servidor = "";
            if (cliente != null)
            {
                servidor = mConexion.Servidor;
            }
            frmConexion f = new frmConexion(servidor);
            f.ShowDialog();
            mConexion.Reload();
            Connect();
        }
    }
}