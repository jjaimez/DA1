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

//----------------------------------------------
//Formulario
using System.Data;
using System.Data.SqlClient;
//----------------------------------------------
//Librerias
//--------------------------------------------

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
    public partial class ReporteArticulos : Form
    {
        BDconexion bd = new BDconexion();

        public ReporteArticulos()
        {
            InitializeComponent();
        }

        private void ReporteArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gestionnegocioDataSet.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.gestionnegocioDataSet.articulos);

            this.reportViewer1.RefreshReport();
        }
    }
       
}

