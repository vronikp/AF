using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml.Linq;
using System.ServiceModel;

namespace ActivosFijos
{
    class Carga
    {
        public string ArchivoCarga { get; set; }
        public List<Usuario> listaUsuarios = new List<Usuario>();
        public Usuario usuario;
        public Inventario inventario;

        public Carga()
        {
            Reload();
        }
        public void Reload()
        {
            ArchivoCarga = Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(0, 
                Assembly.GetExecutingAssembly().GetName().CodeBase.LastIndexOf('\\') + 1) + "inventario.xml"; 

        }

        public Boolean IniciarSesion(string _usuario)
        {
            Boolean result = false;
            _usuario = _usuario.PadRight(18, ' ');
            _usuario = _usuario.ToLower();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xUsuarios = xInventario.Element("Usuarios");
                var resultUsuario = from u in xUsuarios.Elements("Usuario")
                                    where u.Element("Usuari_Codigo").Value.ToString().Equals(_usuario)
                                    select new
                                    {
                                        Usuari_Codigo = u.Element("Usuari_Codigo").Value,
                                        Usuari_Descripcion = u.Element("Usuari_Descripcion").Value
                                    };
                //listaUsuarios.Clear();
                foreach (var u in resultUsuario)
                {
                    usuario = (new Usuario(u.Usuari_Codigo.ToString(),
                        u.Usuari_Descripcion.ToString()));
                    result= true;
                }

                XElement xPeriodo = xInventario.Element("Periodo");
                string parame = xPeriodo.Element("Parame_Codigo").Value;
                string parame2 = xPeriodo.Element("Parame_Codigo").ToString();

                Parametro periodo = new Parametro(Convert.ToInt32(xPeriodo.Element("Parame_Codigo").Value),
                                                Convert.ToInt32(xPeriodo.Element("Pardet_Secuencia").Value),
                                                xPeriodo.Element("Nombre").Value);
                XElement xUbicacion = xInventario.Element("UbicacionInv");
                Parametro ubicacion = new Parametro(Convert.ToInt32(xUbicacion.Element("Parame_Codigo").Value),
                                                Convert.ToInt32(xUbicacion.Element("Pardet_Secuencia").Value),
                                                xUbicacion.Element("Nombre").Value);
                inventario = new Inventario(periodo, ubicacion);
            }
            catch (Exception ex)
            {
                return false;
            }
            return result;
        }

        public List<Parametro> ListaUbicaciones()
        {
            List<Parametro> ubicaciones = new List<Parametro>();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xUbicaciones = xInventario.Element("Ubicaciones");
                var resultUbicaciones = from u in xUbicaciones.Elements("Ubicacion")
                                    select new
                                    {
                                        Parame_Codigo = u.Element("Parame_Codigo").Value,
                                        Pardet_Secuencia = u.Element("Pardet_Secuencia").Value,
                                        Nombre = u.Element("Nombre").Value
                                    };
                ubicaciones.Clear();
                foreach (var u in resultUbicaciones)
                {
                    ubicaciones.Add(new Parametro(Convert.ToInt32(u.Parame_Codigo.ToString()),
                        Convert.ToInt32(u.Pardet_Secuencia.ToString()),
                        u.Nombre.ToString()));
                }

               
            }
            catch (Exception ex)
            {
                ubicaciones.Clear();
            }

            return ubicaciones;
        }

        public List<Empleado> ListaEmpleados(string parcial)
        {
            List<Empleado> empleados = new List<Empleado>();
            parcial = parcial.ToUpper();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xEmpleados = xInventario.Element("Empleados");
                var resultEmpleados = from u in xEmpleados.Elements("Empleado")
                                      where u.Element("NombreCompleto").Value.ToString().Contains(parcial)
                                        select new
                                        {
                                            Emplea_Custodio = u.Element("Emplea_Custodio").Value,
                                            NombreCompleto = u.Element("NombreCompleto").Value,
                                            Identificacion = u.Element("Identificacion").Value
                                        };
                empleados.Clear();
                foreach (var e in resultEmpleados)
                {
                    empleados.Add(new Empleado(Convert.ToInt32(e.Emplea_Custodio.ToString()),
                        e.NombreCompleto.ToString(),
                        e.Identificacion.ToString()));
                }


            }
            catch (Exception ex)
            {
                empleados.Clear();
            }

            return empleados;
        }

        public List<Parametro> ListaEstados()
        {
            List<Parametro> estados = new List<Parametro>();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xEstados = xInventario.Element("Estados");
                var resultEstados = from u in xEstados.Elements("Estado")
                                      select new
                                      {
                                          Parame_Codigo = u.Element("Parame_Codigo").Value,
                                          Pardet_Secuencia = u.Element("Pardet_Secuencia").Value,
                                          Nombre = u.Element("Nombre").Value
                                      };
                estados.Clear();
                foreach (var e in resultEstados)
                {
                    estados.Add(new Parametro(Convert.ToInt32(e.Parame_Codigo.ToString()),
                        Convert.ToInt32(e.Pardet_Secuencia.ToString()),
                        e.Nombre.ToString()));
                }


            }
            catch (Exception ex)
            {
                estados.Clear();
            }

            return estados;
        }

        public Activo CargarActivo(string _codigoBarras, string _serie)
        {
            Activo activo = new Activo();
            _codigoBarras = _codigoBarras.ToUpper();
            _serie = _serie.ToUpper();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xActivos = xInventario.Element("Activos");
                IEnumerable<XElement> resultActivo;
                if (_codigoBarras != "" && _serie != "")
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                                         where u.Element("Serie").Value.ToString().Equals(_serie) &&
                                                         u.Element("Serie").Value.ToString().Equals(_serie)
                                                         select u;
                }
                else if (_codigoBarras == "" && _serie != "")
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("Serie").Value.ToString().Equals(_serie)
                                   select u;
                }
                if (_codigoBarras != "" && _serie == "")
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                                         where u.Element("CodigoBarras").Value.ToString().Equals(_codigoBarras)
                                                         select u;
                }
                else
                {
                    return null;
                }

                if (resultActivo.Count() == 0)
                {
                    return null;
                }
                foreach (XElement a in resultActivo)
                {
                    activo = new Activo(Convert.ToInt32(a.Element("Emplea_Custodio").Value.ToString()),
                        a.Element("Custodio").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_Ubicacion").Value.ToString()),
                        a.Element("Ubicacion").Value.ToString(),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioCustodio").Value.ToString())),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioUbicacion").Value.ToString())),
                        Convert.ToDateTime(a.Element("Usuari_FechaHoraRegistro").Value.ToString()),
                        a.Element("Usuari_CodigoPDA").Value.ToString(), a.Element("CodigoBarras").Value.ToString(),
                        a.Element("Clase").Value.ToString(), a.Element("Descripcion").Value.ToString(),
                        a.Element("Marca").Value.ToString(), a.Element("Modelo").Value.ToString(),
                        a.Element("Serie").Value.ToString(), 
                        Convert.ToInt32(a.Element("Pardet_EstadoActivo").Value.ToString()),
                        a.Element("EstadoActivo").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_EstadoInventario").Value.ToString()),
                        a.Element("EstadoInventario").Value.ToString());
                }
            }

            catch (Exception ex)
            {
                return null;
            }
            return activo;
        }

        public string GuardarInventarioDet(Usuario mUsuario, Activo mActivo)
        {
            string result = "";
            try
            {
                
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xActivos = xInventario.Element("Activos");
                IEnumerable<XElement> resultActivo;
                resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("CodigoBarras").Value.ToString().Equals(mActivo.CodigoBarras)
                                   select u;

                int asd = resultActivo.Count();
                foreach (XElement a in resultActivo)
                {
                    if (mActivo.InvDet_esCambioCustodio)
                    {
                        a.Element("Emplea_Custodio").Value = mActivo.Emplea_Custodio.ToString();
                        a.Element("Custodio").Value = mActivo.Custodio;
                        a.Element("InvDet_esCambioCustodio").Value = "1";
                    }
                    if (mActivo.InvDet_esCambioUbicacion)
                    {
                        a.Element("InvDet_esCambioUbicacion").Value = "1";
                        a.Element("Pardet_Ubicacion").Value = mActivo.Pardet_Ubicacion.ToString();
                        a.Element("Ubicacion").Value = mActivo.Ubicacion;
                    }

                    a.Element("Pardet_EstadoActivo").Value = mActivo.Pardet_EstadoActivo.ToString();
                    a.Element("EstadoActivo").Value = mActivo.EstadoActivo;
                    a.Element("Pardet_EstadoInventario").Value = "2";
                    a.Element("EstadoInventario").Value = "Inventariado";
                    a.Element("Usuari_FechaHoraRegistro").Value = DateTime.Now.ToString();
                    a.Element("Usuari_CodigoPDA").Value = mUsuario.Usuari_Codigo;
                    doc.Save(ArchivoCarga);
                }
            }

            catch (Exception ex)
            {
                result = ex.Message.ToString();
                return result;
            }
            return result;
        }

        public List<Activo> ListaActivos(Empleado eCustodio, Parametro pUbicacion, Boolean esSoloUbicacion, Boolean esSoloNoInventariados)
        {
            List<Activo> listaActivos = new List<Activo>();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xActivos = xInventario.Element("Activos");
                IEnumerable<XElement> resultActivo;
                if (esSoloUbicacion && esSoloNoInventariados)
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("Emplea_Custodio").Value.ToString().Equals(eCustodio.Emplea_Custodio.ToString()) &&
                                        u.Element("Pardet_Ubicacion").Value.ToString().Equals(pUbicacion.Pardet_Secuencia.ToString()) &&
                                        u.Element("Pardet_EstadoInventario").Value.ToString().Equals("1")
                                   select u;
                }
                else if (esSoloUbicacion)
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("Emplea_Custodio").Value.ToString().Equals(eCustodio.Emplea_Custodio.ToString()) &&
                                        u.Element("Pardet_Ubicacion").Value.ToString().Equals(pUbicacion.Pardet_Secuencia.ToString())
                                   select u;
                }
                else if (esSoloNoInventariados)
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("Emplea_Custodio").Value.ToString().Equals(eCustodio.Emplea_Custodio.ToString()) &&
                                        u.Element("Pardet_EstadoInventario").Value.ToString().Equals("1")
                                   select u;
                }
                else
                {
                    resultActivo = from u in xActivos.Elements("Activo")
                                   where u.Element("Emplea_Custodio").Value.ToString().Equals(eCustodio.Emplea_Custodio.ToString())
                                   select u;
                }

                int asd = resultActivo.Count();
                foreach (XElement a in resultActivo)
                {
                    listaActivos.Add(new Activo(Convert.ToInt32(a.Element("Emplea_Custodio").Value.ToString()),
                        a.Element("Custodio").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_Ubicacion").Value.ToString()),
                        a.Element("Ubicacion").Value.ToString(),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioCustodio").Value.ToString())),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioUbicacion").Value.ToString())),
                        Convert.ToDateTime(a.Element("Usuari_FechaHoraRegistro").Value.ToString()),
                        a.Element("Usuari_CodigoPDA").Value.ToString(), a.Element("CodigoBarras").Value.ToString(),
                        a.Element("Clase").Value.ToString(), a.Element("Descripcion").Value.ToString(),
                        a.Element("Marca").Value.ToString(), a.Element("Modelo").Value.ToString(),
                        a.Element("Serie").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_EstadoActivo").Value.ToString()),
                        a.Element("EstadoActivo").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_EstadoInventario").Value.ToString()),
                        a.Element("EstadoInventario").Value.ToString()));
                }
            }

            catch (Exception ex)
            {
                listaActivos.Clear();
                return listaActivos;
            }
            return listaActivos;
        }

        public List<Activo> ListaActivosExportar()
        {
            List<Activo> listaActivos = new List<Activo>();
            try
            {
                XDocument doc = XDocument.Load(ArchivoCarga);
                XElement xInventario = doc.Element("Inventario");
                XElement xActivos = xInventario.Element("Activos");
                IEnumerable<XElement> resultActivo;
               
                resultActivo = from u in xActivos.Elements("Activo")
                               where u.Element("Pardet_EstadoInventario").Value.ToString().Equals("2")
                                   select u;
                

                int asd = resultActivo.Count();
                foreach (XElement a in resultActivo)
                {
                    listaActivos.Add(new Activo(Convert.ToInt32(a.Element("Emplea_Custodio").Value.ToString()),
                        a.Element("Custodio").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_Ubicacion").Value.ToString()),
                        a.Element("Ubicacion").Value.ToString(),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioCustodio").Value.ToString())),
                        Convert.ToBoolean(Convert.ToInt32(a.Element("InvDet_esCambioUbicacion").Value.ToString())),
                        Convert.ToDateTime(a.Element("Usuari_FechaHoraRegistro").Value.ToString()),
                        a.Element("Usuari_CodigoPDA").Value.ToString(), a.Element("CodigoBarras").Value.ToString(),
                        a.Element("Clase").Value.ToString(), a.Element("Descripcion").Value.ToString(),
                        a.Element("Marca").Value.ToString(), a.Element("Modelo").Value.ToString(),
                        a.Element("Serie").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_EstadoActivo").Value.ToString()),
                        a.Element("EstadoActivo").Value.ToString(),
                        Convert.ToInt32(a.Element("Pardet_EstadoInventario").Value.ToString()),
                        a.Element("EstadoInventario").Value.ToString()));
                }
            }

            catch (Exception ex)
            {
                listaActivos.Clear();
                return listaActivos;
            }
            return listaActivos;
        }

        public Boolean ExportarInventario()
        {
            Boolean result = false;
            try
            {
            }
            catch (Exception e)
            {
            }
            return result;
        }
    }
}
