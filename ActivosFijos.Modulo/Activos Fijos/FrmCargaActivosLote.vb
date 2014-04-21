Imports Infoware.Consola.Base
Imports Infoware.Reglas.General
Imports Infoware.Reportes
Imports ActivosFijos.Reglas
Imports Microsoft.Office.Interop
Imports System.Reflection
Imports System.ComponentModel

Public Class FrmCargaActivosLote

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
    MyBase.Tabla = "Carga de activos en lote"
    Me.ComboBox1.Items.Add("Activo")
    Me.ComboBox1.Items.Add("Valoración")
    Me.ComboBox1.Items.Add("Característica")
    Me.ComboBox1.Items.Add("Inventario")
    Me.ComboBox1.SelectedIndex = 0

    Me.cboPeriodoInventario.Parametro = Enumerados.EnumParametros.PeriodoInventario
    Me.cboPeriodoInventario.OperadorDatos = Sistema.OperadorDatos
    Me.cboPeriodoInventario.Llenar_Datos()

    cboInventario.MostrarRutaCompleta = True
    cboInventario.Parametro = Enumerados.EnumParametros.UbicacionActivo
    cboInventario.OperadorDatos = Sistema.OperadorDatos
    Me.cboInventario.Llenar_Datos(InventarioList.ObtenerUbicaciones(Sistema.OperadorDatos, Me.cboPeriodoInventario.ParametroDet))
    cboInventario.PuedeActualizar = False
    cboInventario.PuedeNuevo = False
    cboInventario.PuedeModificar = False
    cboInventario.PuedeEliminar = False

  End Sub
#End Region

  Private mInventario As Inventario = Nothing

  Private Sub btnGenerarPlantilla_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerarPlantillaact.Click
    Select Case Me.ComboBox1.SelectedIndex
      Case 0
        Dim datos As New PlantillaActivoList
        datos.Add(New PlantillaActivo(Sistema.OperadorDatos))
        GenerarExcelActivos(datos)
      Case 1
        Dim datos As New PlantillaValoracionList
        datos.Add(New PlantillaValoracion(Sistema.OperadorDatos))
        GenerarExcelActivos(datos)
      Case 2
        Dim datos As New PlantillaCaracteristicaList
        datos.Add(New PlantillaCaracteristica(Sistema.OperadorDatos))
        GenerarExcelActivos(datos)
      Case 3
        mInventario = New Inventario(Sistema.OperadorDatos, Me.cboInventario.ParametroDet.Parame_Codigo, Me.cboInventario.ParametroDet.Pardet_Secuencia, Me.cboPeriodoInventario.ParametroDet.Parame_Codigo, Me.cboPeriodoInventario.ParametroDet.Pardet_Secuencia)
        Dim datos As PlantillaInventarioList = PlantillaInventarioList.ObtenerLista(mInventario)
        GenerarExcelActivos(datos)
    End Select
  End Sub

#Region "Generar"
  Sub GenerarExcelActivos(datos As IList)
    Try
      Dim data As IList = CType(datos, IList)

      If data Is Nothing OrElse data.Count = 0 Then
        Throw New Exception("No existen registros a exportar")
        Exit Sub
      End If

      Dim dets As Type
      dets = data.Item(0).GetType

      Me.ProgressBar1.Value = 0
      Dim excelApp As New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        Dim t1 As Integer = 0
        For Each mInfo As PropertyInfo In dets.GetProperties
          Dim attrCustom As CampoReporteAtributo = Nothing

          For Each attr As Attribute In Attribute.GetCustomAttributes(mInfo)
            If TypeOf attr Is CampoReporteAtributo Then
              attrCustom = CType(attr, CampoReporteAtributo)
              attrCustom.Campo = mInfo.Name
            End If
          Next

          If attrCustom IsNot Nothing AndAlso Not attrCustom.Ignorar Then
            If mInfo.PropertyType.BaseType Is GetType(Object) Or mInfo.PropertyType.BaseType Is GetType(ValueType) Then
              t1 += 1
              .Cells(1, t1).Value = attrCustom.Etiqueta
              .Columns(t1).columnwidth = IIf(attrCustom.Tamano / 6.8 > 255, 255, attrCustom.Tamano / 6.8)

              Dim _pro As System.Reflection.PropertyInfo
              _pro = dets.GetProperty(attrCustom.Campo)

              If _pro IsNot Nothing Then
                If (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
                  .Columns(t1).numberformat = "0.00" '& Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator & "00"
                ElseIf (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
                  .Columns(t1).numberformat = "0"
                Else
                  'If Not _output = EnumSalida.MailMerge AndAlso (_pro.PropertyType Is GetType(String) Or _pro.PropertyType Is GetType(Boolean)) Then
                  .Columns(t1).numberformat = "@"
                End If
              End If

            End If
          End If

        Next

        Me.ProgressBar1.Maximum = data.Count

        For _row As Integer = 1 To data.Count
          Me.ProgressBar1.Value = _row
          Application.DoEvents()
          t1 = 0
          For Each mInfo As PropertyInfo In dets.GetProperties
            Dim attrCustom As CampoReporteAtributo = Nothing

            For Each attr As Attribute In Attribute.GetCustomAttributes(mInfo)
              If TypeOf attr Is CampoReporteAtributo Then
                attrCustom = CType(attr, CampoReporteAtributo)
                attrCustom.Campo = mInfo.Name
              End If
            Next

            If attrCustom IsNot Nothing AndAlso Not attrCustom.Ignorar Then
              If mInfo.PropertyType.BaseType Is GetType(Object) Or mInfo.PropertyType.BaseType Is GetType(ValueType) Then
                t1 += 1
                Dim valor As Object
                valor = GetField(data.Item(_row - 1), attrCustom.Campo)
                If TypeOf valor Is Boolean Then
                  .Cells(_row + 1, t1).Value = IIf(CBool(valor), "Sí", "No")
                Else
                  Dim _pro As System.Reflection.PropertyInfo
                  _pro = dets.GetProperty(attrCustom.Campo)

                  '.Cells(_row + 1, t).Value = valor
                  If (_pro.PropertyType Is GetType(Decimal) Or _pro.PropertyType Is GetType(Double)) Then
                    .Cells(_row + 1, t1).value = Val(valor).ToString("0.00")
                  ElseIf (_pro.PropertyType Is GetType(Integer) Or _pro.PropertyType Is GetType(Byte)) Then
                    .Cells(_row + 1, t1).value = Val(valor).ToString("0")
                  Else 'data.Columns(t - 1).DataType Is GetType(String) Or data.Columns(t - 1).DataType Is GetType(Boolean) Then
                    .Cells(_row + 1, t1).Value = valor
                  End If
                End If
              End If
            End If
          Next
        Next
      End With
      excelApp.Visible = True
      excelApp.ScreenUpdating = True
      'excelWorksheet.PrintPreview()
      'excelApp.Quit()
      Auditoria.Registrar_Auditoria(Restriccion, Auditoria.enumTipoAccion.Impresion, "Generó plantilla de Carga en Lote")
    Catch ex As Exception
      MsgBox("No se puede exporta a Microsoft Excel. " & ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
    End Try
  End Sub
#End Region

#Region " GetField "

  Public Function GetField(ByVal obj As Object, ByVal FieldName As String) As Object
    Try
      Dim sourcetype As Type = obj.GetType
      Dim prop As PropertyInfo = sourcetype.GetProperty(FieldName)
      If prop Is Nothing OrElse Not prop.CanRead Then
        ' no readable property of that name exists - check for a field
        Dim field As FieldInfo = sourcetype.GetField(FieldName)

        If field Is Nothing Then
          Return "No such value " & FieldName
        Else
          Return field.GetValue(obj)
        End If
      Else
        ' found a property, return its value
        Return prop.GetValue(obj, Nothing)
      End If
    Catch ex As Exception
      Return ex.Message
    End Try
  End Function

#End Region

  Private Sub btncargarplantilla_Click(sender As System.Object, e As System.EventArgs) Handles btncargarplantillaact.Click
    Select Case Me.ComboBox1.SelectedIndex
      Case 0
        CargarExcelActivos()
      Case 1
        CargarExcelValoracion()
      Case 2
        CargarExcelCaracteristica()
      Case 3
        CargarExcelInventario()
    End Select
  End Sub

#Region "Cargar"
  Private Sub CargarExcelActivos()
    Dim ArchivoPlantilla As String = ""
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.Filter = "Archivo Microsoft Excel (*.xls; *.xlsx)|*.xls; *.xlsx|Todos los archivos (*.*)|*.*"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.RestoreDirectory = True

    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
      ArchivoPlantilla = Me.OpenFileDialog1.FileName
    Else
      Exit Sub
    End If

    Dim excelApp As Excel.Application = Nothing
    Dim excelBook As Excel.Workbook = Nothing

    Try
      Dim _lote As New PlantillaActivoList

      excelApp = New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      excelBook = excelApp.Workbooks.Open(ArchivoPlantilla)
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        Dim counterrorcarga As Integer = 0
        Dim counterroresvalidacion As Integer = 0
        Dim fila As Integer = 2
        While Not CStr(.Cells(fila, 2).value) = ""
          Dim _plantilla As New PlantillaActivo(Sistema.OperadorDatos)
          Try
            Me.lbl_registro.Text = String.Format("{0} registros leidos", (fila - 1).ToString)
            Application.DoEvents()

            _plantilla.CodigoBarras = .Cells(fila, 2).value
            _plantilla.Serie = .Cells(fila, 3).value
            '_plantilla.Grupo = .Cells(fila, 4).value
            '_plantilla.Tipo = .Cells(fila, 5).value
            _plantilla.Clase = .Cells(fila, 4).value
            _plantilla.Descripcion = .Cells(fila, 5).value
            _plantilla.Marca = .Cells(fila, 6).value
            _plantilla.Modelo = .Cells(fila, 7).value
            _plantilla.Observacion = .Cells(fila, 8).value
            _plantilla.EstadoDepreciacion = .Cells(fila, 9).value
            _plantilla.EstadoActivo = .Cells(fila, 10).value
            _plantilla.ResponsableMantenimiento = .Cells(fila, 11).value
            _plantilla.FechaIngreso = CDate(.Cells(fila, 12).value)
            _plantilla.FechaCompra = CDate(.Cells(fila, 13).value)
            _plantilla.FechaUso = CDate(.Cells(fila, 14).value)
            If Not String.IsNullOrWhiteSpace(.Cells(fila, 15).value) Then
              _plantilla.FechaBaja = CDate(.Cells(fila, 15).value)
            Else
              _plantilla.FechaBaja = Nothing
            End If
            _plantilla.Ubicacion = .Cells(fila, 16).value
            _plantilla.CentroCostos = .Cells(fila, 17).value
            _plantilla.Custodio = .Cells(fila, 18).value
            _plantilla.Costo = CDec(.Cells(fila, 19).value)
            _plantilla.Salvamento = CDec(.Cells(fila, 20).value)
            _plantilla.PeriodosDepreciablesMeses = CInt(.Cells(fila, 21).value)
            _plantilla.FrecuenciaDepreciacion = .Cells(fila, 22).value
            _plantilla.Proveedor = .Cells(fila, 23).value
            _plantilla.Factura = .Cells(fila, 24).value
            _plantilla.TipoBajaActivo = .Cells(fila, 25).value
            _plantilla.Caracteristicas = .Cells(fila, 26).value
            _plantilla.FechaCambioUbcacionCustodio = .Cells(fila, 27).value
            _plantilla.Forzar = .Cells(fila, 28).value.ToString.Trim.ToUpper = "SI"


            If Not _plantilla.Validar() Then
              counterroresvalidacion += 1
            End If
            _lote.Add(_plantilla)

          Catch ex As Exception
            counterrorcarga += 1
            MsgBox(String.Format("Error al tratar de cargar la fila {0}. {1}", fila.ToString, ex.Message), MsgBoxStyle.Critical, "Error")
            If counterrorcarga = 3 Then
              MsgBox("Se ha superado el número máximo de errores de carga. Corrija el archivo y vuelva a intentarlo", MsgBoxStyle.Information, "Información")
              Exit While
            End If
          End Try
          fila += 1
        End While

        Me.bscargaract.DataSource = _lote
        Me.dgcargaract.AutoDiscover()

        If counterrorcarga = 0 And counterroresvalidacion = 0 Then
          Dim _loteerror As New PlantillaActivoList
          fila = 0
          For Each _plantilla As PlantillaActivo In _lote
            If Not _plantilla.Guardar() Then
              _loteerror.Add(_plantilla)
            Else
              fila += 1
              Me.lbl_registro.Text = String.Format("{0} registros guardados", (fila - 1).ToString)
              Application.DoEvents()
            End If
          Next

          If _loteerror.Count > 0 Then
            MsgBox("Se han encontrado errores al momento de guardar los registros, a continuación se creará un archivo en Microsoft Excel con los registros errados junto con una descripción del error. Por favor corríjalos y vuelva a intentarlo", MsgBoxStyle.Information, "Información")

            GenerarExcelActivos(_loteerror)
          Else
            MsgBox("Proceso terminado satisfactoriamente", MsgBoxStyle.Information, "Información")
          End If

          Me.dgcargaract.AutoDiscover()
        End If

      End With
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
      Try
        excelBook.Close()
        excelApp.Quit()
      Catch ex As Exception

      End Try

    End Try
  End Sub

  Private Sub CargarExcelValoracion()
    Dim ArchivoPlantilla As String = ""
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.Filter = "Archivo Microsoft Excel (*.xls; *.xlsx)|*.xls; *.xlsx|Todos los archivos (*.*)|*.*"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.RestoreDirectory = True

    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
      ArchivoPlantilla = Me.OpenFileDialog1.FileName
    Else
      Exit Sub
    End If

    Dim excelApp As Excel.Application = Nothing
    Dim excelBook As Excel.Workbook = Nothing

    Try
      Dim _lote As New PlantillaValoracionList

      excelApp = New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      excelBook = excelApp.Workbooks.Open(ArchivoPlantilla)
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        Dim counterrorcarga As Integer = 0
        Dim counterroresvalidacion As Integer = 0
        Dim fila As Integer = 2
        While Not .Cells(fila, 2).value = ""
          Dim _plantilla As New PlantillaValoracion(Sistema.OperadorDatos)
          Try
            Me.lbl_registro.Text = String.Format("{0} registros leidos", (fila - 1).ToString)
            Application.DoEvents()

            _plantilla.CodigoBarras = .Cells(fila, 2).value
            _plantilla.Costo = CDec(.Cells(fila, 3).value)
            _plantilla.Salvamento = CDec(.Cells(fila, 4).value)
            _plantilla.PeriodosDepreciablesMeses = CInt(.Cells(fila, 5).value)
            _plantilla.FrecuenciaDepreciacion = .Cells(fila, 6).value
            _plantilla.TipoDepreciacion = .Cells(fila, 7).value
            _plantilla.FechaValoracion = CDate(.Cells(fila, 8).value)

            If Not _plantilla.Validar() Then
              counterroresvalidacion += 1
            End If
            _lote.Add(_plantilla)

          Catch ex As Exception
            counterrorcarga += 1
            MsgBox(String.Format("Error al tratar de cargar la fila {0}. {1}", fila.ToString, ex.Message), MsgBoxStyle.Critical, "Error")
            If counterrorcarga = 3 Then
              MsgBox("Se ha superado el número máximo de errores de carga. Corrija el archivo y vuelva a intentarlo", MsgBoxStyle.Information, "Información")
              Exit While
            End If
          End Try
          fila += 1
        End While

        Me.bscargaract.DataSource = _lote
        Me.dgcargaract.AutoDiscover()

        If counterrorcarga = 0 And counterroresvalidacion = 0 Then
          Dim _loteerror As New PlantillaValoracionList
          fila = 0
          For Each _plantilla As PlantillaValoracion In _lote
            If Not _plantilla.Guardar() Then
              _loteerror.Add(_plantilla)
            Else
              fila += 1
              Me.lbl_registro.Text = String.Format("{0} registros guardados", (fila - 1).ToString)
              Application.DoEvents()
            End If
          Next

          If _loteerror.Count > 0 Then
            MsgBox("Se han encontrado errores al momento de guardar los registros, a continuación se creará un archivo en Microsoft Excel con los registros errados junto con una descripción del error. Por favor corríjalos y vuelva a intentarlo", MsgBoxStyle.Information, "Información")

            GenerarExcelActivos(_loteerror)
          Else
            MsgBox("Proceso terminado satisfactoriamente", MsgBoxStyle.Information, "Información")
          End If

          Me.dgcargaract.AutoDiscover()
        End If

      End With
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
      Try
        excelBook.Close()
        excelApp.Quit()
      Catch ex As Exception

      End Try

    End Try

  End Sub

  Private Sub CargarExcelCaracteristica()
    Dim ArchivoPlantilla As String = ""
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.Filter = "Archivo Microsoft Excel (*.xls; *.xlsx)|*.xls; *.xlsx|Todos los archivos (*.*)|*.*"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.RestoreDirectory = True

    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
      ArchivoPlantilla = Me.OpenFileDialog1.FileName
    Else
      Exit Sub
    End If

    Dim excelApp As Excel.Application = Nothing
    Dim excelBook As Excel.Workbook = Nothing

    Try
      Dim _lote As New PlantillaCaracteristicaList

      excelApp = New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      excelBook = excelApp.Workbooks.Open(ArchivoPlantilla)
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        Dim counterrorcarga As Integer = 0
        Dim counterroresvalidacion As Integer = 0
        Dim fila As Integer = 2
        While Not .Cells(fila, 2).value = ""
          Dim _plantilla As New PlantillaCaracteristica(Sistema.OperadorDatos)
          Try
            Me.lbl_registro.Text = String.Format("{0} registros leidos", (fila - 1).ToString)
            Application.DoEvents()

            _plantilla.CodigoBarras = .Cells(fila, 2).value
            _plantilla.Caracteristica = .Cells(fila, 3).value
            _plantilla.Valor = .Cells(fila, 4).value
            
            If Not _plantilla.Validar() Then
              counterroresvalidacion += 1
            End If
            _lote.Add(_plantilla)

          Catch ex As Exception
            counterrorcarga += 1
            MsgBox(String.Format("Error al tratar de cargar la fila {0}. {1}", fila.ToString, ex.Message), MsgBoxStyle.Critical, "Error")
            If counterrorcarga = 3 Then
              MsgBox("Se ha superado el número máximo de errores de carga. Corrija el archivo y vuelva a intentarlo", MsgBoxStyle.Information, "Información")
              Exit While
            End If
          End Try
          fila += 1
        End While

        Me.bscargaract.DataSource = _lote
        Me.dgcargaract.AutoDiscover()

        If counterrorcarga = 0 And counterroresvalidacion = 0 Then
          Dim _loteerror As New PlantillaCaracteristicaList
          fila = 0
          For Each _plantilla As PlantillaCaracteristica In _lote
            If Not _plantilla.Guardar() Then
              _loteerror.Add(_plantilla)
            Else
              fila += 1
              Me.lbl_registro.Text = String.Format("{0} registros guardados", (fila - 1).ToString)
              Application.DoEvents()
            End If
          Next

          If _loteerror.Count > 0 Then
            MsgBox("Se han encontrado errores al momento de guardar los registros, a continuación se creará un archivo en Microsoft Excel con los registros errados junto con una descripción del error. Por favor corríjalos y vuelva a intentarlo", MsgBoxStyle.Information, "Información")

            GenerarExcelActivos(_loteerror)
          Else
            MsgBox("Proceso terminado satisfactoriamente", MsgBoxStyle.Information, "Información")
          End If

          Me.dgcargaract.AutoDiscover()
        End If

      End With
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
      Try
        excelBook.Close()
        excelApp.Quit()
      Catch ex As Exception

      End Try

    End Try

  End Sub

  Private Sub CargarExcelInventario()
    Dim ArchivoPlantilla As String = ""
    OpenFileDialog1.FileName = ""
    OpenFileDialog1.Filter = "Archivo Microsoft Excel (*.xls; *.xlsx)|*.xls; *.xlsx|Todos los archivos (*.*)|*.*"
    OpenFileDialog1.FilterIndex = 1
    OpenFileDialog1.RestoreDirectory = True

    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
      ArchivoPlantilla = Me.OpenFileDialog1.FileName
    Else
      Exit Sub
    End If

    Dim excelApp As Excel.Application = Nothing
    Dim excelBook As Excel.Workbook = Nothing

    Try
      Dim _lote As New PlantillaInventarioList

      excelApp = New Excel.Application
      excelApp.Visible = False
      excelApp.ScreenUpdating = False
      excelBook = excelApp.Workbooks.Open(ArchivoPlantilla)
      Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
      With excelWorksheet
        Dim counterrorcarga As Integer = 0
        Dim counterroresvalidacion As Integer = 0
        Dim fila As Integer = 2
        While Not CStr(.Cells(fila, 2).value) = ""
          Dim _plantilla As New PlantillaInventario(Sistema.OperadorDatos)
          Try
            Me.lbl_registro.Text = String.Format("{0} registros leidos", (fila - 1).ToString)
            Application.DoEvents()

            _plantilla.Ubicacion = .Cells(fila, 2).value
            _plantilla.PeriodoInventario = .Cells(fila, 3).value
            _plantilla.Invent_Descripcion = .Cells(fila, 4).value
            _plantilla.Invent_Fecha = CDate(.Cells(fila, 5).value)
            _plantilla.EstadoInventario = .Cells(fila, 6).value
            _plantilla.InvDet_Observacion = .Cells(fila, 7).value
            _plantilla.UbicacionActual = .Cells(fila, 8).value
            _plantilla.CustodioActual = .Cells(fila, 9).value
            _plantilla.EstadoInventarioDet = .Cells(fila, 10).value
            _plantilla.Usuari_CodigoPDA = .Cells(fila, 11).value
            _plantilla.CodigoBarras = .Cells(fila, 12).value
            _plantilla.CodigoAux = .Cells(fila, 13).value
            _plantilla.Serie = .Cells(fila, 14).value
            _plantilla.Clase = .Cells(fila, 15).value
            _plantilla.Descripcion = .Cells(fila, 16).value
            _plantilla.Marca = .Cells(fila, 17).value
            _plantilla.Modelo = .Cells(fila, 18).value
            _plantilla.Observacion = .Cells(fila, 19).value
            _plantilla.EstadoDepreciacion = .Cells(fila, 20).value
            _plantilla.EstadoActivo = .Cells(fila, 21).value
            _plantilla.ResponsableMantenimiento = .Cells(fila, 22).value
            _plantilla.FechaIngreso = CDate(.Cells(fila, 23).value)
            _plantilla.FechaCompra = CDate(.Cells(fila, 24).value)
            _plantilla.FechaUso = CDate(.Cells(fila, 25).value)
            If Not String.IsNullOrWhiteSpace(.Cells(fila, 26).value) Then
              _plantilla.FechaBaja = CDate(.Cells(fila, 26).value)
            Else
              _plantilla.FechaBaja = Nothing
            End If
            _plantilla.CentroCostos = .Cells(fila, 27).value
            _plantilla.Proveedor = .Cells(fila, 28).value
            _plantilla.Factura = .Cells(fila, 29).value
            _plantilla.TipoBajaActivo = .Cells(fila, 30).value
            _plantilla.Caracteristicas = .Cells(fila, 31).value
            _plantilla.FechaRegistro = .Cells(fila, 32).value

            If Not _plantilla.Validar() Then
              counterroresvalidacion += 1
            End If
            _lote.Add(_plantilla)

          Catch ex As Exception
            counterrorcarga += 1
            MsgBox(String.Format("Error al tratar de cargar la fila {0}. {1}", fila.ToString, ex.Message), MsgBoxStyle.Critical, "Error")
            If counterrorcarga = 3 Then
              MsgBox("Se ha superado el número máximo de errores de carga. Corrija el archivo y vuelva a intentarlo", MsgBoxStyle.Information, "Información")
              Exit While
            End If
          End Try
          fila += 1
        End While

        Me.bscargaract.DataSource = _lote
        Me.dgcargaract.AutoDiscover()

        If counterrorcarga = 0 And counterroresvalidacion = 0 Then
          Dim _loteerror As New PlantillaInventarioList
          fila = 0
          For Each _plantilla As PlantillaInventario In _lote
            If Not _plantilla.Guardar() Then
              _loteerror.Add(_plantilla)
            Else
              fila += 1
              Me.lbl_registro.Text = String.Format("{0} registros guardados", (fila - 1).ToString)
              Application.DoEvents()
            End If
          Next

          If _loteerror.Count > 0 Then
            MsgBox("Se han encontrado errores al momento de guardar los registros, a continuación se creará un archivo en Microsoft Excel con los registros errados junto con una descripción del error. Por favor corríjalos y vuelva a intentarlo", MsgBoxStyle.Information, "Información")

            GenerarExcelActivos(_loteerror)
          Else
            MsgBox("Proceso terminado satisfactoriamente", MsgBoxStyle.Information, "Información")
          End If

          Me.dgcargaract.AutoDiscover()
        End If

      End With
    Catch ex As Exception
      MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
    Finally
      Try
        excelBook.Close()
        excelApp.Quit()
      Catch ex As Exception

      End Try

    End Try
  End Sub
#End Region

  Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    Me.pnlinventario.Visible = Me.ComboBox1.SelectedIndex = 3
  End Sub

  Private Sub cboPeriodoInventario_CambioItem(sender As Object, e As System.EventArgs) Handles cboPeriodoInventario.CambioItem
    Me.cboInventario.Llenar_Datos(InventarioList.ObtenerUbicaciones(Sistema.OperadorDatos, Me.cboPeriodoInventario.ParametroDet))
  End Sub

End Class