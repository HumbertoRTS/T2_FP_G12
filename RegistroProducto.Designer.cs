namespace T2_FP_G12
{
    partial class RegistroProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroProducto));
            this.btncancelar = new System.Windows.Forms.Button();
            this.gbdatprod = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcategoria = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbllistprod = new System.Windows.Forms.Label();
            this.dgvprod = new System.Windows.Forms.DataGridView();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lbltituloreg = new System.Windows.Forms.Label();
            this.btnstockcatg = new System.Windows.Forms.Button();
            this.gbdatprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.AutoSize = true;
            this.btncancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(525, 206);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(147, 38);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "Cancelar Registro";
            this.btncancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gbdatprod
            // 
            this.gbdatprod.Controls.Add(this.txtprecio);
            this.gbdatprod.Controls.Add(this.lblprecio);
            this.gbdatprod.Controls.Add(this.txtcantidad);
            this.gbdatprod.Controls.Add(this.lblcantidad);
            this.gbdatprod.Controls.Add(this.txtcategoria);
            this.gbdatprod.Controls.Add(this.lblcategoria);
            this.gbdatprod.Controls.Add(this.txtnombre);
            this.gbdatprod.Controls.Add(this.lblnombre);
            this.gbdatprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdatprod.Location = new System.Drawing.Point(33, 69);
            this.gbdatprod.Name = "gbdatprod";
            this.gbdatprod.Size = new System.Drawing.Size(471, 180);
            this.gbdatprod.TabIndex = 3;
            this.gbdatprod.TabStop = false;
            this.gbdatprod.Text = "Datos del Producto";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(106, 134);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(327, 21);
            this.txtprecio.TabIndex = 7;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(37, 137);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(52, 15);
            this.lblprecio.TabIndex = 6;
            this.lblprecio.Text = "Precio:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(106, 101);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(327, 21);
            this.txtcantidad.TabIndex = 5;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(26, 104);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(68, 15);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(106, 70);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(327, 21);
            this.txtcategoria.TabIndex = 3;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(21, 73);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(73, 15);
            this.lblcategoria.TabIndex = 2;
            this.lblcategoria.Text = "Categoría:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(106, 40);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(327, 21);
            this.txtnombre.TabIndex = 1;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(27, 43);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(62, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // lbllistprod
            // 
            this.lbllistprod.AutoSize = true;
            this.lbllistprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistprod.Location = new System.Drawing.Point(35, 265);
            this.lbllistprod.Name = "lbllistprod";
            this.lbllistprod.Size = new System.Drawing.Size(130, 15);
            this.lbllistprod.TabIndex = 5;
            this.lbllistprod.Text = "Lista de Productos:";
            // 
            // dgvprod
            // 
            this.dgvprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprod.Location = new System.Drawing.Point(33, 289);
            this.dgvprod.Name = "dgvprod";
            this.dgvprod.ReadOnly = true;
            this.dgvprod.Size = new System.Drawing.Size(471, 136);
            this.dgvprod.TabIndex = 6;
            // 
            // btnregistrar
            // 
            this.btnregistrar.AutoSize = true;
            this.btnregistrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrar.Image")));
            this.btnregistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrar.Location = new System.Drawing.Point(525, 69);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(147, 38);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar Producto";
            this.btnregistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnregistrar.UseVisualStyleBackColor = false;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.AutoSize = true;
            this.btnbuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuscar.Location = new System.Drawing.Point(525, 118);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(147, 38);
            this.btnbuscar.TabIndex = 7;
            this.btnbuscar.Text = "Buscar Producto";
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lbltituloreg
            // 
            this.lbltituloreg.AutoSize = true;
            this.lbltituloreg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltituloreg.Location = new System.Drawing.Point(133, 18);
            this.lbltituloreg.Name = "lbltituloreg";
            this.lbltituloreg.Size = new System.Drawing.Size(266, 32);
            this.lbltituloreg.TabIndex = 8;
            this.lbltituloreg.Text = "Registrar Producto";
            // 
            // btnstockcatg
            // 
            this.btnstockcatg.AutoSize = true;
            this.btnstockcatg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnstockcatg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnstockcatg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstockcatg.Image = ((System.Drawing.Image)(resources.GetObject("btnstockcatg.Image")));
            this.btnstockcatg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstockcatg.Location = new System.Drawing.Point(525, 162);
            this.btnstockcatg.Name = "btnstockcatg";
            this.btnstockcatg.Size = new System.Drawing.Size(147, 38);
            this.btnstockcatg.TabIndex = 9;
            this.btnstockcatg.Text = "Stock Categoría";
            this.btnstockcatg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnstockcatg.UseVisualStyleBackColor = false;
            this.btnstockcatg.Click += new System.EventHandler(this.btnstockcatg_Click);
            // 
            // RegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 512);
            this.Controls.Add(this.btnstockcatg);
            this.Controls.Add(this.lbltituloreg);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvprod);
            this.Controls.Add(this.lbllistprod);
            this.Controls.Add(this.gbdatprod);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Name = "RegistroProducto";
            this.Text = "RegistroProducto";
            this.gbdatprod.ResumeLayout(false);
            this.gbdatprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.GroupBox gbdatprod;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcategoria;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbllistprod;
        private System.Windows.Forms.DataGridView dgvprod;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lbltituloreg;
        private System.Windows.Forms.Button btnstockcatg;
    }
}