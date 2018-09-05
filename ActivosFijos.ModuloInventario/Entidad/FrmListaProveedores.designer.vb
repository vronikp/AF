<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaProveedores
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage()
    Me.chkSoloActivos = New System.Windows.Forms.CheckBox()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.btnmostrar)
    Me.pnlcuerpo.Size = New System.Drawing.Size(611, 433)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.btnmostrar, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkSoloActivos)
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(611, 29)
    Me.Panel1.Visible = True
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(82, 93)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(5, 4)
    Me.btnmostrar.TabIndex = 7
    Me.btnmostrar.Text = "Button1"
    Me.btnmostrar.UseVisualStyleBackColor = True
    Me.btnmostrar.Visible = False
    '
    'chkSoloActivos
    '
    Me.chkSoloActivos.AutoSize = True
    Me.chkSoloActivos.Checked = True
    Me.chkSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkSoloActivos.Location = New System.Drawing.Point(8, 6)
    Me.chkSoloActivos.Name = "chkSoloActivos"
    Me.chkSoloActivos.Size = New System.Drawing.Size(85, 17)
    Me.chkSoloActivos.TabIndex = 0
    Me.chkSoloActivos.Text = "Solo Activos"
    Me.chkSoloActivos.UseVisualStyleBackColor = True
    '
    'FrmListaProveedores
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(611, 482)
    Me.Name = "FrmListaProveedores"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "Lista de proveedores"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents ToolTipImage1 As Infoware.Controles.Base.ToolTipImage
  Friend WithEvents chkSoloActivos As System.Windows.Forms.CheckBox

End Class
