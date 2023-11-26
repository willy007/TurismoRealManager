using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class HotelNegocio
    {

        public async Task<List<HotelDTO>> GetHoteles() {

            try {
                var conn = new Conexion<HotelDTO>();

                var res = await conn.Get("Hotel/Listar");

                if (!res.EsCorrecto)
                {
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }
            catch (Exception ) {
                throw;
            }
        }

        public async Task<HotelDTO> CrearHotel(HotelDTO newHotel) {
            try
            {
                var conn = new Conexion<HotelDTO>();

                var res = await conn.Post("Hotel/Crear" , newHotel);

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

        public async Task<bool> Modificar(HotelDTO modifHotel) {
            try
            {
                var conn = new Conexion<bool>();
                var res = await conn.Update("Hotel/Editar", modifHotel);

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
