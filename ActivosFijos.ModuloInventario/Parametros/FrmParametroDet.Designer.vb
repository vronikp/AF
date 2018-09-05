Imports Infoware.Controles.General
Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametroDet
  Inherits FrmMantBase

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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.pnlpadre = New System.Windows.Forms.Panel()
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet()
    Me.lbl_parametro = New System.Windows.Forms.Label()
    Me.pnldatoint = New System.Windows.Forms.Panel()
    Me.txtdatoint1 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lbl_datoint1 = New System.Windows.Forms.Label()
    Me.pnldatostr1 = New System.Windows.Forms.Panel()
    Me.txt_datostr1 = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datostr1 = New System.Windows.Forms.Label()
    Me.pnldatodec = New System.Windows.Forms.Panel()
    Me.txtdatodec1 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lbl_datodec1 = New System.Windows.Forms.Label()
    Me.pnldatoley = New System.Windows.Forms.Panel()
    Me.txtdatoley1 = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datoley1 = New System.Windows.Forms.Label()
    Me.pnldatobit1 = New System.Windows.Forms.Panel()
    Me.checkdatobit1 = New Infoware.Controles.Base.CheckBoxStd()
    Me.Panel2.SuspendLayout()
    Me.pnlpadre.SuspendLayout()
    Me.pnldatoint.SuspendLayout()
    Me.pnldatostr1.SuspendLayout()
    Me.pnldatodec.SuspendLayout()
    Me.pnldatoley.SuspendLayout()
    Me.pnldatobit1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 4)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtdescripcion.Location = New System.Drawing.Point(134, 2)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(346, 20)
    Me.txtdescripcion.TabIndex = 1
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 26)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(492, 25)
    Me.Panel2.TabIndex = 1
    '
    'pnlpadre
    '
    Me.pnlpadre.Controls.Add(Me.ComboBoxParametroDet1)
    Me.pnlpadre.Controls.Add(Me.lbl_parametro)
    Me.pnlpadre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpadre.Location = New System.Drawing.Point(0, 0)
    Me.pnlpadre.Name = "pnlpadre"
    Me.pnlpadre.Size = New System.Drawing.Size(492, 26)
    Me.pnlpadre.TabIndex = 0
    Me.pnlpadre.Visible = False
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.AbriralEntrar = False
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(134, 3)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(207, 21)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'lbl_parametro
    '
    Me.lbl_parametro.AutoSize = True
    Me.lbl_parametro.Location = New System.Drawing.Point(12, 6)
    Me.lbl_parametro.Name = "lbl_parametro"
    Me.lbl_parametro.Size = New System.Drawing.Size(58, 13)
    Me.lbl_parametro.TabIndex = 0
    Me.lbl_parametro.Text = "Parametro:"
    '
    'pnldatoint
    '
    Me.pnldatoint.Controls.Add(Me.txtdatoint1)
    Me.pnldatoint.Controls.Add(Me.lbl_datoint1)
    Me.pnldatoint.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoint.Location = New System.Drawing.Point(0, 76)
    Me.pnldatoint.Name = "pnldatoint"
    Me.pnldatoint.Size = New System.Drawing.Size(492, 26)
    Me.pnldatoint.TabIndex = 3
    Me.pnldatoint.Visible = False
    '
    'txtdatoint1
    '
    Me.txtdatoint1.Location = New System.Drawing.Point(134, 3)
    Me.txtdatoint1.Mensaje = ""
    Me.txtdatoint1.Name = "txtdatoint1"
    Me.txtdatoint1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdatoint1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdatoint1.PromptText = ""
    Me.txtdatoint1.Size = New System.Drawing.Size(71, 20)
    Me.txtdatoint1.TabIndex = 1
    Me.txtdatoint1.Text = "0"
    Me.txtdatoint1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtdatoint1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdatoint1.Value = 0.0R
    '
    'lbl_datoint1
    '
    Me.lbl_datoint1.AutoSize = True
    Me.lbl_datoint1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoint1.Name = "lbl_datoint1"
    Me.lbl_datoint1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoint1.TabIndex = 0
    Me.lbl_datoint1.Text = "Descripción:"
    '
    'pnldatostr1
    '
    Me.pnldatostr1.Controls.Add(Me.txt_datostr1)
    Me.pnldatostr1.Controls.Add(Me.lbl_datostr1)
    Me.pnldatostr1.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr1.Location = New System.Drawing.Point(0, 51)
    Me.pnldatostr1.Name = "pnldatostr1"
    Me.pnldatostr1.Size = New System.Drawing.Size(492, 25)
    Me.pnldatostr1.TabIndex = 2
    Me.pnldatostr1.Visible = False
    '
    'txt_datostr1
    '
    Me.txt_datostr1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr1.Location = New System.Drawing.Point(134, 3)
    Me.txt_datostr1.Mensaje = ""
    Me.txt_datostr1.Name = "txt_datostr1"
    Me.txt_datostr1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr1.PromptText = ""
    Me.txt_datostr1.Size = New System.Drawing.Size(346, 20)
    Me.txt_datostr1.TabIndex = 1
    Me.txt_datostr1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datostr1
    '
    Me.lbl_datostr1.AutoSize = True
    Me.lbl_datostr1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr1.Name = "lbl_datostr1"
    Me.lbl_datostr1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr1.TabIndex = 0
    Me.lbl_datostr1.Text = "Descripción:"
    '
    'pnldatodec
    '
    Me.pnldatodec.Controls.Add(Me.txtdatodec1)
    Me.pnldatodec.Controls.Add(Me.lbl_datodec1)
    Me.pnldatodec.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatodec.Location = New System.Drawing.Point(0, 102)
    Me.pnldatodec.Name = "pnldatodec"
    Me.pnldatodec.Size = New System.Drawing.Size(492, 26)
    Me.pnldatodec.TabIndex = 4
    Me.pnldatodec.Visible = False
    '
    'txtdatodec1
    '
    Me.txtdatodec1.Location = New System.Drawing.Point(134, 3)
    Me.txtdatodec1.Mensaje = ""
    Me.txtdatodec1.Name = "txtdatodec1"
    Me.txtdatodec1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdatodec1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdatodec1.PromptText = ""
    Me.txtdatodec1.Size = New System.Drawing.Size(71, 20)
    Me.txtdatodec1.TabIndex = 1
    Me.txtdatodec1.Text = "0,00"
    Me.txtdatodec1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtdatodec1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtdatodec1.Value = 0.0R
    '
    'lbl_datodec1
    '
    Me.lbl_datodec1.AutoSize = True
    Me.lbl_datodec1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datodec1.Name = "lbl_datodec1"
    Me.lbl_datodec1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datodec1.TabIndex = 0
    Me.lbl_datodec1.Text = "Descripción:"
    '
    'pnldatoley
    '
    Me.pnldatoley.Controls.Add(Me.txtdatoley1)
    Me.pnldatoley.Controls.Add(Me.lbl_datoley1)
    Me.pnldatoley.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoley.Location = New System.Drawing.Point(0, 128)
    Me.pnldatoley.Name = "pnldatoley"
    Me.pnldatoley.Size = New System.Drawing.Size(492, 71)
    Me.pnldatoley.TabIndex = 5
    Me.pnldatoley.Visible = False
    '
    'txtdatoley1
    '
    Me.txtdatoley1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtdatoley1.Location = New System.Drawing.Point(134, 3)
    Me.txtdatoley1.Mensaje = ""
    Me.txtdatoley1.Multiline = True
    Me.txtdatoley1.Name = "txtdatoley1"
    Me.txtdatoley1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdatoley1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdatoley1.PromptText = ""
    Me.txtdatoley1.Size = New System.Drawing.Size(346, 65)
    Me.txtdatoley1.TabIndex = 1
    Me.txtdatoley1.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'lbl_datoley1
    '
    Me.lbl_datoley1.AutoSize = True
    Me.lbl_datoley1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoley1.Name = "lbl_datoley1"
    Me.lbl_datoley1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoley1.TabIndex = 0
    Me.lbl_datoley1.Text = "Descripción:"
    '
    'pnldatobit1
    '
    Me.pnldatobit1.Controls.Add(Me.checkdatobit1)
    Me.pnldatobit1.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatobit1.Location = New System.Drawing.Point(0, 199)
    Me.pnldatobit1.Name = "pnldatobit1"
    Me.pnldatobit1.Size = New System.Drawing.Size(492, 26)
    Me.pnldatobit1.TabIndex = 1001
    Me.pnldatobit1.Visible = False
    '
    'checkdatobit1
    '
    Me.checkdatobit1.AutoSize = True
    Me.checkdatobit1.Location = New System.Drawing.Point(134, 7)
    Me.checkdatobit1.Name = "checkdatobit1"
    Me.checkdatobit1.Size = New System.Drawing.Size(15, 14)
    Me.checkdatobit1.TabIndex = 1
    Me.checkdatobit1.UseVisualStyleBackColor = True
    '
    'FrmParametroDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(492, 265)
    Me.Controls.Add(Me.pnldatobit1)
    Me.Controls.Add(Me.pnldatoley)
    Me.Controls.Add(Me.pnldatodec)
    Me.Controls.Add(Me.pnldatoint)
    Me.Controls.Add(Me.pnldatostr1)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.pnlpadre)
    Me.Name = "FrmParametroDet"
    Me.Controls.SetChildIndex(Me.pnlpadre, 0)
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Controls.SetChildIndex(Me.pnldatostr1, 0)
    Me.Controls.SetChildIndex(Me.pnldatoint, 0)
    Me.Controls.SetChildIndex(Me.pnldatodec, 0)
    Me.Controls.SetChildIndex(Me.pnldatoley, 0)
    Me.Controls.SetChildIndex(Me.pnldatobit1, 0)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlpadre.ResumeLayout(False)
    Me.pnlpadre.PerformLayout()
    Me.pnldatoint.ResumeLayout(False)
    Me.pnldatoint.PerformLayout()
    Me.pnldatostr1.ResumeLayout(False)
    Me.pnldatostr1.PerformLayout()
    Me.pnldatodec.ResumeLayout(False)
    Me.pnldatodec.PerformLayout()
    Me.pnldatoley.ResumeLayout(False)
    Me.pnldatoley.PerformLayout()
    Me.pnldatobit1.ResumeLayout(False)
    Me.pnldatobit1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents pnlpadre As System.Windows.Forms.Panel
  Friend WithEvents lbl_parametro As System.Windows.Forms.Label
  Friend WithEvents ComboBoxParametroDet1 As ComboBoxParametroDet
  Friend WithEvents pnldatoint As System.Windows.Forms.Panel
  Friend WithEvents txtdatoint1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents lbl_datoint1 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr1 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr1 As System.Windows.Forms.Label
  Friend WithEvents pnldatodec As System.Windows.Forms.Panel
  Friend WithEvents txtdatodec1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents lbl_datodec1 As System.Windows.Forms.Label
  Friend WithEvents pnldatoley As System.Windows.Forms.Panel
  Friend WithEvents txtdatoley1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datoley1 As System.Windows.Forms.Label
  Friend WithEvents pnldatobit1 As System.Windows.Forms.Panel
  Friend WithEvents checkdatobit1 As Infoware.Controles.Base.CheckBoxStd

End Class
