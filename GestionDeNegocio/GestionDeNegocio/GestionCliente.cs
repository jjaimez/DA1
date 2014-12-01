using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------------------
//Formulario
using System.Data;
using System.Data.SqlClient;
//----------------------------------------------
//Librerias
//--------------------------------------------

namespace GestionDeNegocio
{
    public partial class GestionCliente : Form
    {

        BDconexion bd = new BDconexion();
        
        Negocio.Class1 obj = new Negocio.Class1();

        public GestionCliente()
        {
            
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "" || txtDocumento.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
            }
            else
            {
                try
                {
                    obj.guardarCliente(int.Parse(txtId.Text), txtNombre.Text, txtDocumento.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text);
                    MessageBox.Show("Guardado exitosamente!");
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString());
                }
                //Application.Restart();
                this.txtNombre.Text = "";
                this.txtTelefono.Text = "";
                this.txtDocumento.Text = "";
                this.txtEmail.Text = "";
                this.txtCelular.Text = "";
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtDocumento.Text = "";
            this.txtEmail.Text = "";
            this.txtCelular.Text = "";
           
            this.btnGuardar.Enabled = true;
        }

        

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            try 
            {
                obj.mostrarCliente(cb_buscar);
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("alerta", "desea eliminar ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                obj.eliminar(lista.SelectedItem.ToString());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                obj.modificar(txtNombre.Text, txtDocumento.Text, txtTelefono.Text, txtCelular.Text, txtEmail.Text, cb_buscar.Text);
                MessageBox.Show("modificado exitosamente");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
        
        private void dgv_Mostrar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txt_Buscar_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Items.Clear();
                obj.mostrarCliente(lista);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                obj.cargar(cb_buscar.Text, txtNombre, txtDocumento, txtTelefono, txtCelular, txtEmail);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

      
    }
}
