using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Pais;

namespace Bombones2025.Servicios.Servicios
{
    public interface IPaisServicio
    {
        bool Borrar(int paisId, out List<string> errores);
        bool Existe(Pais pais);
        //List<Pais> Filtrar(string textoParaFiltrar);
        List<PaisListDto> GetPais(string? textoParaFiltrar=null);
        bool Agregar(PaisEditDto paisDto, out List<string> errores);
        bool Editar(PaisEditDto paisDto, out List<string> errores);

        PaisEditDto? GetPorId(int paisId);

        //bool EstaRelacionado(int paisId);
    }
}