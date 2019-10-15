namespace FrbaOfertas.CargaCredito
{
    partial class CargaCredito
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
            this.grpCargaCredito = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCargarTarjeta = new System.Windows.Forms.Button();
            this.cmbTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.inputMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.grpCargaCredito.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCargaCredito
            // 
            this.grpCargaCredito.Controls.Add(this.lblCamposObligatorios);
            this.grpCargaCredito.Controls.Add(this.btnLimpiar);
            this.grpCargaCredito.Controls.Add(this.btnVolver);
            this.grpCargaCredito.Controls.Add(this.btnAceptar);
            this.grpCargaCredito.Controls.Add(this.btnCargarTarjeta);
            this.grpCargaCredito.Controls.Add(this.cmbTarjeta);
            this.grpCargaCredito.Controls.Add(this.lblTarjeta);
            this.grpCargaCredito.Controls.Add(this.lblTipoPago);
            this.grpCargaCredito.Controls.Add(this.cmbTipoPago);
            this.grpCargaCredito.Controls.Add(this.inputMonto);
            this.grpCargaCredito.Controls.Add(this.lblMonto);
            this.grpCargaCredito.Location = new System.Drawing.Point(12, 12);
            this.grpCargaCredito.Name = "grpCargaCredito";
            this.grpCargaCredito.Size = new System.Drawing.Size(260, 351);
            this.grpCargaCredito.TabIndex = 0;
            this.grpCargaCredito.TabStop = false;
            this.grpCargaCredito.Text = "Carga de crédito";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(22, 303);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 253);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(213, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCargarTarjeta
            // 
            this.btnCargarTarjeta.Location = new System.Drawing.Point(135, 191);
            this.btnCargarTarjeta.Name = "btnCargarTarjeta";
            this.btnCargarTarjeta.Size = new System.Drawing.Size(100, 23);
            this.btnCargarTarjeta.TabIndex = 1;
            this.btnCargarTarjeta.Text = "Cargar otra tarjeta";
            this.btnCargarTarjeta.UseVisualStyleBackColor = true;
            this.btnCargarTarjeta.Click += new System.EventHandler(this.btnCargarTarjeta_Click);
            // 
            // cmbTarjeta
            // 
            this.cmbTarjeta.FormattingEnabled = true;
            this.cmbTarjeta.Location = new System.Drawing.Point(22, 164);
            this.cmbTarjeta.Name = "cmbTarjeta";
            this.cmbTarjeta.Size = new System.Drawing.Size(213, 21);
            this.cmbTarjeta.TabIndex = 4;
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Location = new System.Drawing.Point(19, 148);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(95, 13);
            this.lblTarjeta.TabIndex = 1;
            this.lblTarjeta.Text = "Seleccionar tarjeta";
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Location = new System.Drawing.Point(19, 87);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(77, 13);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo de pago *";
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Débito",
            "Crédito"});
            this.cmbTipoPago.Location = new System.Drawing.Point(22, 103);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(213, 21);
            this.cmbTipoPago.TabIndex = 2;
            // 
            // inputMonto
            // 
            this.inputMonto.Location = new System.Drawing.Point(22, 48);
            this.inputMonto.Name = "inputMonto";
            this.inputMonto.Size = new System.Drawing.Size(213, 20);
            this.inputMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(19, 32);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(86, 13);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto a cargar *";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(160, 303);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(19, 223);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(108, 13);
            this.lblCamposObligatorios.TabIndex = 6;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // CargaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 375);
            this.Controls.Add(this.grpCargaCredito);
            this.Name = "CargaCredito";
            this.Text = "CargaCredito";
            this.grpCargaCredito.ResumeLayout(false);
            this.grpCargaCredito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargaCredito;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCargarTarjeta;
        private System.Windows.Forms.ComboBox cmbTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.TextBox inputMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCamposObligatorios;
    }
}