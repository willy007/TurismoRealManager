using AutoMapper;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataClase
{
    public class MapperClases : Profile
    {
        protected MapperClases()
        {
            CreateMap< ImagenDG, ImagenDTO >();
            CreateMap< ImagenDTO , ImagenDG >();
        }
    }
}
