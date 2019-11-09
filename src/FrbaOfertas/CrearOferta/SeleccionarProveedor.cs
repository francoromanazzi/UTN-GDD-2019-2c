using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Utils.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class SeleccionarProveedor : Form
    {
        private readonly Form previousForm;

        public SeleccionarProveedor(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (inputMail.Text == "" && inputCuit.Text == "" && inputRazonSocial.Text == "")
            {
                MessageBoxUtil.ShowError("Se debe introducir por lo menos un dato");
            }
            else
            {
                try
                {
                    DataTable dt = new RepositorioProveedores().RealizarBusqueda(inputRazonSocial.Text, inputCuit.Text, inputMail.Text);

                    gridProveedores.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }

        private void gridProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProveedor = Int32.Parse(gridProveedores.CurrentRow.Cells[0].Value.ToString());

            Console.WriteLine(idProveedor);

            NavigableFormUtil.ForwardTo(this, new CrearOfertaPaso2(previousForm, idProveedor));
        }
    }
}
