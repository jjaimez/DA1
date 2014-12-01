using System;
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
using MySql.Data;
using MySql.Data.MySqlClient;
//---------------------------------------------

namespace GestionDeNegocio
{
    public class BDconexion
    {


        public SqlConnection cnn = new SqlConnection("Data Source=FABIOLA-PC\\SQLEXPRESS;Initial Catalog=gestionnegocio;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public DataSet ds = new DataSet();
        DataTable dt;
        SqlDataAdapter da;
        //MySqlDataReader dr;

        //----------------------------Crear un Nuevo Usuario en el Login-------------------------------
        public int CrearCuentas(TextBox txt3, TextBox txt4)//string pUsuario, string pContraseña)
        {
            int resultado = 0;
            cmd = new SqlCommand(string.Format("insert into login (nombre, pass) values ('{0}',('{1}'))", txt3.Text, txt4.Text), cnn);
            cnn.Open();

            resultado = cmd.ExecuteNonQuery();

            cnn.Close();

            return resultado;

        }

        //----------------------------Ventas-------------------------------
        //Ventas(txtId, txtCliente, txtFecha, txtTotal);
        public int Ventas(TextBox txt3, TextBox txt4, DateTimePicker txt5, TextBox txt6)//string pUsuario, string pContraseña)
        {
            int resultado = 0;
            String fecha = txt5.Value.ToShortDateString();
            cmd = new SqlCommand(string.Format("insert into ventas (id , cliente_id, fecha, monto) values ('{0}',('{1}'),('{2}'),('{3}'))", txt3.Text, txt4.Text, fecha, txt6.Text), cnn);
            cnn.Open();

            resultado = cmd.ExecuteNonQuery();

            cnn.Close();

            return resultado;

        }

        //----------------------------Compras-------------------------------
        //Ventas(txtId, txtCliente, txtFecha, txtTotal);
        public int Compras(TextBox txt3, TextBox txt4, TextBox txt5, DateTimePicker txt6)//string pUsuario, string pContraseña)
        {
            int resultado = 0;
            String fecha = txt6.Value.ToShortDateString();
            cmd = new SqlCommand(string.Format("insert into compras (id , monto, proveedor_id, fecha) values ('{0}',('{1}'),('{2}'),('{3}'))", txt3.Text, txt4.Text, txt5.Text, fecha), cnn);
            cnn.Open();

            resultado = cmd.ExecuteNonQuery();

            cnn.Close();

            return resultado;

        }

        //----------------------------Mostrar los datos del cliente------------------------------------

        public void mostrarClientes(DataGridView dv)
        {
            try
            {
                da = new SqlDataAdapter("Select id as id,nombre as nombre,telefono as telefono,celular as celular,email as email, documento as documento from clientes", cnn);
                dt = new DataTable();
                da.Fill(dt);//
                dv.DataSource = dt;//
            }
            catch (Exception ex)
            {
                MessageBox.Show("no datos cliente");
            }
        }

        //----------------------------Mostrar los datos del cliente realizarVenta------------------------------------

        public void mostrarClientes2(DataGridView dv)
        {
            try
            {
                da = new SqlDataAdapter("Select id as id,nombre as nombre,documento as documento from clientes", cnn);
                dt = new DataTable();
                da.Fill(dt);//
                dv.DataSource = dt;//
            }
            catch (Exception ex)
            {
                MessageBox.Show("no datos cliente");
            }
        }

        //----------------------------Mostrar los datos del Proveedor ------------------------------------

        public void mostrarProveedores(DataGridView dv)
        {
            try
            {
                da = new SqlDataAdapter("Select id as id,nombre as nombre,cuit as cuit,telefono as telefono,celular as celular, email as email from proveedors", cnn);
                dt = new DataTable();
                da.Fill(dt);//
                dv.DataSource = dt;//
            }
            catch (Exception ex)
            {
                MessageBox.Show("no datos Proveedor");
            }


        }

        //----------------------------Mostrar los datos del Articulo ------------------------------------

        public void mostrarArticulos(DataGridView dv)
        {
            try
            {
                da = new SqlDataAdapter("Select id as id,nombre as nombre,marca as marca,proveedor_id as proveedor_id,descripcion as descripcion, stock_actual as stock_actual, stock_minimo as stock_minimo, precio_compra as precio_compra, precio_venta as precio_venta from articulos", cnn);

                dt = new DataTable();
                da.Fill(dt);//
                dv.DataSource = dt;//
            }
            catch (Exception ex)
            {
                MessageBox.Show("no datos Proveedor");
            }
        }

        //----------------------------Mostrar los datos del Articulo Realizar Venta ------------------------------------

        public void mostrarArticulos2(DataGridView dv)
        {
            try
            {
                da = new SqlDataAdapter("Select id as id,nombre as nombre,marca as marca,descripcion as descripcion, precio_venta as precio_venta from articulos", cnn);

                dt = new DataTable();
                da.Fill(dt);//
                dv.DataSource = dt;//
            }
            catch (Exception ex)
            {
                MessageBox.Show("no datos Proveedor");
            }
        }
        //------------------------Datos del Cliente---------------------------------------

        public void insertarCliente(TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, TextBox txt7)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into clientes(id,nombre,telefono,celular,email, documento)values('" + txt3.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "')";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception m)
            {
                // MessageBox.Show("No se pudieron insertar los datos");
            }
        }

        //------------------------Datos del Proveedor---------------------------------------

        public void insertarProveedor(TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, TextBox txt7)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into proveedors(id, nombre,cuit,telefono,celular,email)values('" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "')";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception m)
            {
                // MessageBox.Show("No se pudieron insertar los datos");
            }
        }

        

        //------------------------Datos del Articulo---------------------------------------

        public void insertarArticulo(TextBox txt1, TextBox txt2, TextBox txt3, ComboBox txt4, TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8, TextBox txt9)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into articulos(id, nombre, marca, proveedor_id, descripcion, stock_actual, stock_minimo, precio_compra, precio_venta)values('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + txt8.Text + "','" + txt9.Text + "')";
                cmd.Connection = cnn;
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show("No se pudieron guardar los datos");
            }
        }

        //------------------------Datos del Articulo---------------------------------------

        

    }
}
