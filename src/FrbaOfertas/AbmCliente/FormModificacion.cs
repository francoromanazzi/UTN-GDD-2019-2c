﻿using System;
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

namespace FrbaOfertas.AbmCliente
{
    public partial class FormModificacion : Form
    {
        private readonly ModificarCliente previousForm;
        private string dniOriginal;

        public FormModificacion(ModificarCliente previousForm, string nombre, string apellido, string dni, string mail, string telefono,
                                                        string direccion, string piso, string dpto, string localidad, string codigoPostal, DateTime fechaNac)
        {
            this.previousForm = previousForm;
            InitializeComponent();

            // Cargar datos del cliente en cuestión
            Nombre.Text = nombre;
            Apellido.Text = apellido;
            DNI.Text = dni;
            Email.Text = mail;
            Telefono.Text = telefono;
            Direccion.Text = direccion;
            Piso.Text = piso;
            Departamento.Text = dpto;
            Localidad.Text = localidad;
            CodigoPostal.Text = codigoPostal;
            FechaDeNacimiento.Value = fechaNac;

            dniOriginal = dni;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardTo(this, previousForm);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            if (!TextFieldUtil.CampoNumericoValido(DNI, Piso, CodigoPostal) ||
                !TextFieldUtil.CampoTextoValido(Nombre, Apellido))
            {
                // Nothing
            }
            else
            {
                if (CamposRequeridosNoVacios())
                {
                    StoredProcedureParameters datosActualizados = new StoredProcedureParameters()
                        .AddParameter("@dniOriginal", dniOriginal)
                        .AddParameter("@nombre", Nombre.Text)
                        .AddParameter("@apellido", Apellido.Text)
                        .AddParameter("@dni", double.Parse(DNI.Text))
                        .AddParameter("@mail", Email.Text)
                        .AddParameter("@telefono", double.Parse(Telefono.Text))
                        .AddParameter("@direccion", Direccion.Text)
                        .AddParameter("@fecha_nacimiento", DateTime.Parse(FechaDeNacimiento.Text))
                        .AddParameter("@habilitado", habilitacion.Checked);
                 
                    // Ahora me fijo si completo los campos no requeridos y lo agrego en caso que si
                    // Piso
                    if (Piso.Text == "")
                    {
                        datosActualizados.AddParameter("@piso", DBNull.Value); // Muy diferente de NULL 
                    }
                    else
                    {
                        datosActualizados.AddParameter("@piso", decimal.Parse(Piso.Text));
                    }
                    // Dpto
                    if (Departamento.Text == "")
                    {
                        datosActualizados.AddParameter("@departamento", DBNull.Value);
                    }
                    else
                    {
                        datosActualizados.AddParameter("@departamento", Departamento.Text);
                    }
                    // Localidad
                    if (Localidad.Text == "")
                    {
                        datosActualizados.AddParameter("@localidad", DBNull.Value);
                    }
                    else
                    {
                        datosActualizados.AddParameter("@localidad", Localidad.Text);
                    }
                    // Codigo Postal
                    if (CodigoPostal.Text == "")
                    {
                        datosActualizados.AddParameter("@codigo_postal", DBNull.Value);
                    }
                    else
                    {
                        datosActualizados.AddParameter("@codigo_postal", decimal.Parse(CodigoPostal.Text));
                    }

                    try
                    {
                        Conexion con = new Conexion();
                        con.ExecDataTableStoredProcedure(StoredProcedures.ActualizarCliente, datosActualizados);

                        previousForm.RefrescarBusqueda();

                        MessageBoxUtil.ShowInfo("Cliente actualizado correctamente");
                    }
                    catch (Exception ex)
                    {
                        MessageBoxUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        #region Validadores
        private bool CamposRequeridosNoVacios()
        {
            if (Nombre.Text == "" || Apellido.Text == "" || DNI.Text == "" || FechaDeNacimiento.Text == ""
                || Email.Text == "" || Telefono.Text == "" || Direccion.Text == "")
            {
                MessageBoxUtil.ShowError("Hay campos requeridos incompletos.");
                return false;
            }
            return true;
        }
        #endregion


        private void FormModificacion_Load(object sender, EventArgs e)
        {
            int id_usuario = new Conexion().ExecSingleOutputSqlQuery<int>("SELECT id_usuario FROM LOS_BORBOTONES.Clientes WHERE dni = " + dniOriginal);
            bool habilitado = new Conexion().ExecSingleOutputSqlQuery<bool>("SELECT habilitado FROM LOS_BORBOTONES.Usuarios WHERE id_usuario = " + id_usuario);
            if (habilitado)
                habilitacion.Checked = true;
            else
                habilitacion.Checked = false;

        }
    }
}
