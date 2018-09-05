Imports Infoware.Reglas.General
Imports ActivosFijos.Reglas

Public Class CtlRestricciones
  Inherits DataGridView

  Private mFactorTamanio As Decimal = 1
  Public Property FactorTamanio() As Decimal
    Get
      Return mFactorTamanio
    End Get
    Set(ByVal value As Decimal)
      mFactorTamanio = value
    End Set
  End Property

  Private mUsuario As WWTSUsuario
  Public Property Usuario() As WWTSUsuario
    Get
      Return mUsuario
    End Get
    Set(ByVal value As WWTSUsuario)
      mUsuario = value
      If value IsNot Nothing Then
        Llenar_detalles()
      End If
    End Set
  End Property

  Public ReadOnly Property Restriccion() As Restriccion
    Get
      Dim _restric As Restriccion = Nothing
      If Me.CurrentRow IsNot Nothing Then
        _restric = mUsuario.Restricciones(Me.CurrentRow.Index)
      End If
      Return _restric
    End Get
  End Property

  'Private mClsMenuEstandar As ClsMenuEstandar
  'Public Property ClsMenuEstandar() As ClsMenuEstandar
  '  Get
  '    Return mClsMenuEstandar
  '  End Get
  '  Set(ByVal value As ClsMenuEstandar)
  '    mClsMenuEstandar = value
  '  End Set
  'End Property

  Private WithEvents BindingSourceDetalles As BindingSource

#Region "Detalles de Restricciones"
  Private Sub Llenar_detalles()
    Me.BindingSourceDetalles.DataSource = GetType(RestriccionList)
    BindingSourceDetalles.DataSource = mUsuario.Restricciones
    MyBase.Columns.Clear()

    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetModuloString"
    DataGridViewTextBoxColumn1.HeaderText = "Módulo"
    DataGridViewTextBoxColumn1.Width = 120
    DataGridViewTextBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    DataGridViewTextBoxColumn1.DataPropertyName = "PardetOpcionString"
    DataGridViewTextBoxColumn1.HeaderText = "Opción"
    DataGridViewTextBoxColumn1.Width = 180
    DataGridViewTextBoxColumn1.ReadOnly = True
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Lectura"
    DataGridViewTextBoxColumn0.HeaderText = "Lectura"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Ingreso"
    DataGridViewTextBoxColumn0.HeaderText = "Ingreso"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Modificacion"
    DataGridViewTextBoxColumn0.HeaderText = "Modificación"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Eliminacion"
    DataGridViewTextBoxColumn0.HeaderText = "Eliminación"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_Impresion"
    DataGridViewTextBoxColumn0.HeaderText = "Impresión"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    DataGridViewTextBoxColumn0.DataPropertyName = "Restri_VerConfidencial"
    DataGridViewTextBoxColumn0.HeaderText = "Confidencial"
    DataGridViewTextBoxColumn0.Width = 65
    MyBase.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'If mUsuario.Restricciones.Count = 0 Then
    '  BindingSourceDetalles.AddNew()
    'End If
    'actualizar_totales()
  End Sub

  'Private Sub MyBase_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MyBase.CellEndEdit
  '  'actualizar_totales()
  'End Sub

  'Private Sub Mybase_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
  '  'AbrirDetalle()
  'End Sub

  'Private Sub DataGridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
  '  Select Case e.KeyCode
  '    Case Keys.Enter
  '      e.Handled = True
  '      If BindingSourceDetalles.Current IsNot Nothing Then
  '        AbrirDetalle()
  '      End If
  '    Case Keys.Insert
  '      e.Handled = True
  '      Me.BindingSourceDetalles.AddNew()
  '      AbrirDetalle()
  '    Case Keys.Delete
  '      e.Handled = True
  '      If BindingSourceDetalles.Current IsNot Nothing Then
  '        Me.BindingSourceDetalles.RemoveCurrent()
  '        actualizar_totales()
  '      End If
  '  End Select
  'End Sub

  'Private Sub AbrirDetalle()
  '  Dim f As New FrmMantenimientoMovimientoContableDet
  '  f.Usuario = mUsuario
  '  f.ClsMenuEstandar(Enumerados.EnumOpcionesNuevo.Usuario) = ClsMenuEstandar
  '  If BindingSourceDetalles.Count = 0 Then
  '    BindingSourceDetalles.AddNew()
  '  End If
  '  f.MovimientoContableDets = BindingSourceDetalles
  '  f.ShowDialog()
  '  'BindingSourceDetalles.EndEdit()
  '  MyBase.Refresh()
  '  actualizar_totales()
  'End Sub

  'Public Event Cambio_MovimientoDets As EventHandler
  'Private Sub actualizar_totales()
  '  RaiseEvent Cambio_MovimientoDets(Me, Nothing)
  'End Sub
#End Region

  Public Sub New()
    BindingSourceDetalles = New BindingSource
    MyBase.DataSource = BindingSourceDetalles
    MyBase.AutoGenerateColumns = False
    MyBase.AllowUserToAddRows = False
    MyBase.AllowUserToDeleteRows = False
    MyBase.ReadOnly = False

    Me.SetStyle(ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    Me.RowHeadersVisible = False
  End Sub

  Public Sub Merge()
    If Me.DisplayedRowCount(True) = 0 Then
      Exit Sub
    End If

    For Each _control As Control In Me.Controls
      If TypeOf _control Is Label Then
        _control.Dispose()
      End If
    Next

    Dim _texto As String = ">>>>"
    Dim x As Integer
    Dim y As Integer
    Dim w As Integer
    Dim h As Integer

    For Each _row As DataGridViewRow In Me.Rows
      If _row.Displayed Then
        Dim _fila As Restriccion = Me.BindingSourceDetalles(_row.Index)
        If _fila.PardetModuloString <> _texto Then
          If _texto <> ">>>>" Then
            Dim _label As New Label
            With _label
              .Text = _texto
              .Font = New Font(Me.DefaultCellStyle.Font, Me.DefaultCellStyle.Font.Style)
              .SetBounds(x, y, w, h)
            End With
            Me.Controls.Add(_label)
          End If

          x = Me.GetRowDisplayRectangle(_row.Index, False).Left
          y = Me.GetRowDisplayRectangle(_row.Index, False).Top
          w = Me.GetColumnDisplayRectangle(0, False).Right - x - 1
          h = Me.GetRowDisplayRectangle(_row.Index, False).Size.Height - 1

          _texto = _fila.PardetModuloString
        Else
          h += Me.GetRowDisplayRectangle(_row.Index, False).Size.Height
        End If
      End If
    Next
    If _texto <> ">>>>>" Then
      Dim _label As New Label
      With _label
        .Text = _texto
        .Font = New Font(Me.DefaultCellStyle.Font, Me.DefaultCellStyle.Font.Style)
        .TextAlign = ContentAlignment.MiddleLeft
        .SetBounds(x, y, w, h)
      End With
      Me.Controls.Add(_label)
    End If
  End Sub

  Private Sub CtlRestricciones_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    Merge()

  End Sub

  Private Sub CtlRestricciones_RowPostPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Me.RowPostPaint
    Merge()
  End Sub
End Class
