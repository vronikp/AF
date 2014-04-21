namespace ActivosFijos
{
    partial class frmInicioSesion
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
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblInventarios = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtUsuario = new ActivosFijos.Controles.TextBoxStd();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContrasena = new ActivosFijos.Controles.TextBoxStd();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Conexión";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSeleccionar.Location = new System.Drawing.Point(0, 0);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(115, 25);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Iniciar Sesión";
            this.btnSeleccionar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // lblInventarios
            // 
            this.lblInventarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventarios.Location = new System.Drawing.Point(0, 0);
            this.lblInventarios.Name = "lblInventarios";
            this.lblInventarios.Size = new System.Drawing.Size(240, 20);
            this.lblInventarios.Text = "Usuario:";
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Location = new System.Drawing.Point(125, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 25);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUsuario.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtUsuario.Location = new System.Drawing.Point(0, 20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 19);
            this.txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContrasena.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.txtContrasena.Location = new System.Drawing.Point(0, 59);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(240, 19);
            this.txtContrasena.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 25);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 13);
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblInventarios);
            this.Location = new System.Drawing.Point(0, 0);
            this.Menu = this.mainMenu1;
            this.Name = "frmInicioSesion";
            this.Text = "Iniciar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label lblInventarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuItem menuItem1;
        private ActivosFijos.Controles.TextBoxStd txtUsuario;
        private System.Windows.Forms.Label label1;
        private ActivosFijos.Controles.TextBoxStd txtContrasena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

