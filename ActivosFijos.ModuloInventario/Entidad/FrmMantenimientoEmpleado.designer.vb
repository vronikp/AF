<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoEmpleado
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
    Me.CtlEmpleado1 = New CtlEmpleado()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'CtlEmpleado1
    '
    Me.CtlEmpleado1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEmpleado1.Empleado = Nothing
    Me.CtlEmpleado1.Location = New System.Drawing.Point(0, 49)
    Me.CtlEmpleado1.Name = "CtlEmpleado1"
    Me.CtlEmpleado1.OperadorDatos = Nothing
    Me.CtlEmpleado1.Size = New System.Drawing.Size(650, 514)
    Me.CtlEmpleado1.TabIndex = 4
    '
    'FrmMantenimientoEmpleado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(650, 563)
    Me.Controls.Add(Me.CtlEmpleado1)
    Me.Name = "FrmMantenimientoEmpleado"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Controls.SetChildIndex(Me.CtlEmpleado1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlEmpleado1 As CtlEmpleado

End Class
