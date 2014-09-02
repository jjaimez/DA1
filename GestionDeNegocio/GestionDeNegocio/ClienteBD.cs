using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionDeNegocio
{
    class ClienteBD
    {
        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into clientes (nombre, documento, telefono, celular, email) values ('{0}','{1}','{2}', '{3}','{4}')",
                pCliente.Nombre, pCliente.Documento, pCliente.Telefono, pCliente.Celular, pCliente.Email), BDconexion.ObtenerConexion());

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Cliente> Buscar(string pNombre)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT id, nombre, documento, telefono, celular, email FROM Clientes  where Nombre ='{0}'", pNombre), BDconexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Documento = _reader.GetString(2);
                pCliente.Telefono = _reader.GetString(3);
                pCliente.Celular = _reader.GetString(4);
                pCliente.Email = _reader.GetString(5);


                _lista.Add(pCliente);
            }

            return _lista;
        }
    }
}
