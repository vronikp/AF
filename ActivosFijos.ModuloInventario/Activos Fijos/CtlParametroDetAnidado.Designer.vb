<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlParametroDetAnidado
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.TreeviewParametroDet1 = New ActivosFijos.Modulo.TreeviewParametroDet()
    Me.SuspendLayout()
    '
    'FlowLayoutPanel1
    '
    Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
    Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
    Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
    Me.FlowLayoutPanel1.Size = New System.Drawing.Size(150, 34)
    Me.FlowLayoutPanel1.TabIndex = 0
    '
    'Timer1
    '
    Me.Timer1.Interval = 15000
    '
    'TreeviewParametroDet1
    '
    Me.TreeviewParametroDet1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TreeviewParametroDet1.Location = New System.Drawing.Point(0, 34)
    Me.TreeviewParametroDet1.Name = "TreeviewParametroDet1"
    Me.TreeviewParametroDet1.ParametroDet = Nothing
    Me.TreeviewParametroDet1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.TreeviewParametroDet1.PardetRaiz = Nothing
    Me.TreeviewParametroDet1.Size = New System.Drawing.Size(150, 116)
    Me.TreeviewParametroDet1.TabIndex = 1
    '
    'CtlParametroDetAnidado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TreeviewParametroDet1)
    Me.Controls.Add(Me.FlowLayoutPanel1)
    Me.Name = "CtlParametroDetAnidado"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
  Friend WithEvents TreeviewParametroDet1 As ActivosFijos.Modulo.TreeviewParametroDet
  Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
