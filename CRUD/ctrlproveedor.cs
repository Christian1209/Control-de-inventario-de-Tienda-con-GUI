using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class ctrlproveedor
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null)
            {
                sql = "SELECT codigo, marca, cod_producto, numero_telefono FROM proveedor ORDER BY codigo ASC";
            }
            else
            {
                sql = "SELECT codigo, nombre, cod_producto, numero_telefono FROM proveedor WHERE codigo LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR cod_producto LIKE '%" + dato + "%' OR numero_telefono LIKE '%" + dato + "%' ORDER BY codigo ASC";
            }
            try
            {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    proveedor _proveedor = new proveedor();
                    _proveedor.Codigo = int.Parse(reader.GetString(0));
                    _proveedor.Marca = reader.GetString(1);
                    _proveedor.Producto = int.Parse(reader.GetString(2));
                    _proveedor.Numero_tel = int.Parse(reader.GetString(3));
                    lista.Add(_proveedor);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<Object> consultabasica(string columnas, bool cod, bool marca, bool producto, bool num, bool exis)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql = columnas;
            if (sql != "")
            {
                sql = "SELECT " + columnas + " FROM proveedor";
            }
            else
            {
                sql = "SELECT codigo, marca, cod_producto, numero_telefono FROM proveedor ORDER BY codigo ASC";
            }
            try
            {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    int i = 0;
                    proveedor _proveedor = new proveedor();
                    if (cod)
                    {
                        _proveedor.Codigo = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (marca)
                    {
                        _proveedor.Marca = reader.GetString(i);
                        i++;

                    }
                    if (producto)
                    {
                        _proveedor.Producto = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (num)
                    {
                        _proveedor.Numero_tel = int.Parse(reader.GetString(i));
                    }
                    lista.Add(_proveedor);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }
    }
}
