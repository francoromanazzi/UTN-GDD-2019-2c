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
    public partial class AltaRol : Form
    {
        private readonly Form previousForm;

        public AltaRol(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            DataTable dt = new DataTable();
            try
            {
                dt = new Conexion().ExecDataTableSqlQuery("SELECT id_funcionalidad, descripcion FROM LOS_BORBOTONES.Funcionalidades");

                dgvFuncionalidades.AllowUserToAddRows = false;
                dgvFuncionalidades.ReadOnly = true;
                dgvFuncionalidades.DataSource = dt;
                dgvFuncionalidades.Columns[0].Visible = false;
            }
            catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (inputNombre.Text != "")
            {
                StoredProcedureParameters inputParameters = new StoredProcedureParameters()
                    .AddParameter("@nombre", inputNombre.Text);

                try
                {
                    int idRol = new Conexion().ExecSingleOutputStoredProcedure<int>(StoredProcedures.AltaRol, inputParameters, StoredProcedures.AltaRolOutput);

                    inputParameters.RemoveParameters();

                    foreach (DataGridViewRow c in dgvFuncionalidades.SelectedRows)
                    {
                        inputParameters.AddParameter("@id_rol", idRol);

                        Console.WriteLine("rol " +idRol);
                        
                        int id_funcionalidad = Int32.Parse(c.Cells["id_funcionalidad"].Value.ToString());
                        Console.WriteLine(id_funcionalidad);
                        inputParameters.AddParameter("@id_funcionalidad", id_funcionalidad);

                        new Conexion().ExecStoredProcedure(StoredProcedures.AgregarFuncionalidadRol, inputParameters);

                        inputParameters.RemoveParameters();
                    }

                    MessageBox.Show("Rol dado de alta correctamente!");
                    NavigableFormUtil.BackwardTo(this, previousForm);
                }
                catch (SqlException ex) { MessageBoxUtil.ShowError(ex.Message); }
            }
            else { MessageBoxUtil.ShowError("Por favor ingrese un nombre");
            }
        }
    }
}
