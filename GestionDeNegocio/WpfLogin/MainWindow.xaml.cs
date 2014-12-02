using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLogin
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GestionDeNegocio.AplicacionGui f1 = new GestionDeNegocio.AplicacionGui();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                App.UsuarioEnTurno = App.ConBD1.loguear(pswUsuario.Password.Trim(), pswContraseña.Password.Trim());

                if (App.UsuarioEnTurno != null)
                {
                    MessageBox.Show("Bienvenido al Sistema");
                    f1.Show();
                    //this.DialogResult = true;
                    //this.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El nombre y/o usuario son incorrectos",
                        "Login Incorrecto", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //this.DialogResult = false;
            this.Close();
        }
    }
}
