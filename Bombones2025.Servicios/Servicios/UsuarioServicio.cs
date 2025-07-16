﻿using Bombones2025.DatosSql.Repositorios;
using Bombones2025.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025.Servicios.Servicios
{
    public class UsuarioServicio : IUsuarioServicio
    {
        private readonly UsuarioRepositorio usuarioRepositorio;

        public UsuarioServicio()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public Usuario? Login(string username)
        {
            return usuarioRepositorio.Login(username);
        }
    }
}
