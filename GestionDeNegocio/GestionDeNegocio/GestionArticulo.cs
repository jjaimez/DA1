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
            this.telefono.Text = "";
            this.precioVenta.Text = "";
            this.precioCompra.Text = "";
            this.stockActual.Text = "";
            this.stockMinimo.Text = "";
            this.cuit.Text = "";
            this.codigo.Text = "";
            this.email.Text = "";
            this.celular.Text = "";
            this.nombre.Enabled = true;
            this.telefono.Enabled = true;   
            this.email.Enabled = true;
            this.celular.Enabled = true;
            this.guardar.Enabled = true;
             this.precioVenta.Enabled = true;
            this.precioCompra.Enabled = true;
            this.stockActual.Enabled = true;
            this.stockMinimo.Enabled = true;
            this.cuit.Enabled = true;
            this.codigo.Enabled = true;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /* guardar articulo*/
            this.nombre.Enabled = false;
            this.telefono.Enabled = false;
            this.email.Enabled = false;
            this.celular.Enabled = false;
            this.guardar.Enabled = false;
            this.precioVenta.Enabled = false;
            this.precioCompra.Enabled = false;
            this.stockActual.Enabled = false;
            this.stockMinimo.Enabled = false;
            this.cuit.Enabled = false;
            this.codigo.Enabled = false;
            this.guardar.Enabled = false;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.nombre.Enabled = true;
            this.telefono.Enabled = true;
            this.email.Enabled = true;
            this.celular.Enabled = true;
            this.guardar.Enabled = true;
            this.precioVenta.Enabled = true;
            this.precioCompra.Enabled = true;
            this.stockActual.Enabled = true;
            this.stockMinimo.Enabled = true;
            this.cuit.Enabled = true;
            this.codigo.Enabled = true;
            this.nuevo.Enabled = false;
            this.guardar.Enabled = true;
        }
    }
}
