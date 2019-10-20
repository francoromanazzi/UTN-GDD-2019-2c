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
            /*Revisar porque no anda bien cuando Limpias y queres Volver al form anterior */
            DatosCliente formDatosCli = new DatosCliente(previusForm);
            formDatosCli.Show();
            this.Dispose(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previusForm);
        }
    }
}
