using AutoMapper;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Windows.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            LoadPaisMapping();
            LoadProvinciaEstadoMapping();
            LoadCiudadMapping();
        }

        private void LoadCiudadMapping()
        {
            CreateMap<Ciudad, CiudadListDto>()
               .ForMember(dest => dest.NombreProvincia,
                       opt => opt.MapFrom(src => src
                       .ProvinciaEstado!.NombreProvinciaEstado))
               .ForMember(dest => dest.NombrePais,
                       opt => opt.MapFrom(src => src.ProvinciaEstado!.Pais!.NombrePais));
            CreateMap<Ciudad, CiudadEditDto>().ReverseMap();
            CreateMap<CiudadEditDto, CiudadListDto>();
        }

        private void LoadProvinciaEstadoMapping()
        {
            CreateMap<ProvinciaEstado, ProvinciaEstadoListDto>()
                .ForMember(p => p.NombrePais, opt => opt.MapFrom(src => src.Pais!.NombrePais));
            //aca le digo que me va a crear una provincia/estado list dto
            //como a NombrePais no lo tiene, le indico que lo va a sacar de la fuente (src)
            //para el miembro NOMBREPAIS lo vas a sacar de la Entidad
            //que viene del repo, me vas a traer el nombrepais
        }

        private void LoadPaisMapping()
        {
            CreateMap<Pais,PaisListDto>();
            CreateMap<Pais,PaisEditDto>().ReverseMap();//me permite pasar de pais a paiseditdto y viceversa
            CreateMap<PaisEditDto,PaisListDto>();
        }
    }
}
