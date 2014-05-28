Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoPoliza
#Region "Parametros"
  Public Property Polizas() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mPoliza As Poliza = Nothing
  Public Property Poliza() As Poliza
    Get
      Return mPoliza
    End Get
    Set(ByVal value As Poliza)
      mPoliza = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Polizas As New PolizaList
        _Polizas.Add(mPoliza)
        MyBase.BindingSource1.DataSource = GetType(Poliza)
        MyBase.BindingSource1.DataSource = _Polizas
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mPoliza = Polizas.Current
    If mPoliza Is Nothing Then
      Exit Sub
    End If

    Me.CtlBuscaProveedor1.Proveedor = mPoliza.Proveedor
    Me.txtdescripcion.Text = mPoliza.Poliza_Descripcion
    Me.dtfecinicio.Value = mPoliza.Poliza_FechaInicio
    Me.dtfecfin.Value = mPoliza.Poliza_FechaFin
        Me.txtvalor.Value = mPoliza.Poliza_ValorAsegurado
        Me.cbotipopoliza.ParametroDet = mPoliza.PardetTipoPoliza

    Me.bsdets.DataSource = mPoliza.PolizaDets
    Me.dgdets.AutoDiscover()
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoPoliza_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mPoliza.EsNuevo
    If _esnuevo AndAlso Polizas.Current IsNot Nothing Then
      Polizas.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Polizas eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _Poliza As Poliza = New Poliza(Sistema.OperadorDatos, True)
    e.NewObject = _Poliza
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoPoliza_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mPoliza.Proveedor = Me.CtlBuscaProveedor1.Proveedor
    mPoliza.Poliza_Descripcion = Me.txtdescripcion.Text
    mPoliza.Poliza_FechaInicio = Me.dtfecinicio.Value
    mPoliza.Poliza_FechaFin = Me.dtfecfin.Value
        mPoliza.Poliza_ValorAsegurado = Me.txtvalor.Value
        mPoliza.PardetTipoPoliza = Me.cbotipopoliza.ParametroDet
  End Sub

  Private Function Guardar_datos() As Boolean
    Mapear_Datos()
    Dim _esnuevo As Boolean = mPoliza.EsNuevo
    If mPoliza.Guardar() Then
      Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mPoliza.Descripcion)

      Return True
    Else
      'Polizas.CancelEdit()
      MsgBox("No se puede guardar Poliza" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End If
  End Function

  Private Sub FrmMantenimientoPoliza_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mPoliza.Eliminar() AndAlso Polizas.Current IsNot Nothing Then
      Polizas.RemoveCurrent()
      Me.Close()
    Else
      'Polizas.CancelEdit()
      MsgBox("No se puede eliminar Poliza" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoPoliza_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPoliza_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPoliza_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoPoliza_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPolizas)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoPoliza_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoPolizas)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoPoliza_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Póliza"

    Me.CtlBuscaProveedor1.SoloActivos = True
    Me.CtlBuscaProveedor1.OperadorDatos = Sistema.OperadorDatos
        Me.CtlBuscaProveedor1.Llenar_Datos()
        Me.cbotipopoliza.OperadorDatos = Sistema.OperadorDatos
        Me.cbotipopoliza.Parametro = Enumerados.EnumParametros.TipoPoliza
        Me.cbotipopoliza.Llenar_Datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

  End Sub

  Private Sub btnnuevocomp_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevocomp.Click
    Dim f As New FrmListaActivos(Sistema, Enumerados.EnumOpciones.ListadoActivos, True)
    f.MultiSelect = True
    f.ShowDialog()

    Dim _activos As ActivoList = f.ActivosSeleccionados
    For Each _activo As Activo In _activos
      Dim _existe As Boolean = False
      For Each _polidet As PolizaDet In mPoliza.PolizaDets
        If _polidet.Activo_Codigo = _activo.Activo_Codigo Then
          _existe = True
        End If
      Next

      If Not _existe Then
        Dim _polidet As New PolizaDet(Sistema.OperadorDatos, True)
        _polidet.Poliza = mPoliza
        _polidet.Activo = _activo

        mPoliza.PolizaDets.Add(_polidet)
      End If
    Next
    Me.dgdets.AutoDiscover()
  End Sub

  Private Sub btnelimcomp_Click(sender As System.Object, e As System.EventArgs) Handles btnelimcomp.Click
    For Each _row As DataGridViewRow In Me.dgdets.SelectedRows
      mPoliza.PolizaDetsEli.Add(CType(Me.dgdets.DataSource.datasource, PolizaDetList)(_row.Index))
      mPoliza.PolizaDets.RemoveAt(_row.Index)
    Next
  End Sub

  Private Sub dtfecfin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtfecfin.ValueChanged

  End Sub
End Class
