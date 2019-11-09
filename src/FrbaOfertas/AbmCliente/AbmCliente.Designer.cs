namespace FrbaOfertas.AbmCliente
{
    partial class AbmCliente
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
            this.volver = new System.Windows.Forms.Button();
            this.bajaCliente = new System.Windows.Forms.Button();
            this.modificarCliente = new System.Windows.Forms.Button();
            this.altaCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.volver);
            this.groupBox1.Controls.Add(this.bajaCliente);
            this.groupBox1.Controls.Add(this.modificarCliente);
            this.groupBox1.Controls.Add(this.altaCliente);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(381, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione una opcion";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(9, 257);
            this.volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(112, 35);
            this.volver.TabIndex = 3;
            this.volver.Text = "<< Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // bajaCliente
            // 
            this.bajaCliente.Location = new System.Drawing.Point(123, 177);
            this.bajaCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bajaCliente.Name = "bajaCliente";
            this.bajaCliente.Size = new System.Drawing.Size(140, 35);
            this.bajaCliente.TabIndex = 2;
            this.bajaCliente.Text = "Baja Cliente";
            this.bajaCliente.UseVisualStyleBackColor = true;
            this.bajaCliente.Click += new System.EventHandler(this.bajaCliente_Click);
            // 
            // modificarCliente
            // 
            this.modificarCliente.Location = new System.Drawing.Point(123, 118);
            this.modificarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modificarCliente.Name = "modificarCliente";
            this.modificarCliente.Size = new System.Drawing.Size(140, 35);
            this.modificarCliente.TabIndex = 1;
            this.modificarCliente.Text = "Modificar Cliente";
            this.modificarCliente.UseVisualStyleBackColor = true;
            this.modificarCliente.Click += new System.EventHandler(this.modificarCliente_Click);
            // 
            // altaCliente
            // 
            this.altaCliente.Location = new System.Drawing.Point(123, 60);
            this.altaCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(140, 35);
            this.altaCliente.TabIndex = 0;
            this.altaCliente.Text = "Alta Cliente";
            this.altaCliente.UseVisualStyleBackColor = true;
            this.altaCliente.Click += new System.EventHandler(this.altaCliente_Click);
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 338);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AbmCliente";
            this.Text = "ABM Cliente";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button altaCliente;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button bajaCliente;
        private System.Windows.Forms.Button modificarCliente;
    }
}