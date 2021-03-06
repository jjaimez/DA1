﻿using System;
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
    public partial class gestionProveedor : Form
    {
        BDconexion bd = new BDconexion();

        public gestionProveedor()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "" || txtCiut.Text == "" || txtTelefono.Text == "" || txtCelular.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show(" Rellene todos los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNombre.Focus();
            }
            else
            {
                try
                {

                    bd.insertarProveedor(txtId, txtNombre, txtCiut, txtTelefono, txtCelular, txtEmail);

                    MessageBox.Show("Se insertaron correctamente los datos");
                    this.txtId.Text = "";
                    this.txtNombre.Text = "";
                    this.txtCiut.Text = "";
                    this.txtTelefono.Text = "";
                    this.txtCelular.Text = "";
                    this.txtEmail.Text = "";/*
                    this.txtNombre.Enabled = false;
                    this.txtCiut.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.txtCelular.Enabled = false;
                    this.txtEmail.Enabled = false;
                    this.btnGuardar.Enabled = false;*/

                }
                catch (Exception m)
                {
                    MessageBox.Show("No se pudieron insertar los datos");
                }
                bd.mostrarProveedores(dgv_Mostrar);
                this.txtId.Text = "";
                this.txtNombre.Text = "";
                this.txtCiut.Text = "";
                this.txtTelefono.Text = "";
                this.txtCelular.Text = "";
                this.txtEmail.Text = "";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtCiut.Text = "";
            this.txtEmail.Text = "";
            this.txtCelular.Text = "";

            this.btnGuardar.Enabled = true;
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            bd.cnn.Open();
            SqlCommand cmd = bd.cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from proveedors where nombre like('" + txtBuscar.Text + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_Mostrar.DataSource = dt;
            bd.cnn.Close();
        }

        private void dgv_Mostrar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Llenamos la información de la linea seleccionada en las
            // respectivas cajitas de texto
            txtId.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCiut.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefono.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCelular.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dgv_Mostrar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }


        private void gestionProveedor_Load(object sender, EventArgs e)
        {
            bd.mostrarProveedores(dgv_Mostrar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bd.cnn.Open();
            string borra = "DELETE FROM PROVEEDORS WHERE ID='" + txtId.Text + "'";
            SqlCommand cmd = new SqlCommand(borra, bd.cnn);
            cmd.ExecuteNonQuery();
            bd.cnn.Close();
            bd.mostrarProveedores(dgv_Mostrar);
            this.txtId.Text = "";
            this.txtNombre.Text = "";
            this.txtCiut.Text = "";
            this.txtTelefono.Text = "";
            this.txtCelular.Text = "";
            this.txtEmail.Text = "";
            MessageBox.Show("registro eliminado con exito");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //realizamos la consulta de actualizar en el q se toma desde el ID ingresado por el texboxId y despues que se modifique se actualiza los datos 
                string Query = "update proveedors set id='" + this.txtId.Text + "',nombre='" + this.txtNombre.Text
                    + "',cuit='" + this.txtCiut.Text
                    + "',telefono='" + this.txtTelefono.Text
                    + "',celular='" + this.txtCelular.Text
                    + "',email='" + this.txtEmail.Text
                    + "' where id='" + this.txtId.Text + "';";
                SqlCommand MyCommand2 = new SqlCommand(Query, bd.cnn);
                SqlDataReader MyReader2;
                bd.cnn.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Registro modificado");
                bd.cnn.Close();//
                bd.mostrarProveedores(dgv_Mostrar);//actualiza el datagridview
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
    }
}
