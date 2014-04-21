Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base

Imports ActivosFijos.Reglas

Public Class FrmMantenimientoPersona
#Region "Parametros"
  Public Property Personas() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mPersona As Entidad = Nothing
  Public Property Persona() As Entidad
    Get
      Return mPersona
    End Get
    Set(ByVal value As Entidad)
      mPersona = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _personas As New EntidadList
        _personas.Add(mPersona)
        MyBase.BindingSource1.DataSource = GetType(Entidad)
        MyBase.BindingSource1.DataSource = _personas
      End If
    End Set
  End Property

  Public Property PuedeElegirEntidad() As Boolean
    Get
      Return Me.CtlPersona1.PuedeElegirTipoEntidad
    End Get
    Set(ByVal value As Boolean)
      Me.CtlPersona1.PuedeElegirTipoEntidad = value
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mPersona = Personas.Current
    Me.CtlPersona1.Entidad = mPersona
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoPersona_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mPersona.EsNuevo
    If _esnuevo AndAlso Personas.Current IsNot Nothing Then
      Personas.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Personas eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Persona As Entidad = New Entidad(Sistema.OperadorDatos, True)
    e.NewObject = _Persona
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoPersona_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    Me.CtlPersona1.Mapear_datos()
    Dim _esnuevo As Boolean = mPersona.EsNuevo
    If mPersona.Entidadnatural IsNot Nothing AndAlso mPersona.Entidadnatural.Guardar Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mPersona.NombreCompleto)
      Return True
    ElseIf mPersona.Entidadjuridica IsNot Nothing AndAlso mPersona.Entidadjuridica.Guardar Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mPersona.NombreCompleto)
      Return True
    Else
      'Personas.CancelEdit()
      MsgBox("No se puede guardar Persona" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoPersona_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPersona.Eliminar() AndAlso Personas.Current IsNot Nothing Then
      Personas.RemoveCurrent()
      Me.Close()
    Else
      'Personas.CancelEdit()
      MsgBox("No se puede eliminar Persona" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoPersona_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPersona_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPersona_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPersona_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoPersona_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _OpcionActual, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoPersona_Inicializar(Me, Nothing)
  End Sub

  Private Sub FrmMantenimientoPersona_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Persona"
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

End Class
