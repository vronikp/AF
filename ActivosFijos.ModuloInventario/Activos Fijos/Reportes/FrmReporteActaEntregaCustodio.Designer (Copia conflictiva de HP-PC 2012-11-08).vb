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
    Me.Label18 = New System.Windows.Forms.Label()
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.pnlsoloinventariados = New System.Windows.Forms.Panel()
    Me.cboPeriodoInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnActaConstatacion = New System.Windows.Forms.Button()
    Me.btnCambioCustodioSRI = New System.Windows.Forms.Button()
    Me.cbociudad = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.CtlBuscaCustodio = New ActivosFijos.Modulo.CtlBuscaEmpleado()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.pnlsoloinventariados.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(1099, 504)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.pnlsoloinventariados)
    Me.Panel1.Controls.Add(Me.CheckBox1)
    Me.Panel1.Controls.Add(Me.DateTimePicker1)
    Me.Panel1.Controls.Add(Me.btnmostrar)
    Me.Panel1.Controls.Add(Me.cbociudad)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label18)
    Me.Panel1.Controls.Add(Me.CtlBuscaCustodio)
    Me.Panel1.Size = New System.Drawing.Size(1099, 138)
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(12, 47)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(43, 13)
    Me.Label18.TabIndex = 1
    Me.Label18.Text = "Ciudad:"
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(134, 106)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(158, 23)
    Me.btnmostrar.TabIndex = 5
    Me.btnmostrar.Text = "Acta de entrega"
    Me.btnmostrar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 76)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Fecha:"
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Location = New System.Drawing.Point(134, 70)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(250, 20)
    Me.DateTimePicker1.TabIndex = 4
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Location = New System.Drawing.Point(435, 17)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(165, 17)
    Me.CheckBox1.TabIndex = 6
    Me.CheckBox1.Text = "Solo activos inventariados en"
    Me.CheckBox1.UseVisualStyleBackColor = True
    Me.CheckBox1.Visible = False
    '
    'pnlsoloinventariados
    '
    Me.pnlsoloinventariados.Controls.Add(Me.cboPeriodoInventario)
    Me.pnlsoloinventariados.Controls.Add(Me.Label2)
    Me.pnlsoloinventariados.Controls.Add(Me.btnActaConstatacion)
    Me.pnlsoloinventariados.Controls.Add(Me.btnCambioCustodioSRI)
    Me.pnlsoloinventariados.Location = New System.Drawing.Point(457, 37)
    Me.pnlsoloinventariados.Name = "pnlsoloinventariados"
    Me.pnlsoloinventariados.Size = New System.Drawing.Size(634, 95)
    Me.pnlsoloinventariados.TabIndex = 7
    '
    'cboPeriodoInventario
    '
    Me.cboPeriodoInventario.AbriralEntrar = False
    Me.cboPeriodoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboPeriodoInventario.FormattingEnabled = True
    Me.cboPeriodoInventario.Location = New System.Drawing.Point(129, 7)
    Me.cboPeriodoInventario.Margin = New System.Windows.Forms.Padding(2)
    Me.cboPeriodoInventario.MostrarRutaCompleta = False
    Me.cboPeriodoInventario.Name = "cboPeriodoInventario"
    Me.cboPeriodoInventario.OperadorDatos = Nothing
    Me.cboPeriodoInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cboPeriodoInventario.ParametroDet = Nothing
    Me.cboPeriodoInventario.PuedeActualizar = True
    Me.cboPeriodoInventario.PuedeEliminar = True
    Me.cboPeriodoInventario.PuedeModificar = True
    Me.cboPeriodoInventario.PuedeNuevo = True
    Me.cboPeriodoInventario.Size = New System.Drawing.Size(451, 21)
    Me.cboPeriodoInventario.TabIndex = 4
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(7, 10)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(95, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Periodo inventario:"
    '
    'btnActaConstatacion
    '
    Me.btnActaConstatacion.Location = New System.Drawing.Point(10, 69)
    Me.btnActaConstatacion.Name = "btnActaConstatacion"
    Me.btnActaConstatacion.Size = New System.Drawing.Size(158, 23)
    Me.btnActaConstatacion.TabIndex = 5
    Me.btnActaConstatacion.Text = "Acta de constatación SRI"
    Me.btnActaConstatacion.UseVisualStyleBackColor = True
    '
    'btnCambioCustodioSRI
    '
    Me.btnCambioCustodioSRI.Location = New System.Drawing.Point(174, 69)
    Me.btnCambioCustodioSRI.Name = "btnCambioCustodioSRI"
    Me.btnCambioCustodioSRI.Size = New System.Drawing.Size(222, 23)
    Me.btnCambioCustodioSRI.TabIndex = 5
    Me.btnCambioCustodioSRI.Text = "Cambio Custodio por Constatación SRI"
    Me.btnCambioCustodioSRI.UseVisualStyleBackColor = True
    '
    'cbociudad
    '
    Me.cbociudad.AbriralEntrar = False
    Me.cbociudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbociudad.FormattingEnabled = True
    Me.cbociudad.Location = New System.Drawing.Point(134, 44)
    Me.cbociudad.Margin = New System.Windows.Forms.Padding(2)
    Me.cbociudad.MostrarRutaCompleta = False
    Me.cbociudad.Name = "cbociudad"
    Me.cbociudad.OperadorDatos = Nothing
    Me.cbociudad.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.cbociudad.ParametroDet = Nothing
    Me.cbociudad.PuedeActualizar = True
    Me.cbociudad.PuedeEliminar = True
    Me.cbociudad.PuedeModificar = True
    Me.cbociudad.PuedeNuevo = True
    Me.cbociudad.Size = New System.Drawing.Size(250, 21)
    Me.cbociudad.TabIndex = 2
    '
    'CtlBuscaCustodio
    '
    Me.CtlBuscaCustodio.Empleado = Nothing
    Me.CtlBuscaCustodio.EmpleadoText = "Custodio"
    Me.CtlBuscaCustodio.ItemText = "Custodio"
    Me.CtlBuscaCustodio.Location = New System.Drawing.Point(12, 17)
    Me.CtlBuscaCustodio.Name = "CtlBuscaCustodio"
    Me.CtlBuscaCustodio.Size = New System.Drawing.Size(372, 22)
    Me.CtlBuscaCustodio.TabIndex = 0
    Me.CtlBuscaCustodio.TipoEmpleado = Nothing
    Me.CtlBuscaCustodio.Ubicacion = ActivosFijos.Modulo.CtlBuscaEmpleado.EnumUbicacion.Normal
    '
    'FrmReporteActaEntregaCustodio
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1099, 553)
    Me.Name = "FrmReporteActaEntregaCustodio"
    Me.PuedeImprimir = True
    Me.Text = "Acta de Entrega a Custodio"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.pnlsoloinventariados.ResumeLayout(False)
    Me.pnlsoloinventariados.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

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
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents btnActaConstatacion As System.Windows.Forms.Button
  Friend WithEvents btnCambioCustodioSRI As System.Windows.Forms.Button
End Class
