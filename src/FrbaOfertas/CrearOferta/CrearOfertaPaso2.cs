using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Utils.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOfertaPaso2 : Form
    {
        private readonly Form previousForm;
        private readonly int idProveedor;

        public CrearOfertaPaso2(Form previousForm, int idProveedor)
        {
            this.previousForm = previousForm;
            this.idProveedor = idProveedor;

            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CrearOfertaPaso2 NewForm = new CrearOfertaPaso2(previousForm, idProveedor);
            NewForm.Show();
            this.Dispose(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.ValidarInputs())
            {
                double precioOferta, precioLista;
                double.TryParse(inputPrecioOferta.Text, out precioOferta);
                double.TryParse(inputPrecioLista.Text, out precioLista);

                try
                {

                    new RepositorioOfertas().Guardar(
                        dateTimePickerFechaPublicacion.Value,
                        dateTimePickerFechaVencimiento.Value,
                        precioOferta,
                        precioLista,
                        Int32.Parse(inputStockDisponible.Text),
                        Int32.Parse(inputMaxUnidadesPorCliente.Text),
                        inputCodigo.Text,
                        inputDescripcion.Text,
                        idProveedor
                    );

                    MessageBoxUtil.ShowInfo("La oferta fue guardada exitosamente");
                    NavigableFormUtil.BackwardTo(this, previousForm);
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
            double precioOferta, precioLista;
            DateTime fechaSistema = DateTime.Parse(ConfigurationManager.AppSettings["FechaSistema"]);
            
            // Validacion fecha publicacion
            if (dateTimePickerFechaPublicacion.Value.CompareTo(fechaSistema) < 0)
            {
                errores += "La fecha de publicacion no puede ser anterior a la fecha actual (" + fechaSistema + ")\n";
            }

            // Validacion fecha vencimiento
            if (dateTimePickerFechaVencimiento.Value.CompareTo(fechaSistema) < 0)
            {
                errores += "La fecha de publicacion no puede ser anterior a la fecha actual (" + fechaSistema + ")\n";
            }

            // Validacion fecha publicacion y vencimiento
            if (dateTimePickerFechaVencimiento.Value.CompareTo(dateTimePickerFechaPublicacion.Value) < 0)
            {
                errores += "La fecha de vencimiento no puede ser anterior a la fecha de publicacion\n";
            }

            // Validacion precio oferta
            if (inputPrecioOferta.Text == "")
            {
                errores += "El precio de oferta es obligatorio\n";
            }
            else if (!double.TryParse(inputPrecioOferta.Text, out precioOferta))
            {
                errores += "El precio de oferta debe ser un número flotante\n";
            }
            else if (precioOferta <= 0)
            {
                errores += "El precio de oferta debe ser mayor que cero\n";
            }

            // Validacion precio lista
            if (inputPrecioLista.Text == "")
            {
                errores += "El precio de lista es obligatorio\n";
            }
            else if (!double.TryParse(inputPrecioLista.Text, out precioLista))
            {
                errores += "El precio de lista debe ser un número flotante\n";
            }
            else if (precioLista <= 0)
            {
                errores += "El precio de lista debe ser mayor que cero\n";
            }

            // Validacion precio oferta y precio lista
            if (double.TryParse(inputPrecioOferta.Text, out precioOferta) && double.TryParse(inputPrecioLista.Text, out precioLista) && precioOferta >= precioLista)
            {
                errores += "El precio de oferta debe ser menor que el precio de lista\n";
            }

            // Validacion stock disponible
            if (inputStockDisponible.Text == "")
            {
                errores += "El stock disponible es obligatorio\n";
            }
            else if (!TextFieldUtil.IsDigitsOnly(inputStockDisponible.Text))
            {
                errores += "El stock disponible debe ser un número entero positivo\n";
            }

            // Validacion max unidades por cliente
            if (inputMaxUnidadesPorCliente.Text == "")
            {
                errores += "El maximo de unidades por cliente es obligatorio\n";
            }
            else if (!TextFieldUtil.IsDigitsOnly(inputMaxUnidadesPorCliente.Text))
            {
                errores += "El maximo de unidades por cliente debe ser un número entero positivo\n";
            }

            // Validacion codigo
            if (inputCodigo.Text == "")
            {
                errores += "El codigo es obligatorio\n";
            }
            else if (inputCodigo.Text.Length > 50)
            {
                errores += "El codigo es muy largo\n";
            }
            else if (inputCodigo.Text.Length < 4)
            {
                errores += "El codigo es muy corto\n";
            }

            // Validacion descripcion
            if (inputDescripcion.Text == "")
            {
                errores += "La descripcion es obligatoria\n";
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
