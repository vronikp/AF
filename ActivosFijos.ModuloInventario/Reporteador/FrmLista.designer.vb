<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLista
  Inherits Infoware.Consola.Base.FrmListaSimpleBase

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
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
    Me.btnejecutar = New System.Windows.Forms.ToolStripButton
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
    Me.lblmensaje = New System.Windows.Forms.ToolStripLabel
    Me.btnconfemail = New System.Windows.Forms.ToolStripButton
    Me.tmrdatos = New System.Windows.Forms.Timer(Me.components)
    Me.tvopciones = New System.Windows.Forms.TreeView
    Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
    Me.ComboBoxConexionOtros1 = New ComboBoxConexionOtros
    Me.TabConexion = New System.Windows.Forms.TabControl
    Me.TabPage1 = New System.Windows.Forms.TabPage
    Me.TabPage2 = New System.Windows.Forms.TabPage
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.TabConexion.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 74)
    Me.pnlcuerpo.Size = New System.Drawing.Size(692, 392)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.TabConexion)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
    Me.Panel1.Size = New System.Drawing.Size(211, 367)
    Me.Panel1.Visible = True
    '
    'Panel2
    '
    Me.Panel2.Location = New System.Drawing.Point(211, 25)
    Me.Panel2.Size = New System.Drawing.Size(481, 34)
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnejecutar, Me.ToolStripSeparator1, Me.lblmensaje, Me.btnconfemail})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(692, 25)
    Me.ToolStrip2.TabIndex = 4
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnejecutar
    '
        'Me.btnejecutar.Image = My.Resources.Resources.play.ToBitmap
    Me.btnejecutar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnejecutar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnejecutar.MergeIndex = 5
    Me.btnejecutar.Name = "btnejecutar"
    Me.btnejecutar.Size = New System.Drawing.Size(110, 22)
    Me.btnejecutar.Text = "Ejecutar consulta"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 5
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'lblmensaje
    '
    Me.lblmensaje.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.lblmensaje.MergeIndex = 5
    Me.lblmensaje.Name = "lblmensaje"
    Me.lblmensaje.Size = New System.Drawing.Size(187, 22)
    Me.lblmensaje.Text = "No existen registros en la vista actual"
    '
    'btnconfemail
    '
    Me.btnconfemail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'Me.btnconfemail.Image = My.Resources.Resources.configure.ToBitmap
    Me.btnconfemail.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnconfemail.Name = "btnconfemail"
    Me.btnconfemail.Size = New System.Drawing.Size(23, 22)
    Me.btnconfemail.Text = "Configurar envío email automático"
    Me.btnconfemail.Visible = False
    '
    'tmrdatos
    '
    Me.tmrdatos.Interval = 350
    '
    'tvopciones
    '
    Me.tvopciones.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tvopciones.HideSelection = False
    Me.tvopciones.ImageIndex = 0
    Me.tvopciones.ImageList = Me.ImageList1
    Me.tvopciones.Location = New System.Drawing.Point(3, 24)
    Me.tvopciones.Name = "tvopciones"
    Me.tvopciones.SelectedImageIndex = 0
    Me.tvopciones.ShowRootLines = False
    Me.tvopciones.Size = New System.Drawing.Size(191, 308)
    Me.tvopciones.TabIndex = 3
    '
    'ImageList1
    '
    Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
    Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
    Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
    '
    'ComboBoxConexionOtros1
    '
    Me.ComboBoxConexionOtros1.Archivoxml = Nothing
    Me.ComboBoxConexionOtros1.Dock = System.Windows.Forms.DockStyle.Top
    Me.ComboBoxConexionOtros1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxConexionOtros1.FormattingEnabled = True
    Me.ComboBoxConexionOtros1.Location = New System.Drawing.Point(3, 3)
    Me.ComboBoxConexionOtros1.Name = "ComboBoxConexionOtros1"
    Me.ComboBoxConexionOtros1.PuedeActualizar = False
    Me.ComboBoxConexionOtros1.PuedeEliminar = True
    Me.ComboBoxConexionOtros1.PuedeModificar = True
    Me.ComboBoxConexionOtros1.PuedeNuevo = True
    Me.ComboBoxConexionOtros1.Size = New System.Drawing.Size(191, 21)
    Me.ComboBoxConexionOtros1.TabIndex = 0
    '
    'TabConexion
    '
    Me.TabConexion.Controls.Add(Me.TabPage1)
    Me.TabConexion.Controls.Add(Me.TabPage2)
    Me.TabConexion.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabConexion.Location = New System.Drawing.Point(3, 3)
    Me.TabConexion.Name = "TabConexion"
    Me.TabConexion.SelectedIndex = 0
    Me.TabConexion.Size = New System.Drawing.Size(205, 361)
    Me.TabConexion.TabIndex = 2
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.tvopciones)
    Me.TabPage1.Controls.Add(Me.ComboBoxConexionOtros1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(197, 335)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Conexiones"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'TabPage2
    '
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(178, 335)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Parámetros"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'FrmLista
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(692, 466)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmLista"
    Me.PuedeImprimir = True
    Me.Text = "Reportes externos"
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.TabConexion.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents btnejecutar As System.Windows.Forms.ToolStripButton
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents lblmensaje As System.Windows.Forms.ToolStripLabel
  Friend WithEvents tmrdatos As System.Windows.Forms.Timer
  Friend WithEvents tvopciones As System.Windows.Forms.TreeView
  Friend WithEvents ComboBoxConexionOtros1 As ComboBoxConexionOtros
  Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
  Friend WithEvents TabConexion As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents btnconfemail As System.Windows.Forms.ToolStripButton

End Class
