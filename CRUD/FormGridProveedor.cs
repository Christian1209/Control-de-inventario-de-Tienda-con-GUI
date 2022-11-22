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
    public partial class FormGridProveedor : Form
    {
        public FormGridProveedor()
        {
            InitializeComponent();
        }

        private void cargarConsulta(string columnas, bool col1, bool col2, bool col3, bool col4, bool calculada)
        {
            List<proveedor> lista = new List<proveedor>();
            ctrlproveedor _ctrlProveedor = new ctrlproveedor();
            dtaGridProveedor.DataSource = _ctrlProveedor.consultabasica(columnas, col1, col2, col3, col4, calculada);
            dtaGridProveedor.Visible = true;
        }

        private void ocultaColumnas()
        {
            dtaGridProveedor.Columns["Codigo"].Visible = false;
            dtaGridProveedor.Columns["Marca"].Visible = false;
            dtaGridProveedor.Columns["Producto"].Visible = false;
            dtaGridProveedor.Columns["Numero_Tel"].Visible = false;
        }


        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string columna1 = "";
            string columna2 = "";
            string columna3 = "";
            string columna4 = "";
            bool col1 = false, col2 = false, col3 = false, col4 = false;
            ocultaColumnas();

            //este contador es para saber cuantas columnas quiere ver el usuario y asi saber cuantas debo mostrar.
            if (cbConsulta1.Checked)
            {
                dtaGridProveedor.Columns["Codigo"].Visible = true;
                col1 = true;
                columna1 = cbConsulta1.Text;
                if (cbConsulta2.Checked || cbConsulta3.Checked || cbConsulta4.Checked)
                    columna1 += ",";
                //valido si hay mas cb chekeados para entonces ponerle una coma a mi string.
            }
            if (cbConsulta2.Checked)
            {

                dtaGridProveedor.Columns["Marca"].Visible = true;
                col2 = true;
                columna2 = cbConsulta2.Text;
                if (cbConsulta3.Checked || cbConsulta4.Checked)
                    columna2 += ",";

            }
            if (cbConsulta3.Checked)
            {
                dtaGridProveedor.Columns["Producto"].Visible = true;
                col3 = true;
                columna3 = cbConsulta3.Text;
                if (cbConsulta4.Checked)
                    columna3 += ",";
            }
            if (cbConsulta4.Checked)
            {
                dtaGridProveedor.Columns["Numero_tel"].Visible = true;
                col4 = true;
                columna4 = cbConsulta4.Text;
            }
            //
            bool calculado = false;
            string columnas = columna1 + columna2 + columna3 + columna4;
            cargarConsulta(columnas, col1, col2, col3, col4, calculado);

        }
    }
}
