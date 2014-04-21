Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas

Public Class Loader
#Region "General"
  Function CargarModuloGeneral(ByVal _Sistema As Sistema) As List(Of GrupoOpcion)
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.General) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.General), CargarOpcionesGeneral(_Sistema, False), CargarOpcionesGeneral(_Sistema, True), CargarOpcionesGeneralRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesGeneral(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

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
    Return _opciones
  End Function

  Function CargarOpcionesGeneralRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

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
    Dim _grupos As New List(Of GrupoOpcion)
    If _Sistema.Usuario.Restricciones.porModulo(Enumerados.EnumModulos.ActivosFijos) Then
      _grupos.Add(New GrupoOpcion(New ParametroDet(_Sistema.OperadorDatos, 4, Enumerados.EnumModulos.ActivosFijos), CargarOpcionesActivoFijo(_Sistema, False), CargarOpcionesActivoFijo(_Sistema, True), CargarOpcionesActivoFijoRep(_Sistema)))
    End If
    Return _grupos
  End Function

  Function CargarOpcionesActivoFijo(ByVal _Sistema As Sistema, ByVal _SoloFavoritas As Boolean) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

    For Each _restriccion As Restriccion In _Sistema.Restricciones
      If Not _SoloFavoritas Or (_SoloFavoritas AndAlso _restriccion.Restri_Favorito) Then
        If _restriccion.Restri_Lectura Then
          Select CType(_restriccion.Pardet_Opciones, Enumerados.EnumOpciones)
            Case Enumerados.EnumOpciones.ListadoActivos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarActivos))
            Case Enumerados.EnumOpciones.CargarActivosLote
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarActivosLote))
            Case Enumerados.EnumOpciones.ListadoPolizas
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarPolizas))
            Case Enumerados.EnumOpciones.ListadoTransaccionActivos
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarTransacciones))
            Case Enumerados.EnumOpciones.ListadoPendientesCustodio
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarPendientesAprobacion))
            Case Enumerados.EnumOpciones.ReporteActaEntregaCustodio
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteActaEntregaCustodio))
            Case Enumerados.EnumOpciones.Depreciacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarDepreciacion))
            Case Enumerados.EnumOpciones.ReporteResumenDepreciacion
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarReporteResumenDepreciacion))
            Case Enumerados.EnumOpciones.DarBajaActivo
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarBajaActivo))
            Case Enumerados.EnumOpciones.InventarioActivo
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarInventarioActivo))
            Case Enumerados.EnumOpciones.ResumenDepreciacionPorTipo
              _opciones.Add(New Opcion(_restriccion, AddressOf CargarResumenDepreciacionPorTipo))
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
    Return _opciones
  End Function

  Function CargarOpcionesActivoFijoRep(ByVal _Sistema As Sistema) As List(Of Opcion)
    Dim _opciones As New List(Of Opcion)

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
    Return _opciones
  End Function

  Function CargarActivos(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmMantenimientoActivo(_Sistema, _Restriccion)
    f.Activo = New Activo(_Sistema.OperadorDatos, True)
    Return f
  End Function

  Function CargarActivosLote(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmCargaActivosLote(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarPolizas(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaPolizas(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarTransacciones(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaTransaccionActivos(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarPendientesAprobacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaActivoCustodioAprobar(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarReporteActaEntregaCustodio(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmReporteActaEntregaCustodio(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarDepreciacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmDepreciacion(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarReporteResumenDepreciacion(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmReporteResumenDepreciacion(_Sistema, _Restriccion)
    Return f
  End Function

  Function CargarBajaActivo(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaBajasActivo(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarInventarioActivo(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmListaInventarios(_Sistema, _Restriccion, False)
    Return f
  End Function

  Function CargarResumenDepreciacionPorTipo(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New FrmResumenDepreciacionPorTipo(_Sistema, _Restriccion)
    Return f
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
#End Region

  Function CargarReporte(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _Opcion As Opcion) As Infoware.Docking.IDockContent
    Dim f As New Infoware.Reporteador.FrmLista(_Sistema, _Restriccion)
    f.Reporte = _Opcion.Tag
    Return f
  End Function

End Class
