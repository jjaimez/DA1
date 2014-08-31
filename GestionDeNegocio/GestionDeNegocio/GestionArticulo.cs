using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeNegocio
{
    public partial class GestionArticulo : Form
    {
        public GestionArticulo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GestionArticulo_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.nombre.Text = "";
            this.marca.Text = "";
            this.precioVenta.Text = "";
            this.precioCompra.Text = "";
            this.stockActual.Text = "";
            this.stockMinimo.Text = "";
            this.codigo.Text = "";
            this.descripcion.Text = "";
            this.nombre.Enabled = true;
            this.marca.Enabled = true;   
            this.descripcion.Enabled = true;
            this.guardar.Enabled = true;
             this.precioVenta.Enabled = true;
            this.precioCompra.Enabled = true;
            this.stockActual.Enabled = true;
            this.stockMinimo.Enabled = true;
            this.codigo.Enabled = true;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /* guardar articulo*/
            this.nombre.Enabled = false;
            this.marca.Enabled = false;
            this.descripcion.Enabled = false;
            this.guardar.Enabled = false;
            this.precioVenta.Enabled = false;
            this.precioCompra.Enabled = false;
            this.stockActual.Enabled = false;
            this.stockMinimo.Enabled = false;
            this.codigo.Enabled = false;
            this.guardar.Enabled = false;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.nombre.Enabled = true;
            this.marca.Enabled = true;
            this.descripcion.Enabled = true;
            this.guardar.Enabled = true;
            this.precioVenta.Enabled = true;
            this.precioCompra.Enabled = true;
            this.stockActual.Enabled = true;
            this.stockMinimo.Enabled = true;
            this.codigo.Enabled = true;
            this.nuevo.Enabled = false;
            this.guardar.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
