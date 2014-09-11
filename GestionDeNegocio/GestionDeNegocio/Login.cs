using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace GestionDeNegocio
{
    public partial class Login : Form
    {
        BDconexion bd = new BDconexion();
        
        MySqlCommand cmd = new MySqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            bd.cnn.Open();
            cmd.Connection = bd.cnn;

            try
            {
                cmd.CommandText = "select count(*) from login where nombre = '" + txtuser.Text + "' and pass = '" + txtpass.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());

                if (valor == 1)
                {

                    MessageBox.Show("Bienvenido, Ingreso de Datos Correctos", "Ingreso Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AplicacionGui apli = new AplicacionGui();
                    apli.Show();
                }
                else

                    MessageBox.Show("ingreso de datos incorrectos, verifique por favor",
                    "error al ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblmensaje.Text = "Error Siguiente" + ex;
            }
            bd.cnn.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

    