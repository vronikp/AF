Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports ActivosFijos.Reglas

Public Class FrmMantenimientoActivo
  Public Property Activos() As BindingSource
    Get
      Return MyBase.BindingSource1
    End Get
    Set(ByVal value As BindingSource)
      MyBase.BindingSource1 = value
      llenar_datos()
    End Set
  End Property

  Private mActivo As Activo = Nothing
  Public Property Activo() As Activo
    Get
      Return mActivo
    End Get
    Set(ByVal value As Activo)
      mActivo = value
      If MyBase.BindingSource1.DataSource Is Nothing Then
        Dim _Activos As New ActivoList
        _Activos.Add(mActivo)
        MyBase.BindingSource1.DataSource = GetType(Activo)
        MyBase.BindingSource1.DataSource = _Activos
      End If
    End Set
  End Property

  Sub llenar_datos()
    If Sistema.OperadorDatos Is Nothing Then
      Exit Sub
    End If
    If Activos Is Nothing OrElse Activos.Count = 0 Then
      If Colapsado Then
        Me.pnlmantenimiento.Enabled = False
      End If
      Exit Sub
    End If
    Me.pnlmantenimiento.Enabled = True

    mActivo = Activos.Current
    If mActivo Is Nothing Then
      Exit Sub
    End If
    If Not mActivo.EsNuevo Then
      mActivo.Recargar()
    Else
      Colapsado = True
    End If

    Me.CtlActivo1.Activo = mActivo
    If mActivo.EsNuevo Then
      Me.CtlActivo1.CtlBuscaCustodio.Empleado = mCustodioActual
    End If
  End Sub

#Region "Cerrar y Cancelar"
  Private Sub FrmMantenimientoActivo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    Cancelar_Nuevo()
  End Sub

  Private Function Cancelar_Nuevo() As Boolean
    If mActivo Is Nothing Then
      Return True
    End If
    Dim _esnuevo As Boolean = mActivo.EsNuevo
    If _esnuevo AndAlso Activos.Current IsNot Nothing Then
      Activos.RemoveCurrent()
    End If
    Return _esnuevo
  End Function
#End Region

#Region "Activos eventos"
  Private mCustodioActual As Empleado = Nothing

  Private Sub FrmMantenimientoCliente_CrearNuevo(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles Me.CrearNuevo
    If Activo IsNot Nothing Then
      mCustodioActual = Activo.CustodioActual
    End If
    Dim _Activo As Activo = New Activo(Sistema.OperadorDatos, True)
    If mActivo IsNot Nothing AndAlso mActivo.Facturaactivo IsNot Nothing Then
      _Activo.Facturaactivo = mActivo.Facturaactivo
    End If
    e.NewObject = _Activo
  End Sub

  Private Sub FrmMantenimientoCliente_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    llenar_datos()
  End Sub
#End Region

#Region "Guardar y Eliminar"
  Private Sub FrmMantenimientoActivo_Guardar(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Guardar
    e.Cancel = Not Guardar_datos()
  End Sub

  Private Sub Mapear_Datos()
    Me.ctlActivo1.Mapear_datos()
  End Sub

  Private Function Guardar_datos() As Boolean
    If mActivo Is Nothing Then
      Return False
    End If
    Try
      Mapear_Datos()
      Dim _esnuevo As Boolean = mActivo.EsNuevo
      If CtlActivo1.Guardar Then
        Auditoria.Registrar_Auditoria(Restriccion, IIf(_esnuevo, Enumerados.enumTipoAccion.Adicion, Enumerados.enumTipoAccion.Modificacion), mActivo.CodigoBarraDescripcion)

        llenar_datos()
        Return True
      Else
        Throw New Exception("Error al guardar Activo")
      End If
    Catch ex As Exception
      MsgBox(ex.Message & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
      Return False
    End Try
  End Function

  Private Sub FrmMantenimientoActivo_Eliminar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Eliminar
    If Activos.Current IsNot Nothing Then
      Exit Sub
    End If
    If mActivo.Eliminar() Then
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Eliminacion, mActivo.CodigoBarraDescripcion)
      Activos.RemoveCurrent()
      Me.Close()
    Else
      'Activos.CancelEdit()
      MsgBox("No se puede eliminar Activo" & Environment.NewLine & Sistema.OperadorDatos.MsgError, MsgBoxStyle.Critical, "Error")
    End If
  End Sub
#End Region

#Region "Mover"
  Private Sub FrmMantenimientoActivo_Primero(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Primero
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivo_Siguiente(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Siguiente
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivo_Ultimo(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Ultimo
    e.Cancel = Cancelar_Nuevo()
  End Sub

  Private Sub FrmMantenimientoActivo_Anterior(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.Anterior
    e.Cancel = Cancelar_Nuevo()
  End Sub
#End Region

#Region "New"
  Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
    ' This call is required by the Windows Form Designer.
    InitializeComponent()

    ' Add any initialization after the InitializeComponent() call.
    'Me.CtlPersona1.PuedeElegirTipoEntidad = True
    FrmMantenimientoActivo_Inicializar(Me, Nothing)
  End Sub

  Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoActivos)
    Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
  End Sub

  Private Sub FrmMantenimientoActivo_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    MyBase.Tabla = "Activo"

    Me.PuedeNuevo = True
    Me.PuedeGuardarcerrar = False
    Me.PuedeGuardar = True
    Me.PuedeImprimir = True

    Me.CtlBuscaActivos1.PuedeExportaryBarCode = True

    Me.CtlBuscaActivos1.OperadorDatos = Sistema.OperadorDatos
    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False
  End Sub
#End Region

  Private Sub FrmMantenimientoMovimientoInventario_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    Me.BindingSource1 = Nothing
  End Sub


  Private Sub CtlBuscaActivos1_Buscar(sender As Object, e As System.EventArgs) Handles CtlBuscaActivos1.Buscar
    Me.BindingSource1.DataSource = Me.CtlBuscaActivos1.Activos
    Me.dgActivos.AutoDiscover()
    Me.ToolStripLabel1.Text = String.Format("{0} Registros", Me.BindingSource1.Count.ToString)
    Colapsado = False
  End Sub

  Private Sub BindingSource1_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles BindingSource1.CurrentChanged
    If BindingSource1.Current Is Nothing OrElse CType(BindingSource1.Current, Activo).EsNuevo Then
      Exit Sub
    End If
    Dim _ultimo As Activo = CType(Me.BindingSource1.DataSource, ActivoList)(Me.BindingSource1.Count - 1)
    If Not _ultimo.EsNuevo Then
      Exit Sub
    End If
    Me.BindingSource1.Remove(_ultimo)
  End Sub

  Private Sub FrmMantenimientoActivo_Imprimir(sender As Object, e As System.EventArgs) Handles Me.Imprimir
    If mActivo Is Nothing Then
      Exit Sub
    End If
    If mActivo.EsNuevo Then
      If MsgBox("¿Desea guardar el activo para poder imprimir su ficha?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes Then
        If Not Guardar_datos() Then
          Exit Sub
        End If
      Else
        Exit Sub
      End If
    End If
    Dim f As New FrmReporteFichaActivo(Sistema, Restriccion)
    f.Activo = mActivo
    f.ShowDialog()
  End Sub

  Private Sub CtlActivo1_CopiarActivo(sender As Object, e As System.EventArgs) Handles CtlActivo1.CopiarActivo
    Me.BindingSource1.Add(Me.CtlActivo1.ActivoCopiar)
    Me.BindingSource1.MoveLast()
  End Sub

  Private mColapsado As Boolean = True
  Public Property Colapsado As Boolean
    Get
      Return mColapsado
    End Get
    Set(value As Boolean)
      mColapsado = value
      Colapsar()
    End Set
  End Property

  Sub Colapsar()
    If Colapsado Then
      Me.CtlActivo1.Visible = True
      Me.pnldatosbusqueda.Controls.Add(Me.dgActivos)
    Else
      Me.CtlActivo1.Visible = False
      Me.pnlmantenimiento.Controls.Add(Me.dgActivos)
    End If
  End Sub

  Private Sub dgActivos_DoubleClick(sender As Object, e As System.EventArgs) Handles dgActivos.DoubleClick
    If Not Colapsado Then
      Colapsado = True
    End If
  End Sub

  Private Sub CtlBuscaActivos1_Exportar(sender As Object, e As System.EventArgs) Handles CtlBuscaActivos1.Exportar
    Me.dgActivos.Excel(DataGridViewAutoDiscover.EnumSalida.Excel)
  End Sub

  Private Sub ImprimirCodigoBarra(_Activo As Activo)
    If _Activo Is Nothing Then
      Exit Sub
    End If
    If _Activo.EsNuevo Then
      If Not (MsgBox("Debe guardar el activo antes de continuar, ¿Desea hacerlo ahora?", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.Yes AndAlso Guardar_datos()) Then
        Exit Sub
      End If
    End If
    Dim _Carpeta As String = My.Computer.FileSystem.CombinePath(Sistema.DirectorioRaiz, "Barcode")
    Dim nombreArchivoEtiquetas As String = My.Computer.FileSystem.CombinePath(_Carpeta, "Barcode.lbl")
    Dim nombreImpresoraEtiquetas As String = My.Settings.impresoraetiquetas
    Dim rutaEjecutableImpresion As String = My.Settings.ejecutablecreatealabel
    Try
      My.Computer.FileSystem.CreateDirectory(_Carpeta)
    Catch ex As Exception

    End Try

    If My.Settings.tipoprogramacodigobarra = 0 Then
      'ZebraDesigner2
      Shell(rutaEjecutableImpresion & " " & nombreArchivoEtiquetas, AppWinStyle.NormalFocus)
      Threading.Thread.Sleep(3000)
      AppActivate("ZebraDesigner")
      SendKeys.SendWait("^(P)")
      SendKeys.SendWait(_Activo.Activo_CodigoBarra)
      SendKeys.SendWait("{ENTER}")
      Threading.Thread.Sleep(3000)
      SendKeys.SendWait("%(f)x")
    Else
      'CreateaLabel
      Dim sCadena As String = "LABELNAME = """ & nombreArchivoEtiquetas & """" & vbCrLf & _
             "PRINTER = """ & nombreImpresoraEtiquetas & """" & vbCrLf & _
             "CODIGO = """ & Trim(_Activo.Activo_CodigoBarra) & """" & vbCrLf & _
             "DESCRIPCION = """ & Trim(_Activo.Descripcion) & """" & vbCrLf & _
             "LABELQUANTITY = ""1""" & vbCrLf


      Dim _file As String = My.Computer.FileSystem.CombinePath(_Carpeta, "PRN-" + Format(Now, "YYYYMMDD") + "-" + Format(Now, "HHMMSS") + "-" + Trim(Sistema.Usuario.Usuari_Codigo) + ".CMD")
      My.Computer.FileSystem.WriteAllText(_file, sCadena, False)
      My.Computer.FileSystem.WriteAllText(_file, "QUITAPP", True)

      '-- Imprimir etiquetas a traves de Create-A-Label
      'Debug.Print """" & rutaEjecutableImpresion & """/CMD """ & sFileName & """"
      'Shell """" & rutaEjecutableImpresion & """/CMD """ & sFileName & """", vbHide
      Shell(rutaEjecutableImpresion & " /CMD " & _file, AppWinStyle.Hide)
      'C:\CAL3V306\lv.exe /CMD c:\ActivosFijos\Etiquetas\Archivo.cmd
    End If

  End Sub

  Private Sub ConfigurarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConfigurarToolStripMenuItem.Click
    If My.Settings.tipoprogramacodigobarra = 0 Then
    Else
      My.Settings.impresoraetiquetas = InputBox("Escriba el nombre de la impresora de códigos de barra:", "Configurar", My.Settings.impresoraetiquetas)
    End If
    My.Settings.ejecutablecreatealabel = InputBox("Escriba la ruta del programa:", "Configurar", My.Settings.ejecutablecreatealabel)
    My.Settings.Save()
  End Sub

  Private Sub btncodigobarras_ButtonClick(sender As System.Object, e As System.EventArgs) Handles btncodigobarras.ButtonClick
    ImprimirCodigoBarra(mActivo)
  End Sub

  Private Sub CtlBuscaActivos1_ImprimirBarCode(sender As Object, e As System.EventArgs) Handles CtlBuscaActivos1.ImprimirBarCode
    For Each _row As DataGridViewRow In Me.dgActivos.SelectedRows
      ImprimirCodigoBarra(CType(Me.BindingSource1(_row.Index), Activo))
    Next
  End Sub

    Private Sub dgActivos_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgActivos.CellContentClick

    End Sub
End Class
