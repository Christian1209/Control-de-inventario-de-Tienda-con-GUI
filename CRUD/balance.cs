using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class balance : Form
    {
        public balance()
        {
            InitializeComponent();
        }
        int gasto = 0;
        int ingreso = 0;
        int balan = 0;    

        private void balance_Load(object sender, EventArgs e)
        {
            MySqlDataReader reader = null;
            string sql = " SELECT SUM(total) FROM altas; ";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        gasto = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
            reader = null;
            sql = " SELECT SUM(total) FROM venta; ";
            conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ingreso = int.Parse(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el producto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al buscar" + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            txtIngreso.Text = ingreso.ToString();
            txtGasto.Text = gasto.ToString();
            balan = ingreso - gasto;
            txtBalance.Text = balan.ToString();
        }
    }
}
