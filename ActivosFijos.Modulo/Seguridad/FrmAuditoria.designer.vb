<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAuditoria
  Inherits Infoware.Consola.Base.FrmReporteBase

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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
        Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chksolousuario = New Infoware.Controles.Base.CheckBoxStd()
        Me.ComboBoxUsuario1 = New ActivosFijos.Modulo.ComboBoxUsuario()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcuerpo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlcuerpo
        '
        Me.pnlcuerpo.Size = New System.Drawing.Size(580, 333)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.txtcodigo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBoxUsuario1)
        Me.Panel1.Controls.Add(Me.chksolousuario)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Size = New System.Drawing.Size(580, 81)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtfechasta)
        Me.GroupBox1.Controls.Add(Me.dtfecdesde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(166, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de fechas"
        '
        'dtfechasta
        '
        Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfechasta.Location = New System.Drawing.Point(62, 44)
        Me.dtfechasta.Name = "dtfechasta"
        Me.dtfechasta.Size = New System.Drawing.Size(91, 20)
        Me.dtfechasta.TabIndex = 1
        '
        'dtfecdesde
        '
        Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtfecdesde.Location = New System.Drawing.Point(62, 19)
        Me.dtfecdesde.Name = "dtfecdesde"
        Me.dtfecdesde.Size = New System.Drawing.Size(91, 20)
        Me.dtfecdesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasta:"
        '
        'chksolousuario
        '
        Me.chksolousuario.AutoSize = True
        Me.chksolousuario.Location = New System.Drawing.Point(177, 10)
        Me.chksolousuario.Name = "chksolousuario"
        Me.chksolousuario.Size = New System.Drawing.Size(95, 17)
        Me.chksolousuario.TabIndex = 2
        Me.chksolousuario.Text = "Solo el usuario"
        Me.chksolousuario.UseVisualStyleBackColor = True
        '
        'ComboBoxUsuario1
        '
        Me.ComboBoxUsuario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUsuario1.Enabled = False
        Me.ComboBoxUsuario1.Location = New System.Drawing.Point(279, 7)
        Me.ComboBoxUsuario1.Name = "ComboBoxUsuario1"
        Me.ComboBoxUsuario1.OperadorDatos = Nothing
        Me.ComboBoxUsuario1.PuedeActualizar = False
        Me.ComboBoxUsuario1.PuedeEliminar = False
        Me.ComboBoxUsuario1.PuedeModificar = False
        Me.ComboBoxUsuario1.PuedeNuevo = False
        Me.ComboBoxUsuario1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBoxUsuario1.TabIndex = 3
        Me.ComboBoxUsuario1.Usuario = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Que contenga:"
        '
        'txtcodigo
        '
        Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtcodigo.Location = New System.Drawing.Point(279, 34)
        Me.txtcodigo.Mensaje = ""
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtcodigo.PromptText = ""
        Me.txtcodigo.Size = New System.Drawing.Size(178, 20)
        Me.txtcodigo.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(481, 10)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FrmAuditoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(580, 382)
        Me.Name = "FrmAuditoria"
        Me.PuedeImprimir = True
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcuerpo.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents chksolousuario As Infoware.Controles.Base.CheckBoxStd
    Friend WithEvents ComboBoxUsuario1 As ComboBoxUsuario
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents btnBuscar As System.Windows.Forms.Button

End Class
