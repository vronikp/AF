Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas
Imports Infoware.Datos
Imports Infoware.Reglas
Imports System.Data.SqlClient

Public Class Loader
#Region "General"

  Public PardetEmpresaActivo As WWTSParametroDet
  Private esBasica As Boolean = False
  Private esEstandar As Boolean = False
  Private esProfesional As Boolean = False
  Private esInterprof As Boolean = False
  Private esAlquiler As Boolean = False
  Private licencia As Licencia = New Licencia

  Sub CargarTipoLicencia(ByVal _Sistema As Sistema)
    PardetEmpresaActivo = New WWTSParametroDet(_Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1)
    'If My.Application.Deployment.IsFirstRun Then
    '    My.Settings.Key = InputBox("Escriba el código de activación:", "Activar", My.Settings.Key)
    '    My.Settings.Save()
    '    If ActivarVerificarLicencia(True) Then
    '        If CargarLicencia() Then
    '            MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
    '        Else
    '            MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
    '        End If
    '    Else
    '        My.Settings.Key = InputBox("No se ha activado el sistema. Escriba el código de activación:", "Activar", My.Settings.Key)
    '        My.Settings.Save()
    '        If ActivarVerificarLicencia(True) Then
    '            If CargarLicencia() Then
    '                MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
    '            Else
    '                MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
    '            End If
    '        Else
    '            My.Settings.Key = InputBox("No se ha activado el sistema. Escriba el código de activación:", "Activar", My.Settings.Key)
    '            My.Settings.Save()
    '            If ActivarVerificarLicencia(True) Then
    '                If CargarLicencia() Then
    '                    MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
    '                Else
    '                    MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
    '                End If
    '            Else
    '                MsgBox("No se ha activado el sistema.")
    '            End If
    '        End If
    '    End If
    'End If
    'MsgBox("Hoy " + Now.ToString)
    'MsgBox("Exipira " + My.Settings.ExpDa.ToString)
    'MsgBox("diferencia " + DateDiff(DateInterval.Year, Now, New Date(2016, 12, 17)).ToString)
    If DateDiff(DateInterval.Month, Now, My.Settings.ExpDa) >= 12 Then 'ha pasado 1 año
      If My.Settings.EsAlquiler Then
        PardetEmpresaActivo.Pardet_DatoStr1 = ""
        PardetEmpresaActivo.Pardet_DatoStr2 = ""
        PardetEmpresaActivo.Pardet_DatoStr3 = ""
        PardetEmpresaActivo.Pardet_DatoInt1 = 0
        PardetEmpresaActivo.Pardet_DatoBit1 = False
        PardetEmpresaActivo.Guardar()
        My.Settings.Key = InputBox("El periodo del alquiler del sistema ha concluido. Renueve sus licencias y escriba el código de activación:", "Activar", My.Settings.Key)
        My.Settings.Save()
        If ActivarVerificarLicencia(True) Then
          If CargarLicencia() Then
            MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
          Else
            MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
          End If
        Else
          MsgBox("No se ha activado el sistema.")
        End If
      Else
        'verificacion de licencia
        If ActivarVerificarLicencia(False) Then
          If CargarLicencia() Then
            MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
          Else
            MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
          End If
        Else
          MsgBox("No se ha activado el sistema.")
        End If
      End If
    End If
    'PardetEmpresaActivo = New WWTSParametroDet(_Sistema.OperadorDatos, Enumerados.EnumParametros.EmpresaActivo, 1)

    If PardetEmpresaActivo.Pardet_DatoStr1 = "N9IM2I" And PardetEmpresaActivo.Pardet_DatoStr2 = "F8PP6N" And
            PardetEmpresaActivo.Pardet_DatoStr3 = "N6AI0T" And PardetEmpresaActivo.Pardet_DatoInt1 = 10814 And
            PardetEmpresaActivo.Pardet_DatoBit1 = False Then
      esInterprof = True
      'MsgBox("es interprof")
    ElseIf PardetEmpresaActivo.Pardet_DatoStr1 = "A9MP0P" And PardetEmpresaActivo.Pardet_DatoStr2 = "R0MG3R" And
            PardetEmpresaActivo.Pardet_DatoStr3 = "A6MG3O" And PardetEmpresaActivo.Pardet_DatoInt1 = 151102 And
            PardetEmpresaActivo.Pardet_DatoBit1 = True Then
      esProfesional = True
      'MsgBox("es profesional")
    ElseIf PardetEmpresaActivo.Pardet_DatoStr1 = "R8MV8E" And PardetEmpresaActivo.Pardet_DatoStr2 = "A9MI7S" And
            PardetEmpresaActivo.Pardet_DatoStr3 = "R6AI0T" And PardetEmpresaActivo.Pardet_DatoInt1 = 10814 And
            PardetEmpresaActivo.Pardet_DatoBit1 = False Then
      esEstandar = True
      'MsgBox("es estandar")
    ElseIf PardetEmpresaActivo.Pardet_DatoStr1 = "F8MM7B" And PardetEmpresaActivo.Pardet_DatoStr2 = "N9ME4A" And
            PardetEmpresaActivo.Pardet_DatoStr3 = "F6MG3S" And PardetEmpresaActivo.Pardet_DatoInt1 = 151102 And
            PardetEmpresaActivo.Pardet_DatoBit1 = True Then
      esBasica = True
      'MsgBox("es basica")
    Else
      My.Settings.Key = InputBox("Escriba el código de activación:", "Activar", My.Settings.Key)
      My.Settings.Save()
      If ActivarVerificarLicencia(True) Then
        'MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
        If CargarLicencia() Then
          MsgBox("Interprof IFA " + licencia.NoVersion + " " + licencia.TipoVersionDescripcion + " se ha activado con éxito.")
        Else
          MsgBox("Ha ocurrido un error durante la activación. Contácte a su proveedor.")
        End If
      Else
        MsgBox("No se ha activado el sistema.")
      End If
    End If
  End Sub

  Function CargarModuloGeneral(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    'MsgBox("Cargar modulo general")
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.General) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.General), CargarOpcionesGeneral(_Sistema, False), CargarOpcionesGeneral(_Sistema, True), CargarOpcionesGeneralRep(_Sistema)))
    End If
    CargarTipoLicencia(_Sistema)
    Return _grupos
  End Function

  Function CargarOpcionesGeneral(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    'MsgBox("cargar opciones general")
    CargarTipoLicencia(_Sistema)
    Dim _opciones As New List(Of Opcion)
    If esBasica Or esEstandar Or esProfesional Or esInterprof Then
      For Each _restriccion As Restriccion In _Sistema.Restricciones
        If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
          If _restriccion.Restri_Lectura Then
            Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
              Case Enumerados.EnumOpciones.ListadoProveedores
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarProveedores))
              Case Enumerados.EnumOpciones.ListadoEmpleados
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarEmpleados))
              Case Enumerados.EnumOpciones.ListadoPeritos
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarPeritos))
              Case Enumerados.EnumOpciones.Caracteristicas
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarCaracteristicas))
              Case Enumerados.EnumOpciones.Secuencias
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarSecuencias))
                '_opciones.Add(New Opcion(_restriccion, AddressOf CargarWCFService))
            End Select
          End If
        End If
      Next
    End If
    Return _opciones
  End Function

  Function CargarOpcionesGeneralRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    CargarTipoLicencia(_Sistema)
    Dim _opciones As New List(Of Opcion)
    If esBasica Or esEstandar Or esProfesional Or esInterprof Then
      For Each _restriccion As Restriccion In _Sistema.Restricciones
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.ReportesGeneral
              Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPG")

              For Each _reporte As Infoware.Reporteador.Reporte In _reportes
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
              Next

          End Select
        End If
      Next
    End If
    Return _opciones
  End Function

  Function CargarProveedores(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaProveedores(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarEmpleados(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaEmpleados(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarPeritos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaPeritos(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarCaracteristicas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.CaracteristicaActivo
    Return f
  End Function

  Function CargarSecuencias(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.Secuencias
    Return f
  End Function

  'Function CargarWCFService(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
  '  Dim f As New FrmWCFService(_Sistema, _Restriccion, False)
  '  Return f
  'End Function

#End Region

#Region "ActivoFijo"

  Function CargarModuloActivoFijo(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    CargarTipoLicencia(_Sistema)
    Dim _grupos As New List(Of GrupoOpcion)
    If esBasica Or esEstandar Or esProfesional Or esInterprof Then
      If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.ActivosFijos) Then
        _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.ActivosFijos), CargarOpcionesActivoFijo(_Sistema, False), CargarOpcionesActivoFijo(_Sistema, True), CargarOpcionesActivoFijoRep(_Sistema)))
      End If
    End If
    Return _grupos
  End Function

  Function CargarOpcionesActivoFijo(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    CargarTipoLicencia(_Sistema)
    Dim _opciones As New List(Of Opcion)
    If esBasica Or esEstandar Or esProfesional Or esInterprof Then
      For Each _restriccion As Restriccion In _Sistema.Restricciones
        If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
          If _restriccion.Restri_Lectura Then
            Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
              Case Enumerados.EnumOpciones.CargarActivosLote
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarActivosLote))
              Case Enumerados.EnumOpciones.ListadoPendientesCustodio
              Case Enumerados.EnumOpciones.ReporteActaEntregaCustodio
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteActaEntregaCustodio))
              Case Enumerados.EnumOpciones.InventarioActivo
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarInventarioActivo))
                '  Case Enumerados.EnumOpciones.Seleccion
                '    _opciones.Add(New Opcion(_restriccion, AddressOf CargarSeleccion))
                '  Case Enumerados.EnumOpciones.TestxArea
                '    _opciones.Add(New Opcion(_restriccion, AddressOf CargarTestxArea))
                '  Case Enumerados.EnumOpciones.Personal
                '    _opciones.Add(New Opcion(_restriccion, AddressOf CargarPersonal))
            End Select
          End If
        End If
      Next
    End If
    Return _opciones
  End Function

  Function CargarOpcionesActivoFijoRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    CargarTipoLicencia(_Sistema)
    Dim _opciones As New List(Of Opcion)
    If esBasica Or esEstandar Or esProfesional Or esInterprof Then
      For Each _restriccion As Restriccion In _Sistema.Restricciones
        If _restriccion.Restri_Lectura Then
          Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.ReportesActivosFijos
              Dim _reportes As Infoware.Reporteador.ReporteList = Infoware.Reporteador.ReporteList.ObtenerLista(_Sistema.OperadorDatos, "REPR")

              For Each _reporte As Infoware.Reporteador.Reporte In _reportes
                _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporte, _reporte.NombreReporte, _reporte))
              Next

          End Select
        End If
      Next
    End If
    Return _opciones
  End Function

  Function CargarActivosLote(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    ''If 
    Dim f As New FrmCargaActivosLote(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarReporteActaEntregaCustodio(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmReporteActaEntregaCustodio(_Sistema, _Restriccion, False)
    Return f
  End Function


  Function CargarInventarioActivo(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        If esEstandar Or esProfesional Or esInterprof Then
            Dim f As New FrmListaInventarios(_Sistema, _Restriccion, False)
            Return f
        Else
            MsgBox("Esta opción no está disponible en su versión del sistema", MsgBoxStyle.Information, "Información")
            Return Nothing
        End If
    End Function

#End Region

#Region "Seguridad"
  Function CargarModuloSeguridad(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Seguridad) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Seguridad), CargarOpcionesSeguridad(_Sistema, False), CargarOpcionesSeguridad(_Sistema, True), CargarOpcionesSeguridadRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesSeguridad(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.Usuarios
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarUsuario))
                        Case Enumerados.EnumOpciones.Auditoria
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarAuditoria))
            Case Enumerados.EnumOpciones.Politicas
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarPoliticas))
          End Select
        End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesSeguridadRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        Return _opciones
    End Function

    Function CargarUsuario(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaUsuarios(_Sistema, _Restriccion, False)
        Return f
    End Function

    Function CargarAuditoria(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmAuditoria(_Sistema, _Restriccion)
        Return f
    End Function
#End Region

#Region "Configuracion"
    Function CargarModuloConfiguracion(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
        Dim _grupos As New List(Of GrupoOpcion)
        If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.Configuracion) Then
            _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.Configuracion), CargarOpcionesConfiguracion(_Sistema, False), CargarOpcionesConfiguracion(_Sistema, True), CargarOpcionesConfiguracionRep(_Sistema)))
        End If
        Return _grupos
    End Function

    Function CargarOpcionesConfiguracion(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)

        For Each _restriccion As Restriccion In _Sistema.Restricciones
            If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
                If _restriccion.Restri_Lectura Then
                    Select Case CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
                        Case Enumerados.EnumOpciones.Modulos
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarModulos))
                        Case Enumerados.EnumOpciones.Opciones
                            _opciones.Add(New Opcion(_restriccion, AddressOf CargarOpciones))
                    End Select
                End If
            End If
        Next
        Return _opciones
    End Function

    Function CargarOpcionesConfiguracionRep(ByVal _Sistema As Sistema) As List(Of Opcion)
        Dim _opciones As New List(Of Opcion)
        Return _opciones
    End Function

    Function CargarModulos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Modulos
        f.PuedeNuevo = False
        Return f
    End Function

    Function CargarOpciones(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
        f.Parame_Codigo = Enumerados.EnumParametros.Opciones
        f.PuedeNuevo = False
        Return f
    End Function

  Function CargarPoliticas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaParametroDets(_Sistema, _Restriccion, False)
    f.Parame_Codigo = Enumerados.EnumParametros.Politicas
    f.PuedeNuevo = False
    Return f
  End Function


  Function ActivarVerificarLicencia(ByVal esActivar As Boolean) As Boolean
        Dim conString As String = My.Settings.AdminConnectionString
        Dim sqlCon = New SqlConnection(conString)
        Dim reader As SqlDataReader
        Dim resultado As Boolean = False
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "proc_Licencia"
                sqlComm.CommandType = CommandType.StoredProcedure
                If esActivar Then
                    sqlComm.Parameters.AddWithValue("@accion", "ac")
                Else
                    sqlComm.Parameters.AddWithValue("@accion", "ve")
                End If
                sqlComm.Parameters.AddWithValue("@Codigo", My.Settings.Key)
                sqlComm.CommandTimeout = 1200
                sqlCon.Open()
                reader = sqlComm.ExecuteReader()
                Dim DTResults As New DataTable
                DTResults.Load(reader)
                If DTResults.Rows(0)(0) = 1 Then
                    resultado = True
                End If
                sqlCon.Close()
            End Using
        Catch
            MsgBox("Verifique su conexión a Internet.")
            resultado = False
        End Try

        Return resultado
    End Function

    Function CargarLicencia()
        Dim resultado As Boolean = False
        Dim conString As String = My.Settings.AdminConnectionString
        Dim sqlCon = New SqlConnection(conString)
        Dim reader As SqlDataReader
        Try
            Using (sqlCon)
                Dim sqlComm As New SqlCommand
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "proc_Licencia"
                sqlComm.CommandType = CommandType.StoredProcedure
                sqlComm.Parameters.AddWithValue("@accion", "c")
                sqlComm.Parameters.AddWithValue("@Codigo", My.Settings.Key)
                sqlComm.CommandTimeout = 1200
                sqlCon.Open()
                reader = sqlComm.ExecuteReader()
                Dim DTResults As New DataTable
                DTResults.Load(reader)
                If DTResults.Rows.Count > 0 Then
                    licencia.Codigo = CType(DTResults.Rows(0)("Codigo"), String)
                    licencia.TipoVersion = CType(DTResults.Rows(0)("TipoVersion"), Integer)
                    licencia.NoVersion = CType(DTResults.Rows(0)("NoVersion"), String)
                    licencia.EsAlquilada = CType(DTResults.Rows(0)("EsAlquilada"), Boolean)
                    licencia.FechaAdquisicion = CType(DTResults.Rows(0)("FechaAdquisision"), Date)
                    licencia.FechaActivacion = CType(DTResults.Rows(0)("FechaActivacion"), Date)
                    If Not TypeOf (DTResults.Rows(0)("FechaUltimaVerificacion")) Is DBNull Then
                        licencia.FechaUltimaVerificacion = CDate(DTResults.Rows(0)("FechaUltimaVerificacion"))
                    Else
                        licencia.FechaUltimaVerificacion = Nothing
                    End If
                    licencia.Nombre = CType(DTResults.Rows(0)("Nombre"), String)

                    My.Settings.EsAlquiler = licencia.EsAlquilada
                    My.Settings.Save()
                    My.Settings.ExpDa = licencia.FechaActivacion
                    My.Settings.Save()

                    If licencia.TipoVersion = 4 Then 'interprof
                        PardetEmpresaActivo.Pardet_DatoStr1 = "N9IM2I"
                        PardetEmpresaActivo.Pardet_DatoStr2 = "F8PP6N"
                        PardetEmpresaActivo.Pardet_DatoStr3 = "N6AI0T"
                        PardetEmpresaActivo.Pardet_DatoInt1 = 10814
                        PardetEmpresaActivo.Pardet_DatoBit1 = False
                        PardetEmpresaActivo.Guardar()
                    ElseIf licencia.TipoVersion = 3 Then 'Profesional
                        PardetEmpresaActivo.Pardet_DatoStr1 = "A9MP0P"
                        PardetEmpresaActivo.Pardet_DatoStr2 = "R0MG3R"
                        PardetEmpresaActivo.Pardet_DatoStr3 = "A6MG3O"
                        PardetEmpresaActivo.Pardet_DatoInt1 = 151102
                        PardetEmpresaActivo.Pardet_DatoBit1 = True
                        PardetEmpresaActivo.Guardar()
                    ElseIf licencia.TipoVersion = 2 Then 'Estandar
                        PardetEmpresaActivo.Pardet_DatoStr1 = "R8MV8E"
                        PardetEmpresaActivo.Pardet_DatoStr2 = "A9MI7S"
                        PardetEmpresaActivo.Pardet_DatoStr3 = "R6AI0T"
                        PardetEmpresaActivo.Pardet_DatoInt1 = 10814
                        PardetEmpresaActivo.Pardet_DatoBit1 = False
                        PardetEmpresaActivo.Guardar()
                    ElseIf licencia.TipoVersion = 1 Then 'Basica
                        PardetEmpresaActivo.Pardet_DatoStr1 = "F8MM7B"
                        PardetEmpresaActivo.Pardet_DatoStr2 = "N9ME4A"
                        PardetEmpresaActivo.Pardet_DatoStr3 = "F6MG3S"
                        PardetEmpresaActivo.Pardet_DatoInt1 = 151102
                        PardetEmpresaActivo.Pardet_DatoBit1 = True
                        PardetEmpresaActivo.Guardar()
                    End If
                    resultado = True
                End If

                sqlCon.Close()
            End Using
        Catch
            MsgBox("Verifique su conexión a Internet.")
            resultado = False
        End Try
        Return resultado
    End Function

#End Region

    Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
        Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion)
        f.Reporte = _Opcion.Tag
        Return f
    End Function

End Class
