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
        private readonly AbmCliente previousForm;

        public AltaCliente(AbmCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        // Limpiar pantalla
        private void limpiar_Click(object sender, EventArgs e)
        {
            AltaCliente newForm = new AltaCliente(previousForm);
            newForm.Show();
            this.Dispose(false);
        }

        // Volver atras
        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Validaciones

            try { }
            catch { }
        }
    }
}
