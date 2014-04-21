Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class clsReporteActivo
  Public Shared Function RetornarFichaActivoDS(_Activo As Activo) As dsReporteActivosValorizacionDet
    Dim bReturn As Boolean
    Dim ds As New dsReporteActivosValorizacionDet
    With _Activo.OperadorDatos
      .AgregarParametro("@Accion", "Ri")
      .AgregarParametro("@Activo_Codigo", _Activo.Activo_Codigo)
      .Comando.CommandText = "proc_Activo"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function

  Public Shared Function RetornarActaEntregaCustodioDS(_Custodio As Empleado) As dsReporteActivos
    Dim bReturn As Boolean
    Dim ds As New dsReporteActivos
    With _Custodio.OperadorDatos
      .AgregarParametro("@Accion", "RAC")
      .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
      .Comando.CommandText = "proc_Activo"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function

  Public Enum EnumListaActivosOrden
    GrupoTipoClase
    Custodio
    Ubicacion
  End Enum

  'Tipo Rango Fechas
  '0 Compra entre
  '1 Ingreso entre
  '2 Uso entre
  '3 Baja entre
  '4 Sin fecha de uso
  '5 Sin fecha de baja

  Public Shared Function RetornarListaActivosDS(_ListaActivosOrden As EnumListaActivosOrden, ByVal _OperadorDatos As OperadorDatos, _CodigoBarras As String, _CodigoAux As String, _Serie As String, _Descripcion As String, _Clase As WWTSParametroDet, _Marca As WWTSParametroDet, _Modelo As String, _Proveedor As Proveedor, _Factura As FacturaActivo, _Custodio As Empleado, _Ubicacion As WWTSParametroDet, _Estadoinv As WWTSParametroDet, _SoloActivos As Boolean, _RangoFecha As Integer, _Desde As Date, _Hasta As Date) As dsReporteActivos
    Dim bReturn As Boolean
    Dim ds As New dsReporteActivos
    With _OperadorDatos
      Select Case _ListaActivosOrden
        Case EnumListaActivosOrden.GrupoTipoClase
          .AgregarParametro("@Accion", "RG")
        Case EnumListaActivosOrden.Custodio
          .AgregarParametro("@Accion", "RC")
        Case EnumListaActivosOrden.Ubicacion
          .AgregarParametro("@Accion", "RU")
      End Select
      .AgregarParametro("@Activo_CodigoBarra", _CodigoBarras)
      .AgregarParametro("@Activo_CodigoAux", _CodigoAux)
      .AgregarParametro("@Activo_Serie", _Serie)
      .AgregarParametro("@Activo_Descripcion", _Descripcion)
      If _Clase IsNot Nothing Then
        .AgregarParametro("@Parame_ClaseActivo", _Clase.Parame_Codigo)
        .AgregarParametro("@Pardet_ClaseActivo", _Clase.Pardet_Secuencia)
      End If
      If _Marca IsNot Nothing Then
        .AgregarParametro("@Pardet_Marca", _Marca.Pardet_Secuencia)
      End If
      .AgregarParametro("@Activo_Modelo", _Modelo)
      If _Proveedor IsNot Nothing Then
        .AgregarParametro("@Entida_Proveedor", _Proveedor.Entida_Codigo)
        If _Factura IsNot Nothing Then
          .AgregarParametro("@Factura_Codigo", _Factura.Factura_Codigo)
        End If
      End If
      If _Custodio IsNot Nothing Then
        .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
      End If
      If _Ubicacion IsNot Nothing Then
        .AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
        .AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
      End If
      If _Estadoinv IsNot Nothing Then
        .AgregarParametro("@Parame_EstadoInventario", _Estadoinv.Parame_Codigo)
        .AgregarParametro("@Pardet_EstadoInventario", _Estadoinv.Pardet_Secuencia)
      End If
      If _SoloActivos Then
        .AgregarParametro("@SoloActivos", _SoloActivos)
      End If
      .AgregarParametro("@RangoFecha", _RangoFecha)
      If _RangoFecha >= 0 Then
        .AgregarParametro("@FechaDesde", _Desde.Date)
        .AgregarParametro("@FechaHasta", _Hasta.Date)
      End If
      .Comando.CommandText = "proc_Activo"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function
  Public Shared Function RetornarListaActivosDepreciacionDS(_ListaActivosOrden As EnumListaActivosOrden, ByVal _OperadorDatos As OperadorDatos, _CodigoBarras As String, _CodigoAux As String, _Serie As String, _Descripcion As String, _Clase As WWTSParametroDet, _Marca As WWTSParametroDet, _Modelo As String, _Proveedor As Proveedor, _Factura As FacturaActivo, _Custodio As Empleado, _Ubicacion As WWTSParametroDet, _Estadoinv As WWTSParametroDet, _SoloActivos As Boolean, _RangoFecha As Integer, _Desde As Date, _Hasta As Date) As dsReporteActivoDepreciacion
    Dim bReturn As Boolean
    Dim ds As New dsReporteActivoDepreciacion
    With _OperadorDatos
      Select Case _ListaActivosOrden
        Case EnumListaActivosOrden.GrupoTipoClase
          .AgregarParametro("@Accion", "RGd")
        Case EnumListaActivosOrden.Custodio
          .AgregarParametro("@Accion", "RCd")
        Case EnumListaActivosOrden.Ubicacion
          .AgregarParametro("@Accion", "RUd")
      End Select
      .AgregarParametro("@Activo_CodigoBarra", _CodigoBarras)
      .AgregarParametro("@Activo_CodigoAux", _CodigoAux)
      .AgregarParametro("@Activo_Serie", _Serie)
      .AgregarParametro("@Activo_Descripcion", _Descripcion)
      If _Clase IsNot Nothing Then
        .AgregarParametro("@Parame_ClaseActivo", _Clase.Parame_Codigo)
        .AgregarParametro("@Pardet_ClaseActivo", _Clase.Pardet_Secuencia)
      End If
      If _Marca IsNot Nothing Then
        .AgregarParametro("@Pardet_Marca", _Marca.Pardet_Secuencia)
      End If
      .AgregarParametro("@Activo_Modelo", _Modelo)
      If _Proveedor IsNot Nothing Then
        .AgregarParametro("@Entida_Proveedor", _Proveedor.Entida_Codigo)
        If _Factura IsNot Nothing Then
          .AgregarParametro("@Factura_Codigo", _Factura.Factura_Codigo)
        End If
      End If
      If _Custodio IsNot Nothing Then
        .AgregarParametro("@Entida_Custodio", _Custodio.Entida_Codigo)
      End If
      If _Ubicacion IsNot Nothing Then
        .AgregarParametro("@Parame_Ubicacion", _Ubicacion.Parame_Codigo)
        .AgregarParametro("@Pardet_Ubicacion", _Ubicacion.Pardet_Secuencia)
      End If
      If _Estadoinv IsNot Nothing Then
        .AgregarParametro("@Parame_EstadoInventario", _Estadoinv.Parame_Codigo)
        .AgregarParametro("@Pardet_EstadoInventario", _Estadoinv.Pardet_Secuencia)
      End If
      If _SoloActivos Then
        .AgregarParametro("@SoloActivos", _SoloActivos)
      End If
      .AgregarParametro("@RangoFecha", _RangoFecha)
      If _RangoFecha >= 0 Then
        .AgregarParametro("@FechaDesde", _Desde.Date)
        .AgregarParametro("@FechaHasta", _Hasta.Date)
      End If
      .Comando.CommandText = "proc_Activo"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteActivo")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function

  Public Shared Function RetornarDepreciacionDS(_Depreciacion As Depreciacion) As dsReporteDepreciacion
    Dim bReturn As Boolean
    Dim ds As New dsReporteDepreciacion
    With _Depreciacion.OperadorDatos
      .AgregarParametro("@Accion", "R")
      .AgregarParametro("@Parame_FrecuenciaDepreciacion", _Depreciacion.Parame_FrecuenciaDepreciacion)
      .AgregarParametro("@Pardet_FrecuenciaDepreciacion", _Depreciacion.Pardet_FrecuenciaDepreciacion)
      .AgregarParametro("@Parame_TipoDepreciacion", _Depreciacion.Parame_TipoDepreciacion)
      .AgregarParametro("@Pardet_TipoDepreciacion", _Depreciacion.Pardet_TipoDepreciacion)
      .AgregarParametro("@Deprec_Codigo", _Depreciacion.Deprec_Codigo)
      .Comando.CommandText = "proc_DepreciacionDet"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteDepreciacion")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteDepreciacion")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function
End Class
