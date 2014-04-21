<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoPersona
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
    Me.CtlPersona1 = New CtlPersona
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'CtlPersona1
    '
    Me.CtlPersona1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlPersona1.Entidad = Nothing
    Me.CtlPersona1.Location = New System.Drawing.Point(0, 49)
    Me.CtlPersona1.Name = "CtlPersona1"
    Me.CtlPersona1.PuedeElegirTipoEntidad = True
    Me.CtlPersona1.PuedeSRI = False
    Me.CtlPersona1.Size = New System.Drawing.Size(563, 524)
    Me.CtlPersona1.TabIndex = 4
    '
    'FrmMantenimientoPersona
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    Me.ClientSize = New System.Drawing.Size(563, 573)
    Me.Controls.Add(Me.CtlPersona1)
    Me.Name = "FrmMantenimientoPersona"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.CtlPersona1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents CtlPersona1 As CtlPersona

End Class
