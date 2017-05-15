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

namespace InventoryCount.SmartDevice
{
    public partial class FrmInventario : Form
    {
        public bool esEquipo;
        public bool esPerecible;

        private InventarioDet mInventarioDet;
        private List<InventarioDet> listaInventarioDet = new List<InventarioDet>();
        private int rowSelected;
        private int total = 0;
        private Bodega mBodega;
        private Ubicacion mUbicacion;

        public FrmInventario(bool _esEquipo, bool _esPerecible, Bodega _bodega, Ubicacion _ubicacion)
        {
            InitializeComponent();

            esEquipo = _esEquipo;
            esPerecible = _esPerecible;
            mBodega = _bodega;
            mUbicacion = _ubicacion;

            this.Text = "Inventario de Productos";

            this.lblUbicacion.Text = _bodega.Bodega_Nombre + ": " + _ubicacion.Ubicac_Descripcion;

            if (esEquipo)
            {
                this.pnlSerie.Visible = true;
                this.Text = "Inventario de Equipos";
            }
            if (esPerecible)
            {
                this.pnlLote.Visible = true;
                this.pnlFechaVenc.Visible = true;
                this.Text = "Inventario de Prod. Perecibles";
            }

            dgInventarioDet.DataSource = listaInventarioDet;
            Llenar_detalles();
            limpiar();

            int ancho = this.Width / 2;
            this.btnAgregar.Width = ancho;
            this.btnQuitar.Width = ancho;
        }

        private void Agregar()
        {
            try
            {
                total += Convert.ToInt32(this.txtCantidad.Text);

                if (esEquipo)
                {
                    mInventarioDet = new InventarioDet(this.txtCodigo.Text, this.txtSerie.Text, Convert.ToInt32(this.txtCantidad.Text));
                }
                else if (esPerecible)
                {
                    mInventarioDet = new InventarioDet(this.txtCodigo.Text, Convert.ToInt32(this.txtCantidad.Text), this.txtNoLote.Text, this.dtpFecVenc.Value);
                }
                else
                {
                    mInventarioDet = new InventarioDet(this.txtCodigo.Text, this.txtSerie.Text, Convert.ToInt32(this.txtCantidad.Text));
                }
                listaInventarioDet.Add(mInventarioDet);
                bsInventarioDet.DataSource = listaInventarioDet;
                Llenar_detalles();
                limpiar();
            }
            catch
            {
                MessageBox.Show("La cantidad debe estar escrita en numeros");
            }
            
        }

        private void limpiar()
        {
            this.txtCodigo.Text = "";
            this.txtCodigo.Focus();
            this.txtCantidad.Text = "1";
            this.txtSerie.Text = "";
            this.txtNoLote.Text = "";
            this.dtpFecVenc.Value = DateTime.Now;
            this.txtTotal.Text = total.ToString();
        }


        public void Llenar_detalles()
        {
            DataGridTableStyle dgts = new DataGridTableStyle();
            dgts.MappingName = listaInventarioDet.GetType().Name;

            DataGridTextBoxColumn DataGridTextBoxColumn1 = new DataGridTextBoxColumn();
            DataGridTextBoxColumn1.MappingName = "Item_Codigo";
            DataGridTextBoxColumn1.HeaderText = "Código";
            DataGridTextBoxColumn1.Width = 70;
            dgts.GridColumnStyles.Add(DataGridTextBoxColumn1);

            if (esEquipo)
            {
                DataGridTextBoxColumn DataGridTextBoxColumn2 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn2.MappingName = "Invdet_Serie";
                DataGridTextBoxColumn2.HeaderText = "Serie";
                DataGridTextBoxColumn2.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn2);
            }

            if (esPerecible)
            {
                DataGridTextBoxColumn DataGridTextBoxColumn5 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn5.MappingName = "Invdet_NoLote";
                DataGridTextBoxColumn5.HeaderText = "No. Lote";
                DataGridTextBoxColumn5.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn5);

                DataGridTextBoxColumn DataGridTextBoxColumn6 = new DataGridTextBoxColumn();
                DataGridTextBoxColumn6.MappingName = "Invdet_FechaCaducidad";
                DataGridTextBoxColumn6.HeaderText = "Fecha Venc.";
                DataGridTextBoxColumn6.Width = 90;
                dgts.GridColumnStyles.Add(DataGridTextBoxColumn6);
            }

            DataGridTextBoxColumn DataGridTextBoxColumn3 = new DataGridTextBoxColumn();
            DataGridTextBoxColumn3.MappingName = "Invdet_Cantidad";
            DataGridTextBoxColumn3.HeaderText = "Cantidad";
            DataGridTextBoxColumn3.Width = 90;
            dgts.GridColumnStyles.Add(DataGridTextBoxColumn3);

            this.dgInventarioDet.TableStyles.Clear();
            this.dgInventarioDet.TableStyles.Add(dgts);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void txtCodigo_PressEnter(object sender, EventArgs e)
        {
            if (esEquipo)
            {
                this.txtSerie.Focus();
            }
            else if (esPerecible)
            {
                this.txtNoLote.Focus();
            }
            else
            {
                Agregar();
            }
        }

        private void txtSerie_PressEnter(object sender, EventArgs e)
        {
            if (esEquipo)
            {
                Agregar();
            }
        }


        private void txtNoLote_PressEnter(object sender, EventArgs e)
        {
            if (esPerecible)
            {
                this.dtpFecVenc.Focus();
            }
        }

        private void dtpFecVenc_PressEnter(object sender, EventArgs e)
        {
            if (esPerecible)
            {
                this.txtCantidad.Focus();
            }
        }

        private void txtCantidad_PressEnter(object sender, EventArgs e)
        {
            if (esPerecible)
            {
                Agregar();
            }
            else
            {
                txtCodigo.Focus();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.bsInventarioDet.Position = rowSelected;
            InventarioDet invdetCurrent = (InventarioDet)bsInventarioDet.Current;
            total = total - invdetCurrent.Invdet_Cantidad;
            if (total != 0)
            {
                bsInventarioDet.RemoveAt(rowSelected);
                Llenar_detalles();
                limpiar();
            }
        }

        private void dgInventarioDet_CurrentCellChanged(object sender, EventArgs e)
        {
            rowSelected = this.dgInventarioDet.CurrentCell.RowNumber;
        }

        private void miGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DateTime.Now.ToString("HH") + "H" + DateTime.Now.ToString("mm"));
            string nombreArchivo;
            if (esEquipo) 
            {
                nombreArchivo = "invEq" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString()
                    + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("HH") + "H" + 
                    DateTime.Now.ToString("mm") + ".xml";
            } 
            else if (esPerecible) 
            {
                nombreArchivo = "invProdPerec" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString()
                    + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("HH") + "H" +
                    DateTime.Now.ToString("mm") + ".xml";
            } 
            else 
            {
                nombreArchivo = "invProd" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString()
                    + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.ToString("HH") + "H" +
                    DateTime.Now.ToString("mm") + ".xml";
            }

            string file = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, 
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + 
                nombreArchivo;

            XDocument doc = new XDocument();

            XElement xRoot = new XElement("Root");
            doc.Add(xRoot);
            foreach (InventarioDet invdet in listaInventarioDet)
            {
                XElement xInvdet = new XElement("Item");
                
                XElement xItem_Codigo = new XElement("Codigo");
                xItem_Codigo.SetValue(invdet.Item_Codigo);
                xInvdet.Add(xItem_Codigo);

                if (esEquipo)
                {
                    XElement xInvdet_Serie = new XElement("Serie");
                    xInvdet_Serie.SetValue(invdet.Invdet_Serie);
                    xInvdet.Add(xInvdet_Serie);
                }

                if (esPerecible)
                {
                    XElement xInvdet_NoLote = new XElement("NoLote");
                    xInvdet_NoLote.SetValue(invdet.Invdet_NoLote);
                    xInvdet.Add(xInvdet_NoLote);

                    XElement xInvdet_FechaCaducidad = new XElement("FechaVencimiento");
                    xInvdet_FechaCaducidad.SetValue(invdet.Invdet_FechaCaducidad);
                    xInvdet.Add(xInvdet_FechaCaducidad);
                }

                XElement xInvdet_Cantidad = new XElement("Cantidad");
                xInvdet_Cantidad.SetValue(invdet.Invdet_Cantidad);
                xInvdet.Add(xInvdet_Cantidad);

                XElement xInvdet_FechaHoraRegistro = new XElement("FechaHoraRegistro");
                xInvdet_FechaHoraRegistro.SetValue(invdet.Invdet_FechaHoraRegistro.ToString());
                xInvdet.Add(xInvdet_FechaHoraRegistro);

                xRoot.Add(xInvdet);
            }
            doc.Save(file);
            MessageBox.Show("Se ha guardado correctamente el archivo.");
            this.Close();
        }


    }
}