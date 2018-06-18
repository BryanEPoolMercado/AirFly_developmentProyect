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
    public partial class frm_Avion_Aerolinea : Form
    {
        Avion objAvion;
        Aerolinea objAerolinea;
        srv_Aviones servicesAvion = new srv_Aviones();
        srv_Aerolinea servicesAerolinea = new srv_Aerolinea();
        public frm_Avion_Aerolinea()
        {
            InitializeComponent();
        }
        public Avion datosAvion()
        {
            objAvion = new Avion();

            objAvion.id_aerolinea = Convert.ToInt32(cmb_Aerolinea.SelectedValue);
            objAvion.id_secciones = Convert.ToInt16(cmb_Secciones.SelectedValue);
            objAvion.nombre_avion = txt_nombreAvion.Text.Trim();
            objAvion.numfila_avion = Convert.ToInt32(txt_NumFilas.Text.Trim());
            objAvion.numcolumna_avion = Convert.ToInt32(txt_NumColumnas.Text.Trim());
            return objAvion;
        }
        public Aerolinea datosAerolinea()
        {
            objAerolinea = new Aerolinea();
          
            objAerolinea.nombre_aerolinea = txt_NombreAerolinea.Text.Trim();
            return objAerolinea;
        }
        public Avion ModificarAvion()
        {
            objAvion = new Avion();

            objAvion.id_avion = Convert.ToInt16(txt_codigoAvion.Text.Trim());
            objAvion.id_aerolinea = Convert.ToInt32(cmb_Aerolinea.SelectedValue);
            objAvion.id_secciones = Convert.ToInt16(cmb_Secciones.SelectedValue);
            objAvion.nombre_avion = txt_nombreAvion.Text.Trim();
            objAvion.numfila_avion = Convert.ToInt32(txt_NumFilas.Text.Trim());
            objAvion.numcolumna_avion = Convert.ToInt32(txt_NumColumnas.Text.Trim());
            return objAvion;
        }
        public Aerolinea ModificarAerolinea()
        {
            objAerolinea = new Aerolinea();

            objAerolinea.id_aerolinea = Convert.ToInt16(txt_CodigoAerolinea.Text.Trim());
            objAerolinea.nombre_aerolinea = txt_NombreAerolinea.Text.Trim();
            return objAerolinea;
        }
        public void LimpiarAvion()
        {
            txt_codigoAvion.Clear();
            txt_nombreAvion.Clear();
            txt_NumFilas.Clear();
            txt_NumColumnas.Clear();
            cmb_Aerolinea.ResetText();
            cmb_Secciones.ResetText();
        }
        public void LimpiarAerolinea()
        {
            txt_CodigoAerolinea.Clear();
            txt_NombreAerolinea.Clear();
        }
        public void MostrarAviones()
        {
            dgv_aviones.AutoGenerateColumns = false;
            dgv_aviones.DataSource = servicesAvion.GetListaAvion();
        }
        public void MostrarAerolinea()
        {
            dgv_aerolineas.AutoGenerateColumns = false;
            dgv_aerolineas.DataSource = servicesAerolinea.GetListAerolinea();
        }
        public void ListaAerolineas()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Aerolinea.ToList();

            if (Lista.Count > 0)
            {
                cmb_Aerolinea.DataSource = Lista;
                cmb_Aerolinea.DisplayMember = "nombre_aerolinea";
                cmb_Aerolinea.ValueMember = "id_aerolinea";
            }
        }
        public void ListaSecciones()
        {
            AirFly_Modelo con = new AirFly_Modelo();

            var Lista = con.Secciones.ToList();

            if (Lista.Count > 0)
            {
                cmb_Secciones.DataSource = Lista;
                cmb_Secciones.DisplayMember = "nombre_seccion";
                cmb_Secciones.ValueMember = "id_secciones";
            }
        }

        private void frm_Avion_Aerolinea_Load(object sender, EventArgs e)
        {
            MostrarAviones();
            MostrarAerolinea();
            ListaSecciones();
            ListaAerolineas();
        }

        private void btn_AgregarAerolinea_Click(object sender, EventArgs e)
        {
            servicesAerolinea.AgregarAerolinea(datosAerolinea());
            dgv_aerolineas.DataSource = servicesAerolinea.GetListAerolinea();
            LimpiarAerolinea();
        }

        private void btn_ActualizarAerolinea_Click(object sender, EventArgs e)
        {
            servicesAerolinea.ActualizarAerolinea(ModificarAerolinea());
            dgv_aerolineas.DataSource = servicesAerolinea.GetListAerolinea();
            LimpiarAerolinea();
        }

        private void btn_EliminarAerolinea_Click(object sender, EventArgs e)
        {
            servicesAerolinea.EliminarAerolinea(ModificarAerolinea());
            dgv_aerolineas.DataSource = servicesAerolinea.GetListAerolinea();
            LimpiarAerolinea();
        }

        private void dgv_aerolineas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_CodigoAerolinea.Text = Convert.ToString(dgv_aerolineas.Rows[filaSeleccionada].Cells[0].Value.ToString());
                txt_NombreAerolinea.Text = Convert.ToString(dgv_aerolineas.Rows[filaSeleccionada].Cells[1].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
        private void btn_AgregarAvion_Click(object sender, EventArgs e)
        {
            servicesAvion.AgregarAvion(datosAvion());
            dgv_aviones.DataSource = servicesAvion.GetListaAvion();
            LimpiarAvion();
        }

        private void btn_ActualizarAvion_Click(object sender, EventArgs e)
        {
            servicesAvion.ActualizarAvion(ModificarAvion());
            dgv_aviones.DataSource = servicesAvion.GetListaAvion();
            LimpiarAvion();
        }

        private void btn_EliminarAvion_Click(object sender, EventArgs e)
        {
            servicesAvion.EliminarAvion(ModificarAvion());
            dgv_aviones.DataSource = servicesAvion.GetListaAvion();
            LimpiarAvion();
        }

        private void dgv_aviones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int filaSeleccionada = e.RowIndex;

                txt_codigoAvion.Text = Convert.ToString(dgv_aviones.Rows[filaSeleccionada].Cells[0].Value.ToString());
                cmb_Aerolinea.Text = Convert.ToString(dgv_aviones.Rows[filaSeleccionada].Cells[1].Value.ToString());
                txt_nombreAvion.Text = dgv_aviones.Rows[filaSeleccionada].Cells[2].Value.ToString();
                cmb_Secciones.Text = dgv_aviones.Rows[filaSeleccionada].Cells[3].Value.ToString();
                txt_NumFilas.Text= Convert.ToString(dgv_aviones.Rows[filaSeleccionada].Cells[4].Value.ToString());
                txt_NumColumnas.Text = Convert.ToString(dgv_aviones.Rows[filaSeleccionada].Cells[5].Value.ToString());
            }
            catch (Exception)
            {

            }
        }
    }
}
