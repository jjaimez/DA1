using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Data.OleDb;

namespace GestionDeNegocio
{
    public partial class ExporImporExcel : Form
    {
        public ExporImporExcel()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "" || textBox2.Text == "")
            //{
            //   MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //  textBox1.Focus();
            //}
            //else
            //{

            //}
            string constr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source= " + textBox1.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox2.Text + "$]",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       
    }
}
