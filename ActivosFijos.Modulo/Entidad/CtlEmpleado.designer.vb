Imports ActivosFijos.Reglas

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlEmpleado
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
    Me.TabControl1 = New System.Windows.Forms.TabControl()
    Me.TabPage1 = New System.Windows.Forms.TabPage()
    Me.CtlEntidadNatural1 = New ActivosFijos.Modulo.CtlEntidadNatural()
    Me.TabPage2 = New System.Windows.Forms.TabPage()
    Me.Label11 = New System.Windows.Forms.Label()
    Me.Label13 = New System.Windows.Forms.Label()
    Me.dtfecafiliess = New System.Windows.Forms.DateTimePicker()
    Me.CtlFotoPersona1 = New Infoware.Controles.Base.ImagenSQL()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtjubpatronal = New Infoware.Controles.Base.TextBoxCalculator()
    Me.txtpresquirog = New Infoware.Controles.Base.TextBoxCalculator()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label36 = New System.Windows.Forms.Label()
    Me.Label18 = New System.Windows.Forms.Label()
    Me.Label24 = New System.Windows.Forms.Label()
    Me.Label30 = New System.Windows.Forms.Label()
    Me.Label33 = New System.Windows.Forms.Label()
    Me.txtnumcta = New System.Windows.Forms.TextBox()
    Me.chkexclfam = New System.Windows.Forms.CheckBox()
    Me.Label20 = New System.Windows.Forms.Label()
    Me.cboNacionalidad = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.cboSectorDomicilio = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.CtlUbicacion1 = New ActivosFijos.Modulo.CtlUbicacion()
    Me.ComboBoxTipoEmpleado = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.ComboBoxTipoCtaBancaria = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.ComboBoxBanco = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.ComboBoxFormaPagoRol = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.TabPage3 = New System.Windows.Forms.TabPage()
    Me.chkdiscapsicologica = New System.Windows.Forms.CheckBox()
    Me.chkdiscaintelectual = New System.Windows.Forms.CheckBox()
    Me.chkdiscavisual = New System.Windows.Forms.CheckBox()
    Me.chkdiscalinguistica = New System.Windows.Forms.CheckBox()
    Me.chkdiscaauditiva = New System.Windows.Forms.CheckBox()
    Me.chkdiscafisica = New System.Windows.Forms.CheckBox()
    Me.txtenfermedad = New System.Windows.Forms.TextBox()
    Me.Label12 = New System.Windows.Forms.Label()
    Me.Label10 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.Label17 = New System.Windows.Forms.Label()
    Me.txtavisoemer = New System.Windows.Forms.TextBox()
    Me.Label15 = New System.Windows.Forms.Label()
    Me.ComboBoxSeguroCorporativo = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.ComboBoxDiscapacidad = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.ComboBoxTipoSangre = New ActivosFijos.Modulo.ComboBoxParametroDet()
    Me.TabPage4 = New System.Windows.Forms.TabPage()
    Me.chckTitulo = New System.Windows.Forms.CheckBox()
    Me.txtEspecializacion = New System.Windows.Forms.TextBox()
    Me.Label19 = New System.Windows.Forms.Label()
    Me.chckBachiller = New System.Windows.Forms.CheckBox()
    Me.txtprimaria = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.txtsecundaria = New System.Windows.Forms.TextBox()
    Me.Label7 = New System.Windows.Forms.Label()
    Me.Label8 = New System.Windows.Forms.Label()
    Me.txtcursos = New System.Windows.Forms.TextBox()
    Me.txtsuperior = New System.Windows.Forms.TextBox()
    Me.txtrefper = New System.Windows.Forms.TextBox()
    Me.Label9 = New System.Windows.Forms.Label()
    Me.Label22 = New System.Windows.Forms.Label()
    Me.txtreflab = New System.Windows.Forms.TextBox()
    Me.txtsecanio = New System.Windows.Forms.TextBox()
    Me.Label23 = New System.Windows.Forms.Label()
    Me.txtprianio = New System.Windows.Forms.TextBox()
    Me.txtsupanio = New System.Windows.Forms.TextBox()
    Me.Label25 = New System.Windows.Forms.Label()
    Me.Label27 = New System.Windows.Forms.Label()
    Me.Label26 = New System.Windows.Forms.Label()
    Me.txtbachiller = New System.Windows.Forms.TextBox()
    Me.Label28 = New System.Windows.Forms.Label()
    Me.txttitulo = New System.Windows.Forms.TextBox()
    Me.Label29 = New System.Windows.Forms.Label()
    Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn212 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BScontratosterminados = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn213 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSaplicacion = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn214 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.BSselecciondetalle = New System.Windows.Forms.BindingSource(Me.components)
    Me.DataGridViewTextBoxColumn209 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn210 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn211 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn206 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn207 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn208 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn203 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn204 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn205 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn200 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn201 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn202 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn197 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn198 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn199 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn194 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn195 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn196 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn191 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn192 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn193 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn188 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn189 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn190 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn185 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn186 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn187 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn182 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn183 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn184 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn179 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn180 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn181 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn176 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn177 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn178 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn173 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn174 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn175 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn170 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn171 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn172 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn167 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn168 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn169 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn164 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn165 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn166 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn161 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn162 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn163 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn158 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn159 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn160 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn155 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn156 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn157 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn152 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn153 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn154 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn149 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn150 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn151 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn146 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn147 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn148 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn143 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn144 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn145 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn140 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn141 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn142 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn137 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn138 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn139 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn134 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn135 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn136 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn131 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn132 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn133 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn128 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn129 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn130 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn125 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn126 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn127 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn122 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn123 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn124 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn119 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn120 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn121 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn116 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn117 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn118 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn113 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn114 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn115 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn110 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn111 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn112 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn107 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn108 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn109 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn104 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn105 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn106 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn101 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn102 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn103 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn98 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn99 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn100 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn95 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn96 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn97 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn92 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn93 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn94 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn89 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn90 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn91 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn86 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn87 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn88 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn83 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn84 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn85 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn80 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn81 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn82 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn77 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn78 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn79 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn74 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn75 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn76 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn71 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn72 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn73 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn68 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn69 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn70 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn65 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn66 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn67 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn62 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn63 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn64 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn59 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn61 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.DataGridViewTextBoxColumn60 = New System.Windows.Forms.DataGridViewTextBoxColumn()
    Me.chkVisible = New System.Windows.Forms.CheckBox()
    Me.TabControl1.SuspendLayout()
    Me.TabPage1.SuspendLayout()
    Me.TabPage2.SuspendLayout()
    Me.TabPage3.SuspendLayout()
    Me.TabPage4.SuspendLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BScontratosterminados, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSaplicacion, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.BSselecciondetalle, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'TabControl1
    '
    Me.TabControl1.Controls.Add(Me.TabPage1)
    Me.TabControl1.Controls.Add(Me.TabPage2)
    Me.TabControl1.Controls.Add(Me.TabPage3)
    Me.TabControl1.Controls.Add(Me.TabPage4)
    Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TabControl1.Location = New System.Drawing.Point(0, 0)
    Me.TabControl1.Name = "TabControl1"
    Me.TabControl1.SelectedIndex = 0
    Me.TabControl1.Size = New System.Drawing.Size(793, 381)
    Me.TabControl1.TabIndex = 0
    '
    'TabPage1
    '
    Me.TabPage1.Controls.Add(Me.CtlEntidadNatural1)
    Me.TabPage1.Location = New System.Drawing.Point(4, 22)
    Me.TabPage1.Name = "TabPage1"
    Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage1.Size = New System.Drawing.Size(785, 355)
    Me.TabPage1.TabIndex = 0
    Me.TabPage1.Text = "Datos personales"
    Me.TabPage1.UseVisualStyleBackColor = True
    '
    'CtlEntidadNatural1
    '
    Me.CtlEntidadNatural1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.CtlEntidadNatural1.Entidad = Nothing
    Me.CtlEntidadNatural1.Location = New System.Drawing.Point(3, 3)
    Me.CtlEntidadNatural1.Name = "CtlEntidadNatural1"
    Me.CtlEntidadNatural1.PuedeSRI = False
    Me.CtlEntidadNatural1.Size = New System.Drawing.Size(779, 349)
    Me.CtlEntidadNatural1.TabIndex = 1
    '
    'TabPage2
    '
    Me.TabPage2.Controls.Add(Me.chkVisible)
    Me.TabPage2.Controls.Add(Me.Label11)
    Me.TabPage2.Controls.Add(Me.Label13)
    Me.TabPage2.Controls.Add(Me.dtfecafiliess)
    Me.TabPage2.Controls.Add(Me.CtlFotoPersona1)
    Me.TabPage2.Controls.Add(Me.Label3)
    Me.TabPage2.Controls.Add(Me.Label2)
    Me.TabPage2.Controls.Add(Me.Label1)
    Me.TabPage2.Controls.Add(Me.txtjubpatronal)
    Me.TabPage2.Controls.Add(Me.txtpresquirog)
    Me.TabPage2.Controls.Add(Me.Label4)
    Me.TabPage2.Controls.Add(Me.Label36)
    Me.TabPage2.Controls.Add(Me.Label18)
    Me.TabPage2.Controls.Add(Me.Label24)
    Me.TabPage2.Controls.Add(Me.Label30)
    Me.TabPage2.Controls.Add(Me.Label33)
    Me.TabPage2.Controls.Add(Me.txtnumcta)
    Me.TabPage2.Controls.Add(Me.chkexclfam)
    Me.TabPage2.Controls.Add(Me.Label20)
    Me.TabPage2.Controls.Add(Me.cboNacionalidad)
    Me.TabPage2.Controls.Add(Me.cboSectorDomicilio)
    Me.TabPage2.Controls.Add(Me.CtlUbicacion1)
    Me.TabPage2.Controls.Add(Me.ComboBoxTipoEmpleado)
    Me.TabPage2.Controls.Add(Me.ComboBoxTipoCtaBancaria)
    Me.TabPage2.Controls.Add(Me.ComboBoxBanco)
    Me.TabPage2.Controls.Add(Me.ComboBoxFormaPagoRol)
    Me.TabPage2.Location = New System.Drawing.Point(4, 22)
    Me.TabPage2.Name = "TabPage2"
    Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage2.Size = New System.Drawing.Size(785, 355)
    Me.TabPage2.TabIndex = 2
    Me.TabPage2.Text = "Datos adicionales"
    Me.TabPage2.UseVisualStyleBackColor = True
    '
    'Label11
    '
    Me.Label11.AutoSize = True
    Me.Label11.Location = New System.Drawing.Point(274, 287)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(72, 13)
    Me.Label11.TabIndex = 23
    Me.Label11.Text = "Nacionalidad:"
    '
    'Label13
    '
    Me.Label13.AutoSize = True
    Me.Label13.Location = New System.Drawing.Point(274, 260)
    Me.Label13.Name = "Label13"
    Me.Label13.Size = New System.Drawing.Size(86, 13)
    Me.Label13.TabIndex = 21
    Me.Label13.Text = "Sector Domicilio:"
    '
    'dtfecafiliess
    '
    Me.dtfecafiliess.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
    Me.dtfecafiliess.Location = New System.Drawing.Point(408, 140)
    Me.dtfecafiliess.Name = "dtfecafiliess"
    Me.dtfecafiliess.Size = New System.Drawing.Size(129, 20)
    Me.dtfecafiliess.TabIndex = 15
    '
    'CtlFotoPersona1
    '
    Me.CtlFotoPersona1.ArchivoImagen = ""
    Me.CtlFotoPersona1.BackColor = System.Drawing.Color.Transparent
    Me.CtlFotoPersona1.Imagen = Nothing
    Me.CtlFotoPersona1.Location = New System.Drawing.Point(88, 6)
    Me.CtlFotoPersona1.Name = "CtlFotoPersona1"
    Me.CtlFotoPersona1.Padding = New System.Windows.Forms.Padding(3)
    Me.CtlFotoPersona1.Size = New System.Drawing.Size(103, 101)
    Me.CtlFotoPersona1.TabIndex = 1
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Location = New System.Drawing.Point(6, 9)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(31, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "Foto:"
    '
    'Label2
    '
    Me.Label2.Location = New System.Drawing.Point(6, 116)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(76, 40)
    Me.Label2.TabIndex = 2
    Me.Label2.Text = "Lugar de nacimiento:"
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(274, 116)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(95, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Tipo de empleado:"
    '
    'txtjubpatronal
    '
    Me.txtjubpatronal.Location = New System.Drawing.Point(408, 192)
    Me.txtjubpatronal.Mensaje = ""
    Me.txtjubpatronal.Name = "txtjubpatronal"
    Me.txtjubpatronal.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtjubpatronal.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtjubpatronal.PromptText = ""
    Me.txtjubpatronal.Size = New System.Drawing.Size(129, 20)
    Me.txtjubpatronal.TabIndex = 19
    Me.txtjubpatronal.Text = "0,00"
    Me.txtjubpatronal.Value = 0.0R
    '
    'txtpresquirog
    '
    Me.txtpresquirog.Location = New System.Drawing.Point(408, 166)
    Me.txtpresquirog.Mensaje = ""
    Me.txtpresquirog.Name = "txtpresquirog"
    Me.txtpresquirog.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtpresquirog.PromptForeColor = System.Drawing.SystemColors.GrayText
    Me.txtpresquirog.PromptText = ""
    Me.txtpresquirog.Size = New System.Drawing.Size(129, 20)
    Me.txtpresquirog.TabIndex = 17
    Me.txtpresquirog.Text = "0,00"
    Me.txtpresquirog.Value = 0.0R
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(275, 143)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(111, 13)
    Me.Label4.TabIndex = 14
    Me.Label4.Text = "Fecha afiliación IESS:"
    '
    'Label36
    '
    Me.Label36.AutoSize = True
    Me.Label36.Location = New System.Drawing.Point(274, 195)
    Me.Label36.Name = "Label36"
    Me.Label36.Size = New System.Drawing.Size(98, 13)
    Me.Label36.TabIndex = 18
    Me.Label36.Text = "Jubilación patronal:"
    '
    'Label18
    '
    Me.Label18.AutoSize = True
    Me.Label18.Location = New System.Drawing.Point(274, 36)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(41, 13)
    Me.Label18.TabIndex = 6
    Me.Label18.Text = "Banco:"
    '
    'Label24
    '
    Me.Label24.AutoSize = True
    Me.Label24.Location = New System.Drawing.Point(274, 63)
    Me.Label24.Name = "Label24"
    Me.Label24.Size = New System.Drawing.Size(82, 13)
    Me.Label24.TabIndex = 8
    Me.Label24.Text = "Tipo de cuenta:"
    '
    'Label30
    '
    Me.Label30.AutoSize = True
    Me.Label30.Location = New System.Drawing.Point(274, 9)
    Me.Label30.Name = "Label30"
    Me.Label30.Size = New System.Drawing.Size(81, 13)
    Me.Label30.TabIndex = 4
    Me.Label30.Text = "Forma de pago:"
    '
    'Label33
    '
    Me.Label33.AutoSize = True
    Me.Label33.Location = New System.Drawing.Point(274, 90)
    Me.Label33.Name = "Label33"
    Me.Label33.Size = New System.Drawing.Size(65, 13)
    Me.Label33.TabIndex = 10
    Me.Label33.Text = "Número cta:"
    '
    'txtnumcta
    '
    Me.txtnumcta.Location = New System.Drawing.Point(408, 87)
    Me.txtnumcta.Name = "txtnumcta"
    Me.txtnumcta.Size = New System.Drawing.Size(129, 20)
    Me.txtnumcta.TabIndex = 11
    '
    'chkexclfam
    '
    Me.chkexclfam.AutoSize = True
    Me.chkexclfam.Location = New System.Drawing.Point(278, 218)
    Me.chkexclfam.Name = "chkexclfam"
    Me.chkexclfam.Size = New System.Drawing.Size(167, 17)
    Me.chkexclfam.TabIndex = 20
    Me.chkexclfam.Text = "Excluir familiares por ficha roja"
    '
    'Label20
    '
    Me.Label20.AutoSize = True
    Me.Label20.Location = New System.Drawing.Point(275, 169)
    Me.Label20.Name = "Label20"
    Me.Label20.Size = New System.Drawing.Size(115, 13)
    Me.Label20.TabIndex = 16
    Me.Label20.Text = "Préstamo quirografario:"
    '
    'cboNacionalidad
    '
    Me.cboNacionalidad.AbriralEntrar = False
    Me.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboNacionalidad.FormattingEnabled = True
    Me.cboNacionalidad.Location = New System.Drawing.Point(408, 284)
    Me.cboNacionalidad.MostrarRutaCompleta = False
    Me.cboNacionalidad.Name = "cboNacionalidad"
    Me.cboNacionalidad.OperadorDatos = Nothing
    Me.cboNacionalidad.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.SectorDomicilio
    Me.cboNacionalidad.ParametroDet = Nothing
    Me.cboNacionalidad.PuedeActualizar = True
    Me.cboNacionalidad.PuedeEliminar = True
    Me.cboNacionalidad.PuedeModificar = True
    Me.cboNacionalidad.PuedeNuevo = True
    Me.cboNacionalidad.Size = New System.Drawing.Size(129, 21)
    Me.cboNacionalidad.TabIndex = 24
    '
    'cboSectorDomicilio
    '
    Me.cboSectorDomicilio.AbriralEntrar = False
    Me.cboSectorDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboSectorDomicilio.FormattingEnabled = True
    Me.cboSectorDomicilio.Location = New System.Drawing.Point(408, 257)
    Me.cboSectorDomicilio.MostrarRutaCompleta = False
    Me.cboSectorDomicilio.Name = "cboSectorDomicilio"
    Me.cboSectorDomicilio.OperadorDatos = Nothing
    Me.cboSectorDomicilio.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.SectorDomicilio
    Me.cboSectorDomicilio.ParametroDet = Nothing
    Me.cboSectorDomicilio.PuedeActualizar = True
    Me.cboSectorDomicilio.PuedeEliminar = True
    Me.cboSectorDomicilio.PuedeModificar = True
    Me.cboSectorDomicilio.PuedeNuevo = True
    Me.cboSectorDomicilio.Size = New System.Drawing.Size(129, 21)
    Me.cboSectorDomicilio.TabIndex = 22
    '
    'CtlUbicacion1
    '
    Me.CtlUbicacion1.HideSelection = False
    Me.CtlUbicacion1.Location = New System.Drawing.Point(88, 113)
    Me.CtlUbicacion1.Name = "CtlUbicacion1"
    Me.CtlUbicacion1.OperadorDatos = Nothing
    Me.CtlUbicacion1.Parroquia = Nothing
    Me.CtlUbicacion1.Size = New System.Drawing.Size(176, 204)
    Me.CtlUbicacion1.TabIndex = 3
    '
    'ComboBoxTipoEmpleado
    '
    Me.ComboBoxTipoEmpleado.AbriralEntrar = False
    Me.ComboBoxTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoEmpleado.FormattingEnabled = True
    Me.ComboBoxTipoEmpleado.Location = New System.Drawing.Point(408, 113)
    Me.ComboBoxTipoEmpleado.MostrarRutaCompleta = False
    Me.ComboBoxTipoEmpleado.Name = "ComboBoxTipoEmpleado"
    Me.ComboBoxTipoEmpleado.OperadorDatos = Nothing
    Me.ComboBoxTipoEmpleado.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoEmpleado.ParametroDet = Nothing
    Me.ComboBoxTipoEmpleado.PuedeActualizar = True
    Me.ComboBoxTipoEmpleado.PuedeEliminar = True
    Me.ComboBoxTipoEmpleado.PuedeModificar = True
    Me.ComboBoxTipoEmpleado.PuedeNuevo = True
    Me.ComboBoxTipoEmpleado.Size = New System.Drawing.Size(129, 21)
    Me.ComboBoxTipoEmpleado.TabIndex = 13
    '
    'ComboBoxTipoCtaBancaria
    '
    Me.ComboBoxTipoCtaBancaria.AbriralEntrar = False
    Me.ComboBoxTipoCtaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoCtaBancaria.FormattingEnabled = True
    Me.ComboBoxTipoCtaBancaria.Location = New System.Drawing.Point(408, 60)
    Me.ComboBoxTipoCtaBancaria.MostrarRutaCompleta = False
    Me.ComboBoxTipoCtaBancaria.Name = "ComboBoxTipoCtaBancaria"
    Me.ComboBoxTipoCtaBancaria.OperadorDatos = Nothing
    Me.ComboBoxTipoCtaBancaria.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoCtaBancaria.ParametroDet = Nothing
    Me.ComboBoxTipoCtaBancaria.PuedeActualizar = True
    Me.ComboBoxTipoCtaBancaria.PuedeEliminar = True
    Me.ComboBoxTipoCtaBancaria.PuedeModificar = True
    Me.ComboBoxTipoCtaBancaria.PuedeNuevo = True
    Me.ComboBoxTipoCtaBancaria.Size = New System.Drawing.Size(129, 21)
    Me.ComboBoxTipoCtaBancaria.TabIndex = 9
    '
    'ComboBoxBanco
    '
    Me.ComboBoxBanco.AbriralEntrar = False
    Me.ComboBoxBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxBanco.FormattingEnabled = True
    Me.ComboBoxBanco.Location = New System.Drawing.Point(408, 33)
    Me.ComboBoxBanco.MostrarRutaCompleta = False
    Me.ComboBoxBanco.Name = "ComboBoxBanco"
    Me.ComboBoxBanco.OperadorDatos = Nothing
    Me.ComboBoxBanco.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxBanco.ParametroDet = Nothing
    Me.ComboBoxBanco.PuedeActualizar = True
    Me.ComboBoxBanco.PuedeEliminar = True
    Me.ComboBoxBanco.PuedeModificar = True
    Me.ComboBoxBanco.PuedeNuevo = True
    Me.ComboBoxBanco.Size = New System.Drawing.Size(129, 21)
    Me.ComboBoxBanco.TabIndex = 7
    '
    'ComboBoxFormaPagoRol
    '
    Me.ComboBoxFormaPagoRol.AbriralEntrar = False
    Me.ComboBoxFormaPagoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxFormaPagoRol.FormattingEnabled = True
    Me.ComboBoxFormaPagoRol.Location = New System.Drawing.Point(408, 6)
    Me.ComboBoxFormaPagoRol.MostrarRutaCompleta = False
    Me.ComboBoxFormaPagoRol.Name = "ComboBoxFormaPagoRol"
    Me.ComboBoxFormaPagoRol.OperadorDatos = Nothing
    Me.ComboBoxFormaPagoRol.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxFormaPagoRol.ParametroDet = Nothing
    Me.ComboBoxFormaPagoRol.PuedeActualizar = True
    Me.ComboBoxFormaPagoRol.PuedeEliminar = True
    Me.ComboBoxFormaPagoRol.PuedeModificar = True
    Me.ComboBoxFormaPagoRol.PuedeNuevo = True
    Me.ComboBoxFormaPagoRol.Size = New System.Drawing.Size(129, 21)
    Me.ComboBoxFormaPagoRol.TabIndex = 5
    '
    'TabPage3
    '
    Me.TabPage3.Controls.Add(Me.chkdiscapsicologica)
    Me.TabPage3.Controls.Add(Me.chkdiscaintelectual)
    Me.TabPage3.Controls.Add(Me.chkdiscavisual)
    Me.TabPage3.Controls.Add(Me.chkdiscalinguistica)
    Me.TabPage3.Controls.Add(Me.chkdiscaauditiva)
    Me.TabPage3.Controls.Add(Me.chkdiscafisica)
    Me.TabPage3.Controls.Add(Me.txtenfermedad)
    Me.TabPage3.Controls.Add(Me.Label12)
    Me.TabPage3.Controls.Add(Me.Label10)
    Me.TabPage3.Controls.Add(Me.Label6)
    Me.TabPage3.Controls.Add(Me.Label17)
    Me.TabPage3.Controls.Add(Me.txtavisoemer)
    Me.TabPage3.Controls.Add(Me.Label15)
    Me.TabPage3.Controls.Add(Me.ComboBoxSeguroCorporativo)
    Me.TabPage3.Controls.Add(Me.ComboBoxDiscapacidad)
    Me.TabPage3.Controls.Add(Me.ComboBoxTipoSangre)
    Me.TabPage3.Location = New System.Drawing.Point(4, 22)
    Me.TabPage3.Name = "TabPage3"
    Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage3.Size = New System.Drawing.Size(785, 355)
    Me.TabPage3.TabIndex = 4
    Me.TabPage3.Text = "Otros"
    Me.TabPage3.UseVisualStyleBackColor = True
    '
    'chkdiscapsicologica
    '
    Me.chkdiscapsicologica.AutoSize = True
    Me.chkdiscapsicologica.Location = New System.Drawing.Point(293, 112)
    Me.chkdiscapsicologica.Name = "chkdiscapsicologica"
    Me.chkdiscapsicologica.Size = New System.Drawing.Size(147, 17)
    Me.chkdiscapsicologica.TabIndex = 9
    Me.chkdiscapsicologica.Text = "Discapacidad psicológica"
    '
    'chkdiscaintelectual
    '
    Me.chkdiscaintelectual.AutoSize = True
    Me.chkdiscaintelectual.Location = New System.Drawing.Point(293, 89)
    Me.chkdiscaintelectual.Name = "chkdiscaintelectual"
    Me.chkdiscaintelectual.Size = New System.Drawing.Size(142, 17)
    Me.chkdiscaintelectual.TabIndex = 8
    Me.chkdiscaintelectual.Text = "Discapacidad intelectual"
    '
    'chkdiscavisual
    '
    Me.chkdiscavisual.AutoSize = True
    Me.chkdiscavisual.Location = New System.Drawing.Point(293, 66)
    Me.chkdiscavisual.Name = "chkdiscavisual"
    Me.chkdiscavisual.Size = New System.Drawing.Size(121, 17)
    Me.chkdiscavisual.TabIndex = 7
    Me.chkdiscavisual.Text = "Discapacidad visual"
    '
    'chkdiscalinguistica
    '
    Me.chkdiscalinguistica.AutoSize = True
    Me.chkdiscalinguistica.Location = New System.Drawing.Point(139, 112)
    Me.chkdiscalinguistica.Name = "chkdiscalinguistica"
    Me.chkdiscalinguistica.Size = New System.Drawing.Size(142, 17)
    Me.chkdiscalinguistica.TabIndex = 6
    Me.chkdiscalinguistica.Text = "Discapacidad lingüística"
    '
    'chkdiscaauditiva
    '
    Me.chkdiscaauditiva.AutoSize = True
    Me.chkdiscaauditiva.Location = New System.Drawing.Point(139, 89)
    Me.chkdiscaauditiva.Name = "chkdiscaauditiva"
    Me.chkdiscaauditiva.Size = New System.Drawing.Size(131, 17)
    Me.chkdiscaauditiva.TabIndex = 5
    Me.chkdiscaauditiva.Text = "Discapacidad auditiva"
    '
    'chkdiscafisica
    '
    Me.chkdiscafisica.AutoSize = True
    Me.chkdiscafisica.Location = New System.Drawing.Point(139, 66)
    Me.chkdiscafisica.Name = "chkdiscafisica"
    Me.chkdiscafisica.Size = New System.Drawing.Size(120, 17)
    Me.chkdiscafisica.TabIndex = 4
    Me.chkdiscafisica.Text = "Discapacidad física"
    '
    'txtenfermedad
    '
    Me.txtenfermedad.Location = New System.Drawing.Point(139, 162)
    Me.txtenfermedad.Multiline = True
    Me.txtenfermedad.Name = "txtenfermedad"
    Me.txtenfermedad.Size = New System.Drawing.Size(400, 32)
    Me.txtenfermedad.TabIndex = 13
    '
    'Label12
    '
    Me.Label12.AutoSize = True
    Me.Label12.Location = New System.Drawing.Point(6, 165)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(67, 13)
    Me.Label12.TabIndex = 12
    Me.Label12.Text = "Enfermedad:"
    '
    'Label10
    '
    Me.Label10.AutoSize = True
    Me.Label10.Location = New System.Drawing.Point(6, 138)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(100, 13)
    Me.Label10.TabIndex = 10
    Me.Label10.Text = "Seguro corporativo:"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(6, 42)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(75, 13)
    Me.Label6.TabIndex = 2
    Me.Label6.Text = "Discapacidad:"
    '
    'Label17
    '
    Me.Label17.AutoSize = True
    Me.Label17.Location = New System.Drawing.Point(6, 15)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(81, 13)
    Me.Label17.TabIndex = 0
    Me.Label17.Text = "Tipo de sangre:"
    '
    'txtavisoemer
    '
    Me.txtavisoemer.Location = New System.Drawing.Point(139, 200)
    Me.txtavisoemer.Multiline = True
    Me.txtavisoemer.Name = "txtavisoemer"
    Me.txtavisoemer.Size = New System.Drawing.Size(400, 32)
    Me.txtavisoemer.TabIndex = 15
    '
    'Label15
    '
    Me.Label15.AutoSize = True
    Me.Label15.Location = New System.Drawing.Point(6, 203)
    Me.Label15.Name = "Label15"
    Me.Label15.Size = New System.Drawing.Size(122, 13)
    Me.Label15.TabIndex = 14
    Me.Label15.Text = "En caso de emergencia:"
    '
    'ComboBoxSeguroCorporativo
    '
    Me.ComboBoxSeguroCorporativo.AbriralEntrar = False
    Me.ComboBoxSeguroCorporativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxSeguroCorporativo.FormattingEnabled = True
    Me.ComboBoxSeguroCorporativo.Location = New System.Drawing.Point(139, 135)
    Me.ComboBoxSeguroCorporativo.MostrarRutaCompleta = False
    Me.ComboBoxSeguroCorporativo.Name = "ComboBoxSeguroCorporativo"
    Me.ComboBoxSeguroCorporativo.OperadorDatos = Nothing
    Me.ComboBoxSeguroCorporativo.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxSeguroCorporativo.ParametroDet = Nothing
    Me.ComboBoxSeguroCorporativo.PuedeActualizar = True
    Me.ComboBoxSeguroCorporativo.PuedeEliminar = True
    Me.ComboBoxSeguroCorporativo.PuedeModificar = True
    Me.ComboBoxSeguroCorporativo.PuedeNuevo = True
    Me.ComboBoxSeguroCorporativo.Size = New System.Drawing.Size(296, 21)
    Me.ComboBoxSeguroCorporativo.TabIndex = 11
    '
    'ComboBoxDiscapacidad
    '
    Me.ComboBoxDiscapacidad.AbriralEntrar = False
    Me.ComboBoxDiscapacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxDiscapacidad.FormattingEnabled = True
    Me.ComboBoxDiscapacidad.Location = New System.Drawing.Point(139, 39)
    Me.ComboBoxDiscapacidad.MostrarRutaCompleta = False
    Me.ComboBoxDiscapacidad.Name = "ComboBoxDiscapacidad"
    Me.ComboBoxDiscapacidad.OperadorDatos = Nothing
    Me.ComboBoxDiscapacidad.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxDiscapacidad.ParametroDet = Nothing
    Me.ComboBoxDiscapacidad.PuedeActualizar = True
    Me.ComboBoxDiscapacidad.PuedeEliminar = True
    Me.ComboBoxDiscapacidad.PuedeModificar = True
    Me.ComboBoxDiscapacidad.PuedeNuevo = True
    Me.ComboBoxDiscapacidad.Size = New System.Drawing.Size(147, 21)
    Me.ComboBoxDiscapacidad.TabIndex = 3
    '
    'ComboBoxTipoSangre
    '
    Me.ComboBoxTipoSangre.AbriralEntrar = False
    Me.ComboBoxTipoSangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.ComboBoxTipoSangre.FormattingEnabled = True
    Me.ComboBoxTipoSangre.Location = New System.Drawing.Point(139, 12)
    Me.ComboBoxTipoSangre.MostrarRutaCompleta = False
    Me.ComboBoxTipoSangre.Name = "ComboBoxTipoSangre"
    Me.ComboBoxTipoSangre.OperadorDatos = Nothing
    Me.ComboBoxTipoSangre.Parametro = ActivosFijos.Reglas.Enumerados.EnumParametros.TipoEntidad
    Me.ComboBoxTipoSangre.ParametroDet = Nothing
    Me.ComboBoxTipoSangre.PuedeActualizar = True
    Me.ComboBoxTipoSangre.PuedeEliminar = True
    Me.ComboBoxTipoSangre.PuedeModificar = True
    Me.ComboBoxTipoSangre.PuedeNuevo = True
    Me.ComboBoxTipoSangre.Size = New System.Drawing.Size(147, 21)
    Me.ComboBoxTipoSangre.TabIndex = 1
    '
    'TabPage4
    '
    Me.TabPage4.Controls.Add(Me.chckTitulo)
    Me.TabPage4.Controls.Add(Me.txtEspecializacion)
    Me.TabPage4.Controls.Add(Me.Label19)
    Me.TabPage4.Controls.Add(Me.chckBachiller)
    Me.TabPage4.Controls.Add(Me.txtprimaria)
    Me.TabPage4.Controls.Add(Me.Label5)
    Me.TabPage4.Controls.Add(Me.txtsecundaria)
    Me.TabPage4.Controls.Add(Me.Label7)
    Me.TabPage4.Controls.Add(Me.Label8)
    Me.TabPage4.Controls.Add(Me.txtcursos)
    Me.TabPage4.Controls.Add(Me.txtsuperior)
    Me.TabPage4.Controls.Add(Me.txtrefper)
    Me.TabPage4.Controls.Add(Me.Label9)
    Me.TabPage4.Controls.Add(Me.Label22)
    Me.TabPage4.Controls.Add(Me.txtreflab)
    Me.TabPage4.Controls.Add(Me.txtsecanio)
    Me.TabPage4.Controls.Add(Me.Label23)
    Me.TabPage4.Controls.Add(Me.txtprianio)
    Me.TabPage4.Controls.Add(Me.txtsupanio)
    Me.TabPage4.Controls.Add(Me.Label25)
    Me.TabPage4.Controls.Add(Me.Label27)
    Me.TabPage4.Controls.Add(Me.Label26)
    Me.TabPage4.Controls.Add(Me.txtbachiller)
    Me.TabPage4.Controls.Add(Me.Label28)
    Me.TabPage4.Controls.Add(Me.txttitulo)
    Me.TabPage4.Controls.Add(Me.Label29)
    Me.TabPage4.Location = New System.Drawing.Point(4, 22)
    Me.TabPage4.Name = "TabPage4"
    Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
    Me.TabPage4.Size = New System.Drawing.Size(785, 355)
    Me.TabPage4.TabIndex = 1
    Me.TabPage4.Text = "Currículum"
    Me.TabPage4.UseVisualStyleBackColor = True
    '
    'chckTitulo
    '
    Me.chckTitulo.AutoSize = True
    Me.chckTitulo.Location = New System.Drawing.Point(148, 110)
    Me.chckTitulo.Name = "chckTitulo"
    Me.chckTitulo.Size = New System.Drawing.Size(29, 17)
    Me.chckTitulo.TabIndex = 27
    Me.chckTitulo.Text = " "
    Me.chckTitulo.UseVisualStyleBackColor = True
    '
    'txtEspecializacion
    '
    Me.txtEspecializacion.Enabled = False
    Me.txtEspecializacion.Location = New System.Drawing.Point(148, 136)
    Me.txtEspecializacion.Name = "txtEspecializacion"
    Me.txtEspecializacion.Size = New System.Drawing.Size(292, 20)
    Me.txtEspecializacion.TabIndex = 26
    '
    'Label19
    '
    Me.Label19.AutoSize = True
    Me.Label19.Location = New System.Drawing.Point(8, 136)
    Me.Label19.Name = "Label19"
    Me.Label19.Size = New System.Drawing.Size(83, 13)
    Me.Label19.TabIndex = 25
    Me.Label19.Text = "Especialización:"
    '
    'chckBachiller
    '
    Me.chckBachiller.AutoSize = True
    Me.chckBachiller.Location = New System.Drawing.Point(148, 58)
    Me.chckBachiller.Name = "chckBachiller"
    Me.chckBachiller.Size = New System.Drawing.Size(29, 17)
    Me.chckBachiller.TabIndex = 24
    Me.chckBachiller.Text = " "
    Me.chckBachiller.UseVisualStyleBackColor = True
    '
    'txtprimaria
    '
    Me.txtprimaria.Location = New System.Drawing.Point(148, 6)
    Me.txtprimaria.Name = "txtprimaria"
    Me.txtprimaria.Size = New System.Drawing.Size(292, 20)
    Me.txtprimaria.TabIndex = 1
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(8, 6)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(47, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "Primaria:"
    '
    'txtsecundaria
    '
    Me.txtsecundaria.Location = New System.Drawing.Point(148, 32)
    Me.txtsecundaria.Name = "txtsecundaria"
    Me.txtsecundaria.Size = New System.Drawing.Size(292, 20)
    Me.txtsecundaria.TabIndex = 5
    '
    'Label7
    '
    Me.Label7.AutoSize = True
    Me.Label7.Location = New System.Drawing.Point(8, 32)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(64, 13)
    Me.Label7.TabIndex = 4
    Me.Label7.Text = "Secundaria:"
    '
    'Label8
    '
    Me.Label8.AutoSize = True
    Me.Label8.Location = New System.Drawing.Point(8, 84)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(49, 13)
    Me.Label8.TabIndex = 10
    Me.Label8.Text = "Superior:"
    '
    'txtcursos
    '
    Me.txtcursos.Location = New System.Drawing.Point(148, 162)
    Me.txtcursos.Multiline = True
    Me.txtcursos.Name = "txtcursos"
    Me.txtcursos.Size = New System.Drawing.Size(292, 48)
    Me.txtcursos.TabIndex = 17
    '
    'txtsuperior
    '
    Me.txtsuperior.Location = New System.Drawing.Point(148, 84)
    Me.txtsuperior.Name = "txtsuperior"
    Me.txtsuperior.Size = New System.Drawing.Size(292, 20)
    Me.txtsuperior.TabIndex = 11
    '
    'txtrefper
    '
    Me.txtrefper.Location = New System.Drawing.Point(148, 216)
    Me.txtrefper.Multiline = True
    Me.txtrefper.Name = "txtrefper"
    Me.txtrefper.Size = New System.Drawing.Size(292, 48)
    Me.txtrefper.TabIndex = 19
    '
    'Label9
    '
    Me.Label9.AutoSize = True
    Me.Label9.Location = New System.Drawing.Point(8, 165)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(102, 13)
    Me.Label9.TabIndex = 16
    Me.Label9.Text = "Cursos y seminarios:"
    '
    'Label22
    '
    Me.Label22.AutoSize = True
    Me.Label22.Location = New System.Drawing.Point(8, 219)
    Me.Label22.Name = "Label22"
    Me.Label22.Size = New System.Drawing.Size(121, 13)
    Me.Label22.TabIndex = 18
    Me.Label22.Text = "Referencias personales:"
    '
    'txtreflab
    '
    Me.txtreflab.Location = New System.Drawing.Point(148, 270)
    Me.txtreflab.Multiline = True
    Me.txtreflab.Name = "txtreflab"
    Me.txtreflab.Size = New System.Drawing.Size(292, 48)
    Me.txtreflab.TabIndex = 21
    '
    'txtsecanio
    '
    Me.txtsecanio.Location = New System.Drawing.Point(491, 32)
    Me.txtsecanio.Name = "txtsecanio"
    Me.txtsecanio.Size = New System.Drawing.Size(36, 20)
    Me.txtsecanio.TabIndex = 7
    '
    'Label23
    '
    Me.Label23.AutoSize = True
    Me.Label23.Location = New System.Drawing.Point(8, 273)
    Me.Label23.Name = "Label23"
    Me.Label23.Size = New System.Drawing.Size(112, 13)
    Me.Label23.TabIndex = 20
    Me.Label23.Text = "Referencias laborales:"
    '
    'txtprianio
    '
    Me.txtprianio.Location = New System.Drawing.Point(491, 6)
    Me.txtprianio.Name = "txtprianio"
    Me.txtprianio.Size = New System.Drawing.Size(36, 20)
    Me.txtprianio.TabIndex = 3
    '
    'txtsupanio
    '
    Me.txtsupanio.Location = New System.Drawing.Point(491, 84)
    Me.txtsupanio.Name = "txtsupanio"
    Me.txtsupanio.Size = New System.Drawing.Size(36, 20)
    Me.txtsupanio.TabIndex = 13
    '
    'Label25
    '
    Me.Label25.AutoSize = True
    Me.Label25.Location = New System.Drawing.Point(446, 30)
    Me.Label25.Name = "Label25"
    Me.Label25.Size = New System.Drawing.Size(37, 13)
    Me.Label25.TabIndex = 6
    Me.Label25.Text = "Curso:"
    '
    'Label27
    '
    Me.Label27.AutoSize = True
    Me.Label27.Location = New System.Drawing.Point(446, 6)
    Me.Label27.Name = "Label27"
    Me.Label27.Size = New System.Drawing.Size(39, 13)
    Me.Label27.TabIndex = 2
    Me.Label27.Text = "Grado:"
    '
    'Label26
    '
    Me.Label26.AutoSize = True
    Me.Label26.Location = New System.Drawing.Point(446, 87)
    Me.Label26.Name = "Label26"
    Me.Label26.Size = New System.Drawing.Size(34, 13)
    Me.Label26.TabIndex = 12
    Me.Label26.Text = "Nivel:"
    '
    'txtbachiller
    '
    Me.txtbachiller.Enabled = False
    Me.txtbachiller.Location = New System.Drawing.Point(178, 58)
    Me.txtbachiller.Name = "txtbachiller"
    Me.txtbachiller.Size = New System.Drawing.Size(262, 20)
    Me.txtbachiller.TabIndex = 9
    '
    'Label28
    '
    Me.Label28.AutoSize = True
    Me.Label28.Location = New System.Drawing.Point(8, 58)
    Me.Label28.Name = "Label28"
    Me.Label28.Size = New System.Drawing.Size(50, 13)
    Me.Label28.TabIndex = 8
    Me.Label28.Text = "Bachiller:"
    '
    'txttitulo
    '
    Me.txttitulo.Enabled = False
    Me.txttitulo.Location = New System.Drawing.Point(178, 110)
    Me.txttitulo.Name = "txttitulo"
    Me.txttitulo.Size = New System.Drawing.Size(262, 20)
    Me.txttitulo.TabIndex = 15
    '
    'Label29
    '
    Me.Label29.AutoSize = True
    Me.Label29.Location = New System.Drawing.Point(8, 110)
    Me.Label29.Name = "Label29"
    Me.Label29.Size = New System.Drawing.Size(38, 13)
    Me.Label29.TabIndex = 14
    Me.Label29.Text = "Título:"
    '
    'DataGridViewTextBoxColumn212
    '
    Me.DataGridViewTextBoxColumn212.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn212.Name = "DataGridViewTextBoxColumn212"
    '
    'DataGridViewTextBoxColumn213
    '
    Me.DataGridViewTextBoxColumn213.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn213.Name = "DataGridViewTextBoxColumn213"
    '
    'DataGridViewTextBoxColumn214
    '
    Me.DataGridViewTextBoxColumn214.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn214.Name = "DataGridViewTextBoxColumn214"
    '
    'DataGridViewTextBoxColumn209
    '
    Me.DataGridViewTextBoxColumn209.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn209.Name = "DataGridViewTextBoxColumn209"
    '
    'DataGridViewTextBoxColumn210
    '
    Me.DataGridViewTextBoxColumn210.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn210.Name = "DataGridViewTextBoxColumn210"
    '
    'DataGridViewTextBoxColumn211
    '
    Me.DataGridViewTextBoxColumn211.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn211.Name = "DataGridViewTextBoxColumn211"
    '
    'DataGridViewTextBoxColumn206
    '
    Me.DataGridViewTextBoxColumn206.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn206.Name = "DataGridViewTextBoxColumn206"
    '
    'DataGridViewTextBoxColumn207
    '
    Me.DataGridViewTextBoxColumn207.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn207.Name = "DataGridViewTextBoxColumn207"
    '
    'DataGridViewTextBoxColumn208
    '
    Me.DataGridViewTextBoxColumn208.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn208.Name = "DataGridViewTextBoxColumn208"
    '
    'DataGridViewTextBoxColumn203
    '
    Me.DataGridViewTextBoxColumn203.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn203.Name = "DataGridViewTextBoxColumn203"
    '
    'DataGridViewTextBoxColumn204
    '
    Me.DataGridViewTextBoxColumn204.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn204.Name = "DataGridViewTextBoxColumn204"
    '
    'DataGridViewTextBoxColumn205
    '
    Me.DataGridViewTextBoxColumn205.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn205.Name = "DataGridViewTextBoxColumn205"
    '
    'DataGridViewTextBoxColumn200
    '
    Me.DataGridViewTextBoxColumn200.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn200.Name = "DataGridViewTextBoxColumn200"
    '
    'DataGridViewTextBoxColumn201
    '
    Me.DataGridViewTextBoxColumn201.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn201.Name = "DataGridViewTextBoxColumn201"
    '
    'DataGridViewTextBoxColumn202
    '
    Me.DataGridViewTextBoxColumn202.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn202.Name = "DataGridViewTextBoxColumn202"
    '
    'DataGridViewTextBoxColumn197
    '
    Me.DataGridViewTextBoxColumn197.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn197.Name = "DataGridViewTextBoxColumn197"
    '
    'DataGridViewTextBoxColumn198
    '
    Me.DataGridViewTextBoxColumn198.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn198.Name = "DataGridViewTextBoxColumn198"
    '
    'DataGridViewTextBoxColumn199
    '
    Me.DataGridViewTextBoxColumn199.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn199.Name = "DataGridViewTextBoxColumn199"
    '
    'DataGridViewTextBoxColumn194
    '
    Me.DataGridViewTextBoxColumn194.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn194.Name = "DataGridViewTextBoxColumn194"
    '
    'DataGridViewTextBoxColumn195
    '
    Me.DataGridViewTextBoxColumn195.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn195.Name = "DataGridViewTextBoxColumn195"
    '
    'DataGridViewTextBoxColumn196
    '
    Me.DataGridViewTextBoxColumn196.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn196.Name = "DataGridViewTextBoxColumn196"
    '
    'DataGridViewTextBoxColumn191
    '
    Me.DataGridViewTextBoxColumn191.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn191.Name = "DataGridViewTextBoxColumn191"
    '
    'DataGridViewTextBoxColumn192
    '
    Me.DataGridViewTextBoxColumn192.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn192.Name = "DataGridViewTextBoxColumn192"
    '
    'DataGridViewTextBoxColumn193
    '
    Me.DataGridViewTextBoxColumn193.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn193.Name = "DataGridViewTextBoxColumn193"
    '
    'DataGridViewTextBoxColumn188
    '
    Me.DataGridViewTextBoxColumn188.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn188.Name = "DataGridViewTextBoxColumn188"
    '
    'DataGridViewTextBoxColumn189
    '
    Me.DataGridViewTextBoxColumn189.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn189.Name = "DataGridViewTextBoxColumn189"
    '
    'DataGridViewTextBoxColumn190
    '
    Me.DataGridViewTextBoxColumn190.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn190.Name = "DataGridViewTextBoxColumn190"
    '
    'DataGridViewTextBoxColumn185
    '
    Me.DataGridViewTextBoxColumn185.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn185.Name = "DataGridViewTextBoxColumn185"
    '
    'DataGridViewTextBoxColumn186
    '
    Me.DataGridViewTextBoxColumn186.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn186.Name = "DataGridViewTextBoxColumn186"
    '
    'DataGridViewTextBoxColumn187
    '
    Me.DataGridViewTextBoxColumn187.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn187.Name = "DataGridViewTextBoxColumn187"
    '
    'DataGridViewTextBoxColumn182
    '
    Me.DataGridViewTextBoxColumn182.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn182.Name = "DataGridViewTextBoxColumn182"
    '
    'DataGridViewTextBoxColumn183
    '
    Me.DataGridViewTextBoxColumn183.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn183.Name = "DataGridViewTextBoxColumn183"
    '
    'DataGridViewTextBoxColumn184
    '
    Me.DataGridViewTextBoxColumn184.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn184.Name = "DataGridViewTextBoxColumn184"
    '
    'DataGridViewTextBoxColumn179
    '
    Me.DataGridViewTextBoxColumn179.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn179.Name = "DataGridViewTextBoxColumn179"
    '
    'DataGridViewTextBoxColumn180
    '
    Me.DataGridViewTextBoxColumn180.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn180.Name = "DataGridViewTextBoxColumn180"
    '
    'DataGridViewTextBoxColumn181
    '
    Me.DataGridViewTextBoxColumn181.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn181.Name = "DataGridViewTextBoxColumn181"
    '
    'DataGridViewTextBoxColumn176
    '
    Me.DataGridViewTextBoxColumn176.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn176.Name = "DataGridViewTextBoxColumn176"
    '
    'DataGridViewTextBoxColumn177
    '
    Me.DataGridViewTextBoxColumn177.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn177.Name = "DataGridViewTextBoxColumn177"
    '
    'DataGridViewTextBoxColumn178
    '
    Me.DataGridViewTextBoxColumn178.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn178.Name = "DataGridViewTextBoxColumn178"
    '
    'DataGridViewTextBoxColumn173
    '
    Me.DataGridViewTextBoxColumn173.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn173.Name = "DataGridViewTextBoxColumn173"
    '
    'DataGridViewTextBoxColumn174
    '
    Me.DataGridViewTextBoxColumn174.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn174.Name = "DataGridViewTextBoxColumn174"
    '
    'DataGridViewTextBoxColumn175
    '
    Me.DataGridViewTextBoxColumn175.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn175.Name = "DataGridViewTextBoxColumn175"
    '
    'DataGridViewTextBoxColumn170
    '
    Me.DataGridViewTextBoxColumn170.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn170.Name = "DataGridViewTextBoxColumn170"
    '
    'DataGridViewTextBoxColumn171
    '
    Me.DataGridViewTextBoxColumn171.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn171.Name = "DataGridViewTextBoxColumn171"
    '
    'DataGridViewTextBoxColumn172
    '
    Me.DataGridViewTextBoxColumn172.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn172.Name = "DataGridViewTextBoxColumn172"
    '
    'DataGridViewTextBoxColumn167
    '
    Me.DataGridViewTextBoxColumn167.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn167.Name = "DataGridViewTextBoxColumn167"
    '
    'DataGridViewTextBoxColumn168
    '
    Me.DataGridViewTextBoxColumn168.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn168.Name = "DataGridViewTextBoxColumn168"
    '
    'DataGridViewTextBoxColumn169
    '
    Me.DataGridViewTextBoxColumn169.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn169.Name = "DataGridViewTextBoxColumn169"
    '
    'DataGridViewTextBoxColumn164
    '
    Me.DataGridViewTextBoxColumn164.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn164.Name = "DataGridViewTextBoxColumn164"
    '
    'DataGridViewTextBoxColumn165
    '
    Me.DataGridViewTextBoxColumn165.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn165.Name = "DataGridViewTextBoxColumn165"
    '
    'DataGridViewTextBoxColumn166
    '
    Me.DataGridViewTextBoxColumn166.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn166.Name = "DataGridViewTextBoxColumn166"
    '
    'DataGridViewTextBoxColumn161
    '
    Me.DataGridViewTextBoxColumn161.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn161.Name = "DataGridViewTextBoxColumn161"
    '
    'DataGridViewTextBoxColumn162
    '
    Me.DataGridViewTextBoxColumn162.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn162.Name = "DataGridViewTextBoxColumn162"
    '
    'DataGridViewTextBoxColumn163
    '
    Me.DataGridViewTextBoxColumn163.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn163.Name = "DataGridViewTextBoxColumn163"
    '
    'DataGridViewTextBoxColumn158
    '
    Me.DataGridViewTextBoxColumn158.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn158.Name = "DataGridViewTextBoxColumn158"
    '
    'DataGridViewTextBoxColumn159
    '
    Me.DataGridViewTextBoxColumn159.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn159.Name = "DataGridViewTextBoxColumn159"
    '
    'DataGridViewTextBoxColumn160
    '
    Me.DataGridViewTextBoxColumn160.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn160.Name = "DataGridViewTextBoxColumn160"
    '
    'DataGridViewTextBoxColumn155
    '
    Me.DataGridViewTextBoxColumn155.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn155.Name = "DataGridViewTextBoxColumn155"
    '
    'DataGridViewTextBoxColumn156
    '
    Me.DataGridViewTextBoxColumn156.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn156.Name = "DataGridViewTextBoxColumn156"
    '
    'DataGridViewTextBoxColumn157
    '
    Me.DataGridViewTextBoxColumn157.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn157.Name = "DataGridViewTextBoxColumn157"
    '
    'DataGridViewTextBoxColumn152
    '
    Me.DataGridViewTextBoxColumn152.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn152.Name = "DataGridViewTextBoxColumn152"
    '
    'DataGridViewTextBoxColumn153
    '
    Me.DataGridViewTextBoxColumn153.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn153.Name = "DataGridViewTextBoxColumn153"
    '
    'DataGridViewTextBoxColumn154
    '
    Me.DataGridViewTextBoxColumn154.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn154.Name = "DataGridViewTextBoxColumn154"
    '
    'DataGridViewTextBoxColumn149
    '
    Me.DataGridViewTextBoxColumn149.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn149.Name = "DataGridViewTextBoxColumn149"
    '
    'DataGridViewTextBoxColumn150
    '
    Me.DataGridViewTextBoxColumn150.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn150.Name = "DataGridViewTextBoxColumn150"
    '
    'DataGridViewTextBoxColumn151
    '
    Me.DataGridViewTextBoxColumn151.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn151.Name = "DataGridViewTextBoxColumn151"
    '
    'DataGridViewTextBoxColumn146
    '
    Me.DataGridViewTextBoxColumn146.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn146.Name = "DataGridViewTextBoxColumn146"
    '
    'DataGridViewTextBoxColumn147
    '
    Me.DataGridViewTextBoxColumn147.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn147.Name = "DataGridViewTextBoxColumn147"
    '
    'DataGridViewTextBoxColumn148
    '
    Me.DataGridViewTextBoxColumn148.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn148.Name = "DataGridViewTextBoxColumn148"
    '
    'DataGridViewTextBoxColumn143
    '
    Me.DataGridViewTextBoxColumn143.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn143.Name = "DataGridViewTextBoxColumn143"
    '
    'DataGridViewTextBoxColumn144
    '
    Me.DataGridViewTextBoxColumn144.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn144.Name = "DataGridViewTextBoxColumn144"
    '
    'DataGridViewTextBoxColumn145
    '
    Me.DataGridViewTextBoxColumn145.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn145.Name = "DataGridViewTextBoxColumn145"
    '
    'DataGridViewTextBoxColumn140
    '
    Me.DataGridViewTextBoxColumn140.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn140.Name = "DataGridViewTextBoxColumn140"
    '
    'DataGridViewTextBoxColumn141
    '
    Me.DataGridViewTextBoxColumn141.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn141.Name = "DataGridViewTextBoxColumn141"
    '
    'DataGridViewTextBoxColumn142
    '
    Me.DataGridViewTextBoxColumn142.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn142.Name = "DataGridViewTextBoxColumn142"
    '
    'DataGridViewTextBoxColumn137
    '
    Me.DataGridViewTextBoxColumn137.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn137.Name = "DataGridViewTextBoxColumn137"
    '
    'DataGridViewTextBoxColumn138
    '
    Me.DataGridViewTextBoxColumn138.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn138.Name = "DataGridViewTextBoxColumn138"
    '
    'DataGridViewTextBoxColumn139
    '
    Me.DataGridViewTextBoxColumn139.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn139.Name = "DataGridViewTextBoxColumn139"
    '
    'DataGridViewTextBoxColumn134
    '
    Me.DataGridViewTextBoxColumn134.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn134.Name = "DataGridViewTextBoxColumn134"
    '
    'DataGridViewTextBoxColumn135
    '
    Me.DataGridViewTextBoxColumn135.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn135.Name = "DataGridViewTextBoxColumn135"
    '
    'DataGridViewTextBoxColumn136
    '
    Me.DataGridViewTextBoxColumn136.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn136.Name = "DataGridViewTextBoxColumn136"
    '
    'DataGridViewTextBoxColumn131
    '
    Me.DataGridViewTextBoxColumn131.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn131.Name = "DataGridViewTextBoxColumn131"
    '
    'DataGridViewTextBoxColumn132
    '
    Me.DataGridViewTextBoxColumn132.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn132.Name = "DataGridViewTextBoxColumn132"
    '
    'DataGridViewTextBoxColumn133
    '
    Me.DataGridViewTextBoxColumn133.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn133.Name = "DataGridViewTextBoxColumn133"
    '
    'DataGridViewTextBoxColumn128
    '
    Me.DataGridViewTextBoxColumn128.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn128.Name = "DataGridViewTextBoxColumn128"
    '
    'DataGridViewTextBoxColumn129
    '
    Me.DataGridViewTextBoxColumn129.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn129.Name = "DataGridViewTextBoxColumn129"
    '
    'DataGridViewTextBoxColumn130
    '
    Me.DataGridViewTextBoxColumn130.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn130.Name = "DataGridViewTextBoxColumn130"
    '
    'DataGridViewTextBoxColumn125
    '
    Me.DataGridViewTextBoxColumn125.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn125.Name = "DataGridViewTextBoxColumn125"
    '
    'DataGridViewTextBoxColumn126
    '
    Me.DataGridViewTextBoxColumn126.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn126.Name = "DataGridViewTextBoxColumn126"
    '
    'DataGridViewTextBoxColumn127
    '
    Me.DataGridViewTextBoxColumn127.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn127.Name = "DataGridViewTextBoxColumn127"
    '
    'DataGridViewTextBoxColumn122
    '
    Me.DataGridViewTextBoxColumn122.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn122.Name = "DataGridViewTextBoxColumn122"
    '
    'DataGridViewTextBoxColumn123
    '
    Me.DataGridViewTextBoxColumn123.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn123.Name = "DataGridViewTextBoxColumn123"
    '
    'DataGridViewTextBoxColumn124
    '
    Me.DataGridViewTextBoxColumn124.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn124.Name = "DataGridViewTextBoxColumn124"
    '
    'DataGridViewTextBoxColumn119
    '
    Me.DataGridViewTextBoxColumn119.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn119.Name = "DataGridViewTextBoxColumn119"
    '
    'DataGridViewTextBoxColumn120
    '
    Me.DataGridViewTextBoxColumn120.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn120.Name = "DataGridViewTextBoxColumn120"
    '
    'DataGridViewTextBoxColumn121
    '
    Me.DataGridViewTextBoxColumn121.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn121.Name = "DataGridViewTextBoxColumn121"
    '
    'DataGridViewTextBoxColumn116
    '
    Me.DataGridViewTextBoxColumn116.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn116.Name = "DataGridViewTextBoxColumn116"
    '
    'DataGridViewTextBoxColumn117
    '
    Me.DataGridViewTextBoxColumn117.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn117.Name = "DataGridViewTextBoxColumn117"
    '
    'DataGridViewTextBoxColumn118
    '
    Me.DataGridViewTextBoxColumn118.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn118.Name = "DataGridViewTextBoxColumn118"
    '
    'DataGridViewTextBoxColumn113
    '
    Me.DataGridViewTextBoxColumn113.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn113.Name = "DataGridViewTextBoxColumn113"
    '
    'DataGridViewTextBoxColumn114
    '
    Me.DataGridViewTextBoxColumn114.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn114.Name = "DataGridViewTextBoxColumn114"
    '
    'DataGridViewTextBoxColumn115
    '
    Me.DataGridViewTextBoxColumn115.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn115.Name = "DataGridViewTextBoxColumn115"
    '
    'DataGridViewTextBoxColumn110
    '
    Me.DataGridViewTextBoxColumn110.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn110.Name = "DataGridViewTextBoxColumn110"
    '
    'DataGridViewTextBoxColumn111
    '
    Me.DataGridViewTextBoxColumn111.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn111.Name = "DataGridViewTextBoxColumn111"
    '
    'DataGridViewTextBoxColumn112
    '
    Me.DataGridViewTextBoxColumn112.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn112.Name = "DataGridViewTextBoxColumn112"
    '
    'DataGridViewTextBoxColumn107
    '
    Me.DataGridViewTextBoxColumn107.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn107.Name = "DataGridViewTextBoxColumn107"
    '
    'DataGridViewTextBoxColumn108
    '
    Me.DataGridViewTextBoxColumn108.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn108.Name = "DataGridViewTextBoxColumn108"
    '
    'DataGridViewTextBoxColumn109
    '
    Me.DataGridViewTextBoxColumn109.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn109.Name = "DataGridViewTextBoxColumn109"
    '
    'DataGridViewTextBoxColumn104
    '
    Me.DataGridViewTextBoxColumn104.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn104.Name = "DataGridViewTextBoxColumn104"
    '
    'DataGridViewTextBoxColumn105
    '
    Me.DataGridViewTextBoxColumn105.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn105.Name = "DataGridViewTextBoxColumn105"
    '
    'DataGridViewTextBoxColumn106
    '
    Me.DataGridViewTextBoxColumn106.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn106.Name = "DataGridViewTextBoxColumn106"
    '
    'DataGridViewTextBoxColumn101
    '
    Me.DataGridViewTextBoxColumn101.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn101.Name = "DataGridViewTextBoxColumn101"
    '
    'DataGridViewTextBoxColumn102
    '
    Me.DataGridViewTextBoxColumn102.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn102.Name = "DataGridViewTextBoxColumn102"
    '
    'DataGridViewTextBoxColumn103
    '
    Me.DataGridViewTextBoxColumn103.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn103.Name = "DataGridViewTextBoxColumn103"
    '
    'DataGridViewTextBoxColumn98
    '
    Me.DataGridViewTextBoxColumn98.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn98.Name = "DataGridViewTextBoxColumn98"
    '
    'DataGridViewTextBoxColumn99
    '
    Me.DataGridViewTextBoxColumn99.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn99.Name = "DataGridViewTextBoxColumn99"
    '
    'DataGridViewTextBoxColumn100
    '
    Me.DataGridViewTextBoxColumn100.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn100.Name = "DataGridViewTextBoxColumn100"
    '
    'DataGridViewTextBoxColumn95
    '
    Me.DataGridViewTextBoxColumn95.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn95.Name = "DataGridViewTextBoxColumn95"
    '
    'DataGridViewTextBoxColumn96
    '
    Me.DataGridViewTextBoxColumn96.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn96.Name = "DataGridViewTextBoxColumn96"
    '
    'DataGridViewTextBoxColumn97
    '
    Me.DataGridViewTextBoxColumn97.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn97.Name = "DataGridViewTextBoxColumn97"
    '
    'DataGridViewTextBoxColumn92
    '
    Me.DataGridViewTextBoxColumn92.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn92.Name = "DataGridViewTextBoxColumn92"
    '
    'DataGridViewTextBoxColumn93
    '
    Me.DataGridViewTextBoxColumn93.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn93.Name = "DataGridViewTextBoxColumn93"
    '
    'DataGridViewTextBoxColumn94
    '
    Me.DataGridViewTextBoxColumn94.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn94.Name = "DataGridViewTextBoxColumn94"
    '
    'DataGridViewTextBoxColumn89
    '
    Me.DataGridViewTextBoxColumn89.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn89.Name = "DataGridViewTextBoxColumn89"
    '
    'DataGridViewTextBoxColumn90
    '
    Me.DataGridViewTextBoxColumn90.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn90.Name = "DataGridViewTextBoxColumn90"
    '
    'DataGridViewTextBoxColumn91
    '
    Me.DataGridViewTextBoxColumn91.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn91.Name = "DataGridViewTextBoxColumn91"
    '
    'DataGridViewTextBoxColumn86
    '
    Me.DataGridViewTextBoxColumn86.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn86.Name = "DataGridViewTextBoxColumn86"
    '
    'DataGridViewTextBoxColumn87
    '
    Me.DataGridViewTextBoxColumn87.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn87.Name = "DataGridViewTextBoxColumn87"
    '
    'DataGridViewTextBoxColumn88
    '
    Me.DataGridViewTextBoxColumn88.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn88.Name = "DataGridViewTextBoxColumn88"
    '
    'DataGridViewTextBoxColumn83
    '
    Me.DataGridViewTextBoxColumn83.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn83.Name = "DataGridViewTextBoxColumn83"
    '
    'DataGridViewTextBoxColumn84
    '
    Me.DataGridViewTextBoxColumn84.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn84.Name = "DataGridViewTextBoxColumn84"
    '
    'DataGridViewTextBoxColumn85
    '
    Me.DataGridViewTextBoxColumn85.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn85.Name = "DataGridViewTextBoxColumn85"
    '
    'DataGridViewTextBoxColumn80
    '
    Me.DataGridViewTextBoxColumn80.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn80.Name = "DataGridViewTextBoxColumn80"
    '
    'DataGridViewTextBoxColumn81
    '
    Me.DataGridViewTextBoxColumn81.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn81.Name = "DataGridViewTextBoxColumn81"
    '
    'DataGridViewTextBoxColumn82
    '
    Me.DataGridViewTextBoxColumn82.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn82.Name = "DataGridViewTextBoxColumn82"
    '
    'DataGridViewTextBoxColumn77
    '
    Me.DataGridViewTextBoxColumn77.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn77.Name = "DataGridViewTextBoxColumn77"
    '
    'DataGridViewTextBoxColumn78
    '
    Me.DataGridViewTextBoxColumn78.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn78.Name = "DataGridViewTextBoxColumn78"
    '
    'DataGridViewTextBoxColumn79
    '
    Me.DataGridViewTextBoxColumn79.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn79.Name = "DataGridViewTextBoxColumn79"
    '
    'DataGridViewTextBoxColumn74
    '
    Me.DataGridViewTextBoxColumn74.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn74.Name = "DataGridViewTextBoxColumn74"
    '
    'DataGridViewTextBoxColumn75
    '
    Me.DataGridViewTextBoxColumn75.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn75.Name = "DataGridViewTextBoxColumn75"
    '
    'DataGridViewTextBoxColumn76
    '
    Me.DataGridViewTextBoxColumn76.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn76.Name = "DataGridViewTextBoxColumn76"
    '
    'DataGridViewTextBoxColumn71
    '
    Me.DataGridViewTextBoxColumn71.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn71.Name = "DataGridViewTextBoxColumn71"
    '
    'DataGridViewTextBoxColumn72
    '
    Me.DataGridViewTextBoxColumn72.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn72.Name = "DataGridViewTextBoxColumn72"
    '
    'DataGridViewTextBoxColumn73
    '
    Me.DataGridViewTextBoxColumn73.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn73.Name = "DataGridViewTextBoxColumn73"
    '
    'DataGridViewTextBoxColumn68
    '
    Me.DataGridViewTextBoxColumn68.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn68.Name = "DataGridViewTextBoxColumn68"
    '
    'DataGridViewTextBoxColumn69
    '
    Me.DataGridViewTextBoxColumn69.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn69.Name = "DataGridViewTextBoxColumn69"
    '
    'DataGridViewTextBoxColumn70
    '
    Me.DataGridViewTextBoxColumn70.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn70.Name = "DataGridViewTextBoxColumn70"
    '
    'DataGridViewTextBoxColumn65
    '
    Me.DataGridViewTextBoxColumn65.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn65.Name = "DataGridViewTextBoxColumn65"
    '
    'DataGridViewTextBoxColumn66
    '
    Me.DataGridViewTextBoxColumn66.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn66.Name = "DataGridViewTextBoxColumn66"
    '
    'DataGridViewTextBoxColumn67
    '
    Me.DataGridViewTextBoxColumn67.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn67.Name = "DataGridViewTextBoxColumn67"
    '
    'DataGridViewTextBoxColumn62
    '
    Me.DataGridViewTextBoxColumn62.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn62.Name = "DataGridViewTextBoxColumn62"
    '
    'DataGridViewTextBoxColumn63
    '
    Me.DataGridViewTextBoxColumn63.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn63.Name = "DataGridViewTextBoxColumn63"
    '
    'DataGridViewTextBoxColumn64
    '
    Me.DataGridViewTextBoxColumn64.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn64.Name = "DataGridViewTextBoxColumn64"
    '
    'DataGridViewTextBoxColumn58
    '
    Me.DataGridViewTextBoxColumn58.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
    '
    'DataGridViewTextBoxColumn59
    '
    Me.DataGridViewTextBoxColumn59.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn59.Name = "DataGridViewTextBoxColumn59"
    '
    'DataGridViewTextBoxColumn61
    '
    Me.DataGridViewTextBoxColumn61.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn61.Name = "DataGridViewTextBoxColumn61"
    '
    'DataGridViewTextBoxColumn55
    '
    Me.DataGridViewTextBoxColumn55.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
    '
    'DataGridViewTextBoxColumn56
    '
    Me.DataGridViewTextBoxColumn56.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
    '
    'DataGridViewTextBoxColumn57
    '
    Me.DataGridViewTextBoxColumn57.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
    '
    'DataGridViewTextBoxColumn52
    '
    Me.DataGridViewTextBoxColumn52.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
    '
    'DataGridViewTextBoxColumn53
    '
    Me.DataGridViewTextBoxColumn53.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
    '
    'DataGridViewTextBoxColumn54
    '
    Me.DataGridViewTextBoxColumn54.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
    '
    'DataGridViewTextBoxColumn49
    '
    Me.DataGridViewTextBoxColumn49.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
    '
    'DataGridViewTextBoxColumn50
    '
    Me.DataGridViewTextBoxColumn50.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
    '
    'DataGridViewTextBoxColumn51
    '
    Me.DataGridViewTextBoxColumn51.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
    '
    'DataGridViewTextBoxColumn46
    '
    Me.DataGridViewTextBoxColumn46.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
    '
    'DataGridViewTextBoxColumn47
    '
    Me.DataGridViewTextBoxColumn47.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
    '
    'DataGridViewTextBoxColumn48
    '
    Me.DataGridViewTextBoxColumn48.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
    '
    'DataGridViewTextBoxColumn43
    '
    Me.DataGridViewTextBoxColumn43.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
    '
    'DataGridViewTextBoxColumn44
    '
    Me.DataGridViewTextBoxColumn44.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
    '
    'DataGridViewTextBoxColumn45
    '
    Me.DataGridViewTextBoxColumn45.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
    '
    'DataGridViewTextBoxColumn40
    '
    Me.DataGridViewTextBoxColumn40.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
    '
    'DataGridViewTextBoxColumn41
    '
    Me.DataGridViewTextBoxColumn41.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
    '
    'DataGridViewTextBoxColumn42
    '
    Me.DataGridViewTextBoxColumn42.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
    '
    'DataGridViewTextBoxColumn37
    '
    Me.DataGridViewTextBoxColumn37.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
    '
    'DataGridViewTextBoxColumn38
    '
    Me.DataGridViewTextBoxColumn38.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
    '
    'DataGridViewTextBoxColumn39
    '
    Me.DataGridViewTextBoxColumn39.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
    '
    'DataGridViewTextBoxColumn34
    '
    Me.DataGridViewTextBoxColumn34.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
    '
    'DataGridViewTextBoxColumn35
    '
    Me.DataGridViewTextBoxColumn35.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
    '
    'DataGridViewTextBoxColumn36
    '
    Me.DataGridViewTextBoxColumn36.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
    '
    'DataGridViewTextBoxColumn31
    '
    Me.DataGridViewTextBoxColumn31.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
    '
    'DataGridViewTextBoxColumn32
    '
    Me.DataGridViewTextBoxColumn32.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
    '
    'DataGridViewTextBoxColumn33
    '
    Me.DataGridViewTextBoxColumn33.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
    '
    'DataGridViewTextBoxColumn28
    '
    Me.DataGridViewTextBoxColumn28.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
    '
    'DataGridViewTextBoxColumn30
    '
    Me.DataGridViewTextBoxColumn30.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
    '
    'DataGridViewTextBoxColumn29
    '
    Me.DataGridViewTextBoxColumn29.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
    '
    'DataGridViewTextBoxColumn25
    '
    Me.DataGridViewTextBoxColumn25.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
    '
    'DataGridViewTextBoxColumn26
    '
    Me.DataGridViewTextBoxColumn26.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
    '
    'DataGridViewTextBoxColumn27
    '
    Me.DataGridViewTextBoxColumn27.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
    '
    'DataGridViewTextBoxColumn23
    '
    Me.DataGridViewTextBoxColumn23.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
    '
    'DataGridViewTextBoxColumn24
    '
    Me.DataGridViewTextBoxColumn24.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
    '
    'DataGridViewTextBoxColumn21
    '
    Me.DataGridViewTextBoxColumn21.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
    '
    'DataGridViewTextBoxColumn22
    '
    Me.DataGridViewTextBoxColumn22.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
    '
    'DataGridViewTextBoxColumn19
    '
    Me.DataGridViewTextBoxColumn19.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
    '
    'DataGridViewTextBoxColumn20
    '
    Me.DataGridViewTextBoxColumn20.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
    '
    'DataGridViewTextBoxColumn18
    '
    Me.DataGridViewTextBoxColumn18.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
    '
    'DataGridViewTextBoxColumn17
    '
    Me.DataGridViewTextBoxColumn17.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
    '
    'DataGridViewTextBoxColumn16
    '
    Me.DataGridViewTextBoxColumn16.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
    '
    'DataGridViewTextBoxColumn15
    '
    Me.DataGridViewTextBoxColumn15.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
    '
    'DataGridViewTextBoxColumn14
    '
    Me.DataGridViewTextBoxColumn14.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
    '
    'DataGridViewTextBoxColumn12
    '
    Me.DataGridViewTextBoxColumn12.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
    '
    'DataGridViewTextBoxColumn13
    '
    Me.DataGridViewTextBoxColumn13.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
    '
    'DataGridViewTextBoxColumn11
    '
    Me.DataGridViewTextBoxColumn11.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
    '
    'DataGridViewTextBoxColumn9
    '
    Me.DataGridViewTextBoxColumn9.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
    '
    'DataGridViewTextBoxColumn8
    '
    Me.DataGridViewTextBoxColumn8.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
    '
    'DataGridViewTextBoxColumn7
    '
    Me.DataGridViewTextBoxColumn7.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
    '
    'DataGridViewTextBoxColumn6
    '
    Me.DataGridViewTextBoxColumn6.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
    '
    'DataGridViewTextBoxColumn5
    '
    Me.DataGridViewTextBoxColumn5.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
    '
    'DataGridViewTextBoxColumn4
    '
    Me.DataGridViewTextBoxColumn4.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
    '
    'DataGridViewTextBoxColumn3
    '
    Me.DataGridViewTextBoxColumn3.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    '
    'DataGridViewTextBoxColumn10
    '
    Me.DataGridViewTextBoxColumn10.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
    '
    'DataGridViewTextBoxColumn60
    '
    Me.DataGridViewTextBoxColumn60.HeaderText = "No existen registros a presentar"
    Me.DataGridViewTextBoxColumn60.Name = "DataGridViewTextBoxColumn60"
    '
    'chkVisible
    '
    Me.chkVisible.AutoSize = True
    Me.chkVisible.Checked = True
    Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
    Me.chkVisible.Location = New System.Drawing.Point(277, 311)
    Me.chkVisible.Name = "chkVisible"
    Me.chkVisible.Size = New System.Drawing.Size(56, 17)
    Me.chkVisible.TabIndex = 25
    Me.chkVisible.Text = "Visible"
    '
    'CtlEmpleado
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.TabControl1)
    Me.Name = "CtlEmpleado"
    Me.Size = New System.Drawing.Size(793, 381)
    Me.TabControl1.ResumeLayout(False)
    Me.TabPage1.ResumeLayout(False)
    Me.TabPage2.ResumeLayout(False)
    Me.TabPage2.PerformLayout()
    Me.TabPage3.ResumeLayout(False)
    Me.TabPage3.PerformLayout()
    Me.TabPage4.ResumeLayout(False)
    Me.TabPage4.PerformLayout()
    CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BScontratosterminados, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSaplicacion, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.BSselecciondetalle, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
  Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
  Friend WithEvents CtlEntidadNatural1 As CtlEntidadNatural
  Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
  Friend WithEvents txtprimaria As System.Windows.Forms.TextBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents txtsecundaria As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents txtcursos As System.Windows.Forms.TextBox
  Friend WithEvents txtsuperior As System.Windows.Forms.TextBox
  Friend WithEvents txtrefper As System.Windows.Forms.TextBox
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents Label22 As System.Windows.Forms.Label
  Friend WithEvents txtreflab As System.Windows.Forms.TextBox
  Friend WithEvents txtsecanio As System.Windows.Forms.TextBox
  Friend WithEvents Label23 As System.Windows.Forms.Label
  Friend WithEvents txtprianio As System.Windows.Forms.TextBox
  Friend WithEvents txtsupanio As System.Windows.Forms.TextBox
  Friend WithEvents Label25 As System.Windows.Forms.Label
  Friend WithEvents Label27 As System.Windows.Forms.Label
  Friend WithEvents Label26 As System.Windows.Forms.Label
  Friend WithEvents txtbachiller As System.Windows.Forms.TextBox
  Friend WithEvents Label28 As System.Windows.Forms.Label
  Friend WithEvents txttitulo As System.Windows.Forms.TextBox
  Friend WithEvents Label29 As System.Windows.Forms.Label
  Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
  Friend WithEvents txtjubpatronal As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents txtpresquirog As Infoware.Controles.Base.TextBoxCalculator
  Friend WithEvents ComboBoxTipoCtaBancaria As ComboBoxParametroDet
  Friend WithEvents ComboBoxBanco As ComboBoxParametroDet
  Friend WithEvents ComboBoxFormaPagoRol As ComboBoxParametroDet
  Friend WithEvents ComboBoxTipoSangre As ComboBoxParametroDet
  Friend WithEvents txtavisoemer As System.Windows.Forms.TextBox
  Friend WithEvents Label15 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents txtenfermedad As System.Windows.Forms.TextBox
  Friend WithEvents Label36 As System.Windows.Forms.Label
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label24 As System.Windows.Forms.Label
  Friend WithEvents Label30 As System.Windows.Forms.Label
  Friend WithEvents Label33 As System.Windows.Forms.Label
  Friend WithEvents txtnumcta As System.Windows.Forms.TextBox
  Friend WithEvents chkexclfam As System.Windows.Forms.CheckBox
  Friend WithEvents Label20 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxTipoEmpleado As ComboBoxParametroDet
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
  Friend WithEvents CtlUbicacion1 As CtlUbicacion
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents CtlFotoPersona1 As Infoware.Controles.Base.ImagenSQL
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents dtfecafiliess As System.Windows.Forms.DateTimePicker
  Friend WithEvents ComboBoxDiscapacidad As ComboBoxParametroDet
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
  Friend WithEvents chkdiscafisica As System.Windows.Forms.CheckBox
  Friend WithEvents chkdiscapsicologica As System.Windows.Forms.CheckBox
  Friend WithEvents chkdiscaintelectual As System.Windows.Forms.CheckBox
  Friend WithEvents chkdiscavisual As System.Windows.Forms.CheckBox
  Friend WithEvents chkdiscalinguistica As System.Windows.Forms.CheckBox
  Friend WithEvents chkdiscaauditiva As System.Windows.Forms.CheckBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents ComboBoxSeguroCorporativo As ComboBoxParametroDet
  Friend WithEvents Label13 As System.Windows.Forms.Label
  Friend WithEvents cboSectorDomicilio As ComboBoxParametroDet
  Friend WithEvents BSaplicacion As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BSselecciondetalle As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents BScontratosterminados As System.Windows.Forms.BindingSource
  Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn31 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn32 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn33 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn34 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn35 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn36 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn37 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn38 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn39 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn40 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn41 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn42 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn43 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn44 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn45 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn46 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn47 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn48 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn49 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn50 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn51 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn52 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn53 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn54 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn55 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn56 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn57 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn58 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn59 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn61 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn60 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn62 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn63 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn64 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn65 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn66 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn67 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn68 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn69 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn70 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn71 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn72 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn73 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn74 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn75 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn76 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn77 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn78 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn79 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn80 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn81 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn82 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn83 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn84 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn85 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn86 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn87 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn88 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn89 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn90 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn91 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn92 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn93 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn94 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn95 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn96 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn97 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn98 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn99 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn100 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn101 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn102 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn103 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn104 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn105 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn106 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn107 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn108 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn109 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn110 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn111 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn112 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn113 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn114 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn115 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn116 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn117 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn118 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn119 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn120 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn121 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn122 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn123 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn124 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn125 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn126 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn127 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn128 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn129 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn130 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn131 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn132 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn133 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn134 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn135 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn136 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn137 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn138 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn139 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn140 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn141 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn142 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn143 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn144 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn145 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn146 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn147 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn148 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn149 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn150 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn151 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn152 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn153 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn154 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn155 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn156 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn157 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn158 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn159 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn160 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn161 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn162 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn163 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn164 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn165 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn166 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn167 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn168 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn169 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn170 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn171 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn172 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn173 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn174 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn175 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chckBachiller As System.Windows.Forms.CheckBox
  Friend WithEvents DataGridViewTextBoxColumn176 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn177 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn178 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn179 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn180 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn181 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents chckTitulo As System.Windows.Forms.CheckBox
  Friend WithEvents txtEspecializacion As System.Windows.Forms.TextBox
  Friend WithEvents Label19 As System.Windows.Forms.Label
  Friend WithEvents DataGridViewTextBoxColumn182 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn183 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn184 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn185 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn186 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn187 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn188 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn189 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn190 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn191 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn192 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn193 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn194 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn195 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn196 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn197 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn198 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn199 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn200 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn201 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn202 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn203 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn204 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn205 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn206 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn207 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn208 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn209 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn210 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn211 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn212 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn213 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn214 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents cboNacionalidad As ActivosFijos.Modulo.ComboBoxParametroDet
  Friend WithEvents chkVisible As System.Windows.Forms.CheckBox

End Class
