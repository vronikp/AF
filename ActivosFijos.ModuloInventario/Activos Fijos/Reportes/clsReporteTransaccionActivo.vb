﻿Imports Infoware.Datos
Imports ActivosFijos.Reglas
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class clsReporteTransaccionActivo

    Public Shared Function RetornarTransaccionActivoDS(_TransaccionActivo As TransaccionActivo) As dsReporteTransaccion
        Dim bReturn As Boolean
        Dim ds As New dsReporteTransaccion
        With _TransaccionActivo.OperadorDatos
            .AgregarParametro("@Accion", "R")
            .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)
            .Comando.CommandText = "proc_TransaccionActivo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivo")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivo")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function

    Public Shared Function RetornarTransaccionActivoCustodioDS(_TransaccionActivo As TransaccionActivo) As dsReporteTransaccionActivoCustodio
        Dim bReturn As Boolean
        Dim ds As New dsReporteTransaccionActivoCustodio
        With _TransaccionActivo.OperadorDatos
            .AgregarParametro("@Accion", "RC")
            .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)
            .Comando.CommandText = "proc_TransaccionActivo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoCustodio")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoCustodio")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function

    Public Shared Function RetornarTransaccionActivoCustodio2DS(_TransaccionActivo As TransaccionActivo) As dsReporteTransaccionActivoCustodio2
        Dim bReturn As Boolean
        Dim ds As New dsReporteTransaccionActivoCustodio2
        With _TransaccionActivo.OperadorDatos
            .AgregarParametro("@Accion", "RC2")
            .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)
            .Comando.CommandText = "proc_TransaccionActivo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoCustodio2")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoCustodio2")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function
    Public Shared Function RetornarTransaccionActivoUbicacionDS(_TransaccionActivo As TransaccionActivo) As dsReporteTransaccionActivoUbicacion
        Dim bReturn As Boolean
        Dim ds As New dsReporteTransaccionActivoUbicacion
        With _TransaccionActivo.OperadorDatos
            .AgregarParametro("@Accion", "RU")
            .AgregarParametro("@Transa_Codigo", _TransaccionActivo.Transa_Codigo)
            .Comando.CommandText = "proc_TransaccionActivo"

            If .Proveedor = enumProveedorDatos.SQL Then
                Dim DataAdapter As SqlDataAdapter
                DataAdapter = New SqlDataAdapter(.Comando)
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoUbicacion")
                Catch ex As Exception
                    bReturn = False
                End Try
            ElseIf .Proveedor = enumProveedorDatos.Sybase Then
                Dim DataAdapter As OleDbDataAdapter
                DataAdapter = New OleDbDataAdapter(.Comando)
                .ReconfigurarParametros()
                Try
                    DataAdapter.Fill(ds, "vw_TransaccionActivoUbicacion")
                Catch ex As Exception
                    bReturn = False
                End Try
            End If

            .LimpiarParametros()
        End With
        Return ds
    End Function

    Public Enum EnumListaTransaccionTipo
        Resumen
        Custodio1
        Custodio2
        Ubicacion
    End Enum

End Class
