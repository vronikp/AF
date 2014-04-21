<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoActivoComponente
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

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
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnlbaja = New System.Windows.Forms.Panel()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.dtfechabaja = New System.Windows.Forms.DateTimePicker()
    Me.pnlerogacion = New System.Windows.Forms.Panel()
    Me.txtvalorerogacion = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.chkbaja = New System.Windows.Forms.CheckBox()
    Me.chkerogacion = New System.Windows.Forms.CheckBox()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.txtfactura = New Infoware.Controles.Base.TextBoxStd()
    Me.txtserie = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.dtfecfactura = New System.Windows.Forms.DateTimePicker()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtmodelo = New Infoware.Controles.Base.TextBoxStd()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.cbomarca = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.CtlBuscaProveedor1 = New ActivosFijos.Modulo.CtlBuscaProveedor()
    Me.dtfecingreso = New System.Windows.Forms.DateTimePicker()
    Me.Label6 = New System.Windows.Forms.Label()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnlbaja.SuspendLayout()
    Me.pnlerogacion.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlbaja)
    Me.Panel1.Controls.Add(Me.pnlerogacion)
    Me.Panel1.Controls.Add(Me.chkbaja)
    Me.Panel1.Controls.Add(Me.chkerogacion)
    Me.Panel1.Controls.Add(Me.Label6)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Controls.Add(Me.txtfactura)
    Me.Panel1.Controls.Add(Me.txtserie)
    Me.Panel1.Controls.Add(Me.dtfecingreso)
    Me.Panel1.Controls.Add(Me.Label4)
    Me.Panel1.Controls.Add(Me.dtfecfactura)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.txtmodelo)
    Me.Panel1.Controls.Add(Me.Label7)
    Me.Panel1.Controls.Add(Me.cbomarca)
    Me.Panel1.Controls.Add(Me.Label8)
    Me.Panel1.Controls.Add(Me.txtdescripcion)
    Me.Panel1.Controls.Add(Me.Label2)
    Me.Panel1.Controls.Add(Me.CtlBuscaProveedor1)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(521, 347)
    Me.Panel1.TabIndex = 0
    '
    'pnlbaja
    '
    Me.pnlbaja.Controls.Add(Me.Label5)
    Me.pnlbaja.Controls.Add(Me.dtfechabaja)
    Me.pnlbaja.Location = New System.Drawing.Point(12, 285)
    Me.pnlbaja.Name = "pnlbaja"
    Me.pnlbaja.Size = New System.Drawing.Size(497, 28)
    Me.pnlbaja.TabIndex = 18
    Me.pnlbaja.Visible = False
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(3, 6)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(78, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Fecha de baja:"
    '
    'dtfechabaja
    '
    Me.dtfechabaja.Location = New System.Drawing.Point(130, 3)
    Me.dtfechabaja.Name = "dtfechabaja"
    Me.dtfechabaja.Size = New System.Drawing.Size(200, 20)
    Me.dtfechabaja.TabIndex = 1
    '
    'pnlerogacion
    '
    Me.pnlerogacion.Controls.Add(Me.txtvalorerogacion)
    Me.pnlerogacion.Controls.Add(Me.Label3)
    Me.pnlerogacion.Location = New System.Drawing.Point(12, 235)
    Me.pnlerogacion.Name = "pnlerogacion"
    Me.pnlerogacion.Size = New System.Drawing.Size(497, 25)
    Me.pnlerogacion.TabIndex = 16
    Me.pnlerogacion.Visible = False
    '
    'txtvalorerogacion
    '
    Me.txtvalorerogacion.BackColor = System.Drawing.SystemColors.Window
    Me.txtvalorerogacion.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtvalorerogacion.Location = New System.Drawing.Point(130, 2)
    Me.txtvalorerogacion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtvalorerogacion.Mensaje = ""
    Me.txtvalorerogacion.Name = "txtvalorerogacion"
    Me.txtvalorerogacion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalorerogacion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalorerogacion.PromptText = ""
    Me.txtvalorerogacion.Size = New System.Drawing.Size(200, 20)
    Me.txtvalorerogacion.TabIndex = 1
    Me.txtvalorerogacion.Text = "0,00"
    Me.txtvalorerogacion.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorerogacion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalorerogacion.Value = 0.0R
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(3, 5)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(85, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Valor Erogación:"
    '
    'chkbaja
    '
    Me.chkbaja.AutoSize = True
    Me.chkbaja.Location = New System.Drawing.Point(142, 266)
    Me.chkbaja.Name = "chkbaja"
    Me.chkbaja.Size = New System.Drawing.Size(64, 17)
    Me.chkbaja.TabIndex = 17
    Me.chkbaja.Text = "De Baja"
    Me.chkbaja.UseVisualStyleBackColor = True
    '
    'chkerogacion
    '
    Me.chkerogacion.AutoSize = True
    Me.chkerogacion.Location = New System.Drawing.Point(142, 216)
    Me.chkerogacion.Name = "chkerogacion"
    Me.chkerogacion.Size = New System.Drawing.Size(74, 17)
    Me.chkerogacion.TabIndex = 15
    Me.chkerogacion.Text = "Erogación"
    Me.chkerogacion.UseVisualStyleBackColor = True
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(15, 143)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(91, 13)
    Me.Label13.TabIndex = 9
    Me.Label13.Text = "Fecha de factura:"
    '
    'txtfactura
    '
    Me.txtfactura.Location = New System.Drawing.Point(142, 191)
    Me.txtfactura.Margin = New System.Windows.Forms.Padding(2)
    Me.txtfactura.Mensaje = ""
    Me.txtfactura.Name = "txtfactura"
    Me.txtfactura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtfactura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtfactura.PromptText = ""
    Me.txtfactura.Size = New System.Drawing.Size(200, 20)
    Me.txtfactura.TabIndex = 14
    Me.txtfactura.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtserie
    '
    Me.txtserie.Location = New System.Drawing.Point(142, 87)
    Me.txtserie.Margin = New System.Windows.Forms.Padding(2)
    Me.txtserie.Mensaje = ""
    Me.txtserie.Name = "txtserie"
    Me.txtserie.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtserie.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtserie.PromptText = ""
    Me.txtserie.Size = New System.Drawing.Size(200, 20)
    Me.txtserie.TabIndex = 7
    Me.txtserie.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(15, 194)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(46, 13)
    Me.Label4.TabIndex = 13
    Me.Label4.Text = "Factura:"
    '
    'dtfecfactura
    '
    Me.dtfecfactura.Location = New System.Drawing.Point(142, 140)
    Me.dtfecfactura.Name = "dtfecfactura"
    Me.dtfecfactura.Size = New System.Drawing.Size(200, 20)
    Me.dtfecfactura.TabIndex = 10
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(15, 90)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(34, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Serie:"
    '
    'txtmodelo
    '
    Me.txtmodelo.Location = New System.Drawing.Point(142, 63)
    Me.txtmodelo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtmodelo.Mensaje = ""
    Me.txtmodelo.Name = "txtmodelo"
    Me.txtmodelo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtmodelo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtmodelo.PromptText = ""
    Me.txtmodelo.Size = New System.Drawing.Size(200, 20)
    Me.txtmodelo.TabIndex = 5
    Me.txtmodelo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(15, 66)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(45, 13)
    Me.Label7.TabIndex = 4
    Me.Label7.Text = "Modelo:"
    '
    'cbomarca
    '
    Me.cbomarca.AbriralEntrar = False
    Me.cbomarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbomarca.FormattingEnabled = True
    Me.cbomarca.Location = New System.Drawing.Point(142, 38)
    Me.cbomarca.Margin = New System.Windows.Forms.Padding(2)
    Me.cbomarca.MostrarRutaCompleta = False
    Me.cbomarca.Name = "cbomarca"
    Me.cbomarca.OperadorDatos = Nothing
    Me.cbomarca.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbomarca.ParametroDet = Nothing
    Me.cbomarca.PuedeActualizar = True
    Me.cbomarca.PuedeEliminar = True
    Me.cbomarca.PuedeModificar = True
    Me.cbomarca.PuedeNuevo = True
    Me.cbomarca.Size = New System.Drawing.Size(200, 21)
    Me.cbomarca.TabIndex = 3
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(15, 41)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(40, 13)
    Me.Label8.TabIndex = 2
    Me.Label8.Text = "Marca:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(142, 14)
    Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(368, 20)
    Me.txtdescripcion.TabIndex = 1
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(15, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Descripción:"
    '
    'CtlBuscaProveedor1
    '
    Me.CtlBuscaProveedor1.ItemText = "Proveedor"
    Me.CtlBuscaProveedor1.Location = New System.Drawing.Point(18, 112)
    Me.CtlBuscaProveedor1.Name = "CtlBuscaProveedor1"
    Me.CtlBuscaProveedor1.Proveedor = Nothing
    Me.CtlBuscaProveedor1.ProveedorText = "Proveedor"
    Me.CtlBuscaProveedor1.Size = New System.Drawing.Size(478, 22)
    Me.CtlBuscaProveedor1.TabIndex = 8
    Me.CtlBuscaProveedor1.Ubicacion = ActivosFijos.Modulo.CtlBuscaProveedor.EnumUbicacion.Normal
    '
    'dtfecingreso
    '
    Me.dtfecingreso.Location = New System.Drawing.Point(142, 166)
    Me.dtfecingreso.Name = "dtfecingreso"
    Me.dtfecingreso.Size = New System.Drawing.Size(200, 20)
    Me.dtfecingreso.TabIndex = 12
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(15, 169)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(92, 13)
    Me.Label6.TabIndex = 11
    Me.Label6.Text = "Fecha de ingreso:"
    '
    'FrmMantenimientoActivoComponente
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(521, 396)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoActivoComponente"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Componente Activo"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.pnlbaja.ResumeLayout(False)
    Me.pnlbaja.PerformLayout()
    Me.pnlerogacion.ResumeLayout(False)
    Me.pnlerogacion.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaProveedor1 As ActivosFijos.Modulo.CtlBuscaProveedor
  Friend WithEvents dtfecfactura As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents cbomarca As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents pnlerogacion As System.Windows.Forms.Panel
  Friend WithEvents chkerogacion As System.Windows.Forms.CheckBox
  Friend WithEvents txtserie As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtmodelo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtvalorerogacion As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtfactura As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents pnlbaja As System.Windows.Forms.Panel
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents dtfechabaja As System.Windows.Forms.DateTimePicker
  Friend WithEvents chkbaja As System.Windows.Forms.CheckBox
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents dtfecingreso As System.Windows.Forms.DateTimePicker

End Class
