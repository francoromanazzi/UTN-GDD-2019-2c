﻿namespace FrbaOfertas.ListadoEstadistico
{
    partial class ListadoEstadistico
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
            this.nroSemestre = new System.Windows.Forms.ComboBox();
            this.textoSemestre = new System.Windows.Forms.Label();
            this.textAño = new System.Windows.Forms.Label();
            this.textlist1 = new System.Windows.Forms.Label();
            this.list2 = new System.Windows.Forms.Label();
            this.btnListMayorPorcentaje = new System.Windows.Forms.Button();
            this.btnListProvMayorFact = new System.Windows.Forms.Button();
            this.selectAño = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nroSemestre
            // 
            this.nroSemestre.FormattingEnabled = true;
            this.nroSemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.nroSemestre.Location = new System.Drawing.Point(82, 44);
            this.nroSemestre.Name = "nroSemestre";
            this.nroSemestre.Size = new System.Drawing.Size(40, 21);
            this.nroSemestre.TabIndex = 1;
            this.nroSemestre.SelectedIndexChanged += new System.EventHandler(this.nroSemestre_SelectedIndexChanged);
            // 
            // textoSemestre
            // 
            this.textoSemestre.AutoSize = true;
            this.textoSemestre.Location = new System.Drawing.Point(23, 47);
            this.textoSemestre.Name = "textoSemestre";
            this.textoSemestre.Size = new System.Drawing.Size(51, 13);
            this.textoSemestre.TabIndex = 2;
            this.textoSemestre.Text = "Semestre";
            this.textoSemestre.Click += new System.EventHandler(this.label1_Click);
            // 
            // textAño
            // 
            this.textAño.AutoSize = true;
            this.textAño.Location = new System.Drawing.Point(150, 47);
            this.textAño.Name = "textAño";
            this.textAño.Size = new System.Drawing.Size(26, 13);
            this.textAño.TabIndex = 3;
            this.textAño.Text = "Año";
            // 
            // textlist1
            // 
            this.textlist1.AutoSize = true;
            this.textlist1.Location = new System.Drawing.Point(6, 82);
            this.textlist1.Name = "textlist1";
            this.textlist1.Size = new System.Drawing.Size(350, 13);
            this.textlist1.TabIndex = 4;
            this.textlist1.Text = "Proveedores con mayor porcentaje de descuento ofrecido en sus ofertas";
            // 
            // list2
            // 
            this.list2.AutoSize = true;
            this.list2.Location = new System.Drawing.Point(7, 125);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(175, 13);
            this.list2.TabIndex = 5;
            this.list2.Text = "Proveedores con mayor facturación";
            // 
            // btnListMayorPorcentaje
            // 
            this.btnListMayorPorcentaje.Location = new System.Drawing.Point(362, 79);
            this.btnListMayorPorcentaje.Name = "btnListMayorPorcentaje";
            this.btnListMayorPorcentaje.Size = new System.Drawing.Size(85, 23);
            this.btnListMayorPorcentaje.TabIndex = 6;
            this.btnListMayorPorcentaje.Text = "Consultar";
            this.btnListMayorPorcentaje.UseVisualStyleBackColor = true;
            this.btnListMayorPorcentaje.Click += new System.EventHandler(this.btnListMayorPorcentaje_Click);
            // 
            // btnListProvMayorFact
            // 
            this.btnListProvMayorFact.Location = new System.Drawing.Point(362, 120);
            this.btnListProvMayorFact.Name = "btnListProvMayorFact";
            this.btnListProvMayorFact.Size = new System.Drawing.Size(85, 23);
            this.btnListProvMayorFact.TabIndex = 7;
            this.btnListProvMayorFact.Text = "Consultar";
            this.btnListProvMayorFact.UseVisualStyleBackColor = true;
            this.btnListProvMayorFact.Click += new System.EventHandler(this.btnListProvMayorFact_Click);
            // 
            // selectAño
            // 
            this.selectAño.FormattingEnabled = true;
            this.selectAño.Items.AddRange(new object[] {
            "2020",
            "2019",
            "2018",
            "2017"});
            this.selectAño.Location = new System.Drawing.Point(186, 44);
            this.selectAño.Name = "selectAño";
            this.selectAño.Size = new System.Drawing.Size(50, 21);
            this.selectAño.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnListProvMayorFact);
            this.groupBox1.Controls.Add(this.selectAño);
            this.groupBox1.Controls.Add(this.btnListMayorPorcentaje);
            this.groupBox1.Controls.Add(this.list2);
            this.groupBox1.Controls.Add(this.textoSemestre);
            this.groupBox1.Controls.Add(this.textlist1);
            this.groupBox1.Controls.Add(this.nroSemestre);
            this.groupBox1.Controls.Add(this.textAño);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 207);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado Estadistico";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(9, 168);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "<< Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // ListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoEstadistico";
            this.Text = "ListadoEstadistico";
            this.Load += new System.EventHandler(this.ListadoEstadistico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nroSemestre;
        private System.Windows.Forms.Label textoSemestre;
        private System.Windows.Forms.Label textAño;
        private System.Windows.Forms.Label textlist1;
        private System.Windows.Forms.Label list2;
        private System.Windows.Forms.Button btnListMayorPorcentaje;
        private System.Windows.Forms.Button btnListProvMayorFact;
        private System.Windows.Forms.ComboBox selectAño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVolver;
    }
}