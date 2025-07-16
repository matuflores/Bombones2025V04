using AutoMapper;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Ciudad;
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

namespace Bombones2025.Windows
{
    public partial class FrmCiudades : Form
    {
        private readonly ICiudadServicio _ciudadServicio;
        private readonly IProvinciaEstadoServicio _provinciaEstadoServicio;
        private readonly IPaisServicio _paisServicio;
        private readonly IMapper _mapper;
        private bool filtrarOn = false;
        private List<CiudadListDto>? ciudades;

        public FrmCiudades(ICiudadServicio ciudadServicio, IProvinciaEstadoServicio provinciaEstadoServicio,
            IPaisServicio paisServicio, IMapper mapper)
        {
            InitializeComponent();
            _ciudadServicio = ciudadServicio;
            _provinciaEstadoServicio = provinciaEstadoServicio;
            _paisServicio = paisServicio;
            _mapper = mapper;
        }

        private void FrmCiudades_Load(object sender, EventArgs e)
        {
            try
            {
                ciudades = _ciudadServicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla()
        {
            GridHelper.LimpiarGrilla(dgvCiudades);
            foreach (var ciudad in ciudades!)
            {
                var r = GridHelper.ConstruirFila(dgvCiudades);

                GridHelper.SetearFila(r, ciudad);
                GridHelper.AgregarFila(r, dgvCiudades);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
