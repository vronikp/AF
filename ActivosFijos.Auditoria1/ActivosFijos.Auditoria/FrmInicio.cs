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
using System.Xml;
using System.IO;

namespace InventoryCount.SmartDevice
{
    public partial class FrmInicio : Form
    {
        public string ArchivoConfiguracion { get; set; }
        public string mUsuario;
        public List<Bodega> listaBodega = new List<Bodega>();
        public List<Ubicacion> listaUbicacion = new List<Ubicacion>();
        private bool estaActualizado = false;
        private bool esPressEnterTxtUbi = false;
        private bool esCambioCboBodega = false;

        public FrmInicio()
        {
            InitializeComponent();
            
            CargarCombos();
        }



        private void btnInvProd_Click(object sender, EventArgs e)
        {
            if (cboBodega.SelectedItem != null && this.listUbicacion.SelectedItem != null)
            {
                FrmInventario f = new FrmInventario(false, false, (Bodega)cboBodega.SelectedItem, (Ubicacion)listUbicacion.SelectedItem);
                f.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Seleccione una bodega y una ubicacion para iniciar con el inventario.");
            }
            
        }

        private void btnInvEq_Click(object sender, EventArgs e)
        {
            if (cboBodega.SelectedItem != null && this.listUbicacion.SelectedItem != null)
            {
                FrmInventario f = new FrmInventario(true, false, (Bodega)cboBodega.SelectedItem, (Ubicacion)listUbicacion.SelectedItem);
                f.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Seleccione una bodega y una ubicacion para iniciar con el inventario.");
            }
        }

        private void btnProdPerec_Click(object sender, EventArgs e)
        {
            if (cboBodega.SelectedItem != null && this.listUbicacion.SelectedItem != null)
            {
                FrmInventario f = new FrmInventario(false, true, (Bodega)cboBodega.SelectedItem, (Ubicacion)listUbicacion.SelectedItem);
                f.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Seleccione una bodega y una ubicacion para iniciar con el inventario.");
            }
        }

        private void miActualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
            CargarCombos();
        }

        private void Actualizar()
        {
            ArchivoConfiguracion = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0,
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "ic.xml";

            try
            {
                XDocument doc = XDocument.Load(ArchivoConfiguracion);
                XElement root = doc.Element("Root");
                XElement usuarios = root.Element("Usuarios");
                mUsuario = usuarios.Value.ToString();
                
                XElement bodegas = root.Element("Bodegas");
                var resultBodegas = from bodega in bodegas.Elements("Bodega")
                             select new
                             {
                                 Empres_Codigo = bodega.Element("Empres_Codigo").Value,
                                 Sucurs_Codigo = bodega.Element("Sucurs_Codigo").Value,
                                 Bodega_Codigo = bodega.Element("Bodega_Codigo").Value,
                                 Bodega_Nombre = bodega.Element("Bodega_Nombre").Value
                             };
                listaBodega.Clear();
                foreach (var bodega in resultBodegas)
                {
                    listaBodega.Add(new Bodega(Convert.ToInt32(bodega.Empres_Codigo.ToString()),
                        Convert.ToInt32(bodega.Sucurs_Codigo.ToString()), Convert.ToInt32(bodega.Bodega_Codigo.ToString()),
                        bodega.Bodega_Nombre.ToString()));
                }
                
                XElement ubicaciones = root.Element("Ubicaciones");
                var resultUbicaciones = from ubicacion in ubicaciones.Elements("Ubicacion")
                             select new
                             {
                                 Parame_Ubicacion = ubicacion.Element("Parame_Ubicacion").Value,
                                 Pardet_Ubicacion = ubicacion.Element("Pardet_Ubicacion").Value,
                                 Ubicac_Codigo = ubicacion.Element("Ubicac_Codigo").Value,
                                 Ubicac_Descripcion = ubicacion.Element("Ubicac_Descripcion").Value,
                                 Empres_Codigo = ubicacion.Element("Empres_Codigo").Value,
                                 Sucurs_Codigo = ubicacion.Element("Sucurs_Codigo").Value,
                                 Bodega_Codigo = ubicacion.Element("Bodega_Codigo").Value
                             };
                foreach (var ubi in resultUbicaciones)
                {
                    Bodega bod = buscarBodega(Convert.ToInt32(ubi.Empres_Codigo.ToString()),
                        Convert.ToInt32(ubi.Sucurs_Codigo.ToString()),
                        Convert.ToInt32(ubi.Bodega_Codigo.ToString()));
                    if (bod!= null)
                    {
                        listaUbicacion.Add(new Ubicacion(Convert.ToInt32(ubi.Parame_Ubicacion.ToString()),
                            Convert.ToInt32(ubi.Pardet_Ubicacion.ToString()), ubi.Ubicac_Codigo.ToString(),
                            ubi.Ubicac_Descripcion.ToString(), bod));
                    }                    
                }
                
                estaActualizado = true;

            }
            catch { }
        }
        private void CargarCombos()
        {
            if (estaActualizado)
            {
                //cboBodega.Items.Clear();
                cboBodega.DataSource = listaBodega;
                cboBodega.DisplayMember = "Bodega_Nombre";
            }
        }

        private Bodega buscarBodega(int _Empres_Codigo, int _Sucurs_Codigo, int _Bodega_Codigo)
        {
            foreach (Bodega bodega in listaBodega)
            {
                if (bodega.Empres_Codigo == _Empres_Codigo &&
                    bodega.Sucrus_Codigo == _Sucurs_Codigo && bodega.Bodega_Codigo == _Bodega_Codigo)
                {
                    return bodega;
                }
            }
            return null;
        }

        private List<Ubicacion> buscarUbicaciones() 
        {
            List<Ubicacion> listaUbiAct = new List<Ubicacion>();
            Bodega bodega = (Bodega)cboBodega.SelectedItem;
            String codigo = txtBuscarCodUbi.Text;

            foreach (Ubicacion ubicacion in listaUbicacion)
            {
                if (esCambioCboBodega)
                {
                    if (bodega != null && bodega == ubicacion.Bodega)
                    {
                        listaUbiAct.Add(ubicacion);
                    }
                }
                else if(esPressEnterTxtUbi)
                {
                    if (bodega!=null && bodega==ubicacion.Bodega && ubicacion.Ubicac_Codigo == codigo)
                    {
                        listaUbiAct.Add(ubicacion);
                    }
                }
                
            }
            
            return listaUbiAct;
        }

        private void cboBodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            esCambioCboBodega = true;
            this.listUbicacion.DataSource = buscarUbicaciones();
            this.listUbicacion.DisplayMember = "Ubicac_Descripcion";
            esCambioCboBodega = false;
            
        }

        private void txtBuscarCodUbi_PressEnter(object sender, EventArgs e)
        {
            //this.listUbicacion.DataSource = null;
            esPressEnterTxtUbi = true;
            this.listUbicacion.DataSource = buscarUbicaciones();
            this.listUbicacion.DisplayMember = "Ubicac_Descripcion";
            esPressEnterTxtUbi = false;
        }
    }

    
}