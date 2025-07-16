using Bombones2025.DatosSql.Repositorios;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Entidades.DTOs.ProvinciaEstado;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Windows.Helpers
{
    public static class CombosHelper
    {
        public static void CargarComboPaises(ref ComboBox cbo, IPaisServicio paisServicio)
        {
            var listaPaises = paisServicio.GetPais();
            var defaultPais = new PaisListDto
            {
                PaisId = 0,
                NombrePais = "Selecione País"
            };
            listaPaises.Insert(0, defaultPais);
            cbo.DataSource = listaPaises;
            cbo.DisplayMember = "NombrePais";
            cbo.ValueMember = "PaisId";
            cbo.SelectedIndex = 0;
        }

        public static void CargarComboProvinciasEstados(ref ComboBox cbo,int paisId, IProvinciaEstadoServicio provinciaEstadoServicio)
        {
            var listaProvEst = provinciaEstadoServicio.GetProvinciaEstado(paisId);
            var defaultProvincia = new ProvinciaEstadoListDto
            {
                ProvinciaEstadoId = 0,
                NombreProvinciaEstado = "Selecione Provincia/Estado"
            };
            listaProvEst.Insert(0, defaultProvincia);
            cbo.DataSource = listaProvEst;
            cbo.DisplayMember = "NombreProvinciaEstado";
            cbo.ValueMember = "ProvinciaEstadoId";
            cbo.SelectedIndex = 0;
        }
    }
}
