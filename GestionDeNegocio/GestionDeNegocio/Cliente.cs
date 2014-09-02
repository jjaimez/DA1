﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeNegocio
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Documento { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public Cliente(int pId, string pNombre, string pDocumento, string pTelefono, string pCelular, string pEmail)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Documento = pDocumento;
            this.Telefono = pTelefono;
            this.Celular = pCelular;
            this.Email = pEmail;
        }
    }
}
