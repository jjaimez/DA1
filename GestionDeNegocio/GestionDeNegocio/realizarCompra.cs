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
    public partial class realizarCompra : Form
    {
        BDconexion bd = new BDconexion();
        public realizarCompra()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNom_KeyUp(object sender, KeyEventArgs e)
        {
            bd.cnn.Open();
            SqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from proveedors where nombre like('" + txtBusNom.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dvgTblProveedores.DataSource = dt;
            bd.cnn.Close();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dvgTblProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProveedor.Text = dvgTblProveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           /* bd.cnn.Open();
            SqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from articulos where id like('" + txtBusArt.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dvgTblArticulos.DataSource = dt;
            bd.cnn.Close();*/
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtArticulo.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrecio.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void realizarCompra_Load(object sender, EventArgs e)
        {
            bd.mostrarProveedores(dvgTblProveedores);
            bd.mostrarArticulos(dvgTblArticulos);

            //prueba a eliminar

            //agregamos una nueva fila al datatable
            /*DataTable dt = Datos();
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);

            //mostramos los datos en el datagriedview
            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dt;*/

            //mostramos el valor de 0 en la fila que agregamos
            //DataGridViewRow rowtotal = dgvCompra.Rows[dgvCompra.Rows.Count - 1];
            //rowtotal.Cells["Precio"].Value = 0;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCompra.Rows.Add(txtId.Text, txtProveedor.Text, txtFecha.Text, txtArticulo.Text, txtPrecio.Text);

            //Realizar Suma total de Precio
            double resul = dgvCompra.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Precio"].Value));

            //mostramos la suma en el textbox y en la fila que agregamos
            txtTotal.Text = Convert.ToString(resul);
            DataGridViewRow rowtotal = dgvCompra.Rows[dgvCompra.Rows.Count - 1];
            rowtotal.Cells["Precio"].Value = resul;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (txtId.Text == "" || txtTotal.Text == "" ||txtProveedor.Text == "" || txtFecha.Text == "")
            {
                MessageBox.Show("Rellene Todos los Campos", "Campos Vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Productos a comprar " + Environment.NewLine + Environment.NewLine + "Proveedor:   " + txtProveedor.Text + Environment.NewLine + "Fecha:   " + txtFecha.Text + Environment.NewLine + "Articulo:   " + txtArticulo.Text + Environment.NewLine + "Precio Total:   " + txtTotal.Text + Environment.NewLine + "Gracias Por su Compra!!");
                int resultado = bd.Compras(txtId, txtTotal, txtProveedor, txtFecha);
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
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
