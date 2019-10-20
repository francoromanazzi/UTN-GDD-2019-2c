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

namespace FrbaOfertas.RegistroUsuario
{
    
    public partial class RegistroDeUsuario : Form
    {
        private readonly Form previusForm;

        public RegistroDeUsuario(Form previusForm)
        {
            this.previusForm = previusForm;
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            /*Revisar porque no anda bien cuando Limpias y queres Volver al form anterior */
            RegistroDeUsuario newFormReg = new RegistroDeUsuario(previusForm);
            newFormReg.Show();
            this.Dispose(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            NavigableFormUtil.BackwardToDifferentWindow(this, previusForm);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            DatosCliente formDatosCli = new DatosCliente(this);
            formDatosCli.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            DatosProveedor formDatosProv = new DatosProveedor(this);
            formDatosProv.ShowDialog();
        }

      
      
    }
}
