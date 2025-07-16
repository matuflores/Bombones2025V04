using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios.Interfaces
{
    public interface IProvinciaEstadoServicio
    {
        bool Borrar(int provinciaEstadoId, out List<string> errores);
        ProvinciaEstado? GetById(int provinciaEstadoId);
        List<ProvinciaEstadoListDto> GetProvinciaEstado(int? paisId=null,string? textoFiltro=null);
        bool Guardar(ProvinciaEstado provinciaEstado, out List<string>errores);
    }
}
