Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoActivoComponente

#Region "Parametros"
  Public Property ActivoComponentes() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mActivoComponente As ActivoComponente = Nothing
  Public Property ActivoComponente() As ActivoComponente
    Get
      Return mActivoComponente
    End Get
    Set(ByVal value As ActivoComponente)
      mActivoComponente = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _ActivoComponentes As New ActivoComponenteList
        _ActivoComponentes.Add(mActivoComponente)
        MyBase.BindingSource1.DataSource = GetType(ActivoComponente)
        MyBase.BindingSource1.DataSource = _ActivoComponentes
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mActivoComponente = ActivoComponentes.Current
    If mActivoComponente Is Nothing Then
      Exit Sub
    End If

    Me.txtdescripcion.Text = mActivoComponente.ActCom_Descripcion
    Me.cbomarca.ParametroDet = mActivoComponente.PardetMarca
    Me.txtmodelo.Text = mActivoComponente.ActCom_Modelo
    Me.txtserie.Text = mActivoComponente.ActCom_Serie
    Me.CtlBuscaProveedor1.Proveedor = mActivoComponente.Proveedor
    Me.txtfactura.Text = mActivoComponente.ActCom_Factura
    Me.dtfecfactura.Value = mActivoComponente.ActCom_FechaAdquisicion
    Me.dtfecingreso.Value = mActivoComponente.ActCom_FechaIngreso
    Me.chkerogacion.Checked = mActivoComponente.ActCom_esErogacion
    If Not mActivoComponente.EsNuevo AndAlso Me.chkerogacion.Checked Then
      Me.chkerogacion.Enabled = False
      Me.pnlerogacion.Enabled = False
    End If
    If mActivoComponente.ActCom_esErogacion Then
      Me.txtvalorerogacion.Value = mActivoComponente.ActCom_ValorErogacion
    End If
    Me.chkbaja.Checked = Not mActivoComponente.ActCom_Activo
    If chkbaja.Checked Then
      Me.dtfechabaja.Value = mActivoComponente.ActCom_FechaBaja
    End If
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoActivoComponente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esAceptado As Boolean = mActivoComponente.Aceptado
    If Not _esAceptado AndAlso ActivoComponentes.Current IsNot Nothing Then
      ActivoComponentes.RemoveCurrent()
    End If
    Return _esAceptado
  End Function
#End Region

#Region "ActivoComponentes eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _ActivoComponente As ActivoComponente = New ActivoComponente(Sistema.OperadorDatos, True)
    e.NewObject = _ActivoComponente
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoActivoComponente_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mActivoComponente.ActCom_Descripcion = Me.txtdescripcion.Text
    mActivoComponente.PardetMarca = Me.cbomarca.ParametroDet
    mActivoComponente.ActCom_Modelo = Me.txtmodelo.Text
    mActivoComponente.ActCom_Serie = Me.txtserie.Text
    mActivoComponente.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    mActivoComponente.ActCom_Factura = Me.txtfactura.Text
    mActivoComponente.ActCom_FechaAdquisicion = Me.dtfecfactura.Value
    mActivoComponente.ActCom_FechaIngreso = Me.dtfecingreso.Value
    mActivoComponente.ActCom_esErogacion = Me.chkerogacion.Checked
    If mActivoComponente.ActCom_esErogacion Then
      mActivoComponente.ActCom_ValorErogacion = Me.txtvalorerogacion.Value
    End If
    mActivoComponente.ActCom_Activo = Not Me.chkbaja.Checked
    If Not mActivoComponente.ActCom_Activo Then
      mActivoComponente.ActCom_FechaBaja = Me.dtfechabaja.Value
    End If
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_Datos()
      If Not mActivoComponente.Activo.EsNuevo Then
        Dim _esnuevo As Boolean = mActivoComponente.EsNuevo
        If Not mActivoComponente.Guardar() Then
          Throw New Exception("No se puede guardar Activo Componente")
        End If
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mActivoComponente.Descripcion)
        mActivoComponente.Aceptado = True
      End If
      Return True
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoActivoComponente_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    'If mActivoComponente.Eliminar() AndAlso ActivoComponentes.Current IsNot Nothing Then
    '  Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Eliminacion, mActivoComponente.Descripcion)
    '  ActivoComponentes.RemoveCurrent()
    '  Me.Close()
    'Else
    '  'ActivoComponentes.CancelEdit()
    '  MsgBox("No se puede eliminar ActivoComponente" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    'End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoActivoComponente_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoComponente_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoComponente_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoComponente_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoActivoComponente_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivoComponente_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Componentes"

    Me.CtlBuscaProveedor1.SoloActivos = True
    Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaProveedor1.Llenar_Datos()

    Me.cbomarca.OperadorDatos = Sistema.OperadorDatos
    Me.cbomarca.Parametro = Enumerados.EnumParametros.MarcaActivo
    Me.cbomarca.Llenar_Datos()

  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub chkerogacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkerogacion.CheckedChanged
    Me.pnlerogacion.Visible = Me.chkerogacion.Checked
  End Sub

  Private Sub chkbaja_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkbaja.CheckedChanged
    Me.pnlbaja.Visible = Me.chkbaja.Checked
  End Sub
End Class
