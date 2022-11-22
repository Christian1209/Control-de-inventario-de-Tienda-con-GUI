using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class producto
    {
        private int codigo;
        private string nombre;
        private string description;
        private double precio;
        private int existencias;
        private double calculado;
        private double coste;


        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Description { get => description; set => description = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Existencia { get => existencias; set => existencias = value; }
        public double Coste { get => coste; set => coste = value; }
        public double Calculado { get => calculado; set => calculado = value; }
    }
}
