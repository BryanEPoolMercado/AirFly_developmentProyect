﻿namespace Aerolineas_AirFly.GUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_NombreRuta = new System.Windows.Forms.ComboBox();
            this.dgv_Vuelos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clavevuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUTA_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avion_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Rutas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.mktxt_hora = new System.Windows.Forms.MaskedTextBox();
            this.cmb_horario = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rutas)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 16);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 580);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuCards2);
            this.tabPage2.Controls.Add(this.dgv_Vuelos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(918, 554);
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
            this.bunifuCards2.Controls.Add(this.cmb_horario);
            this.bunifuCards2.Controls.Add(this.mktxt_hora);
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
            this.bunifuCards2.Controls.Add(this.label7);
            this.bunifuCards2.Controls.Add(this.dt_Fecha);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.cmb_NombreRuta);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 6);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(911, 180);
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
            this.btn_EliminarVuelo.Location = new System.Drawing.Point(526, 136);
            this.btn_EliminarVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EliminarVuelo.Name = "btn_EliminarVuelo";
            this.btn_EliminarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarVuelo.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarVuelo.selected = false;
            this.btn_EliminarVuelo.Size = new System.Drawing.Size(112, 27);
            this.btn_EliminarVuelo.TabIndex = 40;
            this.btn_EliminarVuelo.Text = "Eliminar";
            this.btn_EliminarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarVuelo.Click += new System.EventHandler(this.btn_EliminarVuelo_Click);
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
            this.btn_ActualizarVuelo.Location = new System.Drawing.Point(391, 136);
            this.btn_ActualizarVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ActualizarVuelo.Name = "btn_ActualizarVuelo";
            this.btn_ActualizarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarVuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarVuelo.selected = false;
            this.btn_ActualizarVuelo.Size = new System.Drawing.Size(112, 27);
            this.btn_ActualizarVuelo.TabIndex = 39;
            this.btn_ActualizarVuelo.Text = "Actualizar";
            this.btn_ActualizarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarVuelo.Click += new System.EventHandler(this.btn_ActualizarVuelo_Click);
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
            this.btn_AgregarVuelo.Location = new System.Drawing.Point(256, 136);
            this.btn_AgregarVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AgregarVuelo.Name = "btn_AgregarVuelo";
            this.btn_AgregarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarVuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarVuelo.selected = false;
            this.btn_AgregarVuelo.Size = new System.Drawing.Size(112, 27);
            this.btn_AgregarVuelo.TabIndex = 38;
            this.btn_AgregarVuelo.Text = "Agregar";
            this.btn_AgregarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarVuelo.Click += new System.EventHandler(this.btn_AgregarVuelo_Click);
            // 
            // txt_CodigoVuelo
            // 
            this.txt_CodigoVuelo.Location = new System.Drawing.Point(859, 28);
            this.txt_CodigoVuelo.Name = "txt_CodigoVuelo";
            this.txt_CodigoVuelo.Size = new System.Drawing.Size(43, 20);
            this.txt_CodigoVuelo.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(805, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 36;
            this.label13.Text = "Codigo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Avion";
            // 
            // cmb_NombreAvion
            // 
            this.cmb_NombreAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NombreAvion.FormattingEnabled = true;
            this.cmb_NombreAvion.Location = new System.Drawing.Point(28, 102);
            this.cmb_NombreAvion.Name = "cmb_NombreAvion";
            this.cmb_NombreAvion.Size = new System.Drawing.Size(165, 21);
            this.cmb_NombreAvion.TabIndex = 31;
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(693, 63);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(100, 20);
            this.txt_Tiempo.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(590, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Tiempo de vuelo";
            // 
            // txt_DistanciaVuelo
            // 
            this.txt_DistanciaVuelo.Location = new System.Drawing.Point(693, 28);
            this.txt_DistanciaVuelo.Name = "txt_DistanciaVuelo";
            this.txt_DistanciaVuelo.Size = new System.Drawing.Size(100, 20);
            this.txt_DistanciaVuelo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(630, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Distancia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hora";
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Location = new System.Drawing.Point(311, 63);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(192, 20);
            this.dt_Fecha.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ruta";
            // 
            // cmb_NombreRuta
            // 
            this.cmb_NombreRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NombreRuta.FormattingEnabled = true;
            this.cmb_NombreRuta.Location = new System.Drawing.Point(28, 36);
            this.cmb_NombreRuta.Name = "cmb_NombreRuta";
            this.cmb_NombreRuta.Size = new System.Drawing.Size(165, 21);
            this.cmb_NombreRuta.TabIndex = 21;
            // 
            // dgv_Vuelos
            // 
            this.dgv_Vuelos.AllowUserToAddRows = false;
            this.dgv_Vuelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Vuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vuelos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Vuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Vuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavevuelo,
            this.RUTA_vuelo,
            this.Fecha_vuelo,
            this.Hora_vuelo,
            this.Distancia_vuelo,
            this.Tiempo_vuelo,
            this.Avion_vuelo});
            this.dgv_Vuelos.DoubleBuffered = true;
            this.dgv_Vuelos.EnableHeadersVisualStyles = false;
            this.dgv_Vuelos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Vuelos.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Vuelos.Location = new System.Drawing.Point(3, 193);
            this.dgv_Vuelos.Name = "dgv_Vuelos";
            this.dgv_Vuelos.ReadOnly = true;
            this.dgv_Vuelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Vuelos.Size = new System.Drawing.Size(914, 361);
            this.dgv_Vuelos.TabIndex = 19;
            this.dgv_Vuelos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Vuelos_CellMouseClick);
            // 
            // clavevuelo
            // 
            this.clavevuelo.DataPropertyName = "id_vuelo";
            this.clavevuelo.HeaderText = "Clave";
            this.clavevuelo.Name = "clavevuelo";
            this.clavevuelo.ReadOnly = true;
            // 
            // RUTA_vuelo
            // 
            this.RUTA_vuelo.DataPropertyName = "nombre_ruta";
            this.RUTA_vuelo.HeaderText = "Ruta";
            this.RUTA_vuelo.Name = "RUTA_vuelo";
            this.RUTA_vuelo.ReadOnly = true;
            // 
            // Fecha_vuelo
            // 
            this.Fecha_vuelo.DataPropertyName = "fecha_vuelo";
            this.Fecha_vuelo.HeaderText = "Fecha";
            this.Fecha_vuelo.Name = "Fecha_vuelo";
            this.Fecha_vuelo.ReadOnly = true;
            // 
            // Hora_vuelo
            // 
            this.Hora_vuelo.DataPropertyName = "hora_vuelo";
            this.Hora_vuelo.HeaderText = "Hora";
            this.Hora_vuelo.Name = "Hora_vuelo";
            this.Hora_vuelo.ReadOnly = true;
            // 
            // Distancia_vuelo
            // 
            this.Distancia_vuelo.DataPropertyName = "distancia_vuelo";
            this.Distancia_vuelo.HeaderText = "Distancia";
            this.Distancia_vuelo.Name = "Distancia_vuelo";
            this.Distancia_vuelo.ReadOnly = true;
            // 
            // Tiempo_vuelo
            // 
            this.Tiempo_vuelo.DataPropertyName = "tiempo_vuelo";
            this.Tiempo_vuelo.HeaderText = "Tiempo de vuelo";
            this.Tiempo_vuelo.Name = "Tiempo_vuelo";
            this.Tiempo_vuelo.ReadOnly = true;
            // 
            // Avion_vuelo
            // 
            this.Avion_vuelo.DataPropertyName = "nombre_avion";
            this.Avion_vuelo.HeaderText = "Avion";
            this.Avion_vuelo.Name = "Avion_vuelo";
            this.Avion_vuelo.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Rutas);
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(918, 554);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Rutas    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Rutas
            // 
            this.dgv_Rutas.AllowUserToAddRows = false;
            this.dgv_Rutas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Rutas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Rutas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Rutas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Rutas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Rutas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Rutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.ruta,
            this.ORIGEN,
            this.DESTINO,
            this.distancia,
            this.tiempovuelo});
            this.dgv_Rutas.DoubleBuffered = true;
            this.dgv_Rutas.EnableHeadersVisualStyles = false;
            this.dgv_Rutas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Rutas.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Rutas.Location = new System.Drawing.Point(3, 265);
            this.dgv_Rutas.Name = "dgv_Rutas";
            this.dgv_Rutas.ReadOnly = true;
            this.dgv_Rutas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Rutas.Size = new System.Drawing.Size(910, 288);
            this.dgv_Rutas.TabIndex = 7;
            this.dgv_Rutas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Rutas_CellMouseClick);
            // 
            // clave
            // 
            this.clave.DataPropertyName = "id_ruta";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // ruta
            // 
            this.ruta.DataPropertyName = "nombre_ruta";
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            // 
            // ORIGEN
            // 
            this.ORIGEN.DataPropertyName = "aeropuerto_origen";
            this.ORIGEN.HeaderText = "Origen";
            this.ORIGEN.Name = "ORIGEN";
            this.ORIGEN.ReadOnly = true;
            // 
            // DESTINO
            // 
            this.DESTINO.DataPropertyName = "aeropuerto_destino";
            this.DESTINO.HeaderText = "Destino";
            this.DESTINO.Name = "DESTINO";
            this.DESTINO.ReadOnly = true;
            // 
            // distancia
            // 
            this.distancia.DataPropertyName = "distancia";
            this.distancia.HeaderText = "Distancia";
            this.distancia.Name = "distancia";
            this.distancia.ReadOnly = true;
            // 
            // tiempovuelo
            // 
            this.tiempovuelo.DataPropertyName = "tiempo";
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
            this.bunifuCards1.Location = new System.Drawing.Point(3, 6);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(911, 253);
            this.bunifuCards1.TabIndex = 6;
            // 
            // txt_NombreRuta
            // 
            this.txt_NombreRuta.Location = new System.Drawing.Point(454, 35);
            this.txt_NombreRuta.Name = "txt_NombreRuta";
            this.txt_NombreRuta.Size = new System.Drawing.Size(214, 20);
            this.txt_NombreRuta.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre de la ruta:";
            // 
            // txt_DistanciaRuta
            // 
            this.txt_DistanciaRuta.Location = new System.Drawing.Point(454, 75);
            this.txt_DistanciaRuta.Name = "txt_DistanciaRuta";
            this.txt_DistanciaRuta.Size = new System.Drawing.Size(104, 20);
            this.txt_DistanciaRuta.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(390, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Distancia:";
            // 
            // txt_CodigoRuta
            // 
            this.txt_CodigoRuta.Location = new System.Drawing.Point(772, 110);
            this.txt_CodigoRuta.Name = "txt_CodigoRuta";
            this.txt_CodigoRuta.Size = new System.Drawing.Size(43, 20);
            this.txt_CodigoRuta.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(718, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Codigo:";
            // 
            // txt_TiempoRuta
            // 
            this.txt_TiempoRuta.Location = new System.Drawing.Point(454, 113);
            this.txt_TiempoRuta.Name = "txt_TiempoRuta";
            this.txt_TiempoRuta.Size = new System.Drawing.Size(104, 20);
            this.txt_TiempoRuta.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(352, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Tiempo de vuelo:";
            // 
            // cmb_AeropuertoDestino
            // 
            this.cmb_AeropuertoDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AeropuertoDestino.FormattingEnabled = true;
            this.cmb_AeropuertoDestino.Location = new System.Drawing.Point(44, 113);
            this.cmb_AeropuertoDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_AeropuertoDestino.Name = "cmb_AeropuertoDestino";
            this.cmb_AeropuertoDestino.Size = new System.Drawing.Size(176, 21);
            this.cmb_AeropuertoDestino.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Aeropuerto de destino:";
            // 
            // cmb_AeropuertoOrigen
            // 
            this.cmb_AeropuertoOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AeropuertoOrigen.FormattingEnabled = true;
            this.cmb_AeropuertoOrigen.Location = new System.Drawing.Point(44, 35);
            this.cmb_AeropuertoOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_AeropuertoOrigen.Name = "cmb_AeropuertoOrigen";
            this.cmb_AeropuertoOrigen.Size = new System.Drawing.Size(176, 21);
            this.cmb_AeropuertoOrigen.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
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
            this.btn_EliminarRuta.Location = new System.Drawing.Point(530, 211);
            this.btn_EliminarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_EliminarRuta.Name = "btn_EliminarRuta";
            this.btn_EliminarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarRuta.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarRuta.selected = false;
            this.btn_EliminarRuta.Size = new System.Drawing.Size(112, 27);
            this.btn_EliminarRuta.TabIndex = 25;
            this.btn_EliminarRuta.Text = "Eliminar";
            this.btn_EliminarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarRuta.Click += new System.EventHandler(this.btn_EliminarRuta_Click);
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
            this.btn_ActualizarRuta.Location = new System.Drawing.Point(394, 211);
            this.btn_ActualizarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ActualizarRuta.Name = "btn_ActualizarRuta";
            this.btn_ActualizarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarRuta.selected = false;
            this.btn_ActualizarRuta.Size = new System.Drawing.Size(112, 27);
            this.btn_ActualizarRuta.TabIndex = 24;
            this.btn_ActualizarRuta.Text = "Actualizar";
            this.btn_ActualizarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarRuta.Click += new System.EventHandler(this.btn_ActualizarRuta_Click);
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
            this.btn_AgregarRuta.Location = new System.Drawing.Point(259, 211);
            this.btn_AgregarRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_AgregarRuta.Name = "btn_AgregarRuta";
            this.btn_AgregarRuta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarRuta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarRuta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarRuta.selected = false;
            this.btn_AgregarRuta.Size = new System.Drawing.Size(112, 27);
            this.btn_AgregarRuta.TabIndex = 23;
            this.btn_AgregarRuta.Text = "Agregar";
            this.btn_AgregarRuta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarRuta.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarRuta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarRuta.Click += new System.EventHandler(this.btn_AgregarRuta_Click);
            // 
            // mktxt_hora
            // 
            this.mktxt_hora.Location = new System.Drawing.Point(312, 32);
            this.mktxt_hora.Mask = "00:00";
            this.mktxt_hora.Name = "mktxt_hora";
            this.mktxt_hora.Size = new System.Drawing.Size(39, 20);
            this.mktxt_hora.TabIndex = 41;
            this.mktxt_hora.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_horario
            // 
            this.cmb_horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_horario.FormattingEnabled = true;
            this.cmb_horario.Items.AddRange(new object[] {
            "",
            "AM",
            "PM"});
            this.cmb_horario.Location = new System.Drawing.Point(357, 32);
            this.cmb_horario.Name = "cmb_horario";
            this.cmb_horario.Size = new System.Drawing.Size(42, 21);
            this.cmb_horario.TabIndex = 42;
            // 
            // frm_Vuelos_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Vuelos_Rutas";
            this.Text = "Vuelos_Rutas";
            this.Load += new System.EventHandler(this.frm_Vuelos_Rutas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Rutas)).EndInit();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_NombreRuta;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Vuelos;
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Rutas;
        private System.Windows.Forms.TextBox txt_NombreRuta;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarVuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarVuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORIGEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempovuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavevuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUTA_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avion_vuelo;
        private System.Windows.Forms.ComboBox cmb_horario;
        private System.Windows.Forms.MaskedTextBox mktxt_hora;
    }
}