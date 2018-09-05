Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlDireccion
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
    Me.Direcc_CalleprincipalTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.Direcc_CalleinterseccionTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.Direcc_NumeroTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.ComboBoxCiudad = New ComboBoxParametroDet()
    Me.ComboBoxTipoDireccion = New ComboBoxParametroDet()
    Me.SuspendLayout()
    '
    'Direcc_CalleprincipalTextBox
    '
    Me.Direcc_CalleprincipalTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Direcc_CalleprincipalTextBox.Location = New System.Drawing.Point(124, 0)
    Me.Direcc_CalleprincipalTextBox.Mensaje = ""
    Me.Direcc_CalleprincipalTextBox.Name = "Direcc_CalleprincipalTextBox"
    Me.Direcc_CalleprincipalTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Direcc_CalleprincipalTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Direcc_CalleprincipalTextBox.PromptText = "Calle principal"
    Me.Direcc_CalleprincipalTextBox.Size = New System.Drawing.Size(138, 20)
    Me.Direcc_CalleprincipalTextBox.TabIndex = 1
    Me.Direcc_CalleprincipalTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Direcc_CalleinterseccionTextBox
    '
    Me.Direcc_CalleinterseccionTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Direcc_CalleinterseccionTextBox.Location = New System.Drawing.Point(124, 23)
    Me.Direcc_CalleinterseccionTextBox.Mensaje = ""
    Me.Direcc_CalleinterseccionTextBox.Name = "Direcc_CalleinterseccionTextBox"
    Me.Direcc_CalleinterseccionTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Direcc_CalleinterseccionTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Direcc_CalleinterseccionTextBox.PromptText = "Calle intersección"
    Me.Direcc_CalleinterseccionTextBox.Size = New System.Drawing.Size(204, 20)
    Me.Direcc_CalleinterseccionTextBox.TabIndex = 3
    Me.Direcc_CalleinterseccionTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Direcc_NumeroTextBox
    '
    Me.Direcc_NumeroTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Direcc_NumeroTextBox.Location = New System.Drawing.Point(268, 0)
    Me.Direcc_NumeroTextBox.Mensaje = ""
    Me.Direcc_NumeroTextBox.Name = "Direcc_NumeroTextBox"
    Me.Direcc_NumeroTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Direcc_NumeroTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Direcc_NumeroTextBox.PromptText = "Número"
    Me.Direcc_NumeroTextBox.Size = New System.Drawing.Size(60, 20)
    Me.Direcc_NumeroTextBox.TabIndex = 2
    Me.Direcc_NumeroTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'ComboBoxCiudad
    '
    Me.ComboBoxCiudad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxCiudad.FormattingEnabled = True
    Me.ComboBoxCiudad.Location = New System.Drawing.Point(124, 46)
    Me.ComboBoxCiudad.Name = "ComboBoxCiudad"
    Me.ComboBoxCiudad.OperadorDatos = Nothing
    Me.ComboBoxCiudad.Parametro = Enumerados.EnumParametros.Ciudad
    Me.ComboBoxCiudad.ParametroDet = Nothing
    Me.ComboBoxCiudad.PuedeActualizar = True
    Me.ComboBoxCiudad.PuedeEliminar = True
    Me.ComboBoxCiudad.PuedeModificar = True
    Me.ComboBoxCiudad.PuedeNuevo = True
    Me.ComboBoxCiudad.Size = New System.Drawing.Size(165, 21)
    Me.ComboBoxCiudad.TabIndex = 4
    '
    'ComboBoxTipoDireccion
    '
    Me.ComboBoxTipoDireccion.BackColor = System.Drawing.SystemColors.Control
    Me.ComboBoxTipoDireccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoDireccion.FormattingEnabled = True
    Me.ComboBoxTipoDireccion.Location = New System.Drawing.Point(0, 0)
    Me.ComboBoxTipoDireccion.Name = "ComboBoxTipoDireccion"
    Me.ComboBoxTipoDireccion.OperadorDatos = Nothing
    Me.ComboBoxTipoDireccion.Parametro = Enumerados.EnumParametros.TipoDireccion
    Me.ComboBoxTipoDireccion.ParametroDet = Nothing
    Me.ComboBoxTipoDireccion.PuedeActualizar = True
    Me.ComboBoxTipoDireccion.PuedeEliminar = True
    Me.ComboBoxTipoDireccion.PuedeModificar = True
    Me.ComboBoxTipoDireccion.PuedeNuevo = True
    Me.ComboBoxTipoDireccion.Size = New System.Drawing.Size(118, 21)
    Me.ComboBoxTipoDireccion.TabIndex = 0
    '
    'CtlDireccion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.ComboBoxCiudad)
    Me.Controls.Add(Me.ComboBoxTipoDireccion)
    Me.Controls.Add(Me.Direcc_NumeroTextBox)
    Me.Controls.Add(Me.Direcc_CalleinterseccionTextBox)
    Me.Controls.Add(Me.Direcc_CalleprincipalTextBox)
    Me.Name = "CtlDireccion"
    Me.Size = New System.Drawing.Size(328, 69)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Direcc_CalleprincipalTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Direcc_CalleinterseccionTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Direcc_NumeroTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ComboBoxTipoDireccion As ComboBoxParametroDet
  Friend WithEvents ComboBoxCiudad As ComboBoxParametroDet

End Class
