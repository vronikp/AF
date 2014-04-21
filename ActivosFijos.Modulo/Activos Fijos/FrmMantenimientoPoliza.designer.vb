<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPoliza
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoPoliza))
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.dgdets = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsdets = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnnuevocomp = New System.Windows.Forms.ToolStripButton()
    Me.btnelimcomp = New System.Windows.Forms.ToolStripButton()
    Me.txtvalor = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfecfin = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtfecinicio = New System.Windows.Forms.DateTimePicker()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.CtlBuscaProveedor1 = New ActivosFijos.Modulo.CtlBuscaProveedor()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.txtvalor)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.txtdescripcion)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dtfecfin)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.dtfecinicio)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Controls.Add(Me.CtlBuscaProveedor1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(509, 450)
    Me.Panel1.TabIndex = 0
    '
    'Panel2
    '
    Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Panel2.Controls.Add(Me.dgdets)
    Me.Panel2.Controls.Add(Me.ToolStrip2)
    Me.Panel2.Location = New System.Drawing.Point(15, 148)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(482, 290)
    Me.Panel2.TabIndex = 36
    '
    'dgdets
    '
    Me.dgdets.AgruparRepetidos = False
    Me.dgdets.AllowUserToAddRows = False
    Me.dgdets.AllowUserToDeleteRows = False
    Me.dgdets.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgdets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgdets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5})
    Me.dgdets.DataSource = Me.bsdets
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdets.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgdets.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgdets.Location = New System.Drawing.Point(0, 25)
    Me.dgdets.Name = "dgdets"
    Me.dgdets.ReadOnly = True
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdets.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgdets.RowHeadersVisible = False
    Me.dgdets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
    Me.dgdets.Size = New System.Drawing.Size(482, 265)
    Me.dgdets.TabIndex = 1
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    Me.DataGridViewTextBoxColumn4.ReadOnly = True
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    Me.DataGridViewTextBoxColumn5.ReadOnly = True
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnnuevocomp, Me.btnelimcomp})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(482, 25)
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
    'txtvalor
    '
    Me.txtvalor.BackColor = System.Drawing.SystemColors.Window
    Me.txtvalor.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtvalor.Location = New System.Drawing.Point(138, 123)
    Me.txtvalor.Margin = New System.Windows.Forms.Padding(2)
    Me.txtvalor.Mensaje = ""
    Me.txtvalor.Name = "txtvalor"
    Me.txtvalor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalor.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalor.PromptText = ""
    Me.txtvalor.Size = New System.Drawing.Size(100, 20)
    Me.txtvalor.TabIndex = 8
    Me.txtvalor.Text = "0,00"
    Me.txtvalor.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalor.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalor.Value = 0.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 126)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(87, 13)
    Me.Label3.TabIndex = 7
    Me.Label3.Text = "Valor asegurado:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(138, 47)
    Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(355, 20)
    Me.txtdescripcion.TabIndex = 2
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 50)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Descripción:"
    '
    'dtfecfin
    '
    Me.dtfecfin.Location = New System.Drawing.Point(138, 98)
    Me.dtfecfin.Name = "dtfecfin"
    Me.dtfecfin.Size = New System.Drawing.Size(200, 20)
    Me.dtfecfin.TabIndex = 6
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 102)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(69, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Fecha de fin:"
    '
    'dtfecinicio
    '
    Me.dtfecinicio.Location = New System.Drawing.Point(138, 72)
    Me.dtfecinicio.Name = "dtfecinicio"
    Me.dtfecinicio.Size = New System.Drawing.Size(200, 20)
    Me.dtfecinicio.TabIndex = 4
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(12, 76)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(82, 13)
    Me.Label13.TabIndex = 3
    Me.Label13.Text = "Fecha de inicio:"
    '
    'CtlBuscaProveedor1
    '
    Me.CtlBuscaProveedor1.ItemText = "Proveedor"
    Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(15, 20)
    Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
    Me.CtlBuscaProveedor1.Proveedor = Nothing
    Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
    Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(478, 22)
    Me.CtlBuscaProveedor1.TabIndex = 0
    Me.CtlBuscaProveedor1.Ubicacion = ActivosFijos.Modulo.CtlBuscaProveedor.EnumUbicacion.Normal
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
    'FrmMantenimientoPoliza
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(509, 499)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoPoliza"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Póliza"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaProveedor1 As ActivosFijos.Modulo.CtlBuscaProveedor
  Friend WithEvents dtfecinicio As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecfin As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtvalor As Infoware.Controles.Base.TextBoxCalculator
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
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
