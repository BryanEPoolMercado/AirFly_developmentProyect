namespace Aerolineas_AirFly.GUI
{
    partial class frm_PaisesCiudades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PaisesCiudades));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_cod_pais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombrePais = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_pais = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cmb_NombrePais = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CodigoCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NombreCiudad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_ciudad = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.cmb_Ciudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CodigoAeropuerto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_NombreAeropuerto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_Aeropuertos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_EliminarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarAeropuerto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EliminarCiudad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarCiudad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarCiudad = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_EliminarPais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ModificarPais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarPais = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aeropuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ciudad)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 20);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 714);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuCards2);
            this.tabPage2.Controls.Add(this.dgv_pais);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Paises    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards2.Controls.Add(this.btn_EliminarPais);
            this.bunifuCards2.Controls.Add(this.btn_ModificarPais);
            this.bunifuCards2.Controls.Add(this.btn_AgregarPais);
            this.bunifuCards2.Controls.Add(this.txt_cod_pais);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.txt_nombrePais);
            this.bunifuCards2.Controls.Add(this.label7);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1213, 275);
            this.bunifuCards2.TabIndex = 5;
            // 
            // txt_cod_pais
            // 
            this.txt_cod_pais.Location = new System.Drawing.Point(401, 68);
            this.txt_cod_pais.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cod_pais.Name = "txt_cod_pais";
            this.txt_cod_pais.Size = new System.Drawing.Size(68, 22);
            this.txt_cod_pais.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo:";
            // 
            // txt_nombrePais
            // 
            this.txt_nombrePais.Location = new System.Drawing.Point(401, 101);
            this.txt_nombrePais.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombrePais.Name = "txt_nombrePais";
            this.txt_nombrePais.Size = new System.Drawing.Size(307, 22);
            this.txt_nombrePais.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre de pais:";
            // 
            // dgv_pais
            // 
            this.dgv_pais.AllowUserToAddRows = false;
            this.dgv_pais.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_pais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_pais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pais.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_pais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_pais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_pais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_pais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pais,
            this.Nombre_pais});
            this.dgv_pais.DoubleBuffered = true;
            this.dgv_pais.EnableHeadersVisualStyles = false;
            this.dgv_pais.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_pais.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_pais.Location = new System.Drawing.Point(4, 290);
            this.dgv_pais.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_pais.Name = "dgv_pais";
            this.dgv_pais.ReadOnly = true;
            this.dgv_pais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_pais.Size = new System.Drawing.Size(1213, 391);
            this.dgv_pais.TabIndex = 1;
            this.dgv_pais.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_pais_CellMouseClick);
            // 
            // id_pais
            // 
            this.id_pais.DataPropertyName = "id_pais";
            this.id_pais.HeaderText = "Clave";
            this.id_pais.Name = "id_pais";
            this.id_pais.ReadOnly = true;
            // 
            // Nombre_pais
            // 
            this.Nombre_pais.DataPropertyName = "nombre_pais";
            this.Nombre_pais.HeaderText = "Pais";
            this.Nombre_pais.Name = "Nombre_pais";
            this.Nombre_pais.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Controls.Add(this.dgv_ciudad);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Ciudad    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards1.Controls.Add(this.btn_EliminarCiudad);
            this.bunifuCards1.Controls.Add(this.btn_ActualizarCiudad);
            this.bunifuCards1.Controls.Add(this.btn_AgregarCiudad);
            this.bunifuCards1.Controls.Add(this.cmb_NombrePais);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.txt_CodigoCiudad);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.txt_NombreCiudad);
            this.bunifuCards1.Controls.Add(this.label8);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1215, 292);
            this.bunifuCards1.TabIndex = 6;
            // 
            // cmb_NombrePais
            // 
            this.cmb_NombrePais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_NombrePais.FormattingEnabled = true;
            this.cmb_NombrePais.Location = new System.Drawing.Point(182, 69);
            this.cmb_NombrePais.Name = "cmb_NombrePais";
            this.cmb_NombrePais.Size = new System.Drawing.Size(319, 24);
            this.cmb_NombrePais.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre del pais:";
            // 
            // txt_CodigoCiudad
            // 
            this.txt_CodigoCiudad.Location = new System.Drawing.Point(761, 41);
            this.txt_CodigoCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoCiudad.Name = "txt_CodigoCiudad";
            this.txt_CodigoCiudad.Size = new System.Drawing.Size(121, 22);
            this.txt_CodigoCiudad.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(689, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Codigo:";
            // 
            // txt_NombreCiudad
            // 
            this.txt_NombreCiudad.Location = new System.Drawing.Point(761, 71);
            this.txt_NombreCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreCiudad.Name = "txt_NombreCiudad";
            this.txt_NombreCiudad.Size = new System.Drawing.Size(320, 22);
            this.txt_NombreCiudad.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(607, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre de ciudad:";
            // 
            // dgv_ciudad
            // 
            this.dgv_ciudad.AllowUserToAddRows = false;
            this.dgv_ciudad.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_ciudad.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ciudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ciudad.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_ciudad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ciudad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ciudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Ciudad,
            this.idpais,
            this.Nombre_ciudad});
            this.dgv_ciudad.DoubleBuffered = true;
            this.dgv_ciudad.EnableHeadersVisualStyles = false;
            this.dgv_ciudad.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.dgv_ciudad.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_ciudad.Location = new System.Drawing.Point(4, 307);
            this.dgv_ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ciudad.Name = "dgv_ciudad";
            this.dgv_ciudad.ReadOnly = true;
            this.dgv_ciudad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_ciudad.Size = new System.Drawing.Size(1213, 371);
            this.dgv_ciudad.TabIndex = 2;
            this.dgv_ciudad.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ciudad_CellMouseClick);
            // 
            // id_Ciudad
            // 
            this.id_Ciudad.DataPropertyName = "id_ciudad";
            this.id_Ciudad.HeaderText = "Clave";
            this.id_Ciudad.Name = "id_Ciudad";
            this.id_Ciudad.ReadOnly = true;
            // 
            // idpais
            // 
            this.idpais.DataPropertyName = "id_pais";
            this.idpais.HeaderText = "Pais";
            this.idpais.Name = "idpais";
            this.idpais.ReadOnly = true;
            // 
            // Nombre_ciudad
            // 
            this.Nombre_ciudad.DataPropertyName = "nombre_ciudad";
            this.Nombre_ciudad.HeaderText = "Ciudad";
            this.Nombre_ciudad.Name = "Nombre_ciudad";
            this.Nombre_ciudad.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_Aeropuertos);
            this.tabPage3.Controls.Add(this.bunifuCards3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 685);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "     Aeropuertos     ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards3.Controls.Add(this.btn_EliminarAeropuerto);
            this.bunifuCards3.Controls.Add(this.btn_ActualizarAeropuerto);
            this.bunifuCards3.Controls.Add(this.btn_AgregarAeropuerto);
            this.bunifuCards3.Controls.Add(this.cmb_Ciudad);
            this.bunifuCards3.Controls.Add(this.label1);
            this.bunifuCards3.Controls.Add(this.txt_CodigoAeropuerto);
            this.bunifuCards3.Controls.Add(this.label5);
            this.bunifuCards3.Controls.Add(this.txt_NombreAeropuerto);
            this.bunifuCards3.Controls.Add(this.label6);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(1215, 292);
            this.bunifuCards3.TabIndex = 7;
            // 
            // cmb_Ciudad
            // 
            this.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ciudad.FormattingEnabled = true;
            this.cmb_Ciudad.Location = new System.Drawing.Point(411, 66);
            this.cmb_Ciudad.Name = "cmb_Ciudad";
            this.cmb_Ciudad.Size = new System.Drawing.Size(319, 24);
            this.cmb_Ciudad.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ciudad:";
            // 
            // txt_CodigoAeropuerto
            // 
            this.txt_CodigoAeropuerto.Location = new System.Drawing.Point(260, 66);
            this.txt_CodigoAeropuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoAeropuerto.Name = "txt_CodigoAeropuerto";
            this.txt_CodigoAeropuerto.Size = new System.Drawing.Size(51, 22);
            this.txt_CodigoAeropuerto.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo:";
            // 
            // txt_NombreAeropuerto
            // 
            this.txt_NombreAeropuerto.Location = new System.Drawing.Point(411, 134);
            this.txt_NombreAeropuerto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreAeropuerto.Name = "txt_NombreAeropuerto";
            this.txt_NombreAeropuerto.Size = new System.Drawing.Size(320, 22);
            this.txt_NombreAeropuerto.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre del aeropuerto:";
            // 
            // dgv_Aeropuertos
            // 
            this.dgv_Aeropuertos.AllowUserToAddRows = false;
            this.dgv_Aeropuertos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Aeropuertos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Aeropuertos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aeropuertos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Aeropuertos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Aeropuertos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Aeropuertos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Aeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aeropuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.ciudad,
            this.aeropuerto});
            this.dgv_Aeropuertos.DoubleBuffered = true;
            this.dgv_Aeropuertos.EnableHeadersVisualStyles = false;
            this.dgv_Aeropuertos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.dgv_Aeropuertos.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Aeropuertos.Location = new System.Drawing.Point(6, 307);
            this.dgv_Aeropuertos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Aeropuertos.Name = "dgv_Aeropuertos";
            this.dgv_Aeropuertos.ReadOnly = true;
            this.dgv_Aeropuertos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Aeropuertos.Size = new System.Drawing.Size(1213, 371);
            this.dgv_Aeropuertos.TabIndex = 8;
            this.dgv_Aeropuertos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Aeropuertos_CellMouseClick);
            // 
            // btn_EliminarAeropuerto
            // 
            this.btn_EliminarAeropuerto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarAeropuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarAeropuerto.BorderRadius = 0;
            this.btn_EliminarAeropuerto.ButtonText = "Eliminar";
            this.btn_EliminarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarAeropuerto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAeropuerto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarAeropuerto.Iconimage")));
            this.btn_EliminarAeropuerto.Iconimage_right = null;
            this.btn_EliminarAeropuerto.Iconimage_right_Selected = null;
            this.btn_EliminarAeropuerto.Iconimage_Selected = null;
            this.btn_EliminarAeropuerto.IconMarginLeft = 0;
            this.btn_EliminarAeropuerto.IconMarginRight = 0;
            this.btn_EliminarAeropuerto.IconRightVisible = true;
            this.btn_EliminarAeropuerto.IconRightZoom = 0D;
            this.btn_EliminarAeropuerto.IconVisible = true;
            this.btn_EliminarAeropuerto.IconZoom = 40D;
            this.btn_EliminarAeropuerto.IsTab = false;
            this.btn_EliminarAeropuerto.Location = new System.Drawing.Point(705, 233);
            this.btn_EliminarAeropuerto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarAeropuerto.Name = "btn_EliminarAeropuerto";
            this.btn_EliminarAeropuerto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAeropuerto.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarAeropuerto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarAeropuerto.selected = false;
            this.btn_EliminarAeropuerto.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarAeropuerto.TabIndex = 28;
            this.btn_EliminarAeropuerto.Text = "Eliminar";
            this.btn_EliminarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarAeropuerto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarAeropuerto.Click += new System.EventHandler(this.btn_EliminarAeropuerto_Click);
            // 
            // btn_ActualizarAeropuerto
            // 
            this.btn_ActualizarAeropuerto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarAeropuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarAeropuerto.BorderRadius = 0;
            this.btn_ActualizarAeropuerto.ButtonText = "Actualizar";
            this.btn_ActualizarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarAeropuerto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarAeropuerto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarAeropuerto.Iconimage")));
            this.btn_ActualizarAeropuerto.Iconimage_right = null;
            this.btn_ActualizarAeropuerto.Iconimage_right_Selected = null;
            this.btn_ActualizarAeropuerto.Iconimage_Selected = null;
            this.btn_ActualizarAeropuerto.IconMarginLeft = 0;
            this.btn_ActualizarAeropuerto.IconMarginRight = 0;
            this.btn_ActualizarAeropuerto.IconRightVisible = true;
            this.btn_ActualizarAeropuerto.IconRightZoom = 0D;
            this.btn_ActualizarAeropuerto.IconVisible = true;
            this.btn_ActualizarAeropuerto.IconZoom = 40D;
            this.btn_ActualizarAeropuerto.IsTab = false;
            this.btn_ActualizarAeropuerto.Location = new System.Drawing.Point(524, 233);
            this.btn_ActualizarAeropuerto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarAeropuerto.Name = "btn_ActualizarAeropuerto";
            this.btn_ActualizarAeropuerto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAeropuerto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarAeropuerto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarAeropuerto.selected = false;
            this.btn_ActualizarAeropuerto.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarAeropuerto.TabIndex = 27;
            this.btn_ActualizarAeropuerto.Text = "Actualizar";
            this.btn_ActualizarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarAeropuerto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarAeropuerto.Click += new System.EventHandler(this.btn_ActualizarAeropuerto_Click);
            // 
            // btn_AgregarAeropuerto
            // 
            this.btn_AgregarAeropuerto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarAeropuerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAeropuerto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarAeropuerto.BorderRadius = 0;
            this.btn_AgregarAeropuerto.ButtonText = "Agregar";
            this.btn_AgregarAeropuerto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAeropuerto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarAeropuerto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAeropuerto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarAeropuerto.Iconimage")));
            this.btn_AgregarAeropuerto.Iconimage_right = null;
            this.btn_AgregarAeropuerto.Iconimage_right_Selected = null;
            this.btn_AgregarAeropuerto.Iconimage_Selected = null;
            this.btn_AgregarAeropuerto.IconMarginLeft = 0;
            this.btn_AgregarAeropuerto.IconMarginRight = 0;
            this.btn_AgregarAeropuerto.IconRightVisible = true;
            this.btn_AgregarAeropuerto.IconRightZoom = 0D;
            this.btn_AgregarAeropuerto.IconVisible = true;
            this.btn_AgregarAeropuerto.IconZoom = 40D;
            this.btn_AgregarAeropuerto.IsTab = false;
            this.btn_AgregarAeropuerto.Location = new System.Drawing.Point(344, 233);
            this.btn_AgregarAeropuerto.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarAeropuerto.Name = "btn_AgregarAeropuerto";
            this.btn_AgregarAeropuerto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAeropuerto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarAeropuerto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarAeropuerto.selected = false;
            this.btn_AgregarAeropuerto.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarAeropuerto.TabIndex = 26;
            this.btn_AgregarAeropuerto.Text = "Agregar";
            this.btn_AgregarAeropuerto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarAeropuerto.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarAeropuerto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAeropuerto.Click += new System.EventHandler(this.btn_AgregarAeropuerto_Click);
            // 
            // btn_EliminarCiudad
            // 
            this.btn_EliminarCiudad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCiudad.BorderRadius = 0;
            this.btn_EliminarCiudad.ButtonText = "Eliminar";
            this.btn_EliminarCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarCiudad.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarCiudad.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarCiudad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCiudad.Iconimage")));
            this.btn_EliminarCiudad.Iconimage_right = null;
            this.btn_EliminarCiudad.Iconimage_right_Selected = null;
            this.btn_EliminarCiudad.Iconimage_Selected = null;
            this.btn_EliminarCiudad.IconMarginLeft = 0;
            this.btn_EliminarCiudad.IconMarginRight = 0;
            this.btn_EliminarCiudad.IconRightVisible = false;
            this.btn_EliminarCiudad.IconRightZoom = 0D;
            this.btn_EliminarCiudad.IconVisible = false;
            this.btn_EliminarCiudad.IconZoom = 40D;
            this.btn_EliminarCiudad.IsTab = false;
            this.btn_EliminarCiudad.Location = new System.Drawing.Point(706, 211);
            this.btn_EliminarCiudad.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarCiudad.Name = "btn_EliminarCiudad";
            this.btn_EliminarCiudad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarCiudad.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarCiudad.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarCiudad.selected = false;
            this.btn_EliminarCiudad.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarCiudad.TabIndex = 28;
            this.btn_EliminarCiudad.Text = "Eliminar";
            this.btn_EliminarCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarCiudad.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarCiudad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarCiudad.Click += new System.EventHandler(this.btn_EliminarCiudad_Click);
            // 
            // btn_ActualizarCiudad
            // 
            this.btn_ActualizarCiudad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarCiudad.BorderRadius = 0;
            this.btn_ActualizarCiudad.ButtonText = "Actualizar";
            this.btn_ActualizarCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarCiudad.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarCiudad.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarCiudad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarCiudad.Iconimage")));
            this.btn_ActualizarCiudad.Iconimage_right = null;
            this.btn_ActualizarCiudad.Iconimage_right_Selected = null;
            this.btn_ActualizarCiudad.Iconimage_Selected = null;
            this.btn_ActualizarCiudad.IconMarginLeft = 0;
            this.btn_ActualizarCiudad.IconMarginRight = 0;
            this.btn_ActualizarCiudad.IconRightVisible = false;
            this.btn_ActualizarCiudad.IconRightZoom = 0D;
            this.btn_ActualizarCiudad.IconVisible = false;
            this.btn_ActualizarCiudad.IconZoom = 40D;
            this.btn_ActualizarCiudad.IsTab = false;
            this.btn_ActualizarCiudad.Location = new System.Drawing.Point(525, 211);
            this.btn_ActualizarCiudad.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarCiudad.Name = "btn_ActualizarCiudad";
            this.btn_ActualizarCiudad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarCiudad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarCiudad.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarCiudad.selected = false;
            this.btn_ActualizarCiudad.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarCiudad.TabIndex = 27;
            this.btn_ActualizarCiudad.Text = "Actualizar";
            this.btn_ActualizarCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarCiudad.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarCiudad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarCiudad.Click += new System.EventHandler(this.btn_ActualizarCiudad_Click);
            // 
            // btn_AgregarCiudad
            // 
            this.btn_AgregarCiudad.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarCiudad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarCiudad.BorderRadius = 0;
            this.btn_AgregarCiudad.ButtonText = "Agregar";
            this.btn_AgregarCiudad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarCiudad.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarCiudad.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarCiudad.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarCiudad.Iconimage")));
            this.btn_AgregarCiudad.Iconimage_right = null;
            this.btn_AgregarCiudad.Iconimage_right_Selected = null;
            this.btn_AgregarCiudad.Iconimage_Selected = null;
            this.btn_AgregarCiudad.IconMarginLeft = 0;
            this.btn_AgregarCiudad.IconMarginRight = 0;
            this.btn_AgregarCiudad.IconRightVisible = false;
            this.btn_AgregarCiudad.IconRightZoom = 0D;
            this.btn_AgregarCiudad.IconVisible = false;
            this.btn_AgregarCiudad.IconZoom = 40D;
            this.btn_AgregarCiudad.IsTab = false;
            this.btn_AgregarCiudad.Location = new System.Drawing.Point(345, 211);
            this.btn_AgregarCiudad.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarCiudad.Name = "btn_AgregarCiudad";
            this.btn_AgregarCiudad.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarCiudad.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarCiudad.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarCiudad.selected = false;
            this.btn_AgregarCiudad.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarCiudad.TabIndex = 26;
            this.btn_AgregarCiudad.Text = "Agregar";
            this.btn_AgregarCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarCiudad.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarCiudad.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarCiudad.Click += new System.EventHandler(this.btn_AgregarCiudad_Click);
            // 
            // btn_EliminarPais
            // 
            this.btn_EliminarPais.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarPais.BorderRadius = 0;
            this.btn_EliminarPais.ButtonText = "Eliminar";
            this.btn_EliminarPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarPais.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarPais.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarPais.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarPais.Iconimage")));
            this.btn_EliminarPais.Iconimage_right = null;
            this.btn_EliminarPais.Iconimage_right_Selected = null;
            this.btn_EliminarPais.Iconimage_Selected = null;
            this.btn_EliminarPais.IconMarginLeft = 0;
            this.btn_EliminarPais.IconMarginRight = 0;
            this.btn_EliminarPais.IconRightVisible = false;
            this.btn_EliminarPais.IconRightZoom = 0D;
            this.btn_EliminarPais.IconVisible = false;
            this.btn_EliminarPais.IconZoom = 40D;
            this.btn_EliminarPais.IsTab = false;
            this.btn_EliminarPais.Location = new System.Drawing.Point(704, 209);
            this.btn_EliminarPais.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarPais.Name = "btn_EliminarPais";
            this.btn_EliminarPais.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarPais.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarPais.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarPais.selected = false;
            this.btn_EliminarPais.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarPais.TabIndex = 28;
            this.btn_EliminarPais.Text = "Eliminar";
            this.btn_EliminarPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarPais.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarPais.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarPais.Click += new System.EventHandler(this.btn_EliminarPais_Click);
            // 
            // btn_ModificarPais
            // 
            this.btn_ModificarPais.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ModificarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ModificarPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ModificarPais.BorderRadius = 0;
            this.btn_ModificarPais.ButtonText = "Actualizar";
            this.btn_ModificarPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ModificarPais.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ModificarPais.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ModificarPais.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ModificarPais.Iconimage")));
            this.btn_ModificarPais.Iconimage_right = null;
            this.btn_ModificarPais.Iconimage_right_Selected = null;
            this.btn_ModificarPais.Iconimage_Selected = null;
            this.btn_ModificarPais.IconMarginLeft = 0;
            this.btn_ModificarPais.IconMarginRight = 0;
            this.btn_ModificarPais.IconRightVisible = false;
            this.btn_ModificarPais.IconRightZoom = 0D;
            this.btn_ModificarPais.IconVisible = false;
            this.btn_ModificarPais.IconZoom = 40D;
            this.btn_ModificarPais.IsTab = false;
            this.btn_ModificarPais.Location = new System.Drawing.Point(523, 209);
            this.btn_ModificarPais.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ModificarPais.Name = "btn_ModificarPais";
            this.btn_ModificarPais.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ModificarPais.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ModificarPais.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ModificarPais.selected = false;
            this.btn_ModificarPais.Size = new System.Drawing.Size(149, 33);
            this.btn_ModificarPais.TabIndex = 27;
            this.btn_ModificarPais.Text = "Actualizar";
            this.btn_ModificarPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ModificarPais.Textcolor = System.Drawing.Color.White;
            this.btn_ModificarPais.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificarPais.Click += new System.EventHandler(this.btn_ModificarPais_Click);
            // 
            // btn_AgregarPais
            // 
            this.btn_AgregarPais.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarPais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarPais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarPais.BorderRadius = 0;
            this.btn_AgregarPais.ButtonText = "Agregar";
            this.btn_AgregarPais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarPais.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarPais.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarPais.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarPais.Iconimage")));
            this.btn_AgregarPais.Iconimage_right = null;
            this.btn_AgregarPais.Iconimage_right_Selected = null;
            this.btn_AgregarPais.Iconimage_Selected = null;
            this.btn_AgregarPais.IconMarginLeft = 0;
            this.btn_AgregarPais.IconMarginRight = 0;
            this.btn_AgregarPais.IconRightVisible = false;
            this.btn_AgregarPais.IconRightZoom = 0D;
            this.btn_AgregarPais.IconVisible = false;
            this.btn_AgregarPais.IconZoom = 40D;
            this.btn_AgregarPais.IsTab = false;
            this.btn_AgregarPais.Location = new System.Drawing.Point(343, 209);
            this.btn_AgregarPais.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarPais.Name = "btn_AgregarPais";
            this.btn_AgregarPais.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarPais.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarPais.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarPais.selected = false;
            this.btn_AgregarPais.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarPais.TabIndex = 26;
            this.btn_AgregarPais.Text = "Agregar";
            this.btn_AgregarPais.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarPais.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarPais.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPais.Click += new System.EventHandler(this.btn_AgregarPais_Click);
            // 
            // clave
            // 
            this.clave.DataPropertyName = "id_aeropuerto";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.DataPropertyName = "id_ciudad";
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // aeropuerto
            // 
            this.aeropuerto.DataPropertyName = "nombre_aeropuerto";
            this.aeropuerto.HeaderText = "Aeropuerto";
            this.aeropuerto.Name = "aeropuerto";
            this.aeropuerto.ReadOnly = true;
            // 
            // frm_PaisesCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PaisesCiudades";
            this.Text = "PaisesCiudades";
            this.Load += new System.EventHandler(this.frm_PaisesCiudades_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pais)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ciudad)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuertos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.TextBox txt_cod_pais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombrePais;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_pais;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.ComboBox cmb_NombrePais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CodigoCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NombreCiudad;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_ciudad;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Aeropuertos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private System.Windows.Forms.ComboBox cmb_Ciudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CodigoAeropuerto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NombreAeropuerto;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarPais;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ModificarPais;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarPais;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarCiudad;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarCiudad;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarCiudad;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarAeropuerto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarAeropuerto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarAeropuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn aeropuerto;
    }
}