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
using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.AbmCliente;
using FrbaOfertas.RegistroUsuario;

namespace FrbaOfertas.RegistroUsuario
{
    
    public partial class RegistroDeUsuario : Form
    {
        private readonly Form previusForm;

        public RegistroDeUsuario(Form previusForm)
        {
            this.previusForm = previusForm;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new RegistroDeUsuario(previusForm));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previusForm);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.validarUseryPass())
            {
                if (this.comboUserType.Text.Equals("Cliente"))
                {
                    NavigableFormUtil.ForwardTo(this, new RegistroAltaCliente(this,txtUserName.Text, txtUserPass.Text));
                    
                }
                else if (this.comboUserType.Text.Equals("Proveedor"))
                {
                    NavigableFormUtil.ForwardTo(this,new RegistroAltaProveedor(this,txtUserName.Text,txtUserPass.Text));
                }
            }
        }

       
        private bool validarUseryPass() // Paso 1
        {
            if (this.CamposRequeridosNoVacios())
            {
                if (this.verificarUsuario())
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        private bool CamposRequeridosNoVacios() //paso2
        {
            if (txtUserName.Text == "" || txtUserPass.Text == "")
            {
                MessageBoxUtil.ShowError("Hay campos requeridos incompletos.");
                return false;
            }
            return true;
        }

        private bool verificarUsuario() //paso3 Verifico si existe ese nombre de usuario
        {
            StoredProcedureParameters parametros = new StoredProcedureParameters()
                        .AddParameter("@username", txtUserName.Text);

            try
            {
                Conexion conexion = new Conexion();
                conexion.ExecDataTableStoredProcedure(StoredProcedures.VerificarUsername, parametros);
                MessageBoxUtil.ShowInfo("Nombre de usuario valido");
                return true;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
                return false;
            }
        }

        

        
      
    }
}
