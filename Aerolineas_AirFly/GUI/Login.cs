using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aerolineas_AirFly.GUI;

namespace Aerolineas_AirFly
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            frm_MenuPrincipal menu = new frm_MenuPrincipal();
            menu.Show();
        }

        private void btn_Registro_Click(object sender, EventArgs e)
        {
            frm_Registrar registro = new frm_Registrar();
            registro.Show();
        }

        private void btn_cerrar_main_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
