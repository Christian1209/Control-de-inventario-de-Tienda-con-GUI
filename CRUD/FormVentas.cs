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
    public partial class FormVentas : Form
    {
        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            cargarConsulta(" ", true, true, true, true, true, true);
        }


        private void limpiar()
        {
            txtCodigo.Text = "";

        }


        private void cargarConsulta(string columnas, bool col1, bool col2, bool col3, bool col4, bool col5,bool col6)
        {
            List <Ventas> lista = new List<Ventas>();
            ctrlventas _ctrlventas = new ctrlventas();
            dtagridVenta.DataSource = _ctrlventas.consultabasica(columnas, col1, col2, col3, col4, col5,col6);
            dtagridVenta.Visible = true;
        }


        private void ocultaColumnas()
        {
            dtagridVenta.Columns["nCompra"].Visible = false;
            dtagridVenta.Columns["producto"].Visible = false;
            dtagridVenta.Columns["nombreProducto"].Visible = false;
            dtagridVenta.Columns["cantidad"].Visible = false;
            dtagridVenta.Columns["fecha"].Visible = false;
            dtagridVenta.Columns["total"].Visible = false;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            String id = txtCodigo.Text;

            string sql = "DELETE FROM venta WHERE N_compra = '" + id + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                limpiar();
                cargarConsulta("", true, true, true, true, true,true);

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

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string columna1 = "";
            string columna2 = "";
            string columna3 = "";
            string columna4 = "";
            string columna5 = "";
            string columna6 = "";

            bool col1 = false, col2 = false, col3 = false, col4 = false, col5 = false, col6=false;
            ocultaColumnas();
            //este contador es para saber cuantas columnas quiere ver el usuario y asi saber cuantas debo mostrar.
            if (cbConsulta1.Checked)
            {
                dtagridVenta.Columns["nCompra"].Visible = true;
                col1 = true;
                columna1 = cbConsulta1.Text;
                if (cbConsulta2.Checked || cbConsulta3.Checked || cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna1 += ",";
                //valido si hay mas cb chekeados para entonces ponerle una coma a mi string.
            }
            if (cbConsulta2.Checked)
            {

                dtagridVenta.Columns["producto"].Visible = true;
                col2 = true;
                columna2 = cbConsulta2.Text;
                if (cbConsulta3.Checked || cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna2 += ",";

            }
            if (cbConsulta3.Checked)
            {
                dtagridVenta.Columns["nombreProducto"].Visible = true;
                col3 = true;
                columna3 = cbConsulta3.Text;
                if (cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna3 += ",";
            }
            if (cbConsulta4.Checked)
            {
                dtagridVenta.Columns["cantidad"].Visible = true;
                col4 = true;
                columna4 = cbConsulta4.Text;
                if (cbConsulta5.Checked || cbConsulta5.Checked)
                    columna4 += ",";
            }
            //
            if (cbConsulta5.Checked )
            {
                dtagridVenta.Columns["fecha"].Visible = true;
                col5 = true;
                columna5 = cbConsulta5.Text;
                if (cbConsulta6.Checked)
                    columna5 += ",";

            }
            if (cbConsulta6.Checked)
            {
                dtagridVenta.Columns["total"].Visible = true;
                col6 = true;
                columna6 = cbConsulta6.Text;
            }
            string columnas = columna1 + columna2 + columna3 + columna4 + columna5 + columna6;
            cargarConsulta(columnas, col1, col2, col3, col4, col5,col6);
        }
    }
}
