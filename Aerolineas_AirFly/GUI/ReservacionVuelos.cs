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
            if(cmb_ruta.Text!="")
            {
                btn_buscarvuelo.Enabled = false;
            }
            else
            {
                btn_buscarvuelo.Enabled = true;
            }
        }
        public void ListaRutas()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Ruta.ToList();

            if (Lista.Count > 0)
            {
                cmb_ruta.DataSource = Lista;
                cmb_ruta.DisplayMember = "nombre_ruta";
                cmb_ruta.ValueMember = "id_ruta";

             
            }

        }

        private void frm_ReservacionVuelos_Load(object sender, EventArgs e)
        {
            ListaRutas();
        }
    }
}
