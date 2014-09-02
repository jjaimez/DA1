namespace GestionDeNegocio
{
    partial class GestionCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.documento = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.celular = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.tablaClientes = new System.Windows.Forms.TableLayoutPanel();
            this.nuevo = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 8;
            // 
            // documento
            // 
            this.documento.Enabled = false;
            this.documento.Location = new System.Drawing.Point(94, 407);
            this.documento.Name = "documento";
            this.documento.Size = new System.Drawing.Size(100, 20);
            this.documento.TabIndex = 9;
            // 
            // telefono
            // 
            this.telefono.Enabled = false;
            this.telefono.Location = new System.Drawing.Point(94, 430);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(100, 20);
            this.telefono.TabIndex = 10;
            // 
            // celular
            // 
            this.celular.Enabled = false;
            this.celular.Location = new System.Drawing.Point(94, 456);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(100, 20);
            this.celular.TabIndex = 11;
            this.celular.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(94, 485);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 12;
            // 
            // nombre
            // 
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(94, 380);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 13;
            // 
            // id
            // 
            this.id.Enabled = false;
            this.id.Location = new System.Drawing.Point(94, 353);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 14;
            // 
            // tablaClientes
            // 
            this.tablaClientes.ColumnCount = 6;
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablaClientes.Location = new System.Drawing.Point(15, 46);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.RowCount = 2;
            this.tablaClientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaClientes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablaClientes.Size = new System.Drawing.Size(597, 290);
            this.tablaClientes.TabIndex = 16;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(393, 353);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(67, 31);
            this.nuevo.TabIndex = 17;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // editar
            // 
            this.editar.Enabled = false;
            this.editar.Location = new System.Drawing.Point(393, 439);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(67, 31);
            this.editar.TabIndex = 18;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // guardar
            // 
            this.guardar.Enabled = false;
            this.guardar.Location = new System.Drawing.Point(393, 396);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(67, 31);
            this.guardar.TabIndex = 19;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Enabled = false;
            this.eliminar.Location = new System.Drawing.Point(393, 485);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(67, 31);
            this.eliminar.TabIndex = 20;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.tablaClientes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.email);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.documento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Gestion de Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox documento;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TableLayoutPanel tablaClientes;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button eliminar;
    }
}