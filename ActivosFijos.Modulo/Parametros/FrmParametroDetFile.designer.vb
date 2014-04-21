Imports Infoware.Controles.General
Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametroDetFile
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
    Me.components = New System.ComponentModel.Container
    Me.Label1 = New System.Windows.Forms.Label
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd
    Me.Panel2 = New System.Windows.Forms.Panel
    Me.lnkarchivo = New System.Windows.Forms.LinkLabel
    Me.btnarchivo = New System.Windows.Forms.Button
    Me.Label2 = New System.Windows.Forms.Label
    Me.pnlpadre = New System.Windows.Forms.Panel
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet
    Me.lbl_parametro = New System.Windows.Forms.Label
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
    Me.Panel2.SuspendLayout()
    Me.pnlpadre.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(88, 6)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(253, 20)
    Me.txtdescripcion.TabIndex = 1
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.lnkarchivo)
    Me.Panel2.Controls.Add(Me.btnarchivo)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 29)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(353, 82)
    Me.Panel2.TabIndex = 1
    '
    'lnkarchivo
    '
    Me.lnkarchivo.Location = New System.Drawing.Point(88, 32)
    Me.lnkarchivo.Name = "lnkarchivo"
    Me.lnkarchivo.Size = New System.Drawing.Size(215, 48)
    Me.lnkarchivo.TabIndex = 3
    '
    'btnarchivo
    '
    Me.btnarchivo.Image = My.Resources.Resources.adjunto.ToBitmap
    Me.btnarchivo.Location = New System.Drawing.Point(309, 32)
    Me.btnarchivo.Name = "btnarchivo"
    Me.btnarchivo.Size = New System.Drawing.Size(32, 29)
    Me.btnarchivo.TabIndex = 4
    Me.btnarchivo.Text = "..."
    Me.btnarchivo.UseVisualStyleBackColor = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(46, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Archivo:"
    '
    'pnlpadre
    '
    Me.pnlpadre.Controls.Add(Me.ComboBoxParametroDet1)
    Me.pnlpadre.Controls.Add(Me.lbl_parametro)
    Me.pnlpadre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpadre.Location = New System.Drawing.Point(0, 0)
    Me.pnlpadre.Name = "pnlpadre"
    Me.pnlpadre.Size = New System.Drawing.Size(353, 29)
    Me.pnlpadre.TabIndex = 0
    Me.pnlpadre.Visible = False
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(88, 3)
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(253, 21)
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
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'FrmParametroDetFile
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(353, 155)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.pnlpadre)
    Me.Name = "FrmParametroDetFile"
    Me.Controls.SetChildIndex(Me.pnlpadre, 0)
    Me.Controls.SetChildIndex(Me.Panel2, 0)
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlpadre.ResumeLayout(False)
    Me.pnlpadre.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents pnlpadre As System.Windows.Forms.Panel
  Friend WithEvents lbl_parametro As System.Windows.Forms.Label
  Friend WithEvents ComboBoxParametroDet1 As ComboBoxParametroDet
  Friend WithEvents btnarchivo As System.Windows.Forms.Button
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents lnkarchivo As System.Windows.Forms.LinkLabel
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
