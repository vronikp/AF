<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoBajaActivo
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
    Me.dgdets = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.bsdets = New System.Windows.Forms.BindingSource(Me.components)
    Me.dtfecbaja = New System.Windows.Forms.DateTimePicker()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.cbotipobaja = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.cbotipobaja)
    Me.pnlcuerpo.Controls.Add(Me.Label8)
    Me.pnlcuerpo.Controls.Add(Me.dtfecbaja)
    Me.pnlcuerpo.Controls.Add(Me.Label13)
    Me.pnlcuerpo.Controls.Add(Me.dgdets)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.dgdets, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Label13, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.dtfecbaja, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Label8, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.cbotipobaja, 0)
    '
    'dgdets
    '
    Me.dgdets.AgruparRepetidos = False
    Me.dgdets.AllowUserToAddRows = False
    Me.dgdets.AllowUserToDeleteRows = False
    Me.dgdets.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
    Me.dgdets.DataSource = Me.bsdets
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgdets.DefaultCellStyle = DataGridViewCellStyle2
    Me.dgdets.Location = New System.Drawing.Point(12, 107)
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
    Me.dgdets.Size = New System.Drawing.Size(568, 398)
    Me.dgdets.TabIndex = 2
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'dtfecbaja
    '
    Me.dtfecbaja.Location = New System.Drawing.Point(138, 44)
    Me.dtfecbaja.Name = "dtfecbaja"
    Me.dtfecbaja.Size = New System.Drawing.Size(200, 20)
    Me.dtfecbaja.TabIndex = 6
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(12, 48)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(78, 13)
    Me.Label13.TabIndex = 5
    Me.Label13.Text = "Fecha de baja:"
    '
    'cbotipobaja
    '
    Me.cbotipobaja.AbriralEntrar = False
    Me.cbotipobaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipobaja.FormattingEnabled = True
    Me.cbotipobaja.Location = New System.Drawing.Point(138, 69)
    Me.cbotipobaja.Margin = New System.Windows.Forms.Padding(2)
    Me.cbotipobaja.MostrarRutaCompleta = False
    Me.cbotipobaja.Name = "cbotipobaja"
    Me.cbotipobaja.OperadorDatos = Nothing
    Me.cbotipobaja.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipobaja.ParametroDet = Nothing
    Me.cbotipobaja.PuedeActualizar = True
    Me.cbotipobaja.PuedeEliminar = True
    Me.cbotipobaja.PuedeModificar = True
    Me.cbotipobaja.PuedeNuevo = True
    Me.cbotipobaja.Size = New System.Drawing.Size(200, 21)
    Me.cbotipobaja.TabIndex = 8
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(12, 72)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(69, 13)
    Me.Label8.TabIndex = 7
    Me.Label8.Text = "Tipo de baja:"
    '
    'FrmMantenimientoBajaActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(592, 566)
    Me.Name = "FrmMantenimientoBajaActivo"
    Me.Text = "Baja Activo"
    Me.pnlcuerpo.ResumeLayout(False)
    Me.pnlcuerpo.PerformLayout()
    CType(Me.dgdets, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsdets, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgdets As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents bsdets As System.Windows.Forms.BindingSource
  Friend WithEvents dtfecbaja As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cbotipobaja As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
