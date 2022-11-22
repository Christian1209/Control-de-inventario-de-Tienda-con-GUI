using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class alta
    {
        private int id;
        private int producto;
        private string nombreproducto;
        private int cantidad;
        private string fecha;
        private double total;

        public int Id { get { return id; } set { id = value; } }
        public int Producto { get => producto; set => producto = value; }
        public string Nombreproducto { get => nombreproducto; set => nombreproducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Total { get => total; set => total = value; }
    }
}
