namespace ActivosFijos
{
    partial class frmTomaActivo
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblCustodio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbActivo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.cboEstadoActivo = new System.Windows.Forms.ComboBox();
            this.txtSerie = new ActivosFijos.Controles.TextBoxStd();
            this.txtModelo = new ActivosFijos.Controles.TextBoxStd();
            this.pnlMarca = new System.Windows.Forms.Panel();
            this.txtMarca = new ActivosFijos.Controles.TextBoxStd();
            this.txtDescripcion = new ActivosFijos.Controles.TextBoxStd();
            this.txtClase = new ActivosFijos.Controles.TextBoxStd();
            this.txtCodigo = new ActivosFijos.Controles.TextBoxStd();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEstadoActivo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblClase = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSerie1 = new ActivosFijos.Controles.TextBoxStd();
            this.txtActivo = new ActivosFijos.Controles.TextBoxStd();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.pnlListaActivos = new System.Windows.Forms.Panel();
            this.dgActivos = new System.Windows.Forms.DataGrid();
            this.pnlCabeceraListaActivos = new System.Windows.Forms.Panel();
            this.pnlChk = new System.Windows.Forms.Panel();
            this.chbSoloUbicacion = new System.Windows.Forms.CheckBox();
            this.chkSoloInventariados = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tbActivo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlMarca.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlListaActivos.SuspendLayout();
            this.pnlCabeceraListaActivos.SuspendLayout();
            this.pnlChk.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUbicacion.Location = new System.Drawing.Point(0, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(638, 30);
            // 
            // lblCustodio
            // 
            this.lblCustodio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCustodio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustodio.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblCustodio.Location = new System.Drawing.Point(0, 30);
            this.lblCustodio.Name = "lblCustodio";
            this.lblCustodio.Size = new System.Drawing.Size(638, 15);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.Text = "Cod. Barra:";
            // 
            // tbActivo
            // 
            this.tbActivo.Controls.Add(this.tabPage1);
            this.tbActivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbActivo.Location = new System.Drawing.Point(0, 86);
            this.tbActivo.Name = "tbActivo";
            this.tbActivo.SelectedIndex = 0;
            this.tbActivo.Size = new System.Drawing.Size(638, 346);
            this.tbActivo.TabIndex = 2;
            this.tbActivo.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(638, 323);
            this.tabPage1.Text = "Datos";
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.pnlDatos);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(638, 323);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.cboEstadoActivo);
            this.pnlDatos.Controls.Add(this.txtSerie);
            this.pnlDatos.Controls.Add(this.txtModelo);
            this.pnlDatos.Controls.Add(this.pnlMarca);
            this.pnlDatos.Controls.Add(this.txtDescripcion);
            this.pnlDatos.Controls.Add(this.txtClase);
            this.pnlDatos.Controls.Add(this.txtCodigo);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(71, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(567, 323);
            // 
            // cboEstadoActivo
            // 
            this.cboEstadoActivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboEstadoActivo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cboEstadoActivo.Location = new System.Drawing.Point(0, 117);
            this.cboEstadoActivo.Name = "cboEstadoActivo";
            this.cboEstadoActivo.Size = new System.Drawing.Size(567, 20);
            this.cboEstadoActivo.TabIndex = 26;
            // 
            // txtSerie
            // 
            this.txtSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSerie.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtSerie.Location = new System.Drawing.Point(0, 98);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(567, 19);
            this.txtSerie.TabIndex = 24;
            // 
            // txtModelo
            // 
            this.txtModelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtModelo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtModelo.Location = new System.Drawing.Point(0, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(567, 19);
            this.txtModelo.TabIndex = 19;
            // 
            // pnlMarca
            // 
            this.pnlMarca.Controls.Add(this.txtMarca);
            this.pnlMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMarca.Location = new System.Drawing.Point(0, 57);
            this.pnlMarca.Name = "pnlMarca";
            this.pnlMarca.Size = new System.Drawing.Size(567, 22);
            // 
            // txtMarca
            // 
            this.txtMarca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarca.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtMarca.Location = new System.Drawing.Point(0, 0);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(567, 19);
            this.txtMarca.TabIndex = 16;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescripcion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtDescripcion.Location = new System.Drawing.Point(0, 38);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(567, 19);
            this.txtDescripcion.TabIndex = 14;
            // 
            // txtClase
            // 
            this.txtClase.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtClase.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtClase.Location = new System.Drawing.Point(0, 19);
            this.txtClase.Name = "txtClase";
            this.txtClase.Size = new System.Drawing.Size(567, 19);
            this.txtClase.TabIndex = 10;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCodigo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtCodigo.Location = new System.Drawing.Point(0, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(567, 19);
            this.txtCodigo.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblEstadoActivo);
            this.panel5.Controls.Add(this.lblSerie);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.lblMarca);
            this.panel5.Controls.Add(this.lblDescripcion);
            this.panel5.Controls.Add(this.lblClase);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(71, 323);
            // 
            // lblEstadoActivo
            // 
            this.lblEstadoActivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstadoActivo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblEstadoActivo.Location = new System.Drawing.Point(0, 120);
            this.lblEstadoActivo.Name = "lblEstadoActivo";
            this.lblEstadoActivo.Size = new System.Drawing.Size(71, 20);
            this.lblEstadoActivo.Text = "Estado:";
            // 
            // lblSerie
            // 
            this.lblSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSerie.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblSerie.Location = new System.Drawing.Point(0, 100);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(71, 20);
            this.lblSerie.Text = "Serie:";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label8.Location = new System.Drawing.Point(0, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblMarca.Location = new System.Drawing.Point(0, 60);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(71, 20);
            this.lblMarca.Text = "Marca:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescripcion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblDescripcion.Location = new System.Drawing.Point(0, 40);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(71, 20);
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblClase
            // 
            this.lblClase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClase.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblClase.Location = new System.Drawing.Point(0, 20);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(71, 20);
            this.lblClase.Text = "Clase:";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.Text = "Codigo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(5, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(55, 18);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Invent.";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.panel4);
            this.pnlBusqueda.Controls.Add(this.panel3);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 45);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(638, 41);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.txtSerie1);
            this.panel4.Controls.Add(this.txtActivo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(71, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 41);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(192, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 100);
            // 
            // txtSerie1
            // 
            this.txtSerie1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSerie1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtSerie1.Location = new System.Drawing.Point(0, 19);
            this.txtSerie1.Name = "txtSerie1";
            this.txtSerie1.Size = new System.Drawing.Size(567, 19);
            this.txtSerie1.TabIndex = 1;
            this.txtSerie1.PressEnter += new System.EventHandler(this.txtSerie1_PressEnter);
            // 
            // txtActivo
            // 
            this.txtActivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtActivo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtActivo.Location = new System.Drawing.Point(0, 0);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(567, 19);
            this.txtActivo.TabIndex = 0;
            this.txtActivo.PressEnter += new System.EventHandler(this.txtActivo_PressEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(71, 41);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.Text = "Serie:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnatras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 432);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 23);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(112, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(64, 18);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Cancelar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(88, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(20, 18);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(64, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 18);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(180, 2);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(63, 18);
            this.btnatras.TabIndex = 16;
            this.btnatras.Text = "Salir";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // pnlListaActivos
            // 
            this.pnlListaActivos.Controls.Add(this.dgActivos);
            this.pnlListaActivos.Controls.Add(this.pnlCabeceraListaActivos);
            this.pnlListaActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListaActivos.Location = new System.Drawing.Point(0, 86);
            this.pnlListaActivos.Name = "pnlListaActivos";
            this.pnlListaActivos.Size = new System.Drawing.Size(638, 346);
            // 
            // dgActivos
            // 
            this.dgActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgActivos.Location = new System.Drawing.Point(0, 51);
            this.dgActivos.Name = "dgActivos";
            this.dgActivos.Size = new System.Drawing.Size(638, 295);
            this.dgActivos.TabIndex = 11;
            // 
            // pnlCabeceraListaActivos
            // 
            this.pnlCabeceraListaActivos.Controls.Add(this.pnlChk);
            this.pnlCabeceraListaActivos.Controls.Add(this.btnConsultar);
            this.pnlCabeceraListaActivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraListaActivos.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraListaActivos.Name = "pnlCabeceraListaActivos";
            this.pnlCabeceraListaActivos.Size = new System.Drawing.Size(638, 51);
            // 
            // pnlChk
            // 
            this.pnlChk.Controls.Add(this.chbSoloUbicacion);
            this.pnlChk.Controls.Add(this.chkSoloInventariados);
            this.pnlChk.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChk.Location = new System.Drawing.Point(0, 0);
            this.pnlChk.Name = "pnlChk";
            this.pnlChk.Size = new System.Drawing.Size(192, 51);
            // 
            // chbSoloUbicacion
            // 
            this.chbSoloUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.chbSoloUbicacion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chbSoloUbicacion.Location = new System.Drawing.Point(0, 23);
            this.chbSoloUbicacion.Name = "chbSoloUbicacion";
            this.chbSoloUbicacion.Size = new System.Drawing.Size(192, 28);
            this.chbSoloUbicacion.TabIndex = 8;
            this.chbSoloUbicacion.Text = "Sólo de la ubicación seleccionada";
            this.chbSoloUbicacion.CheckStateChanged += new System.EventHandler(this.chbSoloUbicacion_CheckStateChanged);
            // 
            // chkSoloInventariados
            // 
            this.chkSoloInventariados.Checked = true;
            this.chkSoloInventariados.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloInventariados.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSoloInventariados.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.chkSoloInventariados.Location = new System.Drawing.Point(0, 0);
            this.chkSoloInventariados.Name = "chkSoloInventariados";
            this.chkSoloInventariados.Size = new System.Drawing.Size(192, 23);
            this.chkSoloInventariados.TabIndex = 10;
            this.chkSoloInventariados.Text = "Sólo no inventariados";
            this.chkSoloInventariados.CheckStateChanged += new System.EventHandler(this.chkSoloInventariados_CheckStateChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConsultar.Location = new System.Drawing.Point(566, 0);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(72, 51);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmTomaActivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.tbActivo);
            this.Controls.Add(this.pnlListaActivos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.lblCustodio);
            this.Controls.Add(this.lblUbicacion);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTomaActivo";
            this.Text = "Toma Activo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTomaActivo_Load);
            this.tbActivo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlDatos.ResumeLayout(false);
            this.pnlMarca.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlListaActivos.ResumeLayout(false);
            this.pnlCabeceraListaActivos.ResumeLayout(false);
            this.pnlChk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUbicacion;
        private ActivosFijos.Controles.TextBoxStd txtActivo;
        private System.Windows.Forms.Label lblCustodio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tbActivo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private ActivosFijos.Controles.TextBoxStd txtSerie1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel panel7;
        private ActivosFijos.Controles.TextBoxStd txtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Panel pnlListaActivos;
        private System.Windows.Forms.CheckBox chbSoloUbicacion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkSoloInventariados;
        private System.Windows.Forms.DataGrid dgActivos;
        private ActivosFijos.Controles.TextBoxStd txtDescripcion;
        private ActivosFijos.Controles.TextBoxStd txtClase;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlMarca;
        private ActivosFijos.Controles.TextBoxStd txtMarca;
        private ActivosFijos.Controles.TextBoxStd txtSerie;
        private ActivosFijos.Controles.TextBoxStd txtModelo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.ComboBox cboEstadoActivo;
        private System.Windows.Forms.Label lblEstadoActivo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlCabeceraListaActivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlChk;
    }
}