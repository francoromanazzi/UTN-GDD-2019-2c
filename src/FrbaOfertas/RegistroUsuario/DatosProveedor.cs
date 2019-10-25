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
    /* Hay que mudar esta clase a AbmProveedor */

    public partial class DatosProveedor : Form
    {
        private readonly RegistroDeUsuario formAnterior;

        public DatosProveedor(RegistroDeUsuario previusForm)
        {
            this.formAnterior = previusForm;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*Revisar porque no anda bien cuando Limpias y queres Volver al form anterior */
            DatosProveedor formDatosProv = new DatosProveedor(formAnterior);
            formDatosProv.Show();
            this.Dispose(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, formAnterior);
        }
    }
}
