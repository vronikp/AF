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
        private Conexion mConexion = new Conexion();
        private Configuracion mConfiguracion = new Configuracion();
        private ActivosFijosServiceClient cliente;
        private string mUsuario;
        private Inventario mInventario;

        private Parametro pUbicacion;
        private Empleado eCustodio;
        private Activo mActivo;

        private Parametro[] pClase;
        private Parametro[] pMarca;
        private Parametro[] pEstadoDepreciacion;
        private Parametro[] pEstadoActivo;
        private Parametro[] pGrupo;
        private Parametro[] pTipo;

        private Activo[] mActivos;


        private int GRUPO = 10009;
        private int TIPO = 10019;
        private int CLASE = 10029;
        private int MARCA = 10030;
        private int ESTADODEPRECIACION = 10035;
        private int ESTADOACTIVO = 10040;

        private bool esLimpiar = false;

        public frmTomaActivo(string _Usuario, Inventario _Inventario, Parametro ubicacion, Empleado custodio)
        {
            InitializeComponent();
            mUsuario = _Usuario;
            mInventario = _Inventario;
            pUbicacion = ubicacion;
            eCustodio = custodio;
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
            cboTipo.SelectedIndex = -1;
            cboClase.SelectedIndex = -1;
            txtDescripcion.Text = "";
            txtmarca.Text = "";
            cboMarca.SelectedIndex = -1;
            txtModelo.Text = "";
            txtSerie.Text = "";
            cboEstadoActivo.SelectedIndex = -1;
            cboDepreciacion.SelectedIndex = -1;
            txtObservacion.Text = "";
            txtResponsable.Text = "";
            pnladic.Controls.Clear();

            pnlBusqueda.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void frmTomaActivo_Load(object sender, EventArgs e)
        {
            cliente = mConexion.Cliente();

            chkSoloInventariados.Enabled = mConfiguracion.puedeVerNoInv;

            pEstadoDepreciacion = cliente.ParametroList(ESTADODEPRECIACION, 0, 0, "");
            pEstadoActivo = cliente.ParametroList(ESTADOACTIVO, 0, 0, "");
            pGrupo = cliente.ParametroList(GRUPO, 0, 0, "");
            try
            {
                lblUbicacion.Text += " " + pUbicacion.Descripcion;
                lblCustodio.Text += " " + eCustodio.NombreCompleto;

                verificarChecks();
                
                cboEstadoActivo.DisplayMember = "Descripcion";
                cboEstadoActivo.ValueMember = "Pardet_Secuencia";
                cboEstadoActivo.DataSource = pEstadoActivo;

                cboDepreciacion.DisplayMember = "Descripcion";
                cboDepreciacion.ValueMember = "Pardet_Secuencia";
                cboDepreciacion.DataSource = pEstadoDepreciacion;

                cboGrupo.DisplayMember = "Descripcion";
                cboGrupo.ValueMember = "Pardet_Secuencia";
                cboGrupo.DataSource = pGrupo;
            }
            catch (Exception) {}
            this.btnGuardar.Enabled = false;
        }

        private void llenarDatos()
        {
            try {
                DataGridTableStyle dgts = new DataGridTableStyle();
                dgts.MappingName = mActivos.GetType().Name;

                DataGridTextBoxColumn DataGridTextBoxColumn6 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn6.MappingName = "Activo_Observacion";
                DataGridTextBoxColumn6.HeaderText = "Estado";
                DataGridTextBoxColumn6.Width = 120;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn6);

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

                this.dgActivos.TableStyles.Clear();
                this.dgActivos.TableStyles.Add(dgts);
            }
            catch (Exception) { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboClase.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la clase.","Mensaje");
            }
            else if (cboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la marca.", "Mensaje");
            }
            else if ( cboDepreciacion.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado de depreciación.", "Mensaje");
            }
            else if (cboEstadoActivo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el estado del activo.", "Mensaje");
            }
            else
            {

                try
                {
                    mActivo.Activo_CodigoBarra = txtActivo.Text;
                    mActivo.Activo_CodigoAux = txtCodAux.Text;
                    mActivo.Activo_Serie = txtSerie.Text;
                    mActivo.Parame_ClaseActivo = CLASE;
                    mActivo.Pardet_ClaseActivo = (int)cboClase.SelectedValue;
                    mActivo.Activo_Descripcion = txtDescripcion.Text;
                    mActivo.Parame_Marca = MARCA;
                    mActivo.Pardet_Marca = (int)cboMarca.SelectedValue;
                    mActivo.Activo_Modelo = txtModelo.Text;
                    mActivo.Activo_Observacion = txtObservacion.Text;
                    mActivo.Parame_EstadoDepreciacion = ESTADODEPRECIACION;
                    mActivo.Pardet_EstadoDepreciacion = (int)cboDepreciacion.SelectedValue;
                    mActivo.Parame_EstadoActivo = ESTADOACTIVO;
                    mActivo.Pardet_EstadoActivo = (int)cboEstadoActivo.SelectedValue;
                    mActivo.Activo_ResponsableMantenimiento = txtResponsable.Text;

                    mActivo.Caracteristicas = new Caracteristica[pnladic.Controls.Count];
                    int i = 0;
                    foreach (ActivosFijos.Controles.CtlAdicional ctl in pnladic.Controls)
                    {
                        mActivo.Caracteristicas[i] = ctl.get_Catacteristica();
                        i++;
                    }

                    mActivo.Pardet_Ubicacion = pUbicacion.Pardet_Secuencia;
                    mActivo.Entida_Custodio = eCustodio.Emplea_Custodio;

                    string result = cliente.GuardarInventarioDet(mUsuario, mInventario, mActivo,
                       eCustodio.Emplea_Custodio, pUbicacion.Parame_Codigo, pUbicacion.Pardet_Secuencia);
                    if (!string.IsNullOrEmpty(result))
                    {
                        MessageBox.Show("Error al registrar el inventario " + result, "Error");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Registro guardado. Desea limpiar los campos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                        if (dialogResult == DialogResult.Yes)
                        {
                            cboClase.SelectedIndex = -1;
                            cboTipo.SelectedIndex = -1;
                            cboGrupo.SelectedIndex = -1;
                            LimpiarCampos();
                        }
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
                        verificarChecks();

                    }
                }
                catch
                {
                    MessageBox.Show("Error guardando inventario, puede deberse a problemas de conexión o de concurrencia, inténtelo de nuevo");
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
            pnladic.Controls.Clear();
            if (string.IsNullOrEmpty(txtActivo.Text) && string.IsNullOrEmpty(txtSerie1.Text))
            {
                tbActivo.Enabled = false;
                txtActivo.Focus();
            }
            else
            {
                try
                {
                    mActivo = cliente.CargarActivo(txtActivo.Text, txtSerie1.Text);
                }
                catch
                {
                    tbActivo.Enabled = false;
                    MessageBox.Show("Error cargando activo, puede deberse a problemas de conexión o de concurrencia, inténtelo de nuevo");
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

                //txtmarca.Text = "";
                pnlDatos.Enabled = false;
                /*txtCodAux.Enabled = false;
                cboGrupo.Enabled = false;
                cboTipo.Enabled = false;
                cboClase.Enabled = false;
                txtDescripcion.Enabled = false;
                txtmarca.Enabled = false;
                cboMarca.Enabled = false;
                txtModelo.Enabled = false;
                txtSerie.Enabled = false;*/
                //pnladic.Enabled = false;
                //pnlOtros.Enabled = false;
                txtObservacion.Enabled = false;
                txtResponsable.Enabled = false;
                cboDepreciacion.Enabled = false;

                if (mConfiguracion.puedeModificar)
                {
                    /*txtCodAux.Enabled = true;
                    cboGrupo.Enabled = true;
                    cboTipo.Enabled = true;
                    cboClase.Enabled = true;
                    txtDescripcion.Enabled = true;
                    txtmarca.Enabled = true;
                    cboMarca.Enabled = true;
                    txtModelo.Enabled = true;
                    txtSerie.Enabled = true;*/
                    pnlDatos.Enabled = true;
                    //pnladic.Enabled = true;
                    txtResponsable.Enabled = true;
                    cboDepreciacion.Enabled = true;
                    txtObservacion.Enabled = true;
                    //pnlOtros.Enabled = true;
                }
                

                tbActivo.Enabled = true;
                if (mActivo.esNuevo)
                {
                    //LimpiarCampos();
                    if (mConfiguracion.puedeIngresarNuevo)
                    {
                        MessageBox.Show("Activo nuevo", "Mensaje");
                        btnLimpiar.Enabled = true;
                        btnGuardar.Enabled = true;
                        txtCodigo.Text = txtActivo.Text;
                        CargarCaracteristicasporTipo();
                        pnlDatos.Enabled = true;
                        pnladic.Enabled = true;
                        pnlOtros.Enabled = true;
                        pnlListaActivos.Visible = false;
                        pnlBusqueda.Visible = false;
                        tbActivo.Visible = true;
                        btnBack.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Activo no existe", "Mensaje"); 
                    }
                    //btnNext.Enabled = true;
                }
                else
                {
                    //MessageBox.Show("Fecha baja " + mActivo.Activo_FechaBaja.ToString());
                    btnLimpiar.Enabled = true;

                    if (mActivo.Activo_FechaBaja.ToString("yyyy-MM-dd") == "0001-01-01")
                    {
                        bool inventariado = cliente.ActivoInventariado(mActivo.Activo_Codigo, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario);
                        if (inventariado)
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
                            
                            txtCodigo.Text = mActivo.Activo_CodigoBarra;
                            cboGrupo.SelectedValue = mActivo.Pardet_Grupo;
                            cboTipo.SelectedValue = mActivo.Pardet_Tipo;
                            if (!mActivo.esNuevo)
                            {
                                foreach (Caracteristica carac in mActivo.Caracteristicas)
                                {
                                    ActivosFijos.Controles.CtlAdicional ctl = new ActivosFijos.Controles.CtlAdicional();
                                    ctl.set_Caracteristica(carac);
                                    pnladic.Controls.Add(ctl);
                                    ctl.Dock = DockStyle.Top;
                                    ctl.SendToBack();
                                }
                            }

                            CargarCaracteristicasporTipo();
                            txtCodAux.Text = mActivo.Activo_CodigoAux;
                            cboClase.SelectedValue = mActivo.Pardet_ClaseActivo;
                            txtDescripcion.Text = mActivo.Activo_Descripcion;
                            CargarUnaMarca(mActivo.Parame_Marca, mActivo.Pardet_Marca, mActivo.Parame_Marca);
                            cboMarca.SelectedValue = mActivo.Pardet_Marca;
                            txtModelo.Text = mActivo.Activo_Modelo;
                            txtSerie.Text = mActivo.Activo_Serie;
                            cboEstadoActivo.SelectedValue = mActivo.Pardet_EstadoActivo;
                            cboDepreciacion.SelectedValue = mActivo.Pardet_EstadoDepreciacion;
                            txtObservacion.Text = mActivo.Activo_Observacion;
                            txtResponsable.Text = mActivo.Activo_ResponsableMantenimiento;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El activo ha sido dado de baja", "Mensaje");
                        tbActivo.Enabled = false;
                    }
                }
            }
            CargandoArchivo = false;
        }

        private void cboGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGrupo.SelectedIndex >= 0 && (int)cboGrupo.SelectedValue > 0)
            {
                pTipo = cliente.ParametroList(TIPO, GRUPO, (int)cboGrupo.SelectedValue, "");
                cboTipo.DisplayMember = "Descripcion";
                cboTipo.ValueMember = "Pardet_Secuencia";
                cboTipo.DataSource = pTipo;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CargandoArchivo)
            {
                CargarCaracteristicasporTipo();
            }
        }

        private void CargarCaracteristicasporTipo()
        {
            if (cboTipo.SelectedIndex >= 0 && (int)cboTipo.SelectedValue>0)
            {
                pClase = cliente.ParametroList(CLASE, TIPO, (int)cboTipo.SelectedValue, "");
                cboClase.DisplayMember = "Descripcion";
                cboClase.ValueMember = "Pardet_Secuencia";
                cboClase.DataSource = pClase;

                for (int i = pnladic.Controls.Count-1; i >= 0; i--)
                {
                    CtlAdicional adic = (CtlAdicional)pnladic.Controls[i];
                    if (adic.get_Catacteristica().esNuevo)
                    {
                        pnladic.Controls.RemoveAt(i);
                    }
                }
                
                Caracteristica[] nuevas;
                nuevas = cliente.ListaCaracteristicas(TIPO, (int)cboTipo.SelectedValue);
                foreach (Caracteristica carac in nuevas)
                {
                    bool existe = false;

                    foreach (Caracteristica carac2 in mActivo.Caracteristicas)
                    {
                        if (carac.Pardet_Caracteristica == carac2.Pardet_Caracteristica)
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (!existe)
                    {
                        ActivosFijos.Controles.CtlAdicional ctl = new ActivosFijos.Controles.CtlAdicional();
                        ctl.set_Caracteristica(carac);
                        pnladic.Controls.Add(ctl);
                        ctl.Dock = DockStyle.Top;
                    }
                }

            }
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarUnaMarca(int Parame_Codigo, int Pardet_Secuencia, int Parame_fin)
        {
            try
            {
                pMarca = cliente.ParametroTreeList(Parame_Codigo, Pardet_Secuencia, Parame_Codigo, false);
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Pardet_Secuencia";
                cboMarca.DataSource = pMarca;

                this.btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                this.btnGuardar.Enabled = false;
            }

        }

        private void CargarMarca(String parcial)
        {
            try
            {
                pMarca = cliente.ParametroList(MARCA, 0, 0, parcial);
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.ValueMember = "Pardet_Secuencia";
                cboMarca.DataSource = pMarca;
               
                this.btnGuardar.Enabled = true;
            }
            catch (Exception)
            {
                this.btnGuardar.Enabled = false;
            }
        }

        private void txtmarca_PressEnter(object sender, EventArgs e)
        {
            CargarMarca(txtmarca.Text);
        }

        private void chbSoloUbicacion_CheckStateChanged(object sender, EventArgs e)
        {
            verificarChecks();
            
        }

        private void verificarChecks()
        {
            try
            {

                if (this.chbSoloUbicacion.Checked && this.chkSoloInventariados.Checked)
                {
                    mActivos = cliente.ListaActivos(eCustodio.Emplea_Custodio, pUbicacion.Parame_Codigo, pUbicacion.Pardet_Secuencia, mInventario, true);
                }
                else if (this.chbSoloUbicacion.Checked)
                {
                    mActivos = cliente.ListaActivos(eCustodio.Emplea_Custodio, pUbicacion.Parame_Codigo, pUbicacion.Pardet_Secuencia, mInventario, false);
                }
                else if (this.chkSoloInventariados.Checked)
                {
                    mActivos = cliente.ListaActivos(eCustodio.Emplea_Custodio, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario, true);
                }
                else
                {
                    mActivos = cliente.ListaActivos(eCustodio.Emplea_Custodio, mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, mInventario, false);
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
            verificarChecks();
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



    }
}