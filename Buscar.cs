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
using static T2_FP_G12.RegistroProducto;

namespace T2_FP_G12
{
    public partial class Buscar : Form
    {

        private RegistroProducto G12_registro;
        
        public Buscar(RegistroProducto registroProducto)
        {
            InitializeComponent();
            G12_registro = registroProducto;//Se llama al formulario RegistroProducto y se setea en la palabra "registro", con el fin de trae la lista de los productos registrados
            //Generación de columna del datagridview de buscar
            dvprod.AutoGenerateColumns = false;
            dvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "G12_Nombre" });
            dvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "CategoriaNombre" });
            dvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Cantidad", DataPropertyName = "G12_Cantidad" });
            dvprod.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Precio", DataPropertyName = "G12_Precio" });

            //Elimina el botón de cerrar, minimizar y maximizar.
            this.ControlBox = false;
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            //Valida si hay datos en la lista listProd para mostrar en el datagridview
            if (G12_registro.listProd.Count > 0)
            {
                dvprod.DataSource = G12_registro.listProd;//Si hay datos, se muestra en el datagridview
            }
            else
            {
                MessageBox.Show("No hay productos disponibles para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); //Si no hay datos registrados en el datagridview, no se va a mostrar el formulario de buscar
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string G12_textoBuscado = txtbuscar.Text.Trim().ToLower();//

            // Lista para almacenar los productos filtrados
            List<Producto> G12_productosFiltrados = new List<Producto>();

            foreach (var G12_producto in G12_registro.listProd)
            {
                if (G12_producto.G12_Nombre.ToLower().Contains(G12_textoBuscado))
                {
                    G12_productosFiltrados.Add(G12_producto);
                }
            }

            //Actualiza el DataGridView con los resultados filtrados
            dvprod.DataSource = null;
            dvprod.DataSource = G12_productosFiltrados;
        }

        private void btnsalirbus_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Deseas salir de la ventana de búsqueda?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }

        }
    }
}

    

