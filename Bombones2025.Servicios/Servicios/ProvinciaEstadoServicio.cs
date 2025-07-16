using AutoMapper;
using Bombones2025.DatosSql.Interfaces;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios.Servicios
{
    public class ProvinciaEstadoServicio : IProvinciaEstadoServicio
    {
        private readonly IProvinciaEstadoRepositorio _provinciaEstadoRepositorio;
        private readonly IMapper _mapper;
        public ProvinciaEstadoServicio(IProvinciaEstadoRepositorio provinciaEstadoRepositorio, IMapper mapper)
        {
            _provinciaEstadoRepositorio = provinciaEstadoRepositorio;
            _mapper = mapper;
        }

        public bool Borrar(int provinciaEstadoId, out List<string> errores)
        {
            errores=new List<string>();
            if (_provinciaEstadoRepositorio.EstaRelacionado(provinciaEstadoId))
            {
                errores.Add("Registro relacionado, no es posible borrar");
                return false;
            }
            _provinciaEstadoRepositorio.Borrar(provinciaEstadoId);
            return true;
        }

        public ProvinciaEstado? GetById(int provinciaEstadoId)
        {
            return _provinciaEstadoRepositorio.GetById(provinciaEstadoId);
        }

        public List<ProvinciaEstadoListDto> GetProvinciaEstado(int? paisId = null, string? textoFiltro = null)
        {
            var provinciasEstados= _provinciaEstadoRepositorio.GetProvinciaEstados(paisId,textoFiltro);
            return _mapper.Map<List<ProvinciaEstadoListDto>>(provinciasEstados);
        }

        public bool Guardar(ProvinciaEstado provinciaEstado, out List<string> errores)
        {
            errores=new List<string>();
            if (_provinciaEstadoRepositorio.Existe(provinciaEstado))
            {
                errores.Add("Provincia/Estado existente");
                return false;
            }
            if (provinciaEstado.ProvinciaEstadoId==0)
            {
                _provinciaEstadoRepositorio.Agregar(provinciaEstado);
                return true;
            }
            _provinciaEstadoRepositorio.Editar(provinciaEstado);
            return true;
        }
    }
}
