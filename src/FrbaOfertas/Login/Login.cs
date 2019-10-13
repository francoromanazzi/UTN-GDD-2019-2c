using FrbaOfertas.Clases.Exceptions;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Session;
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

namespace FrbaOfertas.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();

            try
            {
                repositorioUsuarios.ExisteUsernameYPassword(inputUsername.Text, inputPassword.Text);

                Session.Instance.OpenSession(inputUsername.Text);

                //Rol userRol = rolRepository.IdRolDeUsuario(txtUsername.Text);
                //NavigableFormUtil.ForwardTo(this, new SeleccionarFuncionalidadForm(this, userRol));
            }
            catch (StoredProcedureException ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
        }
    }
}
