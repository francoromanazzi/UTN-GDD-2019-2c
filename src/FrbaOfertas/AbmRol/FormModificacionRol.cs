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
    public partial class FormModificacionRol : Form
    {
        private readonly ModificarRol previousForm;
        private readonly int idRol;

        public FormModificacionRol(ModificarRol previousForm, int idRol, string nombre, bool habilitado)
        {
            this.previousForm = previousForm;
            this.idRol = idRol;

            InitializeComponent();

            inputNombre.Text = nombre;
            checkBoxHabilitado.Checked = habilitado;

            this.LlenarAmbasGrillas();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameters inputParameters = new StoredProcedureParameters();

            try
            {
                foreach (DataGridViewRow row in dgvFunsDisponibles.SelectedRows)
                {
                    int idFuncionalidad = Int32.Parse(row.Cells["id_funcionalidad"].Value.ToString());

                    inputParameters.AddParameter("@id_rol", idRol);
                    inputParameters.AddParameter("@id_funcionalidad", idFuncionalidad);

                    new Conexion().ExecStoredProcedure(StoredProcedures.AgregarFuncionalidadRol, inputParameters);

                    inputParameters.RemoveParameters();
                }

                LlenarAmbasGrillas();
                MessageBoxUtil.ShowInfo("Funcionalidades agregadas al rol correctamente");
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameters inputParameters = new StoredProcedureParameters();

            try
            {
                foreach (DataGridViewRow row in dgvFunsActuales.SelectedRows)
                {
                    int idFuncionalidad = Int32.Parse(row.Cells["id_funcionalidad"].Value.ToString());

                    inputParameters.AddParameter("@id_rol", idRol);
                    inputParameters.AddParameter("@id_funcionalidad", idFuncionalidad);

                    new Conexion().ExecStoredProcedure(StoredProcedures.QuitarFuncionalidadRol, inputParameters);

                    inputParameters.RemoveParameters();
                }

                LlenarAmbasGrillas();
                MessageBoxUtil.ShowInfo("Funcionalidades quitadas del rol correctamente");
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

        public void LlenarAmbasGrillas()
        {
            DataTable dt1 = new Conexion().ExecDataTableSqlQuery("SELECT id_funcionalidad, descripcion FROM LOS_BORBOTONES.Funcionalidades WHERE id_funcionalidad NOT IN (SELECT id_funcionalidad FROM LOS_BORBOTONES.FuncionalidadesXRoles WHERE id_rol=" + + idRol + ")");
            dgvFunsDisponibles.DataSource = dt1;
            dgvFunsDisponibles.Columns[0].Visible = false;

            DataTable dt2 = new Conexion().ExecDataTableSqlQuery("SELECT id_funcionalidad, descripcion FROM LOS_BORBOTONES.Funcionalidades WHERE id_funcionalidad IN (SELECT id_funcionalidad FROM LOS_BORBOTONES.FuncionalidadesXRoles WHERE id_rol=" + idRol + ")");
            dgvFunsActuales.DataSource = dt2;
            dgvFunsActuales.Columns[0].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                .AddParameter("id_rol", idRol)
                .AddParameter("nombre", inputNombre.Text)
                .AddParameter("habilitado", checkBoxHabilitado.Checked);

            try
            {
                new Conexion().ExecStoredProcedure(StoredProcedures.ModificarRol, inputParameters);
                MessageBoxUtil.ShowInfo("Rol modificado correctamente");
                previousForm.LlenarGrilla();
                NavigableFormUtil.BackwardTo(this, previousForm);
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }
    }
}
