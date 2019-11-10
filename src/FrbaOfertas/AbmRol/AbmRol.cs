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

namespace FrbaOfertas.AbmRol
{
    public partial class AbmRol : Form
    {
        private readonly Form previousForm;

        public AbmRol(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new AltaRol(this));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ModificarRol(this));
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new BajaRol(this));
        }
    }
}
