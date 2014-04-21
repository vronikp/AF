<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaActivoCustodioAprobar
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaActivoCustodioAprobar))
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btnseleccionartodo = New System.Windows.Forms.ToolStripButton()
    Me.btnaprobar = New System.Windows.Forms.ToolStripButton()
    Me.btnrechazarcambio = New System.Windows.Forms.ToolStripButton()
    Me.CtlBuscaEmpleado1 = New ActivosFijos.Modulo.CtlBuscaEmpleado()
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
    Me.Panel1.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(812, 47)
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
    'ToolStrip2
    '
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnseleccionartodo, Me.btnaprobar, Me.btnrechazarcambio})
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
    Me.btnseleccionartodo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnseleccionartodo.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnseleccionartodo.MergeIndex = 10
    Me.btnseleccionartodo.Name = "btnseleccionartodo"
    Me.btnseleccionartodo.Size = New System.Drawing.Size(99, 22)
    Me.btnseleccionartodo.Text = "Seleccionar todo"
    '
    'btnaprobar
    '
    Me.btnaprobar.Image = CType(resources.GetObject("btnaprobar.Image"), System.Drawing.Image)
    Me.btnaprobar.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnaprobar.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnaprobar.MergeIndex = 11
    Me.btnaprobar.Name = "btnaprobar"
    Me.btnaprobar.Size = New System.Drawing.Size(113, 22)
    Me.btnaprobar.Text = "Aprobar cambio"
    '
    'btnrechazarcambio
    '
    Me.btnrechazarcambio.Image = CType(resources.GetObject("btnrechazarcambio.Image"), System.Drawing.Image)
    Me.btnrechazarcambio.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnrechazarcambio.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btnrechazarcambio.MergeIndex = 12
    Me.btnrechazarcambio.Name = "btnrechazarcambio"
    Me.btnrechazarcambio.Size = New System.Drawing.Size(117, 22)
    Me.btnrechazarcambio.Text = "Rechazar cambio"
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Custodio"
    Me.CtlBuscaEmpleado1.Enabled = False
    Me.CtlBuscaEmpleado1.ItemText = "Custodio"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(12, 6)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(407, 24)
    Me.CtlBuscaEmpleado1.TabIndex = 2
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'FrmListaActivoCustodioAprobar
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(812, 622)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmListaActivoCustodioAprobar"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "Pendiente aprobación nuevo custodio"
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
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btnseleccionartodo As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnaprobar As System.Windows.Forms.ToolStripButton
  Friend WithEvents btnrechazarcambio As System.Windows.Forms.ToolStripButton
  Friend WithEvents CtlBuscaEmpleado1 As ActivosFijos.Modulo.CtlBuscaEmpleado

End Class
