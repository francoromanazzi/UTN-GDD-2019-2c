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

namespace FrbaOfertas.RegistroUsuario
{
    public partial class RegistroAltaProveedor : Form
    {
        private const int ID_ROL_PROVEEDOR = 2;

        private readonly Form previousForm;
        private readonly string username;
        private readonly string password;

        public RegistroAltaProveedor(Form previousForm, string username, string password)
        {
            this.previousForm = previousForm;
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RegistroAltaProveedor newForm = new RegistroAltaProveedor(previousForm, username, password);
            newForm.Show();
            this.Dispose(false);
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(inputTelefono, inputPiso, inputCodigoPostal) ||
                !TextFieldUtil.CampoTextoValido(inputRubro, inputCiudad))
            {
                // Dentro del metodo esta el mensaje de error
            }
            else
            {
                if (CamposRequeridosNoVacios())
                {
                    Conexion con = new Conexion();

                    // Armo Procedimiento con los parametros de usuario y rol
                    StoredProcedureParameters parametrosUsuarioRol = new StoredProcedureParameters()
                        .AddParameter("@id_rol", ID_ROL_PROVEEDOR)
                        .AddParameter("@username", username);                               

                    // Armo el Store Procedure con los parametros REQUERIDOS
                    StoredProcedureParameters parametros = new StoredProcedureParameters()
                        .AddParameter("@username" , username)
                        .AddParameter("@password", password)
                        .AddParameter("@cant_intentos_fallidos", 0)
                        .AddParameter("@razon_social", inputRazonSocial.Text)
                        .AddParameter("@mail", inputMail.Text)
                        .AddParameter("@telefono", decimal.Parse(inputTelefono.Text))
                        .AddParameter("@direccion", inputDireccion.Text)
                        .AddParameter("@ciudad", inputCiudad.Text)
                        .AddParameter("@cuit", inputCuit.Text)
                        .AddParameter("@rubro", inputRubro.Text)
                        .AddParameter("@nombre_contacto", inputNombreDeContacto.Text);

                    // Ahora me fijo si completo los campos no requeridos y lo agrego en caso que si
                    // Piso
                    if (inputPiso.Text == "")
                    {
                        parametros.AddParameter("@piso", DBNull.Value); // Muy diferente de NULL 
                    }
                    else
                    {
                        parametros.AddParameter("@piso", inputPiso.Text);
                    }

                    // Dpto
                    if (inputDepartamento.Text == "")
                    {
                        parametros.AddParameter("@departamento", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@departamento", inputDepartamento.Text);
                    }

                    // Localidad
                    if (inputLocalidad.Text == "")
                    {
                     parametros.AddParameter("@localidad", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@localidad", inputLocalidad.Text);
                    }

                    // Codigo Postal
                    if (inputCodigoPostal.Text == "")
                    {
                        parametros.AddParameter("@codigo_postal", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@codigo_postal", inputCodigoPostal.Text);
                    }

                    try
                    {  
                        //Aca se guarda el usuario y sus datos propios de proveedor en la tabla proveedor
                        con.ExecStoredProcedure(StoredProcedures.AltaProveedorDesdeRegistroUsuario, parametros);
                        MessageBoxUtil.ShowInfo("Proveedor generado con exito");

                        //Agrego el rol del usuario tipo proveedor
                        con.ExecStoredProcedure(StoredProcedures.AgregarRolAlUsuario, parametrosUsuarioRol);
                        MessageBoxUtil.ShowInfo("Rol asignado con exito");
                        NavigableFormUtil.BackwardTo(this, previousForm);
                    }
                    catch (Exception ex)
                    {
                     MessageBoxUtil.ShowError(ex.Message);
                    }
                
                } //Cierro If campos requeridos no vacios
            } // Cierro else del if validaciones de campos
        } //Cierro metodo

        #region Validadores

        private bool CamposRequeridosNoVacios()
        {
            if (inputRazonSocial.Text == "" || inputTelefono.Text == "" || inputMail.Text == "" || inputDireccion.Text == ""
                || inputCuit.Text == "" || inputRubro.Text == "" || inputCiudad.Text == "" || inputNombreDeContacto.Text == "")
            {
                MessageBoxUtil.ShowError("Hay campos requeridos incompletos.");
                return false;
            }
            return true;
        }

        #endregion

        


    } //Cierro clase
}
