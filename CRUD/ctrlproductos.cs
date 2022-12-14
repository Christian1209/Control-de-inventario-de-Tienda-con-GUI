using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class ctrlproductos
    {
        public List<Object> consulta(string clausula1, string columna2, string clausula2, string columna3)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (clausula1 == null)
            {
                sql = "SELECT codigo, nombre, descripcion, precio, existencia FROM producto ORDER BY codigo ASC";
            }
            else if (clausula2 == null)
            {
                sql = "SELECT * FROM producto " + clausula1 + " " + columna2 + "";
            }
            else {
                if (columna3 == null)
                {
                    sql = "SELECT * FROM producto " + clausula1 + " " + columna2 + " " + clausula2 + "";
                }
                sql = "SELECT * FROM producto " + clausula1 + " " + columna2 + " " + clausula2 + " " + columna3 + "";
            }
            try {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    producto _producto = new producto();
                    _producto.Codigo = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader.GetString(1);
                    _producto.Description = reader.GetString(2);
                    _producto.Precio = double.Parse(reader.GetString(3));
                    _producto.Existencia = int.Parse(reader.GetString(4));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }


        public List<Object> compara(string columna, string operador, string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null)
            {
                sql = "SELECT codigo, nombre, descripcion, precio, existencia FROM producto ORDER BY codigo ASC";
            }
            else
            {
                sql = "SELECT * FROM producto WHERE " + columna + " " + operador + " '" + dato + "'";
            }
            try
            {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    producto _producto = new producto();
                    _producto.Codigo = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader.GetString(1);
                    _producto.Description = reader.GetString(2);
                    _producto.Precio = double.Parse(reader.GetString(3));
                    _producto.Existencia = int.Parse(reader.GetString(4));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<Object> consultabasica(string columnas, bool cod, bool nomb, bool des, bool precio, bool exis,bool coste, bool calculada)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql = columnas;
            if (sql != "")
            {
                sql = "SELECT "+columnas+" FROM producto";
            }
            else
            {
                sql = "SELECT codigo, nombre, descripcion, precio, existencia, coste FROM producto ORDER BY codigo ASC";
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
                    producto _producto = new producto();
                    if (cod)
                    {
                        _producto.Codigo = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (nomb)
                    {
                        _producto.Nombre = reader.GetString(i);
                        i++;

                    }
                    if (des)
                    {
                        _producto.Description = reader.GetString(i);
                        i++;
                    }
                    if (precio)
                    {
                        _producto.Precio = double.Parse(reader.GetString(i));
                        i++;
                    }
                    if (exis)
                    {
                        _producto.Existencia = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (coste)
                    {
                        _producto.Coste = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (calculada)
                    {
                        _producto.Calculado = double.Parse(reader.GetString(i));
                    }
                    lista.Add(_producto);
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
