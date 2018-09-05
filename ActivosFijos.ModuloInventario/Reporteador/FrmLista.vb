Imports Infoware.Datos
Imports Infoware.Reglas
Imports Infoware.Reglas.General
Imports Infoware.Consola.Base
Imports System.Windows.Forms
Imports Infoware.Reporteador
Imports Infoware.Consola.Base.StructExcel
Imports ActivosFijos.Reglas

Public Class FrmLista
  Implements IOpcion

#Region "acciones"
  Private mManInsert As String = ""
  Private Property PuedeAgregar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManInsert)
    End Get
    Set(ByVal value As Boolean)
      mManInsert = value
    End Set
  End Property

  Private mManUpdate As String = ""
  Private Property PuedeModificar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManUpdate)
    End Get
    Set(ByVal value As Boolean)
      mManUpdate = value
    End Set
  End Property

  Private mManDelete As String = ""
  Private Property PuedeEliminar() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManDelete)
    End Get
    Set(ByVal value As Boolean)
      mManDelete = value
    End Set
  End Property

  Private mManPrint As String = ""
  Private Property PuedeImprimir2() As Boolean
    Get
      Return Not String.IsNullOrEmpty(mManPrint)
    End Get
    Set(ByVal value As Boolean)
      mManPrint = value
    End Set
  End Property

  Private mAutoejecutable As Boolean = False
  Public ReadOnly Property PuedeAutoejecutar() As Boolean
    Get
      Return mAutoejecutable
    End Get
  End Property
#End Region

#Region "IOpcion"
  Private mReporte As Reporte = Nothing
  Public WriteOnly Property Reporte() As Reporte
    Set(ByVal value As Reporte)
      mReporte = value
      If value IsNot Nothing Then
        Llenar_Filtros()
        Llenar_Defaults()
      End If
    End Set
  End Property

  Private mValores As Object()
  Public Property Valores() As Object()
    Get
      Return mValores
    End Get
    Set(ByVal value As Object())
      mValores = value
      If value IsNot Nothing Then
        tmrdatos.Enabled = True
      End If
    End Set
  End Property
#End Region

#Region "Llenardatos"
  Private mProgramacion As Programacion

  Sub Llenar_Filtros()
    Me.Titulo = mReporte.NombreReporte
    Me.DocSalida = mReporte.RetornarDocSalida
    Me.AutoUpdate = mReporte.RetornarAutoRefresco

    Me.TabPage2.Controls.Clear()
    Dim esSinFiltros As Boolean = True

    For Each _param As ParametroReporte In mReporte.Parametros
      If Not _param.Oculto Then
        esSinFiltros = False
      End If
      Dim _label1 As New Label
      _label1.Height = 5
      _label1.Dock = DockStyle.Top
      Me.TabPage2.Controls.Add(_label1)
      _label1.BringToFront()
      _label1.Visible = Not _param.Oculto

      Select Case _param.TipoDatoNet
        Case ParametroReporte.EnumTipoDato.Logico ', ParametroReporte.EnumTipoDato.Combo
        Case Else
          Dim _etiqueta As New Label()
          _etiqueta.Text = _param.NombreColumna
          _etiqueta.Dock = DockStyle.Top
          Me.TabPage2.Controls.Add(_etiqueta)
          _etiqueta.BringToFront()
          _etiqueta.Visible = Not _param.Oculto
      End Select

      Select Case _param.TipoDatoNet
        Case ParametroReporte.EnumTipoDato.Texto
          Dim _texto As New Infoware.Controles.Base.TextBoxStd
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Entero
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Decimales
          Dim _texto As New Infoware.Controles.Base.TextBoxCalculator
          _texto.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Fecha
          Dim _texto As New Infoware.Controles.Base.DateTimePickerStd
          _texto.Format = DateTimePickerFormat.Short
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Logico
          Dim _texto As New Infoware.Controles.Base.CheckBoxStd
          _texto.Text = _param.NombreColumna
          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.Combo
          Dim _texto As New ComboBox

          'Dim _selec As New Infoware.Controles.Base.CheckBoxStd
          '_selec.Text = _param.NombreCampo
          '_selec.Dock = DockStyle.Top
          '_selec.Tag = _texto
          '_selec.Checked = True
          'Me.TabPage2.Controls.Add(_selec)
          '_selec.BringToFront()
          'AddHandler _selec.CheckedChanged, AddressOf habilitar

          _texto.DropDownStyle = ComboBoxStyle.DropDownList
          Dim _dssec As DataTable
          _dssec = mReporte.RetornarSubListaDataTable(_param.NombreParametro)

          If _dssec Is Nothing Then
            Throw New Exception(String.Format("Error al tratar de llenar lista {0}", _param.NombreColumna))
          End If
          _texto.DisplayMember = _dssec.Columns(1).ColumnName
          _texto.ValueMember = _dssec.Columns(0).ColumnName
          _texto.DataSource = _dssec

          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
        Case ParametroReporte.EnumTipoDato.ComboActualizable
          Dim _texto As New ComboBox

          _texto.DropDownStyle = ComboBoxStyle.DropDownList
          Dim _dssec As DataTable
          _dssec = mReporte.RetornarSubListaDataTable(_param.NombreParametro)

          _texto.DisplayMember = _dssec.Columns(1).ColumnName
          _texto.ValueMember = _dssec.Columns(0).ColumnName
          _texto.DataSource = _dssec

          _texto.Dock = DockStyle.Top
          _texto.Tag = _param
          Me.TabPage2.Controls.Add(_texto)
          _texto.BringToFront()
          _texto.Visible = Not _param.Oculto
          AddHandler _texto.Validated, AddressOf Actualizar_combos
      End Select
    Next

    'Me.Panel1.Visible = Not esSinFiltros
    mManInsert = mReporte.RetornarManInsert
    mManUpdate = mReporte.RetornarManUpdate
    mManDelete = mReporte.RetornarManDelete
    mManPrint = mReporte.RetornarManPrint
    mAutoejecutable = mReporte.RetornarAutoejecutable

    Me.AutoMail = mReporte.RetornarEmailAutomatico(Restriccion.Usuari_Codigo)
    If Me.AutoMail Then
      Me.AutoMailAsunto = mReporte.RetornarEmailAsunto
      Me.AutoMailArchivo = mReporte.RetornarEmailArchivo
      Me.btnconfemail.Visible = True
      Me.AutoMailLista = mReporte.RetornarEmailLista
      mProgramacion = mReporte.RetornarEmailProgramacion
      Me.ProximoAutoMail = mProgramacion.ProximoEnvio(0)
    End If

    Me.Panel2.Visible = False
    Me.Panel2.Controls.Clear()
    'If PuedeAgregar OrElse PuedeEliminar Then
    '  'agregar boton
    '  Dim _panel As New Panel
    '  _panel.Dock = DockStyle.Top
    '  _panel.Height = 10
    '  Me.Panel1.Controls.Add(_panel)
    '  _panel.BringToFront()

    '  Me.Panel2.Visible = True

    'End If

    If PuedeAgregar Then
      Me.Panel2.Visible = True

      Dim _boton As New LinkLabel
      _boton.Dock = DockStyle.Left
      '_boton.Padding = New Padding(0, 100, 0, 0)
      _boton.Text = "Agregar un nuevo registro"
      '_boton.Tag = _param
      _boton.AutoSize = True
      Me.Panel2.Controls.Add(_boton)
      _boton.BringToFront()
      '_boton.Visible = Not _param.Oculto
      AddHandler _boton.LinkClicked, AddressOf Abrir_Mantenimiento

      Dim _panel As New Panel
      _panel.Dock = DockStyle.Left
      _panel.Width = 10
      _panel.Height = 10
      Me.Panel2.Controls.Add(_panel)
      _panel.BringToFront()
    End If

    If PuedeEliminar Then
      Me.Panel2.Visible = True

      'Dim _panel As New Panel
      '_panel.Dock = DockStyle.Top
      '_panel.Height = 10
      'Me.Panel1.Controls.Add(_panel)
      '_panel.BringToFront()

      Dim _boton As New LinkLabel
      _boton.Dock = DockStyle.Left
      '_boton.Padding = New Padding(0, 100, 0, 0)
      _boton.Text = "Eliminar el registro actual"
      '_boton.Tag = _param
      _boton.AutoSize = True
      Me.Panel2.Controls.Add(_boton)
      _boton.BringToFront()
      '_boton.Visible = Not _param.Oculto
      AddHandler _boton.LinkClicked, AddressOf Eliminar
    End If

    If PuedeImprimir2 Then
      Me.PuedeImprimir = Me.PuedeImprimir2
    End If

    Actualizar_combos(Me, Nothing)
  End Sub

  Private Sub Llenar_Defaults()
    For Each _control As Control In TabPage2.Controls
      If TypeOf _control.Tag Is ParametroReporte Then
        Dim _param As ParametroReporte
        _param = _control.Tag
        Dim mvalor As Object = mReporte.RetornarValorDefault(_param.NombreParametro)

        If mvalor IsNot Nothing Then
          If TypeOf _control Is ComboBox Then
            CType(_control, ComboBox).SelectedValue = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
            CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
            CType(_control, Infoware.Controles.Base.TextBoxStd).Text = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
            CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value = mvalor
          ElseIf TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
            CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked = mvalor
          End If
        End If
      End If
    Next
  End Sub

  Private Sub Actualizar_combos(ByVal sender As Object, ByVal e As EventArgs)
    For Each _param As ParametroReporte In mReporte.Parametros
      If _param.TipoDatoNet = ParametroReporte.EnumTipoDato.ComboActualizable Then
        For Each _control As Control In TabPage2.Controls
          If _param Is _control.Tag Then
            Dim valor As Object = IIf(CType(_control, ComboBox).Enabled, CType(_control, ComboBox).SelectedValue, Nothing)

            Actualizar_valores()
            Dim _dssec As DataTable
            _dssec = mReporte.RetornarSubListaDataTableconParametros(_param.NombreParametro)

            Dim cbo As ComboBox = CType(_control, ComboBox)
            cbo.DisplayMember = _dssec.Columns(1).ColumnName
            cbo.ValueMember = _dssec.Columns(0).ColumnName
            cbo.DataSource = _dssec
            Try
              cbo.SelectedValue = valor
              If cbo.SelectedIndex = -1 Then
                cbo.SelectedIndex = 0
              End If
            Catch ex As Exception
            End Try
          End If
        Next
      End If
    Next
  End Sub

  Private Sub PonerValores()
    Try
      For t As Integer = 0 To mValores.Length - 1
        'If mReporte.Parametros(t).Oculto Then
        mReporte.Parametros(t).Valor = mValores(t)
        'End If
        For Each _control As Control In TabPage2.Controls
          If mReporte.Parametros(t) Is _control.Tag Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
                CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value = mValores(t)
              Else
                _control.Text = mValores(t)
              End If
            End If
            If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value = mValores(t)
            End If
            If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked = mValores(t)
            End If
            If TypeOf _control Is ComboBox Then
              CType(_control, ComboBox).SelectedValue = mValores(t)
            End If
          End If
        Next
      Next

      Actualizar_combos(Me, Nothing)
      btnejecutar_Click(Me, Nothing)
    Catch ex As Exception
    End Try
  End Sub

  'Sub habilitar(ByVal sender As Object, ByVal e As EventArgs)
  '  If TypeOf sender Is CheckBox Then
  '    Dim _check As CheckBox
  '    _check = CType(sender, CheckBox)
  '    CType(_check.Tag, ComboBox).Enabled = _check.Checked
  '  End If
  'End Sub
#End Region

#Region "New"
    Public Sub New(ByVal _Sistema As Sistema, ByVal _Restriccion As Restriccion, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        MyBase.New(_Sistema, _Restriccion, _OpcionNuevo)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        FrmLista_Inicializar(Me, Nothing)
    End Sub

    Public Sub New(ByVal _Sistema As Sistema, ByVal _OpcionActual As Enumerados.EnumOpciones, Optional ByVal _OpcionNuevo As Enumerados.EnumOpciones = Enumerados.EnumOpciones.ListadoTransaccionActivos)
        Me.New(_Sistema, _Sistema.Restricciones.Buscar(_OpcionActual), _OpcionNuevo)
    End Sub

  Private Sub FrmLista_Inicializar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Inicializar
    System.IO.Directory.CreateDirectory(Sistema.DirectorioRaiz)
    Dim _config As String = System.IO.Path.Combine(Sistema.DirectorioRaiz, "Configuracion")
    System.IO.Directory.CreateDirectory(_config)

    Me.ComboBoxConexionOtros1.Archivoxml = System.IO.Path.Combine(_config, "ConexionOtros.xml")
    Me.ComboBoxConexionOtros1.Llenar_datos()

    ToolStripManager.Merge(Me.ToolStrip2, Me.ToolStrip1)
    Me.ToolStrip2.Visible = False
  End Sub
#End Region

  Private Sub Actualizar_valores()
    For Each _control As Control In TabPage2.Controls
      If Not TypeOf _control Is Label Then
        If Not TypeOf _control.Tag Is ComboBox Then
          Dim _param As ParametroReporte = _control.Tag
          If Not _param.Oculto Then
            If TypeOf _control Is Infoware.Controles.Base.TextBoxStd Then
              _param.Valor = _control.Text
            End If
            If TypeOf _control Is Infoware.Controles.Base.TextBoxCalculator Then
              _param.Valor = CType(_control, Infoware.Controles.Base.TextBoxCalculator).Value
            End If
            If TypeOf _control Is Infoware.Controles.Base.DateTimePickerStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.DateTimePickerStd).Value.Date
            End If
            If TypeOf _control Is Infoware.Controles.Base.CheckBoxStd Then
              _param.Valor = CType(_control, Infoware.Controles.Base.CheckBoxStd).Checked
            End If
            If TypeOf _control Is ComboBox Then
              _param.Valor = IIf(CType(_control, ComboBox).Enabled, CType(_control, ComboBox).SelectedValue, Nothing)
            End If
          End If
        End If
      End If
    Next
  End Sub

  Private Sub btnejecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnejecutar.Click
    Ejecutar()
  End Sub

  Public Sub Ejecutar()
    If mReporte Is Nothing Then
      Exit Sub
    End If
    Actualizar_valores()


    Dim _StructExcelList As New StructExcelList
    Me.TabControl1.Tag = _StructExcelList

    Dim _dssubtotales As New DataTable
    _dssubtotales = mReporte.RetornarInfoExcelSubtotales

    Dim _dspivot As New DataTable
    _dspivot = mReporte.RetornarInfoExcelTablaDinamica

    Dim _dstotalizar As New DataSet
    _dstotalizar = mReporte.RetornarInfoExcelTotalizar

    Dim _dsgraficar As New DataTable
    _dsgraficar = mReporte.RetornarInfoExcelGraficar

    Dim _dsnombrehojas As New DataTable
    _dsnombrehojas = mReporte.RetornarInfoNombreHojas

    If _dssubtotales IsNot Nothing AndAlso _dssubtotales.Rows.Count > 0 Then
      For Each _row As DataRow In _dssubtotales.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structsubtotal As StructSubtotales
        _structsubtotal.CampoAgrupado = _row(1)
        Select Case CStr(_row(2)).ToUpper.Trim
          Case "SUMA"
            _structsubtotal.Funcion = EnumFuncion.Suma
          Case "PROMEDIO"
            _structsubtotal.Funcion = EnumFuncion.Promedio
          Case "CUENTA"
            _structsubtotal.Funcion = EnumFuncion.Cuenta
          Case "MAXIMO"
            _structsubtotal.Funcion = EnumFuncion.Maximo
          Case "MINIMO"
            _structsubtotal.Funcion = EnumFuncion.Minimo
        End Select
        Dim _resultado As New List(Of Integer)
        For t As Integer = 3 To _dssubtotales.Columns.Count - 1
          _resultado.Add(CInt(_row(t)))
        Next
        _structsubtotal.CamposResultado = _resultado
        _struct.Subtotales.Add(_structsubtotal)
      Next
    End If

    If _dspivot IsNot Nothing AndAlso _dspivot.Rows.Count > 0 Then
      For Each _row As DataRow In _dspivot.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structTablasDinamicas As New StructTablaDinamica
        _structTablasDinamicas.Pivots = New List(Of String)
        _structTablasDinamicas.PivotsColumns = New List(Of String)
        _structTablasDinamicas.Campos = New List(Of StructCampoTablaDinamica)

        For t As Integer = 1 To _dspivot.Columns.Count - 1 Step 3
          If CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOT" Or CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOTROW" Then
            _structTablasDinamicas.Pivots.Add(CStr(_dspivot.Rows(0)(t + 1)).Trim)
          ElseIf CStr(_dspivot.Rows(0)(t)).Trim.ToUpper = "PIVOTCOLUMN" Then
            _structTablasDinamicas.PivotsColumns.Add(CStr(_dspivot.Rows(0)(t + 1)).Trim)
          Else
            Dim _structcampotabladinamica As New StructCampoTablaDinamica
            _structcampotabladinamica.Campo = CStr(_dspivot.Rows(0)(t + 1)).Trim
            _structcampotabladinamica.Formato = CStr(_dspivot.Rows(0)(t + 2)).Trim
            Select Case CStr(_dspivot.Rows(0)(t)).Trim.ToUpper
              Case "SUMA"
                _structcampotabladinamica.Funcion = EnumFuncion.Suma
              Case "CUENTA"
                _structcampotabladinamica.Funcion = EnumFuncion.Cuenta
              Case "PROMEDIO"
                _structcampotabladinamica.Funcion = EnumFuncion.Promedio
              Case "MAXIMO"
                _structcampotabladinamica.Funcion = EnumFuncion.Maximo
              Case "MINIMO"
                _structcampotabladinamica.Funcion = EnumFuncion.Minimo
            End Select
            _structTablasDinamicas.Campos.Add(_structcampotabladinamica)
          End If
        Next

        _struct.TablaDinamica = _structTablasDinamicas
      Next
    End If

    If _dstotalizar IsNot Nothing AndAlso _dstotalizar.Tables.Count > 0 AndAlso _dstotalizar.Tables(0).Rows.Count > 0 Then
      For Each _table As DataTable In _dstotalizar.Tables
        For Each _row As DataRow In _table.Rows
          Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

          For t As Integer = 1 To _table.Columns.Count - 1 Step 2
            Dim _structtotalizar As New StructTotalizar
            Select Case CStr(_row(t)).ToUpper.Trim
              Case "SUMA"
                _structtotalizar.Funcion = EnumFuncion.Suma
              Case "PROMEDIO"
                _structtotalizar.Funcion = EnumFuncion.Promedio
              Case "CUENTA"
                _structtotalizar.Funcion = EnumFuncion.Cuenta
              Case "MAXIMO"
                _structtotalizar.Funcion = EnumFuncion.Maximo
              Case "MINIMO"
                _structtotalizar.Funcion = EnumFuncion.Minimo
            End Select
            _structtotalizar.Campo = CInt(_row(t + 1))
            _struct.Totalizar.Add(_structtotalizar)
          Next
        Next
      Next
    End If

    If _dsgraficar IsNot Nothing AndAlso _dsgraficar.Rows.Count > 0 Then
      For Each _row As DataRow In _dsgraficar.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        Dim _structgraficar As New StructGraficar
        _structgraficar.TipoGrafico = CInt(_row(1))
        _structgraficar.Orientacion = CInt(_row(2))
        _structgraficar.RelacionAncho = CDec(_row(3))
        _structgraficar.RelacionAlto = CDec(_row(4))
        _struct.Graficar = _structgraficar
      Next
    End If

    If _dsnombrehojas IsNot Nothing AndAlso _dsnombrehojas.Rows.Count > 0 Then
      For Each _row As DataRow In _dsnombrehojas.Rows
        Dim _struct As StructExcel = _StructExcelList.Devolver(_row(0))

        _struct.NombreHoja = CStr(_row(1))
      Next
    End If

    Dim _DataSet As New DataSet
    _DataSet = mReporte.RetornarDataSet

    If _DataSet Is Nothing Then
      MsgBox(String.Format("Error al ejecutar consulta. {0}", mReporte.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
    End If


    Dim estilonum0 As New DataGridViewCellStyle()
    estilonum0.Format = "N0"
    estilonum0.Alignment = DataGridViewContentAlignment.MiddleRight

    Dim estilonum2 As New DataGridViewCellStyle()
    estilonum2.Format = "N2"
    estilonum2.Alignment = DataGridViewContentAlignment.MiddleRight

    Me.TabControl1.TabPages.Clear()
    Dim count As Integer = 0
    For Each _table As DataTable In _DataSet.Tables
      'If count > 0 AndAlso (_table.Columns.Count = 2 OrElse _table.Columns.Count = 4) AndAlso count = _DataSet.Tables.Count - 1 Then
      '  Try
      '    For _countrow As Integer = 0 To _table.Rows.Count - 1
      '      Me.TabControl1.TabPages(_countrow).Text = _table.Rows(_countrow)(1)
      '      If _table.Columns.Count = 4 Then
      '        Dim _datosgraficos As New List(Of Integer)
      '        _datosgraficos.Add(_table.Rows(_countrow)(2))
      '        _datosgraficos.Add(_table.Rows(_countrow)(3))
      '        Me.TabControl1.TabPages(_countrow).Tag = _datosgraficos
      '      End If
      '    Next
      '  Catch ex As Exception
      '  End Try
      'Else
      count += 1
      Dim _tabpage As New TabPage
      Dim _dg As New DataGridView
      _dg.ReadOnly = True
      _dg.AllowUserToDeleteRows = False
      _dg.AllowUserToOrderColumns = False
      _dg.AllowUserToAddRows = False
      _dg.AllowUserToResizeRows = False
      AddHandler _dg.DoubleClick, AddressOf DataGridView1_DoubleClick
      AddHandler _dg.KeyDown, AddressOf DataGridView1_KeyDown

      _tabpage.Controls.Add(_dg)
      _dg.Dock = DockStyle.Fill
      Dim _bs As New BindingSource
      _dg.DataSource = _bs

      _dg.AutoGenerateColumns = True
      _bs.DataSource = _table.GetType
      _bs.DataSource = _table

      If String.IsNullOrEmpty(_StructExcelList.Devolver(count).NombreHoja) Then
        _tabpage.Text = "Resultado " & count.ToString.Trim
      Else
        _tabpage.Text = _StructExcelList.Devolver(count).NombreHoja
      End If

      For Each _col As DataGridViewColumn In _dg.Columns
        If _col.ValueType Is GetType(Decimal) Then
          If _col.HeaderText.ToUpper.Contains("__F") Then
            Dim estilonumN As New DataGridViewCellStyle()
            estilonumN.Format = _col.HeaderText.Substring(_col.HeaderText.ToUpper.IndexOf("__F") + 3)
            estilonumN.Alignment = DataGridViewContentAlignment.MiddleRight
            _col.DefaultCellStyle = estilonumN
            _col.HeaderText = _col.HeaderText.Substring(0, _col.HeaderText.ToUpper.IndexOf("__F"))
          Else
            _col.DefaultCellStyle = estilonum2
          End If
        End If
        If _col.ValueType Is GetType(Integer) Then
          _col.DefaultCellStyle = estilonum0
        End If
        _col.HeaderText = _col.HeaderText.Replace("_", " ")
      Next

      Me.TabControl1.TabPages.Add(_tabpage)

      If _table IsNot Nothing Then
        '_bs.DataMember = _table.TableName
        Me.lblmensaje.Text = String.Format("{0} registros seleccionados", _bs.Count)
      Else
        Me.lblmensaje.Text = "No existen registros en la vista actual"
      End If
      _dg.AutoResizeColumns()
      'End If
    Next
    ReiniciarProgressBar()
  End Sub

  Public Delegate Sub AbrirElemento(ByVal _fila As DataRow)

  Private mobjAbrirElemento As AbrirElemento
  Public Property objAbrirElemento() As AbrirElemento
    Get
      Return mobjAbrirElemento
    End Get
    Set(ByVal value As AbrirElemento)
      mobjAbrirElemento = value
    End Set
  End Property

  Private Sub Abrir_Mantenimiento(ByVal sender As Object, ByVal e As EventArgs)
    Abrir_Mant(Nothing, True)
  End Sub

  Private Sub FrmLista_Abrir(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Abrir
    If Fila Is Nothing Then
      Exit Sub
    End If
    If PuedeModificar Then
      Abrir_Mant(Fila, False)
    End If
    If objAbrirElemento IsNot Nothing Then
      objAbrirElemento.Invoke(Fila)
    End If
  End Sub

  Public Sub Abrir_Mant(ByVal _Elemento As DataRow, ByVal _esNuevo As Boolean)
    If mReporte Is Nothing Then
      Exit Sub
    End If
    Actualizar_valores()

    If _Elemento Is Nothing AndAlso _esNuevo Then
      _Elemento = mReporte.RetornarDataRowPlantillaNew()
    End If

    Dim _reporte As Reporte
    _reporte = New Reporte(mReporte.OperadorDatos, IIf(_Elemento Is Nothing, mManInsert, mManUpdate))
    _reporte.RetornarRegistroxDataRow(_Elemento, _esNuevo)

    Dim f As New FrmMantenimiento(Sistema, Restriccion)
    f.PuedeGuardaryNuevo = PuedeAgregar
    f.Reporte = _reporte
    'f.Elemento(mReporte) = _Elemento
    f.ShowDialog()

    If f.Volver Then
      Abrir_Mant(Nothing, True)
    Else
      Ejecutar()
    End If
  End Sub

  Private Sub Eliminar(ByVal sender As Object, ByVal e As EventArgs)
    If Fila Is Nothing OrElse MsgBox("Está seguro que desea eliminar este registro", MsgBoxStyle.YesNo, "Pregunta") = MsgBoxResult.No Then
      Exit Sub
    End If
    Dim _reporte As New Reporte(mReporte.OperadorDatos, mManDelete)
    _reporte.RetornarRegistroxDataRow(Fila, False)
    If Not _reporte.Eliminar() Then
      MsgBox(String.Format("Error al eliminar. {0}", _reporte.OperadorDatos.MsgError), MsgBoxStyle.Critical, "Error")
    End If
    Ejecutar()
  End Sub

  Public ReadOnly Property Fila() As DataRow
    Get
      If Me.TabControl1.SelectedTab Is Nothing Then
        Return Nothing
      Else
        Return CType(Me.TabControl1.SelectedTab.Controls(0), DataGridView).DataSource.Current.Row
      End If
    End Get
  End Property

  Private Sub FrmLista_Actualizar(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Actualizar
    Ejecutar()
  End Sub

  Public ReadOnly Property Control() As System.Windows.Forms.Control Implements Infoware.Consola.Base.IOpcion.Control
    Get
      Return Me.pnlcuerpo
    End Get
  End Property

  Public ReadOnly Property MenuStrip() As System.Windows.Forms.MenuStrip Implements Infoware.Consola.Base.IOpcion.MenuStrip
    Get
      Return Me.MenuStrip1
    End Get
  End Property

  Public ReadOnly Property ToolStrip() As System.Windows.Forms.ToolStrip Implements Infoware.Consola.Base.IOpcion.ToolStrip
    Get
      Return Me.ToolStrip1
    End Get
  End Property

  Private Sub tmrdatos_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrdatos.Tick
    'If mValores IsNot Nothing Then
    '  PonerValores()
    '  Me.tmrdatos.Enabled = False
    'End If
    If mValores IsNot Nothing Then
      PonerValores()
    End If
    'If mCargarFiltrosDefaults Then
    '  Llenar_Filtros()
    '  Llenar_Defaults()
    '  mCargarFiltrosDefaults = False
    'End If
    If PuedeAutoejecutar Then
      Ejecutar()
    End If
    'If EnviarMailAutomaticoyCerrar Then
    '  Me.EnviarAutoMail()
    '  Me.Close()
    'End If
    Me.tmrdatos.Enabled = False
  End Sub

  Private Sub ComboBoxConexionOtros1_CambioItem(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxConexionOtros1.CambioItem
    Llenar_Reportes()
  End Sub

  Private Sub Llenar_Reportes()
    Me.tvopciones.Nodes.Clear()
    Me.ImageList1.Images.Clear()

    If Me.ComboBoxConexionOtros1.OperadorDatos Is Nothing Then
      Exit Sub
    End If
    Dim _reportes As ReporteList = ReporteList.ObtenerLista(Me.ComboBoxConexionOtros1.OperadorDatos, "REP")
    Dim contimg As Integer = 0
    Dim contimg2 As Integer = 0

    Dim nodogrupo As TreeNode = Nothing
    For Each _reporte As Reporte In _reportes
      If _reporte.ValidarReporte(Sistema.UsuarioString) Then
                'Me.ImageList1.Images.Add(_reporte.NombreReporte, My.Resources.report)
        Dim nodo As TreeNode
        nodo = New TreeNode
        nodo.Text = _reporte.NombreReporte
        nodo.Tag = _reporte
        nodo.SelectedImageIndex = contimg
        nodo.ImageIndex = contimg
        contimg += 1

        If Not String.IsNullOrEmpty(_reporte.NombreGrupo) Then
          If nodogrupo Is Nothing OrElse (nodogrupo IsNot Nothing AndAlso nodogrupo.Text.Trim.ToUpper <> _reporte.NombreGrupo.Trim.ToUpper) Then
            Me.ImageList1.Images.Add(_reporte.NombreReporte, My.Resources.abrir)
            nodogrupo = New TreeNode
            nodogrupo.Text = _reporte.NombreGrupo
            nodogrupo.Tag = Nothing
            nodogrupo.SelectedImageIndex = contimg
            nodogrupo.ImageIndex = contimg
            contimg += 1
            Me.tvopciones.Nodes.Add(nodogrupo)
          End If
          nodogrupo.Nodes.Add(nodo)
        Else
          Me.tvopciones.Nodes.Add(nodo)
        End If
      End If
    Next

    Me.tvopciones.ExpandAll()

    'Me.pnlopciones.Height = (Me.tvopciones.Nodes.Count + 1) * 24

    If Me.tvopciones.Nodes.Count > 0 Then
      Me.tvopciones.SelectedNode = Me.tvopciones.Nodes(0)
    End If
  End Sub

  Private Sub tvopciones_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvopciones.AfterSelect
    If e.Node.Tag Is Nothing Then
      Exit Sub
    End If

    Me.Reporte = e.Node.Tag
    Me.TabConexion.SelectedTab = TabPage2
    tmrdatos.Enabled = True
  End Sub

  Private Sub btnconfemail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconfemail.Click
    Dim f As New FrmProgramacionEnvioMail(Sistema, Me.Restriccion, mReporte)
    f.ShowDialog()
    Me.AutoMailLista = mReporte.RetornarEmailLista
    mProgramacion = mReporte.RetornarEmailProgramacion
    EstablecerProximoAutoMail()
  End Sub

  Private Sub FrmLista_EnviandoAutoMail(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.EnviandoAutoMail
    EstablecerProximoAutoMail()
  End Sub

  Sub EstablecerProximoAutoMail()
    mProgramacion = mReporte.RetornarEmailProgramacion
    Me.ProximoAutoMail = mProgramacion.ProximoEnvio(3)
  End Sub
End Class
