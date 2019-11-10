using FrbaOfertas.Clases.Constantes;
using FrbaOfertas.Clases.Database;
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

namespace FrbaOfertas.AbmProveedor
{
    public partial class BajaProveedor : Form
    {
        private readonly Form previousForm;

        public BajaProveedor(Form previousForm)
        {
            this.previousForm = previousForm;

            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void brnBuscar_Click(object sender, EventArgs e)
        {
            if (AlMenosUnCampoNoVacio())
            {
                try
                {
                    DataTable dat = new RepositorioProveedores().RealizarBusqueda(inputRazonSocial.Text, inputCuit.Text, inputEmail.Text);
                    grillaProveedores.DataSource = dat;
                }
                catch (Exception ex)
                {
                    MessageBoxUtil.ShowError(ex.Message);
                }
            }
        }

        #region Validadores
        private bool AlMenosUnCampoNoVacio()
        {
            if (inputRazonSocial.Text == "" && inputCuit.Text == "" && inputEmail.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }
        #endregion

        private void grillaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion con = new Conexion();

            int idProveedor = int.Parse(grillaProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString());
            string nombreContacto = grillaProveedores.CurrentRow.Cells["nombre_contacto"].Value.ToString();

            if (MessageBox.Show("¿Desea eliminar el proveedor " + nombreContacto + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int id_usuario = con.ExecSingleOutputSqlQuery<int>("SELECT id_usuario FROM LOS_BORBOTONES.Proveedores WHERE id_proveedor = " + idProveedor);

                bool estabaHabilitado = con.ExecSingleOutputSqlQuery<bool>("SELECT habilitado FROM LOS_BORBOTONES.Usuarios WHERE id_usuario = " + id_usuario);
                if (!estabaHabilitado)
                {
                    MessageBoxUtil.ShowError("El proveedor ya se encontraba deshabilitado");
                }
                else
                {
                    StoredProcedureParameters param = new StoredProcedureParameters()
                                .AddParameter("@idUsuario", id_usuario);

                    try
                    {
                        con.ExecDataTableStoredProcedure(StoredProcedures.EliminarUsuario, param);
                        MessageBoxUtil.ShowInfo("Proveedor deshabilitado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }

            }
        }
    }
}
