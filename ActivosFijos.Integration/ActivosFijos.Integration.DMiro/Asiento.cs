using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivosFijos.Integration.DMiro.Data;
using ActivosFijos.Integration.DMiro.WSDMiro;

namespace ActivosFijos.Integration.DMiro
{
    public class Asiento
    {
        public static bool Generar(DataTable ds, out string Result)
        {
            Result = null;
            var ws = new WSDMiro.TopazMiddleWareWSClient();

            string asiento_app_anterior = "----";
            var asientos = new List<AsientoApp>();
            var linea = 0;
            foreach (DataRow row in ds.Rows)
            {
                linea++;
                int.TryParse(row[0].ToString(), out int anio);
                string asiento_app = row[1].ToString();
                string glosa = row[2].ToString();
                string sistema = row[3].ToString();
                string sucursal = row[4].ToString();
                string ctactble = row[5].ToString();
                string ctocostos = row[6].ToString();
                bool.TryParse(row[7].ToString(), out bool esDebito);
                string glosadet = row[8].ToString();
                decimal.TryParse(row[9].ToString(), out decimal monto);

                string asiento = "";
                if (!asiento_app_anterior.Equals(asiento_app))
                {
                    var cabresult = Cabecera(ws, anio, asiento_app, glosa, sistema);
                    if (cabresult.ErrorCode != "0")
                    {
                        Result = Result + string.Format("Error creando cabecera {0}. {1}. ", asiento_app, cabresult.Error);
                        return false;
                    }
                    asiento = cabresult.Sw_DmInsertaAsientos.Sw_DmInsertaAsiento.Pn_asiento;
                    asientos.Add(
                        new AsientoApp()
                        {
                            pn_asiento = asiento,
                            EsCerrado = false
                        }
                    );
                }

                var detresult = Detalle(ws, asiento, sucursal, ctactble, ctocostos, esDebito, glosadet, monto);
                if (detresult.ErrorCode != "0")
                {
                    Result = Result + string.Format("Error creando detalle linea {0} de cabecera {1}. {2}. ", linea, asiento_app, detresult.Error);
                    return false;
                }
            }

            bool TodoOk = true;
            foreach(var asiento in asientos)
            {
                var cierreresult = Cierre(ws, asiento.pn_asiento);
                if (cierreresult.ErrorCode != "0")
                {
                    Result = Result + string.Format("Error cerrando cabecera {0}. {1}. ", asiento.pn_asiento, cierreresult.Error);
                    TodoOk = false;
                    break;
                }
                else
                {
                    asiento.EsCerrado = true;
                }
            }

            if (!TodoOk)
            {
                foreach (var asiento in asientos)
                {
                    //if (asiento.EsCerrado)
                    //{
                    //TODO: Verificar si se deben anular todos los asientos abiertos o solo los que se cerraron exitosamente
                    //}
                    var anularesult = Anula(ws, asiento.pn_asiento);
                    if (anularesult.ErrorCode != "0")
                    {
                        Result = Result + string.Format("Error anulando asiento {0}. {1}. ", asiento.pn_asiento, anularesult.Error);
                    }
                }
            }

            return true;
        }

        private static AnulaResponse.TopazMiddleWareResponse Anula(TopazMiddleWareWSClient ws, string asiento)
        {
            var transaccion = new AnulaRequest.XmlJBankRequest()
            {
                XmlJBankService = new AnulaRequest.XmlJBankService()
                {
                    ServiceName = "Sw_DmAnulaAsiento",
                    XmlJBankFields = new AnulaRequest.XmlJBankFields()
                    {
                        XmlJBankField = new List<AnulaRequest.XmlJBankField>()
                    }
                }
            };

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new AnulaRequest.XmlJBankField()
                {
                    FieldName = "pv_asiento_app",
                    FieldValue = ""
                }
            );

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new AnulaRequest.XmlJBankField()
                {
                    FieldName = "pn_anio",
                    FieldValue = ""
                }
            );

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new AnulaRequest.XmlJBankField()
                {
                    FieldName = "pn_asiento",
                    FieldValue = asiento
                }
            );

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new AnulaRequest.XmlJBankField()
                {
                    FieldName = "pv_sistema",
                    FieldValue = ""
                }
            );

            var transaccionResponse = ws.execute(
                new WSDMiro.execute()
                {
                    request = transaccion.Serialize()
                }
            );

            return transaccionResponse.executeResult.Deserialize<AnulaResponse.TopazMiddleWareResponse>();
        }

        private static CierreResponse.TopazMiddleWareResponse Cierre(TopazMiddleWareWSClient ws, string asiento)
        {
            var transaccion = new CierreRequest.XmlJBankRequest()
            {
                XmlJBankService = new CierreRequest.XmlJBankService()
                {
                    ServiceName = "Sw_DmCierreAsiento",
                    XmlJBankFields = new CierreRequest.XmlJBankFields()
                    {
                        XmlJBankField = new List<CierreRequest.XmlJBankField>()
                    }
                }
            };

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new CierreRequest.XmlJBankField()
                {
                    FieldName = "pn_asiento",
                    FieldValue = asiento
                }
            );

            var transaccionResponse = ws.execute(
                new WSDMiro.execute()
                {
                    request = transaccion.Serialize()
                }
            );

            return transaccionResponse.executeResult.Deserialize<CierreResponse.TopazMiddleWareResponse>();
        }

        private static DetalleResponse.TopazMiddleWareResponse Detalle(TopazMiddleWareWSClient ws, 
            string asiento, string sucursal, string ctactble, string ctocostos, Boolean esDebito,
            string glosa, decimal monto)
        {
            var transaction = new DetalleRequest.XmlJBankRequest()
            {
                XmlJBankService = new DetalleRequest.XmlJBankService()
                {
                    ServiceName = "Sw_DmInsertaDetalle",
                    XmlJBankFields = new DetalleRequest.XmlJBankFields()
                    {
                        XmlJBankField = new List<DetalleRequest.XmlJBankField>()
                    }
                }
            };

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new DetalleRequest.XmlJBankField()
                {
                    FieldName = "pn_asiento",
                    FieldValue = asiento
                }
            );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pn_sucursal",
                     FieldValue = sucursal
                 }
             );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pn_cta_contable",
                     FieldValue = ctactble
                 }
             );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pn_ctro_costo",
                     FieldValue = ctocostos
                 }
             );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pv_debito_credito",
                     FieldValue = esDebito ? "D" : "C"
                 }
             );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pv_glosa",
                     FieldValue = glosa
                 }
             );

            transaction.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                 new DetalleRequest.XmlJBankField()
                 {
                     FieldName = "pn_monto",
                     FieldValue = monto.ToString("0.00")
                 }
             );

            var detalleResponse = ws.execute(
                new WSDMiro.execute()
                {
                    request = transaction.Serialize()
                }
            );

            return detalleResponse.executeResult.Deserialize<DetalleResponse.TopazMiddleWareResponse>();
        }

        private static CabeceraResponse.TopazMiddleWareResponse Cabecera(WSDMiro.TopazMiddleWareWSClient ws, int anio, string asiento_app, string glosa, string sistema)
        {
            var transaccion = new CabeceraRequest.XmlJBankRequest()
            {
                XmlJBankService = new CabeceraRequest.XmlJBankService()
                {
                    ServiceName = "Sw_DmInsertaAsiento",
                    XmlJBankFields = new CabeceraRequest.XmlJBankFields()
                    {
                        XmlJBankField = new List<CabeceraRequest.XmlJBankField>()
                    }
                }
            };

            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new CabeceraRequest.XmlJBankField()
                {
                    FieldName = "pv_asiento_app",
                    FieldValue = asiento_app
                }
            );
            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new CabeceraRequest.XmlJBankField()
                {
                    FieldName = "pn_anio",
                    FieldValue = anio.ToString()
                }
            );
            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new CabeceraRequest.XmlJBankField()
                {
                    FieldName = "pv_glosa",
                    FieldValue = glosa
                }
            );
            transaccion.XmlJBankService.XmlJBankFields.XmlJBankField.Add(
                new CabeceraRequest.XmlJBankField()
                {
                    FieldName = "pv_sistema",
                    FieldValue = sistema
                }
            );

            var transaccionResponse = ws.execute(
                new WSDMiro.execute()
                {
                    request = transaccion.Serialize()
                }
            );

            return transaccionResponse.executeResult.Deserialize<CabeceraResponse.TopazMiddleWareResponse>();
        }
    }
}
