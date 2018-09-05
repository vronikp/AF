<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGenerarAsientos
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.cboTipoAsiento = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtperiodo = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dgdepreciacion = New System.Windows.Forms.DataGridView()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsdepreciacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.btngenerarasiento = New System.Windows.Forms.Button()
    Me.btngenerartxt = New System.Windows.Forms.Button()
    Me.btnexportar = New System.Windows.Forms.Button()
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.btnimprimir = New System.Windows.Forms.Button()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
    Me.GroupBox2.Controls.Add(Me.cboTipoAsiento)
    Me.GroupBox2.Controls.Add(Me.Label2)
    Me.GroupBox2.Controls.Add(Me.dtperiodo)
    Me.GroupBox2.Controls.Add(Me.Label1)
    Me.GroupBox2.Controls.Add(Me.dgdepreciacion)
    Me.GroupBox2.Controls.Add(Me.btngenerarasiento)
    Me.GroupBox2.Controls.Add(Me.btngenerartxt)
    Me.GroupBox2.Controls.Add(Me.btnexportar)
    Me.GroupBox2.Controls.Add(Me.btnmostrar)
    Me.GroupBox2.Controls.Add(Me.btnimprimir)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(684, 472)
    Me.GroupBox2.TabIndex = 0
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Generar asientos"
    '
    'cboTipoAsiento
    '
    Me.cboTipoAsiento.AbriralEntrar = False
    Me.cboTipoAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTipoAsiento.FormattingEnabled = True
    Me.cboTipoAsiento.Items.AddRange(New Object() {"Baja", "Depreciación", "Transferencia"})
    Me.cboTipoAsiento.Location = New System.Drawing.Point(102, 44)
    Me.cboTipoAsiento.Margin = New System.Windows.Forms.Padding(2)
    Me.cboTipoAsiento.MostrarRutaCompleta = False
    Me.cboTipoAsiento.Name = "cboTipoAsiento"
    Me.cboTipoAsiento.OperadorDatos = Nothing
    Me.cboTipoAsiento.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboTipoAsiento.ParametroDet = Nothing
    Me.cboTipoAsiento.PuedeActualizar = True
    Me.cboTipoAsiento.PuedeEliminar = True
    Me.cboTipoAsiento.PuedeModificar = True
    Me.cboTipoAsiento.PuedeNuevo = True
    Me.cboTipoAsiento.Size = New System.Drawing.Size(130, 21)
    Me.cboTipoAsiento.TabIndex = 2
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(83, 13)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "Tipo de asiento:"
    '
    'dtperiodo
    '
    Me.dtperiodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
    Me.dtperiodo.Location = New System.Drawing.Point(102, 19)
    Me.dtperiodo.Name = "dtperiodo"
    Me.dtperiodo.Size = New System.Drawing.Size(130, 20)
    Me.dtperiodo.TabIndex = 1
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(6, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(46, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Periodo:"
    '
    'dgdepreciacion
    '
    Me.dgdepreciacion.AllowUserToAddRows = False
    Me.dgdepreciacion.AllowUserToDeleteRows = False
    Me.dgdepreciacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.dgdepreciacion.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdepreciacion.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgdepreciacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgdepreciacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn18})
    Me.dgdepreciacion.DataSource = Me.bsdepreciacion
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdepreciacion.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgdepreciacion.Location = New System.Drawing.Point(6, 99)
    Me.dgdepreciacion.Name = "dgdepreciacion"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgdepreciacion.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgdepreciacion.RowHeadersVisible = False
    Me.dgdepreciacion.Size = New System.Drawing.Size(672, 358)
    Me.dgdepreciacion.TabIndex = 12
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    '
    'btngenerarasiento
    '
    Me.btngenerarasiento.Location = New System.Drawing.Point(422, 70)
    Me.btngenerarasiento.Name = "btngenerarasiento"
    Me.btngenerarasiento.Size = New System.Drawing.Size(98, 23)
    Me.btngenerarasiento.TabIndex = 7
    Me.btngenerarasiento.Text = "Generar asiento"
    Me.btngenerarasiento.UseVisualStyleBackColor = True
    '
    'btngenerartxt
    '
    Me.btngenerartxt.Location = New System.Drawing.Point(318, 70)
    Me.btngenerartxt.Name = "btngenerartxt"
    Me.btngenerartxt.Size = New System.Drawing.Size(98, 23)
    Me.btngenerartxt.TabIndex = 6
    Me.btngenerartxt.Text = "Generar txt"
    Me.btngenerartxt.UseVisualStyleBackColor = True
    '
    'btnexportar
    '
    Me.btnexportar.Location = New System.Drawing.Point(214, 70)
    Me.btnexportar.Name = "btnexportar"
    Me.btnexportar.Size = New System.Drawing.Size(98, 23)
    Me.btnexportar.TabIndex = 5
    Me.btnexportar.Text = "Exportar"
    Me.btnexportar.UseVisualStyleBackColor = True
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(6, 70)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(98, 23)
    Me.btnmostrar.TabIndex = 3
    Me.btnmostrar.Text = "Mostrar"
    Me.btnmostrar.UseVisualStyleBackColor = True
    '
    'btnimprimir
    '
    Me.btnimprimir.Location = New System.Drawing.Point(110, 70)
    Me.btnimprimir.Name = "btnimprimir"
    Me.btnimprimir.Size = New System.Drawing.Size(98, 23)
    Me.btnimprimir.TabIndex = 4
    Me.btnimprimir.Text = "Imprimir"
    Me.btnimprimir.UseVisualStyleBackColor = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
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
    'FrmGenerarAsientos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(704, 566)
    Me.Name = "FrmGenerarAsientos"
    Me.Text = "Generar Asientos Contables"
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
  Friend WithEvents dgdepreciacion As DataGridView
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsdepreciacion As System.Windows.Forms.BindingSource
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents dtperiodo As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btnexportar As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents btngenerartxt As System.Windows.Forms.Button
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
  Friend WithEvents btngenerarasiento As Button
  Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
  Friend WithEvents cboTipoAsiento As ComboBoxParametroDet
  Friend WithEvents Label2 As Label
  Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
  Friend WithEvents btnmostrar As Button
  Friend WithEvents btnimprimir As Button
  Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
End Class
