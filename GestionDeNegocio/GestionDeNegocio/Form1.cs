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
    public partial class AplicacionGui : Form
    {

        Form2 gestionCliente; /* Gestion Cliente */
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
           gestionCliente = new Form2();
           gestionCliente.BringToFront();
           gestionCliente.Visible = true;
        }

        private void articulo_Click(object sender, EventArgs e)
        {
            gestionAticulo = new GestionArticulo();
            gestionAticulo.BringToFront();
            gestionAticulo.Visible = true;
        }
        
    }
        
}
