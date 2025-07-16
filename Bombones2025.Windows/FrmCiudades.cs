using AutoMapper;
using Bombones2025.Entidades;
using Bombones2025.Entidades.DTOs.Ciudad;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.AE;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmCiudadesAE frm = new FrmCiudadesAE(_paisServicio,_provinciaEstadoServicio) { Text = "Agregar Fruto Seco" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            var ciudadEditDto = frm.GetCiudad();
            if (ciudadEditDto is null) return;
            //try
            //{
            //    if (_ciudadServicio.Guardar(ciudadEditDto, out var errores))
            //    {
            //        //Tengo que generar un CiudadListDto para mostrarlo en la grilla
            //        CiudadListDto ciudadDto = _mapper.Map<CiudadListDto>(ciudadEditDto);
            //        //Tengo que obtener los datos que me faltan!!!
            //        var provinciaDto = _provinciaServicio.GetById(ciudadEditDto.ProvinciaEstadoId);
            //        ciudadDto.NombreProvincia = provinciaDto.NombreProvinciaEstado;
            //        var paisDto = _paisServicio.GetById(provinciaDto.PaisId);
            //        ciudadDto.NombrePais = paisDto.NombrePais;
            //        //Joya ya tengo todos los datos... ahora lo muestro
            //        DataGridViewRow r = GridHelper.ConstruirFila(dgvDatos);
            //        GridHelper.SetearFila(r, ciudadDto!);
            //        GridHelper.AgregarFila(r, dgvDatos);
            //        MessageBox.Show("Registro Agregado", "Información",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }

            //    else
            //    {
            //        MessageBox.Show(errores.First(), "Error",
            //            MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
