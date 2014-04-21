Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class clsReporteResumenDepreciacion
  Public Shared Function RetornarResumenDepreciacionDS(_TipoDepreciacion As WWTSParametroDet, _CortadoAl As Date) As dsReporteResumenDepreciacion
    Dim bReturn As Boolean
    Dim ds As New dsReporteResumenDepreciacion
    With _TipoDepreciacion.OperadorDatos
      .AgregarParametro("@Cortado_al", _CortadoAl.Date)
      .AgregarParametro("@cbo_Tipo_Depreciacion", _TipoDepreciacion.Pardet_Secuencia)
      .Comando.CommandText = "repr_Reporte_Depreciacion"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_ReporteResumenDepreciacion")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_ReporteResumenDepreciacion")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function
End Class
