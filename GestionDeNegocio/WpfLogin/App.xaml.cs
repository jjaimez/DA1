using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfLogin
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static Conexion conBD = new Conexion();
        //private static Conexion conBD1;

        public static Conexion ConBD1
        {
            get { return App.conBD; }
            
        }
        

        private static Usuario usuarioEnTurno;

        public static Usuario UsuarioEnTurno
        {
            get { return App.usuarioEnTurno; }
            set { App.usuarioEnTurno = value; }
        }
    }
}
