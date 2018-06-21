using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirFly.GUI;

namespace AirFly.GUI
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //pnl_indicador.Height = btnInicio.Height;
            pnl_indicador.Top = btnInicio.Bottom;
            btn_exit.Visible = true;
        }

        //Metodo para abrir formulario dentro de otro
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnInicio.Bottom;
            AbrirFormulario(new frmInicio());
        }

        private void btnComprarBoleto_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnComprarBoleto.Bottom;
            AbrirFormulario(new frmComprar_boleto());
        }

        private void btnBuscarVuelo_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnBuscarVuelo.Bottom;
            AbrirFormulario(new frmBuscar_vuelos());
        }

        private void btnMisBoletos_Click(object sender, EventArgs e)
        {
            pnl_indicador.Top = btnMisBoletos.Bottom;
            AbrirFormulario(new frmMis_boletos());
        }

      

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            frmAviso_salida_app aviso = new frmAviso_salida_app();
            aviso.ShowDialog();
        }
    }
}
