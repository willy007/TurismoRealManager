using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class ServicioHotelNegocio
    {
        public async Task<List<ServicioHDTO>> Listar() {

            try
            {
                var conn = new Conexion<ServicioHDTO>();

                var res = await conn.Get("ServicioHotel/Listar");

                if (!res.EsCorrecto)
                {
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<ServicioHDTO> Agregar(ServicioHDTO servicio) {

            try
            {
                var conn = new Conexion<ServicioHDTO>();

                var res = await conn.Post("ServicioHotel/Agregar" , servicio);

                if (!res.EsCorrecto)
                {
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Actualizar(ServicioHDTO servicio)
        {

            try
            {
                var conn = new Conexion<ServicioHDTO>();

                var res = await conn.Update("ServicioHotel/Actualizar", servicio);

                if (!res.EsCorrecto)
                {
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(ServicioHDTO servicio)
        {

            try
            {
                var conn = new Conexion<ServicioHDTO>();

                var res = await conn.Delete("ServicioHotel/Actualizar/id:int?id=" +  servicio.Id);

                if (!res.EsCorrecto)
                {
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
