namespace InventoryCount.SmartDevice
{
    partial class FrmInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.miGuardar = new System.Windows.Forms.MenuItem();
            this.pnlCodigo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSerie = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlLote = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlFechaVenc = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCantidad = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bsInventarioDet = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgInventarioDet = new System.Windows.Forms.DataGrid();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.txtTotal = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.txtCantidad = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.dtpFecVenc = new InventoryCount.SmartDevice.Controles.DateTimePickerStd();
            this.txtNoLote = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.txtSerie = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.txtCodigo = new InventoryCount.SmartDevice.Controles.TextBoxStd();
            this.pnlCodigo.SuspendLayout();
            this.pnlSerie.SuspendLayout();
            this.pnlLote.SuspendLayout();
            this.pnlFechaVenc.SuspendLayout();
            this.pnlCantidad.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioDet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.miGuardar);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Transferir";
            // 
            // miGuardar
            // 
            this.miGuardar.Text = "Guardar";
            this.miGuardar.Click += new System.EventHandler(this.miGuardar_Click);
            // 
            // pnlCodigo
            // 
            this.pnlCodigo.Controls.Add(this.txtCodigo);
            this.pnlCodigo.Controls.Add(this.label1);
            this.pnlCodigo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCodigo.Location = new System.Drawing.Point(0, 22);
            this.pnlCodigo.Name = "pnlCodigo";
            this.pnlCodigo.Size = new System.Drawing.Size(240, 22);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.Text = "Código:";
            // 
            // pnlSerie
            // 
            this.pnlSerie.Controls.Add(this.txtSerie);
            this.pnlSerie.Controls.Add(this.label2);
            this.pnlSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSerie.Location = new System.Drawing.Point(0, 44);
            this.pnlSerie.Name = "pnlSerie";
            this.pnlSerie.Size = new System.Drawing.Size(240, 22);
            this.pnlSerie.Visible = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.Text = "Serie:";
            // 
            // pnlLote
            // 
            this.pnlLote.Controls.Add(this.txtNoLote);
            this.pnlLote.Controls.Add(this.label3);
            this.pnlLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLote.Location = new System.Drawing.Point(0, 66);
            this.pnlLote.Name = "pnlLote";
            this.pnlLote.Size = new System.Drawing.Size(240, 22);
            this.pnlLote.Visible = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.Text = "No. Lote:";
            // 
            // pnlFechaVenc
            // 
            this.pnlFechaVenc.Controls.Add(this.dtpFecVenc);
            this.pnlFechaVenc.Controls.Add(this.label4);
            this.pnlFechaVenc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFechaVenc.Location = new System.Drawing.Point(0, 88);
            this.pnlFechaVenc.Name = "pnlFechaVenc";
            this.pnlFechaVenc.Size = new System.Drawing.Size(240, 22);
            this.pnlFechaVenc.Visible = false;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.Text = "Fecha Venc.:";
            // 
            // pnlCantidad
            // 
            this.pnlCantidad.Controls.Add(this.txtCantidad);
            this.pnlCantidad.Controls.Add(this.label5);
            this.pnlCantidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCantidad.Location = new System.Drawing.Point(0, 110);
            this.pnlCantidad.Name = "pnlCantidad";
            this.pnlCantidad.Size = new System.Drawing.Size(240, 22);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.Text = "Cantidad:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 22);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.Text = "Total:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuitar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 22);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuitar.Location = new System.Drawing.Point(120, 0);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(120, 22);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 22);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgInventarioDet
            // 
            this.dgInventarioDet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgInventarioDet.DataSource = this.bsInventarioDet;
            this.dgInventarioDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgInventarioDet.Location = new System.Drawing.Point(0, 154);
            this.dgInventarioDet.Name = "dgInventarioDet";
            this.dgInventarioDet.Size = new System.Drawing.Size(240, 92);
            this.dgInventarioDet.TabIndex = 20;
            this.dgInventarioDet.CurrentCellChanged += new System.EventHandler(this.dgInventarioDet_CurrentCellChanged);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.lblUbicacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUbicacion.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Regular);
            this.lblUbicacion.Location = new System.Drawing.Point(0, 0);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(240, 22);
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtTotal.Location = new System.Drawing.Point(98, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(142, 21);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCantidad.Location = new System.Drawing.Point(98, 0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 21);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            this.txtCantidad.PressEnter += new System.EventHandler(this.txtCantidad_PressEnter);
            // 
            // dtpFecVenc
            // 
            this.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecVenc.Location = new System.Drawing.Point(98, 0);
            this.dtpFecVenc.Name = "dtpFecVenc";
            this.dtpFecVenc.Size = new System.Drawing.Size(142, 22);
            this.dtpFecVenc.TabIndex = 3;
            this.dtpFecVenc.PressEnter += new System.EventHandler(this.dtpFecVenc_PressEnter);
            // 
            // txtNoLote
            // 
            this.txtNoLote.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtNoLote.Location = new System.Drawing.Point(98, 0);
            this.txtNoLote.Name = "txtNoLote";
            this.txtNoLote.Size = new System.Drawing.Size(142, 21);
            this.txtNoLote.TabIndex = 1;
            this.txtNoLote.PressEnter += new System.EventHandler(this.txtNoLote_PressEnter);
            // 
            // txtSerie
            // 
            this.txtSerie.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSerie.Location = new System.Drawing.Point(98, 0);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(142, 21);
            this.txtSerie.TabIndex = 1;
            this.txtSerie.PressEnter += new System.EventHandler(this.txtSerie_PressEnter);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtCodigo.Location = new System.Drawing.Point(98, 0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 21);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.PressEnter += new System.EventHandler(this.txtCodigo_PressEnter);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.dgInventarioDet);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCantidad);
            this.Controls.Add(this.pnlFechaVenc);
            this.Controls.Add(this.pnlLote);
            this.Controls.Add(this.pnlSerie);
            this.Controls.Add(this.pnlCodigo);
            this.Controls.Add(this.lblUbicacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "FrmInventario";
            this.Text = "Inventario";
            this.pnlCodigo.ResumeLayout(false);
            this.pnlSerie.ResumeLayout(false);
            this.pnlLote.ResumeLayout(false);
            this.pnlFechaVenc.ResumeLayout(false);
            this.pnlCantidad.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsInventarioDet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCodigo;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSerie;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLote;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtNoLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlFechaVenc;
        private InventoryCount.SmartDevice.Controles.DateTimePickerStd dtpFecVenc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCantidad;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private InventoryCount.SmartDevice.Controles.TextBoxStd txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem miGuardar;
        private System.Windows.Forms.BindingSource bsInventarioDet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGrid dgInventarioDet;
        private System.Windows.Forms.Label lblUbicacion;
    }
}