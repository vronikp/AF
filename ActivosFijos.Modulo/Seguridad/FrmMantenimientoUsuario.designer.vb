

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoUsuario
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
    Me.GroupBox2 = New System.Windows.Forms.GroupBox()
    Me.CtlRestricciones1 = New ActivosFijos.Modulo.CtlRestricciones()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.ComboBoxUsuario1 = New ActivosFijos.Modulo.ComboBoxUsuario()
    Me.chkcopiarrestricciones = New Infoware.Controles.Base.CheckBoxStd()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.chkmaniconf = New Infoware.Controles.Base.CheckBoxStd()
    Me.chkregimp = New Infoware.Controles.Base.CheckBoxStd()
    Me.chkmoddat = New Infoware.Controles.Base.CheckBoxStd()
    Me.chkregentsal = New Infoware.Controles.Base.CheckBoxStd()
    Me.Panel2 = New System.Windows.Forms.Panel()
    Me.chkubicacion = New System.Windows.Forms.CheckBox()
    Me.chkempleado = New System.Windows.Forms.CheckBox()
    Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.CtlBuscaEmpleado1 = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    Me.chkactivo = New System.Windows.Forms.CheckBox()
    Me.chkcambcontrpr = New System.Windows.Forms.CheckBox()
    Me.chkcambiocontrasena = New System.Windows.Forms.CheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd()
    Me.txtcontrasena = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.txtmensaje = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.chkcambiocustodio = New System.Windows.Forms.CheckBox()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.CtlRestricciones1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
    Me.Panel1.Size = New System.Drawing.Size(701, 634)
    Me.Panel1.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.CtlRestricciones1)
    Me.GroupBox2.Controls.Add(Me.Panel3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(5, 446)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Size = New System.Drawing.Size(691, 184)
    Me.GroupBox2.TabIndex = 2
    Me.GroupBox2.TabStop = False
    Me.GroupBox2.Text = "Restricciones"
    '
    'CtlRestricciones1
    '
    Me.CtlRestricciones1.AllowUserToAddRows = False
    Me.CtlRestricciones1.AllowUserToDeleteRows = False
    Me.CtlRestricciones1.AutoGenerateColumns = False
    Me.CtlRestricciones1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.CtlRestricciones1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlRestricciones1.FactorTamanio = New Decimal(New Integer() {1, 0, 0, 0})
    Me.CtlRestricciones1.Location = New System.Drawing.Point(3, 44)
    Me.CtlRestricciones1.Name = "CtlRestricciones1"
    Me.CtlRestricciones1.RowHeadersVisible = False
    Me.CtlRestricciones1.RowTemplate.Height = 25
    Me.CtlRestricciones1.Size = New System.Drawing.Size(685, 137)
    Me.CtlRestricciones1.TabIndex = 0
    Me.CtlRestricciones1.Usuario = Nothing
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.ComboBoxUsuario1)
    Me.Panel3.Controls.Add(Me.chkcopiarrestricciones)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(3, 16)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(685, 28)
    Me.Panel3.TabIndex = 1
    '
    'ComboBoxUsuario1
    '
    Me.ComboBoxUsuario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxUsuario1.Enabled = False
    Me.ComboBoxUsuario1.FormattingEnabled = True
    Me.ComboBoxUsuario1.Location = New System.Drawing.Point(130, 1)
    Me.ComboBoxUsuario1.Name = "ComboBoxUsuario1"
    Me.ComboBoxUsuario1.OperadorDatos = Nothing
    Me.ComboBoxUsuario1.PuedeActualizar = False
    Me.ComboBoxUsuario1.PuedeEliminar = False
    Me.ComboBoxUsuario1.PuedeModificar = False
    Me.ComboBoxUsuario1.PuedeNuevo = False
    Me.ComboBoxUsuario1.Size = New System.Drawing.Size(226, 21)
    Me.ComboBoxUsuario1.TabIndex = 4
    Me.ComboBoxUsuario1.Usuario = Nothing
    '
    'chkcopiarrestricciones
    '
    Me.chkcopiarrestricciones.AutoSize = True
    Me.chkcopiarrestricciones.Location = New System.Drawing.Point(15, 3)
    Me.chkcopiarrestricciones.Name = "chkcopiarrestricciones"
    Me.chkcopiarrestricciones.Size = New System.Drawing.Size(105, 17)
    Me.chkcopiarrestricciones.TabIndex = 3
    Me.chkcopiarrestricciones.Text = "Copiar rol desde:"
    Me.chkcopiarrestricciones.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.chkmaniconf)
    Me.GroupBox1.Controls.Add(Me.chkregimp)
    Me.GroupBox1.Controls.Add(Me.chkmoddat)
    Me.GroupBox1.Controls.Add(Me.chkregentsal)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
    Me.GroupBox1.Location = New System.Drawing.Point(5, 380)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(691, 66)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Registro de auditoría"
    '
    'chkmaniconf
    '
    Me.chkmaniconf.AutoSize = True
    Me.chkmaniconf.Location = New System.Drawing.Point(275, 41)
    Me.chkmaniconf.Name = "chkmaniconf"
    Me.chkmaniconf.Size = New System.Drawing.Size(250, 17)
    Me.chkmaniconf.TabIndex = 3
    Me.chkmaniconf.Text = "Registrar manipulación información confidencial"
    Me.chkmaniconf.UseVisualStyleBackColor = True
    '
    'chkregimp
    '
    Me.chkregimp.AutoSize = True
    Me.chkregimp.Location = New System.Drawing.Point(275, 19)
    Me.chkregimp.Name = "chkregimp"
    Me.chkregimp.Size = New System.Drawing.Size(176, 17)
    Me.chkregimp.TabIndex = 2
    Me.chkregimp.Text = "Registrar impresiones realizadas"
    Me.chkregimp.UseVisualStyleBackColor = True
    '
    'chkmoddat
    '
    Me.chkmoddat.AutoSize = True
    Me.chkmoddat.Location = New System.Drawing.Point(18, 41)
    Me.chkmoddat.Name = "chkmoddat"
    Me.chkmoddat.Size = New System.Drawing.Size(174, 17)
    Me.chkmoddat.TabIndex = 1
    Me.chkmoddat.Text = "Registrar modificación de datos"
    Me.chkmoddat.UseVisualStyleBackColor = True
    '
    'chkregentsal
    '
    Me.chkregentsal.AutoSize = True
    Me.chkregentsal.Location = New System.Drawing.Point(18, 19)
    Me.chkregentsal.Name = "chkregentsal"
    Me.chkregentsal.Size = New System.Drawing.Size(210, 17)
    Me.chkregentsal.TabIndex = 0
    Me.chkregentsal.Text = "Registrar entradas y salidas del sistema"
    Me.chkregentsal.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.chkubicacion)
    Me.Panel2.Controls.Add(Me.chkempleado)
    Me.Panel2.Controls.Add(Me.CtlUbicacionActivo1)
    Me.Panel2.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Panel2.Controls.Add(Me.chkcambiocustodio)
    Me.Panel2.Controls.Add(Me.chkactivo)
    Me.Panel2.Controls.Add(Me.chkcambcontrpr)
    Me.Panel2.Controls.Add(Me.chkcambiocontrasena)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.txtcodigo)
    Me.Panel2.Controls.Add(Me.txtcontrasena)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.Label3)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.txtmensaje)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(5, 4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(691, 376)
    Me.Panel2.TabIndex = 0
    '
    'chkubicacion
    '
    Me.chkubicacion.AutoSize = True
    Me.chkubicacion.Location = New System.Drawing.Point(10, 196)
    Me.chkubicacion.Name = "chkubicacion"
    Me.chkubicacion.Size = New System.Drawing.Size(74, 17)
    Me.chkubicacion.TabIndex = 13
    Me.chkubicacion.Text = "Ubicación"
    Me.chkubicacion.UseVisualStyleBackColor = True
    '
    'chkempleado
    '
    Me.chkempleado.AutoSize = True
    Me.chkempleado.Location = New System.Drawing.Point(10, 145)
    Me.chkempleado.Name = "chkempleado"
    Me.chkempleado.Size = New System.Drawing.Size(73, 17)
    Me.chkempleado.TabIndex = 10
    Me.chkempleado.Text = "Empleado"
    Me.chkempleado.UseVisualStyleBackColor = True
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Enabled = False
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(133, 196)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(403, 154)
    Me.CtlUbicacionActivo1.TabIndex = 14
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Empleado"
    Me.CtlBuscaEmpleado1.Enabled = False
    Me.CtlBuscaEmpleado1.ItemText = "Empleado"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(133, 145)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(526, 22)
    Me.CtlBuscaEmpleado1.TabIndex = 11
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'chkactivo
    '
    Me.chkactivo.AutoSize = True
    Me.chkactivo.Location = New System.Drawing.Point(133, 356)
    Me.chkactivo.Name = "chkactivo"
    Me.chkactivo.Size = New System.Drawing.Size(56, 17)
    Me.chkactivo.TabIndex = 15
    Me.chkactivo.Text = "Activo"
    Me.chkactivo.UseVisualStyleBackColor = True
    '
    'chkcambcontrpr
    '
    Me.chkcambcontrpr.AutoSize = True
    Me.chkcambcontrpr.Location = New System.Drawing.Point(133, 81)
    Me.chkcambcontrpr.Name = "chkcambcontrpr"
    Me.chkcambcontrpr.Size = New System.Drawing.Size(311, 17)
    Me.chkcambcontrpr.TabIndex = 7
    Me.chkcambcontrpr.Text = "Solicitar cambio de contraseña en el próximo inicio de sesión"
    Me.chkcambcontrpr.UseVisualStyleBackColor = True
    '
    'chkcambiocontrasena
    '
    Me.chkcambiocontrasena.AutoSize = True
    Me.chkcambiocontrasena.Checked = True
    Me.chkcambiocontrasena.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkcambiocontrasena.Location = New System.Drawing.Point(239, 57)
    Me.chkcambiocontrasena.Name = "chkcambiocontrasena"
    Me.chkcambiocontrasena.Size = New System.Drawing.Size(120, 17)
    Me.chkcambiocontrasena.TabIndex = 6
    Me.chkcambiocontrasena.Text = "Cambiar contraseña"
    Me.chkcambiocontrasena.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(7, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(61, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Id. Usuario:"
    '
    'txtcodigo
    '
    Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
    Me.txtcodigo.Location = New System.Drawing.Point(133, 6)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(100, 20)
    Me.txtcodigo.TabIndex = 1
    Me.txtcodigo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtcontrasena
    '
    Me.txtcontrasena.Location = New System.Drawing.Point(133, 55)
    Me.txtcontrasena.Mensaje = ""
    Me.txtcontrasena.Name = "txtcontrasena"
    Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtcontrasena.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcontrasena.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcontrasena.PromptText = ""
    Me.txtcontrasena.Size = New System.Drawing.Size(100, 20)
    Me.txtcontrasena.TabIndex = 5
    Me.txtcontrasena.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcontrasena.UseSystemPasswordChar = True
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 34)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(7, 59)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(64, 13)
    Me.Label3.TabIndex = 4
    Me.Label3.Text = "Contraseña:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(133, 31)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(296, 20)
    Me.txtdescripcion.TabIndex = 3
    Me.txtdescripcion.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtmensaje
    '
    Me.txtmensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtmensaje.Location = New System.Drawing.Point(133, 104)
    Me.txtmensaje.Mensaje = ""
    Me.txtmensaje.Multiline = True
    Me.txtmensaje.Name = "txtmensaje"
    Me.txtmensaje.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtmensaje.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtmensaje.PromptText = ""
    Me.txtmensaje.Size = New System.Drawing.Size(541, 35)
    Me.txtmensaje.TabIndex = 9
    Me.txtmensaje.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(7, 107)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(50, 13)
    Me.Label4.TabIndex = 8
    Me.Label4.Text = "Mensaje:"
    '
    'chkcambiocustodio
    '
    Me.chkcambiocustodio.AutoSize = True
    Me.chkcambiocustodio.Location = New System.Drawing.Point(133, 173)
    Me.chkcambiocustodio.Name = "chkcambiocustodio"
    Me.chkcambiocustodio.Size = New System.Drawing.Size(286, 17)
    Me.chkcambiocustodio.TabIndex = 12
    Me.chkcambiocustodio.Text = "Requerir confirmación al realizar un cambio de custodio"
    Me.chkcambiocustodio.UseVisualStyleBackColor = True
    '
    'FrmMantenimientoUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(701, 683)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoUsuario"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    CType(Me.CtlRestricciones1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents txtcontrasena As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents txtcodigo As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents chkmaniconf As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chkregimp As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chkmoddat As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents chkregentsal As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents txtmensaje As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
  Friend WithEvents Panel2 As System.Windows.Forms.Panel
  Friend WithEvents CtlRestricciones1 As CtlRestricciones
  Friend WithEvents chkcambiocontrasena As System.Windows.Forms.CheckBox
  Friend WithEvents CtlBuscaEmpleado1 As CtlBuscaEmpleado
  Friend WithEvents chkcambcontrpr As System.Windows.Forms.CheckBox
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
  Friend WithEvents chkcopiarrestricciones As Infoware.Controles.Base.CheckBoxStd
  Friend WithEvents ComboBoxUsuario1 As ComboBoxUsuario
  Friend WithEvents chkactivo As System.Windows.Forms.CheckBox
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
  Friend WithEvents chkubicacion As System.Windows.Forms.CheckBox
  Friend WithEvents chkempleado As System.Windows.Forms.CheckBox
  Friend WithEvents chkcambiocustodio As System.Windows.Forms.CheckBox

End Class
