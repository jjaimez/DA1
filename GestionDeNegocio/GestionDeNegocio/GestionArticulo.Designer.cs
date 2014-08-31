namespace GestionDeNegocio
{
    partial class GestionArticulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.marca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nuevo = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.stockMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.precioVenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.precioCompra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stockActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.proveedores = new System.Windows.Forms.ComboBox();
            this.codigo = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Descripcion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 11;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(124, 335);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 12;
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(124, 299);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 13;
            // 
            // marca
            // 
            this.marca.Enabled = false;
            this.marca.Location = new System.Drawing.Point(124, 401);
            this.marca.Name = "marca";
            this.marca.Size = new System.Drawing.Size(100, 20);
            this.marca.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Id";
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(482, 356);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 19;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // guardar
            // 
            this.guardar.Enabled = false;
            this.guardar.Location = new System.Drawing.Point(482, 385);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 20;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Enabled = false;
            this.eliminar.Location = new System.Drawing.Point(482, 414);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 21;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            // 
            // editar
            // 
            this.editar.Enabled = false;
            this.editar.Location = new System.Drawing.Point(482, 443);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 22;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // stockMinimo
            // 
            this.stockMinimo.Enabled = false;
            this.stockMinimo.Location = new System.Drawing.Point(337, 397);
            this.stockMinimo.Name = "stockMinimo";
            this.stockMinimo.Size = new System.Drawing.Size(100, 20);
            this.stockMinimo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Precio Venta";
            // 
            // precioVenta
            // 
            this.precioVenta.Enabled = false;
            this.precioVenta.Location = new System.Drawing.Point(337, 475);
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.Size = new System.Drawing.Size(100, 20);
            this.precioVenta.TabIndex = 26;
            this.precioVenta.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Precio Compra";
            // 
            // precioCompra
            // 
            this.precioCompra.Enabled = false;
            this.precioCompra.Location = new System.Drawing.Point(337, 437);
            this.precioCompra.Name = "precioCompra";
            this.precioCompra.Size = new System.Drawing.Size(100, 20);
            this.precioCompra.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Stock Actual";
            // 
            // stockActual
            // 
            this.stockActual.Enabled = false;
            this.stockActual.Location = new System.Drawing.Point(337, 361);
            this.stockActual.Name = "stockActual";
            this.stockActual.Size = new System.Drawing.Size(100, 20);
            this.stockActual.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Stock Minimo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Codigo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(256, 299);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Proveedor";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // proveedores
            // 
            this.proveedores.Enabled = false;
            this.proveedores.FormattingEnabled = true;
            this.proveedores.Location = new System.Drawing.Point(337, 291);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(246, 21);
            this.proveedores.TabIndex = 36;
            // 
            // codigo
            // 
            this.codigo.Enabled = false;
            this.codigo.Location = new System.Drawing.Point(124, 365);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 20);
            this.codigo.TabIndex = 33;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(81, 437);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(143, 78);
            this.descripcion.TabIndex = 37;
            this.descripcion.Text = "";
            // 
            // GestionArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 517);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.proveedores);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stockActual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.precioCompra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.precioVenta);
            this.Controls.Add(this.stockMinimo);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.marca);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionArticulo";
            this.Text = "GestionArticulo";
            this.Load += new System.EventHandler(this.GestionArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox marca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.TextBox stockMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox precioVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox precioCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stockActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox proveedores;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.RichTextBox descripcion;
    }
}