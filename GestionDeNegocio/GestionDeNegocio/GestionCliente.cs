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
    public partial class GestionCliente : Form
    {
        public GestionCliente()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        /* Habilito los campos para poder llenarlos */
        private void nuevo_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtDocumento.Text = "";
            this.txtEmail.Text = "";
            this.txtCelular.Text = "";
            this.txtNombre.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtDocumento.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtCelular.Enabled = true;
            this.guardar.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            /*gurdar en la base de datos*/
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtDocumento.Text = "";
            this.txtEmail.Text = "";
            this.txtCelular.Text = "";
            this.txtNombre.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtDocumento.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtCelular.Enabled = false;
            this.guardar.Enabled = false;

            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtNombre.Text.Trim();
            pCliente.Documento = txtDocumento.Text.Trim();
            pCliente.Telefono = txtTelefono.Text.Trim(); ;
            pCliente.Celular = txtCelular.Text.Trim();
            pCliente.Email = txtEmail.Text.Trim();

            int resultado = ClienteBD.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void editar_Click(object sender, EventArgs e)
        {
            this.nuevo.Enabled = false;
            this.txtNombre.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtDocumento.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtCelular.Enabled = true;
            this.guardar.Enabled = true;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            /* elimina el cliente seleccionado de la tabla*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tablaClientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgv_Buscar.DataSource = ClienteBD.Buscar(txtNombre.Text);
        }
    }
}
