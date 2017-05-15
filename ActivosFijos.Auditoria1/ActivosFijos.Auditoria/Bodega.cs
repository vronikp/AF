using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCount.SmartDevice
{
    public class Bodega
    {
        private int mEmpres_Codigo;
        private int mSucurs_Codigo;
        private int mBodega_Codigo;
        private String mBodega_Nombre;

        public Bodega(int _Empres_Codigo, int _mSucurs_Codigo, int _mBodega_Codigo, String _mBodega_Nombre) 
        {
            this.mEmpres_Codigo = _Empres_Codigo;
            this.mSucurs_Codigo = _mSucurs_Codigo;
            this.mBodega_Codigo = _mBodega_Codigo;
            this.mBodega_Nombre = _mBodega_Nombre;
        }

        public int Empres_Codigo
        {
            get { return this.mEmpres_Codigo; }
            set { this.mEmpres_Codigo = value; }
        }

        public int Sucrus_Codigo
        {
            get { return this.mSucurs_Codigo; }
            set { this.mSucurs_Codigo = value; }
        }
        
        public int Bodega_Codigo
        {
            get { return this.mBodega_Codigo; }
            set { this.mBodega_Codigo = value; }
        }

        public String Bodega_Nombre
        {
            get { return this.mBodega_Nombre; }
            set { this.mBodega_Nombre = value; }
        }
    }
}
