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
//----------------------------------------------
//Librerias
using MySql.Data;
using MySql.Data.MySqlClient;
//---------------------------------------------

namespace GestionDeNegocio
{
    public partial class realizarVenta : Form
    {
        BDconexion bd = new BDconexion();

        public realizarVenta()
        {
            InitializeComponent();
        }

        private void txtNom_KeyUp(object sender, KeyEventArgs e)
        {
            bd.cnn.Open();
            MySqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where nombre like('" + txtBusNom.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dvgTblClientes.DataSource = dt;
            bd.cnn.Close();
        }

        private void dvgTblClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            /*txtId.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDocumento.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefono.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCelular.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[5].Value.ToString();*/
        }

        private void realizarVenta_Load(object sender, EventArgs e)
        {
            bd.mostrarClientes2(dvgTblClientes);
            bd.mostrarArticulos2(dvgTblArticulos);

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            bd.cnn.Open();
            MySqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from articulos where id like('" + txtBusArt.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dvgTblArticulos.DataSource = dt;
            bd.cnn.Close();
        }
    }
}
