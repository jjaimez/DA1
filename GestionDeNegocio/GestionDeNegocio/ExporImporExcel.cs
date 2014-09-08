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
using MySql.Data.MySqlClient;
//----------- Excel -----------------
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryDrawingFormat;
using ExcelLibrary.BinaryFileFormat;
using System.Text.RegularExpressions;
using System.Diagnostics;

using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace GestionDeNegocio
{
    public partial class ExporImporExcel : Form
    {
        BDconexion bd = new BDconexion();
        
        public ExporImporExcel()
        {
            InitializeComponent();
        }        

        private void btnImport_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox1.Focus();
            }
            else
            {
                string constr = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source= " + textBox1.Text + "; Extended Properties =\"Excel 8.0; HDR=Yes;\";";
                OleDbConnection con = new OleDbConnection(constr);
                OleDbDataAdapter sda = new OleDbDataAdapter("Select * From [" + textBox2.Text + "$]", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            if (cbExport.SelectedItem == "articulos")
            {
                MySqlCommand cmdDataBase = new MySqlCommand("select * from articulos ;", bd.cnn);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbExport.SelectedItem == "clientes")
            {
                MySqlCommand cmdDataBase = new MySqlCommand("select * from clientes ;", bd.cnn);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbExport.SelectedItem == "compras")
            {
                MySqlCommand cmdDataBase = new MySqlCommand("select * from compras ;", bd.cnn);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbExport.SelectedItem == "proveedors")
            {
                MySqlCommand cmdDataBase = new MySqlCommand("select * from proveedors ;", bd.cnn);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (cbExport.SelectedItem == "ventas")
            {
                MySqlCommand cmdDataBase = new MySqlCommand("select * from ventas ;", bd.cnn);

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBase;
                    DataTable dbdataset = new DataTable();
                    sda.Fill(dbdataset);
                    BindingSource bSource = new BindingSource();

                    bSource.DataSource = dbdataset;
                    dataGridView1.DataSource = bSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            exportarexcel(dataGridView1);           
        }

        private void exportarexcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach ( DataGridViewColumn col in tabla.Columns)//columnas
            {
                IndiceColumna++;
                excel.Cells[1, IndiceColumna] = col.Name;

            }
            int IndiceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)//filas
            {
                IndiceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    IndiceColumna++;
                    excel.Cells[IndiceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
    }
}

