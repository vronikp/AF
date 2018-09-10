<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoWS
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.txtIDSesion = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtClave = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtUsuario = New Infoware.Controles.Base.TextBoxStd()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtUrlWS = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.txtIDSesion)
    Me.Panel1.Controls.Add(Me.txtClave)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txtUsuario)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.txtUrlWS)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(521, 117)
    Me.Panel1.TabIndex = 0
    '
    'txtIDSesion
    '
    Me.txtIDSesion.BackColor = System.Drawing.SystemColors.Window
    Me.txtIDSesion.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtIDSesion.Location = New System.Drawing.Point(142, 89)
    Me.txtIDSesion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtIDSesion.Mensaje = ""
    Me.txtIDSesion.Name = "txtIDSesion"
    Me.txtIDSesion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtIDSesion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtIDSesion.PromptText = ""
    Me.txtIDSesion.Size = New System.Drawing.Size(200, 20)
    Me.txtIDSesion.TabIndex = 4
    Me.txtIDSesion.Text = "0"
    Me.txtIDSesion.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtIDSesion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.SoloNumeros
    Me.txtIDSesion.Value = 0R
    '
    'txtClave
    '
    Me.txtClave.Location = New System.Drawing.Point(142, 62)
    Me.txtClave.Margin = New System.Windows.Forms.Padding(2)
    Me.txtClave.Mensaje = ""
    Me.txtClave.Name = "txtClave"
    Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtClave.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtClave.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtClave.PromptText = ""
    Me.txtClave.Size = New System.Drawing.Size(200, 20)
    Me.txtClave.TabIndex = 3
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(15, 89)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(77, 13)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "No. de Sesión:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 65)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(64, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Contraseña:"
    '
    'txtUsuario
    '
    Me.txtUsuario.Location = New System.Drawing.Point(142, 38)
    Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2)
    Me.txtUsuario.Mensaje = ""
    Me.txtUsuario.Name = "txtUsuario"
    Me.txtUsuario.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUsuario.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUsuario.PromptText = ""
    Me.txtUsuario.Size = New System.Drawing.Size(200, 20)
    Me.txtUsuario.TabIndex = 2
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(15, 41)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(46, 13)
    Me.Label7.TabIndex = 4
    Me.Label7.Text = "Usuario:"
    '
    'txtUrlWS
    '
    Me.txtUrlWS.Location = New System.Drawing.Point(142, 14)
    Me.txtUrlWS.Margin = New System.Windows.Forms.Padding(2)
    Me.txtUrlWS.Mensaje = ""
    Me.txtUrlWS.Name = "txtUrlWS"
    Me.txtUrlWS.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtUrlWS.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtUrlWS.PromptText = ""
    Me.txtUrlWS.Size = New System.Drawing.Size(368, 20)
    Me.txtUrlWS.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(99, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "URL Servicio Web:"
    '
    'FrmMantenimientoWS
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(521, 166)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoWS"
    Me.Text = "Componente Activo"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtUrlWS As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtClave As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtUsuario As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtIDSesion As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
