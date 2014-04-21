Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas
Imports System.IO
Imports ActivosFijos.Reglas.Enumerados

Public Class FrmListaBajasActivo
  Private mActivo As Activo = Nothing
  Public Property Activo() As Activo
    Get
      If ListBindingSource.Current Is Nothing Then
        Return Nothing
      Else
        Return ListBindingSource.Current
      End If
    End Get
    Set(ByVal value As Activo)
      If Not ListBindingSource.Count = 0 And value IsNot Nothing Then
        Dim t As Integer = 0
        For Each _Activo As Activo In Me.ListBindingSource.DataSource
          If _Activo.Activo_Codigo = value.Activo_Codigo Then
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
  Private Sub FrmListaBajasActivo_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    Abrir_Mantenimiento()
  End Sub

  Private Sub FrmListaBajasActivo_Seleccionar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Seleccionar
    DialogResult = Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub FrmListaBajasActivo_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Agregar
    Me.ListBindingSource.AddNew()
    Abrir_Mantenimiento()
  End Sub

  Sub Abrir_Mantenimiento()
    'If ListBindingSource.Current Is Nothing Then
    '  Exit Sub
    'End If
    'Dim f As New FrmMantenimientoActivo(Sistema, Restriccion)
    'f.Activos = ListBindingSource
    'f.ShowDialog()
    'If ListBindingSource.Count <= 1 Then
    '  RefrescarLista()
    'End If
    'f.Dispose()
  End Sub

  Private Sub FrmListaBajasActivo_Buscar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Buscar
    Llenar_datos(Me.combobuscar.Text)
  End Sub

  Private Sub FrmListaBajasActivo_CancelarBuscar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.CancelarBuscar, Me.Refrescar
    Llenar_datos()
  End Sub

  Private Sub FrmListaBajasActivo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If mActivos Is Nothing OrElse ListBindingSource.Current Is Nothing Then
      Exit Sub
    End If
    Dim mActivo As Activo
    mActivo = ListBindingSource.Current
    If mActivo.Eliminar() AndAlso ListBindingSource.Current IsNot Nothing Then
      ListBindingSource.RemoveCurrent()
    Else
      MsgBox("No se puede eliminar Activo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub

  Private Sub FrmListaBajasActivo_Imprimir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Imprimir
    'imprimir
  End Sub
#End Region

#Region "Llenardatos"
  Private WithEvents mActivos As ActivoList = Nothing

  Sub Llenar_datos(Optional ByVal _filtro As String = "")
    MyBase.Titulo = "Listado de bajas de activo"
    MyBase.AgregarLeyenda = "Agregar una nueva Baja de Activos"

    Me.ListBindingSource.DataSource = GetType(Activo)
    mActivos = ActivoList.ObtenerLista(Me.Sistema.OperadorDatos, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, IIf(Me.chkubicacion.Checked, Me.CtlUbicacionActivo1.ParametroDet, Nothing), Nothing, False, 3, Me.dtfecdesde.Value, Me.dtfechasta.Value, IIf(Me.chktipobaja.Checked, Me.CtlTipoBaja.ParametroDet, Nothing))

    Dim mitemssort As New Infoware.Reglas.SortedView(mActivos)
    ListBindingSource.DataSource = mitemssort
  End Sub

  Private Sub mActivos_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles mActivos.AddingNew
    Dim _Activo As Activo = New Activo(Sistema.OperadorDatos, True)
    e.NewObject = _Activo
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    EsBusqueda = _busqueda
    ' Add any initialization after the InitializeComponent() call.
    FrmListaBajasActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, ByVal _busqueda As Boolean, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _busqueda, _OpcionNuevo)
  End Sub

  Private mUsuario As WWTSUsuario = Nothing

  Private Sub FrmListaBajasActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    mUsuario = New WWTSUsuario(Sistema.OperadorDatos, Sistema.Usuario.Usuari_Codigo)

    Me.PuedeNuevo = False
    Me.CtlUbicacionActivo1.SoloVisibles = True
    Me.CtlUbicacionActivo1.PardetRaiz = mUsuario.PardetUbicacion
    Me.CtlUbicacionActivo1.llenar_Datos()

    Me.CtlTipoBaja.ParametroEnum = Enumerados.EnumParametros.TipoBajaActivo
    Me.CtlTipoBaja.llenar_Datos()

    Me.DataGridView1.BringToFront()

    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False

    Me.DataGridView1.BringToFront()
    Llenar_datos()
  End Sub
#End Region

  Private Sub CtlBuscaActivos1_Buscar(ByVal sender As Object, ByVal e As System.EventArgs)
    Llenar_datos()
  End Sub

  Private Sub btnseleccionartodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndarbaja.Click
    Dim f As New FrmListaActivos(Me.Sistema, Me.Restriccion, False, EnumOpciones.ListadoActivos)
    f.MostrarDarBaja = True
    f.MultiSelect = True
    f.ShowDialog()
    Me.Llenar_datos()
  End Sub

  Private Sub chkubicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkubicacion.CheckedChanged
    Me.pnlubicacion.Visible = Me.chkubicacion.Checked
  End Sub

  Private Sub chktipobaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktipobaja.CheckedChanged
    Me.pnlTipoBaja.Visible = Me.chktipobaja.Checked
  End Sub

  Private Sub btnLlenar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlenar.Click
    Llenar_datos()
  End Sub

  Private Sub btngenerartxt_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btngenerartxt.Click
    Dim ds As New DataTable
    Dim bReturn As Boolean = False
    Dim operadorDatos As OperadorDatos = Me.Sistema.OperadorDatos
    operadorDatos.AgregarParametro("@accion", Nothing)
    operadorDatos.AgregarParametro("@Baja_desde", Me.dtfecdesde.Value.Date)
    operadorDatos.AgregarParametro("@Baja_hasta", Me.dtfechasta.Value.Date)
    operadorDatos.AgregarParametro("@Fecha_Asiento", Me.dtfechasta.Value.Date)
    operadorDatos.Procedimiento = "Proc_BajaActivos_Exportar"
    bReturn = operadorDatos.Ejecutar(ds)
    operadorDatos.LimpiarParametros()

    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      Dim _archivotxt As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, String.Format("{0}{1}{2}.txt", "BajaActivos", Me.dtfecdesde.Value.ToString("yyyyMMdd"), Me.dtfechasta.Value.ToString("yyyyMMdd")))

      Dim fila = 0
      Dim errorcont = 0
      My.Computer.FileSystem.WriteAllText(_archivotxt, "", False)
      For Each _dr As DataRow In ds.Rows
        Dim _texto As String = ""
        fila += 1
        For col As Integer = 1 To ds.Columns.Count
          Try
            _texto = _texto + CStr(_dr(col - 1)).Replace(",", ".") + ";"
          Catch ex As Exception
            If Not _texto.Substring(0, 10) = ">>>Error! " Then
              _texto = ">>>Error! " + _texto + "<Error>;"
            End If

            errorcont += 1
          End Try
        Next
        _texto = _texto + vbCrLf
        My.Computer.FileSystem.WriteAllText(_archivotxt, _texto, True)
      Next
      Shell("Notepad " + _archivotxt, AppWinStyle.NormalFocus, False)
    End If
  End Sub
End Class
