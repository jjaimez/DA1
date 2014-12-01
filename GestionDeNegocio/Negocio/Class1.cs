using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class Class1
    {
        db_entityDataContext db = new db_entityDataContext();

        public void guardarCliente(int id, string nombre, string documento, string telefono, string celular, string email) 
        {
            clientes p = new clientes();
            p.id = id;
            p.nombre = nombre;
            p.documento=documento;
            p.telefono=telefono;
            p.celular=celular;
            p.email=email;

            db.clientes.InsertOnSubmit(p);
            db.SubmitChanges();
        }

        public void mostrarCliente(ListBox lb)
        {
            var consulta = from x in db.clientes select x;
            foreach (clientes p in consulta)
            {
                lb.Items.Add(p.id + " " + p.nombre + " " + p.documento + " " + p.telefono + " " + p.celular + " " + p.email + " ");
 
            }
        }
        public void mostrarCliente(ComboBox cb)
        {
            var consulta = from x in db.clientes select x;
            foreach (clientes p in consulta)
            {
                cb.Items.Add(p.nombre);
            }
        }

        int ID;
        public void obtenerID(string dato)
        {
            ID = 0;
            var consulta = from x in db.clientes
                           where x.nombre == dato
                           select x;
            foreach (clientes p in consulta)
            {
                ID = p.id;
            }
        }

        public void modificar(string nombre, string documento, string telefono, string celular, string email, string dat)
        {
            obtenerID(dat);
            var consulta = (from x in db.clientes
                            where x.id == ID
                            select x).First();
            consulta.nombre = nombre;
            consulta.documento = documento;
            consulta.telefono = telefono;
            consulta.celular = celular;
            consulta.email = email;

            db.SubmitChanges();
        }

        public void cargar(string dat, TextBox nombre, TextBox documento, TextBox telefono, TextBox celular, TextBox email)
        {
            obtenerID(dat);
            var consulta = from x in db.clientes
                           where x.id == ID
                           select x;
            foreach (clientes p in consulta)
            {
                nombre.Text = p.nombre;
                documento.Text = p.documento;
                telefono.Text = p.telefono;
                celular.Text = p.celular;
                email.Text = p.email;
                
            }
        }

        public void eliminar(string dato)
        {
            var consulta = from x in db.clientes
                           where (x.id + "" + x.nombre + "" + x.documento + "" + x.telefono + "" + x.celular+""+x.email+"") == dato
                           select x;
            foreach (clientes p in consulta)
            {
                db.clientes.DeleteOnSubmit(p);
            }
            db.SubmitChanges();
        }
    }
}
