<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteResumenDepreciacion
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
    Me.cbotipodepreciacion = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.btnmostrar = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcuerpo.SuspendLayout()
    Me.Panel1.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Size = New System.Drawing.Size(820, 446)
    '
    'Panel1
    '
    Me.Panel1.Controls.Add(Me.DateTimePicker1)
    Me.Panel1.Controls.Add(Me.btnmostrar)
    Me.Panel1.Controls.Add(Me.cbotipodepreciacion)
    Me.Panel1.Controls.Add(Me.Label1)
    Me.Panel1.Controls.Add(Me.Label18)
    Me.Panel1.Size = New System.Drawing.Size(820, 112)
    '
    'cbotipodepreciacion
    '
    Me.cbotipodepreciacion.AbriralEntrar = False
    Me.cbotipodepreciacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cbotipodepreciacion.FormattingEnabled = True
    Me.cbotipodepreciacion.Location = New System.Drawing.Point(134, 18)
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
    Me.cbotipodepreciacion.Size = New System.Drawing.Size(250, 21)
    Me.cbotipodepreciacion.TabIndex = 2
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(12, 21)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(110, 13)
    Me.Label18.TabIndex = 1
    Me.Label18.Text = "Tipo de depreciación:"
    '
    'btnmostrar
    '
    Me.btnmostrar.Location = New System.Drawing.Point(134, 81)
    Me.btnmostrar.Name = "btnmostrar"
    Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
    Me.btnmostrar.TabIndex = 5
    Me.btnmostrar.Text = "Mostrar"
    Me.btnmostrar.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(12, 50)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(40, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "Fecha:"
    '
    'DateTimePicker1
    '
    Me.DateTimePicker1.Location = New System.Drawing.Point(134, 44)
    Me.DateTimePicker1.Name = "DateTimePicker1"
    Me.DateTimePicker1.Size = New System.Drawing.Size(250, 20)
    Me.DateTimePicker1.TabIndex = 4
    '
    'FrmReporteResumenDepreciacion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(820, 495)
    Me.Name = "FrmReporteResumenDepreciacion"
    Me.PuedeImprimir = True
    Me.Text = "Reporte Resumen depreciación"
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcuerpo.ResumeLayout(False)
    Me.Panel1.ResumeLayout(False)
    Me.Panel1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents btnmostrar As System.Windows.Forms.Button
  Friend WithEvents cbotipodepreciacion As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
  Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
