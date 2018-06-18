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
    public partial class frm_PaisesCiudades : Form
    {
        Pais objPais;
        Ciudad objciudad;
        Aeropuerto objAeropuerto;
        srv_Pais ServPais = new srv_Pais();
        srv_Ciudad Servciudad = new srv_Ciudad();
        srv_Aeropuerto ServAeropuerto = new srv_Aeropuerto();
        public frm_PaisesCiudades()
        {
            InitializeComponent();
        }
        public Pais datosPais()
        {
            objPais = new Pais();
            
            objPais.nombre_pais = txt_nombrePais.Text.Trim();
            return objPais;
        }
        public Ciudad datosciudad()
        {
            objciudad = new Ciudad();

            objciudad.id_pais = Convert.ToInt32(cmb_NombrePais.SelectedValue);
            objciudad.nombre_ciudad = txt_NombreCiudad.Text.Trim();
            return objciudad;
        }
        public Aeropuerto datosAeropuerto()
        {
            objAeropuerto = new Aeropuerto();

            objAeropuerto.id_ciudad = Convert.ToInt16(cmb_Ciudad.SelectedValue);
            objAeropuerto.nombre_aeropuerto = txt_NombreAeropuerto.Text.Trim();
            return objAeropuerto;
        }
        public Pais ModificarPais()
        {
            objPais = new Pais();

            objPais.id_pais = Convert.ToInt16(txt_cod_pais.Text.Trim());
            objPais.nombre_pais = txt_nombrePais.Text.Trim();
            return objPais;
        }
        public Ciudad ModificarCiudad()
        {
            objciudad = new Ciudad();

            objciudad.id_ciudad = Convert.ToInt16(txt_CodigoCiudad.Text.Trim());
            objciudad.nombre_ciudad = txt_NombreCiudad.Text.Trim();
            return objciudad;
        }
        public Aeropuerto ModificarAeropuerto()
        {
            objAeropuerto = new Aeropuerto();

            objAeropuerto.id_aeropuerto = Convert.ToInt16(txt_CodigoAeropuerto.Text.Trim());
            objAeropuerto.id_ciudad = Convert.ToInt16(cmb_Ciudad.SelectedValue);
            objAeropuerto.nombre_aeropuerto = txt_NombreAeropuerto.Text.Trim();
            return objAeropuerto;
        }
        public void MostrarPaises()
        {
            dgv_pais.AutoGenerateColumns = false;
            dgv_pais.DataSource = ServPais.GetListPaises();
        }
        public void MostrarCiudades()
        {
            dgv_ciudad.AutoGenerateColumns = false;
            dgv_ciudad.DataSource = Servciudad.GetListCiudad();
        }
        public void MostrarAeropuertos()
        {
            dgv_Aeropuertos.AutoGenerateColumns = false;
            dgv_Aeropuertos.DataSource = ServAeropuerto.GetListAeropuerto();
        }
        public void LimpiarPaises()
        {
            txt_cod_pais.Clear();
            txt_nombrePais.Clear();
        }
        public void LimpiarCiudades()
        {
            cmb_NombrePais.SelectedIndex = 0;
            txt_CodigoCiudad.Clear();
            txt_NombreCiudad.Clear();
        }
        public void LimpiarAeropuerto()
        {
            cmb_Ciudad.SelectedIndex = 0;
            txt_CodigoAeropuerto.Clear();
            txt_NombreAeropuerto.Clear();
        }
        public void ListaPaises()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Pais.ToList();

            if (Lista.Count > 0)
            {
                cmb_NombrePais.DataSource = Lista;
                cmb_NombrePais.DisplayMember = "nombre_pais";
                cmb_NombrePais.ValueMember = "id_pais";
            }
        }
        public void ListaCiudades()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Ciudad.ToList();

            if (Lista.Count > 0)
            {
                cmb_Ciudad.DataSource = Lista;
                cmb_Ciudad.DisplayMember = "nombre_ciudad";
                cmb_Ciudad.ValueMember = "id_ciudad";
            }
        }
        private void frm_PaisesCiudades_Load(object sender, EventArgs e)
        {
            MostrarPaises();
            MostrarCiudades();
            MostrarAeropuertos();
            ListaPaises();
            ListaCiudades();
        }

        private void btn_AgregarPais_Click(object sender, EventArgs e)
        {
            ServPais.AgregarPais(datosPais());
            dgv_pais.DataSource = ServPais.GetListPaises();
            LimpiarPaises();
        }

        private void btn_ModificarPais_Click(object sender, EventArgs e)
        {
            ServPais.ActualizarPais(ModificarPais());
            dgv_pais.DataSource = ServPais.GetListPaises();
            LimpiarPaises();
        }

        private void btn_EliminarPais_Click(object sender, EventArgs e)
        {
            ServPais.EliminarPais(ModificarPais());
            dgv_pais.DataSource = ServPais.GetListPaises();
            LimpiarPaises();
        }

        private void dgv_pais_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_cod_pais.Text = Convert.ToString(dgv_pais.Rows[filaSeleccionada].Cells[0].Value.ToString());
                txt_nombrePais.Text = dgv_pais.Rows[filaSeleccionada].Cells[1].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_AgregarCiudad_Click(object sender, EventArgs e)
        {
            Servciudad.AgregarCiudad(datosciudad());
            dgv_ciudad.DataSource = Servciudad.GetListCiudad();
            LimpiarCiudades();
        }

        private void btn_ActualizarCiudad_Click(object sender, EventArgs e)
        {
            Servciudad.ActualizarCiudad(ModificarCiudad());
            dgv_ciudad.DataSource = Servciudad.GetListCiudad();
            LimpiarCiudades();
        }

        private void btn_EliminarCiudad_Click(object sender, EventArgs e)
        {
            Servciudad.EliminarCiudad(ModificarCiudad());
            dgv_ciudad.DataSource = Servciudad.GetListCiudad();
            LimpiarCiudades();
        }

        private void dgv_ciudad_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_CodigoCiudad.Text = Convert.ToString(dgv_ciudad.Rows[filaSeleccionada].Cells[0].Value.ToString());
                cmb_NombrePais.Text = dgv_ciudad.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txt_NombreCiudad.Text = dgv_ciudad.Rows[filaSeleccionada].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_AgregarAeropuerto_Click(object sender, EventArgs e)
        {
            ServAeropuerto.AgregarAeropuerto(datosAeropuerto());
            dgv_Aeropuertos.DataSource = ServAeropuerto.GetListAeropuerto();
            LimpiarAeropuerto();
        }

        private void btn_ActualizarAeropuerto_Click(object sender, EventArgs e)
        {
            ServAeropuerto.ActualizarAeropuerto(ModificarAeropuerto());
            dgv_Aeropuertos.DataSource = ServAeropuerto.GetListAeropuerto();
            LimpiarAeropuerto();
        }

        private void btn_EliminarAeropuerto_Click(object sender, EventArgs e)
        {
            ServAeropuerto.EliminarAeropuerto(ModificarAeropuerto());
            dgv_Aeropuertos.DataSource = ServAeropuerto.GetListAeropuerto();
            LimpiarAeropuerto();
        }

        private void dgv_Aeropuertos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_CodigoAeropuerto.Text = Convert.ToString(dgv_Aeropuertos.Rows[filaSeleccionada].Cells[0].Value.ToString());
                cmb_Ciudad.Text = dgv_Aeropuertos.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txt_NombreAeropuerto.Text = dgv_Aeropuertos.Rows[filaSeleccionada].Cells[2].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
