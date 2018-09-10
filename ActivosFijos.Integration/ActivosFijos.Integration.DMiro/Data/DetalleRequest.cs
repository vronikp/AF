using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivosFijos.Integration.DMiro.Data
{
    public class DetalleRequest
    {
        public int pn_asiento { get; set; }
        public int pn_sucursal { get; set; }
        public long pn_cta_contable { get; set; }
        public int pn_ctro_costo { get; set; }
        public string pv_debito_credito { get; set; }
        public string pv_glosa { get; set; }
        public Decimal pn_monto { get; set; }

        public DetalleRequest() { }

        public DetalleRequest(int _pn_asiento, int _pn_sucursal, long _pn_cta_contable, int _pn_ctro_costo, string _pv_debito_credit, string _pv_glosa, Decimal _pn_monto)
        {
            this.pn_asiento = _pn_asiento;
            this.pn_sucursal = _pn_sucursal;
            this.pn_cta_contable = _pn_cta_contable;
            this.pn_ctro_costo = _pn_ctro_costo;
            this.pv_debito_credito = _pv_debito_credit;
            this.pv_glosa = _pv_glosa;
            this.pn_monto = _pn_monto;
        }
    }
}
