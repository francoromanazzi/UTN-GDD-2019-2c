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
using FrbaOfertas.Clases.Modelo;

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class ListadoProMayorDesc : Form
    {
        private readonly Form previousForm;

        public ListadoProMayorDesc(Form previousForm, int sem, int anio)
        {
            this.previousForm = previousForm;
            InitializeComponent();
            año.Text = anio.ToString();
            semestre.Text = sem.ToString();
        }

        private void ListadoProMayorDesc_Load(object sender, EventArgs e)
        {
            StoredProcedureParameters listadoProMayorDesc = new StoredProcedureParameters()
            .AddParameter("@anio", año.Text)
            .AddParameter("@semestre", semestre.Text);
            try
            {
                Conexion con = new Conexion();
                DataTable arr =  con.ExecDataTableStoredProcedure(StoredProcedures.ListProveMayDesc , listadoProMayorDesc);
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
