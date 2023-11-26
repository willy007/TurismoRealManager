using HotelManager.Ventanas;
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
using Hotel.Modelo;
using Hotel.Modelo.Negocio;
using HotelManager.VentanasPrincipales;

namespace HotelManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try {

                if (txtPwd.Password == "" || txtUser.Text == "") {
                    MessageBox.Show("Los campos de texto no pueden estar vacios");
                    return;
                }

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                var result = await usuarioNegocio.Login(txtUser.Text, txtPwd.Password);

                if (result.Tipo == "admin")
                {
                    WindowAdministrador wADmin = new WindowAdministrador();
                    this.Close();
                    wADmin.Show();
                    return;
                }
                else if (result.Tipo == "funcionario")
                {
                    WindowFuncionario wFun = new WindowFuncionario();
                    this.Close();
                    wFun.Show();
                    return;
                }

                MessageBox.Show("Usuario o contraseña incorrectos");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPwd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
