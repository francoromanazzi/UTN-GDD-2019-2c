namespace FrbaOfertas.RegistroUsuario
{
    partial class ModificarPasswordUsuario
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
            this.grpModificarPassword = new System.Windows.Forms.GroupBox();
            this.btnModificarPassword = new System.Windows.Forms.Button();
            this.txtConfirmarPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.lblModificarPass = new System.Windows.Forms.Label();
            this.txtNuevoPassword = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpModificarPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModificarPassword
            // 
            this.grpModificarPassword.Controls.Add(this.btnModificarPassword);
            this.grpModificarPassword.Controls.Add(this.txtConfirmarPassword);
            this.grpModificarPassword.Controls.Add(this.lblConfirmarPass);
            this.grpModificarPassword.Controls.Add(this.lblModificarPass);
            this.grpModificarPassword.Controls.Add(this.txtNuevoPassword);
            this.grpModificarPassword.Location = new System.Drawing.Point(40, 34);
            this.grpModificarPassword.Name = "grpModificarPassword";
            this.grpModificarPassword.Size = new System.Drawing.Size(373, 124);
            this.grpModificarPassword.TabIndex = 1;
            this.grpModificarPassword.TabStop = false;
            this.grpModificarPassword.Text = "Modificar contraseña";
            // 
            // btnModificarPassword
            // 
            this.btnModificarPassword.Location = new System.Drawing.Point(264, 87);
            this.btnModificarPassword.Name = "btnModificarPassword";
            this.btnModificarPassword.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPassword.TabIndex = 1;
            this.btnModificarPassword.Text = "Aceptar";
            this.btnModificarPassword.UseVisualStyleBackColor = true;
            this.btnModificarPassword.Click += new System.EventHandler(this.btnModificarPassword_Click);
            // 
            // txtConfirmarPassword
            // 
            this.txtConfirmarPassword.Location = new System.Drawing.Point(177, 61);
            this.txtConfirmarPassword.Name = "txtConfirmarPassword";
            this.txtConfirmarPassword.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmarPassword.TabIndex = 4;
            this.txtConfirmarPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Location = new System.Drawing.Point(50, 64);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(107, 13);
            this.lblConfirmarPass.TabIndex = 5;
            this.lblConfirmarPass.Text = "Confirmar contraseña";
            // 
            // lblModificarPass
            // 
            this.lblModificarPass.AutoSize = true;
            this.lblModificarPass.Location = new System.Drawing.Point(50, 34);
            this.lblModificarPass.Name = "lblModificarPass";
            this.lblModificarPass.Size = new System.Drawing.Size(95, 13);
            this.lblModificarPass.TabIndex = 2;
            this.lblModificarPass.Text = "Nueva contraseña";
            // 
            // txtNuevoPassword
            // 
            this.txtNuevoPassword.Location = new System.Drawing.Point(177, 31);
            this.txtNuevoPassword.Name = "txtNuevoPassword";
            this.txtNuevoPassword.Size = new System.Drawing.Size(162, 20);
            this.txtNuevoPassword.TabIndex = 3;
            this.txtNuevoPassword.UseSystemPasswordChar = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(40, 165);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ModificarPasswordUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 200);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpModificarPassword);
            this.Name = "ModificarPasswordUsuario";
            this.Text = "ModificarPasswordUsuario";
            this.grpModificarPassword.ResumeLayout(false);
            this.grpModificarPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModificarPassword;
        private System.Windows.Forms.Button btnModificarPassword;
        private System.Windows.Forms.TextBox txtConfirmarPassword;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.Label lblModificarPass;
        private System.Windows.Forms.TextBox txtNuevoPassword;
        private System.Windows.Forms.Button btnVolver;
    }
}