Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoTransaccionActivo
#Region "Parametros"
  Public Property TransaccionActivos() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mTransaccionActivo As TransaccionActivo = Nothing
  Public Property TransaccionActivo() As TransaccionActivo
    Get
      Return mTransaccionActivo
    End Get
    Set(ByVal value As TransaccionActivo)
      mTransaccionActivo = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _TransaccionActivos As New TransaccionActivoList
        _TransaccionActivos.Add(mTransaccionActivo)
        MyBase.BindingSource1.DataSource = GetType(TransaccionActivo)
        MyBase.BindingSource1.DataSource = _TransaccionActivos
      End If
    End Set
  End Property

  Public Property Ubicacion As WWTSParametroDet
    Get
      Return Me.CtlUbicacionActivo1.ParametroDet
    End Get
    Set(value As WWTSParametroDet)
      Me.CtlUbicacionActivo1.ParametroDet = value
    End Set
  End Property

  Public Property Custodio As Empleado
    Get
      Return Me.CtlBuscaEmpleado1.Empleado
    End Get
    Set(value As Empleado)
      Me.CtlBuscaEmpleado1.Empleado = value
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If

    mTransaccionActivo = TransaccionActivos.Current
    If mTransaccionActivo Is Nothing Then
      Exit Sub
    End If

    pnlcabecera.Enabled = mTransaccionActivo.EsNuevo
    Me.txtcodigo.Enabled = False
    Me.ComboBoxUsuario1.Enabled = False
    Me.dtfecha.Enabled = Restriccion.Restri_VerConfidencial AndAlso mTransaccionActivo.EsNuevo

    Me.chkSolicitarconfirmacion.Enabled = mTransaccionActivo.EsNuevo AndAlso Not mUsuario.Usuari_RequerirAprobacionCambioCustodio And Me.chkcambiarcustodio.Checked

    Me.txtcodigo.Value = mTransaccionActivo.Transa_Codigo
    Me.ComboBoxUsuario1.Usuario = mTransaccionActivo.Usuario
    If mTransaccionActivo.EsNuevo Then
      Me.ComboBoxUsuario1.Usuario = mUsuario
      Me.chkSolicitarconfirmacion.Checked = mUsuario.Usuari_RequerirAprobacionCambioCustodio
    End If
    Me.txtdescripcion.Text = mTransaccionActivo.Transa_Observacion
    Me.dtfecha.Value = mTransaccionActivo.Transa_Fecha

    If mTransaccionActivo.EsNuevo Then
      Me.bsdets.DataSource = mTransaccionActivo.Activos
      Me.dgdets.AutoDiscover()
      Me.SplitContainer1.Panel2Collapsed = True
    Else
      Me.bscustodio.DataSource = mTransaccionActivo.CambioCustodioList
      Me.dgcustodios.AutoDiscover()
      Me.bsubicacion.DataSource = mTransaccionActivo.CambioUbicacionList
      Me.dgubicaciones.AutoDiscover()
      Me.SplitContainer1.Panel1Collapsed = True
    End If
  End Sub
#End Region

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoTransaccionActivo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    Dim _esnuevo As Boolean = mTransaccionActivo.EsNuevo
    If _esnuevo AndAlso TransaccionActivos.Current IsNot Nothing Then
      TransaccionActivos.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "TransaccionActivos eventos"
  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    Dim _TransaccionActivo As TransaccionActivo = New TransaccionActivo(Sistema.OperadorDatos, True)
    e.NewObject = _TransaccionActivo
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoTransaccionActivo_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    mTransaccionActivo.Transa_Codigo = Me.txtcodigo.Value
    mTransaccionActivo.Usuario = Me.ComboBoxUsuario1.Usuario
    mTransaccionActivo.Transa_Observacion = Me.txtdescripcion.Text
    mTransaccionActivo.Transa_Fecha = Me.dtfecha.Value
    If mTransaccionActivo.EsNuevo Then
      If Not Me.chkcambiarubicacion.Checked AndAlso Not Me.chkcambiarcustodio.Checked Then
        Throw New Exception("Debe seleccionar algún tipo de cambio")
      End If
      If Me.chkcambiarubicacion.Checked Then
        If Me.CtlUbicacionActivo1.ParametroDet Is Nothing OrElse Not Me.CtlUbicacionActivo1.ParametroDet.Parame_Codigo = Enumerados.EnumParametros.UbicacionActivo Then
          Throw New Exception("Debe seleccionar una ubicación")
        End If
      End If
      If Me.chkcambiarcustodio.Checked Then
        If Me.CtlBuscaEmpleado1.Empleado Is Nothing Then
          Throw New Exception("Debe seleccionar un custodio")
        End If
        If Me.chkSolicitarconfirmacion.Checked And String.IsNullOrWhiteSpace(Me.CtlBuscaEmpleado1.Empleado.Entidadnatural.Entidad.EmailsString) Then
          Throw New Exception("No existe un email definido para el custodio al que le solicita una confirmación")
        End If
        Dim _empleado As Empleado = mUsuario.Empleado
        If _empleado IsNot Nothing AndAlso Me.CtlBuscaEmpleado1.Empleado.Entida_Codigo = _empleado.Entida_Codigo Then
          Throw New Exception("No se puede hacer cambios de custodio hacia si mismo")
        End If
      End If
    End If
  End Sub

  Private Function Guardar_datos() As Boolean
    Try
      Mapear_Datos()
      Dim _esnuevo As Boolean = mTransaccionActivo.EsNuevo
      If mTransaccionActivo.Guardar(IIf(Me.chkcambiarcustodio.Checked, Me.CtlBuscaEmpleado1.Empleado, Nothing), Me.chkSolicitarconfirmacion.Checked, IIf(Me.chkcambiarubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing)) Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTransaccionActivo.Descripcion)
        llenar_datos()
      Else
        'TransaccionActivos.CancelEdit()
        Throw New Exception("No se puede guardar Transacción Activo")
      End If
      Return True
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End Try
    Return False
  End Function

  Private Sub FrmMantenimientoTransaccionActivo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mTransaccionActivo.Eliminar() AndAlso TransaccionActivos.Current IsNot Nothing Then
      TransaccionActivos.RemoveCurrent()
      Me.Close()
    Else
      'TransaccionActivos.CancelEdit()
      MsgBox("No se puede eliminar TransaccionActivo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoTransaccionActivo_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTransaccionActivo_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTransaccionActivo_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoTransaccionActivo_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    FrmMantenimientoTransaccionActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private mUsuario As WWTSUsuario = Nothing

  Private Sub FrmMantenimientoTransaccionActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Transacción Activo"

    Me.PuedeGuardar = True
    Me.PuedeImprimir = True

    mUsuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

    Me.ComboBoxUsuario1.OperadorDatos = Sistema.OperadorDatos
    Me.ComboBoxUsuario1.Llenar_datos()

    Me.CtlBuscaEmpleado1.SoloActivos = True
    Me.CtlBuscaEmpleado1.OperadorDatos = Sistema.OperadorDatos
    Me.CtlBuscaEmpleado1.Llenar_Datos()

    Me.CtlUbicacionActivo1.SoloVisibles = True
    Me.CtlUbicacionActivo1.PardetRaiz = mUsuario.PardetUbicacion
    Me.CtlUbicacionActivo1.llenar_datos()
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub

  Private Sub btnnuevocomp_Click(sender As System.Object, e As System.EventArgs) Handles btnnuevocomp.Click
    Dim f As New FrmListaActivos(Sistema, Enumerados.EnumOpciones.ListadoActivos, True)
    f.MultiSelect = True
    f.ShowDialog()

    Dim _activos As ActivoList = f.ActivosSeleccionados
    For Each _activo As Activo In _activos
      Dim _existe As Boolean = False
      For Each _act As Activo In mTransaccionActivo.Activos
        If _act.Activo_Codigo = _activo.Activo_Codigo Then
          _existe = True
        End If
      Next

      If Not _existe Then
        mTransaccionActivo.Activos.Add(_activo)
      End If
    Next
    Me.dgdets.AutoDiscover()
  End Sub

  Private Sub btnelimcomp_Click(sender As System.Object, e As System.EventArgs) Handles btnelimcomp.Click
    For Each _row As DataGridViewRow In Me.dgdets.SelectedRows
      'mTransaccionActivo.TransaccionActivoDetsEli.Add(CType(Me.dgdets.DataSource.datasource, TransaccionActivoDetList)(_row.Index))
      mTransaccionActivo.Activos.RemoveAt(_row.Index)
    Next
  End Sub

  Private Sub dtfecfin_ValueChanged(sender As System.Object, e As System.EventArgs)

  End Sub

  Private Sub dgdets_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdets.CellContentClick

  End Sub

  Private Sub chkcambiarcustodio_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkcambiarcustodio.CheckedChanged
    Me.CtlBuscaEmpleado1.Enabled = Me.chkcambiarcustodio.Checked
    'Me.chkSolicitarconfirmacion.Enabled = Me.chkcambiarcustodio.Checked
    Me.chkSolicitarconfirmacion.Enabled = mTransaccionActivo.EsNuevo AndAlso Not mUsuario.Usuari_RequerirAprobacionCambioCustodio And Me.chkcambiarcustodio.Checked
  End Sub

  Private Sub chkcambiarubicacion_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkcambiarubicacion.CheckedChanged
    Me.CtlUbicacionActivo1.Enabled = Me.chkcambiarubicacion.Checked
  End Sub

  Private Sub FrmMantenimientoTransaccionActivo_Imprimir(sender As Object, e As System.EventArgs) Handles Me.Imprimir
    If mTransaccionActivo Is Nothing Then
      Exit Sub
    End If
    If mTransaccionActivo.EsNuevo Then
      If MsgBox("¿Desea guardar la transacción para poder imprimirla?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        If Not Guardar_datos() Then
          Exit Sub
        End If
      Else
        Exit Sub
      End If
    End If

    cmImprimir.Show(MousePosition)
  End Sub

  Private Sub mnuacta_Click(sender As Object, e As System.EventArgs) Handles mnuacta.Click
    Dim f As New FrmReporteTransaccionActivo(Sistema, Enumerados.EnumOpciones.ListadoTransaccionActivos)
    f.TransaccionActivo = mTransaccionActivo
    f.ShowDialog()
  End Sub

  Private Sub mnumail_Click(sender As Object, e As System.EventArgs) Handles mnumail.Click
    Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.ListadoTransaccionActivos)
    f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "Proc_CambioCustodioEnviarMail")
    f.Valores = New Object() {mUsuario.Usuari_Codigo, mTransaccionActivo.Transa_Codigo}
    f.EnviarMailAutomaticoyCerrar = True
    'f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbriadminrElemento)
    f.ShowDialog()
  End Sub

  Private Sub cmImprimir_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmImprimir.Opening
    Me.mnumail.Enabled = bscustodio.Count > 0 And mTransaccionActivo.ContieneSolicitarConfirmacionCambioCustodio
  End Sub
End Class
