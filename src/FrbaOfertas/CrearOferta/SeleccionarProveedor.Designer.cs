namespace FrbaOfertas.CrearOferta
{
    partial class SeleccionarProveedor
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
            this.grpSeleccionarProveedor = new System.Windows.Forms.GroupBox();
            this.inputMail = new System.Windows.Forms.TextBox();
            this.inputDreccion = new System.Windows.Forms.TextBox();
            this.inputTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.inputCuit = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gridProveedores = new System.Windows.Forms.DataGridView();
            this.grpSeleccionarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSeleccionarProveedor
            // 
            this.grpSeleccionarProveedor.Controls.Add(this.inputMail);
            this.grpSeleccionarProveedor.Controls.Add(this.inputDreccion);
            this.grpSeleccionarProveedor.Controls.Add(this.inputTelefono);
            this.grpSeleccionarProveedor.Controls.Add(this.lblTelefono);
            this.grpSeleccionarProveedor.Controls.Add(this.inputCuit);
            this.grpSeleccionarProveedor.Controls.Add(this.lblEmail);
            this.grpSeleccionarProveedor.Controls.Add(this.lblDireccion);
            this.grpSeleccionarProveedor.Controls.Add(this.lblCuit);
            this.grpSeleccionarProveedor.Controls.Add(this.btnBuscar);
            this.grpSeleccionarProveedor.Controls.Add(this.btnVolver);
            this.grpSeleccionarProveedor.Controls.Add(this.gridProveedores);
            this.grpSeleccionarProveedor.Location = new System.Drawing.Point(12, 12);
            this.grpSeleccionarProveedor.Name = "grpSeleccionarProveedor";
            this.grpSeleccionarProveedor.Size = new System.Drawing.Size(458, 316);
            this.grpSeleccionarProveedor.TabIndex = 0;
            this.grpSeleccionarProveedor.TabStop = false;
            this.grpSeleccionarProveedor.Text = "Seleccionar Proveedor";
            // 
            // inputMail
            // 
            this.inputMail.Location = new System.Drawing.Point(294, 54);
            this.inputMail.Name = "inputMail";
            this.inputMail.Size = new System.Drawing.Size(158, 20);
            this.inputMail.TabIndex = 11;
            // 
            // inputDreccion
            // 
            this.inputDreccion.Location = new System.Drawing.Point(294, 28);
            this.inputDreccion.MaxLength = 8;
            this.inputDreccion.Name = "inputDreccion";
            this.inputDreccion.Size = new System.Drawing.Size(158, 20);
            this.inputDreccion.TabIndex = 10;
            // 
            // inputTelefono
            // 
            this.inputTelefono.Location = new System.Drawing.Point(64, 54);
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.Size = new System.Drawing.Size(149, 20);
            this.inputTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(9, 57);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono";
            // 
            // inputCuit
            // 
            this.inputCuit.Location = new System.Drawing.Point(64, 28);
            this.inputCuit.Name = "inputCuit";
            this.inputCuit.Size = new System.Drawing.Size(149, 20);
            this.inputCuit.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(236, 54);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(236, 28);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 7;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(13, 28);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 8;
            this.lblCuit.Text = "Cuit";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(134, 282);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(318, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(6, 282);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gridProveedores
            // 
            this.gridProveedores.AllowUserToAddRows = false;
            this.gridProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProveedores.Location = new System.Drawing.Point(6, 90);
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.ReadOnly = true;
            this.gridProveedores.Size = new System.Drawing.Size(446, 173);
            this.gridProveedores.TabIndex = 0;
            this.gridProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProveedores_CellContentClick);
            // 
            // SeleccionarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 340);
            this.Controls.Add(this.grpSeleccionarProveedor);
            this.Name = "SeleccionarProveedor";
            this.Text = "SeleccionarProveedor";
            this.grpSeleccionarProveedor.ResumeLayout(false);
            this.grpSeleccionarProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeleccionarProveedor;
        private System.Windows.Forms.DataGridView gridProveedores;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox inputMail;
        private System.Windows.Forms.TextBox inputDreccion;
        private System.Windows.Forms.TextBox inputTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox inputCuit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCuit;
    }
}