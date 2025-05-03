using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_FP_G12.Clases
{
    public class Producto
    {
        public string G12_Nombre { get; set; }
        public Double G12_Precio { get; set; }
        public int G12_Cantidad { get; set; }
        public Categoria G12_categoria { get; set; }

        //Convierte la clase de Categoría a String para que el valor guardado pueda ser tomado en el datagridview
        public string CategoriaNombre
        {
            get
            {
                if (G12_categoria != null && !string.IsNullOrEmpty(G12_categoria.G12_Nombrecat))
                {
                    return G12_categoria.G12_Nombrecat;
                }
                else
                {
                    return "Sin categoría";
                }
            }
        }
    }
}
