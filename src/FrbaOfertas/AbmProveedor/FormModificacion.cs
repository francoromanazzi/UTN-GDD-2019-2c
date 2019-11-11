using FrbaOfertas.Clases.Database;
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
    public partial class FormModificacion : Form
    {
        private readonly ModificarProveedor previousForm;
        private readonly int idProveedor;

        public FormModificacion(ModificarProveedor previousForm, int idProveedor, string mail, decimal telefono, string cuit, string direccion, 
            string piso, string dpto, string localidad, string ciudad, string codigoPostal, 
            string razonSocial, string rubro, string nombreContacto
        )
        {
            this.previousForm = previousForm;
            this.idProveedor = idProveedor;

            InitializeComponent();

            inputEmail.Text = mail;
            inputTelefono.Text = telefono.ToString();
            inputCuit.Text = cuit;
            inputDireccion.Text = direccion;
            inputPiso.Text = piso;
            inputDepartamento.Text = dpto;
            inputLocalidad.Text = localidad;
            inputCiudad.Text = ciudad;
            inputCodigoPostal.Text = codigoPostal;
            inputRazonSocial.Text = razonSocial;
            inputRubro.Text = rubro;
            inputNombreContacto.Text = nombreContacto;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (CamposRequeridosNoVacios())
            {
                try
                {
                    new RepositorioProveedores().Modificar(
                        idProveedor,
                        checkboxHabilitado.Checked,
                        inputRazonSocial.Text,
                        inputTelefono.Text,
                        inputEmail.Text,
                        inputDireccion.Text,
                        inputPiso.Text,
                        inputDepartamento.Text,
                        inputLocalidad.Text,
                        inputCodigoPostal.Text,
                        inputCuit.Text,
                        inputCiudad.Text,
                        inputRubro.Text,
                        inputNombreContacto.Text
                        );

                    previousForm.RefrescarBusqueda();
                    MessageBoxUtil.ShowInfo("Proveedor modificado con exito");
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
            if (inputRazonSocial.Text == "" || inputTelefono.Text == "" || inputDireccion.Text == ""
                || inputCuit.Text == "" || inputRubro.Text == "" || inputCiudad.Text == "" || inputNombreContacto.Text == "")
            {
                MessageBoxUtil.ShowError("Hay campos requeridos incompletos.");
                return false;
            }
            return true;
        }

        #endregion

        private void FormModificacion_Load(object sender, EventArgs e)
        {
            int id_usuario = new Conexion().ExecSingleOutputSqlQuery<int>("SELECT id_usuario FROM LOS_BORBOTONES.Proveedores WHERE id_proveedor = " + idProveedor);
            bool habilitado = new Conexion().ExecSingleOutputSqlQuery<bool>("SELECT habilitado FROM LOS_BORBOTONES.Usuarios WHERE id_usuario = " + id_usuario);
            if (habilitado)
                checkboxHabilitado.Checked = true;
            else
                checkboxHabilitado.Checked = false;

        }

    }
}
