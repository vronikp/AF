Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoFacturaActivo
 Private mProveedor As Proveedor = Nothing
  Public Property Proveedor As Proveedor
    Get
      Return mProveedor
    End Get
    Set(value As Proveedor)
      mProveedor = value
    End Set
  End Property

#Region "Parametros"
  Public Property FacturaActivos() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mFacturaActivo As FacturaActivo = Nothing
  Public Property FacturaActivo() As FacturaActivo
    Get
      Return mFacturaActivo
    End Get
    Set(ByVal value As FacturaActivo)
      mFacturaActivo = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _FacturaActivos As New FacturaActivoList
        _FacturaActivos.Add(mFacturaActivo)
        MyBase.BindingSource1.DataSource = GetType(FacturaActivo)
        MyBase.BindingSource1.DataSource = _FacturaActivos
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mFacturaActivo = FacturaActivos.Current
    If mFacturaActivo Is Nothing Then
      Exit Sub
    End If

    Me.CtlBuscaProveedor1.Proveedor = mFacturaActivo.Proveedor
    Me.txtnumerofactura.Text = mFacturaActivo.Factura_Numero
    Me.txtReferencia.Text = mFacturaActivo.Factura_Referencia
    Me.dtfecfactura.Value = mFacturaActivo.Factura_Fecha
    Me.txtvalortotal.Value = mFacturaActivo.Factura_ValorTotal
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoFacturaActivo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mFacturaActivo.EsNuevo
    If _esnuevo AndAlso FacturaActivos.Current IsNot Nothing Then
      FacturaActivos.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "FacturaActivos eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _FacturaActivo As FacturaActivo = New FacturaActivo(Sistema.OperadorDatos, True)
    e.NewObject = _FacturaActivo
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoFacturaActivo_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mFacturaActivo.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    mFacturaActivo.Factura_Numero = Me.txtnumerofactura.Text
    mFacturaActivo.Factura_Referencia = Me.txtReferencia.Text
    mFacturaActivo.Factura_Fecha = Me.dtfecfactura.Value
    mFacturaActivo.Factura_ValorTotal = Me.txtvalortotal.Value
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_Datos()
    Dim _esnuevo As Boolean = mFacturaActivo.EsNuevo
    If mFacturaActivo.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mFacturaActivo.Descripcion)

      Return True
    Else
      'FacturaActivos.CancelEdit()
      MsgBox("No se puede guardar FacturaActivo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoFacturaActivo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mFacturaActivo.Eliminar() AndAlso FacturaActivos.Current IsNot Nothing Then
      FacturaActivos.RemoveCurrent()
      Me.Close()
    Else
      'FacturaActivos.CancelEdit()
      MsgBox("No se puede eliminar FacturaActivo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoFacturaActivo_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoFacturaActivo_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoFacturaActivo_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoFacturaActivo_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoFacturaActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoFacturaActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoFacturaActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoFacturaActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Factura Activo"

    Me.CtlBuscaProveedor1.SoloActivos = True
    Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaProveedor1.Llenar_Datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub
End Class
