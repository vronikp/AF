<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteTransaccionBaja
    Inherits Infoware.Consola.Base.FrmReporteBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlcuerpo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlcuerpo
        '
        Me.pnlcuerpo.Size = New System.Drawing.Size(851, 467)
        '
        'Panel1
        '
        Me.Panel1.Size = New System.Drawing.Size(851, 66)
        Me.Panel1.Visible = False
        '
        'FrmReporteTransaccionBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 516)
        Me.Name = "FrmReporteTransaccionBaja"
        Me.PuedeImprimir = True
        Me.Text = "Ficha de Activo"
        CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlcuerpo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class
