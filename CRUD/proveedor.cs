using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class proveedor
    {
        private int codigo;
        private string marca;
        private int producto;
        private int numero_telefono;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Producto { get => producto; set => producto = value; }
        public int Numero_tel { get => numero_telefono; set => numero_telefono = value; }
    }
}
