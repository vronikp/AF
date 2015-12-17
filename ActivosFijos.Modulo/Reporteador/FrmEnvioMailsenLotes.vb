Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Windows.Forms
Imports Infoware.Reporteador
Imports ActivosFijos.Reglas

Public Class FrmEnvioMailsenLotes

  Private Sub ComboBoxConexionOtros1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxConexionOtros1.CambioItem
    Llenar_Reportes()
  End Sub

  Private Sub Llenar_Reportes()
    If Me.ComboBoxConexionOtros1.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    Dim _reportes As ReporteList = ReporteList.ObtenerLista(Me.ComboBoxConexionOtros1.OperadorDatos, "REP")

    Dim t As Integer = _reportes.Count
    While t > 0
      Dim _reporte As Reporte = _reportes(t - 1)
      If Not _reporte.ValidarReporte(Sistema.UsuarioString) OrElse Not _reporte.RetornarEmailAutomatico(Sistema.UsuarioString) Then
        _reportes.RemoveAt(t - 1)
      Else
        _reporte.ProximoEnvioAutomatico = _reporte.RetornarEmailProgramacion.ProximoEnvio(1)
      End If
      t -= 1
    End While

    Me.BindingSource1.DataSource = _reportes
    Me.DataGridView1.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreGrupo"
    DataGridViewTextBoxColumn1.HeaderText = "Grupo"
    DataGridViewTextBoxColumn1.Width = 170
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "NombreReporte"
    DataGridViewTextBoxColumn1.HeaderText = "Reporte"
    DataGridViewTextBoxColumn1.Width = 220
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "ProximoEnvioAutomatico"
    DataGridViewTextBoxColumn1.HeaderText = "Próximo envío"
    DataGridViewTextBoxColumn1.Width = 160
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "Enviara"
    DataGridViewTextBoxColumn1.HeaderText = "Enviar a"
    DataGridViewTextBoxColumn1.Width = 250
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
  End Sub

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FrmLista_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

  Private Sub FrmLista_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    System.IO.Directory.CreateDirectory(Sistema.DirectorioRaiz)
    Dim _config As String = System.IO.Path.Combine(Sistema.DirectorioRaiz, "Configuracion")
    System.IO.Directory.CreateDirectory(_config)

    Me.ComboBoxConexionOtros1.Archivoxml = System.IO.Path.Combine(_config, "ConexionOtros.xml")
    Me.ComboBoxConexionOtros1.Llenar_datos()

    Me.Tabla = "Envío de mails automático"
    'ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    'Me.ToolStrip2.Visible = False

    DataGridView1.AgruparRepetidos = True
  End Sub
#End Region

  Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    Timer1.Enabled = False
    For Each _reporte As Reporte In Me.BindingSource1.DataSource

      Dim minutosfaltan As Integer = Math.Abs(_reporte.ProximoEnvioAutomatico.Subtract(Now).Hours * 60 + _reporte.ProximoEnvioAutomatico.Subtract(Now).Minutes)

      If _reporte.ProximoEnvioAutomatico.Subtract(Now).Days = 0 AndAlso minutosfaltan < 1 AndAlso minutosfaltan > -1 Then
        EnviarAutoMail(_reporte)
        _reporte.ProximoEnvioAutomatico = _reporte.RetornarEmailProgramacion.ProximoEnvio(3)
      End If
    Next
    Timer1.Enabled = True
  End Sub

  Sub EnviarAutoMail(ByVal _reporte As Reporte)
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Restriccion)
    f.EnviarMailAutomaticoyCerrar = True
    f.Reporte = _reporte
    f.ShowDialog()
  End Sub
End Class