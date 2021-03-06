﻿Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Infoware.Reportes
Imports ActivosFijos.Reglas
Imports Microsoft.Office.Interop
Imports System.Reflection
Imports ActivosFijos.Integration

Public Class FrmGenerarAsientos
  Dim mCodigoPeriodo As String
  Dim mTipoAsiento As String
  Dim mParametroDepreciacion As WWTSParametroDet
  Dim mParametroServicioWeb As WWTSParametroDet = Nothing

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
    MyBase.Tabla = "Generar asientos"

    mParametroDepreciacion = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumParametros.ParametroDepreciacion, 1)
    mParametroServicioWeb = New WWTSParametroDet(Sistema.OperadorDatos, Enumerados.EnumOpciones.Sistema, 2)

    If mParametroDepreciacion.Pardet_DatoStr1.ToUpper() = "MENSUAL" Then
      Me.dtperiodo.CustomFormat = "yyyy/MM"
    Else
      Me.dtperiodo.CustomFormat = "yyyy/MM/dd"
    End If

  End Sub
#End Region


  Private Sub btnmostrar_Click(sender As System.Object, e As System.EventArgs) Handles btnmostrar.Click
    Try
      Me.dgdepreciacion.Columns.Clear()
      Me.dgdepreciacion.AutoGenerateColumns = True
      Me.bsdepreciacion.DataSource = obtenerAsiento(0, "mostrar")
      Me.dgdepreciacion.DataSource = bsdepreciacion

      If Me.dgdepreciacion.Rows.Count() = 0 Then
        Me.dgdepreciacion.Columns.Clear()
        dgdepreciacion.Columns.Add(Me.DataGridViewTextBoxColumn18)
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion,
                                            "Se consultó la " + cboTipoAsiento.ValueMember.ToString + " del periodo " + mCodigoPeriodo + ". No se presentaron datos.")
      Else
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion,
                                            "Se mostró la " + cboTipoAsiento.ValueMember.ToString + " del periodo " + mCodigoPeriodo + ".")
      End If

    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
      Exit Sub
    End Try

  End Sub


  Private Sub btnexportar_Click(sender As Object, e As EventArgs) Handles btnexportar.Click
    Me.dgdepreciacion.Columns.Clear()
    Me.dgdepreciacion.AutoGenerateColumns = True
    Me.bsdepreciacion.DataSource = obtenerAsiento(0, "mostrar")
    Me.dgdepreciacion.DataSource = bsdepreciacion

    If Me.dgdepreciacion.Rows.Count() = 0 Then
      Me.dgdepreciacion.Columns.Clear()
      dgdepreciacion.Columns.Add(Me.DataGridViewTextBoxColumn18)
    Else
      Dim excelApp As New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      For i = 0 To dgdepreciacion.RowCount - 1
        For j = 0 To dgdepreciacion.ColumnCount - 1
          For k As Integer = 1 To dgdepreciacion.Columns.Count
            excelWorksheet.Cells(1, k) = dgdepreciacion.Columns(k - 1).HeaderText
            excelWorksheet.Cells(i + 2, j + 1) = dgdepreciacion(j, i).Value.ToString()
          Next
        Next
      Next
      excelApp.Visible = True
      excelApp.ScreenUpdating = True
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion,
                                  "Se exportó a Excel la consulta de la " + cboTipoAsiento.ValueMember.ToString + " del periodo " + mCodigoPeriodo + ".")
    End If


  End Sub

  Private Sub btngenerartxt_Click(sender As System.Object, e As System.EventArgs) Handles btngenerartxt.Click
    Dim ds As New DataTable
    ds = obtenerAsiento(0, "exportarTxt")

    If Not ds Is Nothing AndAlso ds.Rows.Count > 0 Then
      Dim _archivotxt As String = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments,
                                                         String.Format("{0} {1} {2}.txt", cboTipoAsiento.ValueMember.ToString, mCodigoPeriodo,
                                                                       Now().ToString("dd-MM-yyyy") + Now().Hour().ToString("HH") + "h" + Now().Minute.ToString("mm")))

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
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion,
                                  "Se generó el txt de la " + cboTipoAsiento.ValueMember.ToString + " del periodo " + mCodigoPeriodo + ".")
    End If
  End Sub

  Private Sub obtenerParametros()
    If mParametroDepreciacion.Pardet_DatoStr1.ToUpper() = "MENSUAL" Then
      mCodigoPeriodo = Me.dtperiodo.Value.ToString("yyyyMM")
    Else
      mCodigoPeriodo = Me.dtperiodo.Value.ToString("yyyyMMdd")
    End If

    If cboTipoAsiento.SelectedIndex = 0 Then
      mTipoAsiento = "B"
    ElseIf cboTipoAsiento.SelectedIndex = 1 Then
      mTipoAsiento = "D"
    ElseIf cboTipoAsiento.SelectedIndex = 2 Then
      mTipoAsiento = "T"
    End If
  End Sub

  Private Function obtenerAsiento(_numeroAsiento As String, _accion As String) As DataTable
    obtenerParametros()
    Dim ds As New DataTable
    Dim bReturn As Boolean = False

    With Sistema.OperadorDatos
      .AgregarParametro("@accion", _accion)
      .AgregarParametro("@codigoPeriodo", mCodigoPeriodo)
      .AgregarParametro("@tipoAsiento", mTipoAsiento)
      .AgregarParametro("@numeroAsiento", _numeroAsiento)
      .Procedimiento = "proc_GenerarAsientos"
      bReturn = .Ejecutar(ds)
      .LimpiarParametros()
    End With
    If bReturn AndAlso Not ds Is Nothing AndAlso ds.Rows.Count = 0 Then
      MsgBox("No hay elementos que presentar.", MsgBoxStyle.Exclamation, "Error")
    ElseIf Not bReturn Or ds Is Nothing Then
      MsgBox("No se pudo obtener el detalle del asiento.", MsgBoxStyle.Exclamation, "Error")
    End If
    Return ds
  End Function

  Private Sub btnimprimir_Click(sender As Object, e As EventArgs) Handles btnimprimir.Click
    Me.dgdepreciacion.Columns.Clear()
    Me.dgdepreciacion.AutoGenerateColumns = True
    Me.bsdepreciacion.DataSource = obtenerAsiento(0, "mostrar")
    Me.dgdepreciacion.DataSource = bsdepreciacion

    If Me.dgdepreciacion.Rows.Count() = 0 Then
      Me.dgdepreciacion.Columns.Clear()
      dgdepreciacion.Columns.Add(Me.DataGridViewTextBoxColumn18)
    Else
      Dim doc As New Infoware.Reportes.ReportDocument
      doc.Titulo = Me.Text
      If dgdepreciacion.ColumnCount > 8 Then
        doc.DefaultPageSettings.Landscape = True
      End If
      doc.DataGridView = dgdepreciacion
      Dim previo As New System.Windows.Forms.PrintPreviewDialog
      previo.Document = doc
      previo.Document.DocumentName = Me.Text
      previo.Text = Me.Text
      previo.WindowState = FormWindowState.Maximized
      previo.ShowDialog()
    End If
  End Sub

  Private Sub btngenerarasiento_Click(sender As Object, e As EventArgs) Handles btngenerarasiento.Click
    Dim dsc As New DataTable
    Dim dsd As New DataTable
    Dim resultCode As Integer = 999
    Dim result As String = Nothing
    Dim numAsiento As String = Nothing

    dsc = obtenerAsiento(0, "cabecera")

    If mParametroServicioWeb Is Nothing Then
      MsgBox("Debe configurar el Servicio Web", MsgBoxStyle.Exclamation, "Error")
      Exit Sub
    Else
      mParametroServicioWeb.Recargar()
    End If

    If Not dsc Is Nothing AndAlso dsc.Rows.Count > 0 Then
      If Asiento.GenerarCabecera(mParametroDepreciacion.Pardet_DatoStr3, dsc, result, numAsiento, mParametroServicioWeb) Then
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Confidencial,
                                    "Se generó la cabecera del asiento de la " + cboTipoAsiento.ValueMember.ToString + " " + mCodigoPeriodo)
        dsd = obtenerAsiento(numAsiento, "asiento")
        If Asiento.GenerarDetalle(mParametroDepreciacion.Pardet_DatoStr3, dsd, result, mParametroServicioWeb) Then
          Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Confidencial,
                                    "Se generó el asiento " + numAsiento + " de la " + cboTipoAsiento.ValueMember.ToString + " " + mCodigoPeriodo)
          MsgBox("Generado asiento con éxito.", MsgBoxStyle.Information)
        Else
          Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Confidencial,
                                    "Error al generar el detalle del asiento " + numAsiento + " de la " + cboTipoAsiento.ValueMember.ToString + " " + mCodigoPeriodo + " " + result)
          MsgBox(result, MsgBoxStyle.Exclamation, "Error")
        End If
      Else
        Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Confidencial,
                                    "Error al generar la cabecera del asiento de la " + cboTipoAsiento.ValueMember.ToString + " " + mCodigoPeriodo + " " + result)
        MsgBox(result, MsgBoxStyle.Exclamation, "Error")
      End If
    End If
  End Sub

  Private Sub btnConfigurarWS_Click(sender As Object, e As EventArgs) Handles btnConfigurarWS.Click
    Dim f As New FrmMantenimientoWS(Sistema, Enumerados.EnumOpciones.ConfigurarWS)
    f.ShowDialog()
  End Sub
End Class