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
using System.Runtime.InteropServices;


namespace CRUD
{
    public partial class Form1 : Form
    {
        double precio = 0;
        int cantidad = 0;
        int total = 0;
        int existenciaPrevia = 0;

        int totalprov = 0;
        public Form1()
        {
            InitializeComponent();
            /*
            comboAccion.Items.Add("Consulta Basica");
            comboAccion.Items.Add("Campos Calculados");
            */
        }

        string contraseña = "123456";
        bool correcta = false;
        string id = "";

        private void txtPrecioPublico_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbCamposCaculados_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            btnRestaurar.Visible=false;
            btnMaximizar.Visible=true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void conToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void verTodosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new FormGridProducto();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }

        }

        private void darDeAltaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new FormProducto();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new FormCliente();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }

        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new FormGridCliente();
            formulario.Show();

        }

        private void verProductosDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form formulario = new FormGridProveedor();
                formulario.Show();

        }

        private void editarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(correcta == true)
            {
                Form formulario = new FormProveedor();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (contraseña == txtContraseña.Text)
            {
                MessageBox.Show("Contraseña Correcta");
                correcta = true;
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;
                btnAceptar.Visible = false;
            }
            else
            {
                correcta = false;
                MessageBox.Show("contraseña incorrecta intenta de nuevo!");
                txtContraseña.Text = "";
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new FormVentas();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }
        }

        private void ingresosDeMercanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new FormAltas();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }
        }

        private void btnVentaBuscarNombre_Click(object sender, EventArgs e)
        {
            String codigo = txtVentaNombre.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT codigo, precio, existencia FROM producto WHERE nombre LIKE '"
                + txtVentaNombre.Text + "'LIMIT 1";
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
                        txtVentaID.Text = reader.GetString(0);
                        lblVentaPrecio.Text = reader.GetString(1);
                        precio = double.Parse(reader.GetString(1));
                        existenciaPrevia = int.Parse(reader.GetString(2));
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

        }

        private void button7_Click(object sender, EventArgs e)
        {
            String codigo = txtVentaNombre.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT nombre, precio, existencia FROM producto WHERE codigo LIKE '"
                + txtVentaID.Text + "'LIMIT 1";
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
                        txtVentaNombre.Text = reader.GetString(0);
                        lblVentaPrecio.Text = reader.GetString(1);
                        precio = double.Parse(reader.GetString(1));
                        existenciaPrevia = int.Parse(reader.GetString(2));
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

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            double subtotal;
            subtotal = precio * int.Parse(txtVentaCantidad.Text);
            lblSubtotal.Text = subtotal.ToString();
            txtVentaTotal.Text = (int.Parse(txtVentaTotal.Text) + subtotal).ToString();
            total = int.Parse(txtVentaTotal.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtVentaTotal.Text = total.ToString();
            int codigo = int.Parse(txtVentaID.Text);
            int existencia = int.Parse(txtVentaCantidad.Text);
            int final = existenciaPrevia - existencia;
            int aux = total;
            txtVentaTotal.Text = aux.ToString();

            string sql = "UPDATE producto SET existencia ='" + final + "' WHERE codigo ='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                txtVentaCantidad.Text = "";
                txtVentaID.Text = "";
                txtVentaNombre.Text = "";
                lblVentaPrecio.Text = "";

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

        private void actualizaExistencias(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtVentaID.Text);
            int existencia = int.Parse(txtVentaCantidad.Text);
            int final = existenciaPrevia + existencia;

            string sql = "UPDATE producto SET existencia ='" + final + "' WHERE codigo ='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                txtVentaCantidad.Text = "";
                txtVentaID.Text = "";
                txtVentaNombre.Text = "";

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

        private void button2_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtVentaID.Text);
            int existencia = int.Parse(txtVentaCantidad.Text);
            int final = existenciaPrevia - existencia;
            int aux = int.Parse(lblSubtotal.Text) + total;
            txtVentaTotal.Text = aux.ToString();

            string sql = "UPDATE producto SET existencia ='" + final + "' WHERE codigo ='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                txtVentaCantidad.Text = "";
                txtVentaID.Text = "";
                txtVentaNombre.Text = "";
                MessageBox.Show("Total a cobrar: " + txtVentaTotal.Text);
                txtVentaTotal.Text = "";
                lblSubtotal.Text = "";
                lblVentaPrecio.Text = "";
                total = 0;
                txtVentaTotal.Text = "";

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

        private void btnAltaBuscar_Click(object sender, EventArgs e)
        {
            String codigo = txtVentaNombre.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT codigo, precio, existencia FROM producto WHERE nombre LIKE '"
                + txtAltaNombre.Text + "'LIMIT 1";
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
                        txtAltaCodigo.Text = reader.GetString(0);
                        precio = double.Parse(reader.GetString(1));
                        existenciaPrevia = int.Parse(reader.GetString(2));
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

        }

        private void btnAltaBuscarCodigo_Click(object sender, EventArgs e)
        {
            String codigo = txtVentaNombre.Text;
            MySqlDataReader reader = null;
            string sql = "SELECT nombre, precio, existencia FROM producto WHERE codigo LIKE '"
                + txtAltaCodigo.Text + "'LIMIT 1";
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
                        txtAltaNombre.Text = reader.GetString(0);
                        precio = double.Parse(reader.GetString(1));
                        existenciaPrevia = int.Parse(reader.GetString(2));
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

        }

        private void btnAltaSeguir_Click(object sender, EventArgs e)
        {


            txtAltaTotal.Text = totalprov.ToString();
            int codigo = int.Parse(txtAltaCodigo.Text);
            int existencia = int.Parse(txtAltaCantidad.Text);
            int final = existenciaPrevia + existencia;
            int aux = int.Parse(lblAltaSubtotal.Text) + totalprov;
            totalprov = totalprov + int.Parse(lblAltaSubtotal.Text);
            txtAltaTotal.Text = aux.ToString();

            string sql = "UPDATE producto SET existencia ='" + final + "' WHERE codigo ='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                txtAltaCantidad.Text = "";
                txtAltaNombre.Text = "";
                txtAltaCodigo.Text = "";
 
                lblAltaSubtotal.Text = "";

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

        private void btnAltaCerrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtAltaCodigo.Text);
            int existencia = int.Parse(txtAltaCantidad.Text);
            int final = existenciaPrevia + existencia;
            int aux = int.Parse(lblAltaSubtotal.Text) + totalprov;
            txtAltaTotal.Text = aux.ToString();

            string sql = "UPDATE producto SET existencia ='" + final + "' WHERE codigo ='" + codigo + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                txtAltaCantidad.Text = "";
                txtAltaNombre.Text = "";
                txtAltaCodigo.Text = "";
                MessageBox.Show("Total a pagar a proveedor: " + txtAltaTotal.Text);
                txtAltaTotal.Text = "";
                totalprov = 0;
                lblAltaSubtotal.Text = "";

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

        private void txtAltaTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double subtotal;
            subtotal = precio * int.Parse(txtAltaCantidad.Text);
            lblAltaSubtotal.Text = subtotal.ToString();
            txtAltaTotal.Text = (int.Parse(txtAltaTotal.Text) + subtotal).ToString();
            total = int.Parse(txtAltaTotal.Text);
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (correcta == true)
            {
                Form formulario = new balance();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("Denegado");
            }

        }
    }

}
