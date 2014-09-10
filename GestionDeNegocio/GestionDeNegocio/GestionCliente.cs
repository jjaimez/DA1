using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------------------------
//Formulario
using System.Data;
//----------------------------------------------
//Librerias
using MySql.Data;
using MySql.Data.MySqlClient;
//---------------------------------------------

namespace GestionDeNegocio
{
    public partial class GestionCliente : Form
    {

        BDconexion bd = new BDconexion();
        string consulta;
        DataTable dat;
        MySqlCommand query;

        public GestionCliente()
        {
            consulta = "";
            InitializeComponent();
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
                    bd.mostrarClientes(dgv_Mostrar);
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
                //Application.Restart();
                
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
            this.txtId.Enabled = true;
            this.txtNombre.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.txtDocumento.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtCelular.Enabled = true;
            this.btnGuardar.Enabled = true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
           
        }

        private void GestionCliente_Load(object sender, EventArgs e)
        {
            bd.mostrarClientes(dgv_Mostrar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bd.cnn.Open();
            string borra = "DELETE FROM CLIENTES WHERE ID='" + txtId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(borra, bd.cnn);
            cmd.ExecuteNonQuery();
            bd.cnn.Close();
            bd.mostrarClientes(dgv_Mostrar);
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtDocumento.Text = "";
            this.txtTelefono.Text = "";
            this.txtCelular.Text = "";
            this.txtEmail.Text = "";
            MessageBox.Show("registro eliminado con exito");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            query = new MySqlCommand("update clientes set nombre=" + txtNombre.Text
                + ", documento=\"" + txtDocumento.Text
                + "\", telefono=\"" + txtTelefono.Text
                + "\", celular=\"" + txtCelular.Text
                + "\", email=\"" + txtEmail.Text
                + "\" where cli=" + dgv_Mostrar.Rows[dgv_Mostrar.SelectedRows[0].Index].Cells[0].Value.ToString(), bd.cnn);
                query.ExecuteNonQuery();
                bd.mostrarClientes(dgv_Mostrar);
            
        }
        
        private void dgv_Mostrar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Llenamos la información de la linea seleccionada en las
            // respectivas cajitas de texto
            txtId.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDocumento.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefono.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCelular.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

      
    }
}
