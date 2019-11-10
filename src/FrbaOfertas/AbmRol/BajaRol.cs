using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
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

namespace FrbaOfertas.AbmRol
{
    public partial class BajaRol : Form
    {
        private readonly Form previousForm;

        public BajaRol(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            this.LlenarGrilla();
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idRol = int.Parse(dgvRoles.CurrentRow.Cells["id_rol"].Value.ToString());
            string nombre = dgvRoles.CurrentRow.Cells["nombre"].Value.ToString();
            bool habilitado = bool.Parse(dgvRoles.CurrentRow.Cells["habilitado"].Value.ToString());

            if (!habilitado)
            {
                MessageBoxUtil.ShowError("El rol ya se encuentra deshabilitado");
            }
            else
            {
                if (MessageBox.Show("¿Desea deshabilitar el rol " + nombre + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    StoredProcedureParameters param = new StoredProcedureParameters()
                                .AddParameter("@id_rol", idRol);

                    try
                    {
                        new Conexion().ExecDataTableStoredProcedure(StoredProcedures.BajaRol, param);
                        MessageBoxUtil.ShowInfo("Rol deshabilitado exitosamente");
                        this.LlenarGrilla();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }

                }
            }
        }

        private void LlenarGrilla()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = new Conexion().ExecDataTableSqlQuery("SELECT id_rol, nombre, habilitado FROM LOS_BORBOTONES.Roles");

                dgvRoles.AllowUserToAddRows = false;
                dgvRoles.ReadOnly = true;
                dgvRoles.DataSource = dt;
                dgvRoles.Columns[0].Visible = false;
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
    }
}
