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
using FrbaOfertas.Clases.Utils.Form;
using FrbaOfertas.Clases.Repositorios;

namespace FrbaOfertas.AbmCliente
{
    public partial class ModificarCliente : Form
    {
        private readonly AbmCliente previousForm;

        public ModificarCliente(AbmCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(DNI) || !TextFieldUtil.CampoTextoValido(Nombre, Apellido))
            {
                // No hacer nada. El msj de error esta dentro de las funciones
            }
            else
            {
                if (AlMenosUnCampoNoVacio())
                {
                    try 
                    {
                        DataTable dat = new RepositorioClientes().BuscarCliente(Nombre.Text, Apellido.Text, DNI.Text, Email.Text);
                        grillaClientes.DataSource = dat;
                        grillaClientes.Columns["id_cliente"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = grillaClientes.CurrentRow.Cells[0].Value.ToString();
            string apellido = grillaClientes.CurrentRow.Cells[1].Value.ToString();
            string dni = grillaClientes.CurrentRow.Cells[2].Value.ToString();
            string mail = grillaClientes.CurrentRow.Cells[3].Value.ToString();
            string telefono = grillaClientes.CurrentRow.Cells[4].Value.ToString();
            string direccion = grillaClientes.CurrentRow.Cells[5].Value.ToString();
            string piso = grillaClientes.CurrentRow.Cells[6].Value.ToString();
            string dpto = grillaClientes.CurrentRow.Cells[7].Value.ToString();
            string localidad = grillaClientes.CurrentRow.Cells[8].Value.ToString();
            string codigoPostal = grillaClientes.CurrentRow.Cells[9].Value.ToString();
            DateTime fechaNac = DateTime.Parse(grillaClientes.CurrentRow.Cells[10].Value.ToString());
            NavigableFormUtil.ForwardToDifferentWindow(this, new FormModificacion(this, nombre, apellido, dni, mail, telefono, direccion, piso, dpto, localidad, codigoPostal, fechaNac));
        }

        #region Validadores
        private bool AlMenosUnCampoNoVacio()
        {
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "" && Email.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }
        #endregion

        public void RefrescarBusqueda()
        {
            this.buscar_Click(null, null);
        }
    }
}
