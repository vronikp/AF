<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaActivos
  Inherits Infoware.Consola.Base.FrmListaBase

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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaActivos))
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage()
    Me.CtlBuscaActivos1 = New ActivosFijos.Modulo.CtlBuscaActivos()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnseleccionartodo = New System.Windows.Forms.ToolStripButton()
    Me.btndarbaja = New System.Windows.Forms.ToolStripButton()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.btnmostrar)
    Me.pnlcuerpo.Size = New System.Drawing.Size(812, 573)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.btnmostrar, 0)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.Panel1, 0)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlBuscaActivos1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(194, 533)
    Me.Panel1.Visible = True
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(82, 93)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(5, 4)
    Me.btnmostrar.TabIndex = 7
    Me.btnmostrar.Text = "Button1"
    Me.btnmostrar.UseVisualStyleBackColor = True
    Me.btnmostrar.Visible = False
    '
    'CtlBuscaActivos1
    '
    Me.CtlBuscaActivos1.BackColor = System.Drawing.SystemColors.Info
    Me.CtlBuscaActivos1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlBuscaActivos1.Location = New System.Drawing.Point(5, 3)
    Me.CtlBuscaActivos1.Name = "CtlBuscaActivos1"
    Me.CtlBuscaActivos1.OperadorDatos = Nothing
    Me.CtlBuscaActivos1.PuedeExportaryBarCode = False
    Me.CtlBuscaActivos1.Size = New System.Drawing.Size(184, 527)
    Me.CtlBuscaActivos1.TabIndex = 0
    '
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnseleccionartodo, Me.btndarbaja})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 49)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(812, 25)
    Me.ToolStrip2.TabIndex = 6
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'ToolStripSeparator1
    '
    Me.ToolStripSeparator1.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.ToolStripSeparator1.MergeIndex = 1
    Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
    Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
    '
    'btnseleccionartodo
    '
    Me.btnseleccionartodo.Image = CType(resources.GetObject("btnseleccionartodo.Image"), System.Drawing.Image)
    Me.btnseleccionartodo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnseleccionartodo.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnseleccionartodo.MergeIndex = 10
    Me.btnseleccionartodo.Name = "btnseleccionartodo"
    Me.btnseleccionartodo.Size = New System.Drawing.Size(115, 22)
    Me.btnseleccionartodo.Text = "Seleccionar todo"
    '
    'btndarbaja
    '
    Me.btndarbaja.Image = CType(resources.GetObject("btndarbaja.Image"), System.Drawing.Image)
    Me.btndarbaja.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btndarbaja.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btndarbaja.MergeIndex = 11
    Me.btndarbaja.Name = "btndarbaja"
    Me.btndarbaja.Size = New System.Drawing.Size(86, 22)
    Me.btndarbaja.Text = "Dar de baja"
    Me.btndarbaja.Visible = False
    '
    'FrmListaActivos
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(812, 622)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmListaActivos"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "Lista de activos"
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents ToolTipImage1 As Infoware.Controles.Base.ToolTipImage
  Friend WithEvents CtlBuscaActivos1 As ActivosFijos.Modulo.CtlBuscaActivos
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnseleccionartodo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btndarbaja As System.Windows.Forms.ToolStripButton

End Class
