<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCopiarActivo
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
    Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Me.dgseries = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.bsseries = New System.Windows.Forms.BindingSource(Me.components)
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.dgseries, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.bsseries, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.dgseries)
    Me.pnlcuerpo.Controls.Add(Me.Label1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(547, 358)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Label1, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.dgseries, 0)
    '
    'dgseries
    '
    Me.dgseries.AgruparRepetidos = False
    Me.dgseries.AllowUserToAddRows = False
    Me.dgseries.AllowUserToDeleteRows = False
    Me.dgseries.AutoGenerateColumns = False
    DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgseries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
    Me.dgseries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgseries.DataSource = Me.bsseries
    DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.dgseries.DefaultCellStyle = DataGridViewCellStyle5
    Me.dgseries.Dock = System.Windows.Forms.DockStyle.Fill
    Me.dgseries.Location = New System.Drawing.Point(0, 64)
    Me.dgseries.Name = "dgseries"
    DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.dgseries.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
    Me.dgseries.RowHeadersVisible = False
    Me.dgseries.Size = New System.Drawing.Size(547, 294)
    Me.dgseries.TabIndex = 34
    '
    'DataGridViewTextBoxColumn68
    '
    Me.DataGridViewTextBoxColumn68.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
    '
    'Label1
    '
    Me.Label1.BackColor = System.Drawing.SystemColors.Info
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.ForeColor = System.Drawing.SystemColors.InfoText
    Me.Label1.Location = New System.Drawing.Point(0, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(547, 39)
    Me.Label1.TabIndex = 35
    Me.Label1.Text = "Copiar todos los datos del activo actual varias veces cambiando solamente el núme" & _
    "ro de serie del listado siguiente:"
    '
    'FrmCopiarActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(547, 407)
    Me.Name = "FrmCopiarActivo"
    Me.Text = "Copiar activo"
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.dgseries, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.bsseries, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents dgseries As Infoware.Consola.Base.DataGridViewAutoDiscover
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents bsseries As System.Windows.Forms.BindingSource
End Class
