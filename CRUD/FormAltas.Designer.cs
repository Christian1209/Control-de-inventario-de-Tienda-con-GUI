namespace CRUD
{
    partial class FormAltas
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
            this.dtagridVenta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbConsulta6 = new System.Windows.Forms.CheckBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsulta5 = new System.Windows.Forms.CheckBox();
            this.cbConsulta4 = new System.Windows.Forms.CheckBox();
            this.cbConsulta3 = new System.Windows.Forms.CheckBox();
            this.cbConsulta2 = new System.Windows.Forms.CheckBox();
            this.cbConsulta1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.altaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtagridVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagridVenta
            // 
            this.dtagridVenta.AutoGenerateColumns = false;
            this.dtagridVenta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtagridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.producto,
            this.nombreProducto,
            this.cantidad,
            this.fecha,
            this.total});
            this.dtagridVenta.DataSource = this.altaBindingSource;
            this.dtagridVenta.Location = new System.Drawing.Point(324, 216);
            this.dtagridVenta.Name = "dtagridVenta";
            this.dtagridVenta.RowHeadersWidth = 51;
            this.dtagridVenta.RowTemplate.Height = 24;
            this.dtagridVenta.Size = new System.Drawing.Size(1061, 696);
            this.dtagridVenta.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbConsulta6);
            this.groupBox2.Controls.Add(this.btnConsulta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbConsulta5);
            this.groupBox2.Controls.Add(this.cbConsulta4);
            this.groupBox2.Controls.Add(this.cbConsulta3);
            this.groupBox2.Controls.Add(this.cbConsulta2);
            this.groupBox2.Controls.Add(this.cbConsulta1);
            this.groupBox2.Location = new System.Drawing.Point(394, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // cbConsulta6
            // 
            this.cbConsulta6.AutoSize = true;
            this.cbConsulta6.Location = new System.Drawing.Point(625, 43);
            this.cbConsulta6.Name = "cbConsulta6";
            this.cbConsulta6.Size = new System.Drawing.Size(54, 20);
            this.cbConsulta6.TabIndex = 6;
            this.cbConsulta6.Text = "total";
            this.cbConsulta6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbConsulta6.UseVisualStyleBackColor = true;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(747, 40);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 5;
            this.btnConsulta.Text = "Ejecutar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Historial de ingresos de mercancia";
            // 
            // cbConsulta5
            // 
            this.cbConsulta5.AutoSize = true;
            this.cbConsulta5.Location = new System.Drawing.Point(541, 43);
            this.cbConsulta5.Name = "cbConsulta5";
            this.cbConsulta5.Size = new System.Drawing.Size(62, 20);
            this.cbConsulta5.TabIndex = 4;
            this.cbConsulta5.Text = "fecha";
            this.cbConsulta5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbConsulta5.UseVisualStyleBackColor = true;
            // 
            // cbConsulta4
            // 
            this.cbConsulta4.AutoSize = true;
            this.cbConsulta4.Location = new System.Drawing.Point(417, 43);
            this.cbConsulta4.Name = "cbConsulta4";
            this.cbConsulta4.Size = new System.Drawing.Size(81, 20);
            this.cbConsulta4.TabIndex = 3;
            this.cbConsulta4.Text = "cantidad";
            this.cbConsulta4.UseVisualStyleBackColor = true;
            // 
            // cbConsulta3
            // 
            this.cbConsulta3.AutoSize = true;
            this.cbConsulta3.Location = new System.Drawing.Point(239, 43);
            this.cbConsulta3.Name = "cbConsulta3";
            this.cbConsulta3.Size = new System.Drawing.Size(128, 20);
            this.cbConsulta3.TabIndex = 2;
            this.cbConsulta3.Text = "nombreproducto";
            this.cbConsulta3.UseVisualStyleBackColor = true;
            // 
            // cbConsulta2
            // 
            this.cbConsulta2.AutoSize = true;
            this.cbConsulta2.Location = new System.Drawing.Point(107, 43);
            this.cbConsulta2.Name = "cbConsulta2";
            this.cbConsulta2.Size = new System.Drawing.Size(93, 20);
            this.cbConsulta2.TabIndex = 1;
            this.cbConsulta2.Text = "idproducto";
            this.cbConsulta2.UseVisualStyleBackColor = true;
            this.cbConsulta2.CheckedChanged += new System.EventHandler(this.cbConsulta2_CheckedChanged);
            // 
            // cbConsulta1
            // 
            this.cbConsulta1.AutoSize = true;
            this.cbConsulta1.Location = new System.Drawing.Point(18, 42);
            this.cbConsulta1.Name = "cbConsulta1";
            this.cbConsulta1.Size = new System.Drawing.Size(40, 20);
            this.cbConsulta1.TabIndex = 0;
            this.cbConsulta1.Text = "id";
            this.cbConsulta1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 467);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBorrar.Location = new System.Drawing.Point(36, 173);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(98, 48);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(37, 127);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Borrar ingresos";
            // 
            // altaBindingSource
            // 
            this.altaBindingSource.DataSource = typeof(CRUD.alta);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "Producto";
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 6;
            this.producto.Name = "producto";
            this.producto.Width = 125;
            // 
            // nombreProducto
            // 
            this.nombreProducto.DataPropertyName = "Nombreproducto";
            this.nombreProducto.HeaderText = "Nombreproducto";
            this.nombreProducto.MinimumWidth = 6;
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "Cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // total
            // 
            this.total.DataPropertyName = "Total";
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // FormAltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 959);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtagridVenta);
            this.Name = "FormAltas";
            this.Text = "FormAltas";
            this.Load += new System.EventHandler(this.FormAltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtagridVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagridVenta;
        private System.Windows.Forms.BindingSource altaBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbConsulta6;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbConsulta5;
        private System.Windows.Forms.CheckBox cbConsulta4;
        private System.Windows.Forms.CheckBox cbConsulta3;
        private System.Windows.Forms.CheckBox cbConsulta2;
        private System.Windows.Forms.CheckBox cbConsulta1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}