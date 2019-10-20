namespace FrbaOfertas.RegistroUsuario
{
    partial class RegistroDeUsuario
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
            this.grpRegistroUsuario = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpUserType = new System.Windows.Forms.GroupBox();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtUserPass = new System.Windows.Forms.TextBox();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpRegistroUsuario.SuspendLayout();
            this.grpUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRegistroUsuario
            // 
            this.grpRegistroUsuario.Controls.Add(this.comboBox1);
            this.grpRegistroUsuario.Controls.Add(this.grpUserType);
            this.grpRegistroUsuario.Controls.Add(this.btnAceptar);
            this.grpRegistroUsuario.Controls.Add(this.lblRol);
            this.grpRegistroUsuario.Controls.Add(this.txtUserPass);
            this.grpRegistroUsuario.Controls.Add(this.lblUserPass);
            this.grpRegistroUsuario.Controls.Add(this.txtUserName);
            this.grpRegistroUsuario.Controls.Add(this.lblUserName);
            this.grpRegistroUsuario.Location = new System.Drawing.Point(12, 24);
            this.grpRegistroUsuario.Name = "grpRegistroUsuario";
            this.grpRegistroUsuario.Size = new System.Drawing.Size(260, 478);
            this.grpRegistroUsuario.TabIndex = 0;
            this.grpRegistroUsuario.TabStop = false;
            this.grpRegistroUsuario.Text = "Registro de Usuario";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(23, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // grpUserType
            // 
            this.grpUserType.Controls.Add(this.btnProveedor);
            this.grpUserType.Controls.Add(this.btnCliente);
            this.grpUserType.Location = new System.Drawing.Point(23, 291);
            this.grpUserType.Name = "grpUserType";
            this.grpUserType.Size = new System.Drawing.Size(214, 75);
            this.grpUserType.TabIndex = 11;
            this.grpUserType.TabStop = false;
            this.grpUserType.Text = "Seleccione el tipo de Usuario";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(113, 29);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnProveedor.TabIndex = 1;
            this.btnProveedor.Text = "Proveedor";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(12, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(162, 429);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(20, 200);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(90, 13);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Seleccione el Rol";
            // 
            // txtUserPass
            // 
            this.txtUserPass.Location = new System.Drawing.Point(23, 143);
            this.txtUserPass.Name = "txtUserPass";
            this.txtUserPass.Size = new System.Drawing.Size(188, 20);
            this.txtUserPass.TabIndex = 3;
            // 
            // lblUserPass
            // 
            this.lblUserPass.AutoSize = true;
            this.lblUserPass.Location = new System.Drawing.Point(20, 114);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(116, 13);
            this.lblUserPass.TabIndex = 2;
            this.lblUserPass.Text = "Ingrese su contraseña*";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(23, 60);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(188, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(153, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Ingrese su nombre de usuario *";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(174, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(35, 532);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 10;
            this.btnVolver.Text = "<<Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // RegistroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 567);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpRegistroUsuario);
            this.Name = "RegistroDeUsuario";
            this.Text = "RegistroDeUsuario";
            this.grpRegistroUsuario.ResumeLayout(false);
            this.grpRegistroUsuario.PerformLayout();
            this.grpUserType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistroUsuario;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.TextBox txtUserPass;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpUserType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnVolver;
    }
}