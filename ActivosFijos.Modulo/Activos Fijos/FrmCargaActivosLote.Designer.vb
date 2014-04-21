<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaActivosLote
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

    'Form overrides dispose to clean up the component list.
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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
    Me.btnGenerarPlantillaact = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.lbl_registro = New System.Windows.Forms.Label()
    Me.dgcargaract = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bscargaract = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btncargarplantillaact = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.pnlinventario = New System.Windows.Forms.Panel()
    Me.cboInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.cboPeriodoInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.ComboBox1 = New System.Windows.Forms.ComboBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.pnlcuerpo.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.dgcargaract, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bscargaract, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel2.SuspendLayout()
    Me.pnlinventario.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.Panel1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(647, 517)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.ProgressBar1)
    Me.GroupBox1.Controls.Add(Me.btnGenerarPlantillaact)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(478, 80)
    Me.GroupBox1.TabIndex = 2
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Generación de plantilla"
    '
    'ProgressBar1
    '
    Me.ProgressBar1.Location = New System.Drawing.Point(170, 42)
    Me.ProgressBar1.Name = "ProgressBar1"
    Me.ProgressBar1.Size = New System.Drawing.Size(242, 23)
    Me.ProgressBar1.TabIndex = 2
    '
    'btnGenerarPlantillaact
    '
    Me.btnGenerarPlantillaact.Location = New System.Drawing.Point(6, 42)
    Me.btnGenerarPlantillaact.Name = "btnGenerarPlantillaact"
    Me.btnGenerarPlantillaact.Size = New System.Drawing.Size(158, 23)
    Me.btnGenerarPlantillaact.TabIndex = 1
    Me.btnGenerarPlantillaact.Text = "Generar plantilla"
    Me.btnGenerarPlantillaact.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Info
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label1.Location = New System.Drawing.Point(3, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(472, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Dé clic en Generar plantilla para que se genere una hoja de Microsoft Excel para " & _
    "el ingreso de la carga inicial de activos"
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.TabControl1)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(647, 492)
    Me.Panel1.TabIndex = 3
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(155, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(492, 492)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.GroupBox2)
    Me.TabPage1.Controls.Add(Me.GroupBox1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(484, 466)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Cargar lote"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.lbl_registro)
    Me.GroupBox2.Controls.Add(Me.dgcargaract)
    Me.GroupBox2.Controls.Add(Me.btncargarplantillaact)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(3, 83)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(478, 380)
    Me.GroupBox2.TabIndex = 3
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Cargar plantilla"
    '
    'lbl_registro
    '
    Me.lbl_registro.AutoSize = True
    Me.lbl_registro.Location = New System.Drawing.Point(180, 47)
    Me.lbl_registro.Name = "lbl_registro"
    Me.lbl_registro.Size = New System.Drawing.Size(10, 13)
    Me.lbl_registro.TabIndex = 35
    Me.lbl_registro.Text = "."
    '
    'dgcargaract
    '
    Me.dgcargaract.AgruparRepetidos = False
    Me.dgcargaract.AllowUserToAddRows = False
    Me.dgcargaract.AllowUserToDeleteRows = False
    Me.dgcargaract.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgcargaract.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargaract.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgcargaract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgcargaract.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
    Me.dgcargaract.DataSource = Me.bscargaract
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgcargaract.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgcargaract.Location = New System.Drawing.Point(6, 71)
    Me.dgcargaract.Name = "dgcargaract"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgcargaract.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgcargaract.RowHeadersVisible = False
    Me.dgcargaract.Size = New System.Drawing.Size(466, 294)
    Me.dgcargaract.TabIndex = 34
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    '
    'btncargarplantillaact
    '
    Me.btncargarplantillaact.Location = New System.Drawing.Point(6, 42)
    Me.btncargarplantillaact.Name = "btncargarplantillaact"
    Me.btncargarplantillaact.Size = New System.Drawing.Size(158, 23)
    Me.btncargarplantillaact.TabIndex = 1
    Me.btncargarplantillaact.Text = "Cargar plantilla"
    Me.btncargarplantillaact.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.BackColor = System.Drawing.SystemColors.Info
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label2.Location = New System.Drawing.Point(3, 16)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(472, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Dé clic en Cargar plantilla para comenzar el proceso de lectura de la hoja de Mic" & _
    "rosoft Excel con los datos iniciales"
    '
    'Panel2
    '
    Me.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
    Me.Panel2.Controls.Add(Me.pnlinventario)
    Me.Panel2.Controls.Add(Me.ComboBox1)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel2.Location = New System.Drawing.Point(0, 0)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
    Me.Panel2.Size = New System.Drawing.Size(155, 492)
    Me.Panel2.TabIndex = 4
    '
    'pnlinventario
    '
    Me.pnlinventario.Controls.Add(Me.cboInventario)
    Me.pnlinventario.Controls.Add(Me.Label4)
    Me.pnlinventario.Controls.Add(Me.cboPeriodoInventario)
    Me.pnlinventario.Controls.Add(Me.Label5)
    Me.pnlinventario.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlinventario.Location = New System.Drawing.Point(5, 39)
    Me.pnlinventario.Name = "pnlinventario"
    Me.pnlinventario.Size = New System.Drawing.Size(145, 77)
    Me.pnlinventario.TabIndex = 12
    Me.pnlinventario.Visible = False
    '
    'cboInventario
    '
    Me.cboInventario.AbriralEntrar = False
    Me.cboInventario.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboInventario.FormattingEnabled = True
    Me.cboInventario.Location = New System.Drawing.Point(0, 47)
    Me.cboInventario.Margin = New System.Windows.Forms.Padding(2)
    Me.cboInventario.MostrarRutaCompleta = False
    Me.cboInventario.Name = "cboInventario"
    Me.cboInventario.OperadorDatos = Nothing
    Me.cboInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboInventario.ParametroDet = Nothing
    Me.cboInventario.PuedeActualizar = True
    Me.cboInventario.PuedeEliminar = True
    Me.cboInventario.PuedeModificar = True
    Me.cboInventario.PuedeNuevo = True
    Me.cboInventario.Size = New System.Drawing.Size(145, 21)
    Me.cboInventario.TabIndex = 11
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label4.Location = New System.Drawing.Point(0, 34)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(57, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Inventario:"
    '
    'cboPeriodoInventario
    '
    Me.cboPeriodoInventario.AbriralEntrar = False
    Me.cboPeriodoInventario.Dock = System.Windows.Forms.DockStyle.Top
    Me.cboPeriodoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodoInventario.FormattingEnabled = True
    Me.cboPeriodoInventario.Location = New System.Drawing.Point(0, 13)
    Me.cboPeriodoInventario.Margin = New System.Windows.Forms.Padding(2)
    Me.cboPeriodoInventario.MostrarRutaCompleta = False
    Me.cboPeriodoInventario.Name = "cboPeriodoInventario"
    Me.cboPeriodoInventario.OperadorDatos = Nothing
    Me.cboPeriodoInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboPeriodoInventario.ParametroDet = Nothing
    Me.cboPeriodoInventario.PuedeActualizar = True
    Me.cboPeriodoInventario.PuedeEliminar = True
    Me.cboPeriodoInventario.PuedeModificar = True
    Me.cboPeriodoInventario.PuedeNuevo = True
    Me.cboPeriodoInventario.Size = New System.Drawing.Size(145, 21)
    Me.cboPeriodoInventario.TabIndex = 9
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label5.Location = New System.Drawing.Point(0, 0)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(95, 13)
    Me.Label5.TabIndex = 8
    Me.Label5.Text = "Periodo inventario:"
    '
    'ComboBox1
    '
    Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBox1.FormattingEnabled = True
    Me.ComboBox1.Location = New System.Drawing.Point(5, 18)
    Me.ComboBox1.Name = "ComboBox1"
    Me.ComboBox1.Size = New System.Drawing.Size(145, 21)
    Me.ComboBox1.TabIndex = 0
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label3.Location = New System.Drawing.Point(5, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(66, 13)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "Tipo de lote:"
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn44
    '
    Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'FrmCargaActivosLote
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(647, 566)
    Me.Name = "FrmCargaActivosLote"
    Me.Text = "Carga en lote"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.dgcargaract, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bscargaract, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlinventario.ResumeLayout(False)
    Me.pnlinventario.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents btnGenerarPlantillaact As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btncargarplantillaact As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dgcargaract As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bscargaract As System.Windows.Forms.BindingSource
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents lbl_registro As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents cboInventario As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents cboPeriodoInventario As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents pnlinventario As System.Windows.Forms.Panel
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
