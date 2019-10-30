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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABM Cliente";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(6, 167);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 3;
            this.volver.Text = "<< Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // bajaCliente
            // 
            this.bajaCliente.Location = new System.Drawing.Point(82, 115);
            this.bajaCliente.Name = "bajaCliente";
            this.bajaCliente.Size = new System.Drawing.Size(93, 23);
            this.bajaCliente.TabIndex = 2;
            this.bajaCliente.Text = "Baja Cliente";
            this.bajaCliente.UseVisualStyleBackColor = true;
            this.bajaCliente.Click += new System.EventHandler(this.bajaCliente_Click);
            // 
            // modificarCliente
            // 
            this.modificarCliente.Location = new System.Drawing.Point(82, 77);
            this.modificarCliente.Name = "modificarCliente";
            this.modificarCliente.Size = new System.Drawing.Size(93, 23);
            this.modificarCliente.TabIndex = 1;
            this.modificarCliente.Text = "Modificar Cliente";
            this.modificarCliente.UseVisualStyleBackColor = true;
            this.modificarCliente.Click += new System.EventHandler(this.modificarCliente_Click);
            // 
            // altaCliente
            // 
            this.altaCliente.Location = new System.Drawing.Point(82, 39);
            this.altaCliente.Name = "altaCliente";
            this.altaCliente.Size = new System.Drawing.Size(93, 23);
            this.altaCliente.TabIndex = 0;
            this.altaCliente.Text = "Alta Cliente";
            this.altaCliente.UseVisualStyleBackColor = true;
            this.altaCliente.Click += new System.EventHandler(this.altaCliente_Click);
            // 
            // AbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 220);
            this.Controls.Add(this.groupBox1);
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