namespace InventoryCount.SmartDevice
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.miConexion = new System.Windows.Forms.MenuItem();
            this.miActualizar = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBodega = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listUbicacion = new System.Windows.Forms.ListBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInvProd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvEq = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnProdPerec = new System.Windows.Forms.Button();
            this.txtBuscarCodUbi = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.miConexion);
            this.mainMenu1.MenuItems.Add(this.miActualizar);
            // 
            // miConexion
            // 
            this.miConexion.Text = "Conexion";
            // 
            // miActualizar
            // 
            this.miActualizar.Text = "Actualizar";
            this.miActualizar.Click += new System.EventHandler(this.miActualizar_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 16);
            this.label1.Text = "Bodega/Tienda:";
            // 
            // cboBodega
            // 
            this.cboBodega.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboBodega.Location = new System.Drawing.Point(0, 16);
            this.cboBodega.Name = "cboBodega";
            this.cboBodega.Size = new System.Drawing.Size(240, 22);
            this.cboBodega.TabIndex = 1;
            this.cboBodega.SelectedIndexChanged += new System.EventHandler(this.cboBodega_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 16);
            this.label2.Text = "Ubicación:";
            // 
            // listUbicacion
            // 
            this.listUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.listUbicacion.Location = new System.Drawing.Point(0, 75);
            this.listUbicacion.Name = "listUbicacion";
            this.listUbicacion.Size = new System.Drawing.Size(240, 58);
            this.listUbicacion.TabIndex = 4;
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacion.Location = new System.Drawing.Point(0, 133);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(240, 32);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 10);
            // 
            // btnInvProd
            // 
            this.btnInvProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvProd.Location = new System.Drawing.Point(0, 175);
            this.btnInvProd.Name = "btnInvProd";
            this.btnInvProd.Size = new System.Drawing.Size(240, 20);
            this.btnInvProd.TabIndex = 8;
            this.btnInvProd.Text = "Inventariar productos";
            this.btnInvProd.Click += new System.EventHandler(this.btnInvProd_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 10);
            // 
            // btnInvEq
            // 
            this.btnInvEq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvEq.Location = new System.Drawing.Point(0, 205);
            this.btnInvEq.Name = "btnInvEq";
            this.btnInvEq.Size = new System.Drawing.Size(240, 20);
            this.btnInvEq.TabIndex = 11;
            this.btnInvEq.Text = "Inventariar equipos";
            this.btnInvEq.Click += new System.EventHandler(this.btnInvEq_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 10);
            // 
            // btnProdPerec
            // 
            this.btnProdPerec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdPerec.Location = new System.Drawing.Point(0, 235);
            this.btnProdPerec.Name = "btnProdPerec";
            this.btnProdPerec.Size = new System.Drawing.Size(240, 20);
            this.btnProdPerec.TabIndex = 14;
            this.btnProdPerec.Text = "Inventariar productos perecibles";
            this.btnProdPerec.Click += new System.EventHandler(this.btnProdPerec_Click);
            // 
            // txtBuscarCodUbi
            // 
            this.txtBuscarCodUbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBuscarCodUbi.Location = new System.Drawing.Point(0, 54);
            this.txtBuscarCodUbi.Name = "txtBuscarCodUbi";
            this.txtBuscarCodUbi.Size = new System.Drawing.Size(240, 21);
            this.txtBuscarCodUbi.TabIndex = 21;
            this.txtBuscarCodUbi.PressEnter += new System.EventHandler(this.txtBuscarCodUbi_PressEnter);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnProdPerec);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnInvEq);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnInvProd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.listUbicacion);
            this.Controls.Add(this.txtBuscarCodUbi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBodega);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "FrmInicio";
            this.Text = "Inventario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem miConexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInvProd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInvEq;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnProdPerec;
        private System.Windows.Forms.MenuItem miActualizar;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtBuscarCodUbi;
    }
}

