using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeNegocio
{
    public class EArticulo
    {
        //Estas son propiedades Autoimplementadas y su uso requiere
        // del Framework 4.0 Client Profile como minimo
        public int id { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; }
        //public string descripcion { get; set; }
        //public Decimal Precio_venta { get; set; }
        //public Decimal Cantidad { get; set; }
    }
}
