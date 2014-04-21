<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoActivoValoracion
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
    Me.CtlBuscaPerito1 = New ActivosFijos.Modulo.CtlBuscaPerito()
    Me.lblactivo = New System.Windows.Forms.Label()
    Me.cbotipodepreciacion = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.cboFrecuenciaDepreciacion = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label27 = New System.Windows.Forms.Label()
    Me.txtperiodosdepreciables = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.txtvaloradepreciar = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.txtvalorsalvamento = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.txtcostoactivo = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.dtfecvaloracion = New System.Windows.Forms.DateTimePicker()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.CtlBuscaPerito1)
    Me.Panel1.Controls.Add(Me.lblactivo)
    Me.Panel1.Controls.Add(Me.cbotipodepreciacion)
    Me.Panel1.Controls.Add(Me.Label3)
    Me.Panel1.Controls.Add(Me.cboFrecuenciaDepreciacion)
    Me.Panel1.Controls.Add(Me.Label27)
    Me.Panel1.Controls.Add(Me.txtperiodosdepreciables)
    Me.Panel1.Controls.Add(Me.Label26)
    Me.Panel1.Controls.Add(Me.txtvaloradepreciar)
    Me.Panel1.Controls.Add(Me.Label25)
    Me.Panel1.Controls.Add(Me.txtvalorsalvamento)
    Me.Panel1.Controls.Add(Me.Label23)
    Me.Panel1.Controls.Add(Me.txtcostoactivo)
    Me.Panel1.Controls.Add(Me.Label24)
    Me.Panel1.Controls.Add(Me.Label13)
    Me.Panel1.Controls.Add(Me.dtfecvaloracion)
    Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Panel1.Location = New System.Drawing.Point(0, 49)
    Me.Panel1.Name = "Panel1"
    Me.Panel1.Size = New System.Drawing.Size(416, 249)
    Me.Panel1.TabIndex = 0
    '
    'CtlBuscaPerito1
    '
    Me.CtlBuscaPerito1.ItemText = "Perito"
    Me.CtlBuscaPerito1.Location = New System.Drawing.Point(15, 206)
    Me.CtlBuscaPerito1.Name = "CtlBuscaPerito1"
    Me.CtlBuscaPerito1.Perito = Nothing
    Me.CtlBuscaPerito1.PeritoText = "Perito"
    Me.CtlBuscaPerito1.Size = New System.Drawing.Size(324, 22)
    Me.CtlBuscaPerito1.TabIndex = 15
    Me.CtlBuscaPerito1.Ubicacion = ActivosFijos.Modulo.CtlBuscaPerito.EnumUbicacion.Normal
    '
    'lblactivo
    '
    Me.lblactivo.BackColor = System.Drawing.SystemColors.Info
    Me.lblactivo.Dock = System.Windows.Forms.DockStyle.Top
    Me.lblactivo.ForeColor = System.Drawing.SystemColors.InfoText
    Me.lblactivo.Location = New System.Drawing.Point(0, 0)
    Me.lblactivo.Name = "lblactivo"
    Me.lblactivo.Size = New System.Drawing.Size(416, 18)
    Me.lblactivo.TabIndex = 0
    Me.lblactivo.Text = "."
    '
    'cbotipodepreciacion
    '
    Me.cbotipodepreciacion.AbriralEntrar = False
    Me.cbotipodepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipodepreciacion.FormattingEnabled = True
    Me.cbotipodepreciacion.Location = New System.Drawing.Point(139, 33)
    Me.cbotipodepreciacion.Margin = New System.Windows.Forms.Padding(2)
    Me.cbotipodepreciacion.MostrarRutaCompleta = False
    Me.cbotipodepreciacion.Name = "cbotipodepreciacion"
    Me.cbotipodepreciacion.OperadorDatos = Nothing
    Me.cbotipodepreciacion.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbotipodepreciacion.ParametroDet = Nothing
    Me.cbotipodepreciacion.PuedeActualizar = True
    Me.cbotipodepreciacion.PuedeEliminar = True
    Me.cbotipodepreciacion.PuedeModificar = True
    Me.cbotipodepreciacion.PuedeNuevo = True
    Me.cbotipodepreciacion.Size = New System.Drawing.Size(200, 21)
    Me.cbotipodepreciacion.TabIndex = 2
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(12, 36)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(110, 13)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "Tipo de depreciación:"
    '
    'cboFrecuenciaDepreciacion
    '
    Me.cboFrecuenciaDepreciacion.AbriralEntrar = False
    Me.cboFrecuenciaDepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboFrecuenciaDepreciacion.FormattingEnabled = True
    Me.cboFrecuenciaDepreciacion.Location = New System.Drawing.Point(139, 154)
    Me.cboFrecuenciaDepreciacion.Margin = New System.Windows.Forms.Padding(2)
    Me.cboFrecuenciaDepreciacion.MostrarRutaCompleta = False
    Me.cboFrecuenciaDepreciacion.Name = "cboFrecuenciaDepreciacion"
    Me.cboFrecuenciaDepreciacion.OperadorDatos = Nothing
    Me.cboFrecuenciaDepreciacion.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboFrecuenciaDepreciacion.ParametroDet = Nothing
    Me.cboFrecuenciaDepreciacion.PuedeActualizar = True
    Me.cboFrecuenciaDepreciacion.PuedeEliminar = True
    Me.cboFrecuenciaDepreciacion.PuedeModificar = True
    Me.cboFrecuenciaDepreciacion.PuedeNuevo = True
    Me.cboFrecuenciaDepreciacion.Size = New System.Drawing.Size(200, 21)
    Me.cboFrecuenciaDepreciacion.TabIndex = 12
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.Location = New System.Drawing.Point(12, 157)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(127, 13)
    Me.Label27.TabIndex = 11
    Me.Label27.Text = "Frecuencia depreciación:"
    '
    'txtperiodosdepreciables
    '
    Me.txtperiodosdepreciables.BackColor = System.Drawing.SystemColors.Window
    Me.txtperiodosdepreciables.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtperiodosdepreciables.Location = New System.Drawing.Point(139, 130)
    Me.txtperiodosdepreciables.Margin = New System.Windows.Forms.Padding(2)
    Me.txtperiodosdepreciables.Mensaje = ""
    Me.txtperiodosdepreciables.Name = "txtperiodosdepreciables"
    Me.txtperiodosdepreciables.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtperiodosdepreciables.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtperiodosdepreciables.PromptText = ""
    Me.txtperiodosdepreciables.Size = New System.Drawing.Size(200, 20)
    Me.txtperiodosdepreciables.TabIndex = 10
    Me.txtperiodosdepreciables.Text = "0"
    Me.txtperiodosdepreciables.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.EnterosPositivos
    Me.txtperiodosdepreciables.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtperiodosdepreciables.Value = 0.0R
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(12, 133)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(104, 13)
    Me.Label26.TabIndex = 9
    Me.Label26.Text = "Meses depreciables:"
    '
    'txtvaloradepreciar
    '
    Me.txtvaloradepreciar.BackColor = System.Drawing.SystemColors.Window
    Me.txtvaloradepreciar.Enabled = False
    Me.txtvaloradepreciar.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtvaloradepreciar.Location = New System.Drawing.Point(139, 106)
    Me.txtvaloradepreciar.Margin = New System.Windows.Forms.Padding(2)
    Me.txtvaloradepreciar.Mensaje = ""
    Me.txtvaloradepreciar.Name = "txtvaloradepreciar"
    Me.txtvaloradepreciar.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvaloradepreciar.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvaloradepreciar.PromptText = ""
    Me.txtvaloradepreciar.Size = New System.Drawing.Size(200, 20)
    Me.txtvaloradepreciar.TabIndex = 8
    Me.txtvaloradepreciar.Text = "0,00"
    Me.txtvaloradepreciar.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvaloradepreciar.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvaloradepreciar.Value = 0.0R
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Location = New System.Drawing.Point(12, 109)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(90, 13)
    Me.Label25.TabIndex = 7
    Me.Label25.Text = "Valor a depreciar:"
    '
    'txtvalorsalvamento
    '
    Me.txtvalorsalvamento.BackColor = System.Drawing.SystemColors.Window
    Me.txtvalorsalvamento.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtvalorsalvamento.Location = New System.Drawing.Point(139, 82)
    Me.txtvalorsalvamento.Margin = New System.Windows.Forms.Padding(2)
    Me.txtvalorsalvamento.Mensaje = ""
    Me.txtvalorsalvamento.Name = "txtvalorsalvamento"
    Me.txtvalorsalvamento.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtvalorsalvamento.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtvalorsalvamento.PromptText = ""
    Me.txtvalorsalvamento.Size = New System.Drawing.Size(200, 20)
    Me.txtvalorsalvamento.TabIndex = 6
    Me.txtvalorsalvamento.Text = "0,00"
    Me.txtvalorsalvamento.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtvalorsalvamento.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtvalorsalvamento.Value = 0.0R
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(12, 85)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(106, 13)
    Me.Label23.TabIndex = 5
    Me.Label23.Text = "Valor de salvamento:"
    '
    'txtcostoactivo
    '
    Me.txtcostoactivo.BackColor = System.Drawing.SystemColors.Window
    Me.txtcostoactivo.ForeColor = System.Drawing.SystemColors.WindowText
    Me.txtcostoactivo.Location = New System.Drawing.Point(139, 58)
    Me.txtcostoactivo.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcostoactivo.Mensaje = ""
    Me.txtcostoactivo.Name = "txtcostoactivo"
    Me.txtcostoactivo.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcostoactivo.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcostoactivo.PromptText = ""
    Me.txtcostoactivo.Size = New System.Drawing.Size(200, 20)
    Me.txtcostoactivo.TabIndex = 4
    Me.txtcostoactivo.Text = "0,00"
    Me.txtcostoactivo.TipoNumero = Infoware.Controles.Base.EnumTipoNumero.Decimales
    Me.txtcostoactivo.TipoTexto = Infoware.Controles.Base.EnumTipoTexto.Ninguno
    Me.txtcostoactivo.Value = 0.0R
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Location = New System.Drawing.Point(12, 61)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(86, 13)
    Me.Label24.TabIndex = 3
    Me.Label24.Text = "Costo del activo:"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(12, 183)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(107, 13)
    Me.Label13.TabIndex = 13
    Me.Label13.Text = "Fecha de valoración:"
    '
    'dtfecvaloracion
    '
    Me.dtfecvaloracion.Location = New System.Drawing.Point(139, 180)
    Me.dtfecvaloracion.Name = "dtfecvaloracion"
    Me.dtfecvaloracion.Size = New System.Drawing.Size(200, 20)
    Me.dtfecvaloracion.TabIndex = 14
    '
    'FrmMantenimientoActivoValoracion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.ClientSize = New System.Drawing.Size(416, 298)
    Me.Controls.Add(Me.Panel1)
    Me.Name = "FrmMantenimientoActivoValoracion"
    Me.PuedeGuardarcerrar = True
    Me.PuedeGuardarnuevo = True
    Me.PuedeMover = True
    Me.Text = "Valoración Activo"
    Me.Controls.SetChildIndex(Me.Panel1, 0)
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Panel1 As System.Windows.Forms.Panel
  Friend WithEvents dtfecvaloracion As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents lblactivo As System.Windows.Forms.Label
  Friend WithEvents cboFrecuenciaDepreciacion As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents txtperiodosdepreciables As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents txtvaloradepreciar As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents txtvalorsalvamento As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents txtcostoactivo As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents CtlBuscaPerito1 As ActivosFijos.Modulo.CtlBuscaPerito
  Friend WithEvents cbotipodepreciacion As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
