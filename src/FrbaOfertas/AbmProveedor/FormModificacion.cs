using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class FormModificacion : Form
    {
        private readonly Form previousForm;

        public FormModificacion(Form previousForm, string mail, decimal telefono, string cuit, string direccion, 
            string piso, string dpto, string localidad, string ciudad, string codigoPostal, 
            string razonSocial, string rubro, string nombreContacto
        )
        {
            this.previousForm = previousForm;

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
    }
}
