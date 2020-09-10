namespace TP2_VentasCapas
{
    partial class frmVendedores
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
            this.btBaja = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.txFiltro = new System.Windows.Forms.TextBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.gv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // btBaja
            // 
            this.btBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaja.Location = new System.Drawing.Point(305, 360);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(75, 23);
            this.btBaja.TabIndex = 3;
            this.btBaja.Text = "Baja";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // btAlta
            // 
            this.btAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlta.Location = new System.Drawing.Point(467, 360);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 23);
            this.btAlta.TabIndex = 5;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btModificar.Location = new System.Drawing.Point(386, 360);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 4;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(12, 360);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 23);
            this.btClose.TabIndex = 6;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // txFiltro
            // 
            this.txFiltro.Location = new System.Drawing.Point(12, 18);
            this.txFiltro.Name = "txFiltro";
            this.txFiltro.Size = new System.Drawing.Size(236, 20);
            this.txFiltro.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(254, 15);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToOrderColumns = true;
            this.gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 44);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(530, 310);
            this.gv.TabIndex = 2;
            this.gv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_CellDoubleClick);
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 399);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txFiltro);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.gv);
            this.Name = "frmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Vendedores";
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.DataGridView gv;
    }
}