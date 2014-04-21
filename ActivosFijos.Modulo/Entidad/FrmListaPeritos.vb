Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaPeritos
  '#Region "IOpcion"
  '  Private mOperadorDatos As OperadorDatos = Nothing
  '  Public WriteOnly Property OperadorDatos() As OperadorDatos
  '    Set(ByVal value As OperadorDatos)
  '      mOperadorDatos = value
  '      If value IsNot Nothing Then
  '        Llenar_datos()
  '      End If
  '    End Set
  '  End Property
  '#End Region

  Private mPerito As Perito = Nothing
  Public Property Perito() As Perito
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Perito)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Perito As Perito In Me.ListBindingSource.DataSource
          If _Perito.Entida_Codigo = value.Entida_Codigo Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public Property Filtro() As String
    Get
      Return MyBase.combobuscar.Text
    End Get
    Set(ByVal value As String)
      MyBase.combobuscar.Text = value
      MyBase.Hacer_busqueda()
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaPeritos_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaPeritos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaPeritos_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoPerito(Sistema, Restriccion)
    f.Peritos = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaPeritos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaPeritos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaPeritos_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPeritos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mPerito As Perito
    mPerito = ListBindingSource.Current
    If mPerito.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Perito" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaPeritos_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mPeritos As PeritoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Peritos"
    MyBase.AgregarLeyenda = "Agregar un nuevo Perito"

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    'DataGridViewTextBoxColumn0.DataPropertyName = "Provee_Visible"
    'DataGridViewTextBoxColumn0.HeaderText = "Activo"
    'DataGridViewTextBoxColumn0.Width = 50
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre de Perito"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "DireccionesString"
    'DataGridViewTextBoxColumn1.HeaderText = "Dirección"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "TelefonosString"
    'DataGridViewTextBoxColumn1.HeaderText = "Teléfono"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(Perito)
    mPeritos = PeritoList.ObtenerLista(Sistema.OperadorDatos, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mPeritos)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mPeritos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPeritos.AddingNew
    Dim _Perito As Perito = New Perito(Sistema.OperadorDatos, True)
    e.NewObject = _Perito
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPeritos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    FrmListaPeritos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPeritos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaPeritos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Llenar_datos()
  End Sub
#End Region

  '  Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
  '    If DesignMode Then
  '      Exit Sub
  '    End If
  '    If e.ColumnIndex = -1 Or e.ColumnIndex <> 0 Or e.RowIndex = -1 Then
  '      Me.btnmostrar.Visible = False
  '      Me.ToolTipImage1.Hide(Me.btnmostrar)
  '      Exit Sub
  '    End If
  '    Me.btnmostrar.Visible = True
  '    Dim rec As Rectangle = Me.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
  '    Me.btnmostrar.Location = New Point(e.Location.X + rec.X + Me.DataGridView1.Location.X, e.Location.Y + rec.Y + DataGridView1.Location.Y)

  '    Dim _Perito As Perito
  '    '_item = mItems(e.RowIndex)
  '    _Perito = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
  '    Me.ToolTipImage1.SetToolTipImageTitle(Me.btnmostrar, "Perito")
  '    Me.ToolTipImage1.SetToolTipImageImage(Me.btnmostrar, _Perito.Entidad.Entida_Imagen(100))
  '    Me.ToolTipImage1.SetToolTipImageText(Me.btnmostrar, _Perito.NombreCompleto)
  '    'Me.ToolTipImage1.SetToolTipImageIcon(Me.btnmostrar, _item.PardetGrupo.Pardet_Imagen(25))
  '    Me.ToolTipImage1.Show("Descripción", Me.btnmostrar)
  '  End Sub
End Class
