namespace FrbaOfertas.AbmCliente
{
    partial class ModificarCliente
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
            this.buscar = new System.Windows.Forms.Button();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(597, 400);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 5;
            this.buscar.Text = "Buscar";
            this.buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buscar.UseMnemonic = false;
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(19, 100);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.Size = new System.Drawing.Size(653, 279);
            this.grillaClientes.TabIndex = 20;
            this.grillaClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaClientes_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(66, 53);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(162, 20);
            this.Apellido.TabIndex = 2;
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(512, 18);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(160, 20);
            this.DNI.TabIndex = 1;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(512, 53);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(160, 20);
            this.Email.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(66, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(162, 20);
            this.Nombre.TabIndex = 0;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(19, 401);
            this.volver.Name = "volver";
            this.volver.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 4;
            this.volver.Text = "<< Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 441);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.grillaClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.volver);
            this.Name = "ModificarCliente";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button volver;
    }
}