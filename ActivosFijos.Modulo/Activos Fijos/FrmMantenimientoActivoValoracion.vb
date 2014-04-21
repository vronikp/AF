Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoActivoValoracion

#Region "Parametros"
  Public Property ActivoValores() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mActivoValor As ActivoValor = Nothing
  Public Property ActivoValor() As ActivoValor
    Get
      Return mActivoValor
    End Get
    Set(ByVal value As ActivoValor)
      mActivoValor = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _ActivoValores As New ActivoValorList
        _ActivoValores.Add(mActivoValor)
        MyBase.BindingSource1.DataSource = GetType(ActivoValor)
        MyBase.BindingSource1.DataSource = _ActivoValores
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mActivoValor = ActivoValores.Current
    If mActivoValor Is Nothing Then
      Exit Sub
    End If

    Me.lblactivo.Text = mActivoValor.Activo.Descripcion
    Me.cbotipodepreciacion.ParametroDet = mActivoValor.PardetTipoDepreciacion
    Me.txtcostoactivo.Value = mActivoValor.ActVal_Costo
    Me.txtvalorsalvamento.Value = mActivoValor.ActVal_Salvamento
    Me.txtperiodosdepreciables.Value = mActivoValor.ActVal_PeriodosDepreciables
    If mActivoValor.EsNuevo Then
      Me.txtperiodosdepreciables.Value = mActivoValor.Activo.PardetTipoActivo.Pardet_DatoInt1
    End If
    Me.cboFrecuenciaDepreciacion.ParametroDet = mActivoValor.PardetFrecuenciaDepreciacion
    Me.dtfecvaloracion.Value = mActivoValor.ActVal_FechaValoracion
    Me.CtlBuscaPerito1.Perito = mActivoValor.Perito
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoActivoValoracion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esAceptado As Boolean = Not mActivoValor.EsNuevo
    If Not _esAceptado AndAlso ActivoValores.Current IsNot Nothing Then
      ActivoValores.RemoveCurrent()
    End If
    Return _esAceptado
  End Function
#End Region

#Region "ActivoValores eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _ActivoValor As ActivoValor = New ActivoValor(Sistema.OperadorDatos, True)
    e.NewObject = _ActivoValor
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoActivoValoracion_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mActivoValor.PardetTipoDepreciacion = Me.cbotipodepreciacion.ParametroDet
    mActivoValor.ActVal_Costo = Me.txtcostoactivo.Value
    mActivoValor.ActVal_Salvamento = Me.txtvalorsalvamento.Value
    mActivoValor.ActVal_PeriodosDepreciables = Me.txtperiodosdepreciables.Value
    mActivoValor.PardetFrecuenciaDepreciacion = Me.cboFrecuenciaDepreciacion.ParametroDet
    mActivoValor.ActVal_FechaValoracion = Me.dtfecvaloracion.Value
    mActivoValor.Perito = Me.CtlBuscaPerito1.Perito
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_Datos()
      Dim _esnuevo As Boolean = mActivoValor.EsNuevo
      If Not mActivoValor.Guardar() Then
        Throw New Exception("No se puede guardar Activo Valor")
      End If
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mActivoValor.Descripcion)
      Return True
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoActivoValoracion_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    'If mActivoValor.Eliminar() AndAlso ActivoValores.Current IsNot Nothing Then
    '  Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Eliminacion, mActivoValor.Descripcion)
    '  ActivoValores.RemoveCurrent()
    '  Me.Close()
    'Else
    '  'ActivoValores.CancelEdit()
    '  MsgBox("No se puede eliminar ActivoValor" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    'End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoActivoValoracion_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoValoracion_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoValoracion_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivoValoracion_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoActivoValoracion_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivoValoracion_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Valoración"

    Me.CtlBuscaPerito1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaPerito1.Llenar_Datos()

    Me.cboFrecuenciaDepreciacion.OperadorDatos = Sistema.OperadorDatos
    Me.cboFrecuenciaDepreciacion.Parametro = Enumerados.EnumParametros.FrecuenciaDepreciacion
    Me.cboFrecuenciaDepreciacion.Llenar_Datos()

    Me.cbotipodepreciacion.OperadorDatos = Sistema.OperadorDatos
    Me.cbotipodepreciacion.Parametro = Enumerados.EnumParametros.TipoDepreciacion
    Me.cbotipodepreciacion.Llenar_Datos()

  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub txtcostoactivo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcostoactivo.TextChanged, txtvalorsalvamento.TextChanged
    Me.txtvaloradepreciar.Value = Me.txtcostoactivo.Value - Me.txtvalorsalvamento.Value
  End Sub

End Class
