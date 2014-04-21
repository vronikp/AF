<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepreciacion
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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.dtperiodo = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.dgdepreciacion = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsdepreciacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.btngenerartxt = New System.Windows.Forms.Button()
    Me.btnexportar = New System.Windows.Forms.Button()
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.btnimprimir = New System.Windows.Forms.Button()
    Me.btneliminar = New System.Windows.Forms.Button()
    Me.btngenerar = New System.Windows.Forms.Button()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.cbotipodepreciacion = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.cbofrecuenciadepreciacion = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.dgdepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsdepreciacion, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.Panel1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(704, 517)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 25)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(10)
    Me.Panel1.Size = New System.Drawing.Size(704, 492)
    Me.Panel1.TabIndex = 3
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.dtperiodo)
    Me.GroupBox2.Controls.Add(Me.cbotipodepreciacion)
    Me.GroupBox2.Controls.Add(Me.cbofrecuenciadepreciacion)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Controls.Add(Me.Label11)
    Me.GroupBox2.Controls.Add(Me.Label10)
    Me.GroupBox2.Controls.Add(Me.dgdepreciacion)
    Me.GroupBox2.Controls.Add(Me.btngenerartxt)
    Me.GroupBox2.Controls.Add(Me.btnexportar)
    Me.GroupBox2.Controls.Add(Me.btnmostrar)
    Me.GroupBox2.Controls.Add(Me.btnimprimir)
    Me.GroupBox2.Controls.Add(Me.btneliminar)
    Me.GroupBox2.Controls.Add(Me.btngenerar)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(684, 472)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Generar depreciación"
    '
    'dtperiodo
    '
    Me.dtperiodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtperiodo.Location = New System.Drawing.Point(170, 49)
    Me.dtperiodo.Name = "dtperiodo"
    Me.dtperiodo.Size = New System.Drawing.Size(235, 20)
    Me.dtperiodo.TabIndex = 3
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 52)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Periodo:"
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(6, 106)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(110, 13)
    Me.Label11.TabIndex = 8
    Me.Label11.Text = "Tipo de depreciación:"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(6, 26)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(127, 13)
    Me.Label10.TabIndex = 0
    Me.Label10.Text = "Frecuencia depreciación:"
    '
    'dgdepreciacion
    '
    Me.dgdepreciacion.AgruparRepetidos = False
    Me.dgdepreciacion.AllowUserToAddRows = False
    Me.dgdepreciacion.AllowUserToDeleteRows = False
    Me.dgdepreciacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgdepreciacion.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdepreciacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.dgdepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgdepreciacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13})
    Me.dgdepreciacion.DataSource = Me.bsdepreciacion
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdepreciacion.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgdepreciacion.Location = New System.Drawing.Point(6, 158)
    Me.dgdepreciacion.Name = "dgdepreciacion"
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdepreciacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.dgdepreciacion.RowHeadersVisible = False
    Me.dgdepreciacion.Size = New System.Drawing.Size(672, 299)
    Me.dgdepreciacion.TabIndex = 12
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    '
    'btngenerartxt
    '
    Me.btngenerartxt.Location = New System.Drawing.Point(533, 75)
    Me.btngenerartxt.Name = "btngenerartxt"
    Me.btngenerartxt.Size = New System.Drawing.Size(115, 23)
    Me.btngenerartxt.TabIndex = 7
    Me.btngenerartxt.Text = "Generar txt"
    Me.btngenerartxt.UseVisualStyleBackColor = True
    '
    'btnexportar
    '
    Me.btnexportar.Location = New System.Drawing.Point(412, 75)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(115, 23)
    Me.btnexportar.TabIndex = 6
    Me.btnexportar.Text = "Exportar"
    Me.btnexportar.UseVisualStyleBackColor = True
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(170, 129)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(115, 23)
    Me.btnmostrar.TabIndex = 10
    Me.btnmostrar.Text = "Mostrar"
    Me.btnmostrar.UseVisualStyleBackColor = True
    '
    'btnimprimir
    '
    Me.btnimprimir.Location = New System.Drawing.Point(291, 129)
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(115, 23)
    Me.btnimprimir.TabIndex = 11
    Me.btnimprimir.Text = "Imprimir"
    Me.btnimprimir.UseVisualStyleBackColor = True
    '
    'btneliminar
    '
    Me.btneliminar.Location = New System.Drawing.Point(291, 75)
    Me.btneliminar.Name = "btneliminar"
    Me.btneliminar.Size = New System.Drawing.Size(115, 23)
    Me.btneliminar.TabIndex = 5
    Me.btneliminar.Text = "Eliminar"
    Me.btneliminar.UseVisualStyleBackColor = True
    '
    'btngenerar
    '
    Me.btngenerar.Location = New System.Drawing.Point(170, 75)
    Me.btngenerar.Name = "btngenerar"
    Me.btngenerar.Size = New System.Drawing.Size(115, 23)
    Me.btngenerar.TabIndex = 4
    Me.btngenerar.Text = "Generar"
    Me.btngenerar.UseVisualStyleBackColor = True
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
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
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
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
    'cbotipodepreciacion
    '
    Me.cbotipodepreciacion.AbriralEntrar = False
    Me.cbotipodepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipodepreciacion.FormattingEnabled = True
    Me.cbotipodepreciacion.Location = New System.Drawing.Point(170, 103)
    Me.cbotipodepreciacion.Margin = New System.Windows.Forms.Padding(2)
    Me.cbotipodepreciacion.MostrarRutaCompleta = False
    Me.cbotipodepreciacion.Name = "cbotipodepreciacion"
    Me.cbotipodepreciacion.OperadorDatos = Nothing
    Me.cbotipodepreciacion.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipodepreciacion.ParametroDet = Nothing
    Me.cbotipodepreciacion.PuedeActualizar = True
    Me.cbotipodepreciacion.PuedeEliminar = True
    Me.cbotipodepreciacion.PuedeModificar = True
    Me.cbotipodepreciacion.PuedeNuevo = True
    Me.cbotipodepreciacion.Size = New System.Drawing.Size(235, 21)
    Me.cbotipodepreciacion.TabIndex = 9
    '
    'cbofrecuenciadepreciacion
    '
    Me.cbofrecuenciadepreciacion.AbriralEntrar = False
    Me.cbofrecuenciadepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbofrecuenciadepreciacion.FormattingEnabled = True
    Me.cbofrecuenciadepreciacion.Location = New System.Drawing.Point(170, 23)
    Me.cbofrecuenciadepreciacion.Margin = New System.Windows.Forms.Padding(2)
    Me.cbofrecuenciadepreciacion.MostrarRutaCompleta = False
    Me.cbofrecuenciadepreciacion.Name = "cbofrecuenciadepreciacion"
    Me.cbofrecuenciadepreciacion.OperadorDatos = Nothing
    Me.cbofrecuenciadepreciacion.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbofrecuenciadepreciacion.ParametroDet = Nothing
    Me.cbofrecuenciadepreciacion.PuedeActualizar = True
    Me.cbofrecuenciadepreciacion.PuedeEliminar = True
    Me.cbofrecuenciadepreciacion.PuedeModificar = True
    Me.cbofrecuenciadepreciacion.PuedeNuevo = True
    Me.cbofrecuenciadepreciacion.Size = New System.Drawing.Size(235, 21)
    Me.cbofrecuenciadepreciacion.TabIndex = 1
    '
    'FrmDepreciacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(704, 566)
    Me.Name = "FrmDepreciacion"
    Me.Text = "Depreciación"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox2.PerformLayout()
    CType(Me.dgdepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsdepreciacion, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents btngenerar As System.Windows.Forms.Button
  Friend WithEvents dgdepreciacion As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsdepreciacion As System.Windows.Forms.BindingSource
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtperiodo As System.Windows.Forms.DateTimePicker
  Friend WithEvents cbotipodepreciacion As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents cbofrecuenciadepreciacion As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnimprimir As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btngenerartxt As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
