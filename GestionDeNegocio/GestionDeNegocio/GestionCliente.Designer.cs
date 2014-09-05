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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.dgv_Buscar = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar)).BeginInit();
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
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(82, 6);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(186, 20);
            this.txt_Nombre.TabIndex = 8;
            this.txt_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(94, 407);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(94, 430);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // txtCelular
            // 
            this.txtCelular.Enabled = false;
            this.txtCelular.Location = new System.Drawing.Point(94, 456);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 11;
            this.txtCelular.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(94, 485);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(94, 380);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(94, 353);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
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
            // dgv_Buscar
            // 
            this.dgv_Buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Buscar.Location = new System.Drawing.Point(12, 50);
            this.dgv_Buscar.Name = "dgv_Buscar";
            this.dgv_Buscar.ReadOnly = true;
            this.dgv_Buscar.Size = new System.Drawing.Size(600, 286);
            this.dgv_Buscar.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::GestionDeNegocio.Properties.Resources.buscar;
            this.btnBuscar.Location = new System.Drawing.Point(290, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // GestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 541);
            this.Controls.Add(this.dgv_Buscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionCliente";
            this.Text = "Gestion de Cliente";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Buscar)).EndInit();
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
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgv_Buscar;
    }
}