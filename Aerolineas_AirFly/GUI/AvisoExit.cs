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
    public partial class frm_AvisoExit : Form
    {
        public frm_AvisoExit()
        {
            InitializeComponent();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
