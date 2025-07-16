using Bombones2025.Entidades.DTOs.Ciudad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios.Interfaces
{
    public interface ICiudadServicio
    {
        List<CiudadListDto> GetLista();
    }
}
