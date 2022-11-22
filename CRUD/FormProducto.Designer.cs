namespace CRUD
{
    partial class FormProducto
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
            this.txtTipoDeDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtColumna = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarColumna = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnEliminarTabla = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCoste = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gbTablas = new System.Windows.Forms.GroupBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbProducto.SuspendLayout();
            this.gbTablas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTipoDeDato
            // 
            this.txtTipoDeDato.Location = new System.Drawing.Point(192, 163);
            this.txtTipoDeDato.Name = "txtTipoDeDato";
            this.txtTipoDeDato.Size = new System.Drawing.Size(100, 22);
            this.txtTipoDeDato.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tipo de dato";
            // 
            // txtColumna
            // 
            this.txtColumna.Location = new System.Drawing.Point(192, 118);
            this.txtColumna.Name = "txtColumna";
            this.txtColumna.Size = new System.Drawing.Size(100, 22);
            this.txtColumna.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Columna a agregar";
            // 
            // btnAgregarColumna
            // 
            this.btnAgregarColumna.Location = new System.Drawing.Point(39, 237);
            this.btnAgregarColumna.Name = "btnAgregarColumna";
            this.btnAgregarColumna.Size = new System.Drawing.Size(75, 41);
            this.btnAgregarColumna.TabIndex = 21;
            this.btnAgregarColumna.Text = "Agregar Columna";
            this.btnAgregarColumna.UseVisualStyleBackColor = true;
            this.btnAgregarColumna.Click += new System.EventHandler(this.btnAgregarColumna_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Manejo de tablas.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Tabla: ";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(192, 81);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(100, 22);
            this.txtTabla.TabIndex = 17;
            // 
            // btnEliminarTabla
            // 
            this.btnEliminarTabla.Location = new System.Drawing.Point(181, 237);
            this.btnEliminarTabla.Name = "btnEliminarTabla";
            this.btnEliminarTabla.Size = new System.Drawing.Size(75, 41);
            this.btnEliminarTabla.TabIndex = 16;
            this.btnEliminarTabla.Text = "Eliminar";
            this.btnEliminarTabla.UseVisualStyleBackColor = true;
            this.btnEliminarTabla.Click += new System.EventHandler(this.btnEliminarTabla_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(309, 322);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(206, 322);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(113, 322);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 12;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(23, 322);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(365, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 27);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(113, 140);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 50);
            this.txtDescripcion.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(113, 238);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(230, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(113, 206);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(230, 22);
            this.txtExistencia.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Existencias: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio Publico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 55);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(230, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 46);
            this.label10.MinimumSize = new System.Drawing.Size(5, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 53);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código: \r\n (AI, 0 para insertar)";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.label12);
            this.gbProducto.Controls.Add(this.txtCoste);
            this.gbProducto.Controls.Add(this.label11);
            this.gbProducto.Controls.Add(this.label3);
            this.gbProducto.Controls.Add(this.btnLimpiar);
            this.gbProducto.Controls.Add(this.btnEliminar);
            this.gbProducto.Controls.Add(this.btnActualizar);
            this.gbProducto.Controls.Add(this.btnGuardar);
            this.gbProducto.Controls.Add(this.btnBuscar);
            this.gbProducto.Controls.Add(this.txtDescripcion);
            this.gbProducto.Controls.Add(this.txtNombre);
            this.gbProducto.Controls.Add(this.txtPrecio);
            this.gbProducto.Controls.Add(this.txtExistencia);
            this.gbProducto.Controls.Add(this.label6);
            this.gbProducto.Controls.Add(this.label7);
            this.gbProducto.Controls.Add(this.label8);
            this.gbProducto.Controls.Add(this.label9);
            this.gbProducto.Controls.Add(this.txtCodigo);
            this.gbProducto.Controls.Add(this.label10);
            this.gbProducto.Location = new System.Drawing.Point(22, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(442, 370);
            this.gbProducto.TabIndex = 0;
            this.gbProducto.TabStop = false;
            this.gbProducto.Enter += new System.EventHandler(this.gbProducto_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Coste";
            // 
            // txtCoste
            // 
            this.txtCoste.Location = new System.Drawing.Point(113, 276);
            this.txtCoste.Name = "txtCoste";
            this.txtCoste.Size = new System.Drawing.Size(230, 22);
            this.txtCoste.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(262, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Puedes buscar por codigo y por referencia";
            // 
            // gbTablas
            // 
            this.gbTablas.Controls.Add(this.label5);
            this.gbTablas.Controls.Add(this.txtTipoDeDato);
            this.gbTablas.Controls.Add(this.txtColumna);
            this.gbTablas.Controls.Add(this.btnEliminarTabla);
            this.gbTablas.Controls.Add(this.btnAgregarColumna);
            this.gbTablas.Controls.Add(this.label4);
            this.gbTablas.Controls.Add(this.label2);
            this.gbTablas.Controls.Add(this.label1);
            this.gbTablas.Controls.Add(this.txtTabla);
            this.gbTablas.Location = new System.Drawing.Point(22, 388);
            this.gbTablas.Name = "gbTablas";
            this.gbTablas.Size = new System.Drawing.Size(357, 288);
            this.gbTablas.TabIndex = 26;
            this.gbTablas.TabStop = false;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CRUD.producto);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 711);
            this.Controls.Add(this.gbTablas);
            this.Controls.Add(this.gbProducto);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbTablas.ResumeLayout(false);
            this.gbTablas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox txtTipoDeDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColumna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarColumna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnEliminarTabla;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.GroupBox gbTablas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCoste;
    }
}