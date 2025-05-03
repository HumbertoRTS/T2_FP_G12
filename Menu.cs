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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnregprod_Click(object sender, EventArgs e)
        {
            RegistroProducto registroProducto = new RegistroProducto();
            registroProducto.Show();
        }
        
        private void tsbtitulo_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
