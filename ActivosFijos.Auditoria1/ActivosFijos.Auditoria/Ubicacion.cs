using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace InventoryCount.SmartDevice
{
    public class Ubicacion
    {
        private int mParame_Ubicacion;
        private int mPardet_Ubicacion;
        private String mUbicac_Codigo;
        private String mUbicac_Descripcion;
        private Bodega mbodega;

        public Ubicacion(int _mParame_Ubicacion, int _mPardet_Ubicacion, String _mUbicac_Codigo, String _mUbicac_Descripcion, Bodega _bodega)
        {
            this.mParame_Ubicacion = _mParame_Ubicacion;
            this.mPardet_Ubicacion = _mPardet_Ubicacion;
            this.mUbicac_Codigo = _mUbicac_Codigo;
            this.mUbicac_Descripcion = _mUbicac_Descripcion;
            this.mbodega = _bodega;
        }

        public int Parame_Ubicacion{
            get { return this.mParame_Ubicacion; }
            set { this.mParame_Ubicacion = value; }
        }

        public int Pardet_Ubicacion
        {
            get { return this.mPardet_Ubicacion; }
            set { this.mPardet_Ubicacion = value; }
        }

        public String Ubicac_Codigo
        {
            get { return this.mUbicac_Codigo; }
            set { this.mUbicac_Codigo = value; }
        }

        public String Ubicac_Descripcion
        {
            get { return this.mUbicac_Descripcion; }
            set { this.mUbicac_Descripcion = value; }
        }

        public Bodega Bodega 
        {
            get { return this.mbodega; }
            set { this.mbodega = value; }
        }
    }
}
