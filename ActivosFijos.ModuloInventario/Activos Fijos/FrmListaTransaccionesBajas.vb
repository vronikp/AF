Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmListaTransaccionBajas
    Private mTransaccionBaja As TransaccionBaja = Nothing
    Public Property TransaccionBaja() As TransaccionBaja
        Get
            If ListBindingSource.Current Is Nothing Then
                Return Nothing
            Else
                Return ListBindingSource.Current
            End If
        End Get
        Set(ByVal value As TransaccionBaja)
            If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
                Dim t As Integer = 0
                For Each _TransaccionBaja As TransaccionBaja In Me.ListBindingSource.DataSource
                    If _TransaccionBaja.TraBaj_Codigo = value.TraBaj_Codigo Then
                        ListBindingSource.Position = t
                    End If
                    t += 1
                Next
            End If
        End Set
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
    Private Sub FrmListaTransaccionBajas_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
        Abrir_Mantenimiento()
    End Sub

    Private Sub FrmListaTransaccionBajas_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub FrmListaTransaccionBajas_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
        Me.ListBindingSource.AddNew()
        Abrir_Mantenimiento()
    End Sub

    Sub Abrir_Mantenimiento()
        If ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim f As New FrmMantenimientoTransaccionBaja(Sistema, Restriccion)
        f.TransaccionBajas = ListBindingSource
        f.ShowDialog()
        If ListBindingSource.Count <= 1 Then
            RefrescarLista()
        End If
        f.Dispose()
    End Sub

    Private Sub FrmListaTransaccionBajas_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
        Llenar_datos(Me.combobuscar.Text)
    End Sub

    Private Sub FrmListaTransaccionBajas_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
        Llenar_datos()
    End Sub

    Private Sub FrmListaTransaccionBajas_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
        If mTransaccionBajas Is Nothing OrElse ListBindingSource.Current Is Nothing Then
            Exit Sub
        End If
        Dim mTransaccionBaja As TransaccionBaja
        mTransaccionBaja = ListBindingSource.Current
        If mTransaccionBaja.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
            ListBindingSource.RemoveCurrent()
        Else
            MsgBox("No se puede eliminar TransaccionBaja" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub FrmListaTransaccionBajas_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
        'imprimir
    End Sub
#End Region

#Region "Llenardatos"
    Private WithEvents mTransaccionBajas As TransaccionBajaList = Nothing

    Sub Llenar_datos(Optional ByVal _filtro As String = "")
        MyBase.Titulo = "Transacción Activos"
        MyBase.AgregarLeyenda = "Agregar una nueva Transacción Activo"

        Me.ListBindingSource.DataSource = GetType(TransaccionBaja)
        mTransaccionBajas = TransaccionBajaList.ObtenerLista(Sistema.OperadorDatos, New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo), _filtro)
        Dim mitemssort As New Infoware.Reglas.SortedView(mTransaccionBajas)
        ListBindingSource.DataSource = mitemssort
        Me.DataGridView1.AutoDiscover()
    End Sub

    Private Sub mTransaccionBajas_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mTransaccionBajas.AddingNew
        Dim _TransaccionBaja As TransaccionBaja = New TransaccionBaja(Sistema.OperadorDatos, True)
        e.NewObject = _TransaccionBaja
    End Sub
#End Region


#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.DarBajaActivo)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        EsBusqueda = _busqueda
        ' Add any initialization after the InitializeComponent() call.
        FrmListaTransaccionBajas_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.DarBajaActivo)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
    End Sub

    Private Sub FrmListaTransaccionBajas_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
        Llenar_datos()
    End Sub
#End Region

End Class
