using AutoMapper;
using Bombones2025.DatosSql.Interfaces;
using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios.Servicios
{
    public class CiudadServicio:ICiudadServicio
    {
        private readonly ICiudadRepositorio _ciudadRepositorio;
        private readonly IMapper _mapper;
        public CiudadServicio(ICiudadRepositorio ciudadRepositorio, IMapper mapper)
        {
            _ciudadRepositorio = ciudadRepositorio;
            _mapper = mapper;
        }

        public List<CiudadListDto> GetLista()
        {
            var ciudades=_ciudadRepositorio.GetLista();

            /*Esto lo hago con select de LINQ
             * Luego lo haremos con AUTOMAPPER
             */
            //return ciudades.Select(c => new CiudadListDto
            //{
            //    CiudadId = c.CiudadId,
            //    NombreCiudad = c.NombreCiudad,
            //    NombreProvincia = c.ProvinciaEstado!.NombreProvinciaEstado,
            //    NombrePais = c.ProvinciaEstado.Pais!.NombrePais
            //}).ToList();
            //con automapper
            return _mapper.Map<List<CiudadListDto>>(ciudades);
        }
    }
}
