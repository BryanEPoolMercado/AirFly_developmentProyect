namespace Aerolineas_AirFly.GUI
{
    partial class frm_Vuelos_Rutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Vuelos_Rutas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_EliminarVuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarVuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarVuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_CodigoVuelo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmb_NombreAvion = new System.Windows.Forms.ComboBox();
            this.txt_Tiempo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_DistanciaVuelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_Hora = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_NombreRuta = new System.Windows.Forms.ComboBox();
            this.dgv_vuelos_rutas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.RUTA_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_pais = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORIGEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempovuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_NombreRuta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DistanciaRuta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_CodigoRuta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_TiempoRuta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_AeropuertoDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_AeropuertoOrigen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_EliminarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarRuta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos_rutas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 20);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 714);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuCards2);
            this.tabPage2.Controls.Add(this.dgv_vuelos_rutas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Vuelos    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.bunifuCards2.Controls.Add(this.btn_EliminarVuelo);
            this.bunifuCards2.Controls.Add(this.btn_ActualizarVuelo);
            this.bunifuCards2.Controls.Add(this.btn_AgregarVuelo);
            this.bunifuCards2.Controls.Add(this.txt_CodigoVuelo);
            this.bunifuCards2.Controls.Add(this.label13);
            this.bunifuCards2.Controls.Add(this.label10);
            this.bunifuCards2.Controls.Add(this.cmb_NombreAvion);
            this.bunifuCards2.Controls.Add(this.txt_Tiempo);
            this.bunifuCards2.Controls.Add(this.label9);
            this.bunifuCards2.Controls.Add(this.txt_DistanciaVuelo);
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.dt_Hora);
            this.bunifuCards2.Controls.Add(this.label7);
            this.bunifuCards2.Controls.Add(this.dt_Fecha);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.cmb_NombreRuta);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1215, 222);
            this.bunifuCards2.TabIndex = 2;
            // 
            // btn_EliminarVuelo
            // 
            this.btn_EliminarVuelo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarVuelo.BorderRadius = 0;
            this.btn_EliminarVuelo.ButtonText = "Eliminar";
            this.btn_EliminarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarVuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarVuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarVuelo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarVuelo.Iconimage")));
            this.btn_EliminarVuelo.Iconimage_right = null;
            this.btn_EliminarVuelo.Iconimage_right_Selected = null;
            this.btn_EliminarVuelo.Iconimage_Selected = null;
            this.btn_EliminarVuelo.IconMarginLeft = 0;
            this.btn_EliminarVuelo.IconMarginRight = 0;
            this.btn_EliminarVuelo.IconRightVisible = false;
            this.btn_EliminarVuelo.IconRightZoom = 0D;
            this.btn_EliminarVuelo.IconVisible = false;
            this.btn_EliminarVuelo.IconZoom = 40D;
            this.btn_EliminarVuelo.IsTab = false;
            this.btn_EliminarVuelo.Location = new System.Drawing.Point(702, 167);
            this.btn_EliminarVuelo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarVuelo.Name = "btn_EliminarVuelo";
            this.btn_EliminarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarVuelo.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarVuelo.selected = false;
            this.btn_EliminarVuelo.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarVuelo.TabIndex = 40;
            this.btn_EliminarVuelo.Text = "Eliminar";
            this.btn_EliminarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_ActualizarVuelo
            // 
            this.btn_ActualizarVuelo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarVuelo.BorderRadius = 0;
            this.btn_ActualizarVuelo.ButtonText = "Actualizar";
            this.btn_ActualizarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarVuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarVuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarVuelo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarVuelo.Iconimage")));
            this.btn_ActualizarVuelo.Iconimage_right = null;
            this.btn_ActualizarVuelo.Iconimage_right_Selected = null;
            this.btn_ActualizarVuelo.Iconimage_Selected = null;
            this.btn_ActualizarVuelo.IconMarginLeft = 0;
            this.btn_ActualizarVuelo.IconMarginRight = 0;
            this.btn_ActualizarVuelo.IconRightVisible = false;
            this.btn_ActualizarVuelo.IconRightZoom = 0D;
            this.btn_ActualizarVuelo.IconVisible = false;
            this.btn_ActualizarVuelo.IconZoom = 40D;
            this.btn_ActualizarVuelo.IsTab = false;
            this.btn_ActualizarVuelo.Location = new System.Drawing.Point(521, 167);
            this.btn_ActualizarVuelo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarVuelo.Name = "btn_ActualizarVuelo";
            this.btn_ActualizarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarVuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarVuelo.selected = false;
            this.btn_ActualizarVuelo.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarVuelo.TabIndex = 39;
            this.btn_ActualizarVuelo.Text = "Actualizar";
            this.btn_ActualizarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AgregarVuelo
            // 
            this.btn_AgregarVuelo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarVuelo.BorderRadius = 0;
            this.btn_AgregarVuelo.ButtonText = "Agregar";
            this.btn_AgregarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarVuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarVuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarVuelo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarVuelo.Iconimage")));
            this.btn_AgregarVuelo.Iconimage_right = null;
            this.btn_AgregarVuelo.Iconimage_right_Selected = null;
            this.btn_AgregarVuelo.Iconimage_Selected = null;
            this.btn_AgregarVuelo.IconMarginLeft = 0;
            this.btn_AgregarVuelo.IconMarginRight = 0;
            this.btn_AgregarVuelo.IconRightVisible = false;
            this.btn_AgregarVuelo.IconRightZoom = 0D;
            this.btn_AgregarVuelo.IconVisible = false;
            this.btn_AgregarVuelo.IconZoom = 40D;
            this.btn_AgregarVuelo.IsTab = false;
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(341, 167);
            this.btn_AgregarVuelo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarVuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarVuelo.selected = false;
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarVuelo.TabIndex = 38;
            this.btn_AgregarVuelo.Text = "Agregar";
            this.btn_AgregarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_CodigoVuelo
            // 
            this.txt_CodigoVuelo.Location = new System.Drawing.Point(1145, 34);
            this.txt_CodigoVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoVuelo.Name = "txt_CodigoVuelo";
            this.txt_CodigoVuelo.Size = new System.Drawing.Size(56, 22);
            this.txt_CodigoVuelo.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1073, 35);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(38, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Avion";
            // 
            // cmb_NombreAvion
            // 
            this.cmb_NombreAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NombreAvion.FormattingEnabled = true;
            this.cmb_NombreAvion.Location = new System.Drawing.Point(38, 125);
            this.cmb_NombreAvion.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_NombreAvion.Name = "cmb_NombreAvion";
            this.cmb_NombreAvion.Size = new System.Drawing.Size(219, 24);
            this.cmb_NombreAvion.TabIndex = 31;
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(924, 77);
            this.txt_Tiempo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(132, 22);
            this.txt_Tiempo.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(786, 79);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tiempo de vuelo";
            // 
            // txt_DistanciaVuelo
            // 
            this.txt_DistanciaVuelo.Location = new System.Drawing.Point(924, 35);
            this.txt_DistanciaVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DistanciaVuelo.Name = "txt_DistanciaVuelo";
            this.txt_DistanciaVuelo.Size = new System.Drawing.Size(132, 22);
            this.txt_DistanciaVuelo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(840, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Distancia";
            // 
            // dt_Hora
            // 
            this.dt_Hora.Checked = false;
            this.dt_Hora.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt_Hora.Enabled = false;
            this.dt_Hora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_Hora.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_Hora.Location = new System.Drawing.Point(415, 39);
            this.dt_Hora.Margin = new System.Windows.Forms.Padding(4);
            this.dt_Hora.Name = "dt_Hora";
            this.dt_Hora.ShowUpDown = true;
            this.dt_Hora.Size = new System.Drawing.Size(125, 22);
            this.dt_Hora.TabIndex = 25;
            this.dt_Hora.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(363, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hora";
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Location = new System.Drawing.Point(415, 77);
            this.dt_Fecha.Margin = new System.Windows.Forms.Padding(4);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(255, 22);
            this.dt_Fecha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(353, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ruta";
            // 
            // cmb_NombreRuta
            // 
            this.cmb_NombreRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NombreRuta.FormattingEnabled = true;
            this.cmb_NombreRuta.Location = new System.Drawing.Point(38, 44);
            this.cmb_NombreRuta.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_NombreRuta.Name = "cmb_NombreRuta";
            this.cmb_NombreRuta.Size = new System.Drawing.Size(219, 24);
            this.cmb_NombreRuta.TabIndex = 21;
            // 
            // dgv_vuelos_rutas
            // 
            this.dgv_vuelos_rutas.AllowUserToAddRows = false;
            this.dgv_vuelos_rutas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_vuelos_rutas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_vuelos_rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_vuelos_rutas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_vuelos_rutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_vuelos_rutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_vuelos_rutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vuelos_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_vuelos_rutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RUTA_vuelo,
            this.Fecha_vuelo,
            this.Hora_vuelo,
            this.Distancia_vuelo,
            this.Tiempo_vuelo,
            this.Avion_vuelo});
            this.dgv_vuelos_rutas.DoubleBuffered = true;
            this.dgv_vuelos_rutas.EnableHeadersVisualStyles = false;
            this.dgv_vuelos_rutas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_vuelos_rutas.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_vuelos_rutas.Location = new System.Drawing.Point(4, 237);
            this.dgv_vuelos_rutas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_vuelos_rutas.Name = "dgv_vuelos_rutas";
            this.dgv_vuelos_rutas.ReadOnly = true;
            this.dgv_vuelos_rutas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_vuelos_rutas.Size = new System.Drawing.Size(1218, 444);
            this.dgv_vuelos_rutas.TabIndex = 19;
            // 
            // RUTA_vuelo
            // 
            this.RUTA_vuelo.HeaderText = "Ruta";
            this.RUTA_vuelo.Name = "RUTA_vuelo";
            this.RUTA_vuelo.ReadOnly = true;
            // 
            // Fecha_vuelo
            // 
            this.Fecha_vuelo.HeaderText = "Fecha";
            this.Fecha_vuelo.Name = "Fecha_vuelo";
            this.Fecha_vuelo.ReadOnly = true;
            // 
            // Hora_vuelo
            // 
            this.Hora_vuelo.HeaderText = "Hora";
            this.Hora_vuelo.Name = "Hora_vuelo";
            this.Hora_vuelo.ReadOnly = true;
            // 
            // Distancia_vuelo
            // 
            this.Distancia_vuelo.HeaderText = "Distancia";
            this.Distancia_vuelo.Name = "Distancia_vuelo";
            this.Distancia_vuelo.ReadOnly = true;
            // 
            // Tiempo_vuelo
            // 
            this.Tiempo_vuelo.HeaderText = "Tiempo de vuelo";
            this.Tiempo_vuelo.Name = "Tiempo_vuelo";
            this.Tiempo_vuelo.ReadOnly = true;
            // 
            // Avion_vuelo
            // 
            this.Avion_vuelo.HeaderText = "Avion";
            this.Avion_vuelo.Name = "Avion_vuelo";
            this.Avion_vuelo.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_pais);
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Rutas    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_pais
            // 
            this.dgv_pais.AllowUserToAddRows = false;
            this.dgv_pais.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_pais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_pais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pais.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_pais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.ORIGEN,
            this.DESTINO,
            this.distancia,
            this.tiempovuelo});
            this.dgv_pais.DoubleBuffered = true;
            this.dgv_pais.EnableHeadersVisualStyles = false;
            this.dgv_pais.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_pais.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_pais.Location = new System.Drawing.Point(4, 326);
            this.dgv_pais.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pais.Name = "dgv_pais";
            this.dgv_pais.ReadOnly = true;
            this.dgv_pais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pais.Size = new System.Drawing.Size(1213, 355);
            this.dgv_pais.TabIndex = 7;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // ORIGEN
            // 
            this.ORIGEN.HeaderText = "Origen";
            this.ORIGEN.Name = "ORIGEN";
            this.ORIGEN.ReadOnly = true;
            // 
            // DESTINO
            // 
            this.DESTINO.HeaderText = "Destino";
            this.DESTINO.Name = "DESTINO";
            this.DESTINO.ReadOnly = true;
            // 
            // distancia
            // 
            this.distancia.HeaderText = "Distancia";
            this.distancia.Name = "distancia";
            this.distancia.ReadOnly = true;
            // 
            // tiempovuelo
            // 
            this.tiempovuelo.HeaderText = "Tiempo";
            this.tiempovuelo.Name = "tiempovuelo";
            this.tiempovuelo.ReadOnly = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards1.Controls.Add(this.txt_NombreRuta);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.txt_DistanciaRuta);
            this.bunifuCards1.Controls.Add(this.label12);
            this.bunifuCards1.Controls.Add(this.txt_CodigoRuta);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.Controls.Add(this.txt_TiempoRuta);
            this.bunifuCards1.Controls.Add(this.label11);
            this.bunifuCards1.Controls.Add(this.cmb_AeropuertoDestino);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.cmb_AeropuertoOrigen);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.btn_EliminarRuta);
            this.bunifuCards1.Controls.Add(this.btn_ActualizarRuta);
            this.bunifuCards1.Controls.Add(this.btn_AgregarRuta);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1215, 311);
            this.bunifuCards1.TabIndex = 6;
            // 
            // txt_NombreRuta
            // 
            this.txt_NombreRuta.Location = new System.Drawing.Point(605, 43);
            this.txt_NombreRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreRuta.Name = "txt_NombreRuta";
            this.txt_NombreRuta.Size = new System.Drawing.Size(284, 22);
            this.txt_NombreRuta.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre de la ruta:";
            // 
            // txt_DistanciaRuta
            // 
            this.txt_DistanciaRuta.Location = new System.Drawing.Point(605, 92);
            this.txt_DistanciaRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DistanciaRuta.Name = "txt_DistanciaRuta";
            this.txt_DistanciaRuta.Size = new System.Drawing.Size(138, 22);
            this.txt_DistanciaRuta.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(520, 95);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Distancia:";
            // 
            // txt_CodigoRuta
            // 
            this.txt_CodigoRuta.Location = new System.Drawing.Point(1030, 136);
            this.txt_CodigoRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoRuta.Name = "txt_CodigoRuta";
            this.txt_CodigoRuta.Size = new System.Drawing.Size(56, 22);
            this.txt_CodigoRuta.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(958, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Codigo:";
            // 
            // txt_TiempoRuta
            // 
            this.txt_TiempoRuta.Location = new System.Drawing.Point(605, 139);
            this.txt_TiempoRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TiempoRuta.Name = "txt_TiempoRuta";
            this.txt_TiempoRuta.Size = new System.Drawing.Size(138, 22);
            this.txt_TiempoRuta.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(470, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tiempo de vuelo:";
            // 
            // cmb_AeropuertoDestino
            // 
            this.cmb_AeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AeropuertoDestino.FormattingEnabled = true;
            this.cmb_AeropuertoDestino.Location = new System.Drawing.Point(59, 139);
            this.cmb_AeropuertoDestino.Name = "cmb_AeropuertoDestino";
            this.cmb_AeropuertoDestino.Size = new System.Drawing.Size(234, 24);
            this.cmb_AeropuertoDestino.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Aeropuerto de destino:";
            // 
            // cmb_AeropuertoOrigen
            // 
            this.cmb_AeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AeropuertoOrigen.FormattingEnabled = true;
            this.cmb_AeropuertoOrigen.Location = new System.Drawing.Point(59, 43);
            this.cmb_AeropuertoOrigen.Name = "cmb_AeropuertoOrigen";
            this.cmb_AeropuertoOrigen.Size = new System.Drawing.Size(234, 24);
            this.cmb_AeropuertoOrigen.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 26;
            this.label4.Text = "Aeropuerto de Origen:";
            // 
            // btn_EliminarRuta
            // 
            this.btn_EliminarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarRuta.BorderRadius = 0;
            this.btn_EliminarRuta.ButtonText = "Eliminar";
            this.btn_EliminarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarRuta.Iconimage")));
            this.btn_EliminarRuta.Iconimage_right = null;
            this.btn_EliminarRuta.Iconimage_right_Selected = null;
            this.btn_EliminarRuta.Iconimage_Selected = null;
            this.btn_EliminarRuta.IconMarginLeft = 0;
            this.btn_EliminarRuta.IconMarginRight = 0;
            this.btn_EliminarRuta.IconRightVisible = false;
            this.btn_EliminarRuta.IconRightZoom = 0D;
            this.btn_EliminarRuta.IconVisible = false;
            this.btn_EliminarRuta.IconZoom = 40D;
            this.btn_EliminarRuta.IsTab = false;
            this.btn_EliminarRuta.Location = new System.Drawing.Point(706, 260);
            this.btn_EliminarRuta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarRuta.Name = "btn_EliminarRuta";
            this.btn_EliminarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarRuta.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarRuta.selected = false;
            this.btn_EliminarRuta.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarRuta.TabIndex = 25;
            this.btn_EliminarRuta.Text = "Eliminar";
            this.btn_EliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_ActualizarRuta
            // 
            this.btn_ActualizarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarRuta.BorderRadius = 0;
            this.btn_ActualizarRuta.ButtonText = "Actualizar";
            this.btn_ActualizarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarRuta.Iconimage")));
            this.btn_ActualizarRuta.Iconimage_right = null;
            this.btn_ActualizarRuta.Iconimage_right_Selected = null;
            this.btn_ActualizarRuta.Iconimage_Selected = null;
            this.btn_ActualizarRuta.IconMarginLeft = 0;
            this.btn_ActualizarRuta.IconMarginRight = 0;
            this.btn_ActualizarRuta.IconRightVisible = false;
            this.btn_ActualizarRuta.IconRightZoom = 0D;
            this.btn_ActualizarRuta.IconVisible = false;
            this.btn_ActualizarRuta.IconZoom = 40D;
            this.btn_ActualizarRuta.IsTab = false;
            this.btn_ActualizarRuta.Location = new System.Drawing.Point(525, 260);
            this.btn_ActualizarRuta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarRuta.Name = "btn_ActualizarRuta";
            this.btn_ActualizarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarRuta.selected = false;
            this.btn_ActualizarRuta.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarRuta.TabIndex = 24;
            this.btn_ActualizarRuta.Text = "Actualizar";
            this.btn_ActualizarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_AgregarRuta
            // 
            this.btn_AgregarRuta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarRuta.BorderRadius = 0;
            this.btn_AgregarRuta.ButtonText = "Agregar";
            this.btn_AgregarRuta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarRuta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarRuta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarRuta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarRuta.Iconimage")));
            this.btn_AgregarRuta.Iconimage_right = null;
            this.btn_AgregarRuta.Iconimage_right_Selected = null;
            this.btn_AgregarRuta.Iconimage_Selected = null;
            this.btn_AgregarRuta.IconMarginLeft = 0;
            this.btn_AgregarRuta.IconMarginRight = 0;
            this.btn_AgregarRuta.IconRightVisible = false;
            this.btn_AgregarRuta.IconRightZoom = 0D;
            this.btn_AgregarRuta.IconVisible = false;
            this.btn_AgregarRuta.IconZoom = 40D;
            this.btn_AgregarRuta.IsTab = false;
            this.btn_AgregarRuta.Location = new System.Drawing.Point(345, 260);
            this.btn_AgregarRuta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarRuta.Name = "btn_AgregarRuta";
            this.btn_AgregarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarRuta.selected = false;
            this.btn_AgregarRuta.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarRuta.TabIndex = 23;
            this.btn_AgregarRuta.Text = "Agregar";
            this.btn_AgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_Vuelos_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Vuelos_Rutas";
            this.Text = "Vuelos_Rutas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vuelos_rutas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmb_NombreAvion;
        private System.Windows.Forms.TextBox txt_Tiempo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_DistanciaVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_Hora;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_NombreRuta;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_vuelos_rutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTA_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion_vuelo;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarRuta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarRuta;
        private System.Windows.Forms.ComboBox cmb_AeropuertoDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_AeropuertoOrigen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CodigoVuelo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_DistanciaRuta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CodigoRuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TiempoRuta;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempovuelo;
        private System.Windows.Forms.TextBox txt_NombreRuta;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarVuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarVuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarVuelo;
    }
}