Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmListaPersonas
#Region "IOpcion"
  Private mOperadorDatos As OperadorDatos = Nothing
  Public WriteOnly Property OperadorDatos() As OperadorDatos
    Set(ByVal value As OperadorDatos)
      mOperadorDatos = value
      If value IsNot Nothing Then
        Llenar_datos()
      End If
    End Set
  End Property
#End Region

  Private mTipoPersona As EntidadList.enumTipoObjeto = EntidadList.enumTipoObjeto.Persona
  Public Property TipoPersona() As EntidadList.enumTipoObjeto
    Get
      Return mTipoPersona
    End Get
    Set(ByVal value As EntidadList.enumTipoObjeto)
      mTipoPersona = value
      Llenar_datos()
    End Set
  End Property

  Private mPuedeElegirEntidad As Boolean = True
  Public Property PuedeElegirEntidad() As Boolean
    Get
      Return Me.mPuedeElegirEntidad
    End Get
    Set(ByVal value As Boolean)
      mPuedeElegirEntidad = value
    End Set
  End Property

  Private mPersona As Entidad = Nothing
  Public Property Persona() As Entidad
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Entidad)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _persona As Entidad In Me.ListBindingSource.DataSource
          If _persona.Entida_Codigo = value.Entida_Codigo Then
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
  Private Sub FrmListaPersonas_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaPersonas_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaPersonas_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    If ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If

    Dim f As New FrmMantenimientoPersona(Sistema, Restriccion)
    f.PuedeElegirEntidad = mPuedeElegirEntidad
    f.Personas = ListBindingSource
    f.ShowDialog()
    If ListBindingSource.Count <= 1 Then
      RefrescarLista()
    End If
    f.Dispose()
  End Sub

  Private Sub FrmListaPersonas_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaPersonas_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaPersonas_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPersonas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mPersona As Entidad
    mPersona = ListBindingSource.Current
    If mPersona.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Persona" & Environment.NewLine & mOperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaPersonas_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mPersonas As EntidadList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    If mOperadorDatos Is Nothing Then
      Exit Sub
    End If
    MyBase.Titulo = "Personas"
    MyBase.AgregarLeyenda = "Agregar una nueva Persona"

    'Me.DataGridView1.Columns.Clear()

    ''Dim DataGridViewTextBoxColumn0 As System.Windows.Forms.DataGridViewCheckBoxColumn
    ''DataGridViewTextBoxColumn0 = New System.Windows.Forms.DataGridViewCheckBoxColumn
    ''DataGridViewTextBoxColumn0.DataPropertyName = "Client_Visible"
    ''DataGridViewTextBoxColumn0.HeaderText = "Activo"
    ''DataGridViewTextBoxColumn0.Width = 50
    ''Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {DataGridViewTextBoxColumn0})

    'Dim DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    'DataGridViewTextBoxColumn1.DataPropertyName = "NombreCompleto"
    'DataGridViewTextBoxColumn1.HeaderText = "Nombre de Persona"
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

    Me.ListBindingSource.DataSource = GetType(Entidad)
    mPersonas = EntidadList.ObtenerLista(mOperadorDatos, Me.mTipoPersona, _filtro)
    Dim mitemssort As New Infoware.Reglas.SortedView(mPersonas)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mPersonas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mPersonas.AddingNew
    Dim _Persona As Entidad = Nothing
    _Persona = New Entidad(mOperadorDatos, True)
    Select Case mTipoPersona
      Case EntidadList.enumTipoObjeto.Natural
        _Persona.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Natural
      Case EntidadList.enumTipoObjeto.Juridica
        _Persona.Pardet_Tipoentidad = Enumerados.EnumTipoEntidad.Juridica
    End Select
    e.NewObject = _Persona
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.

  End Sub
#End Region
End Class
