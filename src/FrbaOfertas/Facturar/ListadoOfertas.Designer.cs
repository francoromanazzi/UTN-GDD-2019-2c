﻿namespace FrbaOfertas.Facturar
{
    partial class ListadoOfertas
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
            this.facturar = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Label();
            this.fin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.volver);
            this.groupBox1.Controls.Add(this.facturar);
            this.groupBox1.Controls.Add(this.inicio);
            this.groupBox1.Controls.Add(this.fin);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(27, 365);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(75, 23);
            this.volver.TabIndex = 6;
            this.volver.Text = "<< Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // facturar
            // 
            this.facturar.Location = new System.Drawing.Point(340, 365);
            this.facturar.Name = "facturar";
            this.facturar.Size = new System.Drawing.Size(75, 23);
            this.facturar.TabIndex = 5;
            this.facturar.Text = "Facturar";
            this.facturar.UseVisualStyleBackColor = true;
            this.facturar.Click += new System.EventHandler(this.facturar_Click);
            // 
            // inicio
            // 
            this.inicio.AutoSize = true;
            this.inicio.Location = new System.Drawing.Point(24, 57);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(32, 13);
            this.inicio.TabIndex = 4;
            this.inicio.Text = "Inicio";
            // 
            // fin
            // 
            this.fin.AutoSize = true;
            this.fin.Location = new System.Drawing.Point(203, 57);
            this.fin.Name = "fin";
            this.fin.Size = new System.Drawing.Size(21, 13);
            this.fin.TabIndex = 3;
            this.fin.Text = "Fin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // ListadoOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 427);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoOfertas";
            this.Text = "Listado de ofertas";
            this.Load += new System.EventHandler(this.ListadoOfertas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label inicio;
        private System.Windows.Forms.Label fin;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button facturar;
    }
}