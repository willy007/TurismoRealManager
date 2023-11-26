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
using System.Windows.Shapes;

namespace HotelManager.VentanasPrincipales
{
    /// <summary>
    /// Lógica de interacción para WindowAdministrador.xaml
    /// </summary>
    public partial class WindowAdministrador : Window
    {
        public WindowAdministrador()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Hotel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Habitacion();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            mainFrame.Content = new Habitacion();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new TipoHabitacionWindow();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new ServicioHotelWindows();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Usuarios();
        }
    }
}
