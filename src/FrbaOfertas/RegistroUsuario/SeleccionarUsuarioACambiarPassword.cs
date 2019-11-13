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

namespace FrbaOfertas.RegistroUsuario
{
    public partial class SeleccionarUsuarioACambiarPassword : Form
    {
        private readonly Form previousForm;

        public SeleccionarUsuarioACambiarPassword(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void brnBuscar_Click(object sender, EventArgs e)
        {
            if (inputUsername.Text != "")
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
            else
            {
                MessageBoxUtil.ShowError("Ingrese un nombre de usuario");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells["id_usuario"].Value.ToString());
            bool habilitado = bool.Parse(dgvUsuarios.CurrentRow.Cells["habilitado"].Value.ToString());
            string username = dgvUsuarios.CurrentRow.Cells["username"].Value.ToString();

            if (MessageBox.Show("¿Desea modificar la contraseña del usuario " + username + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (!habilitado)
                {
                    MessageBoxUtil.ShowError("El usuario ya se encontraba deshabilitado");
                }
                else
                {
                    NavigableFormUtil.ForwardTo(this, new ModificarPasswordUsuario(idUsuario, this));
                }
            }
        }
    }
}
