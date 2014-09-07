namespace GestionDeNegocio
{
    partial class Nuev_Dat_User
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
            this.txtconfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtconfirmar
            // 
            this.txtconfirmar.Location = new System.Drawing.Point(350, 103);
            this.txtconfirmar.Name = "txtconfirmar";
            this.txtconfirmar.Size = new System.Drawing.Size(127, 20);
            this.txtconfirmar.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Confirmar Contraseña:";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(360, 150);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(92, 34);
            this.btncancelar.TabIndex = 25;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(211, 150);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(92, 34);
            this.btnregistrar.TabIndex = 24;
            this.btnregistrar.Text = "Guardar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(350, 58);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(127, 20);
            this.txtcontraseña.TabIndex = 23;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(350, 20);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(127, 20);
            this.txtusuario.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestionDeNegocio.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Nuev_Dat_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 203);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtconfirmar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nuev_Dat_User";
            this.Text = "Crear Datos del Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtconfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}