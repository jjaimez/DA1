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
        public MySqlConnection cnn = new MySqlConnection("Server=localhost;Uid=root;Pwd= root;Database=gestionnegocio;Port=3306");
        public MySqlCommand cmd = new MySqlCommand();
        public DataSet ds = new DataSet();

        //----------------------------Crear un Nuevo Usuario en el Login-------------------------------
        public int CrearCuentas(TextBox txt3, TextBox txt4)//string pUsuario, string pContraseña)
        {
            int resultado = 0;

            //MySqlConnection cn = new MySqlConnection("Server = localhost; Uid = root; Password = root; Database = gestionnegocio; Port = 3306");
            cmd = new MySqlCommand(string.Format("insert into login (nombre, pass) values ('{0}',('{1}'))", txt3, txt4), cnn);
            cnn.Open();

            resultado = cmd.ExecuteNonQuery();

            cnn.Close();

            return resultado;


            /*cnn.Open();
            cmd.CommandText = "Insert into clientes(nombre,telefono,celular,email, documento)values('" + txt3.Text + "','" + txt4.Text + "','" + txt5.Text + "','" + txt6.Text + "','" + txt7.Text + "')";
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            cnn.Close();*/

        }
        
        //----------------------------Mostrar los datos del cliente------------------------------------

        public void mostrarClientes(DataGridView dv)
        {
            cnn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select id as id,nombre as nombre,telefono as telefono,celular as celular,email as email, documento as documento from clientes", cnn);
            da.Fill(ds, "Clientes");
            dv.DataSource = ds.Tables[0];
            cnn.Close();
        }

        //----------------------------Mostrar los datos del Proveedor ------------------------------------

        public void mostrarProveedores(DataGridView dv)
        {
            cnn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select id as id,nombre as nombre,cuit as cuit,telefono as telefono,celular as celular, email as email from proveedors", cnn);
            da.Fill(ds, "Proveedores");
            dv.DataSource = ds.Tables[0];
            cnn.Close();
        }

        //----------------------------Mostrar los datos del Articulo ------------------------------------

        public void mostrarArticulo(DataGridView dv)
        {
            
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

        public void insertarArticulo(TextBox txt1, TextBox txt2, TextBox txt3, ComboBox txt4, TextBox txt5, TextBox txt6, TextBox txt7, TextBox txt8, TextBox txt9)
        {
            
        }
        //--------------------------------------------------------------
    }
}
