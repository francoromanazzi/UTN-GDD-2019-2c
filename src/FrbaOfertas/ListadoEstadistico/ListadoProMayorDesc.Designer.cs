namespace FrbaOfertas.ListadoEstadistico
{
    partial class ListadoProMayorDesc
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
            this.año = new System.Windows.Forms.Label();
            this.semestre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.may_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // año
            // 
            this.año.AutoSize = true;
            this.año.Location = new System.Drawing.Point(68, 40);
            this.año.Name = "año";
            this.año.Size = new System.Drawing.Size(31, 13);
            this.año.TabIndex = 0;
            this.año.Text = "2020";
            // 
            // semestre
            // 
            this.semestre.AutoSize = true;
            this.semestre.Location = new System.Drawing.Point(288, 40);
            this.semestre.Name = "semestre";
            this.semestre.Size = new System.Drawing.Size(13, 13);
            this.semestre.TabIndex = 1;
            this.semestre.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "semestre";
            // 
            // tabla
            // 
            this.tabla.AllowUserToAddRows = false;
            this.tabla.AllowUserToDeleteRows = false;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.may_desc});
            this.tabla.Location = new System.Drawing.Point(118, 93);
            this.tabla.Name = "tabla";
            this.tabla.ReadOnly = true;
            this.tabla.Size = new System.Drawing.Size(245, 167);
            this.tabla.TabIndex = 4;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "Id Proveedor";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.ReadOnly = true;
            // 
            // may_desc
            // 
            this.may_desc.HeaderText = "Mayor Descuento";
            this.may_desc.Name = "may_desc";
            this.may_desc.ReadOnly = true;
            // 
            // ListadoProMayorDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 287);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.semestre);
            this.Controls.Add(this.año);
            this.Name = "ListadoProMayorDesc";
            this.Text = "ListadoProMayorDesc";
            this.Load += new System.EventHandler(this.ListadoProMayorDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label año;
        private System.Windows.Forms.Label semestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn may_desc;
    }
}