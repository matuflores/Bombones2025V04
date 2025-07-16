using Bombones2025.DatosSql.Interfaces;
using Bombones2025.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Bombones2025.DatosSql.Repositorios
{
    public class CiudadRepositorioEF : ICiudadRepositorio
    {
        private BombonesDbContext _dbContext;

        public CiudadRepositorioEF(BombonesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Ciudad> GetLista()
        {
            return _dbContext.Ciudades.Include(c => c.ProvinciaEstado)
                .ThenInclude(pe => pe.Pais)
                .AsNoTracking()
                .ToList();
        }
    }
}
