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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //pnl_indicador.Height = btnInicio.Height;
            pnl_indicador.Top = btnInicio.Bottom;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnInicio.Bottom;
        }

        private void btnComprarBoleto_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnComprarBoleto.Bottom;
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnBuscarVuelo.Bottom;
        }

        private void btnMisBoletos_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnMisBoletos.Bottom;
        }
    }
}
