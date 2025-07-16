using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades
{
    public class Ciudad
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; } = null!;
        public int ProvinciaEstadoId { get; set; }
        public ProvinciaEstado? ProvinciaEstado { get; set; }
    }
}
