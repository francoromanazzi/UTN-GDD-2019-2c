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

        string fechaActual;

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

        private void facturar_Click(object sender, EventArgs e)
        {
            fechaActual = ConfigurationManager.AppSettings["FechaSistema"];
            if (MessageBox.Show("¿Desea facturar al proveedor ID " + proveedor + "?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    StoredProcedureParameters facturasParametros = new StoredProcedureParameters()
                            .AddParameter("@fecha_inicio", DateTime.Parse(fechaInicio))
                            .AddParameter("@fecha_fin", DateTime.Parse(fechaFin))
                            .AddParameter("@fecha", DateTime.Parse(fechaActual))
                            .AddParameter("@id_proveedor", int.Parse(proveedor));

                    int id_factura = new Conexion().ExecSingleOutputStoredProcedure<int>(StoredProcedures.CargarFactura, facturasParametros, "@id_factura");
                    ListadoOfertas_Load(null, null); // Refresh ofertas 

                    // Mostrar id_factura e importe
                    string importe = new Conexion().ExecSingleOutputSqlQuery<string>("SELECT CONVERT(NVARCHAR,importe) FROM LOS_BORBOTONES.Facturas WHERE id_factura = " + id_factura);
                    MessageBoxUtil.ShowInfo("Generada factura ID: " + id_factura + " de importe: $" + importe);

                }
                catch (SqlException ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
            else
            {

            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }
        

    }
}
