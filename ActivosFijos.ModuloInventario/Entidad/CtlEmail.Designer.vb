Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmail
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
    Me.Entdat_DescripcionTextBox = New Infoware.Controles.Base.TextBoxStd
    Me.ComboBoxTipoEmail = New ComboBoxParametroDet
    Me.SuspendLayout()
    '
    'ToolTip1
    '
    Me.ToolTip1.IsBalloon = True
    '
    'Entdat_DescripcionTextBox
    '
    Me.Entdat_DescripcionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entdat_DescripcionTextBox.Location = New System.Drawing.Point(124, 0)
    Me.Entdat_DescripcionTextBox.Mensaje = ""
    Me.Entdat_DescripcionTextBox.Name = "Entdat_DescripcionTextBox"
    Me.Entdat_DescripcionTextBox.Size = New System.Drawing.Size(221, 20)
    Me.Entdat_DescripcionTextBox.TabIndex = 1
    Me.Entdat_DescripcionTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'ComboBoxTipoEmail
    '
    Me.ComboBoxTipoEmail.BackColor = System.Drawing.SystemColors.Control
    Me.ComboBoxTipoEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoEmail.FormattingEnabled = True
    Me.ComboBoxTipoEmail.Location = New System.Drawing.Point(0, 0)
    Me.ComboBoxTipoEmail.Name = "ComboBoxTipoEmail"
    Me.ComboBoxTipoEmail.OperadorDatos = Nothing
    Me.ComboBoxTipoEmail.Parametro = Enumerados.EnumParametros.TipoEmail
    Me.ComboBoxTipoEmail.ParametroDet = Nothing
    Me.ComboBoxTipoEmail.PuedeActualizar = True
    Me.ComboBoxTipoEmail.PuedeEliminar = True
    Me.ComboBoxTipoEmail.PuedeModificar = True
    Me.ComboBoxTipoEmail.PuedeNuevo = True
    Me.ComboBoxTipoEmail.Size = New System.Drawing.Size(118, 21)
    Me.ComboBoxTipoEmail.TabIndex = 0
    '
    'CtlEmail
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ComboBoxTipoEmail)
    Me.Controls.Add(Me.Entdat_DescripcionTextBox)
    Me.Name = "CtlEmail"
    Me.Size = New System.Drawing.Size(345, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents Entdat_DescripcionTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ComboBoxTipoEmail As ComboBoxParametroDet

End Class
