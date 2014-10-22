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
    public class BDconexion
    {


        public MySqlConnection cnn = new MySqlConnection("Server=localhost;Uid=root;Pwd=root;Database=gestionnegocio;Port=3306");
        public MySqlCommand cmd = new MySqlCommand();
        public DataSet ds = new DataSet();
        DataTable dt;
        MySqlDataAdapter da;
        //MySqlDataReader dr;

        //----------------------------Crear un Nuevo Usuario en el Login-------------------------------
        public int CrearCuentas(TextBox txt3, TextBox txt4)//string pUsuario, string pContraseña)
        {
            int resultado = 0;
            cmd = new MySqlCommand(string.Format("insert into login (nombre, pass) values ('{0}',('{1}'))", txt3.Text, txt4.Text), cnn);
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
                da = new MySqlDataAdapter("Select id as id,nombre as nombre,telefono as telefono,celular as celular,email as email, documento as documento from clientes", cnn);
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
                da = new MySqlDataAdapter("Select id as id,nombre as nombre,documento as documento from clientes", cnn);
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
                da = new MySqlDataAdapter("Select id as id,nombre as nombre,cuit as cuit,telefono as telefono,celular as celular, email as email from proveedors", cnn);
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
                da = new MySqlDataAdapter("Select id as id,nombre as nombre,marca as marca,proveedor_id as proveedor_id,descripcion as descripcion, stock_actual as stock_actual, stock_minimo as stock_minimo, precio_compra as precio_compra, precio_venta as precio_venta from articulos", cnn);

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
                da = new MySqlDataAdapter("Select id as id,nombre as nombre,marca as marca,descripcion as descripcion from articulos", cnn);

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

        public void insertarCliente(TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, TextBox txt7)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into clientes(nombre,telefono,celular,email, documento)values('" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "')";
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

        public void insertarProveedor(TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, TextBox txt7)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into proveedors(nombre,cuit,telefono,celular,email)values('" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "')";
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

        public void insertarArticulo(TextBox txt1, TextBox txt2, ComboBox txt3, TextBox txt4, TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8)
        {
            try
            {
                cnn.Open();
                cmd.CommandText = "Insert into articulos(nombre, marca, proveedor_id, descripcion, stock_actual, stock_minimo, precio_compra, precio_venta)values('" + txt1.Text + "','" + txt2.Text + "','" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "','" + txt8.Text + "')";
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
