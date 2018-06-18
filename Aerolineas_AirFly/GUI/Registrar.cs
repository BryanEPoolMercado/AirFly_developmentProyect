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
    public partial class frm_Registrar : Form
    {
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
    }
}
