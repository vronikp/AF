using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActivosFijos.Controles;

namespace ActivosFijos
{
    public partial class frmTomaActivo : Form
    {
        private Carga mCarga = new Carga();
        private Configuracion mConfiguracion = new Configuracion();
        private Usuario mUsuario;
        private Inventario mInventario;

        private Parametro pUbicacion;
        private Empleado eCustodio;
        private Activo mActivo;

        private List<Parametro> pEstadoActivo;

        private List<Activo> mActivos;

        private bool esLimpiar = false;

        public frmTomaActivo(Usuario _Usuario, Inventario _Inventario, Parametro _Ubicacion, Empleado _Empleado)
        {
            InitializeComponent();
            mUsuario = _Usuario;
            mInventario = _Inventario;
            pUbicacion = _Ubicacion;
            eCustodio = _Empleado;
            //chkSoloInventariados.Enabled = false;
            chkSoloInventariados.Checked = true;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "";
            txtSerie1.Text = "";
            LimpiarCampos();
            CargarActivo();
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtClase.Text = "";
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtSerie.Text = "";
            cboEstadoActivo.SelectedIndex = -1;            

            pnlBusqueda.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void frmTomaActivo_Load(object sender, EventArgs e)
        {
            lblUbicacion.Text += " " + pUbicacion.Nombre;
            lblCustodio.Text += " " + eCustodio.NombreCompleto;
            
            pEstadoActivo = mCarga.ListaEstados();
            try
            {
                //verificarChecks();
                
                cboEstadoActivo.DisplayMember = "Nombre";
                cboEstadoActivo.ValueMember = "Pardet_Secuencia";
                cboEstadoActivo.DataSource = pEstadoActivo;
            }
            catch (Exception) {}
            this.btnGuardar.Enabled = false;
        }

        private void llenarDatos()
        {
            try {
                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = mActivos.GetType().Name;

                DataGridTextBoxColumn DataGridTextBoxColumn1 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn1.MappingName = "CodigoBarras";
                DataGridTextBoxColumn1.HeaderText = "Código";
                DataGridTextBoxColumn1.Width = 50;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn1);

                DataGridTextBoxColumn DataGridTextBoxColumn2 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn2.MappingName = "Descripcion";
                DataGridTextBoxColumn2.HeaderText = "Descripcion";
                DataGridTextBoxColumn2.Width = 150;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn2);

                DataGridTextBoxColumn DataGridTextBoxColumn3 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn3.MappingName = "Marca";
                DataGridTextBoxColumn3.HeaderText = "Marca";
                DataGridTextBoxColumn3.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn3);

                DataGridTextBoxColumn DataGridTextBoxColumn4 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn4.MappingName = "Modelo";
                DataGridTextBoxColumn4.HeaderText = "Modelo";
                DataGridTextBoxColumn4.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn4);

                DataGridTextBoxColumn DataGridTextBoxColumn5 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn5.MappingName = "Serie";
                DataGridTextBoxColumn5.HeaderText = "Serie";
                DataGridTextBoxColumn5.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn5);

                DataGridTextBoxColumn DataGridTextBoxColumn6 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn6.MappingName = "InvDet_esCambioCustodio";
                DataGridTextBoxColumn6.HeaderText = "CambioCustodio";
                DataGridTextBoxColumn6.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn6);

                DataGridTextBoxColumn DataGridTextBoxColumn7 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn7.MappingName = "InvDet_esCambioUbicacion";
                DataGridTextBoxColumn7.HeaderText = "CambioUbicacion";
                DataGridTextBoxColumn7.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn7);

                this.dgActivos.TableStyles.Clear();
                this.dgActivos.TableStyles.Add(dgts);
            }
            catch (Exception) { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           if (cboEstadoActivo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado del activo.", "Mensaje");
            }
            else
            {

                try
                {
                    mActivo.Pardet_EstadoActivo = (int)cboEstadoActivo.SelectedValue;
                    mActivo.EstadoActivo = ((Parametro)cboEstadoActivo.SelectedItem).Nombre;
                    if (mActivo.Pardet_Ubicacion != pUbicacion.Pardet_Secuencia)
                    {
                        mActivo.InvDet_esCambioUbicacion = true;
                        mActivo.Pardet_Ubicacion = pUbicacion.Pardet_Secuencia;
                        mActivo.Ubicacion = mInventario.UbicacionInv.Nombre + ',' + pUbicacion.Nombre;
                    }
                    if (mActivo.Emplea_Custodio != eCustodio.Emplea_Custodio)
                    {
                        mActivo.InvDet_esCambioCustodio = true;
                        mActivo.Emplea_Custodio = eCustodio.Emplea_Custodio;
                        mActivo.Custodio = eCustodio.Identificacion + "," + eCustodio.NombreCompleto;
                    }
                    
                    string result = mCarga.GuardarInventarioDet(mUsuario, mActivo);

                    if (result!="")
                    {
                        MessageBox.Show("Error al registrar el inventario. " +result );
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Registro guardado.", "Mensaje");

                        LimpiarCampos();
                        
                        pnlBusqueda.Enabled = true;
                        btnGuardar.Enabled = false;
                        txtActivo.Focus();

                        txtActivo.Text = "";
                        txtSerie1.Text = "";
                        txtCodigo.Text = "";

                        btnLimpiar.Enabled = false;
                        pnlListaActivos.Visible = true;
                        pnlBusqueda.Visible = true;
                        tbActivo.Visible = false;
                        btnBack.Enabled = false;
                        btnNext.Enabled = false;

                        //actualizar lista activos
                        //verificarChecks();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error guardando inventario.");
                }
            }
            
        }

        private void txtActivo_PressEnter(object sender, EventArgs e)
        {
            txtSerie1.Focus();
        }

        private void txtSerie1_PressEnter(object sender, EventArgs e)
        {
            CargarActivo();
        }

        private bool CargandoArchivo = false;

        private void CargarActivo()
        {
            pnlBusqueda.Enabled = true;
            btnGuardar.Enabled = false;
            CargandoArchivo = true;
            //pnladic.Controls.Clear();
            if (string.IsNullOrEmpty(txtActivo.Text) && string.IsNullOrEmpty(txtSerie1.Text))
            {
                tbActivo.Enabled = false;
                txtActivo.Focus();
            }
            else
            {
                try
                {
                    
                    mActivo = mCarga.CargarActivo(txtActivo.Text, txtSerie1.Text);
                }
                catch
                {
                    tbActivo.Enabled = false;
                    MessageBox.Show("Error cargando activo.");
                    btnBack.Enabled = false;
                    pnlListaActivos.Visible = true;
                    pnlBusqueda.Visible = true;
                    pnlBusqueda.Enabled = true;
                    btnGuardar.Enabled = false;
                    tbActivo.Visible = false;
                    btnNext.Enabled = false;
                    txtActivo.Focus();
                    
                    return;
                }

                pnlDatos.Enabled = false;

                tbActivo.Enabled = true;
                if (mActivo == null)
                {
                    MessageBox.Show("No existe", "Mensaje");
                }
                else
                {
                    btnLimpiar.Enabled = true;
                    if (mActivo.Pardet_EstadoInventario!=1)
                    {
                        MessageBox.Show("El activo ya fue inventariado en este periodo", "Mensaje");
                        tbActivo.Enabled = false;
                    }
                    else
                    {
                        pnlBusqueda.Enabled = false;
                        btnGuardar.Enabled = true;
                            
                        pnlListaActivos.Visible = false;
                        pnlBusqueda.Visible = false;
                        tbActivo.Visible = true;
                        btnBack.Enabled = true;
                            
                        //inventario interprof
                        //tabControl1.Enabled = true;
                        pnlDatos.Enabled = true;
                        txtCodigo.Text = mActivo.CodigoBarras;
                        txtCodigo.Enabled = false;
                        txtClase.Text = mActivo.Clase ;
                        txtClase.Enabled = false;
                        txtDescripcion.Text = mActivo.Descripcion;
                        txtDescripcion.Enabled = false;
                        txtMarca.Text = mActivo.Marca;
                        txtMarca.Enabled = false;
                        txtModelo.Text = mActivo.Modelo;
                        txtModelo.Enabled = false;
                        txtSerie.Text = mActivo.Serie;
                        txtSerie.Enabled = false;
                        cboEstadoActivo.SelectedValue = mActivo.Pardet_EstadoActivo;
                    
                    }
                }
            }
            CargandoArchivo = false;
        }

      
        private void chbSoloUbicacion_CheckStateChanged(object sender, EventArgs e)
        {
            //verificarChecks();
            
        }

        private void verificarChecks()
        {
            try
            {
                if (this.chbSoloUbicacion.Checked && this.chkSoloInventariados.Checked)
                {
                    mActivos = mCarga.ListaActivos(eCustodio, pUbicacion, true, true);
                }
                else if (this.chbSoloUbicacion.Checked)
                {
                    mActivos = mCarga.ListaActivos(eCustodio, pUbicacion, true, false);
                }
                else if (this.chkSoloInventariados.Checked)
                {
                    mActivos = mCarga.ListaActivos(eCustodio, pUbicacion, false, true);
                }
                else
                {
                    mActivos = mCarga.ListaActivos(eCustodio, pUbicacion, false, false);
                }
                dgActivos.DataSource = mActivos;
                llenarDatos();
            }
            catch (Exception ex) 
            { 
                //MessageBox.Show("Error: "+ ex.ToString()); 
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = false;
            pnlListaActivos.Visible = true;
            pnlBusqueda.Visible = true;
            tbActivo.Visible = false;
            btnNext.Enabled = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnBack.Enabled = true;
            pnlListaActivos.Visible = false;
            pnlBusqueda.Visible = false;
            tbActivo.Visible = true;
            btnNext.Enabled = false;
        }

        private void chkSoloInventariados_CheckStateChanged(object sender, EventArgs e)
        {
            //verificarChecks();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "";
            txtSerie1.Text = "";
            LimpiarCampos();
            btnBack.Enabled = false;
            pnlListaActivos.Visible = true;
            pnlBusqueda.Visible = true;
            pnlBusqueda.Enabled = true;
            btnGuardar.Enabled = false;
            tbActivo.Visible = false;
            btnNext.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            verificarChecks();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}