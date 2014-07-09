<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlBuscaActivos
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CtlBuscaActivos))
        Me.HeaderStrip2 = New Infoware.Docking.HeaderStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlcierre = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnbuscaractivos = New System.Windows.Forms.ToolStripButton()
        Me.btnimprimiractivos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.MnuDeprec = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PorGrupoTipoClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorCustodioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PorUbicacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnexportar = New System.Windows.Forms.ToolStripButton()
        Me.pnlfecha = New System.Windows.Forms.Panel()
        Me.pnlrangofechas = New System.Windows.Forms.Panel()
        Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
        Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
        Me.cbotipofecha = New System.Windows.Forms.ComboBox()
        Me.chkfecha = New System.Windows.Forms.CheckBox()
        Me.chksoloactivos = New System.Windows.Forms.CheckBox()
        Me.pnlestadoinv = New System.Windows.Forms.Panel()
        Me.cboestadoinv = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.chkestadoinv = New System.Windows.Forms.CheckBox()
        Me.pnlubicacion = New System.Windows.Forms.Panel()
        Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
        Me.chkubicacion = New System.Windows.Forms.CheckBox()
        Me.pnlcustodio = New System.Windows.Forms.Panel()
        Me.CtlBuscaEmpleado1 = New ActivosFijos.Modulo.CtlBuscaEmpleado()
        Me.chkcustodio = New System.Windows.Forms.CheckBox()
        Me.pnlproveedor = New System.Windows.Forms.Panel()
        Me.pnlfactura = New System.Windows.Forms.Panel()
        Me.CtlBuscaFactura1 = New ActivosFijos.Modulo.CtlBuscaFactura()
        Me.chkfactura = New System.Windows.Forms.CheckBox()
        Me.CtlBuscaProveedor1 = New ActivosFijos.Modulo.CtlBuscaProveedor()
        Me.chkproveedor = New System.Windows.Forms.CheckBox()
        Me.txtmodelo = New Infoware.Controles.Base.TextBoxStd()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlmarca = New System.Windows.Forms.Panel()
        Me.cboMarca = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.chkmarca = New System.Windows.Forms.CheckBox()
        Me.pnlgrupo = New System.Windows.Forms.Panel()
        Me.CtlGrupoTipoClase = New ActivosFijos.Modulo.CtlParametroDetAnidado()
        Me.chkgrupo = New System.Windows.Forms.CheckBox()
        Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtserie = New Infoware.Controles.Base.TextBoxStd()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigoaux = New Infoware.Controles.Base.TextBoxStd()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcodigobarra = New Infoware.Controles.Base.TextBoxStd()
        Me.HeaderStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlcierre.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlfecha.SuspendLayout()
        Me.pnlrangofechas.SuspendLayout()
        Me.pnlestadoinv.SuspendLayout()
        Me.pnlubicacion.SuspendLayout()
        Me.pnlcustodio.SuspendLayout()
        Me.pnlproveedor.SuspendLayout()
        Me.pnlfactura.SuspendLayout()
        Me.pnlmarca.SuspendLayout()
        Me.pnlgrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderStrip2
        '
        Me.HeaderStrip2.AutoSize = False
        Me.HeaderStrip2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.HeaderStrip2.ForeColor = System.Drawing.Color.Black
        Me.HeaderStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.HeaderStrip2.HeaderStyle = Infoware.Docking.AreaHeaderStyle.Small
        Me.HeaderStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.HeaderStrip2.Location = New System.Drawing.Point(0, 0)
        Me.HeaderStrip2.Name = "HeaderStrip2"
        Me.HeaderStrip2.Size = New System.Drawing.Size(265, 21)
        Me.HeaderStrip2.TabIndex = 0
        Me.HeaderStrip2.Text = "Opciones"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(117, 18)
        Me.ToolStripLabel2.Text = "Búsqueda de Activos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(15, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de barras"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlcierre)
        Me.Panel1.Controls.Add(Me.pnlfecha)
        Me.Panel1.Controls.Add(Me.chkfecha)
        Me.Panel1.Controls.Add(Me.chksoloactivos)
        Me.Panel1.Controls.Add(Me.pnlestadoinv)
        Me.Panel1.Controls.Add(Me.chkestadoinv)
        Me.Panel1.Controls.Add(Me.pnlubicacion)
        Me.Panel1.Controls.Add(Me.chkubicacion)
        Me.Panel1.Controls.Add(Me.pnlcustodio)
        Me.Panel1.Controls.Add(Me.chkcustodio)
        Me.Panel1.Controls.Add(Me.pnlproveedor)
        Me.Panel1.Controls.Add(Me.chkproveedor)
        Me.Panel1.Controls.Add(Me.txtmodelo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.pnlmarca)
        Me.Panel1.Controls.Add(Me.chkmarca)
        Me.Panel1.Controls.Add(Me.pnlgrupo)
        Me.Panel1.Controls.Add(Me.chkgrupo)
        Me.Panel1.Controls.Add(Me.txtdescripcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtserie)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtcodigoaux)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtcodigobarra)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 5, 5, 5)
        Me.Panel1.Size = New System.Drawing.Size(265, 960)
        Me.Panel1.TabIndex = 1
        '
        'pnlcierre
        '
        Me.pnlcierre.Controls.Add(Me.ToolStrip1)
        Me.pnlcierre.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlcierre.Location = New System.Drawing.Point(15, 818)
        Me.pnlcierre.Name = "pnlcierre"
        Me.pnlcierre.Size = New System.Drawing.Size(245, 35)
        Me.pnlcierre.TabIndex = 21
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnbuscaractivos, Me.btnimprimiractivos, Me.btnexportar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(245, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnbuscaractivos
        '
        Me.btnbuscaractivos.Image = CType(resources.GetObject("btnbuscaractivos.Image"), System.Drawing.Image)
        Me.btnbuscaractivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnbuscaractivos.Name = "btnbuscaractivos"
        Me.btnbuscaractivos.Size = New System.Drawing.Size(62, 22)
        Me.btnbuscaractivos.Text = "Buscar"
        '
        'btnimprimiractivos
        '
        Me.btnimprimiractivos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuDeprec, Me.ToolStripMenuItem1, Me.PorGrupoTipoClaseToolStripMenuItem, Me.PorCustodioToolStripMenuItem, Me.PorUbicacionToolStripMenuItem, Me.ToolStripMenuItem2, Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem})
        Me.btnimprimiractivos.Image = CType(resources.GetObject("btnimprimiractivos.Image"), System.Drawing.Image)
        Me.btnimprimiractivos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnimprimiractivos.Name = "btnimprimiractivos"
        Me.btnimprimiractivos.Size = New System.Drawing.Size(82, 22)
        Me.btnimprimiractivos.Text = "Imprimir"
        '
        'MnuDeprec
        '
        Me.MnuDeprec.CheckOnClick = True
        Me.MnuDeprec.Name = "MnuDeprec"
        Me.MnuDeprec.Size = New System.Drawing.Size(328, 22)
        Me.MnuDeprec.Text = "Reportes con información de Depreciación"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(325, 6)
        '
        'PorGrupoTipoClaseToolStripMenuItem
        '
        Me.PorGrupoTipoClaseToolStripMenuItem.Name = "PorGrupoTipoClaseToolStripMenuItem"
        Me.PorGrupoTipoClaseToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.PorGrupoTipoClaseToolStripMenuItem.Text = "Por Grupo/Tipo/Clase"
        '
        'PorCustodioToolStripMenuItem
        '
        Me.PorCustodioToolStripMenuItem.Name = "PorCustodioToolStripMenuItem"
        Me.PorCustodioToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.PorCustodioToolStripMenuItem.Text = "Por Custodio"
        '
        'PorUbicacionToolStripMenuItem
        '
        Me.PorUbicacionToolStripMenuItem.Name = "PorUbicacionToolStripMenuItem"
        Me.PorUbicacionToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.PorUbicacionToolStripMenuItem.Text = "Por Ubicación"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(325, 6)
        '
        'ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem
        '
        Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem.Name = "ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem"
        Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem.Size = New System.Drawing.Size(328, 22)
        Me.ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem.Text = "Imprimir código de barras activos seleccionados"
        '
        'btnexportar
        '
        Me.btnexportar.Image = CType(resources.GetObject("btnexportar.Image"), System.Drawing.Image)
        Me.btnexportar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnexportar.Name = "btnexportar"
        Me.btnexportar.Size = New System.Drawing.Size(70, 22)
        Me.btnexportar.Text = "Exportar"
        Me.btnexportar.Visible = False
        '
        'pnlfecha
        '
        Me.pnlfecha.Controls.Add(Me.pnlrangofechas)
        Me.pnlfecha.Controls.Add(Me.cbotipofecha)
        Me.pnlfecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfecha.Location = New System.Drawing.Point(15, 772)
        Me.pnlfecha.Name = "pnlfecha"
        Me.pnlfecha.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlfecha.Size = New System.Drawing.Size(245, 46)
        Me.pnlfecha.TabIndex = 25
        Me.pnlfecha.Visible = False
        '
        'pnlrangofechas
        '
        Me.pnlrangofechas.Controls.Add(Me.dtfechasta)
        Me.pnlrangofechas.Controls.Add(Me.dtfecdesde)
        Me.pnlrangofechas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlrangofechas.Location = New System.Drawing.Point(15, 21)
        Me.pnlrangofechas.Name = "pnlrangofechas"
        Me.pnlrangofechas.Size = New System.Drawing.Size(230, 25)
        Me.pnlrangofechas.TabIndex = 1
        '
        'dtfechasta
        '
        Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechasta.Location = New System.Drawing.Point(88, 3)
        Me.dtfechasta.Name = "dtfechasta"
        Me.dtfechasta.Size = New System.Drawing.Size(82, 20)
        Me.dtfechasta.TabIndex = 1
        '
        'dtfecdesde
        '
        Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecdesde.Location = New System.Drawing.Point(3, 3)
        Me.dtfecdesde.Name = "dtfecdesde"
        Me.dtfecdesde.Size = New System.Drawing.Size(82, 20)
        Me.dtfecdesde.TabIndex = 0
        '
        'cbotipofecha
        '
        Me.cbotipofecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbotipofecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipofecha.FormattingEnabled = True
        Me.cbotipofecha.Items.AddRange(New Object() {"Compra entre", "Inicio depreciacion entre", "Uso entre", "Baja entre", "Fin de garantia entre", "Sin fecha de uso", "Con fecha de baja", "Sin garantia", "Con garantia"})
        Me.cbotipofecha.Location = New System.Drawing.Point(15, 0)
        Me.cbotipofecha.Name = "cbotipofecha"
        Me.cbotipofecha.Size = New System.Drawing.Size(230, 21)
        Me.cbotipofecha.TabIndex = 0
        '
        'chkfecha
        '
        Me.chkfecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkfecha.Location = New System.Drawing.Point(15, 755)
        Me.chkfecha.Name = "chkfecha"
        Me.chkfecha.Size = New System.Drawing.Size(245, 17)
        Me.chkfecha.TabIndex = 24
        Me.chkfecha.Text = "Solo fechas"
        '
        'chksoloactivos
        '
        Me.chksoloactivos.Checked = True
        Me.chksoloactivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chksoloactivos.Dock = System.Windows.Forms.DockStyle.Top
        Me.chksoloactivos.Location = New System.Drawing.Point(15, 738)
        Me.chksoloactivos.Name = "chksoloactivos"
        Me.chksoloactivos.Size = New System.Drawing.Size(245, 17)
        Me.chksoloactivos.TabIndex = 20
        Me.chksoloactivos.Text = "Solo items activos"
        '
        'pnlestadoinv
        '
        Me.pnlestadoinv.Controls.Add(Me.cboestadoinv)
        Me.pnlestadoinv.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlestadoinv.Location = New System.Drawing.Point(15, 717)
        Me.pnlestadoinv.Name = "pnlestadoinv"
        Me.pnlestadoinv.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlestadoinv.Size = New System.Drawing.Size(245, 21)
        Me.pnlestadoinv.TabIndex = 23
        Me.pnlestadoinv.Visible = False
        '
        'cboestadoinv
        '
        Me.cboestadoinv.AbriralEntrar = False
        Me.cboestadoinv.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboestadoinv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboestadoinv.FormattingEnabled = True
        Me.cboestadoinv.Location = New System.Drawing.Point(15, 0)
        Me.cboestadoinv.Margin = New System.Windows.Forms.Padding(2)
        Me.cboestadoinv.MostrarRutaCompleta = False
        Me.cboestadoinv.Name = "cboestadoinv"
        Me.cboestadoinv.OperadorDatos = Nothing
        Me.cboestadoinv.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboestadoinv.ParametroDet = Nothing
        Me.cboestadoinv.PuedeActualizar = True
        Me.cboestadoinv.PuedeEliminar = True
        Me.cboestadoinv.PuedeModificar = True
        Me.cboestadoinv.PuedeNuevo = True
        Me.cboestadoinv.Size = New System.Drawing.Size(230, 21)
        Me.cboestadoinv.TabIndex = 0
        '
        'chkestadoinv
        '
        Me.chkestadoinv.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkestadoinv.Location = New System.Drawing.Point(15, 700)
        Me.chkestadoinv.Name = "chkestadoinv"
        Me.chkestadoinv.Size = New System.Drawing.Size(245, 17)
        Me.chkestadoinv.TabIndex = 22
        Me.chkestadoinv.Text = "Actual estado de inventario"
        '
        'pnlubicacion
        '
        Me.pnlubicacion.Controls.Add(Me.CtlUbicacionActivo1)
        Me.pnlubicacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlubicacion.Location = New System.Drawing.Point(15, 564)
        Me.pnlubicacion.Name = "pnlubicacion"
        Me.pnlubicacion.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlubicacion.Size = New System.Drawing.Size(245, 136)
        Me.pnlubicacion.TabIndex = 19
        Me.pnlubicacion.Visible = False
        '
        'CtlUbicacionActivo1
        '
        Me.CtlUbicacionActivo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(15, 0)
        Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
        Me.CtlUbicacionActivo1.ParametroDet = Nothing
        Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
        Me.CtlUbicacionActivo1.PardetRaiz = Nothing
        Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(230, 136)
        Me.CtlUbicacionActivo1.SoloVisibles = False
        Me.CtlUbicacionActivo1.TabIndex = 0
        '
        'chkubicacion
        '
        Me.chkubicacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkubicacion.Location = New System.Drawing.Point(15, 547)
        Me.chkubicacion.Name = "chkubicacion"
        Me.chkubicacion.Size = New System.Drawing.Size(245, 17)
        Me.chkubicacion.TabIndex = 18
        Me.chkubicacion.Text = "Actualmente en ubicación:"
        '
        'pnlcustodio
        '
        Me.pnlcustodio.Controls.Add(Me.CtlBuscaEmpleado1)
        Me.pnlcustodio.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlcustodio.Location = New System.Drawing.Point(15, 502)
        Me.pnlcustodio.Name = "pnlcustodio"
        Me.pnlcustodio.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlcustodio.Size = New System.Drawing.Size(245, 45)
        Me.pnlcustodio.TabIndex = 17
        Me.pnlcustodio.Visible = False
        '
        'CtlBuscaEmpleado1
        '
        Me.CtlBuscaEmpleado1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlBuscaEmpleado1.Empleado = Nothing
        Me.CtlBuscaEmpleado1.EmpleadoText = "Custodio"
        Me.CtlBuscaEmpleado1.ItemText = "Custodio"
        Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(15, 0)
        Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
        Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(230, 43)
        Me.CtlBuscaEmpleado1.SoloActivos = False
        Me.CtlBuscaEmpleado1.TabIndex = 0
        Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
        Me.CtlBuscaEmpleado1.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Abajo
        '
        'chkcustodio
        '
        Me.chkcustodio.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkcustodio.Location = New System.Drawing.Point(15, 485)
        Me.chkcustodio.Name = "chkcustodio"
        Me.chkcustodio.Size = New System.Drawing.Size(245, 17)
        Me.chkcustodio.TabIndex = 16
        Me.chkcustodio.Text = "Actualmente en custodia de:"
        '
        'pnlproveedor
        '
        Me.pnlproveedor.Controls.Add(Me.pnlfactura)
        Me.pnlproveedor.Controls.Add(Me.chkfactura)
        Me.pnlproveedor.Controls.Add(Me.CtlBuscaProveedor1)
        Me.pnlproveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlproveedor.Location = New System.Drawing.Point(15, 378)
        Me.pnlproveedor.Name = "pnlproveedor"
        Me.pnlproveedor.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlproveedor.Size = New System.Drawing.Size(245, 107)
        Me.pnlproveedor.TabIndex = 15
        Me.pnlproveedor.Visible = False
        '
        'pnlfactura
        '
        Me.pnlfactura.Controls.Add(Me.CtlBuscaFactura1)
        Me.pnlfactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlfactura.Location = New System.Drawing.Point(15, 62)
        Me.pnlfactura.Name = "pnlfactura"
        Me.pnlfactura.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlfactura.Size = New System.Drawing.Size(230, 45)
        Me.pnlfactura.TabIndex = 2
        Me.pnlfactura.Visible = False
        '
        'CtlBuscaFactura1
        '
        Me.CtlBuscaFactura1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlBuscaFactura1.FacturaActivo = Nothing
        Me.CtlBuscaFactura1.FacturaText = "Factura"
        Me.CtlBuscaFactura1.ItemText = "Factura"
        Me.CtlBuscaFactura1.Location = New System.Drawing.Point(15, 0)
        Me.CtlBuscaFactura1.Name = "CtlBuscaFactura1"
        Me.CtlBuscaFactura1.Proveedor = Nothing
        Me.CtlBuscaFactura1.Size = New System.Drawing.Size(215, 45)
        Me.CtlBuscaFactura1.TabIndex = 0
        Me.CtlBuscaFactura1.Ubicacion = ActivosFijos.Modulo.CtlBuscaFactura.EnumUbicacion.Abajo
        '
        'chkfactura
        '
        Me.chkfactura.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkfactura.Location = New System.Drawing.Point(15, 45)
        Me.chkfactura.Name = "chkfactura"
        Me.chkfactura.Size = New System.Drawing.Size(230, 17)
        Me.chkfactura.TabIndex = 1
        Me.chkfactura.Text = "Solo esta factura:"
        '
        'CtlBuscaProveedor1
        '
        Me.CtlBuscaProveedor1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlBuscaProveedor1.ItemText = "Proveedor"
        Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(15, 0)
        Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
        Me.CtlBuscaProveedor1.Proveedor = Nothing
        Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
        Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(230, 45)
        Me.CtlBuscaProveedor1.SoloActivos = False
        Me.CtlBuscaProveedor1.TabIndex = 0
        Me.CtlBuscaProveedor1.Ubicacion = ActivosFijos.Modulo.CtlBuscaProveedor.EnumUbicacion.Abajo
        '
        'chkproveedor
        '
        Me.chkproveedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkproveedor.Location = New System.Drawing.Point(15, 361)
        Me.chkproveedor.Name = "chkproveedor"
        Me.chkproveedor.Size = New System.Drawing.Size(245, 17)
        Me.chkproveedor.TabIndex = 14
        Me.chkproveedor.Text = "Solo este Proveedor:"
        '
        'txtmodelo
        '
        Me.txtmodelo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtmodelo.Location = New System.Drawing.Point(15, 341)
        Me.txtmodelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmodelo.Mensaje = ""
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmodelo.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtmodelo.PromptText = ""
        Me.txtmodelo.Size = New System.Drawing.Size(245, 20)
        Me.txtmodelo.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(15, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Modelo"
        '
        'pnlmarca
        '
        Me.pnlmarca.Controls.Add(Me.cboMarca)
        Me.pnlmarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlmarca.Location = New System.Drawing.Point(15, 307)
        Me.pnlmarca.Name = "pnlmarca"
        Me.pnlmarca.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlmarca.Size = New System.Drawing.Size(245, 21)
        Me.pnlmarca.TabIndex = 11
        Me.pnlmarca.Visible = False
        '
        'cboMarca
        '
        Me.cboMarca.AbriralEntrar = False
        Me.cboMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(15, 0)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMarca.MostrarRutaCompleta = False
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.OperadorDatos = Nothing
        Me.cboMarca.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboMarca.ParametroDet = Nothing
        Me.cboMarca.PuedeActualizar = True
        Me.cboMarca.PuedeEliminar = True
        Me.cboMarca.PuedeModificar = True
        Me.cboMarca.PuedeNuevo = True
        Me.cboMarca.Size = New System.Drawing.Size(230, 21)
        Me.cboMarca.TabIndex = 0
        '
        'chkmarca
        '
        Me.chkmarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkmarca.Location = New System.Drawing.Point(15, 290)
        Me.chkmarca.Name = "chkmarca"
        Me.chkmarca.Size = New System.Drawing.Size(245, 17)
        Me.chkmarca.TabIndex = 10
        Me.chkmarca.Text = "Solo esta marca:"
        '
        'pnlgrupo
        '
        Me.pnlgrupo.Controls.Add(Me.CtlGrupoTipoClase)
        Me.pnlgrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlgrupo.Location = New System.Drawing.Point(15, 154)
        Me.pnlgrupo.Name = "pnlgrupo"
        Me.pnlgrupo.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlgrupo.Size = New System.Drawing.Size(245, 136)
        Me.pnlgrupo.TabIndex = 9
        Me.pnlgrupo.Visible = False
        '
        'CtlGrupoTipoClase
        '
        Me.CtlGrupoTipoClase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlGrupoTipoClase.Location = New System.Drawing.Point(15, 0)
        Me.CtlGrupoTipoClase.Name = "CtlGrupoTipoClase"
        Me.CtlGrupoTipoClase.ParametroDet = Nothing
        Me.CtlGrupoTipoClase.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
        Me.CtlGrupoTipoClase.PardetRaiz = Nothing
        Me.CtlGrupoTipoClase.Size = New System.Drawing.Size(230, 136)
        Me.CtlGrupoTipoClase.SoloVisibles = False
        Me.CtlGrupoTipoClase.TabIndex = 1
        '
        'chkgrupo
        '
        Me.chkgrupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkgrupo.Location = New System.Drawing.Point(15, 137)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(245, 17)
        Me.chkgrupo.TabIndex = 8
        Me.chkgrupo.Text = "Solo este grupo:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtdescripcion.Location = New System.Drawing.Point(15, 117)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcion.Mensaje = ""
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtdescripcion.PromptText = ""
        Me.txtdescripcion.Size = New System.Drawing.Size(245, 20)
        Me.txtdescripcion.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(15, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Descripcion"
        '
        'txtserie
        '
        Me.txtserie.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtserie.Location = New System.Drawing.Point(15, 84)
        Me.txtserie.Margin = New System.Windows.Forms.Padding(2)
        Me.txtserie.Mensaje = ""
        Me.txtserie.Name = "txtserie"
        Me.txtserie.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserie.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtserie.PromptText = ""
        Me.txtserie.Size = New System.Drawing.Size(245, 20)
        Me.txtserie.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serie"
        '
        'txtcodigoaux
        '
        Me.txtcodigoaux.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtcodigoaux.Location = New System.Drawing.Point(15, 51)
        Me.txtcodigoaux.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigoaux.Mensaje = ""
        Me.txtcodigoaux.Name = "txtcodigoaux"
        Me.txtcodigoaux.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigoaux.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcodigoaux.PromptText = ""
        Me.txtcodigoaux.Size = New System.Drawing.Size(245, 20)
        Me.txtcodigoaux.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(15, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Código auxiliar"
        '
        'txtcodigobarra
        '
        Me.txtcodigobarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtcodigobarra.Location = New System.Drawing.Point(15, 18)
        Me.txtcodigobarra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcodigobarra.Mensaje = ""
        Me.txtcodigobarra.Name = "txtcodigobarra"
        Me.txtcodigobarra.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigobarra.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcodigobarra.PromptText = ""
        Me.txtcodigobarra.Size = New System.Drawing.Size(245, 20)
        Me.txtcodigobarra.TabIndex = 1
        '
        'CtlBuscaActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderStrip2)
        Me.Name = "CtlBuscaActivos"
        Me.Size = New System.Drawing.Size(265, 981)
        Me.HeaderStrip2.ResumeLayout(False)
        Me.HeaderStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlcierre.ResumeLayout(False)
        Me.pnlcierre.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlfecha.ResumeLayout(False)
        Me.pnlrangofechas.ResumeLayout(False)
        Me.pnlestadoinv.ResumeLayout(False)
        Me.pnlubicacion.ResumeLayout(False)
        Me.pnlcustodio.ResumeLayout(False)
        Me.pnlproveedor.ResumeLayout(False)
        Me.pnlfactura.ResumeLayout(False)
        Me.pnlmarca.ResumeLayout(False)
        Me.pnlgrupo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
  Friend WithEvents HeaderStrip2 As Infoware.Docking.HeaderStrip
  Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtcodigobarra As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtserie As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pnlgrupo As System.Windows.Forms.Panel
  Friend WithEvents chkgrupo As System.Windows.Forms.CheckBox
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtmodelo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents pnlmarca As System.Windows.Forms.Panel
  Friend WithEvents cboMarca As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents chkmarca As System.Windows.Forms.CheckBox
  Friend WithEvents pnlcierre As System.Windows.Forms.Panel
  Friend WithEvents pnlproveedor As System.Windows.Forms.Panel
  Friend WithEvents pnlfactura As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaFactura1 As ActivosFijos.Modulo.CtlBuscaFactura
  Friend WithEvents chkfactura As System.Windows.Forms.CheckBox
  Friend WithEvents CtlBuscaProveedor1 As ActivosFijos.Modulo.CtlBuscaProveedor
  Friend WithEvents chkproveedor As System.Windows.Forms.CheckBox
  Friend WithEvents pnlcustodio As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaEmpleado1 As ActivosFijos.Modulo.CtlBuscaEmpleado
  Friend WithEvents chkcustodio As System.Windows.Forms.CheckBox
  Friend WithEvents pnlubicacion As System.Windows.Forms.Panel
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents chkubicacion As System.Windows.Forms.CheckBox
  Friend WithEvents chksoloactivos As System.Windows.Forms.CheckBox
  Friend WithEvents txtcodigoaux As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents CtlGrupoTipoClase As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents pnlestadoinv As System.Windows.Forms.Panel
  Friend WithEvents cboestadoinv As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents chkestadoinv As System.Windows.Forms.CheckBox
  Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnbuscaractivos As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnexportar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnimprimiractivos As System.Windows.Forms.ToolStripDropDownButton
  Friend WithEvents PorGrupoTipoClaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PorCustodioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents PorUbicacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents MnuDeprec As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents ImprimirCódigoDeBarrasActivosSeleccionadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents pnlfecha As System.Windows.Forms.Panel
  Friend WithEvents chkfecha As System.Windows.Forms.CheckBox
  Friend WithEvents pnlrangofechas As System.Windows.Forms.Panel
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbotipofecha As System.Windows.Forms.ComboBox

End Class
