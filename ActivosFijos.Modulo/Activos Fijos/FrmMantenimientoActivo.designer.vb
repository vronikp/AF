Imports Infoware.Consola.Base

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoActivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoActivo))
        Me.bscaracteristica = New System.Windows.Forms.BindingSource(Me.components)
        Me.bscustodio = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsubicacion = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsdepreciaciones = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsvaloracion = New System.Windows.Forms.BindingSource(Me.components)
        Me.bscomponentes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bspoliza = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsinventarios = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlbusqueda = New System.Windows.Forms.Panel()
        Me.pnldatosbusqueda = New System.Windows.Forms.Panel()
        Me.dgActivos = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtlBuscaActivos1 = New ActivosFijos.Modulo.CtlBuscaActivos()
        Me.pnlmantenimiento = New System.Windows.Forms.Panel()
        Me.CtlActivo1 = New ActivosFijos.Modulo.CtlActivo()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btncodigobarras = New System.Windows.Forms.ToolStripSplitButton()
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZebraDesigner2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bscaracteristica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bscustodio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsubicacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsdepreciaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsvaloracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bscomponentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bspoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsinventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlbusqueda.SuspendLayout()
        Me.pnldatosbusqueda.SuspendLayout()
        CType(Me.dgActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlmantenimiento.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(947, 645)
        Me.Panel1.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlbusqueda)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlmantenimiento)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 645)
        Me.SplitContainer1.SplitterDistance = 243
        Me.SplitContainer1.TabIndex = 10
        '
        'pnlbusqueda
        '
        Me.pnlbusqueda.Controls.Add(Me.pnldatosbusqueda)
        Me.pnlbusqueda.Controls.Add(Me.CtlBuscaActivos1)
        Me.pnlbusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlbusqueda.Location = New System.Drawing.Point(0, 0)
        Me.pnlbusqueda.Name = "pnlbusqueda"
        Me.pnlbusqueda.Size = New System.Drawing.Size(243, 645)
        Me.pnlbusqueda.TabIndex = 8
        '
        'pnldatosbusqueda
        '
        Me.pnldatosbusqueda.Controls.Add(Me.dgActivos)
        Me.pnldatosbusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnldatosbusqueda.Location = New System.Drawing.Point(0, 346)
        Me.pnldatosbusqueda.Name = "pnldatosbusqueda"
        Me.pnldatosbusqueda.Size = New System.Drawing.Size(243, 299)
        Me.pnldatosbusqueda.TabIndex = 2
        '
        'dgActivos
        '
        Me.dgActivos.AgruparRepetidos = False
        Me.dgActivos.AllowUserToAddRows = False
        Me.dgActivos.AllowUserToDeleteRows = False
        Me.dgActivos.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgActivos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgActivos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8})
        Me.dgActivos.DataSource = Me.BindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgActivos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgActivos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgActivos.Location = New System.Drawing.Point(0, 0)
        Me.dgActivos.Name = "dgActivos"
        Me.dgActivos.ReadOnly = True
        Me.dgActivos.RowHeadersVisible = False
        Me.dgActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgActivos.Size = New System.Drawing.Size(243, 299)
        Me.dgActivos.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'CtlBuscaActivos1
        '
        Me.CtlBuscaActivos1.BackColor = System.Drawing.SystemColors.Info
        Me.CtlBuscaActivos1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlBuscaActivos1.Location = New System.Drawing.Point(0, 0)
        Me.CtlBuscaActivos1.Name = "CtlBuscaActivos1"
        Me.CtlBuscaActivos1.OperadorDatos = Nothing
        Me.CtlBuscaActivos1.PuedeExportaryBarCode = False
        Me.CtlBuscaActivos1.Size = New System.Drawing.Size(243, 346)
        Me.CtlBuscaActivos1.TabIndex = 0
        '
        'pnlmantenimiento
        '
        Me.pnlmantenimiento.Controls.Add(Me.CtlActivo1)
        Me.pnlmantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlmantenimiento.Location = New System.Drawing.Point(0, 0)
        Me.pnlmantenimiento.Name = "pnlmantenimiento"
        Me.pnlmantenimiento.Size = New System.Drawing.Size(700, 645)
        Me.pnlmantenimiento.TabIndex = 9
        '
        'CtlActivo1
        '
        Me.CtlActivo1.Activo = Nothing
        Me.CtlActivo1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CtlActivo1.Location = New System.Drawing.Point(0, 0)
        Me.CtlActivo1.Name = "CtlActivo1"
        Me.CtlActivo1.Size = New System.Drawing.Size(700, 645)
        Me.CtlActivo1.TabIndex = 0
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
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.btncodigobarras})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(947, 25)
        Me.ToolStrip2.TabIndex = 7
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel1.Text = "0 registros"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btncodigobarras
        '
        Me.btncodigobarras.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigurarToolStripMenuItem, Me.TipoDeProgramaToolStripMenuItem})
        Me.btncodigobarras.Image = CType(resources.GetObject("btncodigobarras.Image"), System.Drawing.Image)
        Me.btncodigobarras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btncodigobarras.Name = "btncodigobarras"
        Me.btncodigobarras.Size = New System.Drawing.Size(178, 22)
        Me.btncodigobarras.Text = "Imprimir Código de barras"
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ConfigurarToolStripMenuItem.Text = "Configurar"
        '
        'TipoDeProgramaToolStripMenuItem
        '
        Me.TipoDeProgramaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZebraDesigner2ToolStripMenuItem})
        Me.TipoDeProgramaToolStripMenuItem.Name = "TipoDeProgramaToolStripMenuItem"
        Me.TipoDeProgramaToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.TipoDeProgramaToolStripMenuItem.Text = "Tipo de programa"
        '
        'ZebraDesigner2ToolStripMenuItem
        '
        Me.ZebraDesigner2ToolStripMenuItem.Checked = True
        Me.ZebraDesigner2ToolStripMenuItem.CheckOnClick = True
        Me.ZebraDesigner2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ZebraDesigner2ToolStripMenuItem.Name = "ZebraDesigner2ToolStripMenuItem"
        Me.ZebraDesigner2ToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ZebraDesigner2ToolStripMenuItem.Text = "Zebra Designer 2"
        '
        'FrmMantenimientoActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(947, 694)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMantenimientoActivo"
        Me.PuedeGuardarcerrar = True
        Me.PuedeGuardarnuevo = True
        Me.PuedeMover = True
        Me.PuedeNuevo = True
        Me.Text = "Activo"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bscaracteristica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bscustodio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsubicacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsdepreciaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsvaloracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bscomponentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bspoliza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsinventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlbusqueda.ResumeLayout(False)
        Me.pnldatosbusqueda.ResumeLayout(False)
        CType(Me.dgActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlmantenimiento.ResumeLayout(False)
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents pnlmantenimiento As System.Windows.Forms.Panel
  Friend WithEvents pnlbusqueda As System.Windows.Forms.Panel
  Friend WithEvents dgActivos As DataGridViewAutoDiscover
  Friend WithEvents CtlBuscaActivos1 As ActivosFijos.Modulo.CtlBuscaActivos
  Friend WithEvents bscaracteristica As System.Windows.Forms.BindingSource
  Friend WithEvents bscustodio As System.Windows.Forms.BindingSource
  Friend WithEvents bsubicacion As System.Windows.Forms.BindingSource
  Friend WithEvents bscomponentes As System.Windows.Forms.BindingSource
  Friend WithEvents bspoliza As System.Windows.Forms.BindingSource
  Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
  Friend WithEvents bsvaloracion As System.Windows.Forms.BindingSource
  Friend WithEvents bsinventarios As System.Windows.Forms.BindingSource
  Friend WithEvents bsdepreciaciones As System.Windows.Forms.BindingSource
  Friend WithEvents pnldatosbusqueda As System.Windows.Forms.Panel
  Friend WithEvents CtlActivo1 As ActivosFijos.Modulo.CtlActivo
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btncodigobarras As System.Windows.Forms.ToolStripSplitButton
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ConfigurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TipoDeProgramaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ZebraDesigner2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
