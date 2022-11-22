using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Ventas
    {
        private int n_compra;
        private int producto;
        private string nombre_producto;
        private int cantidad;
        private string fecha;
        private double total;

        public int Ncompra { get { return n_compra; } set { n_compra = value; } }
        public int Producto { get => producto; set => producto = value; }
        public string Nombreproducto { get => nombre_producto; set => nombre_producto = value;}
        public int Cantidad { get => cantidad; set => cantidad = value; } 
        public string Fecha { get => fecha; set => fecha = value; } 
        public double Total { get => total; set => total = value; } 
    }
}
