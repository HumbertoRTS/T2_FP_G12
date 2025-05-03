using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T2_FP_G12.Clases;


namespace T2_FP_G12
{
    public partial class RegistroProducto : Form
    {
        //Lista simple y almacenamiento de objeto
        public List<Producto> listProd = new List<Producto>();
        
       
        public RegistroProducto()
        {
            InitializeComponent();

            //Generación de columna del datagridview
            dgvprod.AutoGenerateColumns = false;
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_Nombre" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "CategoriaNombre" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "G12_Cantidad" });
            dgvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_Precio" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
        }

        private void OrdenarProd(bool ascendente)
        {
            int G12_n = listProd.Count;

            for (int i = 0; i < G12_n - 1; i++)
            {
                for (int j = 0; j < G12_n - i - 1; j++)
                {
                    if (ascendente ? listProd[j].G12_Precio > listProd[j + 1].G12_Precio
                                   : listProd[j].G12_Precio < listProd[j + 1].G12_Precio)
                    {
                        // Intercambio de elementos
                        Producto temp = listProd[j];
                        listProd[j] = listProd[j + 1];
                        listProd[j + 1] = temp;
                    }
                }
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos
                if (string.IsNullOrWhiteSpace(txtnombre.Text) || string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtcantidad.Text) || string.IsNullOrWhiteSpace(txtprecio.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación de duplicados
                foreach (var producto in listProd)
                {
                    if (producto.G12_Nombre.Equals(txtnombre.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Este producto ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Mostrar mensaje de confirmación para guardar el registro de datos del producto
                DialogResult guardar = MessageBox.Show("¿Está seguro de que desea registrar este producto?", "Confirmación",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (guardar == DialogResult.No)
                {
                    return; // Detener el guardado si el usuario elige "No"
                }

                //Agregar datos a Lista
                Categoria G12_categoria = new Categoria
                {
                    G12_Nombrecat=txtcategoria.Text
                };
                
                Producto G12_nuevoProducto = new Producto
                {
                    G12_Nombre = txtnombre.Text,
                    G12_categoria = G12_categoria,
                    G12_Cantidad = Convert.ToInt32(txtcantidad.Text),
                    G12_Precio = Convert.ToDouble(txtprecio.Text),
                };

                listProd.Add(G12_nuevoProducto);               

                //método de ordenar por precio de manera ascendente por método de burbuja
                OrdenarProd(true);

                // Actualiza el datagridview
                dgvprod.DataSource = null;
                dgvprod.DataSource = listProd;

                //Limpiar los textbox
                txtnombre.Clear();
                txtcategoria.Clear();
                txtcantidad.Clear();
                txtprecio.Clear();

                //Iniciar en el primer textbox
                txtnombre.Focus();
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Cantidad y precio deben ser valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar G12_buscar = new Buscar(this);
            G12_buscar.Tag = listProd; // Pasar la lista usando Tag          
            G12_buscar.Show();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea cancelar el registro del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }

        }

        private void btnstockcatg_Click(object sender, EventArgs e)
        {
            StockCat G12_stock = new StockCat(this);
            G12_stock.Tag = listProd; // Pasar la lista usando Tag
            G12_stock.Show();
        }        
    }
}
