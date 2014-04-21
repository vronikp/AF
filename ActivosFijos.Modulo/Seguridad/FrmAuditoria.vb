Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Data.SqlClient
Imports ActivosFijos.Reglas
Imports System.Data.OleDb

Public Class FrmAuditoria
  Private Sub Llenar_datos()
    MyBase.Titulo = "Auditoría"
    If Not mListaLlenarDatos OrElse Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If
    Try
      Dim info As New crpAuditoria
      info.DataDefinition.FormulaFields("filtro").Text = String.Format("'Desde {0} Hasta {1}'", Me.dtfecdesde.Value.ToShortDateString, Me.dtfechasta.Value.ToShortDateString)

      Dim ds As New dsAuditoria
      ds = RetornarAuditoriaDS(Sistema.OperadorDatos, Me.dtfecdesde.Value, Me.dtfechasta.Value, IIf(Me.chksolousuario.Checked, Me.ComboBoxUsuario1.Usuario, Nothing))

      info.SetDataSource(ds)
      info.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
      'Me.CrystalReportViewer1.Zoom(1)
      Me.ReporteDatos = info
    Catch Ex As Exception
      MsgBox(Ex.Message, MsgBoxStyle.Critical, "Error")
    End Try
  End Sub

  Private Function RetornarAuditoriaDS(ByVal _OperadorDatos As OperadorDatos, ByVal _FechaDesde As DateTime, ByVal _FechaHasta As DateTime, Optional ByVal _Usuario As WWTSUsuario = Nothing) As dsAuditoria
    Dim bReturn As Boolean = True
    Dim ds As New dsAuditoria
    With _OperadorDatos
      .AgregarParametro("@accion", "ra")
      .AgregarParametro("@fechadesde", _FechaDesde.Date)
      .AgregarParametro("@fechahasta", _FechaHasta.Date.AddDays(1))
      If _Usuario IsNot Nothing Then
        .AgregarParametro("@Usuari_Codigo", _Usuario.Usuari_Codigo)
      End If
      .Comando.CommandText = "proc_Auditoria"

      If .Proveedor = enumProveedorDatos.SQL Then
        Dim DataAdapter As SqlDataAdapter
        DataAdapter = New SqlDataAdapter(.Comando)
        Try
          DataAdapter.Fill(ds, "vp_Auditoria")
        Catch ex As Exception
          bReturn = False
        End Try
      ElseIf .Proveedor = enumProveedorDatos.Sybase Then
        Dim DataAdapter As OleDbDataAdapter
        DataAdapter = New OleDbDataAdapter(.Comando)
        .ReconfigurarParametros()
        Try
          DataAdapter.Fill(ds, "vp_Auditoria")
        Catch ex As Exception
          bReturn = False
        End Try
      End If

      'Dim DataAdapter As SqlDataAdapter
      'DataAdapter = New SqlDataAdapter(.Comando)
      'Try
      '  dsResult = New dsAuditoria
      '  DataAdapter.Fill(dsResult, "vp_Auditoria")
      'Catch ex As Exception
      '  bReturn = False
      'End Try
      .LimpiarParametros()
    End With
    If bReturn Then
      Return ds
    End If
    Return Nothing
  End Function

  Private Sub chksolousuario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chksolousuario.CheckedChanged, dtfecdesde.Validated, dtfechasta.Validated, ComboBoxUsuario1.CambioItem
    Me.ComboBoxUsuario1.Enabled = Me.chksolousuario.Checked
    Llenar_datos()
  End Sub

#Region "New"
  Private mListaLlenarDatos As Boolean = False

  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxUsuario1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxUsuario1.Llenar_datos()

    Me.dtfecdesde.Value = Now.Date.AddDays(-7)
    Me.dtfechasta.Value = Now.Date

    mListaLlenarDatos = True
    Llenar_datos()
  End Sub
#End Region
End Class
