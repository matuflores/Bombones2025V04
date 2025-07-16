﻿using Bombones2025.DatosSql;
using Bombones2025.DatosSql.Interfaces;
using Bombones2025.DatosSql.Repositorios;
using Bombones2025.Servicios.Interfaces;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Configuration;
using System.Diagnostics;

namespace Bombones2025.Infraestructura
{
    public static class AppServices
    {//encargada de inyectar los servicios
        private static IServiceProvider _serviceProvider;//INTERFAZ ME PERMITE CREAR LOS SERVICIOS QUE YO VOY A INYECTAR
        public static void Inicializar()
        {
            var services = new ServiceCollection();

            services.AddDbContext<BombonesDbContext>(options =>
            {
                options.UseSqlServer(ConfigurationManager
                    .ConnectionStrings["MiConexion"].ConnectionString);

                options.EnableSensitiveDataLogging()
                .LogTo(msg => Debug.WriteLine(msg), LogLevel.Information);
            });//LE DIGO QUE TRABAJE CON sql Y QUE TRABAJE CON LA BASE DE DATO



            services.AddScoped<IPaisRepositorio, PaisRepositorioEF>();
            services.AddScoped<IChocolateRepositorio, ChocolateRepositorioEF>();
            services.AddScoped<IFrutoSecoRepositorio, FrutoSecoRepositorioEF>();
            services.AddScoped<IRellenoRepositorio, RellenoRepositorioEF>();
            services.AddScoped<ITipoDePagoRepositorio, FormaDePagoRepositorioEF>();
            services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddScoped<IProvinciaEstadoRepositorio, ProvinciaEstadoRepositorioEF>();

            services.AddScoped<IPaisServicio, PaisServicio>();
            services.AddScoped<IChocolateServicio, ChocolateServicio>();
            services.AddScoped<IFrutoSecoServicio, FrutoSecoServicio>();
            services.AddScoped<IRellenoServicio, RellenoServicio>();
            services.AddScoped<ITipoDePagoServicio, TipoDePagoServicio>();
            services.AddScoped<IUsuarioServicio, UsuarioServicio>();
            services.AddScoped<IProvinciaEstadoServicio, ProvinciaEstadoServicio>();

            services.AddAutoMapper(typeof(MappingProfile).Assembly);

            _serviceProvider = services.BuildServiceProvider();
            //defino una conexion de servicios, luego creo un proveedor de servicios
        }

        public static IServiceProvider? ServiceProvider =>
            _serviceProvider ?? throw new NotImplementedException("DEPENDENCIAS NO ESTABLECIDAS");



    }
}
