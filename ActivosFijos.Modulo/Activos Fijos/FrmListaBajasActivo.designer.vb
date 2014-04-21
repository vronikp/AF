<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaBajasActivo
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaBajasActivo))
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.ToolTipImage1 = New Infoware.Controles.Base.ToolTipImage()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
    Me.btndarbaja = New System.Windows.Forms.ToolStripButton()
    Me.btngenerartxt = New System.Windows.Forms.ToolStripButton()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.dtfecdesde = New System.Windows.Forms.DateTimePicker()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dtfechasta = New System.Windows.Forms.DateTimePicker()
    Me.pnlubicacion = New System.Windows.Forms.Panel()
    Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.chkubicacion = New System.Windows.Forms.CheckBox()
    Me.chktipobaja = New System.Windows.Forms.CheckBox()
    Me.pnlTipoBaja = New System.Windows.Forms.Panel()
    Me.CtlTipoBaja = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.btnLlenar = New System.Windows.Forms.Button()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.pnlubicacion.SuspendLayout()
    Me.pnlTipoBaja.SuspendLayout()
    Me.Panel2.SuspendLayout()
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
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Controls.Add(Me.pnlTipoBaja)
    Me.Panel1.Controls.Add(Me.chktipobaja)
    Me.Panel1.Controls.Add(Me.pnlubicacion)
    Me.Panel1.Controls.Add(Me.chkubicacion)
    Me.Panel1.Controls.Add(Me.dtfechasta)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.dtfecdesde)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Panel1.Location = New System.Drawing.Point(0, 40)
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 3, 5, 3)
    Me.Panel1.Size = New System.Drawing.Size(190, 533)
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
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btndarbaja, Me.btngenerartxt})
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
    'btndarbaja
    '
    Me.btndarbaja.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btndarbaja.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btndarbaja.MergeIndex = 10
    Me.btndarbaja.Name = "btndarbaja"
    Me.btndarbaja.Size = New System.Drawing.Size(70, 22)
    Me.btndarbaja.Text = "Dar de baja"
    '
    'btngenerartxt
    '
    Me.btngenerartxt.Image = CType(resources.GetObject("btngenerartxt.Image"), System.Drawing.Image)
    Me.btngenerartxt.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btngenerartxt.MergeAction = System.Windows.Forms.MergeAction.Insert
    Me.btngenerartxt.MergeIndex = 12
    Me.btngenerartxt.Name = "btngenerartxt"
    Me.btngenerartxt.Size = New System.Drawing.Size(84, 22)
    Me.btngenerartxt.Text = "Generar txt"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(5, 3)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(41, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Desde:"
    '
    'dtfecdesde
    '
    Me.dtfecdesde.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfecdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecdesde.Location = New System.Drawing.Point(5, 16)
    Me.dtfecdesde.Name = "dtfecdesde"
    Me.dtfecdesde.Size = New System.Drawing.Size(180, 20)
    Me.dtfecdesde.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(5, 36)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(38, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Hasta:"
    '
    'dtfechasta
    '
    Me.dtfechasta.Dock = System.Windows.Forms.DockStyle.Top
    Me.dtfechasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfechasta.Location = New System.Drawing.Point(5, 49)
    Me.dtfechasta.Name = "dtfechasta"
    Me.dtfechasta.Size = New System.Drawing.Size(180, 20)
    Me.dtfechasta.TabIndex = 1
    '
    'pnlubicacion
    '
    Me.pnlubicacion.Controls.Add(Me.CtlUbicacionActivo1)
    Me.pnlubicacion.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlubicacion.Location = New System.Drawing.Point(5, 86)
    Me.pnlubicacion.Name = "pnlubicacion"
    Me.pnlubicacion.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlubicacion.Size = New System.Drawing.Size(180, 136)
    Me.pnlubicacion.TabIndex = 21
    Me.pnlubicacion.Visible = False
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(15, 0)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(165, 136)
    Me.CtlUbicacionActivo1.TabIndex = 0
    '
    'chkubicacion
    '
    Me.chkubicacion.Dock = System.Windows.Forms.DockStyle.Top
    Me.chkubicacion.Location = New System.Drawing.Point(5, 69)
    Me.chkubicacion.Name = "chkubicacion"
    Me.chkubicacion.Size = New System.Drawing.Size(180, 17)
    Me.chkubicacion.TabIndex = 20
    Me.chkubicacion.Text = "Ubicación:"
    '
    'chktipobaja
    '
    Me.chktipobaja.Dock = System.Windows.Forms.DockStyle.Top
    Me.chktipobaja.Location = New System.Drawing.Point(5, 222)
    Me.chktipobaja.Name = "chktipobaja"
    Me.chktipobaja.Size = New System.Drawing.Size(180, 17)
    Me.chktipobaja.TabIndex = 24
    Me.chktipobaja.Text = "Tipo de baja:"
    '
    'pnlTipoBaja
    '
    Me.pnlTipoBaja.Controls.Add(Me.CtlTipoBaja)
    Me.pnlTipoBaja.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlTipoBaja.Location = New System.Drawing.Point(5, 239)
    Me.pnlTipoBaja.Name = "pnlTipoBaja"
    Me.pnlTipoBaja.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
    Me.pnlTipoBaja.Size = New System.Drawing.Size(180, 136)
    Me.pnlTipoBaja.TabIndex = 26
    Me.pnlTipoBaja.Visible = False
    '
    'CtlTipoBaja
    '
    Me.CtlTipoBaja.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlTipoBaja.Location = New System.Drawing.Point(15, 0)
    Me.CtlTipoBaja.Name = "CtlTipoBaja"
    Me.CtlTipoBaja.ParametroDet = Nothing
    Me.CtlTipoBaja.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlTipoBaja.PardetRaiz = Nothing
    Me.CtlTipoBaja.Size = New System.Drawing.Size(165, 136)
    Me.CtlTipoBaja.TabIndex = 1
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.btnLlenar)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(5, 375)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(180, 35)
    Me.Panel2.TabIndex = 28
    '
    'btnLlenar
    '
    Me.btnLlenar.Location = New System.Drawing.Point(7, 6)
    Me.btnLlenar.Name = "btnLlenar"
    Me.btnLlenar.Size = New System.Drawing.Size(75, 23)
    Me.btnLlenar.TabIndex = 0
    Me.btnLlenar.Text = "Mostrar"
    Me.btnLlenar.UseVisualStyleBackColor = True
    '
    'FrmListaBajasActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(812, 622)
    Me.Controls.Add(Me.ToolStrip2)
    Me.Name = "FrmListaBajasActivo"
    Me.PuedeEliminar = True
    Me.PuedeImprimir = True
    Me.PuedeNuevo = True
    Me.PuedeRefrescar = True
    Me.Text = "Listado de bajas de activo"
    Me.Controls.SetChildIndex(Me.pnlcuerpo, 0)
    Me.Controls.SetChildIndex(Me.ToolStrip2, 0)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.pnlubicacion.ResumeLayout(False)
    Me.pnlTipoBaja.ResumeLayout(False)
    Me.Panel2.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents ToolTipImage1 As Infoware.Controles.Base.ToolTipImage
  Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
  Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
  Friend WithEvents btndarbaja As System.Windows.Forms.ToolStripButton
  Friend WithEvents btngenerartxt As System.Windows.Forms.ToolStripButton
  Friend WithEvents dtfechasta As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents dtfecdesde As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlubicacion As System.Windows.Forms.Panel
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents chkubicacion As System.Windows.Forms.CheckBox
  Friend WithEvents chktipobaja As System.Windows.Forms.CheckBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents btnLlenar As System.Windows.Forms.Button
  Friend WithEvents pnlTipoBaja As System.Windows.Forms.Panel
  Friend WithEvents CtlTipoBaja As ActivosFijos.Modulo.CtlParametroDetAnidado

End Class
