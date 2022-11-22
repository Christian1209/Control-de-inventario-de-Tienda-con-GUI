using System;
using MySql.Data.MySqlClient;
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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtNum.Text = "";
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                String nombre = txtNombre.Text;
                String apellidos = txtApellidos.Text;
                double num_tel = int.Parse(txtNum.Text);
                if (nombre != "" && apellidos != "" && num_tel > 0)
                {

                    string sql = "INSERT INTO cliente (codigo, nombre, apellidos, numero_telefono) Values ('" + codigo +
                        "','" + nombre + "','" + apellidos + "','" + num_tel + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
                        limpiar();
                        //cargarTabla(null, null, null, null);

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT nombre, apellidos, numero_telefono FROM cliente WHERE codigo LIKE '"
                + codigo + "'LIMIT 1";
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
                        txtNombre.Text = reader.GetString(0);
                        txtApellidos.Text = reader.GetString(1);
                        txtNum.Text = reader.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros");
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
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            double numero_tel = double.Parse(txtNum.Text);

            string sql = "UPDATE cliente SET nombre='" + nombre + "', apellidos='" + apellidos +
                "', numero_telefono='" + numero_tel + "' WHERE codigo='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Modificado");
                limpiar();
                //cargarTabla(null, null, null, null);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al Modificar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            String id = txtCodigo.Text;

            string sql = "DELETE FROM cliente WHERE codigo= '" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
                //cargarTabla(null, null, null, null);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al Eliminar: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("alter table cliente add " + txtColumna.Text + " " + txtTipoDeDato.Text + "", conexionBD);
                cmd.Prepare();
                cmd.ExecuteNonQuery(); //execute the mysql command
                MessageBox.Show("Columna agregada");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al agregar columna: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
