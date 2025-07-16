using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Entidades.DTOs.Pais;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bombones2025.Windows.AE
{
    public partial class FrmCiudadesAE : Form
    {
        private CiudadEditDto? ciudadDto;
        private PaisListDto? paisSeleccionado;
        private readonly IPaisServicio _paisServicio;
        private readonly IProvinciaEstadoServicio _provinciaEstadoServicio;
        public FrmCiudadesAE(IPaisServicio paisServicio, IProvinciaEstadoServicio provinciaEstadoServicio)
        {
            InitializeComponent();
            _paisServicio = paisServicio;
            _provinciaEstadoServicio = provinciaEstadoServicio;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CombosHelper.CargarComboPaises(ref cbCiudadesPais, _paisServicio);
            if (ciudadDto != null)
            {

                var provincia = _provinciaEstadoServicio.GetById(ciudadDto.ProvinciaEstadoId);
                cbCiudadesPais.SelectedValue = provincia!.PaisId;

                CombosHelper.CargarComboProvinciasEstados(ref cbCiudadesProvEstado,
                    provincia.PaisId, _provinciaEstadoServicio);
                cbCiudadesProvEstado.SelectedValue = ciudadDto.ProvinciaEstadoId;
                textBoxCiudad.Text = ciudadDto.NombreCiudad;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public CiudadEditDto GetCiudad()
        {
            return ciudadDto;
        }
        private void cbCiudadesPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCiudadesPais.SelectedIndex > 0)
            {
                paisSeleccionado = (PaisListDto)cbCiudadesPais.SelectedItem!;
                CombosHelper.CargarComboProvinciasEstados(ref cbCiudadesProvEstado,
                    paisSeleccionado.PaisId, _provinciaEstadoServicio);
            }
            else
            {
                paisSeleccionado = null;
                cbCiudadesProvEstado.DataSource = null;
            }
        }

        
    }
}
