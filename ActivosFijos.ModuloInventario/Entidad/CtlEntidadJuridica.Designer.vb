Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEntidadJuridica
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
    Me.components = New System.ComponentModel.Container
    Dim Entnat_ApellidomaternoLabel As System.Windows.Forms.Label
    Dim Entnat_ApellidopaternoLabel As System.Windows.Forms.Label
    Dim Entnat_FechanacimientoLabel As System.Windows.Forms.Label
    Dim Pardet_EstadocivilLabel As System.Windows.Forms.Label
    Me.EntJur_RazonSocial = New Infoware.Controles.Base.TextBoxStd
    Me.Entjur_NombreComercial = New Infoware.Controles.Base.TextBoxStd
    Me.EntJur_Fechaconstitucion = New Infoware.Controles.Base.DateTimePickerStd
    Me.grpsri = New Infoware.Controles.Base.TaskBoxStd
    Me.mskcaducret = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.mskcaducnotvta = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.mskcaducfactura = New Infoware.Controles.Base.MaskedTextBoxStd
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label7 = New System.Windows.Forms.Label
    Me.txtautoret = New Infoware.Controles.Base.TextBoxStd
    Me.txtautonotvta = New Infoware.Controles.Base.TextBoxStd
    Me.txtautofactura = New Infoware.Controles.Base.TextBoxStd
    Me.GroupBox4 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlIdentificacion1 = New CtlIdentificacion
    Me.GroupBox3 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlEmail2 = New CtlEmail
    Me.CtlEmail1 = New CtlEmail
    Me.GroupBox2 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlTelefono2 = New CtlTelefono
    Me.CtlTelefono1 = New CtlTelefono
    Me.GroupBox1 = New Infoware.Controles.Base.TaskBoxStd
    Me.CtlDireccion1 = New CtlDireccion
    Me.Panel4 = New System.Windows.Forms.Panel
    Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
    Me.CtlBuscaEntidad2 = New CtlBuscaEntidad2
    Me.CtlBuscaEntidad1 = New CtlBuscaEntidad2
    Me.ComboBoTipoContrib = New ComboBoxParametroDet
    Me.pnl_cuerpo = New System.Windows.Forms.FlowLayoutPanel
    Entnat_ApellidomaternoLabel = New System.Windows.Forms.Label
    Entnat_ApellidopaternoLabel = New System.Windows.Forms.Label
    Entnat_FechanacimientoLabel = New System.Windows.Forms.Label
    Pardet_EstadocivilLabel = New System.Windows.Forms.Label
    Me.grpsri.SuspendLayout()
    Me.GroupBox4.SuspendLayout()
    Me.GroupBox3.SuspendLayout()
    Me.GroupBox2.SuspendLayout()
    Me.GroupBox1.SuspendLayout()
    Me.Panel4.SuspendLayout()
    Me.TableLayoutPanel2.SuspendLayout()
    Me.pnl_cuerpo.SuspendLayout()
    Me.SuspendLayout()
    '
    'Entnat_ApellidomaternoLabel
    '
    Entnat_ApellidomaternoLabel.AutoSize = True
    Entnat_ApellidomaternoLabel.Location = New System.Drawing.Point(3, 26)
    Entnat_ApellidomaternoLabel.Name = "Entnat_ApellidomaternoLabel"
    Entnat_ApellidomaternoLabel.Size = New System.Drawing.Size(71, 13)
    Entnat_ApellidomaternoLabel.TabIndex = 2
    Entnat_ApellidomaternoLabel.Text = "Razón social:"
    '
    'Entnat_ApellidopaternoLabel
    '
    Entnat_ApellidopaternoLabel.AutoSize = True
    Entnat_ApellidopaternoLabel.Location = New System.Drawing.Point(3, 0)
    Entnat_ApellidopaternoLabel.Name = "Entnat_ApellidopaternoLabel"
    Entnat_ApellidopaternoLabel.Size = New System.Drawing.Size(95, 13)
    Entnat_ApellidopaternoLabel.TabIndex = 0
    Entnat_ApellidopaternoLabel.Text = "Nombre comercial:"
    '
    'Entnat_FechanacimientoLabel
    '
    Entnat_FechanacimientoLabel.AutoSize = True
    Entnat_FechanacimientoLabel.Location = New System.Drawing.Point(3, 52)
    Entnat_FechanacimientoLabel.Name = "Entnat_FechanacimientoLabel"
    Entnat_FechanacimientoLabel.Size = New System.Drawing.Size(115, 13)
    Entnat_FechanacimientoLabel.TabIndex = 4
    Entnat_FechanacimientoLabel.Text = "Fecha de constitución:"
    '
    'Pardet_EstadocivilLabel
    '
    Pardet_EstadocivilLabel.AutoSize = True
    Pardet_EstadocivilLabel.Location = New System.Drawing.Point(3, 78)
    Pardet_EstadocivilLabel.Name = "Pardet_EstadocivilLabel"
    Pardet_EstadocivilLabel.Size = New System.Drawing.Size(113, 13)
    Pardet_EstadocivilLabel.TabIndex = 6
    Pardet_EstadocivilLabel.Text = "Tipo de contribuyente:"
    '
    'EntJur_RazonSocial
    '
    Me.EntJur_RazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.EntJur_RazonSocial.Location = New System.Drawing.Point(129, 29)
    Me.EntJur_RazonSocial.Mensaje = ""
    Me.EntJur_RazonSocial.Name = "EntJur_RazonSocial"
    Me.EntJur_RazonSocial.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.EntJur_RazonSocial.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.EntJur_RazonSocial.PromptText = ""
    Me.EntJur_RazonSocial.Size = New System.Drawing.Size(138, 20)
    Me.EntJur_RazonSocial.TabIndex = 3
    Me.EntJur_RazonSocial.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'Entjur_NombreComercial
    '
    Me.Entjur_NombreComercial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Entjur_NombreComercial.Location = New System.Drawing.Point(129, 3)
    Me.Entjur_NombreComercial.Mensaje = ""
    Me.Entjur_NombreComercial.Name = "Entjur_NombreComercial"
    Me.Entjur_NombreComercial.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Entjur_NombreComercial.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.Entjur_NombreComercial.PromptText = ""
    Me.Entjur_NombreComercial.Size = New System.Drawing.Size(138, 20)
    Me.Entjur_NombreComercial.TabIndex = 1
    Me.Entjur_NombreComercial.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    '
    'EntJur_Fechaconstitucion
    '
    Me.EntJur_Fechaconstitucion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.EntJur_Fechaconstitucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.EntJur_Fechaconstitucion.Location = New System.Drawing.Point(129, 55)
    Me.EntJur_Fechaconstitucion.Name = "EntJur_Fechaconstitucion"
    Me.EntJur_Fechaconstitucion.ShowCheckBox = True
    Me.EntJur_Fechaconstitucion.Size = New System.Drawing.Size(138, 20)
    Me.EntJur_Fechaconstitucion.TabIndex = 5
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
    Me.grpsri.Location = New System.Drawing.Point(279, 162)
    Me.grpsri.Name = "grpsri"
    Me.grpsri.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.grpsri.Size = New System.Drawing.Size(270, 180)
    Me.grpsri.TabIndex = 2
    Me.grpsri.Visible = False
    '
    'mskcaducret
    '
    Me.mskcaducret.Location = New System.Drawing.Point(165, 154)
    Me.mskcaducret.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducret.Mask = "00/0000"
    Me.mskcaducret.Name = "mskcaducret"
    Me.mskcaducret.Size = New System.Drawing.Size(54, 20)
    Me.mskcaducret.TabIndex = 11
    '
    'mskcaducnotvta
    '
    Me.mskcaducnotvta.Location = New System.Drawing.Point(165, 106)
    Me.mskcaducnotvta.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducnotvta.Mask = "00/0000"
    Me.mskcaducnotvta.Name = "mskcaducnotvta"
    Me.mskcaducnotvta.Size = New System.Drawing.Size(54, 20)
    Me.mskcaducnotvta.TabIndex = 7
    '
    'mskcaducfactura
    '
    Me.mskcaducfactura.Location = New System.Drawing.Point(165, 58)
    Me.mskcaducfactura.Margin = New System.Windows.Forms.Padding(2)
    Me.mskcaducfactura.Mask = "00/0000"
    Me.mskcaducfactura.Name = "mskcaducfactura"
    Me.mskcaducfactura.Size = New System.Drawing.Size(54, 20)
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
    Me.GroupBox4.Controls.Add(Me.CtlIdentificacion1)
    Me.GroupBox4.HeaderText = "Identificaciones"
    Me.GroupBox4.IsModoMini = True
    Me.GroupBox4.Location = New System.Drawing.Point(279, 3)
    Me.GroupBox4.Name = "GroupBox4"
    Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox4.Size = New System.Drawing.Size(270, 60)
    Me.GroupBox4.TabIndex = 1
    '
    'CtlIdentificacion1
    '
    Me.CtlIdentificacion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlIdentificacion1.Entidad = Nothing
    Me.CtlIdentificacion1.EntidadRepetido = Nothing
    Me.CtlIdentificacion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlIdentificacion1.Name = "CtlIdentificacion1"
    Me.CtlIdentificacion1.Size = New System.Drawing.Size(262, 28)
    Me.CtlIdentificacion1.TabIndex = 0
    Me.CtlIdentificacion1.TipoIdentificacion = Enumerados.enumTipoIdentificacion.RUC
    Me.CtlIdentificacion1.TipoLugar = Enumerados.EnumTipoLugar.Sucursal
    '
    'GroupBox3
    '
    Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox3.Controls.Add(Me.CtlEmail2)
    Me.GroupBox3.Controls.Add(Me.CtlEmail1)
    Me.GroupBox3.HeaderText = "Emails"
    Me.GroupBox3.IsModoMini = True
    Me.GroupBox3.Location = New System.Drawing.Point(279, 69)
    Me.GroupBox3.Name = "GroupBox3"
    Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox3.Size = New System.Drawing.Size(270, 87)
    Me.GroupBox3.TabIndex = 0
    '
    'CtlEmail2
    '
    Me.CtlEmail2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail2.Entidad = Nothing
    Me.CtlEmail2.Location = New System.Drawing.Point(4, 60)
    Me.CtlEmail2.Name = "CtlEmail2"
    Me.CtlEmail2.Size = New System.Drawing.Size(262, 28)
    Me.CtlEmail2.TabIndex = 1
    Me.CtlEmail2.TipoEmail = Enumerados.enumTipoEmail.Trabajo1
    '
    'CtlEmail1
    '
    Me.CtlEmail1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlEmail1.Entidad = Nothing
    Me.CtlEmail1.Location = New System.Drawing.Point(4, 32)
    Me.CtlEmail1.Name = "CtlEmail1"
    Me.CtlEmail1.Size = New System.Drawing.Size(262, 28)
    Me.CtlEmail1.TabIndex = 0
    Me.CtlEmail1.TipoEmail = Enumerados.enumTipoEmail.Trabajo
    '
    'GroupBox2
    '
    Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox2.Controls.Add(Me.CtlTelefono2)
    Me.GroupBox2.Controls.Add(Me.CtlTelefono1)
    Me.GroupBox2.HeaderText = "Teléfonos"
    Me.GroupBox2.IsModoMini = True
    Me.GroupBox2.Location = New System.Drawing.Point(3, 285)
    Me.GroupBox2.Name = "GroupBox2"
    Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox2.Size = New System.Drawing.Size(270, 87)
    Me.GroupBox2.TabIndex = 2
    '
    'CtlTelefono2
    '
    Me.CtlTelefono2.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono2.Entidad = Nothing
    Me.CtlTelefono2.Location = New System.Drawing.Point(4, 60)
    Me.CtlTelefono2.Name = "CtlTelefono2"
    Me.CtlTelefono2.Size = New System.Drawing.Size(262, 28)
    Me.CtlTelefono2.TabIndex = 1
    Me.CtlTelefono2.TipoTelefono = Enumerados.enumTipoTelefono.Fax
    '
    'CtlTelefono1
    '
    Me.CtlTelefono1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlTelefono1.Entidad = Nothing
    Me.CtlTelefono1.Location = New System.Drawing.Point(4, 32)
    Me.CtlTelefono1.Name = "CtlTelefono1"
    Me.CtlTelefono1.Size = New System.Drawing.Size(262, 28)
    Me.CtlTelefono1.TabIndex = 0
    Me.CtlTelefono1.TipoTelefono = Enumerados.enumTipoTelefono.Trabajo
    '
    'GroupBox1
    '
    Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
    Me.GroupBox1.Controls.Add(Me.CtlDireccion1)
    Me.GroupBox1.HeaderText = "Direcciones"
    Me.GroupBox1.IsModoMini = True
    Me.GroupBox1.Location = New System.Drawing.Point(3, 168)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 32, 4, 4)
    Me.GroupBox1.Size = New System.Drawing.Size(270, 111)
    Me.GroupBox1.TabIndex = 1
    '
    'CtlDireccion1
    '
    Me.CtlDireccion1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlDireccion1.Entidad = Nothing
    Me.CtlDireccion1.Location = New System.Drawing.Point(4, 32)
    Me.CtlDireccion1.Margin = New System.Windows.Forms.Padding(5)
    Me.CtlDireccion1.Name = "CtlDireccion1"
    Me.CtlDireccion1.Size = New System.Drawing.Size(262, 88)
    Me.CtlDireccion1.TabIndex = 0
    Me.CtlDireccion1.TipoDireccion = Enumerados.enumTipoDireccion.Trabajo
    '
    'Panel4
    '
    Me.Panel4.Controls.Add(Me.TableLayoutPanel2)
    Me.Panel4.Location = New System.Drawing.Point(3, 3)
    Me.Panel4.Name = "Panel4"
    Me.Panel4.Size = New System.Drawing.Size(270, 159)
    Me.Panel4.TabIndex = 0
    '
    'TableLayoutPanel2
    '
    Me.TableLayoutPanel2.ColumnCount = 2
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667!))
    Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.33333!))
    Me.TableLayoutPanel2.Controls.Add(Entnat_ApellidopaternoLabel, 0, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.CtlBuscaEntidad2, 0, 5)
    Me.TableLayoutPanel2.Controls.Add(Me.Entjur_NombreComercial, 1, 0)
    Me.TableLayoutPanel2.Controls.Add(Me.CtlBuscaEntidad1, 0, 4)
    Me.TableLayoutPanel2.Controls.Add(Me.ComboBoTipoContrib, 1, 3)
    Me.TableLayoutPanel2.Controls.Add(Pardet_EstadocivilLabel, 0, 3)
    Me.TableLayoutPanel2.Controls.Add(Entnat_FechanacimientoLabel, 0, 2)
    Me.TableLayoutPanel2.Controls.Add(Entnat_ApellidomaternoLabel, 0, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.EntJur_RazonSocial, 1, 1)
    Me.TableLayoutPanel2.Controls.Add(Me.EntJur_Fechaconstitucion, 1, 2)
    Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
    Me.TableLayoutPanel2.RowCount = 6
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle)
    Me.TableLayoutPanel2.Size = New System.Drawing.Size(270, 159)
    Me.TableLayoutPanel2.TabIndex = 0
    '
    'CtlBuscaEntidad2
    '
    Me.CtlBuscaEntidad2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.SetColumnSpan(Me.CtlBuscaEntidad2, 2)
    Me.CtlBuscaEntidad2.Entidad = Nothing
    Me.CtlBuscaEntidad2.EntidadJuridica = Nothing
    Me.CtlBuscaEntidad2.EntidadNatural = Nothing
    Me.CtlBuscaEntidad2.EntidadText = "Contacto"
    Me.CtlBuscaEntidad2.Location = New System.Drawing.Point(3, 136)
    Me.CtlBuscaEntidad2.Name = "CtlBuscaEntidad2"
    Me.CtlBuscaEntidad2.OperadorDatos = Nothing
    Me.CtlBuscaEntidad2.Size = New System.Drawing.Size(264, 22)
    Me.CtlBuscaEntidad2.TabIndex = 9
    Me.CtlBuscaEntidad2.TipoEntidad = CtlBuscaEntidad2.EnumTipoEntidad.EntidadNatural
    '
    'CtlBuscaEntidad1
    '
    Me.CtlBuscaEntidad1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel2.SetColumnSpan(Me.CtlBuscaEntidad1, 2)
    Me.CtlBuscaEntidad1.Entidad = Nothing
    Me.CtlBuscaEntidad1.EntidadJuridica = Nothing
    Me.CtlBuscaEntidad1.EntidadNatural = Nothing
    Me.CtlBuscaEntidad1.EntidadText = "Representante legal"
    Me.CtlBuscaEntidad1.Location = New System.Drawing.Point(3, 108)
    Me.CtlBuscaEntidad1.Name = "CtlBuscaEntidad1"
    Me.CtlBuscaEntidad1.OperadorDatos = Nothing
    Me.CtlBuscaEntidad1.Size = New System.Drawing.Size(264, 22)
    Me.CtlBuscaEntidad1.TabIndex = 8
    Me.CtlBuscaEntidad1.TipoEntidad = CtlBuscaEntidad2.EnumTipoEntidad.EntidadNatural
    '
    'ComboBoTipoContrib
    '
    Me.ComboBoTipoContrib.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ComboBoTipoContrib.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoTipoContrib.FormattingEnabled = True
    Me.ComboBoTipoContrib.Location = New System.Drawing.Point(129, 81)
    Me.ComboBoTipoContrib.Name = "ComboBoTipoContrib"
    Me.ComboBoTipoContrib.OperadorDatos = Nothing
    Me.ComboBoTipoContrib.Parametro = Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoTipoContrib.ParametroDet = Nothing
    Me.ComboBoTipoContrib.PuedeActualizar = True
    Me.ComboBoTipoContrib.PuedeEliminar = True
    Me.ComboBoTipoContrib.PuedeModificar = True
    Me.ComboBoTipoContrib.PuedeNuevo = True
    Me.ComboBoTipoContrib.Size = New System.Drawing.Size(138, 21)
    Me.ComboBoTipoContrib.TabIndex = 7
    '
    'pnl_cuerpo
    '
    Me.pnl_cuerpo.AutoScroll = True
    Me.pnl_cuerpo.Controls.Add(Me.Panel4)
    Me.pnl_cuerpo.Controls.Add(Me.GroupBox1)
    Me.pnl_cuerpo.Controls.Add(Me.GroupBox2)
    Me.pnl_cuerpo.Controls.Add(Me.GroupBox4)
    Me.pnl_cuerpo.Controls.Add(Me.GroupBox3)
    Me.pnl_cuerpo.Controls.Add(Me.grpsri)
    Me.pnl_cuerpo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnl_cuerpo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
    Me.pnl_cuerpo.Location = New System.Drawing.Point(0, 0)
    Me.pnl_cuerpo.Name = "pnl_cuerpo"
    Me.pnl_cuerpo.Size = New System.Drawing.Size(582, 418)
    Me.pnl_cuerpo.TabIndex = 1
    '
    'CtlEntidadJuridica
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.pnl_cuerpo)
    Me.Name = "CtlEntidadJuridica"
    Me.Size = New System.Drawing.Size(582, 418)
    Me.grpsri.ResumeLayout(False)
    Me.grpsri.PerformLayout()
    Me.GroupBox4.ResumeLayout(False)
    Me.GroupBox3.ResumeLayout(False)
    Me.GroupBox2.ResumeLayout(False)
    Me.GroupBox1.ResumeLayout(False)
    Me.Panel4.ResumeLayout(False)
    Me.TableLayoutPanel2.ResumeLayout(False)
    Me.TableLayoutPanel2.PerformLayout()
    Me.pnl_cuerpo.ResumeLayout(False)
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents EntJur_RazonSocial As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents Entjur_NombreComercial As Infoware.Controles.Base.TextBoxStd
  Friend WithEvents EntJur_Fechaconstitucion As Infoware.Controles.Base.DateTimePickerStd
  Friend WithEvents GroupBox1 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlDireccion1 As CtlDireccion
  Friend WithEvents GroupBox2 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlTelefono1 As CtlTelefono
  Friend WithEvents CtlTelefono2 As CtlTelefono
  Friend WithEvents GroupBox3 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlEmail1 As CtlEmail
  Friend WithEvents GroupBox4 As Infoware.Controles.Base.TaskBoxStd
  Friend WithEvents CtlIdentificacion1 As CtlIdentificacion
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents CtlEmail2 As CtlEmail
  Friend WithEvents CtlBuscaEntidad1 As CtlBuscaEntidad2
  Friend WithEvents ComboBoTipoContrib As ComboBoxParametroDet
  Friend WithEvents CtlBuscaEntidad2 As CtlBuscaEntidad2
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
  Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents pnl_cuerpo As System.Windows.Forms.FlowLayoutPanel

End Class
