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
    public partial class AbmProveedor : Form
    {
        private readonly Form previousForm;

        public AbmProveedor(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new AltaProveedor(this));
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ModificarProveedor(this));
        }

        private void btnBajaProveedor_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new BajaProveedor(this));
        }
    }
}
