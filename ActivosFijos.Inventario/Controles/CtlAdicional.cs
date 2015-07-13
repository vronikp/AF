using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ActivosFijos.Controles
{
    public partial class CtlAdicional : UserControl
    {
        public CtlAdicional()
        {
            InitializeComponent();
        }

        private Caracteristica caracteristica;
        public void set_Caracteristica(Caracteristica caract)
        {
            caracteristica = caract;
            txtDescripcion.Text = caracteristica.ActCar_Descripcion;
            lblDescripcion.Text = caracteristica.CaracteristicaText;
        }

        public Caracteristica get_Catacteristica() {
            caracteristica.ActCar_Descripcion = txtDescripcion.Text;
            return caracteristica;
        }

        public int get_pardet_caracteristica() {
            if (caracteristica == null)
            {
                return 0;
            }
            return caracteristica.Pardet_Caracteristica;
        }
    }
}
