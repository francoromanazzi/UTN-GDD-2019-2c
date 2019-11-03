using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Librerias propias
using FrbaOfertas.Clases.Utils.Form;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Constantes;


namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : Form
    {
        private readonly AbmCliente previousForm;

        public AltaCliente(AbmCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        // Limpiar pantalla
        private void limpiar_Click(object sender, EventArgs e)
        {
            AltaCliente newForm = new AltaCliente(previousForm);
            newForm.Show();
            this.Dispose(false);
        }

        // Volver atras
        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(DNI, numeroCalle, piso, codPostal) &&
                !TextFieldUtil.CampoTextoValido(nombre, apellido, direccion, localidad) 
                &&  !CamposRequeridosVacios())
            {
                // Dentro de la funcion esta el mensaje de error
            }
            else 
            {
                // Armo el Store Procedure con los parametros REQUERIDOS
                StoredProcedureParameters parametros = new StoredProcedureParameters()
                    .AddParameter("@nombre", nombre.Text)
                    .AddParameter("@apellido", apellido.Text)
                    .AddParameter("@dni", decimal.Parse(DNI.Text))
                    .AddParameter("@mail", email.Text)
                    .AddParameter("@telefono", telefono.Text)
                    .AddParameter("@direccion", direccion.Text)
                    .AddParameter("@fecha_nacimiento", Convert.ToDateTime(fechaDeNac.Text))
                    .AddParameter("@numero", decimal.Parse(numeroCalle.Text));
                // Ahora me fijo si completo los campos no requeridos y lo agrego en caso que si
                // Piso
                if (piso.Text == "")
                {
                    parametros.AddParameter("@piso", DBNull.Value); // Muy diferente de NULL 
                }
                else
                {
                    parametros.AddParameter("@piso", decimal.Parse(piso.Text));
                }
                // Dpto
                if (dpto.Text == "")
                {
                    parametros.AddParameter("@departamento", DBNull.Value);
                }
                else
                {
                    parametros.AddParameter("@departamento", decimal.Parse(dpto.Text));
                }
                // Localidad
                if (localidad.Text == "")
                {
                    parametros.AddParameter("@localidad", DBNull.Value);
                }
                else
                {
                    parametros.AddParameter("@localidad", localidad.Text);
                }
                // Codigo Postal
                if (codPostal.Text == "")
                {
                    parametros.AddParameter("@codigo_postal", DBNull.Value); 
                }
                else
                {
                    parametros.AddParameter("@codigo_postal", decimal.Parse(codPostal.Text));
                }

                try 
                {
                    // Impacto en la base
                    Conexion con = new Conexion();
                    con.ExecDataTableStoredProcedure(StoredProcedures.AltaCliente, parametros);
                }
                catch { }
            }
        }

        #region Validadores

        private bool CamposRequeridosVacios()
        {
            if (nombre.Text == "" || apellido.Text == "" || DNI.Text == "" || fechaDeNac.Text == ""
                || email.Text == "" || telefono.Text == "" || direccion.Text == "" || numeroCalle.Text == "")
            {
                MessageBox.Show("Hay campos requeridos incompletos.");
                return true;
            }
            return false;
        }

        #endregion
    }
}
