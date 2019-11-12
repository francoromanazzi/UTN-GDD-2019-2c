using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Session;
using FrbaOfertas.Clases.Utils.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ComprarOferta : Form
    {
        private readonly Form previousForm;

        public ComprarOferta(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            LlenarTablaOfertas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);

        }

        private void dgvOfertas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(inputCantidadUnidades.Text == "")
            {
                MessageBoxUtil.ShowError("Ingrese la cantidad de unidades a comprar");
            }
            else if (!TextFieldUtil.IsDigitsOnly(inputCantidadUnidades.Text))
            {
                MessageBoxUtil.ShowError("La cantidad de unidades debe ser un numero natural");
            }
            else
            {
                if (MessageBox.Show("¿Desea comprar " + inputCantidadUnidades.Text + " unidades de " + dgvOfertas.CurrentRow.Cells["descripcion"].Value.ToString() + "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                        .AddParameter("@id_cliente_comprador", new RepositorioClientes().ObtenerIdClienteDeUsuario(Session.Instance.IdUsuario))
                        .AddParameter("@codigo_oferta", dgvOfertas.CurrentRow.Cells["codigo_oferta"].Value.ToString())
                        .AddParameter("@cant_unidades", Int32.Parse(inputCantidadUnidades.Text))
                        .AddParameter("@fecha", DateTime.Parse(ConfigurationManager.AppSettings["FechaSistema"]));

                    try
                    {
                        new Conexion().ExecDataTableStoredProcedure(StoredProcedures.ComprarOferta, inputParameters);

                        MessageBoxUtil.ShowInfo("Compra exitosa!");
                        this.LlenarTablaOfertas();
                    }
                    catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
                }

            }
        }

        private void LlenarTablaOfertas()
        {
            DataTable dt = new DataTable();
            try
            {
                StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                        .AddParameter("@target_date", DateTime.Parse(ConfigurationManager.AppSettings["FechaSistema"]));

                dt = new Conexion().ExecDataTableStoredProcedure(StoredProcedures.MostrarOfertasValidasParaUnaFecha, inputParameters);

                dgvOfertas.AllowUserToAddRows = false;
                dgvOfertas.ReadOnly = true;
                dgvOfertas.DataSource = dt;
                dgvOfertas.Columns[0].Visible = false;
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

    }
}
