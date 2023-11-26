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

namespace HotelManager
{
    /// <summary>
    /// Lógica de interacción para Habitacion.xaml
    /// </summary>
    public partial class Habitacion : Page
    {
        List<HotelDTO> bufferHotelList;
        List<EstadoHDTO> bufferEstado;
        List<TipoHabitacionDTO> bufferTipoHabitacion;
        long _modificar = 0;

        public Habitacion()
        {
            InitializeComponent();
            Init();
        }

        public async void Init() {

            HotelNegocio hotelNegocio = new HotelNegocio();

            try
            {

                bufferHotelList = await hotelNegocio.GetHoteles();

                cboHoteles.ItemsSource = bufferHotelList.Select(x => x.Nombre);
                cboHoteles.SelectedIndex = 0;

                EstadoServicio estadoServicio = new EstadoServicio();

                bufferEstado = await estadoServicio.GetEstados();

                cboEstado.ItemsSource = bufferEstado.Select(x => x.Estado);
                cboEstado.SelectedIndex = 0;

                TipoHabitacionServicio tipoHabitacionServicio = new TipoHabitacionServicio();

                bufferTipoHabitacion = await tipoHabitacionServicio.Lista();

                if (bufferTipoHabitacion == null)
                {
                    MessageBox.Show("No se a creado tipos de Habitaciones");
                    btnAgregar.IsEnabled = false;
                }
                else {
                    btnAgregar.IsEnabled = true;
                }

                var hotelselect = bufferHotelList.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

                var avitacionesTipo = bufferTipoHabitacion.Where(x => x.HotelId == hotelselect.Id).ToList();

                cboTipoHabitacion.ItemsSource = avitacionesTipo.Select(x => x.Nombre);
                cboTipoHabitacion.SelectedIndex = 0;

                Habitacionegocio habitacionegocio = new Habitacionegocio();

                var listaHabitaciones = await habitacionegocio.Listar((int)hotelselect.Id);

                dgHabitacoines.ItemsSource = listaHabitaciones;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private async void cboHoteles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bufferHotelList == null || bufferTipoHabitacion == null) { return; }
            cboHotelSelecion(cboHoteles.SelectedValue.ToString());
        }

        private async void cboHotelSelecion(string selecion) {

            
            var hotelselect = bufferHotelList.Where(x => x.Nombre == selecion).First();

            if (bufferTipoHabitacion == null)
            {
                MessageBox.Show("No se a creado tipos de Habitaciones");
                btnAgregar.IsEnabled = false;
                return;
            }

            var avitacionesTipo = bufferTipoHabitacion.Where(x => x.HotelId == hotelselect.Id).ToList();

            cboTipoHabitacion.ItemsSource = avitacionesTipo.Select(x => x.Nombre);
            cboTipoHabitacion.SelectedIndex = 0;

            Habitacionegocio habitacionegocio = new Habitacionegocio();

            var listaHabitaciones = await habitacionegocio.Listar((int)hotelselect.Id);

            dgHabitacoines.ItemsSource = listaHabitaciones;
        }


        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            try {

                string enumeracion = txtEnumeracion.Text;

                if (enumeracion == "" ) {
                    MessageBox.Show("No pueden haber campos vacios");
                    return;
                }

                var hotelselect = bufferHotelList.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();
                var tipoHabitacionSelect = bufferTipoHabitacion.Where(x => x.Nombre == cboTipoHabitacion.SelectedValue.ToString()).First();
                var estadoSelect = bufferEstado.Where(x => x.Estado == cboEstado.SelectedValue.ToString()).First();
                    

                Habitacionegocio habitacionegocio = new Habitacionegocio();

                HabitacionDTO newHabitacion = new HabitacionDTO()
                {
                    EstadoId = estadoSelect.Id,
                    HotelId = hotelselect.Id,
                    tipo = tipoHabitacionSelect.Id,
                    Numero = enumeracion
                };

                var stado = habitacionegocio.Crear(newHabitacion);

                Init();
                txtEnumeracion.Text = "";
                MessageBox.Show("Habitacion creado");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);   
            }   
        }

        private void dgHabitacoines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HabitacionDTO hb = (HabitacionDTO)dgHabitacoines.SelectedItem;

            if (hb != null)
            {
                cboEstado.SelectedValue = bufferEstado.Where(x => x.Id == hb.EstadoId).First().Estado;
                txtEnumeracion.Text = hb.Numero.ToString();
                cboTipoHabitacion.SelectedValue = bufferTipoHabitacion.Where(x => x.Id == hb.tipo).First().Nombre;
                _modificar = hb.Id; 
            }

        }

        private async void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string enumeracion = txtEnumeracion.Text;

                if (enumeracion == "")
                {
                    MessageBox.Show("No pueden haber campos vacios");
                    return;
                }

                var hotelselect = bufferHotelList.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();
                var tipoHabitacionSelect = bufferTipoHabitacion.Where(x => x.Nombre == cboTipoHabitacion.SelectedValue.ToString()).First();
                var estadoSelect = bufferEstado.Where(x => x.Estado == cboEstado.SelectedValue.ToString()).First();


                Habitacionegocio habitacionegocio = new Habitacionegocio();

                HabitacionDTO newHabitacion = new HabitacionDTO()
                {
                    Id = _modificar,
                    EstadoId = estadoSelect.Id,
                    HotelId = hotelselect.Id,
                    tipo = tipoHabitacionSelect.Id,
                    Numero = enumeracion
                };

                var stado = await habitacionegocio.Actualizar(newHabitacion);
                if (stado)
                {
                    Init();
                    txtEnumeracion.Text = "";
                    _modificar = 0;

                    cboHotelSelecion(hotelselect.Nombre);

                    MessageBox.Show("Habitacion Modificada");
                }
                else {
                    MessageBox.Show("Error al Modificar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
