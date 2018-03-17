Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas


Public Class FrmMantenimientoTransaccionBaja
#Region "Parametros"
    Public Property TransaccionBajas() As BindingSource
        Get
            Return MyBase.BindingSource1
        End Get
        Set(ByVal value As BindingSource)
            MyBase.BindingSource1 = value
            llenar_datos()
        End Set
    End Property

    Private mTransaccionBaja As TransaccionBaja = Nothing
    Public Property TransaccionBaja() As TransaccionBaja
        Get
            Return mTransaccionBaja
        End Get
        Set(ByVal value As TransaccionBaja)
            mTransaccionBaja = value
            If MyBase.BindingSource1.DataSource Is Nothing Then
                Dim _TransaccionBajas As New TransaccionBajaList
                _TransaccionBajas.Add(mTransaccionBaja)
                MyBase.BindingSource1.DataSource = GetType(TransaccionBaja)
                MyBase.BindingSource1.DataSource = _TransaccionBajas
            End If
        End Set
    End Property

    Public Property MotivoBaja As WWTSParametroDet
        Get
            Return Me.cboMotivoBaja.ParametroDet
        End Get
        Set(value As WWTSParametroDet)
            Me.cboMotivoBaja.ParametroDet = value
        End Set
    End Property

    Sub llenar_datos()
        If Sistema.OperadorDatos Is Nothing Then
            Exit Sub
        End If

        mTransaccionBaja = TransaccionBajas.Current
        If mTransaccionBaja Is Nothing Then
            Exit Sub
        End If

        'pnlcabecera.Enabled = mTransaccionBaja.EsNuevo
        ToolStrip2.Enabled = mTransaccionBaja.EsNuevo
        Me.txtcodigo.Enabled = False
        Me.ComboBoxUsuario1.Enabled = False
        Me.dtfecha.Enabled = Restriccion.Restri_VerConfidencial AndAlso mTransaccionBaja.EsNuevo

        Me.txtcodigo.Value = mTransaccionBaja.TraBaj_Codigo
        Me.ComboBoxUsuario1.Usuario = mTransaccionBaja.Usuario
        If mTransaccionBaja.EsNuevo Then
            Me.ComboBoxUsuario1.Usuario = mUsuario
        End If

        Me.cboMotivoBaja.Enabled = mTransaccionBaja.EsNuevo
        Me.txtdescripcion.Text = mTransaccionBaja.TraBaj_Observacion
        Me.dtfecha.Value = mTransaccionBaja.TraBaj_Fecha

        Me.bsdets.DataSource = mTransaccionBaja.Activos
        Me.dgdets.AutoDiscover()
    End Sub
#End Region

#Region "Cerrar y Cancelar"
    Private Sub FrmMantenimientoTransaccionBaja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Cancelar_Nuevo()
    End Sub

    Private Function Cancelar_Nuevo() As Boolean
        Dim _esnuevo As Boolean = mTransaccionBaja.EsNuevo
        If _esnuevo AndAlso TransaccionBajas.Current IsNot Nothing Then
            TransaccionBajas.RemoveCurrent()
        End If
        Return _esnuevo
    End Function
#End Region

#Region "TransaccionBajas eventos"
    Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
        Dim _TransaccionBaja As TransaccionBaja = New TransaccionBaja(Sistema.OperadorDatos, True)
        e.NewObject = _TransaccionBaja
    End Sub

    Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
        llenar_datos()
    End Sub
#End Region

#Region "Guardar y Eliminar"
    Private Sub FrmMantenimientoTransaccionBaja_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
        e.Cancel = Not Guardar_datos()
    End Sub

    Private Sub Mapear_Datos()
        mTransaccionBaja.TraBaj_Codigo = Me.txtcodigo.Value
        mTransaccionBaja.Usuario = Me.ComboBoxUsuario1.Usuario
        mTransaccionBaja.TraBaj_Observacion = Me.txtdescripcion.Text
        mTransaccionBaja.TraBaj_Fecha = Me.dtfecha.Value
        mTransaccionBaja.PardetTipoBaja = Me.cboMotivoBaja.ParametroDet

        If mTransaccionBaja.EsNuevo Then
            If cboMotivoBaja.ValueMember Is Nothing Then
                Throw New Exception("Debe seleccionar algún motivo de baja")
            End If
        End If
    End Sub

    Private Function Guardar_datos() As Boolean
        Try
            Mapear_Datos()
            Dim _esnuevo As Boolean = mTransaccionBaja.EsNuevo
            If mTransaccionBaja.Guardar(Restriccion) Then
                Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mTransaccionBaja.Descripcion)
                llenar_datos()
            Else
                'TransaccionBajas.CancelEdit()
                Throw New Exception("No se puede guardar Transacción Baja")
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    Private Sub FrmMantenimientoTransaccionBaja_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mTransaccionBaja.Eliminar() AndAlso TransaccionBajas.Current IsNot Nothing Then
            TransaccionBajas.RemoveCurrent()
            Me.Close()
        Else
            'TransaccionBajas.CancelEdit()
            MsgBox("No se puede eliminar TransaccionBaja" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub
#End Region

#Region "Mover"
    Private Sub FrmMantenimientoTransaccionBaja_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoTransaccionBaja_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoTransaccionBaja_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
        e.Cancel = Cancelar_Nuevo()
    End Sub

    Private Sub FrmMantenimientoTransaccionBaja_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
        e.Cancel = Cancelar_Nuevo()
    End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.DarBajaActivo)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FrmMantenimientoTransaccionBaja_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.DarBajaActivo)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

    Private mUsuario As WWTSUsuario = Nothing

    Private Sub FrmMantenimientoTransaccionBaja_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        MyBase.Tabla = "Transacción Bajas de Activos"

        Me.PuedeGuardar = True
        Me.PuedeImprimir = True

        mUsuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

        Me.ComboBoxUsuario1.OperadorDatos = Sistema.OperadorDatos
        Me.ComboBoxUsuario1.Llenar_datos()

        Me.cboMotivoBaja.OperadorDatos = Sistema.OperadorDatos
        Me.cboMotivoBaja.Parametro = Enumerados.EnumParametros.TipoBajaActivo
        Me.cboMotivoBaja.Llenar_Datos()

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
            For Each _act As Activo In mTransaccionBaja.Activos
                If _act.Activo_Codigo = _activo.Activo_Codigo Then
                    _existe = True
                End If
            Next

            If Not _existe Then
                mTransaccionBaja.Activos.Add(_activo)
            End If
        Next
        Me.dgdets.AutoDiscover()
    End Sub

    Private Sub btnelimcomp_Click(sender As System.Object, e As System.EventArgs) Handles btnelimcomp.Click
        For Each _row As DataGridViewRow In Me.dgdets.SelectedRows
            'mTransaccionBaja.TransaccionBajaDetsEli.Add(CType(Me.dgdets.DataSource.datasource, TransaccionBajaDetList)(_row.Index))
            mTransaccionBaja.Activos.RemoveAt(_row.Index)
        Next
    End Sub

    Private Sub dtfecfin_ValueChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub dgdets_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgdets.CellContentClick

    End Sub

    Private Sub FrmMantenimientoTransaccionBaja_Imprimir(sender As Object, e As System.EventArgs) Handles Me.Imprimir
        If mTransaccionBaja Is Nothing Then
            Exit Sub
        End If
        If mTransaccionBaja.EsNuevo Then
            If MsgBox("¿Desea guardar la transacción para poder imprimirla?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
                If Restriccion.Restri_Ingreso Then
                    If Not Guardar_datos() Then
                        Exit Sub
                    End If
                Else
                    MsgBox("No tiene los permisos necesarios para guardar la transacción.")
                    Exit Sub
                End If
            Else
                Exit Sub
            End If
        End If
        'cmImprimir.Show(MousePosition)
        Dim f As New FrmReporteTransaccionBaja(Sistema, Enumerados.EnumOpciones.DarBajaActivo)
        f.TransaccionBaja = mTransaccionBaja
        f.ShowDialog()
    End Sub


    Private Sub mnumail_Click(sender As Object, e As System.EventArgs)
        Dim f As New Infoware.Reporteador.FrmLista(Sistema, Enumerados.EnumOpciones.DarBajaActivo)
        f.Reporte = New Infoware.Reporteador.Reporte(Sistema.OperadorDatos, "Proc_CambioCustodioEnviarMail")
        f.Valores = New Object() {mUsuario.Usuari_Codigo, mTransaccionBaja.TraBaj_Codigo}
        f.EnviarMailAutomaticoyCerrar = True
        'f.objAbrirElemento = New Infoware.Reporteador.FrmLista.AbrirElemento(AddressOf AbriadminrElemento)
        f.ShowDialog()
    End Sub

    Private Sub cmImprimir_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmImprimir.Opening
        'Me.mnumail.Enabled = bscustodio.Count > 0
        'Me.mnuacta.Enabled = bscustodio.Count > 0
        'Me.mnuUbicacion.Enabled = bsubicacion.Count > 0
    End Sub

    Private Sub mnuUbicacion_Click(sender As System.Object, e As System.EventArgs)
        'Dim f As New FrmReporteTransaccionBaja(Sistema, Enumerados.EnumOpciones.ListadoTransaccionBajas)
        'f.ReporteTransaccionTipo = clsReporteTransaccionBaja.EnumListaTransaccionTipo.Ubicacion
        'f.TransaccionBaja = mTransaccionBaja
        'f.ShowDialog()
    End Sub
End Class
