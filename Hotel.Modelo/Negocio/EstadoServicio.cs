using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class EstadoServicio
    {

        public async Task<List<EstadoHDTO>> GetEstados()
        {

            try
            {
                var conn = new Conexion<EstadoHDTO>();

                var res = await conn.Get("EstadoHotel/Listar");

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
