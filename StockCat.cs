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
    public partial class StockCat : Form
    {
        private RegistroProducto G12_registro;
        

        public StockCat(RegistroProducto registroProducto)
        {
            InitializeComponent();
            G12_registro = registroProducto;
            dgvstock.AutoGenerateColumns = false;
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Categoría", DataPropertyName = "G12_Nombrecat" });
            dgvstock.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Stock total", DataPropertyName = "G12_Stocktotal" });

            this.ControlBox = false;
        }

        // Método recursivo para calcular el stock total de una categoría
        private int CalcularStockRecursivo(string G12_categoria, List<Producto> G12_productos, int index = 0, int acumulado = 0)
        {
            if (index >= G12_productos.Count) return acumulado;

            if (G12_productos[index].G12_categoria.G12_Nombrecat.ToLower() == G12_categoria)
            {
                acumulado += G12_productos[index].G12_Cantidad;
            }

            return CalcularStockRecursivo(G12_categoria, G12_productos, index + 1, acumulado);
        }

        private void StockProd_Load(object sender, EventArgs e)
        {
            // Valida si hay datos en la lista listProd para mostrar en el DataGridView
            if (G12_registro.listProd == null || G12_registro.listProd.Count == 0)
            {
                MessageBox.Show("No hay stock disponibles para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            // Crea la lista de categorías con el stock total
            List<Categoria> G12_listaStockCategorias = new List<Categoria>();
            List<string> G12_categorias = new List<string>();

            foreach (var producto in G12_registro.listProd)
            {
                if (!G12_categorias.Contains(producto.G12_categoria.G12_Nombrecat))
                {
                    G12_categorias.Add(producto.G12_categoria.G12_Nombrecat);
                }
            }

            // Calcula el stock total para cada categoría
            foreach (var categoria in G12_categorias)
            {
                int G12_stockTotal = CalcularStockRecursivo(categoria, G12_registro.listProd);
                G12_listaStockCategorias.Add(new Categoria { G12_Nombrecat = categoria, G12_Stocktotal = G12_stockTotal });
            }

            // Asignar los datos al DataGridView
            dgvstock.DataSource = G12_listaStockCategorias;
            dgvstock.Refresh();

        }        

        private void txtstockcat_TextChanged(object sender, EventArgs e)
        {
            string G12_categoriaBuscada = txtstockcat.Text.Trim().ToLower();

            // Limpiar la lista para evitar acumulaciones de búsqueda
            List<Categoria> G12_listaStockCategorias = new List<Categoria>();

            if (string.IsNullOrEmpty(G12_categoriaBuscada))
            {
                // Mostrar todas las categorías si el txtstockcat está vacío
                List<string> G12_categorias = new List<string>();

                foreach (var producto in G12_registro.listProd)
                {
                    if (!G12_categorias.Contains(producto.G12_categoria.G12_Nombrecat))
                    {
                        G12_categorias.Add(producto.G12_categoria.G12_Nombrecat);
                    }
                }

                foreach (var categoria in G12_categorias)
                {
                    int G12_stockTotal = CalcularStockRecursivo(categoria, G12_registro.listProd);
                    G12_listaStockCategorias.Add(new Categoria { G12_Nombrecat = categoria, G12_Stocktotal = G12_stockTotal });
                }
            }
            else
            {
                // Filtrar por categoría ingresada
                int G12_stockTotal = CalcularStockRecursivo(G12_categoriaBuscada, G12_registro.listProd);
                G12_listaStockCategorias.Add(new Categoria { G12_Nombrecat = G12_categoriaBuscada, G12_Stocktotal = G12_stockTotal });
            }

            //Evita limpiar DataSource para mantener la búsqueda en tiempo real
            dgvstock.DataSource = G12_listaStockCategorias;
        }

        private void btnsalirstock_Click(object sender, EventArgs e)
        {
            DialogResult G12_cerrar = MessageBox.Show("¿Desea cerrar la ventana?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (G12_cerrar == DialogResult.Yes)
            {
                this.Close(); // Cierra la ventana si el usuario confirma la acción
            }
        }        
    }
}
