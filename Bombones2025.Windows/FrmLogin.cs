﻿using Bombones2025.Entidades;
using Bombones2025.Servicios.Servicios;
using Bombones2025.Windows.Helpers;

namespace Bombones2025.Windows
{
    public partial class FrmLogin : Form
    {
        private Usuario? usuarioLogueado;
        private readonly IUsuarioServicio? _usuarioServicio;
        public FrmLogin(IUsuarioServicio? usuarioServicio)
        {
            InitializeComponent();
            _usuarioServicio = usuarioServicio;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CERRANDO SISTEMA");
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                usuarioLogueado = _usuarioServicio!.Login(textBoxUsuario.Text);
                if (usuarioLogueado is null)
                {
                    errorProviderLogin.SetError(textBoxUsuario, "EL USUARIO NO EXISTE O CLAVE INCORRECTA");
                    textBoxUsuario.SelectAll();
                    return;
                }
                if (!SeguridadHelper.VerificarHash(textBoxClave.Text, usuarioLogueado.ClaveHash))
                {
                    errorProviderLogin.SetError(textBoxClave, "CLAVE INCORRECTA");
                    textBoxClave.SelectAll();
                    return;

                }
                this.Hide();
                FrmPrincipal frm = new FrmPrincipal() { Text = "Menu Principal" };
                frm.SetUsuario(usuarioLogueado);
                frm.ShowDialog();
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProviderLogin.Clear();
            return valido;
        }
    }
}
