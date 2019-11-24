using FrbaOfertas.Clases.Utils.Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Libs propias
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Constantes;

namespace FrbaOfertas.Facturar
{
    public partial class Facturar : Form
    {
        private readonly Form previousForm;
        string provElegido;

        public Facturar(Form previousForm)
        {
            this.previousForm = previousForm;

            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        // CARGAR PROVEEDORES
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT id_proveedor, cuit, razon_social FROM LOS_BORBOTONES.Proveedores";
                DataTable dat = new Conexion().ExecDataTableSqlQuery(query);
                proveedores.DataSource = dat;
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }

        }

        private void proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            provElegido = proveedores.CurrentRow.Cells[0].Value.ToString(); // id_proveedor
            ListadoOfertas list = new ListadoOfertas(previousForm, provElegido, fechaInicio.Text , fechaFin.Text);
            list.ShowDialog();
        }

    }
}
