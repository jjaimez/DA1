namespace GestionDeNegocio
{
    partial class AplicacionGui
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cliente = new System.Windows.Forms.Button();
            this.proveedor = new System.Windows.Forms.Button();
            this.articulo = new System.Windows.Forms.Button();
            this.venta = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.sinStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(26, 27);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(112, 23);
            this.cliente.TabIndex = 0;
            this.cliente.Text = "Gestion Cliente";
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click);
            // 
            // proveedor
            // 
            this.proveedor.Location = new System.Drawing.Point(26, 107);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(112, 23);
            this.proveedor.TabIndex = 1;
            this.proveedor.Text = "Gestion Proveedor";
            this.proveedor.UseVisualStyleBackColor = true;
            // 
            // articulo
            // 
            this.articulo.Location = new System.Drawing.Point(26, 68);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(112, 23);
            this.articulo.TabIndex = 2;
            this.articulo.Text = "Gestion Articulo";
            this.articulo.UseVisualStyleBackColor = true;
            this.articulo.Click += new System.EventHandler(this.articulo_Click);
            // 
            // venta
            // 
            this.venta.Location = new System.Drawing.Point(26, 153);
            this.venta.Name = "venta";
            this.venta.Size = new System.Drawing.Size(112, 23);
            this.venta.TabIndex = 3;
            this.venta.Text = "Realizar Venta";
            this.venta.UseVisualStyleBackColor = true;
            // 
            // compra
            // 
            this.compra.Location = new System.Drawing.Point(26, 197);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(112, 23);
            this.compra.TabIndex = 4;
            this.compra.Text = "Realizar Compra";
            this.compra.UseVisualStyleBackColor = true;
            // 
            // sinStock
            // 
            this.sinStock.Location = new System.Drawing.Point(26, 243);
            this.sinStock.Name = "sinStock";
            this.sinStock.Size = new System.Drawing.Size(112, 23);
            this.sinStock.TabIndex = 5;
            this.sinStock.Text = "Articulos sin stock";
            this.sinStock.UseVisualStyleBackColor = true;
            // 
            // AplicacionGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 321);
            this.Controls.Add(this.sinStock);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.venta);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.cliente);
            this.Name = "AplicacionGui";
            this.Text = "AplicacionGui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.Button proveedor;
        private System.Windows.Forms.Button articulo;
        private System.Windows.Forms.Button venta;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Button sinStock;
    }
}

