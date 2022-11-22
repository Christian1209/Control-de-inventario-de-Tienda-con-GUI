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
    public partial class FormProducto : Form
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


        }
        private void limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtExistencia.Text = "";
        }


        private void cargarTabla(string clausula1, string columna2, string clausula2, string columna3)
        {
            /*
            dtagridProducto.Visible = true;

                List<producto> lista = new List<producto>();
                ctrlproductos _ctrlProductos = new ctrlproductos();
                dtagridProducto.DataSource = _ctrlProductos.consulta(clausula1, columna2, clausula2, columna3);
                dtagridProducto.Visible = true;
            */
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            String codigo = txtCodigo.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT nombre, descripcion, precio, existencia, coste FROM producto WHERE codigo LIKE '"
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
                        txtDescripcion.Text = reader.GetString(1);
                        txtPrecio.Text = reader.GetString(2);
                        txtExistencia.Text = reader.GetString(3);
                        txtCoste.Text = reader.GetString(4);    
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                try
                {
                    int codigo = int.Parse(txtCodigo.Text);
                    String nombre = txtNombre.Text;
                    String descripcion = txtDescripcion.Text;
                    int existencia = int.Parse(txtExistencia.Text);
                    double precio_publico = double.Parse(txtPrecio.Text);
                    double coste = double.Parse(txtCoste.Text);
                    if (nombre != "" && descripcion != "" && existencia > 0 && precio_publico > 0)
                    {

                        string sql = "INSERT INTO producto (codigo, nombre, descripcion, existencia, precio,coste) Values ('" + codigo +
                            "','" + nombre + "','" + descripcion + "','" + existencia + "','" + precio_publico + "','" + coste + "')";

                        MySqlConnection conexionBD = Conexion.conexion();
                        conexionBD.Open();
                        try
                        {
                            MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                            comando.ExecuteNonQuery();
                            MessageBox.Show("Registro guardado");
                            limpiar();
                            cargarTabla(null, null, null, null);

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

        private void btnAgregarColumna_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("alter table " + txtTabla.Text + " add " + txtColumna.Text + " " + txtTipoDeDato.Text + "", conexionBD);
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

        private void btnEliminarTabla_Click(object sender, EventArgs e)
        {
            String cmdText = @"drop table `empresa`.`" + txtTabla.Text + "`";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmdText, conexionBD);
                cmd.Prepare();
                cmd.ExecuteNonQuery(); //execute the mysql command
                MessageBox.Show("Tabla eliminada");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error al borrar tabla: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            String nombre = txtNombre.Text;
            String descripcion = txtDescripcion.Text;
            double precio_publico = double.Parse(txtPrecio.Text);
            int existencias = int.Parse(txtExistencia.Text);
            double coste = double.Parse(txtCoste.Text);

            string sql = "UPDATE producto SET nombre='" + nombre + "', descripcion='" + descripcion +
                "', existencia='" + existencias + "', precio='" + precio_publico + "', coste='" + coste + "' WHERE codigo='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Modificado");
                limpiar();
                cargarTabla(null, null, null, null);

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

        private void gbProducto_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            String id = txtCodigo.Text;

            string sql = "DELETE FROM producto WHERE codigo= '" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
                cargarTabla(null, null, null, null);

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
    }
}
