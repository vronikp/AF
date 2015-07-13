namespace ActivosFijos
{
    partial class frmIniciarToma2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblCustodio = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInventariar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.dgActivos = new System.Windows.Forms.DataGrid();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustodio
            // 
            this.lblCustodio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCustodio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustodio.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblCustodio.Location = new System.Drawing.Point(0, 39);
            this.lblCustodio.Name = "lblCustodio";
            this.lblCustodio.Size = new System.Drawing.Size(638, 15);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lblUbicacion.Location = new System.Drawing.Point(0, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(638, 39);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInventariar);
            this.panel2.Controls.Add(this.btnatras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 434);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 21);
            // 
            // btnInventariar
            // 
            this.btnInventariar.Location = new System.Drawing.Point(7, 1);
            this.btnInventariar.Name = "btnInventariar";
            this.btnInventariar.Size = new System.Drawing.Size(71, 18);
            this.btnInventariar.TabIndex = 14;
            this.btnInventariar.Text = "Invent.";
            this.btnInventariar.Click += new System.EventHandler(this.btnInventariar_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(84, 1);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(71, 18);
            this.btnatras.TabIndex = 16;
            this.btnatras.Text = "< Atrás";
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // dgActivos
            // 
            this.dgActivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgActivos.Location = new System.Drawing.Point(0, 54);
            this.dgActivos.Name = "dgActivos";
            this.dgActivos.Size = new System.Drawing.Size(638, 380);
            this.dgActivos.TabIndex = 6;
            // 
            // frmIniciarToma2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.dgActivos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblCustodio);
            this.Controls.Add(this.lblUbicacion);
            this.Menu = this.mainMenu1;
            this.Name = "frmIniciarToma2";
            this.Load += new System.EventHandler(this.frmIniciarToma2_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCustodio;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInventariar;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DataGrid dgActivos;
    }
}