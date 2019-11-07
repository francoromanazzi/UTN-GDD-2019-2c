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
using FrbaOfertas.Clases.Repositorios;

namespace FrbaOfertas.AbmCliente
{
    public partial class ModificarCliente : Form
    {
        private readonly AbmCliente previousForm;

        public ModificarCliente(AbmCliente previousForm)
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
                    }
                    catch (SqlException ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private bool AlMenosUnCampoNoVacio()
        {
            if(Nombre.Text == "" && Apellido.Text == "" && DNI.Text == "" && Email.Text == "")
            {
                MessageBoxUtil.ShowError("Debe completar al menos un campo para buscar");
                return false;
            }
            return true;
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
