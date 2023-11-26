using Hotel.DTO;
using Hotel.Modelo.Negocio;
using HotelManager.DataClase;
using Microsoft.Win32;
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
using System.Drawing;
using System.Data;

namespace HotelManager
{
    /// <summary>
    /// Lógica de interacción para Hotel.xaml
    /// </summary>
    public partial class Hotel : Page
    {
        private List<HotelDTO> _hotelbuffer = new List<HotelDTO>();
        private List<EstadoHDTO> _estadobuffer = new List<EstadoHDTO>();
        private long _modificar = 0;

        public Hotel()
        {
            InitializeComponent();

            //var dataGrid = new DataGrid();
            //dataGrid.Columns.Add(new DataColumn("Imagen", GetType(Image)));
            //dataGrid.Columns.Add(new DataColumn("Id", GetType(int)));
            //dataGrid.Columns.Add(new DataColumn("Activa", GetType(bool)));


            CargarData();
        }

        public async void CargarData() { 
        
            HotelNegocio negocioHotel= new HotelNegocio();
            EstadoServicio estadoServicio= new EstadoServicio();    

            try { 
                List<HotelDTO> hoteles = await negocioHotel.GetHoteles();
                _hotelbuffer = hoteles;

                dgHoteles.ItemsSource = null;
                dgHoteles.ItemsSource = hoteles;

                List<EstadoHDTO> estados = await estadoServicio.GetEstados();
                _estadobuffer = estados;

                cboEstado.ItemsSource = estados.Select(x => x.Estado).ToArray();
                cboEstado.SelectedIndex = 0;

            }catch(Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string estado = cboEstado.SelectedItem.ToString()!;
                string decuentoStr = txtDescuento.Text;
                string descripcion = txtDescripcion.Text;

                if (nombre == "" || direccion == "" || decuentoStr == "" || descripcion == "") {
                    MessageBox.Show("Los campos no puedne estar vacios ");
                    return;
                }

                if (!Int32.TryParse(decuentoStr, out int decuento)){
                    MessageBox.Show("el descuento debe ser un numero");
                    return; 
                }
                if (decuento > 100 || decuento < 0) {
                    MessageBox.Show("el descuento debe ser un numero entre 0 y 100");
                    return;
                }

                HotelDTO newHotel = new HotelDTO()
                {
                    Id = _modificar,
                    Nombre = nombre,
                    Direccion = direccion,
                    Estado = _estadobuffer.Where(x => x.Estado == estado).Select(x => x.Id).First(),
                    Descuento = decuento,
                    Descripcion = descripcion,
                }; 

                HotelNegocio negocioHotel = new HotelNegocio();
                var hotelResult = negocioHotel.CrearHotel(newHotel);

                if (hotelResult != null)
                {
                    MessageBox.Show("Hotel Creado");
                }

                CargarData();

                txtNombre.Text = "" ;
                txtDireccion.Text = "";
                txtDescuento.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgHoteles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HotelDTO hotelSelect = (HotelDTO)dgHoteles.SelectedItem ;

            if (hotelSelect != null) { 
                txtNombre.Text = hotelSelect.Nombre;
                txtDireccion.Text = hotelSelect.Direccion;
                txtDescuento.Text = hotelSelect.Descuento.ToString();
                txtDescripcion.Text = hotelSelect.Descripcion;
                cboEstado.SelectedIndex = (int)hotelSelect.Estado! - 1;

                _modificar = hotelSelect.Id;
            }
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_modificar == 0) {
                    MessageBox.Show("Seleccione un hotel");
                    return;
                }

                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                string estado = cboEstado.SelectedItem.ToString()!;
                string decuentoStr = txtDescuento.Text;
                string descripcion = txtDescripcion.Text;

                if (nombre == "" || direccion == "" || decuentoStr == "" || descripcion == "")
                {
                    MessageBox.Show("Los campos no puedne estar vacios");
                    return;
                }

                if (!Int32.TryParse(decuentoStr, out int decuento))
                {
                    MessageBox.Show("el descuento debe ser un numero");
                    return;
                }
                if (decuento > 100 || decuento < 0)
                {
                    MessageBox.Show("el descuento debe ser un numero entre 0 y 100");
                    return;
                }

                HotelDTO newHotel = new HotelDTO()
                {
                    Id = _modificar,
                    Nombre = nombre,
                    Direccion = direccion,
                    Estado = _estadobuffer.Where(x => x.Estado == estado).Select(x => x.Id).First(),
                    Descuento = decuento,
                    Descripcion = descripcion,
                };

                HotelNegocio negocioHotel = new HotelNegocio();
                var hotelResult = negocioHotel.Modificar(newHotel);

                if (hotelResult != null)
                {
                    MessageBox.Show("Hotel Modificado");
                }

                CargarData();

                txtNombre.Text = "";
                txtDireccion.Text = "";
                txtDescuento.Text = "";
                txtDescripcion.Text = "";
                _modificar = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImagenes_Click(object sender, RoutedEventArgs e)
        {
            var lista = new List<ImagenDTO>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.webp";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string filpath in openFileDialog.FileNames) {
                    var imagen = System.IO.File.ReadAllBytes(filpath);
                    lista.Add(new ImagenDTO() { });
                }

            }


        }
    }

    //public class dgImagen {

    //    public int Id { get; set; }
    //    public System.Drawing.Image Img { get; set; }
    //    public bool IsPrimario { get; set; }
    //}
}

