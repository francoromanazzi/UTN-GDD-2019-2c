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
    public partial class AbmCliente : Form
    {
        private readonly Form previousForm; // Ventana Anterior

        public AbmCliente(Form previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        // Alta Cliente
        private void altaCliente_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new AltaCliente(this));
        }

        // Modificar Cliente
        private void modificarCliente_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new ModificarCliente(this));
        }

        // Baja Cliente
        private void bajaCliente_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.ForwardTo(this, new BajaCliente(this));
        }

        // Volver atras
        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

    }
}
