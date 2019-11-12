using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Session;
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

namespace FrbaOfertas.EntregarOferta
{
    public partial class EntregarOferta : Form
    {
        private readonly Form previousForm;

        public EntregarOferta(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            LlenarTablaOfertas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LlenarTablaOfertas()
        {
            DataTable dt = new DataTable();
            try
            {
                StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                        .AddParameter("@id_proveedor", new RepositorioProveedores().ObtenerIdProveedorDeUsuario(Session.Instance.IdUsuario));

                dt = new Conexion().ExecDataTableStoredProcedure(StoredProcedures.MostrarComprasCanjeablesDelProveedor, inputParameters);

                dgvCompras.AllowUserToAddRows = false;
                dgvCompras.ReadOnly = true;
                dgvCompras.DataSource = dt;
                dgvCompras.Columns[1].Visible = false;
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

    }
}
