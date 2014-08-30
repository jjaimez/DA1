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
    public partial class gestionProveedor : Form
    {
        public gestionProveedor()
        {
            InitializeComponent();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.nombre.Text = "";
            this.telefono.Text = "";
            this.documento.Text = "";
            this.email.Text = "";
            this.celular.Text = "";
            this.nombre.Enabled = true;
            this.telefono.Enabled = true;
            this.ciut.Enabled = true;
            this.email.Enabled = true;
            this.celular.Enabled = true;
            this.guardar.Enabled = true;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /*gurdar en la base de datos*/
            this.nombre.Text = "";
            this.telefono.Text = "";
            this.documento.Text = "";
            this.email.Text = "";
            this.celular.Text = "";
            this.nombre.Enabled = false;
            this.telefono.Enabled = false;
            this.ciut.Enabled = false;
            this.email.Enabled = false;
            this.celular.Enabled = false;
            this.guardar.Enabled = false;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.nuevo.Enabled = false;
            this.nombre.Enabled = true;
            this.telefono.Enabled = true;
            this.documento.Enabled = true;
            this.email.Enabled = true;
            this.celular.Enabled = true;
            this.guardar.Enabled = true;
        }

    
    }
}
