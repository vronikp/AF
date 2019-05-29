

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimientoUsuario
  Inherits Infoware.Consola.Base.FrmMantenimientoBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()>
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
  <System.Diagnostics.DebuggerStepThrough()>
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
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
    Me.pnlcontrasena = New System.Windows.Forms.Panel()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtcontrasena = New Infoware.Controles.Base.TextBoxStd()
    Me.chkcambiocontrasena = New System.Windows.Forms.CheckBox()
    Me.chkcambcontrpr = New System.Windows.Forms.CheckBox()
    Me.chkubicacion = New System.Windows.Forms.CheckBox()
    Me.chkempleado = New System.Windows.Forms.CheckBox()
    Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
    Me.CtlBuscaEmpleado1 = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    Me.chkcambiocustodio = New System.Windows.Forms.CheckBox()
    Me.chkactivo = New System.Windows.Forms.CheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtcodigo = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.txtmensaje = New Infoware.Controles.Base.TextBoxStd()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Panel4 = New System.Windows.Forms.Panel()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    CType(Me.CtlRestricciones1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel3.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel2.SuspendLayout()
    Me.pnlcontrasena.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.GroupBox2)
    Me.Panel1.Controls.Add(Me.GroupBox1)
    Me.Panel1.Controls.Add(Me.Panel2)
    Me.Panel1.Location = New System.Drawing.Point(4, 4)
    Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(7, 5, 7, 5)
    Me.Panel1.Size = New System.Drawing.Size(768, 757)
    Me.Panel1.TabIndex = 0
    '
    'GroupBox2
    '
    Me.GroupBox2.Controls.Add(Me.CtlRestricciones1)
    Me.GroupBox2.Controls.Add(Me.Panel3)
    Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox2.Location = New System.Drawing.Point(7, 549)
    Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
    Me.GroupBox2.Size = New System.Drawing.Size(754, 203)
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
    Me.CtlRestricciones1.Location = New System.Drawing.Point(4, 50)
    Me.CtlRestricciones1.Margin = New System.Windows.Forms.Padding(4)
    Me.CtlRestricciones1.Name = "CtlRestricciones1"
    Me.CtlRestricciones1.RowHeadersVisible = False
    Me.CtlRestricciones1.RowTemplate.Height = 25
    Me.CtlRestricciones1.Size = New System.Drawing.Size(746, 149)
    Me.CtlRestricciones1.TabIndex = 0
    Me.CtlRestricciones1.Usuario = Nothing
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.ComboBoxUsuario1)
    Me.Panel3.Controls.Add(Me.chkcopiarrestricciones)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(4, 16)
    Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(746, 34)
    Me.Panel3.TabIndex = 1
    '
    'ComboBoxUsuario1
    '
    Me.ComboBoxUsuario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxUsuario1.Enabled = False
    Me.ComboBoxUsuario1.FormattingEnabled = True
    Me.ComboBoxUsuario1.Location = New System.Drawing.Point(173, 1)
    Me.ComboBoxUsuario1.Margin = New System.Windows.Forms.Padding(4)
    Me.ComboBoxUsuario1.Name = "ComboBoxUsuario1"
    Me.ComboBoxUsuario1.OperadorDatos = Nothing
    Me.ComboBoxUsuario1.PuedeActualizar = False
    Me.ComboBoxUsuario1.PuedeEliminar = False
    Me.ComboBoxUsuario1.PuedeModificar = False
    Me.ComboBoxUsuario1.PuedeNuevo = False
    Me.ComboBoxUsuario1.Size = New System.Drawing.Size(300, 21)
    Me.ComboBoxUsuario1.TabIndex = 4
    Me.ComboBoxUsuario1.Usuario = Nothing
    '
    'chkcopiarrestricciones
    '
    Me.chkcopiarrestricciones.AutoSize = True
    Me.chkcopiarrestricciones.Location = New System.Drawing.Point(20, 4)
    Me.chkcopiarrestricciones.Margin = New System.Windows.Forms.Padding(4)
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
    Me.GroupBox1.Location = New System.Drawing.Point(7, 468)
    Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
    Me.GroupBox1.Size = New System.Drawing.Size(754, 81)
    Me.GroupBox1.TabIndex = 1
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Registro de auditoría"
    '
    'chkmaniconf
    '
    Me.chkmaniconf.AutoSize = True
    Me.chkmaniconf.Location = New System.Drawing.Point(367, 50)
    Me.chkmaniconf.Margin = New System.Windows.Forms.Padding(4)
    Me.chkmaniconf.Name = "chkmaniconf"
    Me.chkmaniconf.Size = New System.Drawing.Size(250, 17)
    Me.chkmaniconf.TabIndex = 3
    Me.chkmaniconf.Text = "Registrar manipulación información confidencial"
    Me.chkmaniconf.UseVisualStyleBackColor = True
    '
    'chkregimp
    '
    Me.chkregimp.AutoSize = True
    Me.chkregimp.Location = New System.Drawing.Point(367, 23)
    Me.chkregimp.Margin = New System.Windows.Forms.Padding(4)
    Me.chkregimp.Name = "chkregimp"
    Me.chkregimp.Size = New System.Drawing.Size(176, 17)
    Me.chkregimp.TabIndex = 2
    Me.chkregimp.Text = "Registrar impresiones realizadas"
    Me.chkregimp.UseVisualStyleBackColor = True
    '
    'chkmoddat
    '
    Me.chkmoddat.AutoSize = True
    Me.chkmoddat.Location = New System.Drawing.Point(24, 50)
    Me.chkmoddat.Margin = New System.Windows.Forms.Padding(4)
    Me.chkmoddat.Name = "chkmoddat"
    Me.chkmoddat.Size = New System.Drawing.Size(174, 17)
    Me.chkmoddat.TabIndex = 1
    Me.chkmoddat.Text = "Registrar modificación de datos"
    Me.chkmoddat.UseVisualStyleBackColor = True
    '
    'chkregentsal
    '
    Me.chkregentsal.AutoSize = True
    Me.chkregentsal.Location = New System.Drawing.Point(24, 23)
    Me.chkregentsal.Margin = New System.Windows.Forms.Padding(4)
    Me.chkregentsal.Name = "chkregentsal"
    Me.chkregentsal.Size = New System.Drawing.Size(210, 17)
    Me.chkregentsal.TabIndex = 0
    Me.chkregentsal.Text = "Registrar entradas y salidas del sistema"
    Me.chkregentsal.UseVisualStyleBackColor = True
    '
    'Panel2
    '
    Me.Panel2.Controls.Add(Me.pnlcontrasena)
    Me.Panel2.Controls.Add(Me.chkubicacion)
    Me.Panel2.Controls.Add(Me.chkempleado)
    Me.Panel2.Controls.Add(Me.CtlUbicacionActivo1)
    Me.Panel2.Controls.Add(Me.CtlBuscaEmpleado1)
    Me.Panel2.Controls.Add(Me.chkcambiocustodio)
    Me.Panel2.Controls.Add(Me.chkactivo)
    Me.Panel2.Controls.Add(Me.Label1)
    Me.Panel2.Controls.Add(Me.txtcodigo)
    Me.Panel2.Controls.Add(Me.Label2)
    Me.Panel2.Controls.Add(Me.txtdescripcion)
    Me.Panel2.Controls.Add(Me.txtmensaje)
    Me.Panel2.Controls.Add(Me.Label4)
    Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel2.Location = New System.Drawing.Point(7, 5)
    Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
    Me.Panel2.Name = "Panel2"
    Me.Panel2.Size = New System.Drawing.Size(754, 463)
    Me.Panel2.TabIndex = 0
    '
    'pnlcontrasena
    '
    Me.pnlcontrasena.Controls.Add(Me.Label3)
    Me.pnlcontrasena.Controls.Add(Me.txtcontrasena)
    Me.pnlcontrasena.Controls.Add(Me.chkcambiocontrasena)
    Me.pnlcontrasena.Controls.Add(Me.chkcambcontrpr)
    Me.pnlcontrasena.Location = New System.Drawing.Point(0, 67)
    Me.pnlcontrasena.Name = "pnlcontrasena"
    Me.pnlcontrasena.Size = New System.Drawing.Size(744, 60)
    Me.pnlcontrasena.TabIndex = 4
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(9, 9)
    Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(64, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Contraseña:"
    '
    'txtcontrasena
    '
    Me.txtcontrasena.Location = New System.Drawing.Point(177, 4)
    Me.txtcontrasena.Margin = New System.Windows.Forms.Padding(4)
    Me.txtcontrasena.Mensaje = ""
    Me.txtcontrasena.Name = "txtcontrasena"
    Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
    Me.txtcontrasena.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcontrasena.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcontrasena.PromptText = ""
    Me.txtcontrasena.Size = New System.Drawing.Size(132, 19)
    Me.txtcontrasena.TabIndex = 1
    Me.txtcontrasena.UseSystemPasswordChar = True
    '
    'chkcambiocontrasena
    '
    Me.chkcambiocontrasena.AutoSize = True
    Me.chkcambiocontrasena.Checked = True
    Me.chkcambiocontrasena.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkcambiocontrasena.Location = New System.Drawing.Point(319, 6)
    Me.chkcambiocontrasena.Margin = New System.Windows.Forms.Padding(4)
    Me.chkcambiocontrasena.Name = "chkcambiocontrasena"
    Me.chkcambiocontrasena.Size = New System.Drawing.Size(120, 17)
    Me.chkcambiocontrasena.TabIndex = 2
    Me.chkcambiocontrasena.Text = "Cambiar contraseña"
    Me.chkcambiocontrasena.UseVisualStyleBackColor = True
    '
    'chkcambcontrpr
    '
    Me.chkcambcontrpr.AutoSize = True
    Me.chkcambcontrpr.Location = New System.Drawing.Point(177, 36)
    Me.chkcambcontrpr.Margin = New System.Windows.Forms.Padding(4)
    Me.chkcambcontrpr.Name = "chkcambcontrpr"
    Me.chkcambcontrpr.Size = New System.Drawing.Size(311, 17)
    Me.chkcambcontrpr.TabIndex = 3
    Me.chkcambcontrpr.Text = "Solicitar cambio de contraseña en el próximo inicio de sesión"
    Me.chkcambcontrpr.UseVisualStyleBackColor = True
    '
    'chkubicacion
    '
    Me.chkubicacion.AutoSize = True
    Me.chkubicacion.Location = New System.Drawing.Point(13, 241)
    Me.chkubicacion.Margin = New System.Windows.Forms.Padding(4)
    Me.chkubicacion.Name = "chkubicacion"
    Me.chkubicacion.Size = New System.Drawing.Size(74, 17)
    Me.chkubicacion.TabIndex = 10
    Me.chkubicacion.Text = "Ubicación"
    Me.chkubicacion.UseVisualStyleBackColor = True
    '
    'chkempleado
    '
    Me.chkempleado.AutoSize = True
    Me.chkempleado.Location = New System.Drawing.Point(13, 178)
    Me.chkempleado.Margin = New System.Windows.Forms.Padding(4)
    Me.chkempleado.Name = "chkempleado"
    Me.chkempleado.Size = New System.Drawing.Size(73, 17)
    Me.chkempleado.TabIndex = 7
    Me.chkempleado.Text = "Empleado"
    Me.chkempleado.UseVisualStyleBackColor = True
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Enabled = False
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(177, 241)
    Me.CtlUbicacionActivo1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(537, 190)
    Me.CtlUbicacionActivo1.SoloVisibles = False
    Me.CtlUbicacionActivo1.TabIndex = 11
    '
    'CtlBuscaEmpleado1
    '
    Me.CtlBuscaEmpleado1.Empleado = Nothing
    Me.CtlBuscaEmpleado1.EmpleadoText = "Empleado"
    Me.CtlBuscaEmpleado1.Enabled = False
    Me.CtlBuscaEmpleado1.ItemText = "Empleado"
    Me.CtlBuscaEmpleado1.Location = New System.Drawing.Point(177, 178)
    Me.CtlBuscaEmpleado1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlBuscaEmpleado1.Name = "CtlBuscaEmpleado1"
    Me.CtlBuscaEmpleado1.Size = New System.Drawing.Size(701, 27)
    Me.CtlBuscaEmpleado1.SoloActivos = False
    Me.CtlBuscaEmpleado1.TabIndex = 8
    Me.CtlBuscaEmpleado1.TipoEmpleado = Nothing
    Me.CtlBuscaEmpleado1.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'chkcambiocustodio
    '
    Me.chkcambiocustodio.AutoSize = True
    Me.chkcambiocustodio.Location = New System.Drawing.Point(177, 213)
    Me.chkcambiocustodio.Margin = New System.Windows.Forms.Padding(4)
    Me.chkcambiocustodio.Name = "chkcambiocustodio"
    Me.chkcambiocustodio.Size = New System.Drawing.Size(286, 17)
    Me.chkcambiocustodio.TabIndex = 9
    Me.chkcambiocustodio.Text = "Requerir confirmación al realizar un cambio de custodio"
    Me.chkcambiocustodio.UseVisualStyleBackColor = True
    '
    'chkactivo
    '
    Me.chkactivo.AutoSize = True
    Me.chkactivo.Location = New System.Drawing.Point(177, 438)
    Me.chkactivo.Margin = New System.Windows.Forms.Padding(4)
    Me.chkactivo.Name = "chkactivo"
    Me.chkactivo.Size = New System.Drawing.Size(56, 17)
    Me.chkactivo.TabIndex = 12
    Me.chkactivo.Text = "Activo"
    Me.chkactivo.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(9, 11)
    Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(61, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Id. Usuario:"
    '
    'txtcodigo
    '
    Me.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
    Me.txtcodigo.Location = New System.Drawing.Point(177, 7)
    Me.txtcodigo.Margin = New System.Windows.Forms.Padding(4)
    Me.txtcodigo.Mensaje = ""
    Me.txtcodigo.Name = "txtcodigo"
    Me.txtcodigo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigo.PromptText = ""
    Me.txtcodigo.Size = New System.Drawing.Size(299, 19)
    Me.txtcodigo.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(9, 42)
    Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Descripción:"
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Location = New System.Drawing.Point(177, 38)
    Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(4)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(393, 19)
    Me.txtdescripcion.TabIndex = 3
    '
    'txtmensaje
    '
    Me.txtmensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtmensaje.Location = New System.Drawing.Point(177, 128)
    Me.txtmensaje.Margin = New System.Windows.Forms.Padding(4)
    Me.txtmensaje.Mensaje = ""
    Me.txtmensaje.Multiline = True
    Me.txtmensaje.Name = "txtmensaje"
    Me.txtmensaje.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtmensaje.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtmensaje.PromptText = ""
    Me.txtmensaje.Size = New System.Drawing.Size(567, 42)
    Me.txtmensaje.TabIndex = 6
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(9, 132)
    Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(50, 13)
    Me.Label4.TabIndex = 5
    Me.Label4.Text = "Mensaje:"
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.Panel1)
    Me.Panel4.Location = New System.Drawing.Point(0, 52)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(779, 768)
    Me.Panel4.TabIndex = 4
    '
    'FrmMantenimientoUsuario
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScroll = True
    Me.ClientSize = New System.Drawing.Size(783, 826)
    Me.Controls.Add(Me.Panel4)
    Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Margin = New System.Windows.Forms.Padding(5)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "FrmMantenimientoUsuario"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel4, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    CType(Me.CtlRestricciones1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel3.ResumeLayout(False)
    Me.Panel3.PerformLayout()
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.Panel2.ResumeLayout(False)
    Me.Panel2.PerformLayout()
    Me.pnlcontrasena.ResumeLayout(False)
    Me.pnlcontrasena.PerformLayout()
    Me.Panel4.ResumeLayout(False)
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
  Friend WithEvents pnlcontrasena As Panel
  Friend WithEvents Panel4 As Panel
End Class
