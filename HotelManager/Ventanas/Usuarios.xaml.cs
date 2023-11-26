using Hotel.DTO;
using Hotel.Modelo.Negocio;
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

namespace HotelManager
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        private List<HotelDTO> _HoteBuffer = new List<HotelDTO>();
        private List<UsuarioDTO> admins = new List<UsuarioDTO>();
        private List<UsuarioDTO> funcionarios = new List<UsuarioDTO>();

        public Usuarios()
        {
            InitializeComponent();

            List<string> roles = new List<string>() ;

            roles.Add("admin");
            roles.Add("funcionario");
            roles.Add("user");

            cboRol.ItemsSource = roles;
            cboRol.SelectedIndex = 0;

            Init();
        }


        private async void Init() {

            try {

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();


                List<string> roles = new List<string>();

                roles.Add("admin");
                roles.Add("funcionario");

                cboRolLista.ItemsSource = roles;
                cboRolLista.SelectedIndex = 0;

                HotelNegocio dataHotel = new HotelNegocio();

                var hoteles = await dataHotel.GetHoteles();
                _HoteBuffer = hoteles;

                cboHotel.ItemsSource = hoteles.Select(h => h.Nombre).ToList();
                cboHotel.SelectedIndex = 0;

                admins = await usuarioNegocio.Listar("admin");
                dgPersona.ItemsSource = admins;
                funcionarios = await usuarioNegocio.Listar("funcionario");

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        private async void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text     == ""
                && txtPwd.Password  == ""
                && txtRun.Text      == ""
                && txtNombre.Text   == ""
                && txtApellido.Text == ""
                && txtCorreo.Text   == ""
                && txtTelefono.Text == "") {

                MessageBox.Show("Hay Campos vacios");
                return; 
            }

            PersonaDTO personaDTO = new PersonaDTO() { 
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Correo = txtCorreo.Text,
                Identificador = txtRun.Text,
                Telefono = txtTelefono.Text,
            };

            RegistroUsaurioDTO registro = new RegistroUsaurioDTO() {
                Nombre = txtUsuario.Text,
                Contrasena = txtPwd.Password,
                Tipo = cboRol.SelectedValue.ToString(),
                IdNavigation = personaDTO
            };


            try {
                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                var respueta = await usuarioNegocio.Crear(registro);

                if (respueta.Tipo == "funcionario") { 

                    var idHotel = _HoteBuffer.Where(x => x.Nombre == cboHotel.SelectedValue.ToString() ).First().Id;

                    EncargadoDTO encargado = new EncargadoDTO()
                    {
                        UsuarioId = respueta.Id,
                        HotelId = idHotel
                    };
                    await usuarioNegocio.CrearEncargado(encargado);
                }

                MessageBox.Show("Usuario Creado");

                txtUsuario.Text = "";
                txtPwd.Password = "";
                txtRun.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";

                Init();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void cboRol_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboRol.SelectedValue == null) { return; }
            string seleccion = cboRol.SelectedValue.ToString()! ;

            if (seleccion  == "funcionario")
            {
                cboHotel.IsEnabled = true;
            }
            else {
                cboHotel.IsEnabled = false;
            }
        }

        private void cboRolLista_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboRolLista.SelectedValue == null) { return; }

            string seleccion = cboRolLista.SelectedValue.ToString()!;

            if (seleccion == "admin")
            {
                dgPersona.ItemsSource = admins;
            }
            else {
                dgPersona.ItemsSource = funcionarios;
            }

        }
    }
}
