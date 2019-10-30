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

namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private readonly AltaCliente previousForm;

        public AltaCliente(AltaCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        // Limpiar pantalla
        private void limpiar_Click(object sender, EventArgs e)
        {
            AltaCliente newForm = new AltaCliente(previousForm);
            newForm.ShowDialog();
            this.Dispose(false);
        }

        // Volver atras
        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            try { }
            catch { }
        }
    }
}
