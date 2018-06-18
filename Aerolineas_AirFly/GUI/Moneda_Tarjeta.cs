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
    public partial class frm_Moneda_Tarjeta : Form
    {
        Moneda objMoneda;
        Tarjeta objTarjeta;
        srv_Moneda ServicesMoneda = new srv_Moneda();
        srv_Tarjeta ServicesTarjeta = new srv_Tarjeta();
        public frm_Moneda_Tarjeta()
        {
            InitializeComponent();
        }
        public Moneda datosMoneda()
        {
            objMoneda= new Moneda();
          
            objMoneda.nombre_moneda = txt_NombreMoneda.Text.Trim();
            objMoneda.valor_moneda = Convert.ToDecimal(txt_ValorMoneda.Text.Trim());
            return objMoneda;
        }
        public Tarjeta datosTarjeta()
        {
            objTarjeta = new Tarjeta();
            
            objTarjeta.nombre_tarjeta = txt_NombreTarjeta.Text.Trim();
            return objTarjeta;
        }
        public Moneda ModificarMoneda()
        {
            objMoneda = new Moneda();

            objMoneda.id_moneda = Convert.ToInt32(txt_ClaveMoneda.Text.Trim());            
            objMoneda.nombre_moneda = txt_NombreMoneda.Text.Trim();
            objMoneda.valor_moneda = Convert.ToDecimal(txt_ValorMoneda.Text.Trim());
            return objMoneda;
        }
        public Tarjeta ModificarTarjeta()
        {
            objTarjeta = new Tarjeta();

            objTarjeta.id_tarjeta = Convert.ToInt32(txt_ClaveTarjeta.Text.Trim());
            objTarjeta.nombre_tarjeta = txt_NombreTarjeta.Text.Trim();
            return objTarjeta;
        }
        public void LimpiarMoneda()
        {
            txt_ClaveMoneda.Clear();
            txt_NombreMoneda.Clear();
            txt_ValorMoneda.Clear();
        }
        public void LimpiarTarjeta()
        {
            txt_ClaveTarjeta.Clear();
            txt_NombreTarjeta.Clear();            
        }
        public void MostrarMoneda()
        {
            dgv_Moneda.AutoGenerateColumns = false;
            dgv_Moneda.DataSource = ServicesMoneda.GetListMoneda();
        }
        public void MostrarTarjeta()
        {
            dgv_Tarjeta.AutoGenerateColumns = false;
            dgv_Tarjeta.DataSource = ServicesTarjeta.GetListTarjeta();
        }

        private void btn_AgregarMoneda_Click(object sender, EventArgs e)
        {
            ServicesMoneda.AgregarMoneda(datosMoneda());
            dgv_Moneda.DataSource = ServicesMoneda.GetListMoneda();
            LimpiarMoneda();
        }

        private void btn_ActualizarMoneda_Click(object sender, EventArgs e)
        {
            ServicesMoneda.ActualizarMoneda(ModificarMoneda());
            dgv_Moneda.DataSource = ServicesMoneda.GetListMoneda();
            LimpiarMoneda();
        }

        private void btn_EliminarMoneda_Click(object sender, EventArgs e)
        {
            ServicesMoneda.EliminarMoneda(ModificarMoneda());
            dgv_Moneda.DataSource = ServicesMoneda.GetListMoneda();
            LimpiarMoneda();
        }

        private void dgv_Moneda_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_ClaveMoneda.Text = Convert.ToString(dgv_Moneda.Rows[filaSeleccionada].Cells[0].Value.ToString());                
                txt_NombreMoneda.Text = dgv_Moneda.Rows[filaSeleccionada].Cells[1].Value.ToString();
                txt_ValorMoneda.Text = Convert.ToString(dgv_Moneda.Rows[filaSeleccionada].Cells[2].Value.ToString());
            }
            catch(Exception)
            {

            }
        }
        private void btn_AgregarTarjeta_Click(object sender, EventArgs e)
        {
            ServicesTarjeta.AgregarTarjeta(datosTarjeta());
            dgv_Tarjeta.DataSource = ServicesTarjeta.GetListTarjeta();
            LimpiarTarjeta();
        }

        private void btn_ActualizarTarjeta_Click(object sender, EventArgs e)
        {
            ServicesTarjeta.ActualizarTarjeta(ModificarTarjeta());
            dgv_Tarjeta.DataSource = ServicesTarjeta.GetListTarjeta();
            LimpiarTarjeta();
        }

        private void btn_EliminarTarjeta_Click(object sender, EventArgs e)
        {
            ServicesTarjeta.EliminarTarjeta(ModificarTarjeta());
            dgv_Tarjeta.DataSource = ServicesTarjeta.GetListTarjeta();
            LimpiarTarjeta();
        }

        private void dgv_Tarjeta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_ClaveTarjeta.Text = Convert.ToString(dgv_Tarjeta.Rows[filaSeleccionada].Cells[0].Value.ToString());
                txt_NombreTarjeta.Text = dgv_Tarjeta.Rows[filaSeleccionada].Cells[1].Value.ToString();             
            }
            catch (Exception)
            {

            }
        }

        private void frm_Moneda_Tarjeta_Load(object sender, EventArgs e)
        {
            MostrarMoneda();
            MostrarTarjeta();
        }
    }
}
