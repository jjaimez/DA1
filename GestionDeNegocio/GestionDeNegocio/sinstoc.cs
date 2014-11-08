using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Formulario
using System.Data;
//----------------------------------------------
//Librerias
using MySql.Data;
using MySql.Data.MySqlClient;
//---------------------------------------------


namespace GestionDeNegocio
{
    public partial class sinstoc : Form
    {
        BDconexion bd = new BDconexion();

        public sinstoc()
        {
            InitializeComponent();
            bd.cnn.Open();
            MySqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from articulos where stock_actual <= stock_minimo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bd.cnn.Close();
        }

        private void sinstoc_Load(object sender, EventArgs e)
        {

        }
    }
}
