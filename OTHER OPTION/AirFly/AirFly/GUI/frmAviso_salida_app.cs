using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirFly.GUI
{
    public partial class frmAviso_salida_app : Form
    {
        public frmAviso_salida_app()
        {
            InitializeComponent();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
