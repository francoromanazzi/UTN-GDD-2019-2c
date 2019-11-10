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

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class ListadoEstadistico : Form
    {
        private readonly Form previousForm;

        public ListadoEstadistico(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void ListadoEstadistico_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nroSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
