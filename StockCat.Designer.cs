namespace T2_FP_G12
{
    partial class StockCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockCat));
            this.lblstockcat = new System.Windows.Forms.Label();
            this.lbltitulostock = new System.Windows.Forms.Label();
            this.txtstockcat = new System.Windows.Forms.TextBox();
            this.dgvstock = new System.Windows.Forms.DataGridView();
            this.btnsalirstock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstockcat
            // 
            this.lblstockcat.AutoSize = true;
            this.lblstockcat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockcat.Location = new System.Drawing.Point(38, 76);
            this.lblstockcat.Name = "lblstockcat";
            this.lblstockcat.Size = new System.Drawing.Size(68, 14);
            this.lblstockcat.TabIndex = 0;
            this.lblstockcat.Text = "Categoría:";
            // 
            // lbltitulostock
            // 
            this.lbltitulostock.AutoSize = true;
            this.lbltitulostock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulostock.Location = new System.Drawing.Point(122, 19);
            this.lbltitulostock.Name = "lbltitulostock";
            this.lbltitulostock.Size = new System.Drawing.Size(226, 32);
            this.lbltitulostock.TabIndex = 9;
            this.lbltitulostock.Text = "Stock Categoría";
            // 
            // txtstockcat
            // 
            this.txtstockcat.Location = new System.Drawing.Point(116, 73);
            this.txtstockcat.Name = "txtstockcat";
            this.txtstockcat.Size = new System.Drawing.Size(232, 20);
            this.txtstockcat.TabIndex = 10;
            this.txtstockcat.TextChanged += new System.EventHandler(this.txtstockcat_TextChanged);
            // 
            // dgvstock
            // 
            this.dgvstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstock.Location = new System.Drawing.Point(29, 114);
            this.dgvstock.Name = "dgvstock";
            this.dgvstock.ReadOnly = true;
            this.dgvstock.Size = new System.Drawing.Size(388, 151);
            this.dgvstock.TabIndex = 11;
            // 
            // btnsalirstock
            // 
            this.btnsalirstock.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirstock.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirstock.Image")));
            this.btnsalirstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirstock.Location = new System.Drawing.Point(180, 286);
            this.btnsalirstock.Name = "btnsalirstock";
            this.btnsalirstock.Size = new System.Drawing.Size(95, 39);
            this.btnsalirstock.TabIndex = 13;
            this.btnsalirstock.Text = "Salir";
            this.btnsalirstock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalirstock.UseVisualStyleBackColor = true;
            this.btnsalirstock.Click += new System.EventHandler(this.btnsalirstock_Click);
            // 
            // StockCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 358);
            this.Controls.Add(this.btnsalirstock);
            this.Controls.Add(this.dgvstock);
            this.Controls.Add(this.txtstockcat);
            this.Controls.Add(this.lbltitulostock);
            this.Controls.Add(this.lblstockcat);
            this.Name = "StockCat";
            this.Text = "Stock Categoría";
            this.Load += new System.EventHandler(this.StockProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstockcat;
        private System.Windows.Forms.Label lbltitulostock;
        private System.Windows.Forms.TextBox txtstockcat;
        private System.Windows.Forms.DataGridView dgvstock;
        private System.Windows.Forms.Button btnsalirstock;
    }
}