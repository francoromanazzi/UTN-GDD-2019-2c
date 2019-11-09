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

// Librerias propias
using FrbaOfertas.Clases.Utils.Form;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Constantes;


namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private readonly AbmCliente previousForm;

        public AltaCliente(AbmCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        // Limpiar pantalla
        private void limpiar_Click(object sender, EventArgs e)
        {
            AltaCliente newForm = new AltaCliente(previousForm);
            newForm.Show();
            this.Dispose(false);
        }

        // Volver atras
        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
    
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(DNI, Piso, CodigoPostal) ||
                !TextFieldUtil.CampoTextoValido(Nombre, Apellido, Direccion, Localidad))
            {
                // Dentro del metodo esta el mensaje de error
            }
            else
            {
                if (CamposRequeridosNoVacios())
                {
                    Conexion con = new Conexion();
                    // Crear el usuario
                    string username = DNI.Text;
                    string password = DNI.Text;
                    StoredProcedureParameters userParametros = new StoredProcedureParameters()
                        .AddParameter("@username", username)
                        .AddParameter("@password", password)
                        .AddParameter("@cant_intentos_fallidos", 0);
                    con.ExecDataTableStoredProcedure(StoredProcedures.AltaUsuario, userParametros);


                    // Armo el Store Procedure con los parametros REQUERIDOS
                    StoredProcedureParameters parametros = new StoredProcedureParameters()
                        .AddParameter("@nombre", Nombre.Text)
                        .AddParameter("@apellido", Apellido.Text)
                        .AddParameter("@dni", double.Parse(DNI.Text))
                        .AddParameter("@mail", Email.Text)
                        .AddParameter("@telefono", double.Parse(Telefono.Text))
                        .AddParameter("@direccion", Direccion.Text)
                        .AddParameter("@fecha_nacimiento", DateTime.Parse(FechaDeNacimiento.Text))
                        .AddParameter("@username", username)
                        .AddParameter("@password", password);
                    // Ahora me fijo si completo los campos no requeridos y lo agrego en caso que si
                    // Piso
                    if (Piso.Text == "")
                    {
                        parametros.AddParameter("@piso", DBNull.Value); // Muy diferente de NULL 
                    }
                    else
                    {
                        parametros.AddParameter("@piso", decimal.Parse(Piso.Text));
                    }
                    // Dpto
                    if (Departamento.Text == "")
                    {
                        parametros.AddParameter("@departamento", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@departamento", Departamento.Text);
                    }
                    // Localidad
                    if (Localidad.Text == "")
                    {
                        parametros.AddParameter("@localidad", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@localidad", Localidad.Text);
                    }
                    // Codigo Postal
                    if (CodigoPostal.Text == "")
                    {
                        parametros.AddParameter("@codigo_postal", DBNull.Value);
                    }
                    else
                    {
                        parametros.AddParameter("@codigo_postal", decimal.Parse(CodigoPostal.Text));
                    }

                    // TENGO QUE VERIFICAR LO DE CLIENTES GEMELOS

                    try
                    {
                        // Impacto en la base
                        con.ExecDataTableStoredProcedure(StoredProcedures.AltaCliente, parametros);
                        MessageBoxUtil.ShowInfo("Cliente generado con exito");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        #region Validadores

        private bool CamposRequeridosNoVacios()
        {
            if (Nombre.Text == "" || Apellido.Text == "" || DNI.Text == "" || FechaDeNacimiento.Text == ""
                || Email.Text == "" || Telefono.Text == "" || Direccion.Text == "")
            {
                MessageBoxUtil.ShowError("Hay campos requeridos incompletos.");
                return false;
            }
            return true;
        }

        #endregion
    }
}
