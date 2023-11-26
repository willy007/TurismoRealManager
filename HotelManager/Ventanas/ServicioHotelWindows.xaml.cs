using Hotel.DTO;
using Hotel.Modelo.Negocio;
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

namespace HotelManager.Ventanas
{
    /// <summary>
    /// Lógica de interacción para ServicioHotelWindows.xaml
    /// </summary>
    public partial class ServicioHotelWindows : Page
    {

        private List<HotelDTO> _HoteBuffer = new List<HotelDTO>();
        private List<ServicioHDTO> _ServiciosBuffer = new List<ServicioHDTO>();

        public ServicioHotelWindows()
        {
            InitializeComponent();
            Init();
        }

        private async void Init()
        {
            try {
                HotelNegocio dataHotel = new HotelNegocio();

                var hoteles = await dataHotel.GetHoteles();
                _HoteBuffer = hoteles;

                cboHoteles.ItemsSource = hoteles.Select(h => h.Nombre).ToList();
                cboHoteles.SelectedIndex = 0;

                ServicioHotelNegocio dataServicios = new ServicioHotelNegocio();

                var servicios = await dataServicios.Listar();
                _ServiciosBuffer = servicios;

                var selectHotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

                dgServicios.ItemsSource = servicios.Where(x => x.Hotel == selectHotel.Id).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }


        private void cboHoteles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_HoteBuffer != null)
            {
                var selectHotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

                dgServicios.ItemsSource = _ServiciosBuffer.Where(x => x.Hotel == selectHotel.Id).ToList();
            }
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNombreServicio.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }

            int valor;
            string nombreServicio = txtNombreServicio.Text;
            string descripcion = txtDescripcion.Text;

            if (!Int32.TryParse(txtPrecio.Text, out valor))
            {
                MessageBox.Show("El precio debe ser numerico");
                return;
            }
            
            var cboVal = cboHoteles.SelectedIndex;

            var selectHotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

            try {

                ServicioHotelNegocio dataServicios = new ServicioHotelNegocio();

                ServicioHDTO newServicio = new ServicioHDTO()
                {
                    Hotel = selectHotel.Id,
                    Valor = valor,
                    Nombre = nombreServicio,
                    Desscripcion = descripcion,
                    PorDia = chbPorDia.IsChecked
                };

                var servicio = await dataServicios.Agregar(newServicio);

                Init();

                cboHoteles.SelectedIndex = cboVal;
                txtNombreServicio.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";

                MessageBox.Show("Servicio Creado");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
