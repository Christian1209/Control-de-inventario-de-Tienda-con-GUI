namespace CRUD
{
    partial class FormGridProveedor
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
            this.dtaGridProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.cbConsulta4 = new System.Windows.Forms.CheckBox();
            this.cbConsulta3 = new System.Windows.Forms.CheckBox();
            this.cbConsulta2 = new System.Windows.Forms.CheckBox();
            this.cbConsulta1 = new System.Windows.Forms.CheckBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridProveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridProveedor
            // 
            this.dtaGridProveedor.AutoGenerateColumns = false;
            this.dtaGridProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtaGridProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Marca,
            this.Producto,
            this.Numero_tel});
            this.dtaGridProveedor.DataSource = this.proveedorBindingSource;
            this.dtaGridProveedor.Location = new System.Drawing.Point(12, 133);
            this.dtaGridProveedor.Name = "dtaGridProveedor";
            this.dtaGridProveedor.RowHeadersWidth = 51;
            this.dtaGridProveedor.RowTemplate.Height = 24;
            this.dtaGridProveedor.Size = new System.Drawing.Size(559, 603);
            this.dtaGridProveedor.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.cbConsulta4);
            this.groupBox1.Controls.Add(this.cbConsulta3);
            this.groupBox1.Controls.Add(this.cbConsulta2);
            this.groupBox1.Controls.Add(this.cbConsulta1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(448, 45);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Ejecutar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // cbConsulta4
            // 
            this.cbConsulta4.AutoSize = true;
            this.cbConsulta4.Location = new System.Drawing.Point(313, 45);
            this.cbConsulta4.Name = "cbConsulta4";
            this.cbConsulta4.Size = new System.Drawing.Size(129, 20);
            this.cbConsulta4.TabIndex = 3;
            this.cbConsulta4.Text = "numero_telefono";
            this.cbConsulta4.UseVisualStyleBackColor = true;
            // 
            // cbConsulta3
            // 
            this.cbConsulta3.AutoSize = true;
            this.cbConsulta3.Location = new System.Drawing.Point(183, 45);
            this.cbConsulta3.Name = "cbConsulta3";
            this.cbConsulta3.Size = new System.Drawing.Size(112, 20);
            this.cbConsulta3.TabIndex = 2;
            this.cbConsulta3.Text = "cod_producto";
            this.cbConsulta3.UseVisualStyleBackColor = true;
            // 
            // cbConsulta2
            // 
            this.cbConsulta2.AutoSize = true;
            this.cbConsulta2.Location = new System.Drawing.Point(110, 45);
            this.cbConsulta2.Name = "cbConsulta2";
            this.cbConsulta2.Size = new System.Drawing.Size(67, 20);
            this.cbConsulta2.TabIndex = 1;
            this.cbConsulta2.Text = "marca";
            this.cbConsulta2.UseVisualStyleBackColor = true;
            // 
            // cbConsulta1
            // 
            this.cbConsulta1.AutoSize = true;
            this.cbConsulta1.Location = new System.Drawing.Point(21, 44);
            this.cbConsulta1.Name = "cbConsulta1";
            this.cbConsulta1.Size = new System.Drawing.Size(71, 20);
            this.cbConsulta1.TabIndex = 0;
            this.cbConsulta1.Text = "codigo";
            this.cbConsulta1.UseVisualStyleBackColor = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Producto
            // 
            this.Producto.DataPropertyName = "Producto";
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // Numero_tel
            // 
            this.Numero_tel.DataPropertyName = "Numero_tel";
            this.Numero_tel.HeaderText = "Numero_tel";
            this.Numero_tel.MinimumWidth = 6;
            this.Numero_tel.Name = "Numero_tel";
            this.Numero_tel.Width = 125;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(CRUD.proveedor);
            // 
            // FormGridProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 765);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtaGridProveedor);
            this.Name = "FormGridProveedor";
            this.Text = "FormGridProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridProveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridProveedor;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.CheckBox cbConsulta4;
        private System.Windows.Forms.CheckBox cbConsulta3;
        private System.Windows.Forms.CheckBox cbConsulta2;
        private System.Windows.Forms.CheckBox cbConsulta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_tel;
    }
}