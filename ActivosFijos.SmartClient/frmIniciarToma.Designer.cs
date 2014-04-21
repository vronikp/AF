namespace ActivosFijos
{
    partial class frmIniciarToma
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cboCustodio = new System.Windows.Forms.ComboBox();
            this.lblCustodio = new System.Windows.Forms.Label();
            this.cboUbicacion = new System.Windows.Forms.ListBox();
            this.lblUbicacionCompleta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtparcial = new ActivosFijos.Controles.TextBoxStd();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSeleccionar.Location = new System.Drawing.Point(0, 0);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(114, 31);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacion.Location = new System.Drawing.Point(0, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(240, 20);
            this.lblUbicacion.Text = "Ubicación:";
            // 
            // btnAtras
            // 
            this.btnAtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAtras.Location = new System.Drawing.Point(126, 0);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(114, 31);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "<< Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // cboCustodio
            // 
            this.cboCustodio.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboCustodio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboCustodio.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cboCustodio.Location = new System.Drawing.Point(0, 155);
            this.cboCustodio.Name = "cboCustodio";
            this.cboCustodio.Size = new System.Drawing.Size(240, 20);
            this.cboCustodio.TabIndex = 2;
            // 
            // lblCustodio
            // 
            this.lblCustodio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblCustodio.Location = new System.Drawing.Point(0, 0);
            this.lblCustodio.Name = "lblCustodio";
            this.lblCustodio.Size = new System.Drawing.Size(59, 23);
            this.lblCustodio.Text = "Custodio:";
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboUbicacion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.cboUbicacion.Location = new System.Drawing.Point(0, 20);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(240, 67);
            this.cboUbicacion.TabIndex = 0;
            this.cboUbicacion.SelectedIndexChanged += new System.EventHandler(this.cboUbicacion_SelectedIndexChanged);
            // 
            // lblUbicacionCompleta
            // 
            this.lblUbicacionCompleta.BackColor = System.Drawing.SystemColors.Info;
            this.lblUbicacionCompleta.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacionCompleta.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblUbicacionCompleta.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblUbicacionCompleta.Location = new System.Drawing.Point(0, 87);
            this.lblUbicacionCompleta.Name = "lblUbicacionCompleta";
            this.lblUbicacionCompleta.Size = new System.Drawing.Size(240, 45);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 31);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 7);
            // 
            // txtparcial
            // 
            this.txtparcial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtparcial.Location = new System.Drawing.Point(59, 0);
            this.txtparcial.Name = "txtparcial";
            this.txtparcial.Size = new System.Drawing.Size(181, 21);
            this.txtparcial.TabIndex = 1;
            this.txtparcial.PressEnter += new System.EventHandler(this.txtparcial_PressEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtparcial);
            this.panel3.Controls.Add(this.lblCustodio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 132);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 23);
            // 
            // frmIniciarToma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboCustodio);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblUbicacionCompleta);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.lblUbicacion);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frmIniciarToma";
            this.Text = "Iniciar Toma Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIniciarToma_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cboCustodio;
        private System.Windows.Forms.Label lblCustodio;
        private System.Windows.Forms.ListBox cboUbicacion;
        private System.Windows.Forms.Label lblUbicacionCompleta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ActivosFijos.Controles.TextBoxStd txtparcial;
        private System.Windows.Forms.Panel panel3;
    }
}

