using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Utils.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.DeshabilitarUsuario
{
    public partial class DeshabilitarUsuario : Form
    {
        private readonly Form previousForm;

        public DeshabilitarUsuario(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void brnBuscar_Click(object sender, EventArgs e)
        {
            if (inputUsername.Text != "")
            {
                this.LlenarTablaUsuarios();
            }
            else
            {
                MessageBoxUtil.ShowError("Ingrese un nombre de usuario");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value.ToString());
            bool habilitado = bool.Parse(dgvUsuarios.CurrentRow.Cells["habilitado"].Value.ToString());
            string username = dgvUsuarios.CurrentRow.Cells["username"].Value.ToString();

            if (MessageBox.Show("¿Desea deshabilitar al usuario " + username + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (!habilitado)
                {
                    MessageBoxUtil.ShowError("El usuario ya se encontraba deshabilitado");
                }
                else
                {
                    StoredProcedureParameters param = new StoredProcedureParameters()
                                .AddParameter("@idUsuario", idUsuario);

                    try
                    {
                        new Conexion().ExecDataTableStoredProcedure(StoredProcedures.EliminarUsuario, param);
                        MessageBoxUtil.ShowInfo("Usuario deshabilitado exitosamente");
                        this.LlenarTablaUsuarios();
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }

            }
        }

        private void LlenarTablaUsuarios()
        {
            try
            {
                DataTable dat = new RepositorioUsuarios().RealizarBusqueda(inputUsername.Text);
                dgvUsuarios.DataSource = dat;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }

        }
    }
}
