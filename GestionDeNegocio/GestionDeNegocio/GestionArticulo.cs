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
    public partial class GestionArticulo : Form
    {
        BDconexion bd = new BDconexion();


        public GestionArticulo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtMarca.Text = "";
            this.cbProveedor.Text = "";
            this.txtDescripcion.Text = "";
            this.txtStockActual.Text = "";
            this.txtStockMinimo.Text = "";
            this.txtPrecioCompra.Text = "";
            this.txtPrecioVenta.Text = "";

            this.btnGuardar.Enabled = true;
        }

        private void dgv_Mostrar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Llenamos la información de la linea seleccionada en las
            // respectivas cajitas de texto
            txtId.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMarca.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbProveedor.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescripcion.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtStockActual.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStockMinimo.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtPrecioCompra.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPrecioVenta.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            bd.cnn.Open();
            MySqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from articulos where nombre like('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_Mostrar.DataSource = dt;
            bd.cnn.Close();
        }

        private void GestionArticulo_Load(object sender, EventArgs e)
        {
            bd.mostrarArticulos(dgv_Mostrar);

            try
            {
                bd.cnn.Open();

                MySqlCommand cn = new MySqlCommand("SELECT id FROM proveedors ORDER BY id ASC", bd.cnn);

                try
                {
                    MySqlDataReader dr = cn.ExecuteReader();
                    while (dr.Read())
                    {
                        cbProveedor.Items.Add(dr["id"]);
                    }
                    dr.Close();
                    dr.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bd.cnn.Open();
            string borra = "DELETE FROM articulos WHERE ID='" + txtId.Text + "'";
            MySqlCommand cmd = new MySqlCommand(borra, bd.cnn);
            cmd.ExecuteNonQuery();
            bd.cnn.Close();
            bd.mostrarArticulos(dgv_Mostrar);
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtMarca.Text = "";
            this.cbProveedor.Text = "";
            this.txtDescripcion.Text = "";
            this.txtStockActual.Text = "";
            this.txtStockMinimo.Text = "";
            this.txtPrecioCompra.Text = "";
            this.txtPrecioVenta.Text = "";

            MessageBox.Show("registro eliminado con exito");



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //realizamos la consulta de actualizar en el q se toma desde el ID ingresado por el texboxId y despues que se modifique se actualiza los datos 
                string Query = "update articulos set id='" + this.txtId.Text + "',nombre='" + this.txtNombre.Text
                    + "',marca='" + this.txtMarca.Text
                    + "',proveedor_id='" + this.cbProveedor.Text
                    + "',descripcion='" + this.txtDescripcion.Text
                    + "',stock_actual='" + this.txtStockActual.Text
                    + "',stock_minimo='" + this.txtStockMinimo.Text
                    + "',precio_compra='" + this.txtPrecioCompra.Text
                    + "',precio_venta='" + this.txtPrecioVenta.Text
                    + "' where id='" + this.txtId.Text + "';";

                MySqlCommand MyCommand2 = new MySqlCommand(Query, bd.cnn);
                MySqlDataReader MyReader2;
                bd.cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Registro modificado");
                while (MyReader2.Read())
                {
                }
                bd.cnn.Close();//
                bd.mostrarArticulos(dgv_Mostrar);//actualiza el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ;


            if (txtNombre.Text == "" || txtMarca.Text == "" || cbProveedor.Text == "" || txtDescripcion.Text == "" || txtStockActual.Text == "" || txtStockMinimo.Text == "" || txtPrecioCompra.Text == "" || txtPrecioVenta.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
            }
            else
            {
                try
                {

                    bd.insertarArticulo(txtNombre, txtMarca, cbProveedor, txtDescripcion, txtStockActual, txtStockMinimo, txtPrecioCompra, txtPrecioVenta);
                    bd.mostrarArticulos(dgv_Mostrar);
                    MessageBox.Show("Se insertaron correctamente los datos");



                }

                catch (Exception m)
                {
                    MessageBox.Show("No se pudieron insertar los datos");
                }
                //Application.Restart();
                this.txtNombre.Text = "";
                this.txtMarca.Text = "";
                this.cbProveedor.Text = "";
                this.txtDescripcion.Text = "";
                this.txtStockActual.Text = "";
                this.txtStockMinimo.Text = "";
                this.txtPrecioCompra.Text = "";
                this.txtPrecioVenta.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
