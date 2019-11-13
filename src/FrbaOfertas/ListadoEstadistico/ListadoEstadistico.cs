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

        private void btnListMayorPorcentaje_Click(object sender, EventArgs e)
        {
            int indiceSemestre = nroSemestre.SelectedIndex;//indice seleccionado

            if (indiceSemestre != -1)
            {
                int semestre = Convert.ToInt32(nroSemestre.Items[indiceSemestre].ToString());

                int indiceAño = selectAño.SelectedIndex;

                if (indiceAño != -1)
                {
                    int año = Convert.ToInt32(selectAño.Items[indiceAño].ToString());

                    NavigableFormUtil.ForwardToDifferentWindow(this, new ListadoProMayorDesc(this, semestre, año));
                }
                else
                {
                    MessageBoxUtil.ShowError("Seleccione un año");
                }
            }
            else
            {
                MessageBoxUtil.ShowError("Seleccione un semestre");
            }
        }

        private void btnListProvMayorFact_Click(object sender, EventArgs e)
        {
            int indiceSemestre = nroSemestre.SelectedIndex;//indice seleccionado
            if (indiceSemestre != -1)
            {
                int semestre = Convert.ToInt32(nroSemestre.Items[indiceSemestre].ToString());

                int indiceAño = selectAño.SelectedIndex;

                if (indiceAño != -1)
                {
                    int año = Convert.ToInt32(selectAño.Items[indiceAño].ToString());

                    NavigableFormUtil.ForwardToDifferentWindow(this, new ListadoProMayorFact(this, semestre, año));
                }
                else
                {
                    MessageBoxUtil.ShowError("Seleccione un año");
                }
            }
            else
            {
                MessageBoxUtil.ShowError("Seleccione un año");
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
    }
}
