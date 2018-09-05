<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaParametroDets
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
    Me.components = New System.ComponentModel.Container
    Me.ComboBoxParametro1 = New ComboBoxParametro
    Me.Label1 = New System.Windows.Forms.Label
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(661, 443)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.ComboBoxParametro1)
    Me.Panel1.Size = New System.Drawing.Size(661, 48)
    '
    'ComboBoxParametro1
    '
    Me.ComboBoxParametro1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametro1.Location = New System.Drawing.Point(91, 13)
    Me.ComboBoxParametro1.Name = "ComboBoxParametro1"
    Me.ComboBoxParametro1.Op = Nothing
    Me.ComboBoxParametro1.Parametro = Nothing
    Me.ComboBoxParametro1.PuedeActualizar = True
    Me.ComboBoxParametro1.PuedeEliminar = True
    Me.ComboBoxParametro1.PuedeModificar = True
    Me.ComboBoxParametro1.PuedeNuevo = True
    Me.ComboBoxParametro1.Size = New System.Drawing.Size(174, 21)
    Me.ComboBoxParametro1.TabIndex = 0
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(58, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "Parametro:"
    '
    'FrmListaParametroDets
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(661, 492)
    Me.Name = "FrmListaParametroDets"
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
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxParametro1 As ComboBoxParametro

End Class
