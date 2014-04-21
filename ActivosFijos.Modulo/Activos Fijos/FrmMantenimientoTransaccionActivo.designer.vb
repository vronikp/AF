<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoTransaccionActivo
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoTransaccionActivo))
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnlcabecera = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.ComboBoxUsuario1 = New ActivosFijos.Modulo.ComboBoxUsuario()
    Me.dtfecha = New System.Windows.Forms.DateTimePicker()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.dgdets = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsdets = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnnuevocomp = New System.Windows.Forms.ToolStripButton()
    Me.btnelimcomp = New System.Windows.Forms.ToolStripButton()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.CtlBuscaEmpleado1 = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    Me.chkcambiarubicacion = New System.Windows.Forms.CheckBox()
    Me.chkSolicitarconfirmacion = New System.Windows.Forms.CheckBox()
    Me.chkcambiarcustodio = New System.Windows.Forms.CheckBox()
    Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
    Me.grpcustodio = New System.Windows.Forms.GroupBox()
    Me.dgcustodios = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bscustodio = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.grpubicacion = New System.Windows.Forms.GroupBox()
    Me.dgubicaciones = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsubicacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.cmImprimir = New System.Windows.Forms.ContextMenuStrip(Me.components)
    Me.mnuacta = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnumail = New System.Windows.Forms.ToolStripMenuItem()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlcabecera.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.TableLayoutPanel1.SuspendLayout()
    Me.grpcustodio.SuspendLayout()
    CType(Me.dgcustodios, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bscustodio, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpubicacion.SuspendLayout()
    CType(Me.dgubicaciones, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.cmImprimir.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlcabecera)
    Me.Panel1.Controls.Add(Me.SplitContainer1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(822, 594)
    Me.Panel1.TabIndex = 0
    '
    'pnlcabecera
    '
    Me.pnlcabecera.Controls.Add(Me.Label3)
    Me.pnlcabecera.Controls.Add(Me.Label13)
    Me.pnlcabecera.Controls.Add(Me.ComboBoxUsuario1)
    Me.pnlcabecera.Controls.Add(Me.dtfecha)
    Me.pnlcabecera.Controls.Add(Me.txtcodigo)
    Me.pnlcabecera.Controls.Add(Me.Label2)
    Me.pnlcabecera.Controls.Add(Me.Label4)
    Me.pnlcabecera.Controls.Add(Me.txtdescripcion)
    Me.pnlcabecera.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcabecera.Location = New System.Drawing.Point(0, 0)
    Me.pnlcabecera.Name = "pnlcabecera"
    Me.pnlcabecera.Size = New System.Drawing.Size(822, 118)
    Me.pnlcabecera.TabIndex = 0
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 22)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(43, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Código:"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(12, 99)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(113, 13)
    Me.Label13.TabIndex = 6
    Me.Label13.Text = "Fecha de transacción:"
    '
    'ComboBoxUsuario1
    '
    Me.ComboBoxUsuario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxUsuario1.FormattingEnabled = True
    Me.ComboBoxUsuario1.Location = New System.Drawing.Point(138, 44)
    Me.ComboBoxUsuario1.Name = "ComboBoxUsuario1"
    Me.ComboBoxUsuario1.OperadorDatos = Nothing
    Me.ComboBoxUsuario1.PuedeActualizar = False
    Me.ComboBoxUsuario1.PuedeEliminar = False
    Me.ComboBoxUsuario1.PuedeModificar = False
    Me.ComboBoxUsuario1.PuedeNuevo = False
    Me.ComboBoxUsuario1.Size = New System.Drawing.Size(200, 21)
    Me.ComboBoxUsuario1.TabIndex = 3
    Me.ComboBoxUsuario1.Usuario = Nothing
    '
    'dtfecha
    '
    Me.dtfecha.Location = New System.Drawing.Point(138, 95)
    Me.dtfecha.Name = "dtfecha"
    Me.dtfecha.Size = New System.Drawing.Size(200, 20)
    Me.dtfecha.TabIndex = 7
    '
    'txtcodigo
    '
    Me.txtcodigo.BackColor = System.Drawing.SystemColors.Window
    Me.txtcodigo.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtcodigo.Location = New System.Drawing.Point(138, 19)
    Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.Text = "0"
    Me.txtcodigo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcodigo.Value = 0.0R
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Descripción:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(12, 47)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(46, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Usuario:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(138, 70)
    Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(355, 20)
    Me.txtdescripcion.TabIndex = 5
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.SplitContainer1.Location = New System.Drawing.Point(12, 121)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
    Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
    Me.SplitContainer1.Size = New System.Drawing.Size(798, 461)
    Me.SplitContainer1.SplitterDistance = 424
    Me.SplitContainer1.TabIndex = 38
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.dgdets)
    Me.Panel2.Controls.Add(Me.ToolStrip2)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel2.Location = New System.Drawing.Point(0, 228)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(424, 233)
    Me.Panel2.TabIndex = 36
    '
    'dgdets
    '
    Me.dgdets.AgruparRepetidos = False
    Me.dgdets.AllowUserToAddRows = False
    Me.dgdets.AllowUserToDeleteRows = False
    Me.dgdets.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgdets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgdets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17})
    Me.dgdets.DataSource = Me.bsdets
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdets.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgdets.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgdets.Location = New System.Drawing.Point(0, 25)
    Me.dgdets.Name = "dgdets"
    Me.dgdets.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdets.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgdets.RowHeadersVisible = False
    Me.dgdets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgdets.Size = New System.Drawing.Size(424, 208)
    Me.dgdets.TabIndex = 1
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    Me.DataGridViewTextBoxColumn13.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevocomp, Me.btnelimcomp})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(424, 25)
    Me.ToolStrip2.TabIndex = 0
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnnuevocomp
    '
    Me.btnnuevocomp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnnuevocomp.Image = CType(resources.GetObject("btnnuevocomp.Image"), System.Drawing.Image)
    Me.btnnuevocomp.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevocomp.Name = "btnnuevocomp"
    Me.btnnuevocomp.Size = New System.Drawing.Size(23, 22)
    Me.btnnuevocomp.Text = "Agregar activos"
    '
    'btnelimcomp
    '
    Me.btnelimcomp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
    Me.btnelimcomp.Image = CType(resources.GetObject("btnelimcomp.Image"), System.Drawing.Image)
    Me.btnelimcomp.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnelimcomp.Name = "btnelimcomp"
    Me.btnelimcomp.Size = New System.Drawing.Size(23, 22)
    Me.btnelimcomp.Text = "Eliminar activos"
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.CtlUbicacionActivo1)
    Me.Panel3.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Panel3.Controls.Add(Me.chkcambiarubicacion)
    Me.Panel3.Controls.Add(Me.chkSolicitarconfirmacion)
    Me.Panel3.Controls.Add(Me.chkcambiarcustodio)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(424, 228)
    Me.Panel3.TabIndex = 0
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Enabled = False
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(126, 77)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(355, 145)
    Me.CtlUbicacionActivo1.TabIndex = 4
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Custodio"
    Me.CtlBuscaEmpleado1.Enabled = False
    Me.CtlBuscaEmpleado1.ItemText = "Custodio"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(126, 3)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(355, 45)
    Me.CtlBuscaEmpleado1.TabIndex = 1
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Abajo
    '
    'chkcambiarubicacion
    '
    Me.chkcambiarubicacion.AutoSize = True
    Me.chkcambiarubicacion.Location = New System.Drawing.Point(3, 77)
    Me.chkcambiarubicacion.Name = "chkcambiarubicacion"
    Me.chkcambiarubicacion.Size = New System.Drawing.Size(113, 17)
    Me.chkcambiarubicacion.TabIndex = 3
    Me.chkcambiarubicacion.Text = "Cambiar ubicación"
    Me.chkcambiarubicacion.UseVisualStyleBackColor = True
    '
    'chkSolicitarconfirmacion
    '
    Me.chkSolicitarconfirmacion.AutoSize = True
    Me.chkSolicitarconfirmacion.Enabled = False
    Me.chkSolicitarconfirmacion.Location = New System.Drawing.Point(126, 54)
    Me.chkSolicitarconfirmacion.Name = "chkSolicitarconfirmacion"
    Me.chkSolicitarconfirmacion.Size = New System.Drawing.Size(213, 17)
    Me.chkSolicitarconfirmacion.TabIndex = 2
    Me.chkSolicitarconfirmacion.Text = "Solicitar confirmación al nuevo custodio"
    Me.chkSolicitarconfirmacion.UseVisualStyleBackColor = True
    '
    'chkcambiarcustodio
    '
    Me.chkcambiarcustodio.AutoSize = True
    Me.chkcambiarcustodio.Location = New System.Drawing.Point(3, 3)
    Me.chkcambiarcustodio.Name = "chkcambiarcustodio"
    Me.chkcambiarcustodio.Size = New System.Drawing.Size(107, 17)
    Me.chkcambiarcustodio.TabIndex = 0
    Me.chkcambiarcustodio.Text = "Cambiar custodio"
    Me.chkcambiarcustodio.UseVisualStyleBackColor = True
    '
    'TableLayoutPanel1
    '
    Me.TableLayoutPanel1.ColumnCount = 1
    Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Controls.Add(Me.grpcustodio, 0, 1)
    Me.TableLayoutPanel1.Controls.Add(Me.grpubicacion, 0, 0)
    Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
    Me.TableLayoutPanel1.RowCount = 2
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
    Me.TableLayoutPanel1.Size = New System.Drawing.Size(370, 461)
    Me.TableLayoutPanel1.TabIndex = 4
    '
    'grpcustodio
    '
    Me.grpcustodio.Controls.Add(Me.dgcustodios)
    Me.grpcustodio.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpcustodio.Location = New System.Drawing.Point(3, 233)
    Me.grpcustodio.Name = "grpcustodio"
    Me.grpcustodio.Size = New System.Drawing.Size(364, 225)
    Me.grpcustodio.TabIndex = 4
    Me.grpcustodio.TabStop = False
    Me.grpcustodio.Text = "Custodio"
    '
    'dgcustodios
    '
    Me.dgcustodios.AgruparRepetidos = False
    Me.dgcustodios.AllowUserToAddRows = False
    Me.dgcustodios.AllowUserToDeleteRows = False
    Me.dgcustodios.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcustodios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgcustodios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgcustodios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18})
    Me.dgcustodios.DataSource = Me.bscustodio
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgcustodios.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgcustodios.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgcustodios.Location = New System.Drawing.Point(3, 16)
    Me.dgcustodios.Name = "dgcustodios"
    Me.dgcustodios.ReadOnly = True
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcustodios.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgcustodios.Size = New System.Drawing.Size(358, 206)
    Me.dgcustodios.TabIndex = 0
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'grpubicacion
    '
    Me.grpubicacion.Controls.Add(Me.dgubicaciones)
    Me.grpubicacion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.grpubicacion.Location = New System.Drawing.Point(3, 3)
    Me.grpubicacion.Name = "grpubicacion"
    Me.grpubicacion.Size = New System.Drawing.Size(364, 224)
    Me.grpubicacion.TabIndex = 3
    Me.grpubicacion.TabStop = False
    Me.grpubicacion.Text = "Ubicación"
    '
    'dgubicaciones
    '
    Me.dgubicaciones.AgruparRepetidos = False
    Me.dgubicaciones.AllowUserToAddRows = False
    Me.dgubicaciones.AllowUserToDeleteRows = False
    Me.dgubicaciones.AutoGenerateColumns = False
    DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgubicaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
    Me.dgubicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgubicaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19})
    Me.dgubicaciones.DataSource = Me.bsubicacion
    DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgubicaciones.DefaultCellStyle = DataGridViewCellStyle8
    Me.dgubicaciones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgubicaciones.Location = New System.Drawing.Point(3, 16)
    Me.dgubicaciones.Name = "dgubicaciones"
    Me.dgubicaciones.ReadOnly = True
    DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgubicaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
    Me.dgubicaciones.Size = New System.Drawing.Size(358, 205)
    Me.dgubicaciones.TabIndex = 0
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    Me.DataGridViewTextBoxColumn19.ReadOnly = True
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    Me.DataGridViewTextBoxColumn10.ReadOnly = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    Me.DataGridViewTextBoxColumn11.ReadOnly = True
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    Me.DataGridViewTextBoxColumn12.ReadOnly = True
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    Me.DataGridViewTextBoxColumn7.ReadOnly = True
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    Me.DataGridViewTextBoxColumn9.ReadOnly = True
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    Me.DataGridViewTextBoxColumn8.ReadOnly = True
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    Me.DataGridViewTextBoxColumn6.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    Me.DataGridViewTextBoxColumn3.ReadOnly = True
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    '
    'DataGridViewTextBoxColumn46
    '
    Me.DataGridViewTextBoxColumn46.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
    '
    'DataGridViewTextBoxColumn45
    '
    Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
    '
    'cmImprimir
    '
    Me.cmImprimir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuacta, Me.mnumail})
    Me.cmImprimir.Name = "cmImprimir"
    Me.cmImprimir.Size = New System.Drawing.Size(153, 70)
    Me.cmImprimir.Text = "Imprimir"
    '
    'mnuacta
    '
    Me.mnuacta.Name = "mnuacta"
    Me.mnuacta.Size = New System.Drawing.Size(152, 22)
    Me.mnuacta.Text = "Acta"
    '
    'mnumail
    '
    Me.mnumail.Name = "mnumail"
    Me.mnumail.Size = New System.Drawing.Size(152, 22)
    Me.mnumail.Text = "Enviar mail"
    '
    'FrmMantenimientoTransaccionActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(822, 643)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoTransaccionActivo"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Transacción activo"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnlcabecera.ResumeLayout(False)
    Me.pnlcabecera.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.TableLayoutPanel1.ResumeLayout(False)
    Me.grpcustodio.ResumeLayout(False)
    CType(Me.dgcustodios, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bscustodio, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpubicacion.ResumeLayout(False)
    CType(Me.dgubicaciones, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsubicacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.cmImprimir.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents dgdets As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsdets As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnnuevocomp As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnelimcomp As System.Windows.Forms.ToolStripButton
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ComboBoxUsuario1 As ActivosFijos.Modulo.ComboBoxUsuario
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents CtlBuscaEmpleado1 As ActivosFijos.Modulo.CtlBuscaEmpleado
  Friend WithEvents chkcambiarubicacion As System.Windows.Forms.CheckBox
  Friend WithEvents chkSolicitarconfirmacion As System.Windows.Forms.CheckBox
  Friend WithEvents chkcambiarcustodio As System.Windows.Forms.CheckBox
  Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents grpcustodio As System.Windows.Forms.GroupBox
  Friend WithEvents dgcustodios As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bscustodio As System.Windows.Forms.BindingSource
  Friend WithEvents grpubicacion As System.Windows.Forms.GroupBox
  Friend WithEvents dgubicaciones As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsubicacion As System.Windows.Forms.BindingSource
  Friend WithEvents pnlcabecera As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cmImprimir As System.Windows.Forms.ContextMenuStrip
  Friend WithEvents mnuacta As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents mnumail As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
