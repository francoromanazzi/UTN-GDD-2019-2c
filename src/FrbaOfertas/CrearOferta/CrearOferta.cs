using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Session;
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

namespace FrbaOfertas.CrearOferta
{
    public partial class CrearOferta : Form
    {
        private readonly Form previousForm;

        public CrearOferta(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();

            try
            {
                int idProveedor = new RepositorioProveedores().ObtenerIdProveedorDeUsuario(Session.Instance.IdUsuario);
                NavigableFormUtil.ForwardTo(this, new CrearOfertaPaso2(previousForm, idProveedor));
            }
            catch(Exception ex)
            {
                NavigableFormUtil.ForwardTo(this, new SeleccionarProveedor(previousForm));
            }
        }
    }
}
