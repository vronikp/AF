Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlIdentificacion
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
    Me.ComboBoxTipoIdentificacion = New ComboBoxParametroDet
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
    'ComboBoxTipoIdentificacion
    '
    Me.ComboBoxTipoIdentificacion.BackColor = System.Drawing.SystemColors.Control
    Me.ComboBoxTipoIdentificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoIdentificacion.FormattingEnabled = True
    Me.ComboBoxTipoIdentificacion.Location = New System.Drawing.Point(0, 0)
    Me.ComboBoxTipoIdentificacion.Name = "ComboBoxTipoIdentificacion"
    Me.ComboBoxTipoIdentificacion.OperadorDatos = Nothing
    Me.ComboBoxTipoIdentificacion.Parametro = Enumerados.EnumParametros.TipoIdentificacion
    Me.ComboBoxTipoIdentificacion.ParametroDet = Nothing
    Me.ComboBoxTipoIdentificacion.PuedeActualizar = True
    Me.ComboBoxTipoIdentificacion.PuedeEliminar = True
    Me.ComboBoxTipoIdentificacion.PuedeModificar = True
    Me.ComboBoxTipoIdentificacion.PuedeNuevo = True
    Me.ComboBoxTipoIdentificacion.Size = New System.Drawing.Size(118, 21)
    Me.ComboBoxTipoIdentificacion.TabIndex = 0
    '
    'CtlIdentificacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ComboBoxTipoIdentificacion)
    Me.Controls.Add(Me.Entdat_DescripcionTextBox)
    Me.Name = "CtlIdentificacion"
    Me.Size = New System.Drawing.Size(345, 22)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
  Friend WithEvents Entdat_DescripcionTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ComboBoxTipoIdentificacion As ComboBoxParametroDet

End Class
