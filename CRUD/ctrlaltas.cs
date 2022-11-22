using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class ctrlaltas
    {
        public List<Object> consultabasica(string columnas, bool id, bool idproducto, bool nombreproducto, bool cantidad, bool fecha, bool total)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql = columnas;
            if (sql != " ")
            {
                sql = "SELECT " + columnas + " FROM altas";
            }
            else
            {
                sql = "SELECT id, idproducto, nombreproducto, cantidad, fecha,total FROM altas ORDER BY id ASC";
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
                    alta _venta = new alta();
                    if (id)
                    {
                        _venta.Id = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (idproducto)
                    {
                        _venta.Producto = int.Parse(reader.GetString(i));
                        i++;

                    }
                    if (nombreproducto)
                    {
                        _venta.Nombreproducto = reader.GetString(i);
                        i++;
                    }
                    if (cantidad)
                    {
                        _venta.Cantidad = int.Parse(reader.GetString(i));
                        i++;
                    }
                    if (fecha)
                    {
                        _venta.Fecha = reader.GetString(i);
                        i++;
                    }
                    if (total)
                    {
                        _venta.Total = double.Parse(reader.GetString(i));
                    }
                    lista.Add(_venta);
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
