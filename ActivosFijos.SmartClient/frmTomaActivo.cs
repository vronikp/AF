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

        private int GRUPO = 10009;
        private int TIPO = 10019;
        private int CLASE = 10029;
        private int MARCA = 10030;
        private int ESTADODEPRECIACION = 10035;
        private int ESTADOACTIVO = 10040;

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

            pEstadoDepreciacion = cliente.ParametroList(ESTADODEPRECIACION, 0, 0, "");
            pEstadoActivo = cliente.ParametroList(ESTADOACTIVO, 0, 0, "");
            pGrupo = cliente.ParametroList(GRUPO, 0, 0, "");
            try
            {
                lblUbicacion.Text += " " + pUbicacion.Descripcion;
                lblCustodio.Text += " " + eCustodio.NombreCompleto;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                mActivo.Activo_CodigoBarra = txtActivo.Text;
                mActivo.Activo_Serie = txtSerie.Text;
                mActivo.Parame_ClaseActivo = CLASE;
                mActivo.Pardet_ClaseActivo = (int)cboClase.SelectedValue;
                mActivo.Activo_Descripcion = txtDescripcion.Text;
                mActivo.Parame_Marca = MARCA;
                mActivo.Pardet_Marca = (int) cboMarca.SelectedValue;
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
                    MessageBox.Show("Registro guardado", "Mensaje");
                    pnlBusqueda.Enabled = true;
                    btnGuardar.Enabled = false;
                    txtActivo.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error guardando inventario, puede deberse a problemas de conexión o de concurrencia, inténtelo de nuevo");
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
                tabControl1.Enabled = false;
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
                    tabControl1.Enabled = false;
                    MessageBox.Show("Error cargando activo, puede deberse a problemas de conexión o de concurrencia, inténtelo de nuevo");
                    return;
                }

                txtmarca.Text = "";

                tabControl1.Enabled = true;
                if (mActivo.esNuevo)
                {
                    MessageBox.Show("Activo nuevo", "Mensaje");
                    LimpiarCampos();
                    CargarCaracteristicasporTipo();
                }
                else
                {
                    //MessageBox.Show("Fecha baja " + mActivo.Activo_FechaBaja.ToString());
                    if (mActivo.Activo_FechaBaja.ToString("yyyy-MM-dd") == "0001-01-01")
                    {
                        bool inventariado = cliente.ActivoInventariado(mActivo.Activo_Codigo, mInventario.Parame_PeriodoInventario, mInventario.Pardet_PeriodoInventario);
                        if (inventariado)
                        {
                            MessageBox.Show("El activo ya fue inventariado en este periodo", "Mensaje");
                            tabControl1.Enabled = false;
                        }
                        else
                        {
                            pnlBusqueda.Enabled = false;
                            btnGuardar.Enabled = true;
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
                        tabControl1.Enabled = false;
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

        private void txtSerie1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}