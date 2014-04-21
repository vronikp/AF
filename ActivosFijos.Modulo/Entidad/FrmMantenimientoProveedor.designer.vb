<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoProveedor
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
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.CtlPersona1 = New ActivosFijos.Modulo.CtlPersona()
    Me.chkVisible = New System.Windows.Forms.CheckBox()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 49)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(650, 514)
    Me.TabControl1.TabIndex = 5
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlPersona1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(642, 488)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos principales"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.chkVisible)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(642, 488)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Adicionales"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'CtlPersona1
    '
    Me.CtlPersona1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPersona1.Entidad = Nothing
    Me.CtlPersona1.Location = New System.Drawing.Point(3, 3)
    Me.CtlPersona1.Name = "CtlPersona1"
    Me.CtlPersona1.PuedeElegirTipoEntidad = False
    Me.CtlPersona1.PuedeRegistrarPersonacomo = False
    Me.CtlPersona1.PuedeSRI = True
    Me.CtlPersona1.Size = New System.Drawing.Size(636, 482)
    Me.CtlPersona1.TabIndex = 0
    '
    'chkVisible
    '
    Me.chkVisible.AutoSize = True
    Me.chkVisible.Checked = True
    Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkVisible.Location = New System.Drawing.Point(6, 6)
    Me.chkVisible.Name = "chkVisible"
    Me.chkVisible.Size = New System.Drawing.Size(56, 17)
    Me.chkVisible.TabIndex = 0
    Me.chkVisible.Text = "Visible"
    Me.chkVisible.UseVisualStyleBackColor = True
    '
    'FrmMantenimientoProveedor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(650, 563)
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "FrmMantenimientoProveedor"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Proveedor"
    Me.Controls.SetChildIndex(Me.TabControl1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlPersona1 As CtlPersona
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents chkVisible As System.Windows.Forms.CheckBox

End Class
