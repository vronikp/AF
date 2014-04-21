Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoProveedor
  '#Region "IOpcion"
  '  Private mOperadorDatos As OperadorDatos = Nothing
  '  Public Property OperadorDatos() As OperadorDatos
  '    Get
  '      Return mOperadorDatos
  '    End Get
  '    Set(ByVal value As OperadorDatos)
  '      mOperadorDatos = value
  '    End Set
  '  End Property
  '#End Region

#Region "Parametros"
  Public Property Proveedores() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mProveedor As Proveedor = Nothing
  Public Property Proveedor() As Proveedor
    Get
      Return mProveedor
    End Get
    Set(ByVal value As Proveedor)
      mProveedor = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _proveedores As New ProveedorList
        _proveedores.Add(mProveedor)
        MyBase.BindingSource1.DataSource = GetType(Proveedor)
        MyBase.BindingSource1.DataSource = _proveedores
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mProveedor = Proveedores.Current
    If mProveedor IsNot Nothing Then
      Me.CtlPersona1.Entidad = mProveedor.Entidad
    End If
    Me.chkVisible.Checked = mProveedor.Provee_Visible
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoProveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mProveedor.EsNuevo
    If _esnuevo AndAlso Proveedores.Current IsNot Nothing Then
      Proveedores.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Proveedores eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Proveedor As Proveedor = New Proveedor(Sistema.OperadorDatos, True)
    e.NewObject = _Proveedor
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoProveedor_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    Me.CtlPersona1.Mapear_datos()
    mProveedor.Provee_Visible = Me.chkVisible.Checked
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_Datos()
    Dim _esnuevo As Boolean = mProveedor.EsNuevo
    If mProveedor.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mProveedor.NombreCompleto)

      Return True
    Else
      'Proveedores.CancelEdit()
      MsgBox("No se puede guardar Proveedor" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoProveedor_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mProveedor.Eliminar() AndAlso Proveedores.Current IsNot Nothing Then
      Proveedores.RemoveCurrent()
      Me.Close()
    Else
      'Proveedores.CancelEdit()
      MsgBox("No se puede eliminar Proveedor" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoProveedor_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoProveedor_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoProveedor_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoProveedor_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoProveedor_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoProveedores)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoProveedor_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Proveedor"
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub
End Class
