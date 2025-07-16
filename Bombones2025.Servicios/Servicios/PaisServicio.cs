using AutoMapper;
using Bombones2025.DatosSql.Repositorios;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bombones2025.Servicios.Servicios
{
    public class PaisServicio : IPaisServicio
    {
        private readonly IPaisRepositorio? _paisRepositorio;
        //traido el repo lo llamo en el ctor
        private readonly IMapper _mapper;
        public PaisServicio(IPaisRepositorio paisRepositorio, IMapper mapper)
        {
            //_paisRepositorio = new PaisRepositorio(ConstantesDelSistema.umbralCache);
            _paisRepositorio=paisRepositorio;
            _mapper=mapper;
        }

        ////llamo a la lista del repo
        public List<PaisListDto> GetPais(string? textoParaFiltrar=null)
        {
            var paises= _paisRepositorio.GetPais(textoParaFiltrar);
            return _mapper.Map<List<PaisListDto>>(paises);
        }//traida lista desarrollo el frmPaises

        public bool Agregar(PaisEditDto paisDto, out List<string> errores)
        {
            errores = new List<string>();
            Pais pais = _mapper.Map<Pais>(paisDto);
            if (_paisRepositorio.Existe(pais))
            {
                errores.Add("Pais existente!");
                return false;
            }
            _paisRepositorio.Agregar(pais);
            return true;
        }

        public bool Existe(Pais pais)
        {
            return _paisRepositorio.Existe(pais);
        }

        public bool Borrar(int paisId, out List<string> errores)
        {
            errores = new List<string>();
            if (_paisRepositorio.EstaRelacionado(paisId))
            {
                errores.Add("Pais con registros relacionados");
                return false;
            }
            
            _paisRepositorio.Borrar(paisId);
            return true;
        }

        public bool Editar(PaisEditDto paisDto, out List<string> errores)
        {
            errores = new List<string>();
            Pais pais = _mapper.Map<Pais>(paisDto);
            if (_paisRepositorio.Existe(pais))
            {
                errores.Add("Pais Existente!!" + Environment.NewLine + "Edicion denegada");
                return false ;
            }
            _paisRepositorio.Editar(pais);
            return true;
        }

        public bool EstaRelacionado(int paisId)
        {
            throw new NotImplementedException();
        }

        //public bool Existe(Pais pais)
        //{
        //    return _paisRepositorio.Existe(pais);
        //}
        //public void Guardar(Pais pais)
        //{
        //    if (pais.PaisId == 0)
        //    {
        //        _paisRepositorio.Agregar(pais);
        //    }
        //    else
        //    {
        //        _paisRepositorio.Editar(pais);
        //    }
        //}
        //public void Borrar(int paisId)
        //{
        //    _paisRepositorio.Borrar(paisId);
        //}

        //public List<Pais> Filtrar(string textoParaFiltrar)
        //{
        //    return _paisRepositorio.Filtrar(textoParaFiltrar);
        //}






    }
}
