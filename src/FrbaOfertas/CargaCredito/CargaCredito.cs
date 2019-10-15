using FrbaOfertas.Clases.Modelo;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Session;
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
    public partial class CargaCredito : Form
    {
        private readonly Form previousForm;
        private readonly int idCliente;

        public CargaCredito(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            this.idCliente = new RepositorioClientes().ObtenerIdClienteDeUsuario(Session.Instance.IdUsuario);

            this.FillComboBoxTarjetas();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(this.ValidarInputs())
            {
                try
                {
                    int idTarjeta = cmbTarjeta.SelectedItem != null ? ((ComboBoxItem<int>) cmbTarjeta.SelectedItem).Value : -1;
                    new RepositorioCargas().Guardar(Int32.Parse(inputMonto.Text), cmbTipoPago.Text, idTarjeta);

                    MessageBoxUtil.ShowInfo("La carga fue exitosa");
                    NavigableFormUtil.BackwardTo(this, previousForm);
                }
                catch(SqlException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }

        private Boolean ValidarInputs()
        {
            string errores = "";

            // Validacion monto
            if (inputMonto.Text == "")
            {
                errores += "El monto es obligatorio\n";
            }
            else if (!TextFieldUtil.IsDigitsOnly(inputMonto.Text))
            {
                errores += "El monto debe ser un número entero positivo\n";
            }

            // Validacion tarjeta
            if (cmbTipoPago.SelectedItem == null)
            {
                errores += "El tipo de pago es obligatorio\n";
            }
            else if (cmbTipoPago.Text == "Efectivo" && cmbTarjeta.SelectedItem != null)
            {
                errores += "No seleccione una tarjeta si el pago es en efectivo\n";
            }
            else if ((cmbTipoPago.Text == "Débito" || cmbTipoPago.Text == "Crédito") && cmbTarjeta.SelectedItem == null)
            {
                errores += "Seleccione la tarjeta asociada al pago\n";
            }
            else if ((cmbTipoPago.Text == "Débito" || cmbTipoPago.Text == "Crédito") && !cmbTarjeta.Text.Contains(cmbTipoPago.Text))
            {
                errores += "El tipo de la tarjeta seleccionada no coincide con el indicado en el formulario\n"; 
            }

            if (errores != "")
            {
                MessageBoxUtil.ShowError(errores);
                return false;
            }
            else
                return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnCargarTarjeta_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardToDifferentWindow(this, new CargarTarjeta(this));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CargaCredito NewForm = new CargaCredito(previousForm);
            NewForm.Show();
            this.Dispose(false);
        }

        public void VolverACargarTarjetas()
        {
            cmbTarjeta.Items.Clear();

            this.FillComboBoxTarjetas();
        }

        private void FillComboBoxTarjetas()
        {
            ComboBoxFiller<Tarjeta, int>.Fill(cmbTarjeta)
                .KeyAs(tarjeta => tarjeta.IdTarjeta)
                .ValueAs(tarjeta => tarjeta.Codigo + " (" + tarjeta.Tipo + ")")
                .With(new RepositorioTarjetas().ObtenerTarjetasDelCliente(this.idCliente));
        }
    }
}
