using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Conexion
    {
        public static MySqlConnection conexion()
        {
            string servidor = "localhost";
            string bd = "proyecto";
            string usuario = "root";
            string password = "iop90iop";
            string cadenaconexion = "Database= " + bd + "; Datasource= " +
                servidor + "; User id= " + usuario + "; password= " +
                password + "";
            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaconexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;

            }
        }

    }
}
