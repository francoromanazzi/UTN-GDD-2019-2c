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
                int funcionalidadId = ((ComboBoxItem<int>) cmbFuncionalidades.SelectedItem).Value;

                NavigableFormUtil.ForwardTo(this, GetSelectedForm(funcionalidadId));
            }
        }

        private Form GetSelectedForm(int funcionalidadId)
        {
            switch (funcionalidadId)
            {
                case 5:
                    return new CargaCredito.CargaCredito(this);
                default:
                    return this;
            }
        }
    }
}
