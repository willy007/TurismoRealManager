using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class Habitacionegocio
    {


        public async Task<List<HabitacionDTO>> Listar(int id) {

            try {

                var con = new Conexion<HabitacionDTO>();

                var res = await con.Get("Habitacion/Listar/id:int?id=" + id);

                if (!res.EsCorrecto) { 
                    throw new TaskCanceledException(res.Mensaje);
                }

                return res.Resultado!;

            }catch (Exception ) {
                throw;
            }
        }


        public async Task<HabitacionDTO> Crear(HabitacionDTO hb)
        {

            try
            {

                var con = new Conexion<HabitacionDTO>();

                var res = await con.Post("Habitacion/Crear" , hb);

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


        public async Task<bool> Actualizar(HabitacionDTO hb)
        {

            try
            {

                var con = new Conexion<bool>();

                var res = await con.Update("Habitacion/Actualizar", hb);

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
