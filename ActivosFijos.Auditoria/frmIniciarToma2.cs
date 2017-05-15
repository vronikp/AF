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
    public partial class frmIniciarToma2 : Form
    {
        private Conexion mConexion = new Conexion();
        private ActivosFijosServiceClient cliente;
        private string mUsuario;
        private Inventario mInventario;

        private Parametro pUbicacion;
        private Empleado eCustodio;
        private Activo[] mActivos;

        public frmIniciarToma2(string _Usuario, Inventario _Inventario, Parametro ubicacion, Empleado custodio)
        {
            InitializeComponent();
            mUsuario = _Usuario;
            mInventario = _Inventario;
            pUbicacion = ubicacion;
            eCustodio = custodio;
        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInventariar_Click(object sender, EventArgs e)
        {
            frmTomaActivo f = new frmTomaActivo(mUsuario, mInventario, pUbicacion, eCustodio);
            f.ShowDialog();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIniciarToma2_Load(object sender, EventArgs e)
        {
            cliente = mConexion.Cliente();

            try
            {
                lblUbicacion.Text += " " + pUbicacion.Descripcion;
                lblCustodio.Text += " " + eCustodio.NombreCompleto;
                mActivos = cliente.ListaActivos(eCustodio.Emplea_Custodio, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario);
                dgActivos.DataSource = mActivos;

                //mActivos[0].

                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = mActivos.GetType().Name;

                DataGridTextBoxColumn DataGridTextBoxColumn1 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn1.MappingName = "Activo_CodigoBarra";
                DataGridTextBoxColumn1.HeaderText = "Código";
                DataGridTextBoxColumn1.Width = 50;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn1);

                DataGridTextBoxColumn DataGridTextBoxColumn2 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn2.MappingName = "Activo_Descripcion";
                DataGridTextBoxColumn2.HeaderText = "Descripcion";
                DataGridTextBoxColumn2.Width = 150;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn2);

                DataGridTextBoxColumn DataGridTextBoxColumn3 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn3.MappingName = "Activo_ResponsableMantenimiento";
                DataGridTextBoxColumn3.HeaderText = "Marca";
                DataGridTextBoxColumn3.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn3);

                DataGridTextBoxColumn DataGridTextBoxColumn4 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn4.MappingName = "Activo_Modelo";
                DataGridTextBoxColumn4.HeaderText = "Modelo";
                DataGridTextBoxColumn4.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn4);

                DataGridTextBoxColumn DataGridTextBoxColumn5 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn5.MappingName = "Activo_Serie";
                DataGridTextBoxColumn5.HeaderText = "Serie";
                DataGridTextBoxColumn5.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn5);

                DataGridTextBoxColumn DataGridTextBoxColumn6 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn6.MappingName = "Activo_Observacion";
                DataGridTextBoxColumn6.HeaderText = "Estado";
                DataGridTextBoxColumn6.Width = 120;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn6);

                this.dgActivos.TableStyles.Clear();
                this.dgActivos.TableStyles.Add(dgts);
            }
            catch (Exception) { }

            
        }


    }
}