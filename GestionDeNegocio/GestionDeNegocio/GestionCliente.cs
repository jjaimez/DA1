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

        BDconexion bd = new BDconexion();


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

              
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDocumento.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
            }
            else
            {
                try
                {

                    bd.insertarCliente(txtNombre, txtDocumento, txtTelefono, txtCelular, txtEmail);

                    MessageBox.Show("Se insertaron correctamente los datos");
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
                    this.btnGuardar.Enabled = false;

                }
                catch (Exception m)
                {
                    MessageBox.Show("No se pudieron insertar los datos");
                }
                bd.mostrarClientes(dgv_Mostrar);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
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
            this.btnGuardar.Enabled = true;
        }
    }
}
