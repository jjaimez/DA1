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
            txtId.Text = dvgTblClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCliente.Text = dvgTblClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDocumento.Text = dvgTblClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            /**/
        }

        private void realizarVenta_Load(object sender, EventArgs e)
        {
            bd.mostrarClientes2(dvgTblClientes);
            bd.mostrarArticulos2(dvgTblArticulos);

            //prueba a eliminar

            //agregamos una nueva fila al datatable
            /*DataTable dt = Datos();
            DataRow row = dt.NewRow();
            dt.Rows.Add(row);

            //mostramos los datos en el datagriedview
            dgvCompra.AutoGenerateColumns = false;
            dgvCompra.DataSource = dt;*/

            //mostramos el valor de 0 en la fila que agregamos
            DataGridViewRow rowtotal = dgvCompra.Rows[dgvCompra.Rows.Count - 1];
            rowtotal.Cells["Precio"].Value = 0;

        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarca.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescripcion.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrecio.Text = dvgTblArticulos.Rows[e.RowIndex].Cells[4].Value.ToString();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvCompra.Rows.Add(txtCliente.Text, txtDocumento.Text, txtNombre.Text, txtMarca.Text, txtDescripcion.Text, txtFecha.Text, txtPrecio.Text);
            
            //Realizar Suma total de Precio
            double resul = dgvCompra.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDouble(x.Cells["Precio"].Value));

            //mostramos la suma en el textbox y en la fila que agregamos
            txttotal.Text = Convert.ToString(resul);
            DataGridViewRow rowtotal = dgvCompra.Rows[dgvCompra.Rows.Count - 1];
            rowtotal.Cells["Precio"].Value = resul;
        }

        private void dvgTblClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txttotal_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        //Prueba
        /*
        private DataTable Datos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Cliente");
            dt.Columns.Add("Documento");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Marca");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Precio");

            DataRow row = dt.NewRow();
            row["Cliente"] = 1;
            row["Documento"] = 321;
            row["Nombre"] = "Arroz";
            row["Marca"] = 1;
            row["Descripcion"] = 1;
            row["Fecha"] = 1;
            row["Precio"] = 50.00;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Cliente"] = 2;
            row["Documento"] = 3241;
            row["Nombre"] = "Pollo";
            row["Marca"] = 1;
            row["Descripcion"] = 1;
            row["Fecha"] = 1;
            row["Precio"] = 75.25;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Cliente"] = 3;
            row["Documento"] = 7661;
            row["Nombre"] = "Frijoles";
            row["Marca"] = 1;
            row["Descripcion"] = 1;
            row["Fecha"] = 1;
            row["Precio"] = 60.25;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row["Cliente"] = 4;
            row["Documento"] = 9871;
            row["Nombre"] = "Leche";
            row["Marca"] = 1;
            row["Descripcion"] = 1;
            row["Fecha"] = 1;
            row["Precio"] = 45.25;
            dt.Rows.Add(row);

            return dt;
        }*/

        private void btnBorrarArtSel_Click(object sender, EventArgs e)
        {
            /*bd.cnn.Open();
            string borra = "DELETE FROM articulos WHERE ID='" + txtId.Text + "'";// a q tabla pertecene
            MySqlCommand cmd = new MySqlCommand(borra, bd.cnn);
            cmd.ExecuteNonQuery();
            bd.cnn.Close();
            bd.mostrarArticulos(dgvCompra);
            this.txtId.Text = "";
            this.txtCliente.Text = "";
            this.txtDocumento.Text = "";
            this.txtNombre.Text = "";
            this.txtMarca.Text = "";
            this.txtDescripcion.Text = "";
            this.txtFecha.Text = "";
            this.txtPrecio.Text = "";

            MessageBox.Show("registro eliminado con exito");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtCliente.Text = "";
            this.txtDocumento.Text = "";
            this.txtNombre.Text = "";
            this.txtMarca.Text = "";
            this.txtDescripcion.Text = "";
            this.txtFecha.Text = "";
            this.txtPrecio.Text = "";
        }




        
    }
}
