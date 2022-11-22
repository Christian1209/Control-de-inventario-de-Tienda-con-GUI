namespace CRUD
{
    partial class FormGridProducto
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
            this.components = new System.ComponentModel.Container();
            this.dtagridProducto = new System.Windows.Forms.DataGridView();
            this.Codigopro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombrepro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciaPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostePro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculadoPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbConsulta6 = new System.Windows.Forms.CheckBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cbConsulta5 = new System.Windows.Forms.CheckBox();
            this.cbConsulta4 = new System.Windows.Forms.CheckBox();
            this.cbConsulta3 = new System.Windows.Forms.CheckBox();
            this.cbConsulta2 = new System.Windows.Forms.CheckBox();
            this.cbConsulta1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtagridProducto
            // 
            this.dtagridProducto.AllowUserToOrderColumns = true;
            this.dtagridProducto.AutoGenerateColumns = false;
            this.dtagridProducto.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtagridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigopro,
            this.Nombrepro,
            this.DescripcionPro,
            this.PrecioPro,
            this.ExistenciaPro,
            this.CostePro,
            this.calculadoPro});
            this.dtagridProducto.DataSource = this.productoBindingSource;
            this.dtagridProducto.Location = new System.Drawing.Point(12, 119);
            this.dtagridProducto.Name = "dtagridProducto";
            this.dtagridProducto.RowHeadersWidth = 51;
            this.dtagridProducto.RowTemplate.Height = 24;
            this.dtagridProducto.Size = new System.Drawing.Size(1172, 664);
            this.dtagridProducto.TabIndex = 6;
            this.dtagridProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtagridProducto_CellContentClick);
            // 
            // Codigopro
            // 
            this.Codigopro.DataPropertyName = "Codigo";
            this.Codigopro.HeaderText = "Codigo";
            this.Codigopro.MinimumWidth = 6;
            this.Codigopro.Name = "Codigopro";
            this.Codigopro.Width = 125;
            // 
            // Nombrepro
            // 
            this.Nombrepro.DataPropertyName = "Nombre";
            this.Nombrepro.HeaderText = "Nombre";
            this.Nombrepro.MinimumWidth = 6;
            this.Nombrepro.Name = "Nombrepro";
            this.Nombrepro.Width = 125;
            // 
            // DescripcionPro
            // 
            this.DescripcionPro.DataPropertyName = "Description";
            this.DescripcionPro.HeaderText = "Description";
            this.DescripcionPro.MinimumWidth = 6;
            this.DescripcionPro.Name = "DescripcionPro";
            this.DescripcionPro.Width = 125;
            // 
            // PrecioPro
            // 
            this.PrecioPro.DataPropertyName = "Precio";
            this.PrecioPro.HeaderText = "Precio";
            this.PrecioPro.MinimumWidth = 6;
            this.PrecioPro.Name = "PrecioPro";
            this.PrecioPro.Width = 125;
            // 
            // ExistenciaPro
            // 
            this.ExistenciaPro.DataPropertyName = "Existencia";
            this.ExistenciaPro.HeaderText = "Existencia";
            this.ExistenciaPro.MinimumWidth = 6;
            this.ExistenciaPro.Name = "ExistenciaPro";
            this.ExistenciaPro.Width = 125;
            // 
            // CostePro
            // 
            this.CostePro.DataPropertyName = "Coste";
            this.CostePro.HeaderText = "Coste";
            this.CostePro.MinimumWidth = 6;
            this.CostePro.Name = "CostePro";
            this.CostePro.Width = 125;
            // 
            // calculadoPro
            // 
            this.calculadoPro.DataPropertyName = "Calculado";
            this.calculadoPro.HeaderText = "Calculado";
            this.calculadoPro.MinimumWidth = 6;
            this.calculadoPro.Name = "calculadoPro";
            this.calculadoPro.Width = 125;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CRUD.producto);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbConsulta6);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.cbConsulta5);
            this.groupBox1.Controls.Add(this.cbConsulta4);
            this.groupBox1.Controls.Add(this.cbConsulta3);
            this.groupBox1.Controls.Add(this.cbConsulta2);
            this.groupBox1.Controls.Add(this.cbConsulta1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cbConsulta6
            // 
            this.cbConsulta6.AutoSize = true;
            this.cbConsulta6.Location = new System.Drawing.Point(634, 40);
            this.cbConsulta6.Name = "cbConsulta6";
            this.cbConsulta6.Size = new System.Drawing.Size(64, 20);
            this.cbConsulta6.TabIndex = 6;
            this.cbConsulta6.Text = "Coste";
            this.cbConsulta6.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(748, 42);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Ejecutar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click_1);
            // 
            // cbConsulta5
            // 
            this.cbConsulta5.AutoSize = true;
            this.cbConsulta5.Location = new System.Drawing.Point(529, 42);
            this.cbConsulta5.Name = "cbConsulta5";
            this.cbConsulta5.Size = new System.Drawing.Size(89, 20);
            this.cbConsulta5.TabIndex = 4;
            this.cbConsulta5.Text = "existencia";
            this.cbConsulta5.UseVisualStyleBackColor = true;
            // 
            // cbConsulta4
            // 
            this.cbConsulta4.AutoSize = true;
            this.cbConsulta4.Location = new System.Drawing.Point(414, 42);
            this.cbConsulta4.Name = "cbConsulta4";
            this.cbConsulta4.Size = new System.Drawing.Size(67, 20);
            this.cbConsulta4.TabIndex = 3;
            this.cbConsulta4.Text = "precio";
            this.cbConsulta4.UseVisualStyleBackColor = true;
            // 
            // cbConsulta3
            // 
            this.cbConsulta3.AutoSize = true;
            this.cbConsulta3.Location = new System.Drawing.Point(288, 42);
            this.cbConsulta3.Name = "cbConsulta3";
            this.cbConsulta3.Size = new System.Drawing.Size(99, 20);
            this.cbConsulta3.TabIndex = 2;
            this.cbConsulta3.Text = "descripcion";
            this.cbConsulta3.UseVisualStyleBackColor = true;
            // 
            // cbConsulta2
            // 
            this.cbConsulta2.AutoSize = true;
            this.cbConsulta2.Location = new System.Drawing.Point(168, 42);
            this.cbConsulta2.Name = "cbConsulta2";
            this.cbConsulta2.Size = new System.Drawing.Size(75, 20);
            this.cbConsulta2.TabIndex = 1;
            this.cbConsulta2.Text = "nombre";
            this.cbConsulta2.UseVisualStyleBackColor = true;
            // 
            // cbConsulta1
            // 
            this.cbConsulta1.AutoSize = true;
            this.cbConsulta1.Location = new System.Drawing.Point(71, 42);
            this.cbConsulta1.Name = "cbConsulta1";
            this.cbConsulta1.Size = new System.Drawing.Size(71, 20);
            this.cbConsulta1.TabIndex = 0;
            this.cbConsulta1.Text = "codigo";
            this.cbConsulta1.UseVisualStyleBackColor = true;
            // 
            // FormGridProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 828);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtagridProducto);
            this.Name = "FormGridProducto";
            this.Text = "FormGridProducto";
            this.Load += new System.EventHandler(this.FormGridProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagridProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbConsulta5;
        private System.Windows.Forms.CheckBox cbConsulta4;
        private System.Windows.Forms.CheckBox cbConsulta3;
        private System.Windows.Forms.CheckBox cbConsulta2;
        private System.Windows.Forms.CheckBox cbConsulta1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.CheckBox cbConsulta6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombrepro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciaPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostePro;
        private System.Windows.Forms.DataGridViewTextBoxColumn calculadoPro;
    }
}