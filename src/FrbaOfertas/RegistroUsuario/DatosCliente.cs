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

namespace FrbaOfertas.RegistroUsuario
{
    /* Hay que mudar esta clase a AbmCliente*/

    public partial class DatosCliente : Form
    {
        private readonly RegistroDeUsuario previusForm;

        public DatosCliente(RegistroDeUsuario previusForm)
        {
            this.previusForm = previusForm;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            NavigableFormUtil.ForwardToDifferentWindow(previusForm, new DatosCliente(previusForm));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previusForm);
        }

        private void DatosCliente_Load(object sender, EventArgs e) // Cargo los CombosBox
        {
            /* Sugerencia: ¿Como diseño, MonthCalendar no sería mas comodo? */
            CargarDias();
            CargarMeses();
            CargarAnios();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try { }
            catch { }
        }

        private void CargarDias()
        {
            for (int i = 1; i <= 31; i++)
            {
                comboDia.Items.Add(i);
            }
        }
        private void CargarMeses()
        {
            for (int i = 1; i <= 12; i++)
            {
                comboMes.Items.Add(i);
            }
        }
        private void CargarAnios()
        {
            for (int i = 1950; i <= 2019; i++)
            {
                comboAnio.Items.Add(i);
            }
        }
    }
}
