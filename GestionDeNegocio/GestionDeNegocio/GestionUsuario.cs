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
    public partial class GestionUsuario : Form
    {
        BDconexion bd = new BDconexion();

        public GestionUsuario()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtcontraseña.Text == "" || txtconfirmar.Text == "")
            {
                MessageBox.Show("Rellene Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (txtcontraseña.Text == txtconfirmar.Text)
                {
                    int resultado = bd.CrearCuentas(txtusuario, txtcontraseña);
                    if (resultado > 0)
                    {
                        //MessageBox.Show("Cuenta Creada con Exito");
                        MessageBox.Show("Ingreso de Datos Correctos", "Ingreso Exitoso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //MessageBox.Show("No se pudo Crear la Cuenta");
                        MessageBox.Show("Ingreso de Datos Incorrectos, Verifique por favor", "Error al Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El password es desigual", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
