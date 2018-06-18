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
    public partial class frm_Vuelos_Rutas : Form
    {
        Vuelos objVuelos;
        Ruta objRuta;
        srv_Vuelos ServicioVuelos = new srv_Vuelos();
        srv_Ruta ServicioRuta = new srv_Ruta();        
        public frm_Vuelos_Rutas()
        {
            InitializeComponent();
        }
        public Vuelos datosVuelos()
        {
            objVuelos = new Vuelos();

            objVuelos.fecha_vuelo = Convert.ToDateTime(dt_Fecha.Text);
            objVuelos.hora_vuelo = mktxt_hora.Text;
            objVuelos.tiempo_vuelo = txt_Tiempo.Text;
            objVuelos.distancia_vuelo = txt_DistanciaVuelo.Text;
            objVuelos.id_avion = Convert.ToInt32(cmb_NombreAvion.SelectedValue);
            objVuelos.id_ruta = Convert.ToInt32(cmb_NombreRuta.SelectedValue);
            return objVuelos;
        }
        public Ruta datosRuta()
        {
            objRuta = new Ruta();

            objRuta.nombre_ruta = txt_NombreRuta.Text.Trim();
            objRuta.distancia = Convert.ToDecimal(txt_DistanciaRuta.Text.Trim());
            objRuta.tiempo = txt_TiempoRuta.Text.Trim();
            objRuta.aeropuerto_origen = Convert.ToInt32(cmb_AeropuertoOrigen.SelectedValue);
            objRuta.aeropuerto_destino = Convert.ToInt32(cmb_AeropuertoDestino.SelectedValue);
            return objRuta;
        }
        public Vuelos ModificarVuelos()
        {
            objVuelos = new Vuelos();

            objVuelos.id_vuelo = Convert.ToInt32(txt_CodigoVuelo.Text.Trim());
            objVuelos.fecha_vuelo = Convert.ToDateTime(dt_Fecha.Text);
            objVuelos.hora_vuelo = mktxt_hora.Text;
            objVuelos.tiempo_vuelo = txt_Tiempo.Text;
            objVuelos.distancia_vuelo = txt_DistanciaVuelo.Text;
            objVuelos.id_avion = Convert.ToInt32(cmb_NombreAvion.SelectedValue);
            objVuelos.id_ruta = Convert.ToInt32(cmb_NombreRuta.SelectedValue);
            return objVuelos;
        }
        public Ruta ModificarRuta()
        {
            objRuta = new Ruta();

            objRuta.id_ruta = Convert.ToInt32(txt_CodigoRuta.Text.Trim());
            objRuta.nombre_ruta = txt_NombreRuta.Text.Trim();
            objRuta.distancia = Convert.ToDecimal(txt_DistanciaRuta.Text.Trim());
            objRuta.tiempo = txt_TiempoRuta.Text.Trim();
            objRuta.aeropuerto_origen = Convert.ToInt32(cmb_AeropuertoOrigen.SelectedValue);
            objRuta.aeropuerto_destino = Convert.ToInt32(cmb_AeropuertoDestino.SelectedValue);
            return objRuta;
        }
        public void LimpiarVuelos()
        {
            txt_CodigoVuelo.Clear();
            txt_DistanciaVuelo.Clear();
            txt_Tiempo.Clear();
            dt_Fecha.ResetText();
            mktxt_hora.Clear();
            cmb_NombreAvion.ResetText();
            cmb_NombreRuta.ResetText();
        }
        public void LimpiarRuta()
        {
            txt_CodigoRuta.Clear();
            txt_NombreRuta.Clear();
            txt_DistanciaRuta.Clear();
            txt_TiempoRuta.Clear();
            cmb_AeropuertoOrigen.ResetText();
            cmb_AeropuertoDestino.ResetText();
        }
        public void MostrarVuelos()
        {
            dgv_Vuelos.AutoGenerateColumns = false;
            dgv_Vuelos.DataSource = ServicioVuelos.GetListaVuelos();
        }
        public void MostrarRuta()
        {
            dgv_Rutas.AutoGenerateColumns = false;
            dgv_Rutas.DataSource = ServicioRuta.GetListaRuta();
        }
        public void ListaRuta()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cmb_NombreRuta.DataSource = Lista;
                cmb_NombreRuta.DisplayMember = "nombre_ruta";
                cmb_NombreRuta.ValueMember = "id_ruta";
            }
        }
        public void ListaAvion()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Avion.ToList();

            if (Lista.Count > 0)
            {
                cmb_NombreAvion.DataSource = Lista;
                cmb_NombreAvion.DisplayMember = "nombre_avion";
                cmb_NombreAvion.ValueMember = "id_avion";
            }
        }
        public void ListaAeropuerto()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Aeropuerto.ToList();

            if (Lista.Count > 0)
            {
                cmb_AeropuertoOrigen.DataSource = Lista;
                cmb_AeropuertoOrigen.DisplayMember = "nombre_aeropuerto";
                cmb_AeropuertoOrigen.ValueMember = "id_aeropuerto";

                cmb_AeropuertoDestino.DataSource = Lista;
                cmb_AeropuertoDestino.DisplayMember = "nombre_aeropuerto";
                cmb_AeropuertoDestino.ValueMember = "id_aeropuerto";
            }
        }

        private void frm_Vuelos_Rutas_Load(object sender, EventArgs e)
        {
            MostrarRuta();
            MostrarVuelos();
            ListaAvion();
            ListaRuta();
            ListaAeropuerto();
        }

        private void btn_AgregarVuelo_Click(object sender, EventArgs e)
        {
            ServicioVuelos.AgregarVuelos(datosVuelos());
            dgv_Vuelos.DataSource = ServicioVuelos.GetListaVuelos();
            LimpiarVuelos();
        }

        private void btn_ActualizarVuelo_Click(object sender, EventArgs e)
        {
            ServicioVuelos.ActualizarVuelos(ModificarVuelos());
            dgv_Vuelos.DataSource = ServicioVuelos.GetListaVuelos();
            LimpiarVuelos();
        }

        private void btn_EliminarVuelo_Click(object sender, EventArgs e)
        {
            ServicioVuelos.EliminarVuelos(ModificarVuelos());
            dgv_Vuelos.DataSource = ServicioVuelos.GetListaVuelos();
            LimpiarVuelos();
        }

        private void dgv_Vuelos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_CodigoVuelo.Text = Convert.ToString(dgv_Vuelos.Rows[filaSeleccionada].Cells[0].Value.ToString());
                cmb_NombreRuta.Text = dgv_Vuelos.Rows[filaSeleccionada].Cells[1].Value.ToString();
                dt_Fecha.Text = Convert.ToString(dgv_Vuelos.Rows[filaSeleccionada].Cells[2].Value.ToString());
                mktxt_hora.Text = dgv_Vuelos.Rows[filaSeleccionada].Cells[3].Value.ToString();
                txt_DistanciaVuelo.Text = dgv_Vuelos.Rows[filaSeleccionada].Cells[4].Value.ToString();
                txt_Tiempo.Text = dgv_Vuelos.Rows[filaSeleccionada].Cells[5].Value.ToString();
                cmb_NombreAvion.Text = dgv_Vuelos.Rows[filaSeleccionada].Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btn_AgregarRuta_Click(object sender, EventArgs e)
        {
            ServicioRuta.AgregarRuta(datosRuta());
            dgv_Rutas.DataSource = ServicioRuta.GetListaRuta();
            LimpiarRuta();
        }

        private void btn_ActualizarRuta_Click(object sender, EventArgs e)
        {
            ServicioRuta.ActualizarRuta(ModificarRuta());
            dgv_Rutas.DataSource = ServicioRuta.GetListaRuta();
            LimpiarRuta();
        }

        private void btn_EliminarRuta_Click(object sender, EventArgs e)
        {
            ServicioRuta.EliminarRuta(ModificarRuta());
            dgv_Rutas.DataSource = ServicioRuta.GetListaRuta();
            LimpiarRuta();
        }

        private void dgv_Rutas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_CodigoRuta.Text = Convert.ToString(dgv_Rutas.Rows[filaSeleccionada].Cells[0].Value.ToString());
                txt_NombreRuta.Text = dgv_Rutas.Rows[filaSeleccionada].Cells[1].Value.ToString();                
                cmb_AeropuertoOrigen.Text = dgv_Rutas.Rows[filaSeleccionada].Cells[2].Value.ToString();
                cmb_AeropuertoDestino.Text = dgv_Rutas.Rows[filaSeleccionada].Cells[3].Value.ToString();
                txt_DistanciaRuta.Text = Convert.ToString(dgv_Rutas.Rows[filaSeleccionada].Cells[4].Value.ToString());
                txt_TiempoRuta.Text = dgv_Rutas.Rows[filaSeleccionada].Cells[5].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
