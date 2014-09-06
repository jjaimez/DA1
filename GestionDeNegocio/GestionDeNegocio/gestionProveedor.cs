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
        BDconexion bd = new BDconexion();

        public gestionProveedor()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtCiut.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
            }
            else
            {
                try
                {

                    bd.insertarProveedor(txtNombre, txtCiut, txtTelefono, txtCelular, txtEmail);

                    MessageBox.Show("Se insertaron correctamente los datos");
                    this.txtNombre.Text = "";
                    this.txtCiut.Text = "";
                    this.txtTelefono.Text = "";
                    this.txtCelular.Text = "";
                    this.txtEmail.Text = "";
                    this.txtNombre.Enabled = false;
                    this.txtCiut.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.txtCelular.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.btnGuardar.Enabled = false;

                }
                catch (Exception m)
                {
                    MessageBox.Show("No se pudieron insertar los datos");
                }
                bd.mostrarProveedores(dgv_Mostrar);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtCiut.Text = "";
            this.txtEmail.Text = "";
            this.txtCelular.Text = "";

            this.txtCiut.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtCelular.Enabled = true;
            this.txtEmail.Enabled = true;
            this.btnGuardar.Enabled = true;
        }

    
    }
}
