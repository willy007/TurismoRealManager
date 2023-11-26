using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class UsuarioNegocio
    {

        public async Task<UsuarioDTO> Login(string usuario, string contrasena) {

            try { 
                
                Conexion<UsuarioDTO> conexion = new Conexion<UsuarioDTO>();

                SessionDTO sessionDTO = new SessionDTO() { Nombre = usuario, Contrasena = contrasena };

                var response = await conexion.Post("Usuario/Login", sessionDTO);

                if (!response.EsCorrecto) {
                    throw new TaskCanceledException(response.Mensaje);
                }

                return response.Resultado!;

            }
            catch (Exception ) {
                throw;
            }
        }

        public async Task<UsuarioDTO> Crear(RegistroUsaurioDTO registro) {

            try { 
                Conexion<UsuarioDTO> conexion =new Conexion<UsuarioDTO>();

                var response = await conexion.Post("Usuario/Crear", registro);

                if (!response.EsCorrecto)
                {
                    throw new TaskCanceledException(response.Mensaje);
                }

                return response.Resultado!;


            } catch (Exception) {
                throw;
            }
            
        }

        public async Task<bool> Actualizar(RegistroUsaurioDTO registro)
        {

            try
            {
                Conexion<bool> conexion = new Conexion<bool>();

                var response = await conexion.Update("Usuario/Editar", registro);

                if (!response.EsCorrecto)
                {
                    throw new TaskCanceledException(response.Mensaje);
                }

                return response.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }

        }


        public async Task<List<UsuarioDTO>> Listar(string rol)
        {

            try
            {
                Conexion<UsuarioDTO> conexion = new Conexion<UsuarioDTO>();

                var response = await conexion.Get("Usuario/Listar/" + rol);

                if (!response.EsCorrecto)
                {
                    throw new TaskCanceledException(response.Mensaje);
                }

                return response.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<EncargadoDTO> CrearEncargado(EncargadoDTO encargado)
        {
            try
            {
                Conexion<EncargadoDTO> conexion = new Conexion<EncargadoDTO>();

                var response = await conexion.Post("EncargadoHotel/crear", encargado);

                if (!response.EsCorrecto)
                {
                    throw new TaskCanceledException(response.Mensaje);
                }

                return response.Resultado!;


            }
            catch (Exception)
            {
                throw;
            }

        }


    }
}
