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

namespace FrbaOfertas.AbmProveedor
{
    public partial class ModificarProveedor : Form
    {
        private readonly Form previousForm;

        public ModificarProveedor(Form previousForm)
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
            if (AlMenosUnCampoNoVacio())
            {
                try
                {
                    DataTable dat = new RepositorioProveedores().RealizarBusqueda(inputRazonSocial.Text, inputCuit.Text, inputEmail.Text);
                    grillaProveedores.DataSource = dat;
                }
                catch (Exception ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }


        #region Validadores
        private bool AlMenosUnCampoNoVacio()
        {
            if (inputRazonSocial.Text == "" && inputCuit.Text == "" && inputEmail.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }
        #endregion

        private void grillaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mail = grillaProveedores.CurrentRow.Cells["mail"].Value.ToString();
            int idProveedor = int.Parse(grillaProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString());
            decimal telefono = decimal.Parse(grillaProveedores.CurrentRow.Cells["telefono"].Value.ToString());
            string cuit = grillaProveedores.CurrentRow.Cells["cuit"].Value.ToString();
            string direccion = grillaProveedores.CurrentRow.Cells["direccion"].Value.ToString();
            string piso = grillaProveedores.CurrentRow.Cells["piso"].Value.ToString();
            string dpto = grillaProveedores.CurrentRow.Cells["departamento"].Value.ToString();
            string localidad = grillaProveedores.CurrentRow.Cells["localidad"].Value.ToString();
            string ciudad = grillaProveedores.CurrentRow.Cells["ciudad"].Value.ToString();
            string codigoPostal = grillaProveedores.CurrentRow.Cells["codigo_postal"].Value.ToString();
            string razonSocial = grillaProveedores.CurrentRow.Cells["razon_social"].Value.ToString();
            string rubro = grillaProveedores.CurrentRow.Cells["rubro"].Value.ToString();
            string nombreContacto = grillaProveedores.CurrentRow.Cells["nombre_contacto"].Value.ToString();

            NavigableFormUtil.ForwardToDifferentWindow(this, new FormModificacion(this, idProveedor, mail, telefono, cuit, direccion, piso, dpto, localidad, ciudad, codigoPostal, razonSocial, rubro, nombreContacto));
        }

        public void RefrescarBusqueda()
        {
            this.brnBuscar_Click(null, null);
        }
    }
}
