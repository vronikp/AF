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
        private Carga mCarga = new Carga();
        
        public frmInicioSesion()
        {
            InitializeComponent();
            CargarUsuarios();
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
                result = mCarga.IniciarSesion(txtUsuario.Text);
                if (result)
                {
                    frmIniciarToma f = new frmIniciarToma(mCarga.inventario, mCarga.usuario);
                    //f.mInventario= mCarga.inventario;
                    //f.mUsuario = mCarga.usuario;
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
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            while (!File.Exists(mCarga.ArchivoCarga))
            {
                MessageBox.Show("No se ha configurado correctamente el equipo.");
                mCarga.Reload();
            }
            this.btnSeleccionar.Enabled = true;
        }

        
    }
}