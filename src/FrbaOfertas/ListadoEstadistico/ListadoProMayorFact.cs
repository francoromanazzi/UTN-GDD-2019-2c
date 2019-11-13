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
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Constantes;


namespace FrbaOfertas.ListadoEstadistico
{
    public partial class ListadoProMayorFact : Form
    {
        private readonly Form previousForm;

        public ListadoProMayorFact(Form previousForm, int sem, int anio)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            año.Text = anio.ToString();
            semestre.Text = sem.ToString();

        }

        private void ListadoProMayorFact_Load(object sender, EventArgs e)
        {
            StoredProcedureParameters listadoProMayorFact = new StoredProcedureParameters()
            .AddParameter("@anio", año.Text)
            .AddParameter("@semestre", semestre.Text);
            try
            {
                Conexion con = new Conexion();
                DataTable arr = con.ExecDataTableStoredProcedure(StoredProcedures.ListProveMayFact, listadoProMayorFact);
                tabla.DataSource = arr;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previousForm);
        }
    }
}
