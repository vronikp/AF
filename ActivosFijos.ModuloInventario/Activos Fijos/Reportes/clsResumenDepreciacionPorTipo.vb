Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class clsResumenDepreciacionPorTipo
  Public Shared Function RetornarResumenDepreciacionPorTipoDS(_TipoDepreciacion As WWTSParametroDet, _Anio As Integer, _Mes As Integer) As dsResumenDepreciacionPorTipo
    Dim bReturn As Boolean
    Dim ds As New dsResumenDepreciacionPorTipo
    With _TipoDepreciacion.OperadorDatos
      .AgregarParametro("@anio", _Anio)
      .AgregarParametro("@mes", _Mes)
      .AgregarParametro("@cbo_Tipo_Depreciacion", _TipoDepreciacion.Pardet_Secuencia)
      .Comando.CommandText = "repr_Resumen_depreciacion_por_tipo"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vw_Resumen_depreciacion_por_tipo")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vw_Resumen_depreciacion_por_tipo")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      .LimpiarParametros()
    End With
    Return ds
  End Function
End Class
