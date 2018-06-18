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
            objVuelos.hora_vuelo = dt_Hora.Text;
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
    }
}
