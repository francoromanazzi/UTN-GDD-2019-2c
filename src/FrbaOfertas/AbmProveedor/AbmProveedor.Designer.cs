namespace FrbaOfertas.AbmProveedor
{
    partial class AbmProveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBajaProveedor = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnAltaProveedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnBajaProveedor);
            this.groupBox1.Controls.Add(this.btnModificarCliente);
            this.groupBox1.Controls.Add(this.btnAltaProveedor);
            this.groupBox1.Location = new System.Drawing.Point(31, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(381, 302);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 257);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 35);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBajaProveedor
            // 
            this.btnBajaProveedor.Location = new System.Drawing.Point(103, 173);
            this.btnBajaProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBajaProveedor.Name = "btnBajaProveedor";
            this.btnBajaProveedor.Size = new System.Drawing.Size(167, 35);
            this.btnBajaProveedor.TabIndex = 2;
            this.btnBajaProveedor.Text = "Baja Proveedor";
            this.btnBajaProveedor.UseVisualStyleBackColor = true;
            this.btnBajaProveedor.Click += new System.EventHandler(this.btnBajaProveedor_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(103, 114);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(167, 35);
            this.btnModificarCliente.TabIndex = 1;
            this.btnModificarCliente.Text = "Modificar Proveedor";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnAltaProveedor
            // 
            this.btnAltaProveedor.Location = new System.Drawing.Point(103, 56);
            this.btnAltaProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAltaProveedor.Name = "btnAltaProveedor";
            this.btnAltaProveedor.Size = new System.Drawing.Size(167, 35);
            this.btnAltaProveedor.TabIndex = 0;
            this.btnAltaProveedor.Text = "Alta Proveedor";
            this.btnAltaProveedor.UseVisualStyleBackColor = true;
            this.btnAltaProveedor.Click += new System.EventHandler(this.btnAltaProveedor_Click);
            // 
            // AbmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 335);
            this.Controls.Add(this.groupBox1);
            this.Name = "AbmProveedor";
            this.Text = "AbmProveedor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBajaProveedor;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnAltaProveedor;
    }
}