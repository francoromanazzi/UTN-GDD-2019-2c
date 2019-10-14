using FrbaOfertas.Clases.Exceptions;
using FrbaOfertas.Clases.Modelo;
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
            Session.Instance.CloseSession();

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RepositorioUsuarios repositorioUsuarios = new RepositorioUsuarios();
            RepositorioRoles repositorioRoles = new RepositorioRoles();

            try
            {
                repositorioUsuarios.ExisteUsernameYPassword(inputUsername.Text, inputPassword.Text);

                Session.Instance.OpenSession(inputUsername.Text);

                IList<Rol> rolesUsuario = repositorioRoles.ObtenerRolesDeUsuario(inputUsername.Text);

                NavigableFormUtil.ForwardTo(this, new SeleccionarFuncionalidad.SeleccionarFuncionalidad(this, rolesUsuario));
            }
            catch (StoredProcedureException ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
        }
    }
}
