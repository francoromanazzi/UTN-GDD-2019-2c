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

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void list_Click(object sender, EventArgs e)
        {

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            // SqlConnection cn = new SqlConnection();
            lbltitulo.Text = "Conexion existosa";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = "";
        }
    }
}
