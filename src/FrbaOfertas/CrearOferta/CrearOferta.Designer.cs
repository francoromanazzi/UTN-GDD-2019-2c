namespace FrbaOfertas.CrearOferta
{
    partial class CrearOferta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpCrearOferta = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.inputDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoOferta = new System.Windows.Forms.Label();
            this.inputMaxUnidadesPorCliente = new System.Windows.Forms.TextBox();
            this.lblMaxUnidadesPorCliente = new System.Windows.Forms.Label();
            this.inputStockDisponible = new System.Windows.Forms.TextBox();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.inputPrecioLista = new System.Windows.Forms.TextBox();
            this.inputPrecioOferta = new System.Windows.Forms.TextBox();
            this.lblPrecioLista = new System.Windows.Forms.Label();
            this.lblPrecioOferta = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPublicacion = new System.Windows.Forms.Label();
            this.grpCrearOferta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCrearOferta
            // 
            this.grpCrearOferta.Controls.Add(this.dateTimePickerFechaVencimiento);
            this.grpCrearOferta.Controls.Add(this.label1);
            this.grpCrearOferta.Controls.Add(this.lblCamposObligatorios);
            this.grpCrearOferta.Controls.Add(this.btnLimpiar);
            this.grpCrearOferta.Controls.Add(this.btnVolver);
            this.grpCrearOferta.Controls.Add(this.btnAceptar);
            this.grpCrearOferta.Controls.Add(this.inputDescripcion);
            this.grpCrearOferta.Controls.Add(this.lblDescripcion);
            this.grpCrearOferta.Controls.Add(this.inputCodigo);
            this.grpCrearOferta.Controls.Add(this.lblCodigoOferta);
            this.grpCrearOferta.Controls.Add(this.inputMaxUnidadesPorCliente);
            this.grpCrearOferta.Controls.Add(this.lblMaxUnidadesPorCliente);
            this.grpCrearOferta.Controls.Add(this.inputStockDisponible);
            this.grpCrearOferta.Controls.Add(this.lblStockDisponible);
            this.grpCrearOferta.Controls.Add(this.inputPrecioLista);
            this.grpCrearOferta.Controls.Add(this.inputPrecioOferta);
            this.grpCrearOferta.Controls.Add(this.lblPrecioLista);
            this.grpCrearOferta.Controls.Add(this.lblPrecioOferta);
            this.grpCrearOferta.Controls.Add(this.dateTimePickerFechaPublicacion);
            this.grpCrearOferta.Controls.Add(this.lblFechaPublicacion);
            this.grpCrearOferta.Location = new System.Drawing.Point(12, 12);
            this.grpCrearOferta.Name = "grpCrearOferta";
            this.grpCrearOferta.Size = new System.Drawing.Size(319, 504);
            this.grpCrearOferta.TabIndex = 0;
            this.grpCrearOferta.TabStop = false;
            this.grpCrearOferta.Text = "Crear oferta";
            // 
            // dateTimePickerFechaVencimiento
            // 
            this.dateTimePickerFechaVencimiento.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaVencimiento.Location = new System.Drawing.Point(24, 108);
            this.dateTimePickerFechaVencimiento.Name = "dateTimePickerFechaVencimiento";
            this.dateTimePickerFechaVencimiento.Size = new System.Drawing.Size(274, 20);
            this.dateTimePickerFechaVencimiento.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Vencimiento *";
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(21, 383);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 13;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(223, 467);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(24, 467);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "<<Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(24, 399);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(274, 35);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // inputDescripcion
            // 
            this.inputDescripcion.Location = new System.Drawing.Point(24, 325);
            this.inputDescripcion.Multiline = true;
            this.inputDescripcion.Name = "inputDescripcion";
            this.inputDescripcion.Size = new System.Drawing.Size(274, 40);
            this.inputDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(21, 309);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descripcion *";
            // 
            // inputCodigo
            // 
            this.inputCodigo.Location = new System.Drawing.Point(24, 276);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(274, 20);
            this.inputCodigo.TabIndex = 9;
            // 
            // lblCodigoOferta
            // 
            this.lblCodigoOferta.AutoSize = true;
            this.lblCodigoOferta.Location = new System.Drawing.Point(21, 260);
            this.lblCodigoOferta.Name = "lblCodigoOferta";
            this.lblCodigoOferta.Size = new System.Drawing.Size(47, 13);
            this.lblCodigoOferta.TabIndex = 1;
            this.lblCodigoOferta.Text = "Codigo *";
            // 
            // inputMaxUnidadesPorCliente
            // 
            this.inputMaxUnidadesPorCliente.Location = new System.Drawing.Point(174, 227);
            this.inputMaxUnidadesPorCliente.Name = "inputMaxUnidadesPorCliente";
            this.inputMaxUnidadesPorCliente.Size = new System.Drawing.Size(124, 20);
            this.inputMaxUnidadesPorCliente.TabIndex = 8;
            // 
            // lblMaxUnidadesPorCliente
            // 
            this.lblMaxUnidadesPorCliente.AutoSize = true;
            this.lblMaxUnidadesPorCliente.Location = new System.Drawing.Point(171, 211);
            this.lblMaxUnidadesPorCliente.Name = "lblMaxUnidadesPorCliente";
            this.lblMaxUnidadesPorCliente.Size = new System.Drawing.Size(132, 13);
            this.lblMaxUnidadesPorCliente.TabIndex = 7;
            this.lblMaxUnidadesPorCliente.Text = "Max unidades por cliente *";
            // 
            // inputStockDisponible
            // 
            this.inputStockDisponible.Location = new System.Drawing.Point(24, 227);
            this.inputStockDisponible.Name = "inputStockDisponible";
            this.inputStockDisponible.Size = new System.Drawing.Size(123, 20);
            this.inputStockDisponible.TabIndex = 6;
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Location = new System.Drawing.Point(21, 211);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(94, 13);
            this.lblStockDisponible.TabIndex = 1;
            this.lblStockDisponible.Text = "Stock Disponible *";
            // 
            // inputPrecioLista
            // 
            this.inputPrecioLista.Location = new System.Drawing.Point(174, 171);
            this.inputPrecioLista.Name = "inputPrecioLista";
            this.inputPrecioLista.Size = new System.Drawing.Size(124, 20);
            this.inputPrecioLista.TabIndex = 5;
            // 
            // inputPrecioOferta
            // 
            this.inputPrecioOferta.Location = new System.Drawing.Point(24, 171);
            this.inputPrecioOferta.Name = "inputPrecioOferta";
            this.inputPrecioOferta.Size = new System.Drawing.Size(123, 20);
            this.inputPrecioOferta.TabIndex = 4;
            // 
            // lblPrecioLista
            // 
            this.lblPrecioLista.AutoSize = true;
            this.lblPrecioLista.Location = new System.Drawing.Point(171, 155);
            this.lblPrecioLista.Name = "lblPrecioLista";
            this.lblPrecioLista.Size = new System.Drawing.Size(84, 13);
            this.lblPrecioLista.TabIndex = 3;
            this.lblPrecioLista.Text = "Precio de Lista *";
            // 
            // lblPrecioOferta
            // 
            this.lblPrecioOferta.AutoSize = true;
            this.lblPrecioOferta.Location = new System.Drawing.Point(21, 155);
            this.lblPrecioOferta.Name = "lblPrecioOferta";
            this.lblPrecioOferta.Size = new System.Drawing.Size(91, 13);
            this.lblPrecioOferta.TabIndex = 1;
            this.lblPrecioOferta.Text = "Precio en Oferta *";
            // 
            // dateTimePickerFechaPublicacion
            // 
            this.dateTimePickerFechaPublicacion.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePickerFechaPublicacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaPublicacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerFechaPublicacion.Location = new System.Drawing.Point(24, 50);
            this.dateTimePickerFechaPublicacion.Name = "dateTimePickerFechaPublicacion";
            this.dateTimePickerFechaPublicacion.Size = new System.Drawing.Size(274, 20);
            this.dateTimePickerFechaPublicacion.TabIndex = 2;
            // 
            // lblFechaPublicacion
            // 
            this.lblFechaPublicacion.AutoSize = true;
            this.lblFechaPublicacion.Location = new System.Drawing.Point(21, 34);
            this.lblFechaPublicacion.Name = "lblFechaPublicacion";
            this.lblFechaPublicacion.Size = new System.Drawing.Size(102, 13);
            this.lblFechaPublicacion.TabIndex = 1;
            this.lblFechaPublicacion.Text = "Fecha Publicacion *";
            // 
            // CrearOfertaPaso2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 528);
            this.Controls.Add(this.grpCrearOferta);
            this.Name = "CrearOfertaPaso2";
            this.Text = "CrearOferta";
            this.grpCrearOferta.ResumeLayout(false);
            this.grpCrearOferta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCrearOferta;
        private System.Windows.Forms.Label lblPrecioLista;
        private System.Windows.Forms.Label lblPrecioOferta;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPublicacion;
        private System.Windows.Forms.Label lblFechaPublicacion;
        private System.Windows.Forms.TextBox inputStockDisponible;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.TextBox inputPrecioLista;
        private System.Windows.Forms.TextBox inputPrecioOferta;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Label lblCodigoOferta;
        private System.Windows.Forms.TextBox inputMaxUnidadesPorCliente;
        private System.Windows.Forms.Label lblMaxUnidadesPorCliente;
        private System.Windows.Forms.TextBox inputDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaVencimiento;
        private System.Windows.Forms.Label label1;
    }
}