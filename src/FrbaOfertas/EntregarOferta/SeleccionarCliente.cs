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

namespace FrbaOfertas.EntregarOferta
{
    public partial class SeleccionarCliente : Form
    {

        private readonly EntregarOferta previousForm;
        private readonly int idCompra;

        public SeleccionarCliente(EntregarOferta previousForm, int idCompra)
        {
            this.previousForm = previousForm;
            this.idCompra = idCompra;

            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(DNI) || !TextFieldUtil.CampoTextoValido(Nombre, Apellido))
            {
                // No hacer nada. El msj de error esta dentro de las funciones
            }
            else
            {
                if (AlMenosUnCampoNoVacio())
                {
                    try
                    {
                        DataTable dat = new RepositorioClientes().BuscarCliente(Nombre.Text, Apellido.Text, DNI.Text, Email.Text);
                        dgvClientes.DataSource = dat;
                        dgvClientes.Columns["id_cliente"].Visible = false;
                    }
                    catch (SqlException ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string apellido = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            int idCliente = Int32.Parse(dgvClientes.CurrentRow.Cells["id_cliente"].Value.ToString());
            string DNI = dgvClientes.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show("¿Desea canjear la oferta para el cliente " + nombre + " " + apellido + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StoredProcedureParameters param = new StoredProcedureParameters()
                    .AddParameter("@id_proveedor", new RepositorioProveedores().ObtenerIdProveedorDeUsuario(Session.Instance.IdUsuario))
                    .AddParameter("@id_cliente", idCliente)
                    .AddParameter("@fecha_actual", DateTime.Parse(ConfigurationManager.AppSettings["FechaSistema"]))
                    .AddParameter("@id_compra", idCompra);

                try
                {
                    new Conexion().ExecDataTableStoredProcedure(StoredProcedures.CanjearCompra, param);
                    MessageBoxUtil.ShowInfo("Compra canjeada exitosamente");
                    previousForm.LlenarTablaOfertas();
                    NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
                }
                catch (Exception ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }           
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
        }

        #region Validadores
        private bool AlMenosUnCampoNoVacio()
        {
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "" && Email.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }
        #endregion

    }
}
