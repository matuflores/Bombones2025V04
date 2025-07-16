using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Entidades.DTOs.ProvinciaEstado
{
    public class ProvinciaEstadoListDto
    {
        public int ProvinciaEstadoId { get; set; }
        public string NombreProvinciaEstado { get; set; } = null!;

        //como el nombrepais el obj no lo tiene, yo le debo indicar de donde lo tiene que sacar, lo hago en el mappers
        public string NombrePais { get; set; } = null!;
    }
}
