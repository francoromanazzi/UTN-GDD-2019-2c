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
            try
            {
                string query = "SELECT Compras.id_compra, Compras.codigo_oferta FROM LOS_BORBOTONES.Ofertas JOIN LOS_BORBOTONES.Compras ON Ofertas.codigo_oferta = Compras.codigo_oferta WHERE Ofertas.id_proveedor = "
                    + proveedor + "AND Compras.fecha BETWEEN " + fechaInicio + " AND "+ fechaFin  + " ";
                DataTable dat = new Conexion().ExecDataTableSqlQuery(query);
                dataGridView1.DataSource = dat;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
