﻿namespace GestionDeNegocio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.exExcel = new System.Windows.Forms.Button();
            this.compra = new System.Windows.Forms.Button();
            this.venta = new System.Windows.Forms.Button();
            this.articulo = new System.Windows.Forms.Button();
            this.proveedor = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarDatosToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos Usuario";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.salirToolStripMenuItem1.Text = "Salir ";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::GestionDeNegocio.Properties.Resources.stock;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 601);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 88);
            this.button1.TabIndex = 14;
            this.button1.Text = "Sin Stock";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exExcel
            // 
            this.exExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exExcel.Image = global::GestionDeNegocio.Properties.Resources.report;
            this.exExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exExcel.Location = new System.Drawing.Point(12, 507);
            this.exExcel.Name = "exExcel";
            this.exExcel.Size = new System.Drawing.Size(106, 88);
            this.exExcel.TabIndex = 12;
            this.exExcel.Text = "Reportes";
            this.exExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exExcel.UseVisualStyleBackColor = true;
            this.exExcel.Click += new System.EventHandler(this.sinStock_Click);
            // 
            // compra
            // 
            this.compra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compra.Image = global::GestionDeNegocio.Properties.Resources.compra;
            this.compra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.compra.Location = new System.Drawing.Point(12, 413);
            this.compra.Name = "compra";
            this.compra.Size = new System.Drawing.Size(106, 88);
            this.compra.TabIndex = 11;
            this.compra.Text = "Realizar Compra";
            this.compra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.compra.UseVisualStyleBackColor = true;
            this.compra.Click += new System.EventHandler(this.compra_Click);
            // 
            // venta
            // 
            this.venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta.Image = global::GestionDeNegocio.Properties.Resources.ventas;
            this.venta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.venta.Location = new System.Drawing.Point(12, 319);
            this.venta.Name = "venta";
            this.venta.Size = new System.Drawing.Size(106, 88);
            this.venta.TabIndex = 10;
            this.venta.Text = "Realizar Venta";
            this.venta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.venta.UseVisualStyleBackColor = true;
            this.venta.Click += new System.EventHandler(this.venta_Click);
            // 
            // articulo
            // 
            this.articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulo.Image = global::GestionDeNegocio.Properties.Resources.articuloo;
            this.articulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.articulo.Location = new System.Drawing.Point(12, 131);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(106, 88);
            this.articulo.TabIndex = 9;
            this.articulo.Text = "Gestion Articulo";
            this.articulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.articulo.UseVisualStyleBackColor = true;
            this.articulo.Click += new System.EventHandler(this.articulo_Click_1);
            // 
            // proveedor
            // 
            this.proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedor.Image = global::GestionDeNegocio.Properties.Resources.proveedor;
            this.proveedor.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.proveedor.Location = new System.Drawing.Point(12, 225);
            this.proveedor.Name = "proveedor";
            this.proveedor.Size = new System.Drawing.Size(106, 88);
            this.proveedor.TabIndex = 8;
            this.proveedor.Text = "Gestion Proveedor";
            this.proveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.proveedor.UseVisualStyleBackColor = true;
            this.proveedor.Click += new System.EventHandler(this.proveedor_Click);
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Image = global::GestionDeNegocio.Properties.Resources.cliente;
            this.cliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cliente.Location = new System.Drawing.Point(12, 37);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(106, 88);
            this.cliente.TabIndex = 7;
            this.cliente.Text = "Gestion Cliente";
            this.cliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cliente.UseVisualStyleBackColor = true;
            this.cliente.Click += new System.EventHandler(this.cliente_Click_1);
            // 
            // AplicacionGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(801, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exExcel);
            this.Controls.Add(this.compra);
            this.Controls.Add(this.venta);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.proveedor);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AplicacionGui";
            this.Text = "AplicacionGui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exExcel;
        private System.Windows.Forms.Button compra;
        private System.Windows.Forms.Button venta;
        private System.Windows.Forms.Button articulo;
        private System.Windows.Forms.Button proveedor;
        private System.Windows.Forms.Button cliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.Button button1;

    }
}

