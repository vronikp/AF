Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEntidadLugar
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
    Dim Entnat_ApellidopaternoLabel As System.Windows.Forms.Label
    Me.EntidadLugarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.Entlug_Descripcion = New Infoware.Controles.Base.TextBoxStd
    Me.grpsri = New Infoware.Controles.Base.TaskBoxStd
    Me.mskcaducret = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.mskcaducnotvta = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.mskcaducfactura = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtautoret = New Infoware.Controles.Base.TextBoxStd
    Me.txtautonotvta = New Infoware.Controles.Base.TextBoxStd
    Me.txtautofactura = New Infoware.Controles.Base.TextBoxStd
    Me.grp_identificacion = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlIdentificacion1 = New CtlIdentificacion
    Me.GroupBox3 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlEmail2 = New CtlEmail
    Me.CtlEmail1 = New CtlEmail
    Me.GroupBox2 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlTelefono2 = New CtlTelefono
    Me.CtlTelefono1 = New CtlTelefono
    Me.GroupBox1 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlDireccion1 = New CtlDireccion
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.pnlcuerpo = New System.Windows.Forms.FlowLayoutPanel
    Entnat_ApellidopaternoLabel = New System.Windows.Forms.Label
    CType(Me.EntidadLugarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpsri.SuspendLayout()
    Me.grp_identificacion.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.pnlcuerpo.SuspendLayout()
    Me.SuspendLayout()
    '
    'Entnat_ApellidopaternoLabel
    '
    Entnat_ApellidopaternoLabel.AutoSize = True
    Entnat_ApellidopaternoLabel.Location = New System.Drawing.Point(6, 9)
    Entnat_ApellidopaternoLabel.Name = "Entnat_ApellidopaternoLabel"
    Entnat_ApellidopaternoLabel.Size = New System.Drawing.Size(66, 13)
    Entnat_ApellidopaternoLabel.TabIndex = 0
    Entnat_ApellidopaternoLabel.Text = "Descripción:"
    '
    'EntidadLugarBindingSource
    '
    Me.EntidadLugarBindingSource.DataSource = GetType(EntidadLugar)
    '
    'Entlug_Descripcion
    '
    Me.Entlug_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entlug_Descripcion.Location = New System.Drawing.Point(129, 6)
    Me.Entlug_Descripcion.Mensaje = ""
    Me.Entlug_Descripcion.Name = "Entlug_Descripcion"
    Me.Entlug_Descripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entlug_Descripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Entlug_Descripcion.PromptText = ""
    Me.Entlug_Descripcion.Size = New System.Drawing.Size(169, 20)
    Me.Entlug_Descripcion.TabIndex = 1
    Me.Entlug_Descripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'grpsri
    '
    Me.grpsri.BackColor = System.Drawing.Color.Transparent
    Me.grpsri.Controls.Add(Me.mskcaducret)
    Me.grpsri.Controls.Add(Me.mskcaducnotvta)
    Me.grpsri.Controls.Add(Me.mskcaducfactura)
    Me.grpsri.Controls.Add(Me.Label3)
    Me.grpsri.Controls.Add(Me.Label6)
    Me.grpsri.Controls.Add(Me.Label2)
    Me.grpsri.Controls.Add(Me.Label5)
    Me.grpsri.Controls.Add(Me.Label4)
    Me.grpsri.Controls.Add(Me.Label7)
    Me.grpsri.Controls.Add(Me.txtautoret)
    Me.grpsri.Controls.Add(Me.txtautonotvta)
    Me.grpsri.Controls.Add(Me.txtautofactura)
    Me.grpsri.HeaderText = "Datos del SRI"
    Me.grpsri.IsModoMini = True
    Me.grpsri.Location = New System.Drawing.Point(312, 98)
    Me.grpsri.Name = "grpsri"
    Me.grpsri.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.grpsri.Size = New System.Drawing.Size(303, 193)
    Me.grpsri.TabIndex = 6
    Me.grpsri.TabStop = False
    Me.grpsri.Visible = False
    '
    'mskcaducret
    '
    Me.mskcaducret.Location = New System.Drawing.Point(165, 165)
    Me.mskcaducret.Mask = "00/0000"
    Me.mskcaducret.Name = "mskcaducret"
    Me.mskcaducret.Size = New System.Drawing.Size(102, 20)
    Me.mskcaducret.TabIndex = 11
    '
    'mskcaducnotvta
    '
    Me.mskcaducnotvta.Location = New System.Drawing.Point(165, 113)
    Me.mskcaducnotvta.Mask = "00/0000"
    Me.mskcaducnotvta.Name = "mskcaducnotvta"
    Me.mskcaducnotvta.Size = New System.Drawing.Size(102, 20)
    Me.mskcaducnotvta.TabIndex = 7
    '
    'mskcaducfactura
    '
    Me.mskcaducfactura.Location = New System.Drawing.Point(165, 61)
    Me.mskcaducfactura.Mask = "00/0000"
    Me.mskcaducfactura.Name = "mskcaducfactura"
    Me.mskcaducfactura.Size = New System.Drawing.Size(102, 20)
    Me.mskcaducfactura.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(7, 142)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(131, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Autorización Retenciones:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(7, 168)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(62, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Caduca en:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 90)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(140, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Autorización Nota de Venta:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(7, 116)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(62, 13)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Caduca en:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(7, 64)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(62, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Caduca en:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(7, 38)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(112, 13)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Autorización Facturas:"
    '
    'txtautoret
    '
    Me.txtautoret.Location = New System.Drawing.Point(165, 139)
    Me.txtautoret.Mensaje = ""
    Me.txtautoret.Name = "txtautoret"
    Me.txtautoret.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautoret.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautoret.PromptText = ""
    Me.txtautoret.Size = New System.Drawing.Size(102, 20)
    Me.txtautoret.TabIndex = 9
    Me.txtautoret.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtautonotvta
    '
    Me.txtautonotvta.Location = New System.Drawing.Point(165, 87)
    Me.txtautonotvta.Mensaje = ""
    Me.txtautonotvta.Name = "txtautonotvta"
    Me.txtautonotvta.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautonotvta.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautonotvta.PromptText = ""
    Me.txtautonotvta.Size = New System.Drawing.Size(102, 20)
    Me.txtautonotvta.TabIndex = 5
    Me.txtautonotvta.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtautofactura
    '
    Me.txtautofactura.Location = New System.Drawing.Point(165, 35)
    Me.txtautofactura.Mensaje = ""
    Me.txtautofactura.Name = "txtautofactura"
    Me.txtautofactura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautofactura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautofactura.PromptText = ""
    Me.txtautofactura.Size = New System.Drawing.Size(102, 20)
    Me.txtautofactura.TabIndex = 1
    Me.txtautofactura.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'grp_identificacion
    '
    Me.grp_identificacion.BackColor = System.Drawing.Color.Transparent
    Me.grp_identificacion.Controls.Add(Me.CtlIdentificacion1)
    Me.grp_identificacion.HeaderText = "Identificación"
    Me.grp_identificacion.IsModoMini = True
    Me.grp_identificacion.Location = New System.Drawing.Point(3, 250)
    Me.grp_identificacion.Name = "grp_identificacion"
    Me.grp_identificacion.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.grp_identificacion.Size = New System.Drawing.Size(303, 61)
    Me.grp_identificacion.TabIndex = 1
    Me.grp_identificacion.TabStop = False
    '
    'CtlIdentificacion1
    '
    Me.CtlIdentificacion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion1.Entidad = Nothing
    Me.CtlIdentificacion1.EntidadRepetido = Nothing
    Me.CtlIdentificacion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlIdentificacion1.Name = "CtlIdentificacion1"
    Me.CtlIdentificacion1.Size = New System.Drawing.Size(295, 28)
    Me.CtlIdentificacion1.TabIndex = 0
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion1.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'GroupBox3
    '
    Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox3.Controls.Add(Me.CtlEmail2)
    Me.GroupBox3.Controls.Add(Me.CtlEmail1)
    Me.GroupBox3.HeaderText = "Email"
    Me.GroupBox3.IsModoMini = True
    Me.GroupBox3.Location = New System.Drawing.Point(312, 3)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox3.Size = New System.Drawing.Size(303, 89)
    Me.GroupBox3.TabIndex = 0
    Me.GroupBox3.TabStop = False
    '
    'CtlEmail2
    '
    Me.CtlEmail2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail2.Entidad = Nothing
    Me.CtlEmail2.Location = New System.Drawing.Point(4, 60)
    Me.CtlEmail2.Name = "CtlEmail2"
    Me.CtlEmail2.Size = New System.Drawing.Size(295, 28)
    Me.CtlEmail2.TabIndex = 1
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    '
    'CtlEmail1
    '
    Me.CtlEmail1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail1.Entidad = Nothing
    Me.CtlEmail1.Location = New System.Drawing.Point(4, 32)
    Me.CtlEmail1.Name = "CtlEmail1"
    Me.CtlEmail1.Size = New System.Drawing.Size(295, 28)
    Me.CtlEmail1.TabIndex = 0
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox2.Controls.Add(Me.CtlTelefono2)
    Me.GroupBox2.Controls.Add(Me.CtlTelefono1)
    Me.GroupBox2.HeaderText = "Teléfonos"
    Me.GroupBox2.IsModoMini = True
    Me.GroupBox2.Location = New System.Drawing.Point(3, 155)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox2.Size = New System.Drawing.Size(303, 89)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    '
    'CtlTelefono2
    '
    Me.CtlTelefono2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono2.Entidad = Nothing
    Me.CtlTelefono2.Location = New System.Drawing.Point(4, 60)
    Me.CtlTelefono2.Name = "CtlTelefono2"
    Me.CtlTelefono2.Size = New System.Drawing.Size(295, 28)
    Me.CtlTelefono2.TabIndex = 1
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'CtlTelefono1
    '
    Me.CtlTelefono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono1.Entidad = Nothing
    Me.CtlTelefono1.Location = New System.Drawing.Point(4, 32)
    Me.CtlTelefono1.Name = "CtlTelefono1"
    Me.CtlTelefono1.Size = New System.Drawing.Size(295, 28)
    Me.CtlTelefono1.TabIndex = 0
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox1.Controls.Add(Me.CtlDireccion1)
    Me.GroupBox1.HeaderText = "Dirección"
    Me.GroupBox1.IsModoMini = True
    Me.GroupBox1.Location = New System.Drawing.Point(3, 42)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox1.Size = New System.Drawing.Size(303, 107)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    '
    'CtlDireccion1
    '
    Me.CtlDireccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlDireccion1.Entidad = Nothing
    Me.CtlDireccion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlDireccion1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlDireccion1.Name = "CtlDireccion1"
    Me.CtlDireccion1.Size = New System.Drawing.Size(295, 88)
    Me.CtlDireccion1.TabIndex = 0
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Trabajo
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Entnat_ApellidopaternoLabel)
    Me.Panel4.Controls.Add(Me.Entlug_Descripcion)
    Me.Panel4.Location = New System.Drawing.Point(3, 3)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(303, 33)
    Me.Panel4.TabIndex = 0
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.AutoScroll = True
    Me.pnlcuerpo.BackColor = System.Drawing.Color.Transparent
    Me.pnlcuerpo.Controls.Add(Me.Panel4)
    Me.pnlcuerpo.Controls.Add(Me.GroupBox1)
    Me.pnlcuerpo.Controls.Add(Me.GroupBox2)
    Me.pnlcuerpo.Controls.Add(Me.grp_identificacion)
    Me.pnlcuerpo.Controls.Add(Me.GroupBox3)
    Me.pnlcuerpo.Controls.Add(Me.grpsri)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(543, 379)
    Me.pnlcuerpo.TabIndex = 1
    '
    'CtlEntidadLugar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Name = "CtlEntidadLugar"
    Me.Size = New System.Drawing.Size(543, 379)
    CType(Me.EntidadLugarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpsri.ResumeLayout(False)
    Me.grpsri.PerformLayout()
    Me.grp_identificacion.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.Panel4.PerformLayout()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents EntidadLugarBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents Entlug_Descripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents GroupBox1 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlDireccion1 As CtlDireccion
  Friend WithEvents GroupBox2 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlTelefono1 As CtlTelefono
  Friend WithEvents CtlTelefono2 As CtlTelefono
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents grp_identificacion As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlIdentificacion1 As CtlIdentificacion
  Friend WithEvents GroupBox3 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlEmail2 As CtlEmail
  Friend WithEvents CtlEmail1 As CtlEmail
  Friend WithEvents grpsri As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents mskcaducret As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents mskcaducnotvta As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents mskcaducfactura As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtautoret As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtautonotvta As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtautofactura As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents pnlcuerpo As System.Windows.Forms.FlowLayoutPanel

End Class
