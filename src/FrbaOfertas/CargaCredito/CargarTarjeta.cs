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

namespace FrbaOfertas.CargaCredito
{
    public partial class CargarTarjeta : Form
    {
        private readonly CargaCredito previousForm;

        public CargarTarjeta(CargaCredito previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarInputs())
            {
                try
                {
                    new RepositorioTarjetas().Guardar(cmbTipoTarjeta.Text, inputCodigo.Text);

                    previousForm.VolverACargarTarjetas();
                    NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
                }
                catch (SqlException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
          }
        }

        private Boolean ValidarInputs()
        {
            string errores = "";

            // Validacion tipo tarjeta
            if (cmbTipoTarjeta.SelectedItem == null)
            {
                errores += "El tipo de tarjeta es obligatorio\n";
            }

            // Validacion código tarjeta
            if (inputCodigo.Text == "")
            {
                errores += "El código de tarjeta es obligatorio\n";
            }

            if (errores != "")
            {
                MessageBoxUtil.ShowError(errores);
                return false;
            }
            else
                return true;
        }
    }
}
