﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Clases.Utils.Form;
using FrbaOfertas.Clases.Database;
using FrbaOfertas.Clases.Repositorios;
using FrbaOfertas.Clases.Constantes;

namespace FrbaOfertas.AbmCliente
{
    public partial class BajaCliente : Form
    {
        private readonly AbmCliente previousForm;

        public BajaCliente(AbmCliente previousForm)
        {
            this.previousForm = previousForm;
            InitializeComponent();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            // Validaciones de campos
            if (!TextFieldUtil.CampoNumericoValido(DNI) || !TextFieldUtil.CampoTextoValido(Nombre, Apellido))
            {
                // No hacer nada. El msj de error esta dentro de las funciones
            }
            else
            {
                if (AlMenosUnCampoNoVacio())
                {
                    try
                    {
                        DataTable dat = new RepositorioClientes().BuscarCliente(Nombre.Text, Apellido.Text, DNI.Text, Email.Text);
                        grillaClientes.DataSource = dat;
                        grillaClientes.Columns["id_cliente"].Visible = false;
                    }
                    catch (SqlException ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Conexion con = new Conexion();
            string nombre = grillaClientes.CurrentRow.Cells[0].Value.ToString();
            string apellido = grillaClientes.CurrentRow.Cells[1].Value.ToString();
            string DNI = grillaClientes.CurrentRow.Cells[2].Value.ToString();
            int id_usuario = con.ExecSingleOutputSqlQuery<int>("SELECT id_usuario FROM LOS_BORBOTONES.Clientes WHERE dni = " + DNI);

            if (MessageBox.Show("¿Desea eliminar el cliente " + nombre + " " + apellido + " ?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StoredProcedureParameters param = new StoredProcedureParameters()
                    .AddParameter("@idUsuario", id_usuario);

                bool estabaHabilitado = con.ExecSingleOutputSqlQuery<bool>("SELECT habilitado FROM LOS_BORBOTONES.Usuarios WHERE id_usuario = " + id_usuario);
                if (!estabaHabilitado)
                {
                    MessageBoxUtil.ShowError("El proveedor ya se encontraba deshabilitado");
                }
                else
                {
                    try
                    {
                        con.ExecDataTableStoredProcedure(StoredProcedures.EliminarUsuario, param);
                        MessageBoxUtil.ShowInfo("Cliente deshabilitado exitosamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        #region Validadores
        private bool AlMenosUnCampoNoVacio()
        {
            if (Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "" && Email.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }
        #endregion
    }
}
