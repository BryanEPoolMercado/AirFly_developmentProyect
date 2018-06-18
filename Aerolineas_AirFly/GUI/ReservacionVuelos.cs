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

namespace Aerolineas_AirFly.GUI
{
    public partial class frm_ReservacionVuelos : Form
    {
        public frm_ReservacionVuelos()
        {
            InitializeComponent();
        }
        public void ListaCiudades()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Ciudad.ToList();

            if (Lista.Count > 0)
            {
                cmb_Origen.DataSource = Lista;
                cmb_Origen.DisplayMember = "nombre_ciudad";
                cmb_Origen.ValueMember = "id_ciudad";

                cmb_Destino.DataSource = Lista;
                cmb_Destino.DisplayMember = "nombre_ciudad";
                cmb_Destino.ValueMember = "id_ciudad";
            }

        }

        private void frm_ReservacionVuelos_Load(object sender, EventArgs e)
        {
            ListaCiudades();
        }
    }
}
