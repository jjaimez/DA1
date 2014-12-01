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
    public partial class Login : Form
    {

        int i = 0;
        BDconexion bd = new BDconexion();
        SqlCommand cmd = new SqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            bd.cnn.Open();
            cmd.Connection = bd.cnn;

            try
            {
                cmd.CommandText = "select count(*) from login where nombre = '" + txtuser.Text + "' and pass = '" + txtpass.Text + "'";
                int valor = int.Parse(cmd.ExecuteScalar().ToString());

                AplicacionGui apli = new AplicacionGui();
                while (i < 3)
                {
                    i++;
                    if (valor == 1)
                    {
                        MessageBox.Show("Bienvenido, Ingreso de Datos Correctos", "Ingreso Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        apli.Show();
                        this.Hide();
                        i = 0;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Ingreso de Datos Incorrectos \n  Le quedan " + (3 - i) + " intentos", "Error al Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtuser.Text = "";
                        txtpass.Text = "";
                        if (i == 3)
                        {
                            MessageBox.Show("Lo Sentimos Usted Excedio 3 Intentos Permitidos \n El PROGRAMA SE CERRARA...", "Contraseña Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Close();
                        }
                        break;
                    }
                }
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

    