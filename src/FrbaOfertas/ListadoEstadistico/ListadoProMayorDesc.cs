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
    public partial class ListadoProMayorDesc : Form
    {
        public ListadoProMayorDesc(int sem, int anio)
        {
            InitializeComponent();
            año.Text = anio.ToString();
            semestre.Text = sem.ToString();
            //vamos a usar esos para editar el contenido de la tabla con los
            //crear tabla de proveedores| Mayor%Desc
        }

        private void ListadoProMayorDesc_Load(object sender, EventArgs e)
        {

        }
    }
}
