<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoInventario
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDesinventariar = New System.Windows.Forms.Button()
        Me.chkSolicitarConfirmacion = New System.Windows.Forms.CheckBox()
        Me.btninventariar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.cboEstadoInventario = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboperiodo = New ActivosFijos.Modulo.ComboBoxParametroDet()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CtlUbicacionActivo1 = New ActivosFijos.Modulo.CtlParametroDetAnidado()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgdets = New Infoware.Consola.Base.DataGridViewAutoDiscover()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsdets = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtdescripcion = New Infoware.Controles.Base.TextBoxStd()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgdets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsdets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnDesinventariar)
        Me.Panel1.Controls.Add(Me.chkSolicitarConfirmacion)
        Me.Panel1.Controls.Add(Me.btninventariar)
        Me.Panel1.Controls.Add(Me.btnmostrar)
        Me.Panel1.Controls.Add(Me.cboEstadoInventario)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboperiodo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.CtlUbicacionActivo1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtdescripcion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtfecha)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 585)
        Me.Panel1.TabIndex = 0
        '
        'btnDesinventariar
        '
        Me.btnDesinventariar.Location = New System.Drawing.Point(264, 269)
        Me.btnDesinventariar.Name = "btnDesinventariar"
        Me.btnDesinventariar.Size = New System.Drawing.Size(116, 23)
        Me.btnDesinventariar.TabIndex = 38
        Me.btnDesinventariar.Text = "Desinventariar"
        Me.btnDesinventariar.UseVisualStyleBackColor = True
        '
        'chkSolicitarConfirmacion
        '
        Me.chkSolicitarConfirmacion.AutoSize = True
        Me.chkSolicitarConfirmacion.Location = New System.Drawing.Point(142, 249)
        Me.chkSolicitarConfirmacion.Name = "chkSolicitarConfirmacion"
        Me.chkSolicitarConfirmacion.Size = New System.Drawing.Size(213, 17)
        Me.chkSolicitarConfirmacion.TabIndex = 37
        Me.chkSolicitarConfirmacion.Text = "Solicitar confirmación al nuevo custodio"
        Me.chkSolicitarConfirmacion.UseVisualStyleBackColor = True
        '
        'btninventariar
        '
        Me.btninventariar.Location = New System.Drawing.Point(386, 269)
        Me.btninventariar.Name = "btninventariar"
        Me.btninventariar.Size = New System.Drawing.Size(116, 23)
        Me.btninventariar.TabIndex = 11
        Me.btninventariar.Text = "Inventariar"
        Me.btninventariar.UseVisualStyleBackColor = True
        Me.btninventariar.Visible = False
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(141, 269)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(117, 23)
        Me.btnmostrar.TabIndex = 10
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'cboEstadoInventario
        '
        Me.cboEstadoInventario.AbriralEntrar = False
        Me.cboEstadoInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEstadoInventario.FormattingEnabled = True
        Me.cboEstadoInventario.Location = New System.Drawing.Point(142, 223)
        Me.cboEstadoInventario.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEstadoInventario.MostrarRutaCompleta = False
        Me.cboEstadoInventario.Name = "cboEstadoInventario"
        Me.cboEstadoInventario.OperadorDatos = Nothing
        Me.cboEstadoInventario.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboEstadoInventario.ParametroDet = Nothing
        Me.cboEstadoInventario.PuedeActualizar = True
        Me.cboEstadoInventario.PuedeEliminar = True
        Me.cboEstadoInventario.PuedeModificar = True
        Me.cboEstadoInventario.PuedeNuevo = True
        Me.cboEstadoInventario.Size = New System.Drawing.Size(200, 21)
        Me.cboEstadoInventario.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Estado inventario:"
        '
        'cboperiodo
        '
        Me.cboperiodo.AbriralEntrar = False
        Me.cboperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboperiodo.FormattingEnabled = True
        Me.cboperiodo.Location = New System.Drawing.Point(142, 148)
        Me.cboperiodo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboperiodo.MostrarRutaCompleta = False
        Me.cboperiodo.Name = "cboperiodo"
        Me.cboperiodo.OperadorDatos = Nothing
        Me.cboperiodo.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
        Me.cboperiodo.ParametroDet = Nothing
        Me.cboperiodo.PuedeActualizar = True
        Me.cboperiodo.PuedeEliminar = True
        Me.cboperiodo.PuedeModificar = True
        Me.cboperiodo.PuedeNuevo = True
        Me.cboperiodo.Size = New System.Drawing.Size(200, 21)
        Me.cboperiodo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Periodo:"
        '
        'CtlUbicacionActivo1
        '
        Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(142, 17)
        Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
        Me.CtlUbicacionActivo1.ParametroDet = Nothing
        Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
        Me.CtlUbicacionActivo1.PardetRaiz = Nothing
        Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(200, 126)
        Me.CtlUbicacionActivo1.SoloVisibles = False
        Me.CtlUbicacionActivo1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.dgdets)
        Me.Panel2.Location = New System.Drawing.Point(15, 307)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 266)
        Me.Panel2.TabIndex = 36
        '
        'dgdets
        '
        Me.dgdets.AgruparRepetidos = False
        Me.dgdets.AllowUserToAddRows = False
        Me.dgdets.AllowUserToDeleteRows = False
        Me.dgdets.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdets.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgdets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdets.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17})
        Me.dgdets.DataSource = Me.bsdets
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgdets.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgdets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgdets.Location = New System.Drawing.Point(0, 0)
        Me.dgdets.Name = "dgdets"
        Me.dgdets.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgdets.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgdets.RowHeadersVisible = False
        Me.dgdets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgdets.Size = New System.Drawing.Size(672, 266)
        Me.dgdets.TabIndex = 0
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(142, 173)
        Me.txtdescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdescripcion.Mensaje = ""
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtdescripcion.PromptText = ""
        Me.txtdescripcion.Size = New System.Drawing.Size(360, 20)
        Me.txtdescripcion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ubicación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción:"
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(142, 198)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtfecha.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 202)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Fecha:"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'FrmMantenimientoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 634)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmMantenimientoInventario"
        Me.PuedeGuardarcerrar = True
        Me.PuedeGuardarnuevo = True
        Me.PuedeMover = True
        Me.Text = "Inventario"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgdets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsdets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgdets As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsdets As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.Modulo.CtlParametroDetAnidado
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboperiodo As ActivosFijos.Modulo.ComboBoxParametroDet
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboEstadoInventario As ActivosFijos.Modulo.ComboBoxParametroDet
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnmostrar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btninventariar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkSolicitarConfirmacion As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDesinventariar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
