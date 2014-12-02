using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLogin
{
    public class Usuario
    {
        //campos 
        
        private int id;
        private string nombre;
        private string pass;

        //propiedades

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        //constructores

        public Usuario(int pId, string pNombre, string pPass)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Pass = pPass;
        }
    }
}
