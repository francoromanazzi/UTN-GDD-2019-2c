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
    
    public partial class RegistroDeUsuario : Form
    {
        private readonly Form previusForm;

        public RegistroDeUsuario(Form previusForm)
        {
            this.previusForm = previusForm;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new RegistroDeUsuario(previusForm));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previusForm);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardToDifferentWindow(this, new DatosCliente(this));
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardToDifferentWindow(this, new DatosProveedor(this));
        }
      
    }
}
