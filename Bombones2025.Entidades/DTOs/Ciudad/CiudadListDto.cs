using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades.DTOs.Ciudad
{
    public class CiudadListDto
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; } = null!;
        public string NombreProvincia { get; set; } = null!;
        public string NombrePais { get; set; } = null!;
    }
}
