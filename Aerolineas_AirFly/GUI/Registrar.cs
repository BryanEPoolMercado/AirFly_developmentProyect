using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Modelo;
using Datos.Servicios;

namespace Aerolineas_AirFly.GUI
{
    public partial class frm_Registrar : Form
    {
        Usuario objUsuario;
        srv_Usuarios servicioUsuario = new srv_Usuarios();
        public frm_Registrar()
        {
            InitializeComponent();
        }

        private void btn_CancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.Show();
        }
        public Usuario datosUsuario()
        {
            objUsuario = new Usuario();

            objUsuario.id_perfil = Convert.ToInt32(txt_Perfil.Text.Trim());
            objUsuario.nombre_usuario = txt_NombreUsuario.Text.Trim();
            objUsuario.apellidopat_usuario = txt_ApellidoPat.Text.Trim();
            objUsuario.apellidomat_usuario = txt_ApellidoMat.Text.Trim();
            objUsuario.correo_usuario = txt_CorreoUsuario.Text.Trim();
            objUsuario.contraseña_usuario = txt_Contrasenia.Text.Trim();

            return objUsuario;
        }
        public Usuario ModificarUsuario()
        {
            objUsuario = new Usuario();

            objUsuario.id_usuario = Convert.ToInt32(txt_ClaveUsuario.Text.Trim());
            objUsuario.id_perfil = Convert.ToInt32(txt_Perfil.Text.Trim());
            objUsuario.nombre_usuario = txt_NombreUsuario.Text.Trim();
            objUsuario.apellidopat_usuario = txt_ApellidoPat.Text.Trim();
            objUsuario.apellidomat_usuario = txt_ApellidoMat.Text.Trim();
            objUsuario.correo_usuario = txt_CorreoUsuario.Text.Trim();
            objUsuario.contraseña_usuario = txt_Contrasenia.Text.Trim();

            return objUsuario;
        }
        public void LimpiarUsuario()
        {
            txt_ClaveUsuario.Clear();           
            txt_NombreUsuario.Clear();
            txt_ApellidoPat.Clear();
            txt_ApellidoMat.Clear();
            txt_CorreoUsuario.Clear();
            txt_Contrasenia.Clear();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            servicioUsuario.AgregarUsuario(datosUsuario());
            LimpiarUsuario();
            frm_MensajeRegistro mensaje = new frm_MensajeRegistro();
            mensaje.Show();            
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.Show();
        }
    }
}
