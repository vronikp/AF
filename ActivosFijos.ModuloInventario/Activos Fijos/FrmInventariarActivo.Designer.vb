﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventariarActivo
  Inherits Infoware.Consola.Base.FrmMantenimientoSimpleBase

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
    Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventariarActivo))
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.pnlactivo = New System.Windows.Forms.Panel()
    Me.CtlActivo1 = New ActivosFijos.ModuloInventario.CtlActivo()
    Me.Panel3 = New System.Windows.Forms.Panel()
    Me.btnControlCabecera = New System.Windows.Forms.Button()
    Me.btncancelar = New System.Windows.Forms.Button()
    Me.btnNoInventariado = New System.Windows.Forms.Button()
    Me.btninventariar = New System.Windows.Forms.Button()
    Me.pnlCabecera = New System.Windows.Forms.Panel()
    Me.DataGridView1 = New Infoware.Consola.Base.DataGridViewAutoDiscover()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.pnlcierre = New System.Windows.Forms.Panel()
    Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
    Me.btnbuscaractivos = New System.Windows.Forms.ToolStripButton()
    Me.btnnuevo = New System.Windows.Forms.ToolStripButton()
    Me.btnAbrirActaEntrega = New System.Windows.Forms.ToolStripButton()
    Me.txtserie = New Infoware.Controles.Base.TextBoxStd()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtcodigobarra = New Infoware.Controles.Base.TextBoxStd()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.CtlBuscaCustodio = New ActivosFijos.ModuloInventario.CtlBuscaEmpleado()
    Me.CtlUbicacionActivo1 = New ActivosFijos.ModuloInventario.CtlParametroDetAnidado()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
    Me.pnlcuerpo.SuspendLayout()
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TabControl1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.pnlactivo.SuspendLayout()
    Me.Panel3.SuspendLayout()
    Me.pnlCabecera.SuspendLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.pnlcierre.SuspendLayout()
    Me.ToolStrip2.SuspendLayout()
    Me.SuspendLayout()
    '
    'pnlcuerpo
    '
    Me.pnlcuerpo.Controls.Add(Me.TabControl1)
    Me.pnlcuerpo.Size = New System.Drawing.Size(1020, 670)
    Me.pnlcuerpo.Controls.SetChildIndex(Me.TabControl1, 0)
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    Me.DataGridViewTextBoxColumn2.ReadOnly = True
    '
    'BindingSource1
    '
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 25)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(1020, 645)
    Me.TabControl1.TabIndex = 4
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.pnlactivo)
    Me.TabPage2.Controls.Add(Me.pnlCabecera)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(1012, 619)
    Me.TabPage2.TabIndex = 1
    Me.TabPage2.Text = "Nuevo"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'pnlactivo
    '
    Me.pnlactivo.Controls.Add(Me.CtlActivo1)
    Me.pnlactivo.Controls.Add(Me.Panel3)
    Me.pnlactivo.Dock = System.Windows.Forms.DockStyle.Fill
    Me.pnlactivo.Location = New System.Drawing.Point(276, 3)
    Me.pnlactivo.Name = "pnlactivo"
    Me.pnlactivo.Size = New System.Drawing.Size(733, 613)
    Me.pnlactivo.TabIndex = 2
    '
    'CtlActivo1
    '
    Me.CtlActivo1.Activo = Nothing
    Me.CtlActivo1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlActivo1.Location = New System.Drawing.Point(0, 35)
    Me.CtlActivo1.Name = "CtlActivo1"
    Me.CtlActivo1.Size = New System.Drawing.Size(733, 578)
    Me.CtlActivo1.TabIndex = 0
    '
    'Panel3
    '
    Me.Panel3.Controls.Add(Me.btnControlCabecera)
    Me.Panel3.Controls.Add(Me.btncancelar)
    Me.Panel3.Controls.Add(Me.btnNoInventariado)
    Me.Panel3.Controls.Add(Me.btninventariar)
    Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
    Me.Panel3.Location = New System.Drawing.Point(0, 0)
    Me.Panel3.Name = "Panel3"
    Me.Panel3.Size = New System.Drawing.Size(733, 35)
    Me.Panel3.TabIndex = 1
    '
    'btnControlCabecera
    '
    Me.btnControlCabecera.Location = New System.Drawing.Point(6, 5)
    Me.btnControlCabecera.Name = "btnControlCabecera"
    Me.btnControlCabecera.Size = New System.Drawing.Size(27, 23)
    Me.btnControlCabecera.TabIndex = 3
    Me.btnControlCabecera.Text = "<<"
    Me.btnControlCabecera.UseVisualStyleBackColor = True
    '
    'btncancelar
    '
    Me.btncancelar.Location = New System.Drawing.Point(289, 5)
    Me.btncancelar.Name = "btncancelar"
    Me.btncancelar.Size = New System.Drawing.Size(119, 23)
    Me.btncancelar.TabIndex = 1
    Me.btncancelar.Text = "Cancelar"
    Me.btncancelar.UseVisualStyleBackColor = True
    '
    'btnNoInventariado
    '
    Me.btnNoInventariado.Location = New System.Drawing.Point(164, 5)
    Me.btnNoInventariado.Name = "btnNoInventariado"
    Me.btnNoInventariado.Size = New System.Drawing.Size(119, 23)
    Me.btnNoInventariado.TabIndex = 2
    Me.btnNoInventariado.Text = "Desinventariar"
    Me.btnNoInventariado.UseVisualStyleBackColor = True
    '
    'btninventariar
    '
    Me.btninventariar.Location = New System.Drawing.Point(39, 5)
    Me.btninventariar.Name = "btninventariar"
    Me.btninventariar.Size = New System.Drawing.Size(119, 23)
    Me.btninventariar.TabIndex = 0
    Me.btninventariar.Text = "Inventariar"
    Me.btninventariar.UseVisualStyleBackColor = True
    '
    'pnlCabecera
    '
    Me.pnlCabecera.BackColor = System.Drawing.SystemColors.Info
    Me.pnlCabecera.Controls.Add(Me.DataGridView1)
    Me.pnlCabecera.Controls.Add(Me.pnlcierre)
    Me.pnlCabecera.Controls.Add(Me.txtserie)
    Me.pnlCabecera.Controls.Add(Me.Label2)
    Me.pnlCabecera.Controls.Add(Me.txtcodigobarra)
    Me.pnlCabecera.Controls.Add(Me.Label1)
    Me.pnlCabecera.Controls.Add(Me.CtlBuscaCustodio)
    Me.pnlCabecera.Controls.Add(Me.CtlUbicacionActivo1)
    Me.pnlCabecera.Controls.Add(Me.Label22)
    Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Left
    Me.pnlCabecera.Location = New System.Drawing.Point(3, 3)
    Me.pnlCabecera.Name = "pnlCabecera"
    Me.pnlCabecera.Padding = New System.Windows.Forms.Padding(5)
    Me.pnlCabecera.Size = New System.Drawing.Size(273, 613)
    Me.pnlCabecera.TabIndex = 1
    '
    'DataGridView1
    '
    Me.DataGridView1.AgruparRepetidos = False
    Me.DataGridView1.AllowUserToAddRows = False
    Me.DataGridView1.AllowUserToDeleteRows = False
    Me.DataGridView1.AutoGenerateColumns = False
    DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
    Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn23})
    Me.DataGridView1.DataSource = Me.BindingSource1
    DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
    DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
    DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
    Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
    Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.DataGridView1.Location = New System.Drawing.Point(5, 385)
    Me.DataGridView1.Name = "DataGridView1"
    Me.DataGridView1.ReadOnly = True
    DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
    DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
    DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
    DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
    DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
    DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
    Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
    Me.DataGridView1.Size = New System.Drawing.Size(263, 223)
    Me.DataGridView1.TabIndex = 23
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    Me.DataGridViewTextBoxColumn22.ReadOnly = True
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    Me.DataGridViewTextBoxColumn23.ReadOnly = True
    '
    'pnlcierre
    '
    Me.pnlcierre.Controls.Add(Me.ToolStrip2)
    Me.pnlcierre.Dock = System.Windows.Forms.DockStyle.Top
    Me.pnlcierre.Location = New System.Drawing.Point(5, 350)
    Me.pnlcierre.Name = "pnlcierre"
    Me.pnlcierre.Size = New System.Drawing.Size(263, 35)
    Me.pnlcierre.TabIndex = 22
    '
    'ToolStrip2
    '
    Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
    Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnbuscaractivos, Me.btnnuevo, Me.btnAbrirActaEntrega})
    Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
    Me.ToolStrip2.Name = "ToolStrip2"
    Me.ToolStrip2.Size = New System.Drawing.Size(263, 25)
    Me.ToolStrip2.TabIndex = 1
    Me.ToolStrip2.Text = "ToolStrip2"
    '
    'btnbuscaractivos
    '
    Me.btnbuscaractivos.Image = CType(resources.GetObject("btnbuscaractivos.Image"), System.Drawing.Image)
    Me.btnbuscaractivos.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnbuscaractivos.Name = "btnbuscaractivos"
    Me.btnbuscaractivos.Size = New System.Drawing.Size(62, 22)
    Me.btnbuscaractivos.Text = "Buscar"
    '
    'btnnuevo
    '
    Me.btnnuevo.Image = CType(resources.GetObject("btnnuevo.Image"), System.Drawing.Image)
    Me.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnnuevo.Name = "btnnuevo"
    Me.btnnuevo.Size = New System.Drawing.Size(62, 22)
    Me.btnnuevo.Text = "Nuevo"
    '
    'btnAbrirActaEntrega
    '
    Me.btnAbrirActaEntrega.Image = CType(resources.GetObject("btnAbrirActaEntrega.Image"), System.Drawing.Image)
    Me.btnAbrirActaEntrega.ImageTransparentColor = System.Drawing.Color.Magenta
    Me.btnAbrirActaEntrega.Name = "btnAbrirActaEntrega"
    Me.btnAbrirActaEntrega.Size = New System.Drawing.Size(110, 22)
    Me.btnAbrirActaEntrega.Text = "Acta de Entrega"
    '
    'txtserie
    '
    Me.txtserie.Dock = System.Windows.Forms.DockStyle.Top
    Me.txtserie.Location = New System.Drawing.Point(5, 330)
    Me.txtserie.Margin = New System.Windows.Forms.Padding(2)
    Me.txtserie.Mensaje = ""
    Me.txtserie.Name = "txtserie"
    Me.txtserie.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtserie.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtserie.PromptText = ""
    Me.txtserie.Size = New System.Drawing.Size(263, 20)
    Me.txtserie.TabIndex = 9
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label2.Location = New System.Drawing.Point(5, 317)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(31, 13)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Serie"
    '
    'txtcodigobarra
    '
    Me.txtcodigobarra.Dock = System.Windows.Forms.DockStyle.Top
    Me.txtcodigobarra.Location = New System.Drawing.Point(5, 297)
    Me.txtcodigobarra.Margin = New System.Windows.Forms.Padding(2)
    Me.txtcodigobarra.Mensaje = ""
    Me.txtcodigobarra.Name = "txtcodigobarra"
    Me.txtcodigobarra.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtcodigobarra.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtcodigobarra.PromptText = ""
    Me.txtcodigobarra.Size = New System.Drawing.Size(263, 20)
    Me.txtcodigobarra.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label1.Location = New System.Drawing.Point(5, 284)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(87, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Código de barras"
    '
    'CtlBuscaCustodio
    '
    Me.CtlBuscaCustodio.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlBuscaCustodio.Empleado = Nothing
    Me.CtlBuscaCustodio.EmpleadoText = "Custodio"
    Me.CtlBuscaCustodio.ItemText = "Custodio"
    Me.CtlBuscaCustodio.Location = New System.Drawing.Point(5, 237)
    Me.CtlBuscaCustodio.Name = "CtlBuscaCustodio"
    Me.CtlBuscaCustodio.Size = New System.Drawing.Size(263, 47)
    Me.CtlBuscaCustodio.SoloActivos = False
    Me.CtlBuscaCustodio.TabIndex = 5
    Me.CtlBuscaCustodio.TipoEmpleado = Nothing
    Me.CtlBuscaCustodio.Ubicacion = ActivosFijos.ModuloInventario.CtlBuscaEmpleado.EnumUbicacion.Abajo
    '
    'CtlUbicacionActivo1
    '
    Me.CtlUbicacionActivo1.Dock = System.Windows.Forms.DockStyle.Top
    Me.CtlUbicacionActivo1.Location = New System.Drawing.Point(5, 18)
    Me.CtlUbicacionActivo1.Name = "CtlUbicacionActivo1"
    Me.CtlUbicacionActivo1.ParametroDet = Nothing
    Me.CtlUbicacionActivo1.ParametroEnum = ActivosFijos.Reglas.Enumerados.EnumParametros.UbicacionActivo
    Me.CtlUbicacionActivo1.PardetRaiz = Nothing
    Me.CtlUbicacionActivo1.Size = New System.Drawing.Size(263, 219)
    Me.CtlUbicacionActivo1.SoloVisibles = False
    Me.CtlUbicacionActivo1.TabIndex = 4
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
    Me.Label22.Location = New System.Drawing.Point(5, 5)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(55, 13)
    Me.Label22.TabIndex = 3
    Me.Label22.Text = "Ubicación"
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    Me.DataGridViewTextBoxColumn21.ReadOnly = True
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    Me.DataGridViewTextBoxColumn20.ReadOnly = True
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    Me.DataGridViewTextBoxColumn19.ReadOnly = True
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    Me.DataGridViewTextBoxColumn18.ReadOnly = True
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    Me.DataGridViewTextBoxColumn17.ReadOnly = True
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    Me.DataGridViewTextBoxColumn16.ReadOnly = True
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    Me.DataGridViewTextBoxColumn15.ReadOnly = True
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    Me.DataGridViewTextBoxColumn14.ReadOnly = True
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
    'FrmInventariarActivo
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1020, 719)
    Me.Name = "FrmInventariarActivo"
    Me.Text = "Inventariar Activo"
    Me.pnlcuerpo.ResumeLayout(False)
    CType(Me.ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.pnlactivo.ResumeLayout(False)
    Me.Panel3.ResumeLayout(False)
    Me.pnlCabecera.ResumeLayout(False)
    Me.pnlCabecera.PerformLayout()
    CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.pnlcierre.ResumeLayout(False)
    Me.pnlcierre.PerformLayout()
    Me.ToolStrip2.ResumeLayout(False)
    Me.ToolStrip2.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents CtlActivo1 As ActivosFijos.ModuloInventario.CtlActivo
  Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
  Friend WithEvents CtlBuscaCustodio As ActivosFijos.ModuloInventario.CtlBuscaEmpleado
  Friend WithEvents CtlUbicacionActivo1 As ActivosFijos.ModuloInventario.CtlParametroDetAnidado
  Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtserie As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcodigobarra As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlcierre As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnbuscaractivos As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As Infoware.Consola.Base.DataGridViewAutoDiscover
    Friend WithEvents pnlactivo As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btninventariar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnnuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNoInventariado As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnControlCabecera As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAbrirActaEntrega As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
End Class
