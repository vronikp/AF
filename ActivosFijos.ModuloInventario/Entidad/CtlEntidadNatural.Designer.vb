Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEntidadNatural
  Inherits System.Windows.Forms.UserControl

  'UserControl overrides dispose to clean up the component list.
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
    Dim Entnat_NombresLabel As System.Windows.Forms.Label
    Dim Pardet_EstadocivilLabel As System.Windows.Forms.Label
    Dim Entnat_FechanacimientoLabel As System.Windows.Forms.Label
    Dim Pardet_SexoLabel As System.Windows.Forms.Label
    Dim Entnat_ApellidomaternoLabel As System.Windows.Forms.Label
    Dim Entnat_ApellidopaternoLabel As System.Windows.Forms.Label
    Me.EntidadNaturalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.grpsri = New Infoware.Controles.Base.TaskBoxStd()
    Me.mskcaducret = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.mskcaducnotvta = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.mskcaducfactura = New Infoware.Controles.Base.MaskedTextBoxStd()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.txtautoret = New Infoware.Controles.Base.TextBoxStd()
    Me.txtautonotvta = New Infoware.Controles.Base.TextBoxStd()
    Me.txtautofactura = New Infoware.Controles.Base.TextBoxStd()
    Me.GroupBox4 = New Infoware.Controles.Base.TaskBoxStd()
    Me.GroupBox3 = New Infoware.Controles.Base.TaskBoxStd()
    Me.TaskBoxStd2 = New Infoware.Controles.Base.TaskBoxStd()
    Me.TaskBoxStd1 = New Infoware.Controles.Base.TaskBoxStd()
    Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
    Me.Entnat_ApellidopaternoTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.Entnat_FechanacimientoDateTimePicker = New Infoware.Controles.Base.DateTimePickerStd()
    Me.Entnat_ApellidomaternoTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.Entnat_NombresTextBox = New Infoware.Controles.Base.TextBoxStd()
    Me.pnlcuerpo = New System.Windows.Forms.FlowLayoutPanel()
    Me.ComboBoxSexo = New ComboBoxParametroDet()
    Me.ComboBoxEstadoCivil = New ComboBoxParametroDet()
    Me.CtlDireccion1 = New CtlDireccion()
    Me.CtlTelefono1 = New CtlTelefono()
    Me.CtlTelefono2 = New CtlTelefono()
    Me.CtlTelefono3 = New CtlTelefono()
    Me.CtlIdentificacion5 = New CtlIdentificacion()
    Me.CtlIdentificacion4 = New CtlIdentificacion()
    Me.CtlIdentificacion3 = New CtlIdentificacion()
    Me.CtlIdentificacion2 = New CtlIdentificacion()
    Me.CtlIdentificacion1 = New CtlIdentificacion()
    Me.CtlEmail2 = New CtlEmail()
    Me.CtlEmail1 = New CtlEmail()
    Entnat_NombresLabel = New System.Windows.Forms.Label()
    Pardet_EstadocivilLabel = New System.Windows.Forms.Label()
    Entnat_FechanacimientoLabel = New System.Windows.Forms.Label()
    Pardet_SexoLabel = New System.Windows.Forms.Label()
    Entnat_ApellidomaternoLabel = New System.Windows.Forms.Label()
    Entnat_ApellidopaternoLabel = New System.Windows.Forms.Label()
    CType(Me.EntidadNaturalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.grpsri.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.TaskBoxStd2.SuspendLayout()
    Me.TaskBoxStd1.SuspendLayout()
    Me.TableLayoutPanel3.SuspendLayout()
    Me.pnlcuerpo.SuspendLayout()
    Me.SuspendLayout()
    '
    'Entnat_NombresLabel
    '
    Entnat_NombresLabel.AutoSize = True
    Entnat_NombresLabel.Location = New System.Drawing.Point(3, 44)
    Entnat_NombresLabel.Name = "Entnat_NombresLabel"
    Entnat_NombresLabel.Size = New System.Drawing.Size(52, 13)
    Entnat_NombresLabel.TabIndex = 4
    Entnat_NombresLabel.Text = "Nombres:"
    '
    'Pardet_EstadocivilLabel
    '
    Pardet_EstadocivilLabel.AutoSize = True
    Pardet_EstadocivilLabel.Location = New System.Drawing.Point(3, 88)
    Pardet_EstadocivilLabel.Name = "Pardet_EstadocivilLabel"
    Pardet_EstadocivilLabel.Size = New System.Drawing.Size(64, 13)
    Pardet_EstadocivilLabel.TabIndex = 8
    Pardet_EstadocivilLabel.Text = "Estado civil:"
    '
    'Entnat_FechanacimientoLabel
    '
    Entnat_FechanacimientoLabel.AutoSize = True
    Entnat_FechanacimientoLabel.Location = New System.Drawing.Point(3, 66)
    Entnat_FechanacimientoLabel.Name = "Entnat_FechanacimientoLabel"
    Entnat_FechanacimientoLabel.Size = New System.Drawing.Size(109, 13)
    Entnat_FechanacimientoLabel.TabIndex = 6
    Entnat_FechanacimientoLabel.Text = "Fecha de nacimiento:"
    '
    'Pardet_SexoLabel
    '
    Pardet_SexoLabel.AutoSize = True
    Pardet_SexoLabel.Location = New System.Drawing.Point(3, 113)
    Pardet_SexoLabel.Name = "Pardet_SexoLabel"
    Pardet_SexoLabel.Size = New System.Drawing.Size(45, 13)
    Pardet_SexoLabel.TabIndex = 10
    Pardet_SexoLabel.Text = "Genero:"
    '
    'Entnat_ApellidomaternoLabel
    '
    Entnat_ApellidomaternoLabel.AutoSize = True
    Entnat_ApellidomaternoLabel.Location = New System.Drawing.Point(3, 22)
    Entnat_ApellidomaternoLabel.Name = "Entnat_ApellidomaternoLabel"
    Entnat_ApellidomaternoLabel.Size = New System.Drawing.Size(88, 13)
    Entnat_ApellidomaternoLabel.TabIndex = 2
    Entnat_ApellidomaternoLabel.Text = "Apellido materno:"
    '
    'Entnat_ApellidopaternoLabel
    '
    Entnat_ApellidopaternoLabel.AutoSize = True
    Entnat_ApellidopaternoLabel.Location = New System.Drawing.Point(3, 0)
    Entnat_ApellidopaternoLabel.Name = "Entnat_ApellidopaternoLabel"
    Entnat_ApellidopaternoLabel.Size = New System.Drawing.Size(86, 13)
    Entnat_ApellidopaternoLabel.TabIndex = 0
    Entnat_ApellidopaternoLabel.Text = "Apellido paterno:"
    '
    'EntidadNaturalBindingSource
    '
    Me.EntidadNaturalBindingSource.DataSource = GetType(EntidadNatural)
    '
    'grpsri
    '
    Me.grpsri.BackColor = System.Drawing.Color.Transparent
    Me.grpsri.Controls.Add(Me.mskcaducret)
    Me.grpsri.Controls.Add(Me.mskcaducnotvta)
    Me.grpsri.Controls.Add(Me.mskcaducfactura)
    Me.grpsri.Controls.Add(Me.Label3)
    Me.grpsri.Controls.Add(Me.Label6)
    Me.grpsri.Controls.Add(Me.Label2)
    Me.grpsri.Controls.Add(Me.Label5)
    Me.grpsri.Controls.Add(Me.Label4)
    Me.grpsri.Controls.Add(Me.Label7)
    Me.grpsri.Controls.Add(Me.txtautoret)
    Me.grpsri.Controls.Add(Me.txtautonotvta)
    Me.grpsri.Controls.Add(Me.txtautofactura)
    Me.grpsri.HeaderText = "Datos del SRI"
    Me.grpsri.IsModoMini = True
    Me.grpsri.Location = New System.Drawing.Point(311, 252)
    Me.grpsri.Name = "grpsri"
    Me.grpsri.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.grpsri.Size = New System.Drawing.Size(302, 177)
    Me.grpsri.TabIndex = 2
    Me.grpsri.Visible = False
    '
    'mskcaducret
    '
    Me.mskcaducret.Location = New System.Drawing.Point(165, 154)
    Me.mskcaducret.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducret.Mask = "00/0000"
    Me.mskcaducret.Name = "mskcaducret"
    Me.mskcaducret.Size = New System.Drawing.Size(55, 20)
    Me.mskcaducret.TabIndex = 11
    '
    'mskcaducnotvta
    '
    Me.mskcaducnotvta.Location = New System.Drawing.Point(165, 106)
    Me.mskcaducnotvta.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducnotvta.Mask = "00/0000"
    Me.mskcaducnotvta.Name = "mskcaducnotvta"
    Me.mskcaducnotvta.Size = New System.Drawing.Size(55, 20)
    Me.mskcaducnotvta.TabIndex = 7
    '
    'mskcaducfactura
    '
    Me.mskcaducfactura.Location = New System.Drawing.Point(165, 58)
    Me.mskcaducfactura.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducfactura.Mask = "00/0000"
    Me.mskcaducfactura.Name = "mskcaducfactura"
    Me.mskcaducfactura.Size = New System.Drawing.Size(55, 20)
    Me.mskcaducfactura.TabIndex = 3
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(7, 133)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(131, 13)
    Me.Label3.TabIndex = 8
    Me.Label3.Text = "Autorización Retenciones:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(7, 157)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(62, 13)
    Me.Label6.TabIndex = 10
    Me.Label6.Text = "Caduca en:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 85)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(140, 13)
    Me.Label2.TabIndex = 4
    Me.Label2.Text = "Autorización Nota de Venta:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(7, 109)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(62, 13)
    Me.Label5.TabIndex = 6
    Me.Label5.Text = "Caduca en:"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(7, 61)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(62, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Caduca en:"
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(7, 37)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(112, 13)
    Me.Label7.TabIndex = 0
    Me.Label7.Text = "Autorización Facturas:"
    '
    'txtautoret
    '
    Me.txtautoret.Location = New System.Drawing.Point(165, 130)
    Me.txtautoret.Margin = New System.Windows.Forms.Padding(2)
    Me.txtautoret.Mensaje = ""
    Me.txtautoret.Name = "txtautoret"
    Me.txtautoret.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautoret.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautoret.PromptText = ""
    Me.txtautoret.Size = New System.Drawing.Size(102, 20)
    Me.txtautoret.TabIndex = 9
    Me.txtautoret.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtautonotvta
    '
    Me.txtautonotvta.Location = New System.Drawing.Point(165, 82)
    Me.txtautonotvta.Margin = New System.Windows.Forms.Padding(2)
    Me.txtautonotvta.Mensaje = ""
    Me.txtautonotvta.Name = "txtautonotvta"
    Me.txtautonotvta.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautonotvta.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautonotvta.PromptText = ""
    Me.txtautonotvta.Size = New System.Drawing.Size(102, 20)
    Me.txtautonotvta.TabIndex = 5
    Me.txtautonotvta.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'txtautofactura
    '
    Me.txtautofactura.Location = New System.Drawing.Point(165, 34)
    Me.txtautofactura.Margin = New System.Windows.Forms.Padding(2)
    Me.txtautofactura.Mensaje = ""
    Me.txtautofactura.Name = "txtautofactura"
    Me.txtautofactura.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtautofactura.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtautofactura.PromptText = ""
    Me.txtautofactura.Size = New System.Drawing.Size(102, 20)
    Me.txtautofactura.TabIndex = 1
    Me.txtautofactura.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'GroupBox4
    '
    Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion5)
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion4)
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion3)
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion2)
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion1)
    Me.GroupBox4.HeaderText = "Identificaciones"
    Me.GroupBox4.IsModoMini = True
    Me.GroupBox4.Location = New System.Drawing.Point(311, 3)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox4.Size = New System.Drawing.Size(302, 154)
    Me.GroupBox4.TabIndex = 1
    '
    'GroupBox3
    '
    Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox3.Controls.Add(Me.CtlEmail2)
    Me.GroupBox3.Controls.Add(Me.CtlEmail1)
    Me.GroupBox3.HeaderText = "Emails"
    Me.GroupBox3.IsModoMini = True
    Me.GroupBox3.Location = New System.Drawing.Point(311, 163)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox3.Size = New System.Drawing.Size(302, 83)
    Me.GroupBox3.TabIndex = 0
    '
    'TaskBoxStd2
    '
    Me.TaskBoxStd2.BackColor = System.Drawing.Color.Transparent
    Me.TaskBoxStd2.Controls.Add(Me.CtlTelefono1)
    Me.TaskBoxStd2.Controls.Add(Me.CtlTelefono2)
    Me.TaskBoxStd2.Controls.Add(Me.CtlTelefono3)
    Me.TaskBoxStd2.HeaderText = "Teléfonos"
    Me.TaskBoxStd2.IsModoMini = True
    Me.TaskBoxStd2.Location = New System.Drawing.Point(3, 265)
    Me.TaskBoxStd2.Name = "TaskBoxStd2"
    Me.TaskBoxStd2.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.TaskBoxStd2.Size = New System.Drawing.Size(302, 105)
    Me.TaskBoxStd2.TabIndex = 2
    '
    'TaskBoxStd1
    '
    Me.TaskBoxStd1.BackColor = System.Drawing.Color.Transparent
    Me.TaskBoxStd1.Controls.Add(Me.CtlDireccion1)
    Me.TaskBoxStd1.HeaderText = "Direcciones"
    Me.TaskBoxStd1.IsModoMini = True
    Me.TaskBoxStd1.Location = New System.Drawing.Point(3, 149)
    Me.TaskBoxStd1.Name = "TaskBoxStd1"
    Me.TaskBoxStd1.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.TaskBoxStd1.Size = New System.Drawing.Size(302, 110)
    Me.TaskBoxStd1.TabIndex = 1
    '
    'TableLayoutPanel3
    '
    Me.TableLayoutPanel3.ColumnCount = 2
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.46575!))
    Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.53425!))
    Me.TableLayoutPanel3.Controls.Add(Entnat_ApellidopaternoLabel, 0, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxSexo, 1, 5)
    Me.TableLayoutPanel3.Controls.Add(Me.Entnat_ApellidopaternoTextBox, 1, 0)
    Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxEstadoCivil, 1, 4)
    Me.TableLayoutPanel3.Controls.Add(Entnat_ApellidomaternoLabel, 0, 1)
    Me.TableLayoutPanel3.Controls.Add(Me.Entnat_FechanacimientoDateTimePicker, 1, 3)
    Me.TableLayoutPanel3.Controls.Add(Pardet_SexoLabel, 0, 5)
    Me.TableLayoutPanel3.Controls.Add(Entnat_FechanacimientoLabel, 0, 3)
    Me.TableLayoutPanel3.Controls.Add(Me.Entnat_ApellidomaternoTextBox, 1, 1)
    Me.TableLayoutPanel3.Controls.Add(Pardet_EstadocivilLabel, 0, 4)
    Me.TableLayoutPanel3.Controls.Add(Entnat_NombresLabel, 0, 2)
    Me.TableLayoutPanel3.Controls.Add(Me.Entnat_NombresTextBox, 1, 2)
    Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 1)
    Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(1)
    Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
    Me.TableLayoutPanel3.RowCount = 7
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
    Me.TableLayoutPanel3.Size = New System.Drawing.Size(304, 144)
    Me.TableLayoutPanel3.TabIndex = 0
    '
    'Entnat_ApellidopaternoTextBox
    '
    Me.Entnat_ApellidopaternoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entnat_ApellidopaternoTextBox.BackColor = System.Drawing.SystemColors.Window
    Me.Entnat_ApellidopaternoTextBox.Location = New System.Drawing.Point(130, 1)
    Me.Entnat_ApellidopaternoTextBox.Margin = New System.Windows.Forms.Padding(1)
    Me.Entnat_ApellidopaternoTextBox.Mensaje = ""
    Me.Entnat_ApellidopaternoTextBox.Name = "Entnat_ApellidopaternoTextBox"
    Me.Entnat_ApellidopaternoTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entnat_ApellidopaternoTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Entnat_ApellidopaternoTextBox.PromptText = ""
    Me.Entnat_ApellidopaternoTextBox.Size = New System.Drawing.Size(173, 20)
    Me.Entnat_ApellidopaternoTextBox.TabIndex = 1
    Me.Entnat_ApellidopaternoTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Entnat_FechanacimientoDateTimePicker
    '
    Me.Entnat_FechanacimientoDateTimePicker.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entnat_FechanacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.Entnat_FechanacimientoDateTimePicker.Location = New System.Drawing.Point(130, 67)
    Me.Entnat_FechanacimientoDateTimePicker.Margin = New System.Windows.Forms.Padding(1)
    Me.Entnat_FechanacimientoDateTimePicker.Name = "Entnat_FechanacimientoDateTimePicker"
    Me.Entnat_FechanacimientoDateTimePicker.ShowCheckBox = True
    Me.Entnat_FechanacimientoDateTimePicker.Size = New System.Drawing.Size(173, 20)
    Me.Entnat_FechanacimientoDateTimePicker.TabIndex = 7
    '
    'Entnat_ApellidomaternoTextBox
    '
    Me.Entnat_ApellidomaternoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entnat_ApellidomaternoTextBox.BackColor = System.Drawing.SystemColors.Window
    Me.Entnat_ApellidomaternoTextBox.Location = New System.Drawing.Point(130, 23)
    Me.Entnat_ApellidomaternoTextBox.Margin = New System.Windows.Forms.Padding(1)
    Me.Entnat_ApellidomaternoTextBox.Mensaje = ""
    Me.Entnat_ApellidomaternoTextBox.Name = "Entnat_ApellidomaternoTextBox"
    Me.Entnat_ApellidomaternoTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entnat_ApellidomaternoTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Entnat_ApellidomaternoTextBox.PromptText = ""
    Me.Entnat_ApellidomaternoTextBox.Size = New System.Drawing.Size(173, 20)
    Me.Entnat_ApellidomaternoTextBox.TabIndex = 3
    Me.Entnat_ApellidomaternoTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Entnat_NombresTextBox
    '
    Me.Entnat_NombresTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entnat_NombresTextBox.BackColor = System.Drawing.SystemColors.Window
    Me.Entnat_NombresTextBox.Location = New System.Drawing.Point(130, 45)
    Me.Entnat_NombresTextBox.Margin = New System.Windows.Forms.Padding(1)
    Me.Entnat_NombresTextBox.Mensaje = ""
    Me.Entnat_NombresTextBox.Name = "Entnat_NombresTextBox"
    Me.Entnat_NombresTextBox.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entnat_NombresTextBox.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Entnat_NombresTextBox.PromptText = ""
    Me.Entnat_NombresTextBox.Size = New System.Drawing.Size(173, 20)
    Me.Entnat_NombresTextBox.TabIndex = 5
    Me.Entnat_NombresTextBox.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.AutoScroll = True
    Me.pnlcuerpo.Controls.Add(Me.TableLayoutPanel3)
    Me.pnlcuerpo.Controls.Add(Me.TaskBoxStd1)
    Me.pnlcuerpo.Controls.Add(Me.TaskBoxStd2)
    Me.pnlcuerpo.Controls.Add(Me.GroupBox4)
    Me.pnlcuerpo.Controls.Add(Me.GroupBox3)
    Me.pnlcuerpo.Controls.Add(Me.grpsri)
    Me.pnlcuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlcuerpo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
    Me.pnlcuerpo.Location = New System.Drawing.Point(0, 0)
    Me.pnlcuerpo.Name = "pnlcuerpo"
    Me.pnlcuerpo.Size = New System.Drawing.Size(622, 458)
    Me.pnlcuerpo.TabIndex = 2
    '
    'ComboBoxSexo
    '
    Me.ComboBoxSexo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSexo.FormattingEnabled = True
    Me.ComboBoxSexo.Location = New System.Drawing.Point(131, 115)
    Me.ComboBoxSexo.Margin = New System.Windows.Forms.Padding(2)
    Me.ComboBoxSexo.Name = "ComboBoxSexo"
    Me.ComboBoxSexo.OperadorDatos = Nothing
    Me.ComboBoxSexo.Parametro = Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxSexo.ParametroDet = Nothing
    Me.ComboBoxSexo.PuedeActualizar = True
    Me.ComboBoxSexo.PuedeEliminar = True
    Me.ComboBoxSexo.PuedeModificar = True
    Me.ComboBoxSexo.PuedeNuevo = True
    Me.ComboBoxSexo.Size = New System.Drawing.Size(171, 21)
    Me.ComboBoxSexo.TabIndex = 11
    '
    'ComboBoxEstadoCivil
    '
    Me.ComboBoxEstadoCivil.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxEstadoCivil.FormattingEnabled = True
    Me.ComboBoxEstadoCivil.Location = New System.Drawing.Point(131, 90)
    Me.ComboBoxEstadoCivil.Margin = New System.Windows.Forms.Padding(2)
    Me.ComboBoxEstadoCivil.Name = "ComboBoxEstadoCivil"
    Me.ComboBoxEstadoCivil.OperadorDatos = Nothing
    Me.ComboBoxEstadoCivil.Parametro = Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxEstadoCivil.ParametroDet = Nothing
    Me.ComboBoxEstadoCivil.PuedeActualizar = True
    Me.ComboBoxEstadoCivil.PuedeEliminar = True
    Me.ComboBoxEstadoCivil.PuedeModificar = True
    Me.ComboBoxEstadoCivil.PuedeNuevo = True
    Me.ComboBoxEstadoCivil.Size = New System.Drawing.Size(171, 21)
    Me.ComboBoxEstadoCivil.TabIndex = 9
    '
    'CtlDireccion1
    '
    Me.CtlDireccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlDireccion1.Entidad = Nothing
    Me.CtlDireccion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlDireccion1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlDireccion1.Name = "CtlDireccion1"
    Me.CtlDireccion1.Size = New System.Drawing.Size(294, 71)
    Me.CtlDireccion1.TabIndex = 0
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Trabajo
    '
    'CtlTelefono1
    '
    Me.CtlTelefono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono1.Entidad = Nothing
    Me.CtlTelefono1.Location = New System.Drawing.Point(4, 82)
    Me.CtlTelefono1.Margin = New System.Windows.Forms.Padding(2)
    Me.CtlTelefono1.Name = "CtlTelefono1"
    Me.CtlTelefono1.Size = New System.Drawing.Size(294, 25)
    Me.CtlTelefono1.TabIndex = 2
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'CtlTelefono2
    '
    Me.CtlTelefono2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono2.Entidad = Nothing
    Me.CtlTelefono2.Location = New System.Drawing.Point(4, 57)
    Me.CtlTelefono2.Margin = New System.Windows.Forms.Padding(2)
    Me.CtlTelefono2.Name = "CtlTelefono2"
    Me.CtlTelefono2.Size = New System.Drawing.Size(294, 25)
    Me.CtlTelefono2.TabIndex = 1
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'CtlTelefono3
    '
    Me.CtlTelefono3.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono3.Entidad = Nothing
    Me.CtlTelefono3.Location = New System.Drawing.Point(4, 32)
    Me.CtlTelefono3.Margin = New System.Windows.Forms.Padding(2)
    Me.CtlTelefono3.Name = "CtlTelefono3"
    Me.CtlTelefono3.Size = New System.Drawing.Size(294, 25)
    Me.CtlTelefono3.TabIndex = 0
    Me.CtlTelefono3.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'CtlIdentificacion5
    '
    Me.CtlIdentificacion5.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion5.Entidad = Nothing
    Me.CtlIdentificacion5.EntidadRepetido = Nothing
    Me.CtlIdentificacion5.Location = New System.Drawing.Point(4, 132)
    Me.CtlIdentificacion5.Name = "CtlIdentificacion5"
    Me.CtlIdentificacion5.Size = New System.Drawing.Size(294, 25)
    Me.CtlIdentificacion5.TabIndex = 4
    Me.CtlIdentificacion5.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion5.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'CtlIdentificacion4
    '
    Me.CtlIdentificacion4.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion4.Entidad = Nothing
    Me.CtlIdentificacion4.EntidadRepetido = Nothing
    Me.CtlIdentificacion4.Location = New System.Drawing.Point(4, 107)
    Me.CtlIdentificacion4.Name = "CtlIdentificacion4"
    Me.CtlIdentificacion4.Size = New System.Drawing.Size(294, 25)
    Me.CtlIdentificacion4.TabIndex = 3
    Me.CtlIdentificacion4.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion4.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'CtlIdentificacion3
    '
    Me.CtlIdentificacion3.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion3.Entidad = Nothing
    Me.CtlIdentificacion3.EntidadRepetido = Nothing
    Me.CtlIdentificacion3.Location = New System.Drawing.Point(4, 82)
    Me.CtlIdentificacion3.Name = "CtlIdentificacion3"
    Me.CtlIdentificacion3.Size = New System.Drawing.Size(294, 25)
    Me.CtlIdentificacion3.TabIndex = 2
    Me.CtlIdentificacion3.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion3.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'CtlIdentificacion2
    '
    Me.CtlIdentificacion2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion2.Entidad = Nothing
    Me.CtlIdentificacion2.EntidadRepetido = Nothing
    Me.CtlIdentificacion2.Location = New System.Drawing.Point(4, 57)
    Me.CtlIdentificacion2.Name = "CtlIdentificacion2"
    Me.CtlIdentificacion2.Size = New System.Drawing.Size(294, 25)
    Me.CtlIdentificacion2.TabIndex = 1
    Me.CtlIdentificacion2.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion2.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'CtlIdentificacion1
    '
    Me.CtlIdentificacion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion1.Entidad = Nothing
    Me.CtlIdentificacion1.EntidadRepetido = Nothing
    Me.CtlIdentificacion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlIdentificacion1.Name = "CtlIdentificacion1"
    Me.CtlIdentificacion1.Size = New System.Drawing.Size(294, 25)
    Me.CtlIdentificacion1.TabIndex = 0
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion1.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'CtlEmail2
    '
    Me.CtlEmail2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail2.Entidad = Nothing
    Me.CtlEmail2.Location = New System.Drawing.Point(4, 57)
    Me.CtlEmail2.Name = "CtlEmail2"
    Me.CtlEmail2.Size = New System.Drawing.Size(294, 25)
    Me.CtlEmail2.TabIndex = 1
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    '
    'CtlEmail1
    '
    Me.CtlEmail1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail1.Entidad = Nothing
    Me.CtlEmail1.Location = New System.Drawing.Point(4, 32)
    Me.CtlEmail1.Name = "CtlEmail1"
    Me.CtlEmail1.Size = New System.Drawing.Size(294, 25)
    Me.CtlEmail1.TabIndex = 0
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    '
    'CtlEntidadNatural
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnlcuerpo)
    Me.Name = "CtlEntidadNatural"
    Me.Size = New System.Drawing.Size(622, 458)
    CType(Me.EntidadNaturalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.grpsri.ResumeLayout(False)
    Me.grpsri.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.TaskBoxStd2.ResumeLayout(False)
    Me.TaskBoxStd1.ResumeLayout(False)
    Me.TableLayoutPanel3.ResumeLayout(False)
    Me.TableLayoutPanel3.PerformLayout()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents EntidadNaturalBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents CtlDireccion1 As CtlDireccion
  Friend WithEvents CtlTelefono1 As CtlTelefono
  Friend WithEvents CtlTelefono3 As CtlTelefono
  Friend WithEvents CtlTelefono2 As CtlTelefono
  Friend WithEvents GroupBox3 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlEmail1 As CtlEmail
  Friend WithEvents GroupBox4 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlIdentificacion4 As CtlIdentificacion
  Friend WithEvents CtlIdentificacion3 As CtlIdentificacion
  Friend WithEvents CtlIdentificacion2 As CtlIdentificacion
  Friend WithEvents CtlIdentificacion1 As CtlIdentificacion
  Friend WithEvents CtlEmail2 As CtlEmail
  Friend WithEvents CtlIdentificacion5 As CtlIdentificacion
  Friend WithEvents grpsri As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents mskcaducret As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents mskcaducnotvta As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents mskcaducfactura As Infoware.Controles.Base.MaskedTextBoxStd
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents txtautoret As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtautonotvta As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents txtautofactura As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents TaskBoxStd1 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents TaskBoxStd2 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents ComboBoxSexo As ComboBoxParametroDet
  Friend WithEvents Entnat_ApellidopaternoTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents ComboBoxEstadoCivil As ComboBoxParametroDet
  Friend WithEvents Entnat_FechanacimientoDateTimePicker As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents Entnat_ApellidomaternoTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Entnat_NombresTextBox As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents pnlcuerpo As System.Windows.Forms.FlowLayoutPanel

End Class
