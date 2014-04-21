<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaEmpleados
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
    Me.chkSoloActivos = New System.Windows.Forms.CheckBox()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(461, 247)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.chkSoloActivos)
    Me.Panel1.Size = New System.Drawing.Size(461, 31)
    Me.Panel1.Visible = True
    '
    'chkSoloActivos
    '
    Me.chkSoloActivos.AutoSize = True
    Me.chkSoloActivos.Checked = True
    Me.chkSoloActivos.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkSoloActivos.Location = New System.Drawing.Point(12, 7)
    Me.chkSoloActivos.Name = "chkSoloActivos"
    Me.chkSoloActivos.Size = New System.Drawing.Size(85, 17)
    Me.chkSoloActivos.TabIndex = 1
    Me.chkSoloActivos.Text = "Solo Activos"
    Me.chkSoloActivos.UseVisualStyleBackColor = True
    '
    'FrmListaEmpleados
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(461, 296)
    Me.Name = "FrmListaEmpleados"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents chkSoloActivos As System.Windows.Forms.CheckBox

End Class
