<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoParametroDet
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
    Me.components = New System.ComponentModel.Container()
    Me.Panel1 = New System.Windows.Forms.Panel()
    Me.pnldatoleyenda = New System.Windows.Forms.Panel()
    Me.txt_datoleyenda = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datoleyenda = New System.Windows.Forms.Label()
    Me.pnldatoimg = New System.Windows.Forms.Panel()
    Me.PictureBox1 = New Infoware.Controles.Base.ImagenSQL()
    Me.lbl_datoimg1 = New System.Windows.Forms.Label()
    Me.pnldatoint = New System.Windows.Forms.Panel()
    Me.txtdatoint1 = New Infoware.Controles.Base.TextBoxCalculator()
    Me.lbl_datoint1 = New System.Windows.Forms.Label()
    Me.pnlctactble2 = New System.Windows.Forms.Panel()
    Me.txtctactble2 = New Infoware.Controles.Base.TextBoxStd()
    Me.lblctactble2 = New System.Windows.Forms.Label()
    Me.pnlctactble1 = New System.Windows.Forms.Panel()
    Me.txtctactble1 = New Infoware.Controles.Base.TextBoxStd()
    Me.lblctactble1 = New System.Windows.Forms.Label()
    Me.pnldatostr3 = New System.Windows.Forms.Panel()
    Me.txt_datostr3 = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datostr3 = New System.Windows.Forms.Label()
    Me.pnldatostr2 = New System.Windows.Forms.Panel()
    Me.txt_datostr2 = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datostr2 = New System.Windows.Forms.Label()
    Me.pnldatostr1 = New System.Windows.Forms.Panel()
    Me.txt_datostr1 = New Infoware.Controles.Base.TextBoxStd()
    Me.lbl_datostr1 = New System.Windows.Forms.Label()
    Me.pnldescripcion = New System.Windows.Forms.Panel()
    Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.pnlpadre = New System.Windows.Forms.Panel()
    Me.ComboBoxParametroDet1 = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.lbl_parametro = New System.Windows.Forms.Label()
    Me.pnldatobit = New System.Windows.Forms.Panel()
    Me.txtdatobit1 = New System.Windows.Forms.CheckBox()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.pnldatoleyenda.SuspendLayout()
    Me.pnldatoimg.SuspendLayout()
    Me.pnldatoint.SuspendLayout()
    Me.pnlctactble2.SuspendLayout()
    Me.pnlctactble1.SuspendLayout()
    Me.pnldatostr3.SuspendLayout()
    Me.pnldatostr2.SuspendLayout()
    Me.pnldatostr1.SuspendLayout()
    Me.pnldescripcion.SuspendLayout()
    Me.pnlpadre.SuspendLayout()
    Me.pnldatobit.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnldatobit)
    Me.Panel1.Controls.Add(Me.pnldatoleyenda)
    Me.Panel1.Controls.Add(Me.pnldatoimg)
    Me.Panel1.Controls.Add(Me.pnldatoint)
    Me.Panel1.Controls.Add(Me.pnlctactble2)
    Me.Panel1.Controls.Add(Me.pnlctactble1)
    Me.Panel1.Controls.Add(Me.pnldatostr3)
    Me.Panel1.Controls.Add(Me.pnldatostr2)
    Me.Panel1.Controls.Add(Me.pnldatostr1)
    Me.Panel1.Controls.Add(Me.pnldescripcion)
    Me.Panel1.Controls.Add(Me.pnlpadre)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
    Me.Panel1.Size = New System.Drawing.Size(475, 474)
    Me.Panel1.TabIndex = 0
    '
    'pnldatoleyenda
    '
    Me.pnldatoleyenda.Controls.Add(Me.txt_datoleyenda)
    Me.pnldatoleyenda.Controls.Add(Me.lbl_datoleyenda)
    Me.pnldatoleyenda.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoleyenda.Location = New System.Drawing.Point(0, 329)
    Me.pnldatoleyenda.Name = "pnldatoleyenda"
    Me.pnldatoleyenda.Size = New System.Drawing.Size(475, 78)
    Me.pnldatoleyenda.TabIndex = 9
    Me.pnldatoleyenda.Visible = False
    '
    'txt_datoleyenda
    '
    Me.txt_datoleyenda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datoleyenda.Location = New System.Drawing.Point(139, 3)
    Me.txt_datoleyenda.Mensaje = ""
    Me.txt_datoleyenda.Multiline = True
    Me.txt_datoleyenda.Name = "txt_datoleyenda"
    Me.txt_datoleyenda.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datoleyenda.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datoleyenda.PromptText = ""
    Me.txt_datoleyenda.Size = New System.Drawing.Size(324, 72)
    Me.txt_datoleyenda.TabIndex = 1
    '
    'lbl_datoleyenda
    '
    Me.lbl_datoleyenda.AutoSize = True
    Me.lbl_datoleyenda.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoleyenda.Name = "lbl_datoleyenda"
    Me.lbl_datoleyenda.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoleyenda.TabIndex = 0
    Me.lbl_datoleyenda.Text = "Descripción:"
    '
    'pnldatoimg
    '
    Me.pnldatoimg.Controls.Add(Me.PictureBox1)
    Me.pnldatoimg.Controls.Add(Me.lbl_datoimg1)
    Me.pnldatoimg.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoimg.Location = New System.Drawing.Point(0, 211)
    Me.pnldatoimg.Name = "pnldatoimg"
    Me.pnldatoimg.Size = New System.Drawing.Size(475, 118)
    Me.pnldatoimg.TabIndex = 8
    Me.pnldatoimg.Visible = False
    '
    'PictureBox1
    '
    Me.PictureBox1.ArchivoImagen = Nothing
    Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
    Me.PictureBox1.Imagen = Nothing
    Me.PictureBox1.Location = New System.Drawing.Point(139, 4)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Padding = New System.Windows.Forms.Padding(3)
    Me.PictureBox1.Size = New System.Drawing.Size(116, 105)
    Me.PictureBox1.TabIndex = 1
    Me.PictureBox1.TabStop = False
    '
    'lbl_datoimg1
    '
    Me.lbl_datoimg1.AutoSize = True
    Me.lbl_datoimg1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoimg1.Name = "lbl_datoimg1"
    Me.lbl_datoimg1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoimg1.TabIndex = 0
    Me.lbl_datoimg1.Text = "Descripción:"
    '
    'pnldatoint
    '
    Me.pnldatoint.Controls.Add(Me.txtdatoint1)
    Me.pnldatoint.Controls.Add(Me.lbl_datoint1)
    Me.pnldatoint.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatoint.Location = New System.Drawing.Point(0, 186)
    Me.pnldatoint.Name = "pnldatoint"
    Me.pnldatoint.Size = New System.Drawing.Size(475, 25)
    Me.pnldatoint.TabIndex = 7
    Me.pnldatoint.Visible = False
    '
    'txtdatoint1
    '
    Me.txtdatoint1.Location = New System.Drawing.Point(139, 3)
    Me.txtdatoint1.Mensaje = ""
    Me.txtdatoint1.Name = "txtdatoint1"
    Me.txtdatoint1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdatoint1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdatoint1.PromptText = ""
    Me.txtdatoint1.Size = New System.Drawing.Size(66, 20)
    Me.txtdatoint1.TabIndex = 1
    Me.txtdatoint1.Text = "0"
    Me.txtdatoint1.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Entero
    Me.txtdatoint1.Value = 0.0R
    '
    'lbl_datoint1
    '
    Me.lbl_datoint1.AutoSize = True
    Me.lbl_datoint1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datoint1.Name = "lbl_datoint1"
    Me.lbl_datoint1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datoint1.TabIndex = 0
    Me.lbl_datoint1.Text = "Descripción:"
    '
    'pnlctactble2
    '
    Me.pnlctactble2.Controls.Add(Me.txtctactble2)
    Me.pnlctactble2.Controls.Add(Me.lblctactble2)
    Me.pnlctactble2.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlctactble2.Location = New System.Drawing.Point(0, 162)
    Me.pnlctactble2.Name = "pnlctactble2"
    Me.pnlctactble2.Size = New System.Drawing.Size(475, 24)
    Me.pnlctactble2.TabIndex = 6
    '
    'txtctactble2
    '
    Me.txtctactble2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtctactble2.Location = New System.Drawing.Point(139, 2)
    Me.txtctactble2.Mensaje = ""
    Me.txtctactble2.Name = "txtctactble2"
    Me.txtctactble2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtctactble2.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtctactble2.PromptText = ""
    Me.txtctactble2.Size = New System.Drawing.Size(324, 20)
    Me.txtctactble2.TabIndex = 1
    '
    'lblctactble2
    '
    Me.lblctactble2.AutoSize = True
    Me.lblctactble2.Location = New System.Drawing.Point(12, 4)
    Me.lblctactble2.Name = "lblctactble2"
    Me.lblctactble2.Size = New System.Drawing.Size(66, 13)
    Me.lblctactble2.TabIndex = 0
    Me.lblctactble2.Text = "Descripción:"
    '
    'pnlctactble1
    '
    Me.pnlctactble1.Controls.Add(Me.txtctactble1)
    Me.pnlctactble1.Controls.Add(Me.lblctactble1)
    Me.pnlctactble1.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlctactble1.Location = New System.Drawing.Point(0, 138)
    Me.pnlctactble1.Name = "pnlctactble1"
    Me.pnlctactble1.Size = New System.Drawing.Size(475, 24)
    Me.pnlctactble1.TabIndex = 5
    '
    'txtctactble1
    '
    Me.txtctactble1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtctactble1.Location = New System.Drawing.Point(139, 2)
    Me.txtctactble1.Mensaje = ""
    Me.txtctactble1.Name = "txtctactble1"
    Me.txtctactble1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtctactble1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtctactble1.PromptText = ""
    Me.txtctactble1.Size = New System.Drawing.Size(324, 20)
    Me.txtctactble1.TabIndex = 1
    '
    'lblctactble1
    '
    Me.lblctactble1.AutoSize = True
    Me.lblctactble1.Location = New System.Drawing.Point(12, 4)
    Me.lblctactble1.Name = "lblctactble1"
    Me.lblctactble1.Size = New System.Drawing.Size(66, 13)
    Me.lblctactble1.TabIndex = 0
    Me.lblctactble1.Text = "Descripción:"
    '
    'pnldatostr3
    '
    Me.pnldatostr3.Controls.Add(Me.txt_datostr3)
    Me.pnldatostr3.Controls.Add(Me.lbl_datostr3)
    Me.pnldatostr3.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr3.Location = New System.Drawing.Point(0, 113)
    Me.pnldatostr3.Name = "pnldatostr3"
    Me.pnldatostr3.Size = New System.Drawing.Size(475, 25)
    Me.pnldatostr3.TabIndex = 4
    Me.pnldatostr3.Visible = False
    '
    'txt_datostr3
    '
    Me.txt_datostr3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr3.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr3.Mensaje = ""
    Me.txt_datostr3.Name = "txt_datostr3"
    Me.txt_datostr3.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr3.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr3.PromptText = ""
    Me.txt_datostr3.Size = New System.Drawing.Size(324, 20)
    Me.txt_datostr3.TabIndex = 1
    '
    'lbl_datostr3
    '
    Me.lbl_datostr3.AutoSize = True
    Me.lbl_datostr3.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr3.Name = "lbl_datostr3"
    Me.lbl_datostr3.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr3.TabIndex = 0
    Me.lbl_datostr3.Text = "Descripción:"
    '
    'pnldatostr2
    '
    Me.pnldatostr2.Controls.Add(Me.txt_datostr2)
    Me.pnldatostr2.Controls.Add(Me.lbl_datostr2)
    Me.pnldatostr2.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr2.Location = New System.Drawing.Point(0, 88)
    Me.pnldatostr2.Name = "pnldatostr2"
    Me.pnldatostr2.Size = New System.Drawing.Size(475, 25)
    Me.pnldatostr2.TabIndex = 3
    Me.pnldatostr2.Visible = False
    '
    'txt_datostr2
    '
    Me.txt_datostr2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr2.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr2.Mensaje = ""
    Me.txt_datostr2.Name = "txt_datostr2"
    Me.txt_datostr2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr2.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr2.PromptText = ""
    Me.txt_datostr2.Size = New System.Drawing.Size(324, 20)
    Me.txt_datostr2.TabIndex = 1
    '
    'lbl_datostr2
    '
    Me.lbl_datostr2.AutoSize = True
    Me.lbl_datostr2.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr2.Name = "lbl_datostr2"
    Me.lbl_datostr2.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr2.TabIndex = 0
    Me.lbl_datostr2.Text = "Descripción:"
    '
    'pnldatostr1
    '
    Me.pnldatostr1.Controls.Add(Me.txt_datostr1)
    Me.pnldatostr1.Controls.Add(Me.lbl_datostr1)
    Me.pnldatostr1.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatostr1.Location = New System.Drawing.Point(0, 63)
    Me.pnldatostr1.Name = "pnldatostr1"
    Me.pnldatostr1.Size = New System.Drawing.Size(475, 25)
    Me.pnldatostr1.TabIndex = 2
    Me.pnldatostr1.Visible = False
    '
    'txt_datostr1
    '
    Me.txt_datostr1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txt_datostr1.Location = New System.Drawing.Point(139, 3)
    Me.txt_datostr1.Mensaje = ""
    Me.txt_datostr1.Name = "txt_datostr1"
    Me.txt_datostr1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txt_datostr1.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txt_datostr1.PromptText = ""
    Me.txt_datostr1.Size = New System.Drawing.Size(324, 20)
    Me.txt_datostr1.TabIndex = 1
    '
    'lbl_datostr1
    '
    Me.lbl_datostr1.AutoSize = True
    Me.lbl_datostr1.Location = New System.Drawing.Point(12, 6)
    Me.lbl_datostr1.Name = "lbl_datostr1"
    Me.lbl_datostr1.Size = New System.Drawing.Size(66, 13)
    Me.lbl_datostr1.TabIndex = 0
    Me.lbl_datostr1.Text = "Descripción:"
    '
    'pnldescripcion
    '
    Me.pnldescripcion.Controls.Add(Me.txtdescripcion)
    Me.pnldescripcion.Controls.Add(Me.Label2)
    Me.pnldescripcion.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldescripcion.Location = New System.Drawing.Point(0, 38)
    Me.pnldescripcion.Name = "pnldescripcion"
    Me.pnldescripcion.Size = New System.Drawing.Size(475, 25)
    Me.pnldescripcion.TabIndex = 1
    '
    'txtdescripcion
    '
    Me.txtdescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtdescripcion.Location = New System.Drawing.Point(139, 3)
    Me.txtdescripcion.Mensaje = ""
    Me.txtdescripcion.Name = "txtdescripcion"
    Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtdescripcion.PromptText = ""
    Me.txtdescripcion.Size = New System.Drawing.Size(324, 20)
    Me.txtdescripcion.TabIndex = 1
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(12, 6)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(66, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "Descripción:"
    '
    'pnlpadre
    '
    Me.pnlpadre.Controls.Add(Me.ComboBoxParametroDet1)
    Me.pnlpadre.Controls.Add(Me.lbl_parametro)
    Me.pnlpadre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlpadre.Location = New System.Drawing.Point(0, 10)
    Me.pnlpadre.Name = "pnlpadre"
    Me.pnlpadre.Size = New System.Drawing.Size(475, 28)
    Me.pnlpadre.TabIndex = 0
    Me.pnlpadre.Visible = False
    '
    'ComboBoxParametroDet1
    '
    Me.ComboBoxParametroDet1.AbriralEntrar = False
    Me.ComboBoxParametroDet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxParametroDet1.FormattingEnabled = True
    Me.ComboBoxParametroDet1.Location = New System.Drawing.Point(139, 3)
    Me.ComboBoxParametroDet1.MostrarRutaCompleta = False
    Me.ComboBoxParametroDet1.Name = "ComboBoxParametroDet1"
    Me.ComboBoxParametroDet1.OperadorDatos = Nothing
    Me.ComboBoxParametroDet1.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxParametroDet1.ParametroDet = Nothing
    Me.ComboBoxParametroDet1.PuedeActualizar = True
    Me.ComboBoxParametroDet1.PuedeEliminar = True
    Me.ComboBoxParametroDet1.PuedeModificar = True
    Me.ComboBoxParametroDet1.PuedeNuevo = True
    Me.ComboBoxParametroDet1.Size = New System.Drawing.Size(207, 21)
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
    'pnldatobit
    '
    Me.pnldatobit.Controls.Add(Me.txtdatobit1)
    Me.pnldatobit.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnldatobit.Location = New System.Drawing.Point(0, 407)
    Me.pnldatobit.Name = "pnldatobit"
    Me.pnldatobit.Size = New System.Drawing.Size(475, 25)
    Me.pnldatobit.TabIndex = 10
    Me.pnldatobit.Visible = False
    '
    'txtdatobit1
    '
    Me.txtdatobit1.AutoSize = True
    Me.txtdatobit1.Location = New System.Drawing.Point(139, 5)
    Me.txtdatobit1.Name = "txtdatobit1"
    Me.txtdatobit1.Size = New System.Drawing.Size(81, 17)
    Me.txtdatobit1.TabIndex = 1
    Me.txtdatobit1.Text = "CheckBox1"
    Me.txtdatobit1.UseVisualStyleBackColor = True
    '
    'FrmMantenimientoParametroDet
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(475, 523)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoParametroDet"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.pnldatoleyenda.ResumeLayout(False)
    Me.pnldatoleyenda.PerformLayout()
    Me.pnldatoimg.ResumeLayout(False)
    Me.pnldatoimg.PerformLayout()
    Me.pnldatoint.ResumeLayout(False)
    Me.pnldatoint.PerformLayout()
    Me.pnlctactble2.ResumeLayout(False)
    Me.pnlctactble2.PerformLayout()
    Me.pnlctactble1.ResumeLayout(False)
    Me.pnlctactble1.PerformLayout()
    Me.pnldatostr3.ResumeLayout(False)
    Me.pnldatostr3.PerformLayout()
    Me.pnldatostr2.ResumeLayout(False)
    Me.pnldatostr2.PerformLayout()
    Me.pnldatostr1.ResumeLayout(False)
    Me.pnldatostr1.PerformLayout()
    Me.pnldescripcion.ResumeLayout(False)
    Me.pnldescripcion.PerformLayout()
    Me.pnlpadre.ResumeLayout(False)
    Me.pnlpadre.PerformLayout()
    Me.pnldatobit.ResumeLayout(False)
    Me.pnldatobit.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents pnlctactble1 As System.Windows.Forms.Panel
  Friend WithEvents lblctactble1 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr1 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr1 As System.Windows.Forms.Label
  Friend WithEvents txtctactble1 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents pnldatoint As System.Windows.Forms.Panel
  Friend WithEvents txtdatoint1 As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents lbl_datoint1 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr2 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr2 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr2 As System.Windows.Forms.Label
  Friend WithEvents pnldatostr3 As System.Windows.Forms.Panel
  Friend WithEvents txt_datostr3 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datostr3 As System.Windows.Forms.Label
  Friend WithEvents pnldatoimg As System.Windows.Forms.Panel
  Friend WithEvents lbl_datoimg1 As System.Windows.Forms.Label
  Friend WithEvents PictureBox1 As Infoware.Controles.Base.ImagenSQL
  Friend WithEvents pnldatoleyenda As System.Windows.Forms.Panel
  Friend WithEvents txt_datoleyenda As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lbl_datoleyenda As System.Windows.Forms.Label
  Friend WithEvents pnlpadre As System.Windows.Forms.Panel
  Friend WithEvents ComboBoxParametroDet1 As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents lbl_parametro As System.Windows.Forms.Label
  Friend WithEvents pnldescripcion As System.Windows.Forms.Panel
  Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents pnlctactble2 As System.Windows.Forms.Panel
  Friend WithEvents txtctactble2 As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents lblctactble2 As System.Windows.Forms.Label
  Friend WithEvents pnldatobit As System.Windows.Forms.Panel
  Friend WithEvents txtdatobit1 As System.Windows.Forms.CheckBox

End Class
