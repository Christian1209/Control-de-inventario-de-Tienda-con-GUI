using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class cliente
    {
        private int codigo;
        private string nombre;
        private string apellidos;
        private double numero_telefono;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public double Numero_tel { get => numero_telefono; set => numero_telefono = value; }
    }
}
