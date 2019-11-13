using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaOfertas.Clases.Utils.Form;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Login;
using FrbaOfertas.Clases.Session;
using FrbaOfertas.Clases.Constantes;

namespace FrbaOfertas.RegistroUsuario
{
    public partial class ModificarPasswordUsuario : Form
    {
        private int idUsuarioAModificar;
        private Form formInvocante;

        public ModificarPasswordUsuario(int usuarioAModificar, Form callerForm)
        {
            InitializeComponent();
            this.idUsuarioAModificar = usuarioAModificar;
            this.formInvocante = callerForm;
        }

        public ModificarPasswordUsuario(Form callerForm)
        {
            InitializeComponent();
            this.idUsuarioAModificar = Session.Instance.IdUsuario;
            this.formInvocante = callerForm;
        }

        private void btnModificarPassword_Click(object sender, EventArgs e)
        {
            if (this.ValidarPasswordNoVacio())
            {
                if (this.ValidarPasswordNuevo())
                {
                    this.CambiarPassword(idUsuarioAModificar, txtNuevoPassword.Text);
                    MessageBoxUtil.ShowInfo("Contraseña modificada correctamente. Acceda nuevamente.");
                    NavigableFormUtil.BackwardTo(this, new Login.Login());
                }
            }
        }

        public void CambiarPassword(int idUsuario, string newPassword)
        {
            Conexion con = new Conexion();

            StoredProcedureParameters parametrosUsuarioACambiarPass = new StoredProcedureParameters()
                .AddParameter("@id_usuario", idUsuario)
                .AddParameter("@password", newPassword);

            try
            {
                //Impacto en la base
                con.ExecStoredProcedure(StoredProcedures.CambiarPasswordUsuario, parametrosUsuarioACambiarPass);      
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
      
        }


        #region Auxiliary methods
        private Boolean ValidarPasswordNoVacio()
        {
            if (txtNuevoPassword.Text == "" || txtConfirmarPassword.Text == "")
            {
                MessageBoxUtil.ShowError("Las contraseñas ingresadas no coinciden.");
                return false;
            }
            return true;
        }

        private Boolean ValidarPasswordNuevo()
        {
            if (!txtNuevoPassword.Text.Equals(txtConfirmarPassword.Text))
            {
                MessageBoxUtil.ShowError("Las contraseñas ingresadas no coinciden.");
                return false;
            }
            return true;

        }
        #endregion

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, formInvocante);
        }


    }
}
