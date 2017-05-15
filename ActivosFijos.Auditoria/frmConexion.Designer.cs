namespace ActivosFijos
{
    partial class frmConexion
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
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConfiguracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServidor
            // 
            this.lblServidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblServidor.Location = new System.Drawing.Point(0, 0);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(240, 20);
            this.lblServidor.Text = "Servidor:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Location = new System.Drawing.Point(125, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 25);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGuardar.Location = new System.Drawing.Point(0, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 25);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtServidor.Location = new System.Drawing.Point(0, 20);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(240, 21);
            this.txtServidor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 13);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 25);
            // 
            // txtConfiguracion
            // 
            this.txtConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtConfiguracion.Location = new System.Drawing.Point(0, 61);
            this.txtConfiguracion.Name = "txtConfiguracion";
            this.txtConfiguracion.PasswordChar = '*';
            this.txtConfiguracion.Size = new System.Drawing.Size(240, 21);
            this.txtConfiguracion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.Text = "Configuracion:";
            // 
            // frmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtConfiguracion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmConexion";
            this.Text = "Conexión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtConfiguracion;
        private System.Windows.Forms.Label label1;
    }
}