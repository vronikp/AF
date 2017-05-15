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
using ActivosFijos.Controles;
using ExcelLibrary.SpreadSheet;

namespace ActivosFijos
{
    public partial class frmIniciarToma : Form
    {
        private Carga mCarga = new Carga();
        //private ActivosFijosServiceClient cliente;
        private List<Parametro> mUbicaciones;
        private List<Empleado> mEmpleados;
        private Inventario mInventario;
        private Usuario mUsuario;

        public frmIniciarToma(Inventario _Inventario, Usuario _Usuario)
        {
            InitializeComponent();
            mInventario = _Inventario;
            mUsuario = _Usuario;
            lblInventario.Text = mInventario.Periodo.Nombre + '-' + mInventario.UbicacionInv.Nombre;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            frmTomaActivo f = new frmTomaActivo(mUsuario, mInventario, (Parametro)cboUbicacion.SelectedItem, (Empleado)cboCustodio.SelectedItem);
            f.ShowDialog();
        }

        private void frmIniciarToma_Load(object sender, EventArgs e)
        {
            this.btnSeleccionar.Enabled = false;
            //cliente = mConexion.Cliente();
            try
            {
                //mUbicaciones = cliente.ParametroTreeList(mInventario.Parame_Ubicacion, mInventario.Pardet_Ubicacion, (int)EnumParametros.UbicacionActivo, true);
                mUbicaciones = mCarga.ListaUbicaciones();
                cboUbicacion.Items.Clear();
                cboUbicacion.DataSource = mUbicaciones;
                cboUbicacion.DisplayMember = "Nombre";
                cboUbicacion.ValueMember = "Pardet_Secuencia";
            }
            catch (Exception){}
        }

        private void CargarCustodio(String parcial)
        {
            this.btnSeleccionar.Enabled = false;
            try
            {
                mEmpleados = mCarga.ListaEmpleados(parcial);
                cboCustodio.DataSource = mEmpleados;
                cboCustodio.DisplayMember = "NombreCompleto";
                cboCustodio.ValueMember = "Emplea_Custodio";

                this.btnSeleccionar.Enabled = (mEmpleados != null && mEmpleados.Count > 0);
            }
            catch (Exception){}
        }

        private void cboUbicacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboUbicacion.SelectedIndex < 0)
            {
                this.lblUbicacionCompleta.Text = "";
            }
            else
            {
                this.lblUbicacionCompleta.Text = ((Parametro)cboUbicacion.SelectedItem).Nombre;
            }
        }

        private void txtparcial_PressEnter(object sender, EventArgs e)
        {
            CargarCustodio(txtparcial.Text);
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            string nombreArchivo = mInventario.UbicacionInv.Nombre + "-" +
                mUsuario.Usuari_Codigo + " " + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString()
                    + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("HH") + "H" +
                    DateTime.Now.ToString("mm") + ".xls";

            

            string file = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0,
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) +
                nombreArchivo;
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("Inventario");

            try
            {
                List<Activo> listaActivosExportar = mCarga.ListaActivosExportar();

                worksheet.Cells[0, 0] = new Cell("Errores");
                worksheet.Cells[0, 1] = new Cell("Ubicacion");
                worksheet.Cells[0, 2] = new Cell("Periodo");
                worksheet.Cells[0, 3] = new Cell("UbicacionActual");
                worksheet.Cells[0, 4] = new Cell("CustodioActual");
                worksheet.Cells[0, 5] = new Cell("EstadoInventarioDet");
                worksheet.Cells[0, 6] = new Cell("Usuari_CodigoPDA");
                worksheet.Cells[0, 7] = new Cell("CodigoBarras");
                worksheet.Cells[0, 8] = new Cell("EstadoActivo");
                worksheet.Cells[0, 9] = new Cell("FechaRegistro");

                if (listaActivosExportar.Count() == 0)
                {
                    MessageBox.Show("No hay activos inventariados para exportar.");
                    return;
                }
                else
                {
                    MessageBox.Show("Se exportarán " + listaActivosExportar.Count().ToString() + " activos.");
                    for (int i = 0; i < listaActivosExportar.Count(); i++)
                    {
                        worksheet.Cells[i + 1, 0] = new Cell(" ");
                        worksheet.Cells[i + 1, 1] = new Cell(mInventario.UbicacionInv.Nombre);
                        worksheet.Cells[i + 1, 2] = new Cell(mInventario.Periodo.Nombre);
                        worksheet.Cells[i + 1, 3] = new Cell(listaActivosExportar.ElementAt(i).Ubicacion);
                        worksheet.Cells[i + 1, 4] = new Cell(listaActivosExportar.ElementAt(i).Custodio);
                        worksheet.Cells[i + 1, 5] = new Cell(listaActivosExportar.ElementAt(i).EstadoInventario);
                        worksheet.Cells[i + 1, 6] = new Cell(mUsuario.Usuari_Codigo);
                        worksheet.Cells[i + 1, 7] = new Cell(listaActivosExportar.ElementAt(i).CodigoBarras);
                        worksheet.Cells[i + 1, 8] = new Cell(listaActivosExportar.ElementAt(i).EstadoActivo);
                        worksheet.Cells[i + 1, 9] = new Cell(listaActivosExportar.ElementAt(i).Usuari_FechaHoraRegistro, @"YYYY-MM-DD hh:mm");
                    }
                }
                for (int i = 0; i < 100; i++)
                {
                    worksheet.Cells[5000 + i, 0] = new Cell("");
                    worksheet.Cells[5000 + i, 1] = new Cell("");
                    worksheet.Cells[5000 + i, 2] = new Cell("");
                    worksheet.Cells[5000 + i, 3] = new Cell("");
                    worksheet.Cells[5000 + i, 4] = new Cell("");
                    worksheet.Cells[5000 + i, 5] = new Cell("");
                    worksheet.Cells[5000 + i, 6] = new Cell("");
                    worksheet.Cells[5000 + i, 7] = new Cell("");
                    worksheet.Cells[5000 + i, 8] = new Cell("");
                    worksheet.Cells[5000 + i, 9] = new Cell("");
                }
                workbook.Worksheets.Add(worksheet);
                workbook.Save(file);
                MessageBox.Show("Exportado con exito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}