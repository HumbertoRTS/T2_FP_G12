namespace T2_FP_G12
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.dvprod = new System.Windows.Forms.DataGridView();
            this.btnsalirbus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(135, 12);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(236, 32);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Buscar Producto";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(18, 63);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(105, 13);
            this.lblbuscar.TabIndex = 1;
            this.lblbuscar.Text = "Buscar Producto:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(129, 60);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(270, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // dvprod
            // 
            this.dvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvprod.Location = new System.Drawing.Point(21, 102);
            this.dvprod.Name = "dvprod";
            this.dvprod.ReadOnly = true;
            this.dvprod.Size = new System.Drawing.Size(481, 169);
            this.dvprod.TabIndex = 3;
            // 
            // btnsalirbus
            // 
            this.btnsalirbus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalirbus.Image = ((System.Drawing.Image)(resources.GetObject("btnsalirbus.Image")));
            this.btnsalirbus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalirbus.Location = new System.Drawing.Point(427, 41);
            this.btnsalirbus.Name = "btnsalirbus";
            this.btnsalirbus.Size = new System.Drawing.Size(75, 39);
            this.btnsalirbus.TabIndex = 4;
            this.btnsalirbus.Text = "Salir";
            this.btnsalirbus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsalirbus.UseVisualStyleBackColor = true;
            this.btnsalirbus.Click += new System.EventHandler(this.btnsalirbus_Click);
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 294);
            this.Controls.Add(this.btnsalirbus);
            this.Controls.Add(this.dvprod);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Buscar";
            this.Text = "Buscar Producto";
            this.Load += new System.EventHandler(this.Buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.DataGridView dvprod;
        private System.Windows.Forms.Button btnsalirbus;
    }
}