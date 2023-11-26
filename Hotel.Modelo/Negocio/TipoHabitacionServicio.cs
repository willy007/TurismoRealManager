using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Modelo.Negocio
{
    public class TipoHabitacionServicio
    {
        
        
        
        
        public async Task<List<TipoHabitacionDTO>> Lista() {
            Conexion<TipoHabitacionDTO> conexion = new Conexion<TipoHabitacionDTO>();

            try { 
            
                var listaTipoHabitacion = await conexion.Get("TipoHabitacion/Listar");

                if (!listaTipoHabitacion.EsCorrecto) {
                    throw new TaskCanceledException(listaTipoHabitacion.Mensaje);
                }

                return listaTipoHabitacion.Resultado!;

            } catch (Exception) {
                throw;
            }
        }

        public async Task<TipoHabitacionDTO> Crear(TipoHabitacionDTO newTipoHabitacion) {
            Conexion<TipoHabitacionDTO> conexion = new Conexion<TipoHabitacionDTO>();

            try
            {

                var listaTipoHabitacion = await conexion.Post("TipoHabitacion/Crear", newTipoHabitacion);

                if (!listaTipoHabitacion.EsCorrecto)
                {
                    throw new TaskCanceledException(listaTipoHabitacion.Mensaje);
                }

                return listaTipoHabitacion.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Actualizar(TipoHabitacionDTO newTipoHabitacion)
        {
            Conexion<bool> conexion = new Conexion<bool>();

            try
            {

                var listaTipoHabitacion = await conexion.Update("TipoHabitacion/Actualizar", newTipoHabitacion);

                if (!listaTipoHabitacion.EsCorrecto)
                {
                    throw new TaskCanceledException(listaTipoHabitacion.Mensaje);
                }

                return listaTipoHabitacion.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(TipoHabitacionDTO newTipoHabitacion)
        {
            Conexion<bool> conexion = new Conexion<bool>();

            try
            {

                var listaTipoHabitacion = await conexion.Delete("TipoHabitacion/Eliminar/id:int?id=" + 
                    
                    newTipoHabitacion.Id);

                if (!listaTipoHabitacion.EsCorrecto)
                {
                    throw new TaskCanceledException(listaTipoHabitacion.Mensaje);
                }

                return listaTipoHabitacion.Resultado!;

            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
