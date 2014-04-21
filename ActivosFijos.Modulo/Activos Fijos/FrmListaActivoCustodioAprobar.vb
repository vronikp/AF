Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaActivoCustodioAprobar
  Private mActivoCustodio As ActivoCustodio = Nothing
  Public Property ActivoCustodio() As ActivoCustodio
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As ActivoCustodio)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _ActivoCustodio As ActivoCustodio In Me.ListBindingSource.DataSource
          If _ActivoCustodio.Activo_Codigo = value.Activo_Codigo And _ActivoCustodio.ActCus_Secuencia = value.ActCus_Secuencia Then
            ListBindingSource.Position = t
          End If
          t += 1
        Next
      End If
    End Set
  End Property

  Public ReadOnly Property ActivoCustodiosSeleccionados As ActivoCustodioList
    Get
      Dim _actcus As New ActivoCustodioList
      For Each _row As DataGridViewRow In Me.DataGridView1.SelectedRows
        _actcus.Add(CType(Me.DataGridView1.DataSource.datasource, Infoware.Reglas.SortedView)(_row.Index))
      Next
      Return _actcus
    End Get
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
  Private Sub FrmListaActivoCustodioAprobar_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaActivoCustodioAprobar_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaActivoCustodioAprobar_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    'If ListBindingSource.Current Is Nothing Then
    '  Exit Sub
    'End If
    'Dim f As New FrmMantenimientoActivo(Sistema, Restriccion)
    'f.Activos = ListBindingSource
    'f.ShowDialog()
    'If ListBindingSource.Count <= 1 Then
    '  RefrescarLista()
    'End If
    'f.Dispose()
  End Sub

  Private Sub FrmListaActivoCustodioAprobar_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaActivoCustodioAprobar_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaActivoCustodioAprobar_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mActivoCustodios Is Nothing OrElse ListBindingSource.Current Is Nothing Then
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

  Private Sub FrmListaActivoCustodioAprobar_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mActivoCustodios As ActivoCustodioList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Cambios de custodio"
    MyBase.AgregarLeyenda = "Agregar un nuevo Cambio de custodio"

    Me.ListBindingSource.DataSource = GetType(Activo)
    If Me.CtlBuscaEmpleado1.Empleado IsNot Nothing Then
      mActivoCustodios = ActivoCustodioList.ObtenerPendientesAprobacion(Me.CtlBuscaEmpleado1.Empleado, _filtro)
    Else
      mActivoCustodios = New ActivoCustodioList
    End If
    Dim mitemssort As New Infoware.Reglas.SortedView(mActivoCustodios)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mActivos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mActivoCustodios.AddingNew
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
    FrmListaActivoCustodioAprobar_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private mUsuario As WWTSUsuario = Nothing

  Private Sub FrmListaActivoCustodioAprobar_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    mUsuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

    Me.CtlBuscaEmpleado1.Enabled = Not mUsuario.Usuari_RequerirAprobacionCambioCustodio
    Me.CtlBuscaEmpleado1.SoloActivos = True
    Me.CtlBuscaEmpleado1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaEmpleado1.Llenar_Datos()
    Me.CtlBuscaEmpleado1.Empleado = mUsuario.Empleado

    Me.PuedeNuevo = False
    Me.DataGridView1.BringToFront()

    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False

    Me.DataGridView1.BringToFront()
    Me.DataGridView1.MultiSelect = True
    Llenar_datos()
  End Sub
#End Region

  Private Sub CtlBuscaActivos1_Buscar(sender As Object, e As System.EventArgs)
    Llenar_datos()
  End Sub

  Private Sub btnseleccionartodo_Click(sender As System.Object, e As System.EventArgs) Handles btnseleccionartodo.Click
    Me.DataGridView1.SelectAll()
  End Sub

  Private Sub btnaprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnaprobar.Click
    If ActivoCustodiosSeleccionados.Count = 0 Then
      Exit Sub
    End If
    Dim _cont As Integer = 0
    For Each _cus As ActivoCustodio In ActivoCustodiosSeleccionados
      _cus.ActCus_Activo = True
      _cus.PardetAprobadoNuevoCustodio = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.AprobacionNuevoCustodio, Enumerados.EnumAprobacionNuevoCustodio.Aprobado)
      If Not _cus.Guardar Then
        MsgBox("Error al aprobar cambio de custodio. " & _cus.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Else
        _cont += 1
      End If
    Next

    MsgBox(String.Format("Se realizaron {0} aprobacion(es) exitosa(s)", _cont.ToString), MsgBoxStyle.Information, "Información")
    Llenar_datos()
  End Sub

  Private Sub btnrechazarcambio_Click(sender As System.Object, e As System.EventArgs) Handles btnrechazarcambio.Click
    If ActivoCustodiosSeleccionados.Count = 0 Then
      Exit Sub
    End If
    If MsgBox("¿Está seguro que desea rechazar los cambios de custodio seleccionados?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If

    Dim _mensaje As String = InputBox("Ingrese alguna observación para justificar el rechazo", "Rechazo", "")
    If String.IsNullOrWhiteSpace(_mensaje) Then
      MsgBox("Debe ingresar una observación de justificación de rechazo", MsgBoxStyle.Critical, "Error")
      Exit Sub
    End If

    Dim _cont As Integer = 0
    For Each _cus As ActivoCustodio In ActivoCustodiosSeleccionados
      '_cus.ActCus_Activo = True
      _cus.PardetAprobadoNuevoCustodio = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.AprobacionNuevoCustodio, Enumerados.EnumAprobacionNuevoCustodio.Reprobado)
      _cus.ActCus_Observacion = _mensaje
      If Not _cus.Guardar Then
        MsgBox("Error al aprobar cambio de custodio. " & _cus.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Else
        _cont += 1
      End If
    Next

    MsgBox(String.Format("Se realizaron {0} rechazo(s) exitoso(s)", _cont.ToString), MsgBoxStyle.Information, "Información")
    Llenar_datos()
  End Sub

  Private Sub CtlBuscaEmpleado1_CambioItem(sender As Object, e As System.EventArgs) Handles CtlBuscaEmpleado1.CambioItem
    Llenar_datos()
  End Sub
End Class
