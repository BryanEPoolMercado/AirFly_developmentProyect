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
    public partial class frm_Usuarios : Form
    {
        Usuario objUsuario;
        srv_Usuarios servicioUsuario = new srv_Usuarios();
        public frm_Usuarios()
        {
            InitializeComponent();
        }
        public Usuario datosUsuario()
        {
            objUsuario = new Usuario();

            objUsuario.id_perfil = Convert.ToInt32(cmb_Perfil.SelectedValue);
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

            objUsuario.id_usuario= Convert.ToInt32(txt_ClaveUsuario.Text.Trim());
            objUsuario.id_perfil = Convert.ToInt32(cmb_Perfil.SelectedValue);
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
            cmb_Perfil.ResetText();
            txt_NombreUsuario.Clear();
            txt_ApellidoPat.Clear();
            txt_ApellidoMat.Clear();
            txt_CorreoUsuario.Clear();
            txt_Contrasenia.Clear();
        }
        public void MostrarUsuarios()
        {
            dgv_Usuarios.AutoGenerateColumns = false;
            dgv_Usuarios.DataSource = servicioUsuario.GetListaUsuario();
        }
        public void ListaPerfiles()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Perfil.ToList();

            if (Lista.Count > 0)
            {
                cmb_Perfil.DataSource = Lista;
                cmb_Perfil.DisplayMember = "nombre_perfil";
                cmb_Perfil.ValueMember = "id_perfil";
            }
        }

        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            servicioUsuario.AgregarUsuario(datosUsuario());
            dgv_Usuarios.DataSource = servicioUsuario.GetListaUsuario();
            LimpiarUsuario();
        }

        private void btn_ActualizarUsuario_Click(object sender, EventArgs e)
        {
            servicioUsuario.ActualizUsuario(ModificarUsuario());
            dgv_Usuarios.DataSource = servicioUsuario.GetListaUsuario();
            LimpiarUsuario();
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            servicioUsuario.EliminarAerolinea(ModificarUsuario());
            dgv_Usuarios.DataSource = servicioUsuario.GetListaUsuario();
            LimpiarUsuario();
        }

        private void dgv_Usuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_ClaveUsuario.Text = Convert.ToString(dgv_Usuarios.Rows[filaSeleccionada].Cells[0].Value.ToString());
                cmb_Perfil.Text = Convert.ToString(dgv_Usuarios.Rows[filaSeleccionada].Cells[1].Value.ToString());
                txt_NombreUsuario.Text = dgv_Usuarios.Rows[filaSeleccionada].Cells[2].Value.ToString();
                txt_ApellidoPat.Text = dgv_Usuarios.Rows[filaSeleccionada].Cells[3].Value.ToString();
                txt_ApellidoMat.Text = dgv_Usuarios.Rows[filaSeleccionada].Cells[4].Value.ToString();
                txt_CorreoUsuario.Text = dgv_Usuarios.Rows[filaSeleccionada].Cells[5].Value.ToString();
                txt_Contrasenia.Text = dgv_Usuarios.Rows[filaSeleccionada].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
            ListaPerfiles();
        }
    }
}
