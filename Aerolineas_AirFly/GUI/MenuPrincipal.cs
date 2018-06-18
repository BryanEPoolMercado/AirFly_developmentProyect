using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolineas_AirFly.GUI
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();

            AbrirFormulario(new frm_FondoPantalla());
        }
        private void AbrirFormulario(object Form_global)
        {
            if (this.panel_Contenedor.Controls.Count > 0)
                this.panel_Contenedor.Controls.RemoveAt(0);
            Form formulario = Form_global as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.panel_Contenedor.Controls.Add(formulario);
            this.panel_Contenedor.Tag = formulario;
            formulario.Show();

        }
        private void btn_inicio_Click(object sender, EventArgs e)
        {
            
            AbrirFormulario(new frm_FondoPantalla());

            pnl_catalogos_dock.Visible = false;
            btn_catalogos.Location = new Point(0, 275);

            if (pnl_inicio_dock.Visible == false)
            {
                pnl_inicio_dock.Visible = true;
                pnl_inicio_dock.Location = new Point(0, 166);
                btn_catalogos.Location = new Point(0, 275);
            }
            else
            {
                pnl_inicio_dock.Visible = false;
                btn_catalogos.Location = new Point(0, 166);

            }
        }

        private void btn_catalogos_Click(object sender, EventArgs e)
        {
            pnl_inicio_dock.Visible = false;
            btn_catalogos.Location = new Point(0, 165);


            if (pnl_inicio_dock.Visible == true)
            {
                pnl_inicio_dock.Visible = false;
                btn_catalogos.Location = new Point(0, 165);
            }
            else
            {
                if (pnl_catalogos_dock.Visible == false)
                {
                    pnl_catalogos_dock.Visible = true;
                }
                else
                {
                    pnl_catalogos_dock.Visible = false;
                }
            }
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            frm_AvisoExit salir = new frm_AvisoExit();
            salir.Show();
        }

        private void btn_HacerReservacion_Click(object sender, EventArgs e)
        {
            if (pnl_inicio_dock.Visible == false)
            {
                pnl_inicio_dock.Visible = true;
                btn_catalogos.Location = new Point(0, 275);
            }
            else
            {
                pnl_inicio_dock.Visible = false;
                btn_catalogos.Location = new Point(0, 166);

            }
            AbrirFormulario(new frm_ReservacionVuelos());
        }

        private void btn_MisReservaciones_Click(object sender, EventArgs e)
        {
            if (pnl_inicio_dock.Visible == false)
            {
                pnl_inicio_dock.Visible = true;
                btn_catalogos.Location = new Point(0, 275);
            }
            else
            {
                pnl_inicio_dock.Visible = false;
                btn_catalogos.Location = new Point(0, 166);

            }
            AbrirFormulario(new frm_MisReservaciones());
        }

        private void btn_AvionAerolinea_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Avion_Aerolinea());
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_PaisesCiudades_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_PaisesCiudades());
        }

        private void btn_VueloRutas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Vuelos_Rutas());
        }

        private void btn_MonedaTarjeta_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Moneda_Tarjeta());
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frm_Usuarios());
        }
    }
}
