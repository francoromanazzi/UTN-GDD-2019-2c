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
    public partial class ListadoProMayorFact : Form
    {
        public ListadoProMayorFact(int sem, int anio)
        {
            InitializeComponent();
            año.Text = anio.ToString();
            semestre.Text = sem.ToString();
        }

        private void ListadoProMayorFact_Load(object sender, EventArgs e)
        {

        }
    }
}
