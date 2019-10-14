using FrbaOfertas.Clases.Modelo;
using FrbaOfertas.Clases.Repositorios;
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

namespace FrbaOfertas.SeleccionarFuncionalidad
{
    public partial class SeleccionarFuncionalidad : Form
    {
        private Form previousForm;
        private IList<Rol> rolesUsuario;

        public SeleccionarFuncionalidad(Form previousForm, IList<Rol> rolesUsuario)
        {
            this.previousForm = previousForm;
            this.rolesUsuario = rolesUsuario;

            RepositorioFuncionalidades repositorioFuncionalidades = new RepositorioFuncionalidades();
            IList<Funcionalidad> todasSusFuncionalidades = new List<Funcionalidad>();
            foreach(Rol rol in rolesUsuario)
            {
                todasSusFuncionalidades = todasSusFuncionalidades.Concat(repositorioFuncionalidades.FuncionalidadesDeUnRol(rol.IdRol)).ToList();
            }

            InitializeComponent();

            ComboBoxFiller<Funcionalidad, int>.Fill(cmbFuncionalidades)
                .KeyAs(funcionalidad => funcionalidad.IdFuncionalidad)
                .ValueAs(funcionalidad => funcionalidad.Descripcion)
                .With(todasSusFuncionalidades);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cmbFuncionalidades.SelectedItem == null)
            {
                MessageBoxUtil.ShowError("Seleccione una funcionalidad");
            }
            else
            {
                int selectedItemId = ((ComboBoxItem<int>) cmbFuncionalidades.SelectedItem).Value;
                MessageBoxUtil.ShowInfo("Seleccionaste" + selectedItemId);
                //NavigableFormUtil.ForwardTo(this, PostLoginFormFactory.CreateForm(selectedItemId, this));
            }
        }
    }
}
