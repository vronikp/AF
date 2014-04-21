Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaActivos
  Private mActivo As Activo = Nothing
  Public Property Activo() As Activo
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Activo)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Activo As Activo In Me.ListBindingSource.DataSource
          If _Activo.Activo_Codigo = value.Activo_Codigo Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public ReadOnly Property ActivosSeleccionados As ActivoList
    Get
      Dim _activos As New ActivoList
      For Each _row As DataGridViewRow In Me.DataGridView1.SelectedRows
        _activos.Add(CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(_row.Index))
      Next
      Return _activos
    End Get
  End Property

  Public Property MultiSelect As Boolean
    Get
      Return Me.DataGridView1.MultiSelect
    End Get
    Set(value As Boolean)
      Me.DataGridView1.MultiSelect = value
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

  Public Property MostrarDarBaja As Boolean
    Get
      Return Me.btndarbaja.Visible
    End Get
    Set(value As Boolean)
      Me.btndarbaja.Visible = value
      If value Then
        Me.Text = "Dar de baja activos"
        Me.DataGridView1.ForeColor = Color.DarkRed
      End If
    End Set
  End Property

#Region "Eventos"
  Private Sub FrmListaActivos_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaActivos_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaActivos_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoActivo(Sistema, Restriccion)
    f.Activos = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaActivos_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaActivos_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaActivos_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mActivos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mActivo As Activo
    mActivo = ListBindingSource.Current
    If mActivo.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Activo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaActivos_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mActivos As ActivoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Activos"
    MyBase.AgregarLeyenda = "Agregar un nuevo Activo"

    Me.ListBindingSource.DataSource = GetType(Activo)
    'mActivos = ActivoList.ObtenerLista(Sistema.OperadorDatos, _filtro)
    mActivos = Me.CtlBuscaActivos1.Activos
    If mActivos IsNot Nothing Then
      Dim mitemssort As New Infoware.Reglas.SortedView(mActivos)
      ListBindingSource.DataSource = mitemssort
    End If
  End Sub

  Private Sub mActivos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mActivos.AddingNew
    Dim _Activo As Activo = New Activo(Sistema.OperadorDatos, True)
    e.NewObject = _Activo
  End Sub
#End Region


#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    'AddHandler Me.DataGridView1.CellMouseMove, AddressOf Me.DataGridView1_CellMouseMove
    FrmListaActivos_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub FrmListaActivos_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.DataGridView1.BringToFront()

    Me.CtlBuscaActivos1.OperadorDatos = Sistema.OperadorDatos
        'Me.CtlBuscaActivos1.Llenar_Datos()

    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False

        'Llenar_datos()
  End Sub
#End Region

  'Private Sub DataGridView1_CellMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
  '  If DesignMode Then
  '    Exit Sub
  '  End If
  '  If e.ColumnIndex = -1 Or e.ColumnIndex <> 0 Or e.RowIndex = -1 Then
  '    Me.btnmostrar.Visible = False
  '    Me.ToolTipImage1.Hide(Me.btnmostrar)
  '    Exit Sub
  '  End If
  '  Me.btnmostrar.Visible = True
  '  Dim rec As Rectangle = Me.DataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, False)
  '  Me.btnmostrar.Location = New Point(e.Location.X + rec.X + Me.DataGridView1.Location.X, e.Location.Y + rec.Y + DataGridView1.Location.Y)

  '  Dim _Activo As Activo
  '  '_item = mItems(e.RowIndex)
  '  _Activo = CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(e.RowIndex)
  '  Me.ToolTipImage1.SetToolTipImageTitle(Me.btnmostrar, "Activo")
  '  Me.ToolTipImage1.SetToolTipImageImage(Me.btnmostrar, _Activo.Activo_Imagen(100))
  '  Me.ToolTipImage1.SetToolTipImageText(Me.btnmostrar, _Activo.Descripcion)
  '  'Me.ToolTipImage1.SetToolTipImageIcon(Me.btnmostrar, _item.PardetGrupo.Pardet_Imagen(25))
  '  Me.ToolTipImage1.Show("Descripción", Me.btnmostrar)
  'End Sub

  Private Sub CtlBuscaActivos1_Buscar(sender As Object, e As System.EventArgs) Handles CtlBuscaActivos1.Buscar
    Llenar_datos()
  End Sub

  Private Sub btnseleccionartodo_Click(sender As System.Object, e As System.EventArgs) Handles btnseleccionartodo.Click
    Me.DataGridView1.SelectAll()
  End Sub

  Private Sub btndarbaja_Click(sender As System.Object, e As System.EventArgs) Handles btndarbaja.Click
    If ActivosSeleccionados Is Nothing OrElse ActivosSeleccionados.Count = 0 Then
      Exit Sub
    End If
    Dim f As New FrmMantenimientoBajaActivo(Sistema, Restriccion)
    f.Activos = ActivosSeleccionados
    f.ShowDialog()

    Llenar_datos()
  End Sub
End Class
