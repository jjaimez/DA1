﻿using System;
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
    public partial class AplicacionGui : Form
    {

        GestionCliente gestionCliente; /* Gestion Cliente */
        GestionArticulo gestionAticulo;

        public AplicacionGui()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cliente_Click(object sender, EventArgs e)
        {
           gestionCliente = new GestionCliente();
           gestionCliente.BringToFront();
           gestionCliente.Visible = true;
        }

        private void articulo_Click(object sender, EventArgs e)
        {
            gestionAticulo = new GestionArticulo();
            gestionAticulo.BringToFront();
            gestionAticulo.Visible = true;
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dat_User datos_usuario = new Dat_User();
            datos_usuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Seguro que desea salir", "Sistema", MessageBoxButtons.YesNo))
            {
                this.Close();
            }
        }

        private void cliente_Click_1(object sender, EventArgs e)
        {
            GestionCliente gestionCliente = new GestionCliente();
            gestionCliente.BringToFront();
            gestionCliente.Visible = true;
        }

        private void articulo_Click_1(object sender, EventArgs e)
        {
            gestionAticulo = new GestionArticulo();
            gestionAticulo.BringToFront();
            gestionAticulo.Visible = true;
        }

        private void proveedor_Click(object sender, EventArgs e)
        {

        }

        private void venta_Click(object sender, EventArgs e)
        {

        }
        
    }
        
}