namespace FrbaOfertas.CargaCredito
{
    partial class CargarTarjeta
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
            this.grpCargarTarjeta = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.inputCodigo = new System.Windows.Forms.TextBox();
            this.grpCargarTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCargarTarjeta
            // 
            this.grpCargarTarjeta.Controls.Add(this.inputCodigo);
            this.grpCargarTarjeta.Controls.Add(this.lblCodigo);
            this.grpCargarTarjeta.Controls.Add(this.cmbTipoTarjeta);
            this.grpCargarTarjeta.Controls.Add(this.lblTipo);
            this.grpCargarTarjeta.Controls.Add(this.btnAceptar);
            this.grpCargarTarjeta.Controls.Add(this.btnVolver);
            this.grpCargarTarjeta.Location = new System.Drawing.Point(12, 12);
            this.grpCargarTarjeta.Name = "grpCargarTarjeta";
            this.grpCargarTarjeta.Size = new System.Drawing.Size(260, 196);
            this.grpCargarTarjeta.TabIndex = 0;
            this.grpCargarTarjeta.TabStop = false;
            this.grpCargarTarjeta.Text = "Cargar nueva tarjeta";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(101, 156);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(153, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 156);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 34);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(75, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de tarjeta";
            // 
            // cmbTipoTarjeta
            // 
            this.cmbTipoTarjeta.FormattingEnabled = true;
            this.cmbTipoTarjeta.Items.AddRange(new object[] {
            "Débito",
            "Crédito"});
            this.cmbTipoTarjeta.Location = new System.Drawing.Point(26, 50);
            this.cmbTipoTarjeta.Name = "cmbTipoTarjeta";
            this.cmbTipoTarjeta.Size = new System.Drawing.Size(203, 21);
            this.cmbTipoTarjeta.TabIndex = 3;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 95);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(98, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código de la tarjeta";
            // 
            // inputCodigo
            // 
            this.inputCodigo.Location = new System.Drawing.Point(26, 111);
            this.inputCodigo.Name = "inputCodigo";
            this.inputCodigo.Size = new System.Drawing.Size(203, 20);
            this.inputCodigo.TabIndex = 5;
            // 
            // CargarTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.grpCargarTarjeta);
            this.Name = "CargarTarjeta";
            this.Text = "CargarTarjeta";
            this.grpCargarTarjeta.ResumeLayout(false);
            this.grpCargarTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCargarTarjeta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox inputCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox cmbTipoTarjeta;
        private System.Windows.Forms.Label lblTipo;
    }
}