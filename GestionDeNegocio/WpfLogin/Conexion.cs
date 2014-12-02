using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace WpfLogin
{
    public class Conexion
    {
        private string conexion = Properties.Settings.Default.Conex;

        public Usuario loguear (string pNombre, string pPass)
        {
            SqlConnection CN;
            SqlCommand CMD;
            SqlDataReader RDR;

            CN = new SqlConnection(conexion);
            CMD = new SqlCommand("SELECT * FROM login where nombre = @p1 and pass = @p2", CN);
            CMD.CommandType = CommandType.Text;
            CMD.Parameters.AddWithValue("@p1", pNombre);
            CMD.Parameters.AddWithValue("@p2", pPass);

            try 
            {
                CN.Open();
                RDR = CMD.ExecuteReader(CommandBehavior.SingleRow);
                if (RDR.Read())
                {
                    Usuario usu = new Usuario
                        (
                            (int)RDR["id"],
                            (string)RDR["nombre"],
                            (string)RDR["pass"]
                        );
                    return usu;
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                CN.Close();
            }        
        }
    }
}
