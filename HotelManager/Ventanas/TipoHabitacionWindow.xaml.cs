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
    /// Lógica de interacción para TipoHabitacionWindow.xaml
    /// </summary>
    public partial class TipoHabitacionWindow : Page
    {
        private List<HotelDTO> _HoteBuffer = new List<HotelDTO>();
        private List<TipoHabitacionDTO> _tiposHabitacionesBuffer = new List<TipoHabitacionDTO>();
        private long _habitacionModificarId = 0;

        public TipoHabitacionWindow()
        {
            InitializeComponent();
            Init();
        }

        private async void Init()
        {
            try {

                txtCantidadPersona.Text = "";
                txtPrecio.Text = "";
                txtDescripcion.Text = "";
                txtNombre.Text = "";

                HotelNegocio dataHotel = new HotelNegocio();
                TipoHabitacionServicio dataTipoHabitaciones = new TipoHabitacionServicio();

                var hoteles = await dataHotel.GetHoteles();
                _HoteBuffer = hoteles;

                cboHoteles.ItemsSource = hoteles.Select(h => h.Nombre).ToList();
                cboHoteles.SelectedIndex = 0;

                _tiposHabitacionesBuffer = await dataTipoHabitaciones.Lista();

                var selectHotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

                var TiposHabitacionesFiltrados = _tiposHabitacionesBuffer.Where(x => x.HotelId == selectHotel.Id).ToList();

                dgTiposHabitacion.ItemsSource = TiposHabitacionesFiltrados;


            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }


        private void cboHoteles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_tiposHabitacionesBuffer != null) {
                var selectHotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

                var TiposHabitacionesFiltrados = _tiposHabitacionesBuffer.Where(x => x.HotelId == selectHotel.Id).ToList();

                dgTiposHabitacion.ItemsSource = TiposHabitacionesFiltrados;
            }
        }

        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {

            if (txtCantidadPersona.Text == "" && txtPrecio.Text == "" && txtDescripcion.Text == "" && txtNombre.Text == "") {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (txtDescripcion.Text.Length > 255 ) {
                MessageBox.Show("La descripccion no puede tener mas de 255 caracteres");
                return;
            }

            if (txtNombre.Text.Length > 255)
            {
                MessageBox.Show("La Nombre no puede tener mas de 255 caracteres");
                return;
            }

            int cantidadPersona;
            int valor;
            string descripcion = txtDescripcion.Text;
            string nombre = txtNombre.Text;


            if (!Int32.TryParse(txtCantidadPersona.Text, out cantidadPersona)) {
                MessageBox.Show("Cantidad de personas debe ser numerico");
                return;
            }
            if (!Int32.TryParse(txtPrecio.Text, out valor))
            {
                MessageBox.Show("El valor debe ser numerico");
                return;
            }

            TipoHabitacionServicio _servicioTH = new TipoHabitacionServicio();

            HotelDTO hotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

            TipoHabitacionDTO newTH = new TipoHabitacionDTO() { 
                HotelId = hotel.Id,
                Nombre = nombre,
                Descripcion = descripcion,
                CantidadPersonas = cantidadPersona,
                ValorDia = valor
            };

            try { 
                
                TipoHabitacionDTO creado = await _servicioTH.Crear(newTH);
                Init();
                MessageBox.Show("Tipo Habitacion Creado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }


        private async void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            if (txtCantidadPersona.Text == "" && txtPrecio.Text == "" && txtDescripcion.Text == "" && txtNombre.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios");
                return;
            }
            if (txtDescripcion.Text.Length < 5)
            {
                MessageBox.Show("La descripccion no puede tener menos de 5 caracteres");
                return;
            }
            if (txtNombre.Text.Length > 255)
            {
                MessageBox.Show("La Nombre no puede tener mas de 255 caracteres");
                return;
            }

            int cantidadPersona;
            int valor;
            string descripcion = txtDescripcion.Text;
            string nombre = txtNombre.Text;

            if (!Int32.TryParse(txtCantidadPersona.Text, out cantidadPersona))
            {
                MessageBox.Show("Cantidad de personas debe ser numerico");
                return;
            }
            if (!Int32.TryParse(txtPrecio.Text, out valor))
            {
                MessageBox.Show("El valor debe ser numerico");
                return;
            }

            TipoHabitacionServicio _servicioTH = new TipoHabitacionServicio();

            HotelDTO hotel = _HoteBuffer.Where(x => x.Nombre == cboHoteles.SelectedValue.ToString()).First();

            TipoHabitacionDTO newTH = new TipoHabitacionDTO()
            {
                Id = _habitacionModificarId,
                HotelId = hotel.Id,
                Descripcion = descripcion,
                Nombre = nombre,
                CantidadPersonas = cantidadPersona,
                ValorDia = valor
            };

            try
            {

                bool creado = await _servicioTH.Actualizar(newTH);
                Init();
                if (creado)
                {
                    MessageBox.Show("Tipo Habitacion Actualizado");
                }
                else {
                    MessageBox.Show("Error al Actualizar");
                }

                _habitacionModificarId = 0;
                Guardar_Activo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgTiposHabitacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TipoHabitacionDTO habitacion = (TipoHabitacionDTO) dgTiposHabitacion.SelectedItem;

            if (habitacion != null)
            {
                txtCantidadPersona.Text = habitacion.CantidadPersonas.ToString();
                txtDescripcion.Text = habitacion.Descripcion!.ToString();
                txtPrecio.Text = habitacion.ValorDia.ToString();
                txtNombre.Text = habitacion.Nombre.ToString();

                _habitacionModificarId = habitacion.Id;
                Guardar_Activo();
            }

        }

        private void Guardar_Activo() {
            if (_habitacionModificarId == 0)
            {
                btnAgregar.IsEnabled = true;
            }
            else {
                btnAgregar.IsEnabled = false;
            }
        }
    }
}
