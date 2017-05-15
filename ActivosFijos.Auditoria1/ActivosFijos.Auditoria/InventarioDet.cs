using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCount.SmartDevice
{
    class InventarioDet
    {
        private String mItem_Codigo;
        private int mInvdet_Cantidad;
        private String mInvdet_Serie;
        private String mInvdet_NoLote;
        private DateTime mInvdet_FechaCaducidad;
        private DateTime mInvdet_FechaHoraRegistro;
        

        public InventarioDet(String _Item_Codigo, int _Invdet_Cantidad)
        {
            this.mItem_Codigo = _Item_Codigo;
            this.mInvdet_Cantidad = _Invdet_Cantidad;
            this.mInvdet_FechaHoraRegistro = DateTime.Now;
        }

        public InventarioDet (String _Item_Codigo, String _Invdet_Serie, int _Invdet_Cantidad)
        {
            this.mItem_Codigo = _Item_Codigo;
            this.mInvdet_Serie = _Invdet_Serie;
            this.mInvdet_Cantidad = _Invdet_Cantidad;
            this.mInvdet_FechaHoraRegistro = DateTime.Now;
        }

        public InventarioDet(String _Item_Codigo, int _Invdet_Cantidad, String _Invdet_NoLote, DateTime _Invdet_FechaCaducidad)
        {
            this.mItem_Codigo = _Item_Codigo;
            this.mInvdet_Cantidad = _Invdet_Cantidad;
            this.mInvdet_NoLote = _Invdet_NoLote;
            this.mInvdet_FechaCaducidad = _Invdet_FechaCaducidad;
            this.mInvdet_FechaHoraRegistro = DateTime.Now;
        }

        public string Item_Codigo
        {
            get
            {
                return this.mItem_Codigo;
            }
            set
            {
                this.mItem_Codigo = value;
            }
        }

        public int Invdet_Cantidad
        {
            get
            {
                return this.mInvdet_Cantidad;
            }
            set
            {
                this.mInvdet_Cantidad = value;
            }
        }

        public string Invdet_Serie
        {
            get
            {
                return this.mInvdet_Serie;
            }
            set
            {
                this.mInvdet_Serie = value;
            }
        }

        public String Invdet_NoLote
        {
            get
            {
                return this.mInvdet_NoLote;
            }
            set
            {
                this.mInvdet_NoLote = value;
            }
        }

        public DateTime Invdet_FechaCaducidad
        {
            get
            {
                return this.mInvdet_FechaCaducidad;
            }
            set
            {
                this.mInvdet_FechaCaducidad = value;
            }
        }

        public DateTime Invdet_FechaHoraRegistro
        {
            get
            {
                return this.mInvdet_FechaHoraRegistro;
            }
            set
            {
                this.mInvdet_FechaHoraRegistro = value;
            }
        }
    }
}
