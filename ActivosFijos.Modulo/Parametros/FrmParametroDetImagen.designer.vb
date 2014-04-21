Imports Infoware.Controles.General
Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmParametroDetImagen
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
    Me.PictureBox1 = New Infoware.Controles.Base.ImagenSQL
    Me.Label2 = New System.Windows.Forms.Label
    Me.pnlpadre = New System.Windows.Forms.Panel
    Me.ComboBoxParametroDet1 = New ComboBoxParametroDet
    Me.lbl_parametro = New System.Windows.Forms.Label
    Me.Panel2.SuspendLayout()
    Me.pnlpadre.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 10)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(65, 15)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(88, 7)
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.Size = New System.Drawing.Size(253, 23)
    Me.txtdescripcion.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.PictureBox1)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(0, 33)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(353, 196)
    Me.Panel2.TabIndex = 1
    '
    'PictureBox1
    '
    Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PictureBox1.ArchivoImagen = Nothing
    Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
    Me.PictureBox1.Imagen = Nothing
    Me.PictureBox1.Location = New System.Drawing.Point(88, 36)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
    Me.PictureBox1.Size = New System.Drawing.Size(128, 152)
    Me.PictureBox1.TabIndex = 6
    Me.PictureBox1.TabStop = False
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 40)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(45, 15)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Imagen:"
    '
    'pnlpadre
    '
    Me.pnlpadre.Controls.Add(Me.ComboBoxParametroDet1)
    Me.pnlpadre.Controls.Add(Me.lbl_parametro)
    Me.pnlpadre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpadre.Location = New System.Drawing.Point(0, 0)
    Me.pnlpadre.Name = "pnlpadre"
    Me.pnlpadre.Size = New System.Drawing.Size(353, 33)
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
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(253, 23)
    Me.ComboBoxParametroDet1.TabIndex = 1
    '
    'lbl_parametro
    '
    Me.lbl_parametro.AutoSize = True
    Me.lbl_parametro.Location = New System.Drawing.Point(12, 7)
    Me.lbl_parametro.Name = "lbl_parametro"
    Me.lbl_parametro.Size = New System.Drawing.Size(60, 15)
    Me.lbl_parametro.TabIndex = 0
    Me.lbl_parametro.Text = "Parametro:"
    '
    'FrmParametroDetImagen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
    Me.ClientSize = New System.Drawing.Size(353, 276)
    Me.Controls.Add(Me.Panel2)
    Me.Controls.Add(Me.pnlpadre)
    Me.Name = "FrmParametroDetImagen"
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
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As Infoware.Controles.Base.ImagenSQL

End Class
