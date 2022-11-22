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
    public partial class FormGridProducto : Form
    {
        /*
        cobConBaCol.Items.Add("Existencia");
            cobConBaCol.Items.Add("Precio");
            cobConBaOp.Items.Add("*");
            cobConBaOp.Items.Add("-");
            cobConBaOp.Items.Add("/");
            cobConBaOp.Items.Add("+");
        */
        public FormGridProducto()
        {
            InitializeComponent();
        }
        private void cargarTabla(string clausula1, string columna2, string clausula2, string columna3)
        {
            List<producto> lista = new List<producto>();
            ctrlproductos _ctrlProductos = new ctrlproductos();
            dtagridProducto.DataSource = _ctrlProductos.consulta(clausula1, columna2, clausula2, columna3);
            dtagridProducto.Visible = true;
        }

        private void cargarConsulta(string columnas, bool col1, bool col2, bool col3, bool col4, bool col5,bool col6, bool calculada)
        {
            List<producto> lista = new List<producto>();
            ctrlproductos _ctrlProductos = new ctrlproductos();
            dtagridProducto.DataSource = _ctrlProductos.consultabasica(columnas, col1, col2, col3, col4, col5,col6, calculada);
            dtagridProducto.Visible = true;
        }


        private void ocultaColumnas()
        {
            dtagridProducto.Columns["Codigopro"].Visible = false;
            dtagridProducto.Columns["Nombrepro"].Visible = false;
            dtagridProducto.Columns["DescripcionPro"].Visible = false;
            dtagridProducto.Columns["PrecioPro"].Visible = false;
            dtagridProducto.Columns["ExistenciaPro"].Visible = false;
            dtagridProducto.Columns["CostePro"].Visible = false;
            dtagridProducto.Columns["calculadoPro"].Visible = false;
        }

        private void FormGridProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click_1(object sender, EventArgs e)
        {
            string columna1 = "";
            string columna2 = "";
            string columna3 = "";
            string columna4 = "";
            string columna5 = "";
            string columna6 = "";
            bool col1 = false, col2 = false, col3 = false, col4 = false, col5 = false, col6 = false;
            ocultaColumnas();

            //este contador es para saber cuantas columnas quiere ver el usuario y asi saber cuantas debo mostrar.
            if (cbConsulta1.Checked)
            {
                dtagridProducto.Columns["Codigopro"].Visible = true;
                col1 = true;
                columna1 = cbConsulta1.Text;
                if (cbConsulta2.Checked || cbConsulta3.Checked || cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna1 += ",";
                //valido si hay mas cb chekeados para entonces ponerle una coma a mi string.
            }
            if (cbConsulta2.Checked)
            {

                dtagridProducto.Columns["Nombrepro"].Visible = true;
                col2 = true;
                columna2 = cbConsulta2.Text;
                if (cbConsulta3.Checked || cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna2 += ",";

            }
            if (cbConsulta3.Checked)
            {
                dtagridProducto.Columns["DescripcionPro"].Visible = true;
                col3 = true;
                columna3 = cbConsulta3.Text;
                if (cbConsulta4.Checked || cbConsulta5.Checked || cbConsulta6.Checked)
                    columna3 += ",";
            }
            if (cbConsulta4.Checked)
            {
                dtagridProducto.Columns["PrecioPro"].Visible = true;
                col4 = true;
                columna4 = cbConsulta4.Text;
                if (cbConsulta5.Checked || cbConsulta6.Checked)
                    columna4 += ",";
            }
            //
            if (cbConsulta5.Checked)
            {
                dtagridProducto.Columns["ExistenciaPro"].Visible = true;
                col5 = true;
                columna5 = cbConsulta5.Text;
                if (cbConsulta6.Checked)
                    columna5 += ",";

            }
            if (cbConsulta6.Checked)
            {
                dtagridProducto.Columns["CostePro"].Visible =true;
                col6 = true;
                columna6 = cbConsulta6.Text;
            }
            bool calculado = false;
            string columnas = columna1 + columna2 + columna3 + columna4 + columna5 + columna6;
            cargarConsulta(columnas, col1, col2, col3, col4, col5,col6, calculado);

        }

        private void dtagridProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
