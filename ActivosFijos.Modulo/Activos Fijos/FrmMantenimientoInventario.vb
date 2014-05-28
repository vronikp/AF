Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoInventario
  Private ReadOnly Property Usuario As WWTSUsuario
    Get
      Return New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)
    End Get
  End Property

#Region "Parametros"
  Public Property Inventarios() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mInventario As Inventario = Nothing
  Public Property Inventario() As Inventario
    Get
      Return mInventario
    End Get
    Set(ByVal value As Inventario)
      mInventario = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Inventarios As New InventarioList
        _Inventarios.Add(mInventario)
        MyBase.BindingSource1.DataSource = GetType(Inventario)
        MyBase.BindingSource1.DataSource = _Inventarios
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mInventario = Inventarios.Current
    If mInventario Is Nothing Then
      Exit Sub
    End If

    Me.CtlUbicacionActivo1.ParametroDet = mInventario.PardetUbicacion
    Me.cboperiodo.ParametroDet = mInventario.PardetPeriodoInventario
    Me.txtdescripcion.Text = mInventario.Invent_Descripcion
    Me.dtfecha.Value = mInventario.Invent_Fecha
    Me.cboEstadoInventario.ParametroDet = mInventario.PardetEstadoInventario
    If mInventario.EsNuevo Then
      Me.cboEstadoInventario.ParametroDet = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventario, Enumerados.enumEstadoInventario.Noterminado)
    End If
    Me.cboEstadoInventario.Enabled = Not mInventario.EsNuevo
    Me.bsdets.DataSource = mInventario.InventarioDets
    Me.dgdets.AutoDiscover()

    Me.CtlUbicacionActivo1.Enabled = mInventario.EsNuevo
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoInventario_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mInventario.EsNuevo
    If _esnuevo AndAlso Inventarios.Current IsNot Nothing Then
      Inventarios.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Inventarios eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Inventario As Inventario = New Inventario(Sistema.OperadorDatos, True)
    e.NewObject = _Inventario
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoInventario_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mInventario.PardetUbicacion = Me.CtlUbicacionActivo1.ParametroDet
    mInventario.PardetPeriodoInventario = Me.cboperiodo.ParametroDet
    mInventario.Invent_Descripcion = Me.txtdescripcion.Text
    mInventario.Invent_Fecha = Me.dtfecha.Value
    mInventario.PardetEstadoInventario = Me.cboEstadoInventario.ParametroDet
    If mInventario.EsNuevo Then
      buscar()
    End If
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_Datos()
    Dim _esnuevo As Boolean = mInventario.EsNuevo
    If mInventario.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mInventario.Descripcion)

      Return True
    Else
      'Inventarios.CancelEdit()
      MsgBox("No se puede guardar Inventario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoInventario_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mInventario.Eliminar() AndAlso Inventarios.Current IsNot Nothing Then
      Inventarios.RemoveCurrent()
      Me.Close()
    Else
      'Inventarios.CancelEdit()
      MsgBox("No se puede eliminar Inventario" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoInventario_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoInventario_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoInventario_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoInventario_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoInventario_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.InventarioActivo)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoInventario_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Inventario"

    Me.CtlUbicacionActivo1.SoloVisibles = True
    Me.CtlUbicacionActivo1.PardetRaiz = Usuario.PardetUbicacion
    Me.CtlUbicacionActivo1.llenar_datos()

    Me.cboperiodo.OperadorDatos = Sistema.OperadorDatos
    Me.cboperiodo.Parametro = Enumerados.EnumParametros.PeriodoInventario
    Me.cboperiodo.Llenar_Datos()

    Me.cboEstadoInventario.OperadorDatos = Sistema.OperadorDatos
    Me.cboEstadoInventario.Parametro = Enumerados.EnumParametros.EstadoInventario
    Me.cboEstadoInventario.Llenar_Datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub CtlUbicacionActivo1_Click(sender As Object, e As System.EventArgs) Handles CtlUbicacionActivo1.Click
    
  End Sub

  Private Sub btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrar.Click
    buscar()
  End Sub

  Sub buscar()
    If Me.cboperiodo.ParametroDet Is Nothing OrElse Me.CtlUbicacionActivo1.ParametroDet Is Nothing Then
      Exit Sub
    End If
    mInventario.InventarioDets = Nothing

    If mInventario.EsNuevo Then
      Dim mdets As New InventarioDetList
      For Each _activo As Activo In ActivoList.ObtenerLista(Sistema.OperadorDatos, "", "", "", "", Nothing, Nothing, "", Nothing, Nothing, Nothing, Me.CtlUbicacionActivo1.ParametroDet, Nothing, True, -1, Nothing, Nothing, Nothing)
        Dim _actubis As ActivoUbicacionList = ActivoUbicacionList.ObtenerActivos(_activo)
        Dim _actcus As ActivoCustodioList = ActivoCustodioList.ObtenerActivos(_activo)
        If Not (_actubis Is Nothing OrElse _actubis.Count = 0) AndAlso Not (_actcus Is Nothing OrElse _actcus.Count = 0) Then
          Dim minvdet As New InventarioDet(Sistema.OperadorDatos, True)
          minvdet.Inventario = mInventario
          minvdet.Activoubicacion = _actubis(0)
          minvdet.Activocustodio = _actcus(0)
          minvdet.PardetEstadoInventario = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.EstadoInventarioActivo, Enumerados.enumEstadoInventarioActivo.NoInventariado)
          mdets.Add(minvdet)
        End If
      Next
      mInventario.InventarioDets = mdets
    End If
    Me.bsdets.DataSource = mInventario.InventarioDets
    Me.dgdets.AutoDiscover()

  End Sub

  Private Sub btninventariar_Click(sender As System.Object, e As System.EventArgs) Handles btninventariar.Click
    If mInventario Is Nothing Then
      Exit Sub
    End If
    If mInventario.EsNuevo Then
      If MsgBox("Debe guardar el inventario para comenzar a inventariar, ¿Desea guardar el inventario ahora?", MsgBoxStyle.YesNo, "Información") = MsgBoxResult.No OrElse Not Guardar_datos() Then
        Exit Sub
      End If
    End If
    Dim f As New FrmInventariarActivo(Sistema, Enumerados.EnumOpciones.InventarioActivo)
    f.Inventario = mInventario
    f.ShowDialog()
    buscar()
  End Sub

    Private Sub cboEstadoInventario_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboEstadoInventario.SelectedIndexChanged

    End Sub
End Class
