namespace TP2_VentasCapas
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDI));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btArticulos = new System.Windows.Forms.ToolStripButton();
            this.btClientes = new System.Windows.Forms.ToolStripButton();
            this.btVendedores = new System.Windows.Forms.ToolStripButton();
            this.btVentas = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 411);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btArticulos,
            this.btClientes,
            this.btVendedores,
            this.btVentas});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(679, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btArticulos
            // 
            this.btArticulos.Image = ((System.Drawing.Image)(resources.GetObject("btArticulos.Image")));
            this.btArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btArticulos.Name = "btArticulos";
            this.btArticulos.Size = new System.Drawing.Size(74, 22);
            this.btArticulos.Text = "Artículos";
            this.btArticulos.Click += new System.EventHandler(this.btArticulos_Click);
            // 
            // btClientes
            // 
            this.btClientes.Image = ((System.Drawing.Image)(resources.GetObject("btClientes.Image")));
            this.btClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClientes.Name = "btClientes";
            this.btClientes.Size = new System.Drawing.Size(69, 22);
            this.btClientes.Text = "Clientes";
            this.btClientes.Click += new System.EventHandler(this.BtClientes_Click);
            // 
            // btVendedores
            // 
            this.btVendedores.Image = ((System.Drawing.Image)(resources.GetObject("btVendedores.Image")));
            this.btVendedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVendedores.Name = "btVendedores";
            this.btVendedores.Size = new System.Drawing.Size(88, 22);
            this.btVendedores.Text = "Vendedores";
            this.btVendedores.Click += new System.EventHandler(this.BtVendedores_Click);
            // 
            // btVentas
            // 
            this.btVentas.Image = ((System.Drawing.Image)(resources.GetObject("btVentas.Image")));
            this.btVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btVentas.Name = "btVentas";
            this.btVentas.Size = new System.Drawing.Size(61, 22);
            this.btVentas.Text = "Ventas";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 433);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Capas - TP2 - Grupo:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDI_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btVentas;
        private System.Windows.Forms.ToolStripButton btArticulos;
        private System.Windows.Forms.ToolStripButton btClientes;
        private System.Windows.Forms.ToolStripButton btVendedores;
    }
}

