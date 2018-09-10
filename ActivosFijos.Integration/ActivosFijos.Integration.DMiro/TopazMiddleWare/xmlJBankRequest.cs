using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivosFijos.Integration.DMiro.Data;

namespace ActivosFijos.Integration.DMiro.TopazMiddleWare
{
    public class xmlJBankRequest
    {
        public xmlJBankService xmlJBankService { get; set; }

        public xmlJBankRequest() { }

        public xmlJBankRequest(CabeceraRequest cabeceraAsiento)
        {
            this.xmlJBankService = new xmlJBankService(cabeceraAsiento);
        }

        public xmlJBankRequest(DetalleRequest detalleRequest)
        {
            this.xmlJBankService = new xmlJBankService(detalleRequest);
        }

        public xmlJBankRequest(CierreRequest cierreRequest)
        {
            this.xmlJBankService = new xmlJBankService(cierreRequest);
        }

        public xmlJBankRequest(AnulaRequest anulaRequest)
        {
            this.xmlJBankService = new xmlJBankService(anulaRequest);
        }

        public xmlJBankRequest(Object _obj, string _serviceName)
        {
            this.xmlJBankService = new xmlJBankService(_obj, _serviceName);
        }
    }

    public class xmlJBankService
    {
        public String serviceName { get; set; }
        public List<xmlJBankField> xmlJBankFields { get; set; }

        public xmlJBankService() { }

        public xmlJBankService(CabeceraRequest cabeceraAsiento)
        {
            this.serviceName = "Sw_DmInsertaAsiento";
            List<xmlJBankField> listFields = new List<xmlJBankField>();
            foreach (var prop in cabeceraAsiento.GetType().GetProperties())
            {
                listFields.Add(new xmlJBankField() { fieldName = prop.Name, fieldValue = prop.GetValue(cabeceraAsiento).ToString() });
            }
            this.xmlJBankFields = listFields;
        }

        public xmlJBankService(DetalleRequest detalleRequest)
        {
            this.serviceName = "Sw_DmInsertaDetalle";
            List<xmlJBankField> listFields = new List<xmlJBankField>();
            foreach (var prop in detalleRequest.GetType().GetProperties())
            {
                listFields.Add(new xmlJBankField() { fieldName = prop.Name, fieldValue = prop.GetValue(detalleRequest).ToString() });
            }
            this.xmlJBankFields = listFields;
        }

        public xmlJBankService(CierreRequest cierreRequest)
        {
            this.serviceName = "Sw_DmCierreAsiento";
            List<xmlJBankField> listFields = new List<xmlJBankField>();
            foreach (var prop in cierreRequest.GetType().GetProperties())
            {
                listFields.Add(new xmlJBankField() { fieldName = prop.Name, fieldValue = prop.GetValue(cierreRequest).ToString() });
            }
            this.xmlJBankFields = listFields;
        }

        public xmlJBankService(AnulaRequest anulaRequest)
        {
            this.serviceName = "Sw_DmAnulaAsiento";
            List<xmlJBankField> listFields = new List<xmlJBankField>();
            foreach (var prop in anulaRequest.GetType().GetProperties())
            {
                listFields.Add(new xmlJBankField() { fieldName = prop.Name, fieldValue = prop.GetValue(anulaRequest).ToString() });
            }
            this.xmlJBankFields = listFields;
        }
        public xmlJBankService(Object _obj, string _serviceName)
        {
            this.serviceName = _serviceName;
            List<xmlJBankField> listFields = new List<xmlJBankField>();
            foreach (var prop in _obj.GetType().GetProperties())
            {
                listFields.Add(new xmlJBankField() { fieldName = prop.Name, fieldValue = prop.GetValue(_serviceName).ToString() });
            }
            this.xmlJBankFields = listFields;
        }
    }

    public class xmlJBankField
    {
        public String fieldName { get; set; }
        public String fieldValue { get; set; }
    }
}
