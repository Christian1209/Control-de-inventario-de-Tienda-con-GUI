namespace CRUD
{
    partial class FormGridCliente
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
            this.dtaGridCliente = new System.Windows.Forms.DataGridView();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.cbConsulta4 = new System.Windows.Forms.CheckBox();
            this.cbConsulta3 = new System.Windows.Forms.CheckBox();
            this.cbConsulta2 = new System.Windows.Forms.CheckBox();
            this.cbConsulta1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaGridCliente
            // 
            this.dtaGridCliente.AllowUserToOrderColumns = true;
            this.dtaGridCliente.AutoGenerateColumns = false;
            this.dtaGridCliente.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtaGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellidos,
            this.Numero_tel});
            this.dtaGridCliente.DataSource = this.clienteBindingSource;
            this.dtaGridCliente.Location = new System.Drawing.Point(12, 105);
            this.dtaGridCliente.Name = "dtaGridCliente";
            this.dtaGridCliente.RowHeadersWidth = 51;
            this.dtaGridCliente.RowTemplate.Height = 24;
            this.dtaGridCliente.Size = new System.Drawing.Size(724, 606);
            this.dtaGridCliente.TabIndex = 10;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(633, 35);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(76, 23);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // cbConsulta4
            // 
            this.cbConsulta4.AutoSize = true;
            this.cbConsulta4.Location = new System.Drawing.Point(488, 38);
            this.cbConsulta4.Name = "cbConsulta4";
            this.cbConsulta4.Size = new System.Drawing.Size(129, 20);
            this.cbConsulta4.TabIndex = 3;
            this.cbConsulta4.Text = "numero_telefono";
            this.cbConsulta4.UseVisualStyleBackColor = true;
            // 
            // cbConsulta3
            // 
            this.cbConsulta3.AutoSize = true;
            this.cbConsulta3.Location = new System.Drawing.Point(386, 38);
            this.cbConsulta3.Name = "cbConsulta3";
            this.cbConsulta3.Size = new System.Drawing.Size(85, 20);
            this.cbConsulta3.TabIndex = 2;
            this.cbConsulta3.Text = "apellidos";
            this.cbConsulta3.UseVisualStyleBackColor = true;
            // 
            // cbConsulta2
            // 
            this.cbConsulta2.AutoSize = true;
            this.cbConsulta2.Location = new System.Drawing.Point(296, 38);
            this.cbConsulta2.Name = "cbConsulta2";
            this.cbConsulta2.Size = new System.Drawing.Size(75, 20);
            this.cbConsulta2.TabIndex = 1;
            this.cbConsulta2.Text = "nombre";
            this.cbConsulta2.UseVisualStyleBackColor = true;
            // 
            // cbConsulta1
            // 
            this.cbConsulta1.AutoSize = true;
            this.cbConsulta1.Location = new System.Drawing.Point(210, 38);
            this.cbConsulta1.Name = "cbConsulta1";
            this.cbConsulta1.Size = new System.Drawing.Size(71, 20);
            this.cbConsulta1.TabIndex = 0;
            this.cbConsulta1.Text = "codigo";
            this.cbConsulta1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEjecutar);
            this.groupBox1.Controls.Add(this.cbConsulta4);
            this.groupBox1.Controls.Add(this.cbConsulta3);
            this.groupBox1.Controls.Add(this.cbConsulta2);
            this.groupBox1.Controls.Add(this.cbConsulta1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 87);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecciona los campos\r\n que quieres ver\r\n";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(CRUD.cliente);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 6;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 125;
            // 
            // Numero_tel
            // 
            this.Numero_tel.DataPropertyName = "Numero_tel";
            this.Numero_tel.HeaderText = "Numero_tel";
            this.Numero_tel.MinimumWidth = 6;
            this.Numero_tel.Name = "Numero_tel";
            this.Numero_tel.Width = 125;
            // 
            // FormGridCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 784);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtaGridCliente);
            this.Name = "FormGridCliente";
            this.Text = "FormGridCliente";
            this.Load += new System.EventHandler(this.FormGridCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaGridCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaGridCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.CheckBox cbConsulta4;
        private System.Windows.Forms.CheckBox cbConsulta3;
        private System.Windows.Forms.CheckBox cbConsulta2;
        private System.Windows.Forms.CheckBox cbConsulta1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_tel;
    }
}