using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivosFijos.Integration.DMiro.Data;
using ActivosFijos.Integration.DMiro.TopazMiddleWare;
using ActivosFijos.Integration.DMiro.WSDMiro;
using ActivosFijos.Reglas;
using ActivosFijos.Integration.DMiro.Util;

namespace ActivosFijos.Integration.DMiro
{
    public class Asiento
    {
        private static string usuario = "";
        public static string clave;
        private static int idsesion = 0;
        
        private static WSDMiro.TopazMiddleWareWSClient wsTopazMiddleware;
        private static WSDMiro.execute request = new WSDMiro.execute();
        private static WSDMiro.executeResponse response = new WSDMiro.executeResponse();

        public static bool Generar(DataTable ds, out string Result)
        {
            Result = null;
            /*var ws = new WSDMiro.TopazMiddleWareWSClient();
            

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
                    var cabresult = Cabecera(ws, asiento_app, anio, glosa, sistema);
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
            }*/

            return true;
        }

        public static void obtenerParametrosWS(WWTSParametroDet ParametroWS)
        {
            var crypto = new PDFco.Security.Cryptography.RijndaelCryptography();
            crypto.KeySize = 256;
            crypto.Key = System.Convert.FromBase64String("DaxnZbh41G4MZUL1ojySjZUP/vp7Me1ynsls8lQTCy8=");
            crypto.IV = System.Convert.FromBase64String("HHL9FfbG+xVcm16fFxYqRA==");
            usuario = ParametroWS.Pardet_DatoStr2;
            crypto.Decrypt(ParametroWS.Pardet_DatoStr3, out clave);
            idsesion = ParametroWS.Pardet_DatoInt1;
        }

        public static bool GenerarCabecera(DataTable ds, out string Result, out string NumeroAsiento, WWTSParametroDet ParametroWS)
        {
            Result = null;
            NumeroAsiento = null;

            var remoteAdd = new System.ServiceModel.EndpointAddress(ParametroWS.Pardet_DatoStr1);
            wsTopazMiddleware = new TopazMiddleWareWSClient(new System.ServiceModel.BasicHttpBinding(), remoteAdd);
            //WSDMiro.TopazMiddleWareWSClient wsTopazMiddleware = new WSDMiro.TopazMiddleWareWSClient();
            obtenerParametrosWS(ParametroWS);

            var linea = 0;
            string asiento_app = "";
            int anio = 0;
            string glosa = "";
            string sistema = "";

            foreach (DataRow row in ds.Rows)
            {
                linea++;
                asiento_app = row[0].ToString();
                int.TryParse(row[1].ToString(), out anio);
                glosa = row[2].ToString();
                sistema = row[3].ToString();
            }

            try
            {
                xmlJBankExecutionParameters executeParameter = new xmlJBankExecutionParameters(usuario, clave, idsesion);
                CabeceraRequest cabeceraAsiento = new CabeceraRequest(asiento_app, anio, glosa, sistema);
                xmlJBankRequest requestObject = new xmlJBankRequest(cabeceraAsiento);
                //xmlJBankRequest requestObject = new xmlJBankRequest(cabeceraAsiento, "Sw_DmInsertaAsiento");
                CabeceraResponse.TopazMiddleWareResponse responseObject = new CabeceraResponse.TopazMiddleWareResponse();

                string xmlParameters = Util.Util.GetXMLFromObject(executeParameter);
                string xmlRequest = Util.Util.GetXMLFromObject(requestObject);

                //request.executionInfo = "<xmlJBankExecutionParameters><authentication><type/><userName>TOP</userName><password>1234miro</password><sessionID>1</sessionID></authentication><duplicatedControl><type/><sequenceID>"+ saldoCreditoReq.NumSecuencia +"</sequenceID></duplicatedControl></xmlJBankExecutionParameters>";
                request.executionInfo = xmlParameters;
                request.request = xmlRequest;

                response = wsTopazMiddleware.execute(request);

                responseObject = response.executeResult.Deserialize<CabeceraResponse.TopazMiddleWareResponse>();

                if (responseObject.ErrorCode != "0" || responseObject.Sw_DmInsertaAsientos.Sw_DmInsertaAsiento.Pn_asiento =="-1")
                {
                    Result = Result + string.Format("Error creando cabecera {0}. {1}. ", asiento_app, responseObject.Sw_DmInsertaAsientos.Sw_DmInsertaAsiento.Pv_error);
                    return false;
                }
                
                NumeroAsiento = responseObject.Sw_DmInsertaAsientos.Sw_DmInsertaAsiento.Pn_asiento;

                return true;
            }
            catch (Exception ex)
            {
                Result = ex.Message;
                return false;
            }
        }

        public static bool GenerarDetalle(DataTable ds, out string Result, WWTSParametroDet ParametroWS)
        {
            Result = null;
            bool TodoOk = true;

            var remoteAdd = new System.ServiceModel.EndpointAddress(ParametroWS.Pardet_DatoStr1);
            wsTopazMiddleware = new TopazMiddleWareWSClient(new System.ServiceModel.BasicHttpBinding(), remoteAdd);
            //WSDMiro.TopazMiddleWareWSClient wsTopazMiddleware = new WSDMiro.TopazMiddleWareWSClient();
            obtenerParametrosWS(ParametroWS);



            obtenerParametrosWS(ParametroWS);
            
            int asiento = 0;
            var linea = 0;
            try
            {
                xmlJBankExecutionParameters executeParameter = new xmlJBankExecutionParameters(usuario, clave, idsesion);
                string asientoApp="---";
                int anio=0;
                string sistema="IFA 2";

                foreach (DataRow row in ds.Rows)
                {
                    linea++;
                    int.TryParse(row[0].ToString(), out asiento);
                    int.TryParse(row[1].ToString(), out int sucursal);
                    long.TryParse(row[2].ToString(), out long ctactble);
                    int.TryParse(row[3].ToString(), out int ctocostos);
                    string debitoCredito = row[4].ToString();
                    string glosadet = row[5].ToString();
                    decimal.TryParse(row[6].ToString(), out decimal monto);
                    asientoApp = row[7].ToString();
                    int.TryParse(row[8].ToString(), out anio);
                    sistema = row[9].ToString();


                    DetalleRequest detalleRequest = new DetalleRequest(asiento, sucursal, ctactble, ctocostos, debitoCredito, glosadet, monto);
                    xmlJBankRequest requestDetalle = new xmlJBankRequest(detalleRequest);
                    DetalleResponse.TopazMiddleWareResponse detalleResponse = new DetalleResponse.TopazMiddleWareResponse();
                    
                    request.executionInfo = Util.Util.GetXMLFromObject(executeParameter);
                    request.request = Util.Util.GetXMLFromObject(requestDetalle);

                    response = wsTopazMiddleware.execute(request);

                    detalleResponse = response.executeResult.Deserialize<DetalleResponse.TopazMiddleWareResponse>();


                    if (detalleResponse.Sw_DmInsertaDetalles.Sw_DmInsertaDetalle.Pn_error != "0")
                    {
                        Result = Result + string.Format("Error creando detalle linea {0} de asiento {1}. {2}. ", linea, asiento.ToString(), detalleResponse.Sw_DmInsertaDetalles.Sw_DmInsertaDetalle.Pv_error);
                        TodoOk= false;
                        break;
                    }
                }
                
                if (!TodoOk)
                {
                    AnulaRequest anulaRequest = new AnulaRequest(asientoApp, anio, asiento, sistema);
                    xmlJBankRequest requestAnula = new xmlJBankRequest(anulaRequest);
                    AnulaResponse.TopazMiddleWareResponse anulaResponse = new AnulaResponse.TopazMiddleWareResponse();

                    request.executionInfo = Util.Util.GetXMLFromObject(executeParameter);
                    request.request = Util.Util.GetXMLFromObject(requestAnula);

                    response = wsTopazMiddleware.execute(request);

                    anulaResponse = response.executeResult.Deserialize<AnulaResponse.TopazMiddleWareResponse>();
                    
                    if (anulaResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pn_error != "0")
                    {
                        Result = Result + string.Format("Error anulando asiento {0}. {1}. ", asiento.ToString(), anulaResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pv_error);
                    }
                    return false;
                }
                else
                {
                    CierreRequest cierreRequest = new CierreRequest(asiento);
                    xmlJBankRequest requestCierre = new xmlJBankRequest(cierreRequest);
                    CierreResponse.TopazMiddleWareResponse cierreResponse = new CierreResponse.TopazMiddleWareResponse();


                    request.executionInfo = Util.Util.GetXMLFromObject(executeParameter);
                    request.request = Util.Util.GetXMLFromObject(requestCierre);

                    response = wsTopazMiddleware.execute(request);

                    cierreResponse = response.executeResult.Deserialize<CierreResponse.TopazMiddleWareResponse>();

                    if (cierreResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pn_error != "0")
                    {
                        Result = Result + string.Format("Error cerrando cabecera {0}. {1}. ", asiento.ToString(), cierreResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pv_error);
                        TodoOk = false;
                        AnulaRequest anulaRequest = new AnulaRequest(asientoApp, anio, asiento, sistema);
                        xmlJBankRequest requestAnula = new xmlJBankRequest(anulaRequest);
                        AnulaResponse.TopazMiddleWareResponse anulaResponse = new AnulaResponse.TopazMiddleWareResponse();

                        request.executionInfo = Util.Util.GetXMLFromObject(executeParameter);
                        request.request = Util.Util.GetXMLFromObject(requestAnula);

                        response = wsTopazMiddleware.execute(request);

                        anulaResponse = response.executeResult.Deserialize<AnulaResponse.TopazMiddleWareResponse>();

                        if (anulaResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pn_error != "0")
                        {
                            Result = Result + string.Format("Error anulando asiento {0}. {1}. ", asiento.ToString(), anulaResponse.Sw_DmCierreAsientos.Sw_DmCierreAsiento.Pv_error);
                        }
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Result = ex.Message;
                return false;
            }
        }
        
        
        private static AutenticacionRequest.XmlJBankExecutionParameters obtenerAutenticacion()
        {
            var autenticacion = new AutenticacionRequest.XmlJBankExecutionParameters();

            autenticacion.Authentication = new AutenticacionRequest.Authentication()
            {
                Type = " ",
                UserName = usuario,
                Password = clave,
                SessionID = idsesion.ToString()
            };

            return autenticacion;
        }
    }
}
