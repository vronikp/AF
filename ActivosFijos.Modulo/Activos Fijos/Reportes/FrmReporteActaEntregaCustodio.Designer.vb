<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteActaEntregaCustodio
  Inherits Infoware.Consola.Base.FrmReporteBase

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.pnlsoloinventariados = New System.Windows.Forms.Panel()
        Me.cboFormato = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCambioCustodioSRI = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnActaConstatacion = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkSoloInventariados = New System.Windows.Forms.CheckBox()
        Me.cboInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboPeriodoInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rdoActaEntrega = New System.Windows.Forms.RadioButton()
        Me.pnlActaEntrega = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cbociudad = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.rdoConstatacion = New System.Windows.Forms.RadioButton()
        Me.CtlBuscaCustodio = New ActivosFijos.Modulo.CtlBuscaEmpleado()
        CType(Me.ListBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.pnlcuerpo.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.pnlsoloinventariados.SuspendLayout
        Me.pnlActaEntrega.SuspendLayout
        Me.SuspendLayout
        '
        'pnlcuerpo
        '
        Me.pnlcuerpo.Size = New System.Drawing.Size(1099, 504)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlsoloinventariados)
        Me.Panel1.Controls.Add(Me.rdoConstatacion)
        Me.Panel1.Controls.Add(Me.pnlActaEntrega)
        Me.Panel1.Controls.Add(Me.rdoActaEntrega)
        Me.Panel1.Controls.Add(Me.CtlBuscaCustodio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Size = New System.Drawing.Size(278, 479)
        Me.Panel1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label18.Location = New System.Drawing.Point(15, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Ciudad:"
        '
        'btnmostrar
        '
        Me.btnmostrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnmostrar.Location = New System.Drawing.Point(15, 84)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(253, 23)
        Me.btnmostrar.TabIndex = 6
        Me.btnmostrar.Text = "Acta de entrega"
        Me.btnmostrar.UseVisualStyleBackColor = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DateTimePicker1.Location = New System.Drawing.Point(15, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(253, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'pnlsoloinventariados
        '
        Me.pnlsoloinventariados.Controls.Add(Me.cboFormato)
        Me.pnlsoloinventariados.Controls.Add(Me.Label4)
        Me.pnlsoloinventariados.Controls.Add(Me.btnCambioCustodioSRI)
        Me.pnlsoloinventariados.Controls.Add(Me.Panel5)
        Me.pnlsoloinventariados.Controls.Add(Me.btnActaConstatacion)
        Me.pnlsoloinventariados.Controls.Add(Me.Panel4)
        Me.pnlsoloinventariados.Controls.Add(Me.chkSoloInventariados)
        Me.pnlsoloinventariados.Controls.Add(Me.cboInventario)
        Me.pnlsoloinventariados.Controls.Add(Me.Label3)
        Me.pnlsoloinventariados.Controls.Add(Me.cboPeriodoInventario)
        Me.pnlsoloinventariados.Controls.Add(Me.Label2)
        Me.pnlsoloinventariados.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlsoloinventariados.Location = New System.Drawing.Point(5, 202)
        Me.pnlsoloinventariados.Name = "pnlsoloinventariados"
        Me.pnlsoloinventariados.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlsoloinventariados.Size = New System.Drawing.Size(268, 213)
        Me.pnlsoloinventariados.TabIndex = 0
        Me.pnlsoloinventariados.Visible = false
        '
        'cboFormato
        '
        Me.cboFormato.AbriralEntrar = false
        Me.cboFormato.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormato.FormattingEnabled = true
        Me.cboFormato.Items.AddRange(New Object() {"Formato 1", "Formato V. General", "Formato H. Cod. Aux. ", "Formato H. Cod. Aux. 2"})
        Me.cboFormato.Location = New System.Drawing.Point(15, 178)
        Me.cboFormato.Margin = New System.Windows.Forms.Padding(2)
        Me.cboFormato.MostrarRutaCompleta = false
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.OperadorDatos = Nothing
        Me.cboFormato.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboFormato.ParametroDet = Nothing
        Me.cboFormato.PuedeActualizar = true
        Me.cboFormato.PuedeEliminar = true
        Me.cboFormato.PuedeModificar = true
        Me.cboFormato.PuedeNuevo = true
        Me.cboFormato.Size = New System.Drawing.Size(253, 21)
        Me.cboFormato.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(15, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Formato:"
        '
        'btnCambioCustodioSRI
        '
        Me.btnCambioCustodioSRI.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCambioCustodioSRI.Location = New System.Drawing.Point(15, 142)
        Me.btnCambioCustodioSRI.Name = "btnCambioCustodioSRI"
        Me.btnCambioCustodioSRI.Size = New System.Drawing.Size(253, 23)
        Me.btnCambioCustodioSRI.TabIndex = 6
        Me.btnCambioCustodioSRI.Text = "Cambio Custodio por Constatación"
        Me.btnCambioCustodioSRI.UseVisualStyleBackColor = true
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(15, 125)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(253, 17)
        Me.Panel5.TabIndex = 9
        '
        'btnActaConstatacion
        '
        Me.btnActaConstatacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnActaConstatacion.Location = New System.Drawing.Point(15, 102)
        Me.btnActaConstatacion.Name = "btnActaConstatacion"
        Me.btnActaConstatacion.Size = New System.Drawing.Size(253, 23)
        Me.btnActaConstatacion.TabIndex = 5
        Me.btnActaConstatacion.Text = "Acta de constatación"
        Me.btnActaConstatacion.UseVisualStyleBackColor = true
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(15, 85)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(253, 17)
        Me.Panel4.TabIndex = 8
        '
        'chkSoloInventariados
        '
        Me.chkSoloInventariados.AutoSize = true
        Me.chkSoloInventariados.Checked = true
        Me.chkSoloInventariados.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSoloInventariados.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkSoloInventariados.Location = New System.Drawing.Point(15, 68)
        Me.chkSoloInventariados.Name = "chkSoloInventariados"
        Me.chkSoloInventariados.Size = New System.Drawing.Size(253, 17)
        Me.chkSoloInventariados.TabIndex = 4
        Me.chkSoloInventariados.Text = "Solo activos inventariados"
        Me.chkSoloInventariados.UseVisualStyleBackColor = true
        '
        'cboInventario
        '
        Me.cboInventario.AbriralEntrar = false
        Me.cboInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboInventario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInventario.FormattingEnabled = true
        Me.cboInventario.Location = New System.Drawing.Point(15, 47)
        Me.cboInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboInventario.MostrarRutaCompleta = false
        Me.cboInventario.Name = "cboInventario"
        Me.cboInventario.OperadorDatos = Nothing
        Me.cboInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboInventario.ParametroDet = Nothing
        Me.cboInventario.PuedeActualizar = true
        Me.cboInventario.PuedeEliminar = true
        Me.cboInventario.PuedeModificar = true
        Me.cboInventario.PuedeNuevo = true
        Me.cboInventario.Size = New System.Drawing.Size(253, 21)
        Me.cboInventario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(15, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Inventario:"
        '
        'cboPeriodoInventario
        '
        Me.cboPeriodoInventario.AbriralEntrar = false
        Me.cboPeriodoInventario.Dock = System.Windows.Forms.DockStyle.Top
        Me.cboPeriodoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodoInventario.FormattingEnabled = true
        Me.cboPeriodoInventario.Location = New System.Drawing.Point(15, 13)
        Me.cboPeriodoInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPeriodoInventario.MostrarRutaCompleta = false
        Me.cboPeriodoInventario.Name = "cboPeriodoInventario"
        Me.cboPeriodoInventario.OperadorDatos = Nothing
        Me.cboPeriodoInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboPeriodoInventario.ParametroDet = Nothing
        Me.cboPeriodoInventario.PuedeActualizar = true
        Me.cboPeriodoInventario.PuedeEliminar = true
        Me.cboPeriodoInventario.PuedeModificar = true
        Me.cboPeriodoInventario.PuedeNuevo = true
        Me.cboPeriodoInventario.Size = New System.Drawing.Size(253, 21)
        Me.cboPeriodoInventario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(15, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Periodo inventario:"
        '
        'rdoActaEntrega
        '
        Me.rdoActaEntrega.AutoSize = true
        Me.rdoActaEntrega.Checked = true
        Me.rdoActaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdoActaEntrega.Location = New System.Drawing.Point(5, 56)
        Me.rdoActaEntrega.Name = "rdoActaEntrega"
        Me.rdoActaEntrega.Size = New System.Drawing.Size(268, 17)
        Me.rdoActaEntrega.TabIndex = 7
        Me.rdoActaEntrega.TabStop = true
        Me.rdoActaEntrega.Text = "Acta de Entrega"
        Me.rdoActaEntrega.UseVisualStyleBackColor = true
        '
        'pnlActaEntrega
        '
        Me.pnlActaEntrega.Controls.Add(Me.btnmostrar)
        Me.pnlActaEntrega.Controls.Add(Me.Panel3)
        Me.pnlActaEntrega.Controls.Add(Me.cbociudad)
        Me.pnlActaEntrega.Controls.Add(Me.Label18)
        Me.pnlActaEntrega.Controls.Add(Me.DateTimePicker1)
        Me.pnlActaEntrega.Controls.Add(Me.Label1)
        Me.pnlActaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActaEntrega.Location = New System.Drawing.Point(5, 73)
        Me.pnlActaEntrega.Name = "pnlActaEntrega"
        Me.pnlActaEntrega.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.pnlActaEntrega.Size = New System.Drawing.Size(268, 112)
        Me.pnlActaEntrega.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(15, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(253, 17)
        Me.Panel3.TabIndex = 7
        '
        'cbociudad
        '
        Me.cbociudad.AbriralEntrar = false
        Me.cbociudad.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbociudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbociudad.FormattingEnabled = true
        Me.cbociudad.Location = New System.Drawing.Point(15, 46)
        Me.cbociudad.Margin = New System.Windows.Forms.Padding(2)
        Me.cbociudad.MostrarRutaCompleta = false
        Me.cbociudad.Name = "cbociudad"
        Me.cbociudad.OperadorDatos = Nothing
        Me.cbociudad.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cbociudad.ParametroDet = Nothing
        Me.cbociudad.PuedeActualizar = true
        Me.cbociudad.PuedeEliminar = true
        Me.cbociudad.PuedeModificar = true
        Me.cbociudad.PuedeNuevo = true
        Me.cbociudad.Size = New System.Drawing.Size(253, 21)
        Me.cbociudad.TabIndex = 3
        '
        'rdoConstatacion
        '
        Me.rdoConstatacion.AutoSize = true
        Me.rdoConstatacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.rdoConstatacion.Location = New System.Drawing.Point(5, 185)
        Me.rdoConstatacion.Name = "rdoConstatacion"
        Me.rdoConstatacion.Size = New System.Drawing.Size(268, 17)
        Me.rdoConstatacion.TabIndex = 9
        Me.rdoConstatacion.Text = "Acta de constatación"
        Me.rdoConstatacion.UseVisualStyleBackColor = true
        '
        'CtlBuscaCustodio
        '
        Me.CtlBuscaCustodio.Dock = System.Windows.Forms.DockStyle.Top
        Me.CtlBuscaCustodio.Empleado = Nothing
        Me.CtlBuscaCustodio.EmpleadoText = "Custodio"
        Me.CtlBuscaCustodio.ItemText = "Custodio"
        Me.CtlBuscaCustodio.Location = New System.Drawing.Point(5, 4)
        Me.CtlBuscaCustodio.Name = "CtlBuscaCustodio"
        Me.CtlBuscaCustodio.Size = New System.Drawing.Size(268, 52)
        Me.CtlBuscaCustodio.SoloActivos = false
        Me.CtlBuscaCustodio.TabIndex = 1
        Me.CtlBuscaCustodio.TipoEmpleado = Nothing
        Me.CtlBuscaCustodio.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Abajo
        '
        'FrmReporteActaEntregaCustodio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 553)
        Me.Name = "FrmReporteActaEntregaCustodio"
        Me.PuedeImprimir = true
        Me.Text = "Acta de Entrega a Custodio"
        CType(Me.ListBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlcuerpo.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnlsoloinventariados.ResumeLayout(false)
        Me.pnlsoloinventariados.PerformLayout
        Me.pnlActaEntrega.ResumeLayout(false)
        Me.pnlActaEntrega.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
  Friend WithEvents CtlBuscaCustodio As ActivosFijos.Modulo.CtlBuscaEmpleado
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents cbociudad As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents pnlsoloinventariados As System.Windows.Forms.Panel
  Friend WithEvents cboPeriodoInventario As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents btnActaConstatacion As System.Windows.Forms.Button
  Friend WithEvents btnCambioCustodioSRI As System.Windows.Forms.Button
  Friend WithEvents chkSoloInventariados As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents cboInventario As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Panel5 As System.Windows.Forms.Panel
  Friend WithEvents Panel4 As System.Windows.Forms.Panel
  Friend WithEvents rdoConstatacion As System.Windows.Forms.RadioButton
  Friend WithEvents pnlActaEntrega As System.Windows.Forms.Panel
  Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rdoActaEntrega As System.Windows.Forms.RadioButton
    Friend WithEvents cboFormato As ActivosFijos.Modulo.ComboBoxParametroDet
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
