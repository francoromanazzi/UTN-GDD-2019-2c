using FrbaOfertas.Clases.Repositorios;
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

namespace FrbaOfertas.AbmProveedor
{
    public partial class AltaProveedor : Form
    {
        private readonly Form previousForm;

        public AltaProveedor(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            AltaProveedor newForm = new AltaProveedor(previousForm);
            newForm.Show();
            this.Dispose(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
                if (CamposRequeridosNoVacios())
                {
                    try
                    {
                        new RepositorioProveedores().Guardar(
                            inputRazonSocial.Text,
                            inputTelefono.Text,
                            inputMail.Text,
                            inputDireccion.Text,
                            inputPiso.Text,
                            inputDepartamento.Text,
                            inputLocalidad.Text,
                            inputCodigoPostal.Text,
                            inputCuit.Text,
                            inputCiudad.Text,
                            inputRubro.Text,
                            inputNombreDeContacto.Text
                            );

                        MessageBoxUtil.ShowInfo("Proveedor generado con exito");
                    }
                    catch (SqlException ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                
            }
        }


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
    }
}
