using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class ctrlcliente
    {
        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;
            if (dato == null)
            {
                sql = "SELECT codigo, nombre, apellidos, numero_telefono FROM cliente ORDER BY codigo ASC";
            }
            else
            {
                sql = "SELECT codigo, nombre, apellidos, numero_telefono FROM proveedor WHERE codigo LIKE '%" + dato + "%' OR nombre LIKE '%" + dato + "%' OR apellidos LIKE '%" + dato + "%' OR numero_telefono LIKE '%" + dato + "%' ORDER BY codigo ASC";
            }
            
            try
            {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cliente _cliente = new cliente();
                    _cliente.Codigo = int.Parse(reader.GetString(0));
                    _cliente.Nombre = reader.GetString(1);
                    _cliente.Apellidos = reader.GetString(2);
                    //_cliente.Numero_tel = double.Parse(reader.GetString(3));
                    lista.Add(_cliente);
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
                sql = "SELECT * FROM cliente WHERE "+columna+" "+operador+" '"+dato+"'";
                //SELECT * FROM contactos WHERE apellido != 'Jameson';

            }
            else
            {
                sql = "SELECT * FROM cliente WHERE " + columna + " " + operador + " '" + dato + "'";
            }
            try
            {
                MySqlConnection conexionBd = Conexion.conexion();
                conexionBd.Open();
                MySqlCommand comando = new MySqlCommand(sql, conexionBd);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cliente _cliente = new cliente();
                    _cliente.Codigo = int.Parse(reader.GetString(0));
                    _cliente.Nombre = reader.GetString(1);
                    _cliente.Apellidos = reader.GetString(2);
                    _cliente.Numero_tel = double.Parse(reader.GetString(3));
                    lista.Add(_cliente);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            return lista;
        }

        public List<Object> consultabasica(string columnas, bool cod, bool nomb, bool apellidos, bool num, bool exis)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql = columnas;
            if (sql != "")
            {
                sql = "SELECT " + columnas + " FROM cliente";
            }
            else
            {
                sql = "SELECT codigo, nombre, apellidos, numero_telefono FROM cliente ORDER BY codigo ASC";
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
                    cliente _cliente = new cliente();
                    if (cod)
                    {
                        _cliente.Codigo = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (nomb)
                    {
                        _cliente.Nombre = reader.GetString(i);
                        i++;

                    }
                    if (apellidos)
                    {
                        _cliente.Apellidos = reader.GetString(i);
                        i++;
                    }
                    if (num)
                    {
                        _cliente.Numero_tel = double.Parse(reader.GetString(i));
                    }
                    lista.Add(_cliente);
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
