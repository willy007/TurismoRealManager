using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DataClase
{
    public class ImagenDG
    {
        public long Id { get; set; }

        public byte[] Img { get; set; } = null!;

        public bool IsPrimario { get; set; }
    }
}
