                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      namespace T2_FP_G12
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblregprod = new System.Windows.Forms.Label();
            this.btnregprod = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtitulo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblregprod
            // 
            this.lblregprod.AutoSize = true;
            this.lblregprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregprod.Location = new System.Drawing.Point(53, 140);
            this.lblregprod.Name = "lblregprod";
            this.lblregprod.Size = new System.Drawing.Size(133, 13);
            this.lblregprod.TabIndex = 3;
            this.lblregprod.Text = "Registro de Productos";
            // 
            // btnregprod
            // 
            this.btnregprod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregprod.BackgroundImage")));
            this.btnregprod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregprod.Location = new System.Drawing.Point(82, 47);
            this.btnregprod.Name = "btnregprod";
            this.btnregprod.Size = new System.Drawing.Size(85, 87);
            this.btnregprod.TabIndex = 8;
            this.btnregprod.UseVisualStyleBackColor = true;
            this.btnregprod.Click += new System.EventHandler(this.btnregprod_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtitulo,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(262, 38);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtitulo
            // 
            this.tsbtitulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtitulo.Image")));
            this.tsbtitulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtitulo.Name = "tsbtitulo";
            this.tsbtitulo.Size = new System.Drawing.Size(33, 35);
            this.tsbtitulo.Text = "Salir";
            this.tsbtitulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtitulo.Click += new System.EventHandler(this.tsbtitulo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 182);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnregprod);
            this.Controls.Add(this.lblregprod);
            this.Name = "Menu";
            this.Text = "Sistema de Inventario";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblregprod;
        private System.Windows.Forms.Button btnregprod;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtitulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

