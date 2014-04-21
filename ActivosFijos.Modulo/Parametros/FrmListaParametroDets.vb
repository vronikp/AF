Imports Infoware.Datos
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmListaParametroDets
#Region "IOpcion"
  Private mParame_Codigo As Enumerados.EnumParametros = Enumerados.EnumParametros.Banco
  Public Property Parame_Codigo() As Enumerados.EnumParametros
    Get
      Return mParame_Codigo
    End Get
    Set(ByVal value As Enumerados.EnumParametros)
      mParame_Codigo = value
      Me.ComboBoxParametro1.SelectedValue = CInt(value)
    End Set
  End Property

  Private mEstaLlenando As Boolean = False
  Private mParametro As Parametro = Nothing
  Public Property Parametro() As WWTSParametro
    Get
      If mParametro Is Nothing Then
        mParametro = New Parametro(Sistema.OperadorDatos, mParame_Codigo)
      End If
      Return mParametro
    End Get
    Set(ByVal value As WWTSParametro)
      If value IsNot Nothing Then
        If Me.ComboBoxParametro1.Parametro Is Nothing OrElse mParametro Is Nothing OrElse Not CInt(Me.ComboBoxParametro1.SelectedValue) = mParametro.Parame_Codigo Then
          Me.ComboBoxParametro1.Parametro = value
          mParametro = value
          mParame_Codigo = value.Parame_Codigo
          Llenar_datos()
        End If
      End If
    End Set
  End Property
#End Region

  Private mParametroDet As WWTSParametroDet = Nothing
  Public Property ParametroDet() As WWTSParametroDet
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As WWTSParametroDet)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _ParametroDet As WWTSParametroDet In Me.ListBindingSource.DataSource
          If _ParametroDet.Pardet_Secuencia = value.Pardet_Secuencia Then
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
  Private Sub FrmListaParametroDets_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaParametroDets_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaParametroDets_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim mParametroDet As WWTSParametroDet
    mParametroDet = ListBindingSource.Current

    If Not mParametroDet.Pardet_Modificable Then
      MsgBox("No se puede modificar el parámetro porque está marcado como no modificable", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If

    Dim f As New FrmMantenimientoParametroDet(Sistema, Restriccion)
    f.ParametroDetLists = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaParametroDets_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaParametroDets_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaParametroDets_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mParametroDets Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim mParametroDet As WWTSParametroDet
    mParametroDet = ListBindingSource.Current

    If Not mParametroDet.Pardet_Modificable Then
      MsgBox("No se puede eliminar el parámetro porque está marcado como no modificable", MsgBoxStyle.Information, "Información")
      Exit Sub
    End If
    If mParametroDet.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Parámetro" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaParametroDets_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mParametroDets As WWTSParametroDetList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.PuedeNuevo = Parametro.Parame_Modificable AndAlso Restriccion.Restri_Ingreso
    MyBase.PuedeEliminar = Parametro.Parame_Modificable AndAlso Restriccion.Restri_Eliminacion

    MyBase.Titulo = Parametro.Parame_Descripcion
    MyBase.AgregarLeyenda = String.Format("Agregar un nuevo {0}", Parametro.Parame_Descripcion)

    'Me.DataGridView1.Columns.Clear()

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "Descripcion"
    'DataGridViewTextBoxColumn1.HeaderText = "Descripción"
    'DataGridViewTextBoxColumn1.Width = 250
    'Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})

    Me.ListBindingSource.DataSource = GetType(WWTSParametroDet)
    mParametroDets = WWTSParametroDetList.ObtenerLista(Sistema.OperadorDatos, mParame_Codigo, WWTSParametroDetList.enumTipoObjeto.Nada, Nothing, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mParametroDets)
    ListBindingSource.DataSource = mitemssort
    Me.DataGridView1.AutoDiscover()
  End Sub

  Private Sub mParametroDets_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mParametroDets.AddingNew
    Dim _ParametroDet As WWTSParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, mParame_Codigo, True)
    e.NewObject = _ParametroDet
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    EsBusqueda = _busqueda
    Forma_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private Sub Forma_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    Me.ComboBoxParametro1.Op = Sistema.OperadorDatos
    Me.ComboBoxParametro1.Llenar_Datos()
    Llenar_datos()
  End Sub
#End Region

  Private Sub ComboBoxParametro1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxParametro1.CambioItem
    Parametro = Me.ComboBoxParametro1.Parametro
  End Sub

  Public Property PuedeElegirParametro() As Boolean
    Get
      Return Me.Panel1.Visible
    End Get
    Set(ByVal value As Boolean)
      Me.Panel1.Visible = value
    End Set
  End Property

  Private Sub FrmListaParametroDets_DespuesSeleccionarCampos(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DespuesSeleccionarCampos
    Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn

    If Parametro.ParametroPadre IsNot Nothing Then
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "PardetPadreString"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.ParametroPadre.Parame_Descripcion
      DataGridViewTextBoxColumn1.Width = 180
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If
    If Parametro.TieneDatoStr1 Then
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_DatoStr1"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoStr1
      DataGridViewTextBoxColumn1.Width = 125
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If
    If Parametro.TieneDatoStr2 Then
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_DatoStr2"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoStr1
      DataGridViewTextBoxColumn1.Width = 125
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If

    If Parametro.TieneDatoStr3 Then
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_DatoStr3"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoStr1
      DataGridViewTextBoxColumn1.Width = 125
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If

    If Parametro.TieneDatoInt1 Then
      Dim estilonum2 As New DataGridViewCellStyle()
      estilonum2.Format = "N0"

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_DatoInt1"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoInt1
      DataGridViewTextBoxColumn1.Width = 75
      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If

    If Parametro.TieneDatoDec1 Then
      Dim estilonum2 As New DataGridViewCellStyle()
      estilonum2.Format = "N2"

      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_DatoDec1"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoDec1
      DataGridViewTextBoxColumn1.Width = 75
      DataGridViewTextBoxColumn1.DefaultCellStyle = estilonum2
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If

    If Parametro.TieneDatoLeyenda Then
      DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
      DataGridViewTextBoxColumn1.DataPropertyName = "Pardet_Leyenda"
      DataGridViewTextBoxColumn1.HeaderText = Parametro.Parame_LeyendaDatoStr1
      DataGridViewTextBoxColumn1.Width = 125
      Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn1})
    End If
  End Sub
End Class
