using AutoMapper;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Pais;
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
        }

        private void LoadPaisMapping()
        {
            CreateMap<Pais,PaisListDto>();
            CreateMap<Pais,PaisEditDto>().ReverseMap();//me permite pasar de pais a paiseditdto y viceversa
            CreateMap<PaisEditDto,PaisListDto>();
        }
    }
}
