using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Utils.Form;

namespace FrbaOfertas.Facturar
{
    public partial class ListadoOfertas : Form
    {
        private readonly Form previousForm;
        private string proveedor;
        private string fechaInicio;
        private string fechaFin;

        public ListadoOfertas(Form previousForm, string proveedor, string fechaInicio, string fechaFin)
        {
            this.previousForm = previousForm;
            this.proveedor = proveedor;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            InitializeComponent();
        }

        private void ListadoOfertas_Load(object sender, EventArgs e)
        {
            label1.Text = "Proveedor ID: " + proveedor;
            inicio.Text = "Fecha de inicio: " + fechaInicio;
            fin.Text = "Fecha de fin: " + fechaFin;

            try
            {
                StoredProcedureParameters listadoParametros = new StoredProcedureParameters()
                    .AddParameter("@id_proveedor", proveedor)
                    .AddParameter("@fechaInicio", DateTime.Parse(fechaInicio))
                    .AddParameter("@fechaFin", DateTime.Parse(fechaFin));

                DataTable dat = new Conexion().ExecDataTableStoredProcedure(StoredProcedures.MostrarListado, listadoParametros);
                dataGridView1.DataSource = dat;
                
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }
        }

    }
}
