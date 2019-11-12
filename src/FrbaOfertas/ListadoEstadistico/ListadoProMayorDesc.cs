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
        public ListadoProMayorDesc(int sem, int anio)
        {
            InitializeComponent();
            año.Text = anio.ToString();
            semestre.Text = sem.ToString();
            //vamos a usar esos para editar el contenido de la tabla con los
            //crear tabla de proveedores| Mayor%Desc
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
            
            }
            catch (Exception ex)
            {
                MessageBoxUtil.ShowError(ex.Message);
            }

        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
