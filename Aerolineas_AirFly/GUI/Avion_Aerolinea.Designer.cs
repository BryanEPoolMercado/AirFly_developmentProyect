namespace Aerolineas_AirFly.GUI
{
    partial class frm_Avion_Aerolinea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Avion_Aerolinea));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_EliminarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarAerolinea = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_CodigoAerolinea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreAerolinea = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_aerolineas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolin_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_EliminarAvion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarAvion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarAvion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_NumColumnas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NumFilas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Secciones = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Aerolinea = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_codigoAvion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombreAvion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_aviones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cod_avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numfila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aerolineas)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviones)).BeginInit();
            this.SuspendLayout();
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
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuCards2);
            this.tabPage2.Controls.Add(this.dgv_aerolineas);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Aerolinea    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards2.Controls.Add(this.btn_EliminarAerolinea);
            this.bunifuCards2.Controls.Add(this.btn_ActualizarAerolinea);
            this.bunifuCards2.Controls.Add(this.btn_AgregarAerolinea);
            this.bunifuCards2.Controls.Add(this.txt_CodigoAerolinea);
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.txt_NombreAerolinea);
            this.bunifuCards2.Controls.Add(this.label7);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1215, 292);
            this.bunifuCards2.TabIndex = 2;
            // 
            // btn_EliminarAerolinea
            // 
            this.btn_EliminarAerolinea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarAerolinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarAerolinea.BorderRadius = 0;
            this.btn_EliminarAerolinea.ButtonText = "Eliminar";
            this.btn_EliminarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarAerolinea.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAerolinea.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarAerolinea.Iconimage")));
            this.btn_EliminarAerolinea.Iconimage_right = null;
            this.btn_EliminarAerolinea.Iconimage_right_Selected = null;
            this.btn_EliminarAerolinea.Iconimage_Selected = null;
            this.btn_EliminarAerolinea.IconMarginLeft = 0;
            this.btn_EliminarAerolinea.IconMarginRight = 0;
            this.btn_EliminarAerolinea.IconRightVisible = false;
            this.btn_EliminarAerolinea.IconRightZoom = 0D;
            this.btn_EliminarAerolinea.IconVisible = false;
            this.btn_EliminarAerolinea.IconZoom = 40D;
            this.btn_EliminarAerolinea.IsTab = false;
            this.btn_EliminarAerolinea.Location = new System.Drawing.Point(699, 180);
            this.btn_EliminarAerolinea.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarAerolinea.Name = "btn_EliminarAerolinea";
            this.btn_EliminarAerolinea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAerolinea.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarAerolinea.selected = false;
            this.btn_EliminarAerolinea.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarAerolinea.TabIndex = 34;
            this.btn_EliminarAerolinea.Text = "Eliminar";
            this.btn_EliminarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarAerolinea.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarAerolinea.Click += new System.EventHandler(this.btn_EliminarAerolinea_Click);
            // 
            // btn_ActualizarAerolinea
            // 
            this.btn_ActualizarAerolinea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarAerolinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarAerolinea.BorderRadius = 0;
            this.btn_ActualizarAerolinea.ButtonText = "Actualizar";
            this.btn_ActualizarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarAerolinea.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarAerolinea.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarAerolinea.Iconimage")));
            this.btn_ActualizarAerolinea.Iconimage_right = null;
            this.btn_ActualizarAerolinea.Iconimage_right_Selected = null;
            this.btn_ActualizarAerolinea.Iconimage_Selected = null;
            this.btn_ActualizarAerolinea.IconMarginLeft = 0;
            this.btn_ActualizarAerolinea.IconMarginRight = 0;
            this.btn_ActualizarAerolinea.IconRightVisible = false;
            this.btn_ActualizarAerolinea.IconRightZoom = 0D;
            this.btn_ActualizarAerolinea.IconVisible = false;
            this.btn_ActualizarAerolinea.IconZoom = 40D;
            this.btn_ActualizarAerolinea.IsTab = false;
            this.btn_ActualizarAerolinea.Location = new System.Drawing.Point(521, 180);
            this.btn_ActualizarAerolinea.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarAerolinea.Name = "btn_ActualizarAerolinea";
            this.btn_ActualizarAerolinea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAerolinea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarAerolinea.selected = false;
            this.btn_ActualizarAerolinea.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarAerolinea.TabIndex = 33;
            this.btn_ActualizarAerolinea.Text = "Actualizar";
            this.btn_ActualizarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarAerolinea.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarAerolinea.Click += new System.EventHandler(this.btn_ActualizarAerolinea_Click);
            // 
            // btn_AgregarAerolinea
            // 
            this.btn_AgregarAerolinea.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarAerolinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAerolinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarAerolinea.BorderRadius = 0;
            this.btn_AgregarAerolinea.ButtonText = "Agregar";
            this.btn_AgregarAerolinea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAerolinea.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarAerolinea.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAerolinea.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarAerolinea.Iconimage")));
            this.btn_AgregarAerolinea.Iconimage_right = null;
            this.btn_AgregarAerolinea.Iconimage_right_Selected = null;
            this.btn_AgregarAerolinea.Iconimage_Selected = null;
            this.btn_AgregarAerolinea.IconMarginLeft = 0;
            this.btn_AgregarAerolinea.IconMarginRight = 0;
            this.btn_AgregarAerolinea.IconRightVisible = false;
            this.btn_AgregarAerolinea.IconRightZoom = 0D;
            this.btn_AgregarAerolinea.IconVisible = false;
            this.btn_AgregarAerolinea.IconZoom = 40D;
            this.btn_AgregarAerolinea.IsTab = false;
            this.btn_AgregarAerolinea.Location = new System.Drawing.Point(341, 180);
            this.btn_AgregarAerolinea.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarAerolinea.Name = "btn_AgregarAerolinea";
            this.btn_AgregarAerolinea.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAerolinea.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarAerolinea.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarAerolinea.selected = false;
            this.btn_AgregarAerolinea.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarAerolinea.TabIndex = 32;
            this.btn_AgregarAerolinea.Text = "Agregar";
            this.btn_AgregarAerolinea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarAerolinea.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarAerolinea.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAerolinea.Click += new System.EventHandler(this.btn_AgregarAerolinea_Click);
            // 
            // txt_CodigoAerolinea
            // 
            this.txt_CodigoAerolinea.Location = new System.Drawing.Point(453, 51);
            this.txt_CodigoAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CodigoAerolinea.Name = "txt_CodigoAerolinea";
            this.txt_CodigoAerolinea.Size = new System.Drawing.Size(68, 22);
            this.txt_CodigoAerolinea.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Codigo:";
            // 
            // txt_NombreAerolinea
            // 
            this.txt_NombreAerolinea.Location = new System.Drawing.Point(453, 81);
            this.txt_NombreAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreAerolinea.Name = "txt_NombreAerolinea";
            this.txt_NombreAerolinea.Size = new System.Drawing.Size(202, 22);
            this.txt_NombreAerolinea.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(267, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre de la aerolinea:";
            // 
            // dgv_aerolineas
            // 
            this.dgv_aerolineas.AllowUserToAddRows = false;
            this.dgv_aerolineas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_aerolineas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_aerolineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aerolineas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_aerolineas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aerolineas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aerolineas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_aerolineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aerolineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.aerolin_nom});
            this.dgv_aerolineas.DoubleBuffered = true;
            this.dgv_aerolineas.EnableHeadersVisualStyles = false;
            this.dgv_aerolineas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.dgv_aerolineas.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_aerolineas.Location = new System.Drawing.Point(4, 307);
            this.dgv_aerolineas.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_aerolineas.Name = "dgv_aerolineas";
            this.dgv_aerolineas.ReadOnly = true;
            this.dgv_aerolineas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_aerolineas.Size = new System.Drawing.Size(1218, 374);
            this.dgv_aerolineas.TabIndex = 2;
            this.dgv_aerolineas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_aerolineas_CellMouseClick);
            // 
            // clave
            // 
            this.clave.DataPropertyName = "id_aerolinea";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // aerolin_nom
            // 
            this.aerolin_nom.DataPropertyName = "nombre_aerolinea";
            this.aerolin_nom.HeaderText = "Nombre de aerolinea";
            this.aerolin_nom.Name = "aerolin_nom";
            this.aerolin_nom.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bunifuCards1);
            this.tabPage1.Controls.Add(this.dgv_aviones);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Avion    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards1.Controls.Add(this.btn_EliminarAvion);
            this.bunifuCards1.Controls.Add(this.btn_ActualizarAvion);
            this.bunifuCards1.Controls.Add(this.btn_AgregarAvion);
            this.bunifuCards1.Controls.Add(this.txt_NumColumnas);
            this.bunifuCards1.Controls.Add(this.label6);
            this.bunifuCards1.Controls.Add(this.txt_NumFilas);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.cmb_Secciones);
            this.bunifuCards1.Controls.Add(this.label5);
            this.bunifuCards1.Controls.Add(this.cmb_Aerolinea);
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.Controls.Add(this.txt_codigoAvion);
            this.bunifuCards1.Controls.Add(this.label9);
            this.bunifuCards1.Controls.Add(this.txt_nombreAvion);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(9, 7);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1208, 340);
            this.bunifuCards1.TabIndex = 1;
            // 
            // btn_EliminarAvion
            // 
            this.btn_EliminarAvion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarAvion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarAvion.BorderRadius = 0;
            this.btn_EliminarAvion.ButtonText = "Eliminar";
            this.btn_EliminarAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarAvion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarAvion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarAvion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarAvion.Iconimage")));
            this.btn_EliminarAvion.Iconimage_right = null;
            this.btn_EliminarAvion.Iconimage_right_Selected = null;
            this.btn_EliminarAvion.Iconimage_Selected = null;
            this.btn_EliminarAvion.IconMarginLeft = 0;
            this.btn_EliminarAvion.IconMarginRight = 0;
            this.btn_EliminarAvion.IconRightVisible = false;
            this.btn_EliminarAvion.IconRightZoom = 0D;
            this.btn_EliminarAvion.IconVisible = false;
            this.btn_EliminarAvion.IconZoom = 40D;
            this.btn_EliminarAvion.IsTab = false;
            this.btn_EliminarAvion.Location = new System.Drawing.Point(682, 264);
            this.btn_EliminarAvion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarAvion.Name = "btn_EliminarAvion";
            this.btn_EliminarAvion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarAvion.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarAvion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarAvion.selected = false;
            this.btn_EliminarAvion.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarAvion.TabIndex = 31;
            this.btn_EliminarAvion.Text = "Eliminar";
            this.btn_EliminarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarAvion.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarAvion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarAvion.Click += new System.EventHandler(this.btn_EliminarAvion_Click);
            // 
            // btn_ActualizarAvion
            // 
            this.btn_ActualizarAvion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarAvion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarAvion.BorderRadius = 0;
            this.btn_ActualizarAvion.ButtonText = "Actualizar";
            this.btn_ActualizarAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarAvion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarAvion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarAvion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarAvion.Iconimage")));
            this.btn_ActualizarAvion.Iconimage_right = null;
            this.btn_ActualizarAvion.Iconimage_right_Selected = null;
            this.btn_ActualizarAvion.Iconimage_Selected = null;
            this.btn_ActualizarAvion.IconMarginLeft = 0;
            this.btn_ActualizarAvion.IconMarginRight = 0;
            this.btn_ActualizarAvion.IconRightVisible = false;
            this.btn_ActualizarAvion.IconRightZoom = 0D;
            this.btn_ActualizarAvion.IconVisible = false;
            this.btn_ActualizarAvion.IconZoom = 40D;
            this.btn_ActualizarAvion.IsTab = false;
            this.btn_ActualizarAvion.Location = new System.Drawing.Point(501, 264);
            this.btn_ActualizarAvion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarAvion.Name = "btn_ActualizarAvion";
            this.btn_ActualizarAvion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarAvion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarAvion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarAvion.selected = false;
            this.btn_ActualizarAvion.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarAvion.TabIndex = 30;
            this.btn_ActualizarAvion.Text = "Actualizar";
            this.btn_ActualizarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarAvion.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarAvion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarAvion.Click += new System.EventHandler(this.btn_ActualizarAvion_Click);
            // 
            // btn_AgregarAvion
            // 
            this.btn_AgregarAvion.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarAvion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAvion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarAvion.BorderRadius = 0;
            this.btn_AgregarAvion.ButtonText = "Agregar";
            this.btn_AgregarAvion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarAvion.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarAvion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarAvion.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarAvion.Iconimage")));
            this.btn_AgregarAvion.Iconimage_right = null;
            this.btn_AgregarAvion.Iconimage_right_Selected = null;
            this.btn_AgregarAvion.Iconimage_Selected = null;
            this.btn_AgregarAvion.IconMarginLeft = 0;
            this.btn_AgregarAvion.IconMarginRight = 0;
            this.btn_AgregarAvion.IconRightVisible = false;
            this.btn_AgregarAvion.IconRightZoom = 0D;
            this.btn_AgregarAvion.IconVisible = false;
            this.btn_AgregarAvion.IconZoom = 40D;
            this.btn_AgregarAvion.IsTab = false;
            this.btn_AgregarAvion.Location = new System.Drawing.Point(321, 264);
            this.btn_AgregarAvion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarAvion.Name = "btn_AgregarAvion";
            this.btn_AgregarAvion.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarAvion.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarAvion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarAvion.selected = false;
            this.btn_AgregarAvion.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarAvion.TabIndex = 29;
            this.btn_AgregarAvion.Text = "Agregar";
            this.btn_AgregarAvion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarAvion.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarAvion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarAvion.Click += new System.EventHandler(this.btn_AgregarAvion_Click);
            // 
            // txt_NumColumnas
            // 
            this.txt_NumColumnas.Location = new System.Drawing.Point(760, 140);
            this.txt_NumColumnas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumColumnas.Name = "txt_NumColumnas";
            this.txt_NumColumnas.Size = new System.Drawing.Size(39, 22);
            this.txt_NumColumnas.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Numero de columnas:";
            // 
            // txt_NumFilas
            // 
            this.txt_NumFilas.Location = new System.Drawing.Point(759, 109);
            this.txt_NumFilas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumFilas.Name = "txt_NumFilas";
            this.txt_NumFilas.Size = new System.Drawing.Size(40, 22);
            this.txt_NumFilas.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Numero de filas:";
            // 
            // cmb_Secciones
            // 
            this.cmb_Secciones.FormattingEnabled = true;
            this.cmb_Secciones.Location = new System.Drawing.Point(460, 50);
            this.cmb_Secciones.Name = "cmb_Secciones";
            this.cmb_Secciones.Size = new System.Drawing.Size(161, 24);
            this.cmb_Secciones.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Secciones:";
            // 
            // cmb_Aerolinea
            // 
            this.cmb_Aerolinea.FormattingEnabled = true;
            this.cmb_Aerolinea.Location = new System.Drawing.Point(163, 50);
            this.cmb_Aerolinea.Name = "cmb_Aerolinea";
            this.cmb_Aerolinea.Size = new System.Drawing.Size(161, 24);
            this.cmb_Aerolinea.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Aerolinea:";
            // 
            // txt_codigoAvion
            // 
            this.txt_codigoAvion.Location = new System.Drawing.Point(258, 110);
            this.txt_codigoAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigoAvion.Name = "txt_codigoAvion";
            this.txt_codigoAvion.Size = new System.Drawing.Size(68, 22);
            this.txt_codigoAvion.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 111);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Codigo:";
            // 
            // txt_nombreAvion
            // 
            this.txt_nombreAvion.Location = new System.Drawing.Point(258, 140);
            this.txt_nombreAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombreAvion.Name = "txt_nombreAvion";
            this.txt_nombreAvion.Size = new System.Drawing.Size(202, 22);
            this.txt_nombreAvion.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de avion:";
            // 
            // dgv_aviones
            // 
            this.dgv_aviones.AllowUserToAddRows = false;
            this.dgv_aviones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_aviones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_aviones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_aviones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_aviones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_aviones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_aviones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_avion,
            this.aerolinea,
            this.nombre_avion,
            this.secciones,
            this.numfila,
            this.numcolum});
            this.dgv_aviones.DoubleBuffered = true;
            this.dgv_aviones.EnableHeadersVisualStyles = false;
            this.dgv_aviones.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_aviones.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_aviones.Location = new System.Drawing.Point(9, 355);
            this.dgv_aviones.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_aviones.Name = "dgv_aviones";
            this.dgv_aviones.ReadOnly = true;
            this.dgv_aviones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_aviones.Size = new System.Drawing.Size(1208, 326);
            this.dgv_aviones.TabIndex = 1;
            this.dgv_aviones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_aviones_CellMouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 20);
            this.panel1.TabIndex = 0;
            // 
            // cod_avion
            // 
            this.cod_avion.DataPropertyName = "id_avion";
            this.cod_avion.HeaderText = "Codigo";
            this.cod_avion.Name = "cod_avion";
            this.cod_avion.ReadOnly = true;
            // 
            // aerolinea
            // 
            this.aerolinea.DataPropertyName = "id_aerolinea";
            this.aerolinea.HeaderText = "Aerolinea";
            this.aerolinea.Name = "aerolinea";
            this.aerolinea.ReadOnly = true;
            // 
            // nombre_avion
            // 
            this.nombre_avion.DataPropertyName = "nombre_avion";
            this.nombre_avion.HeaderText = "Avion";
            this.nombre_avion.Name = "nombre_avion";
            this.nombre_avion.ReadOnly = true;
            // 
            // secciones
            // 
            this.secciones.DataPropertyName = "id_secciones";
            this.secciones.HeaderText = "Secciones";
            this.secciones.Name = "secciones";
            this.secciones.ReadOnly = true;
            // 
            // numfila
            // 
            this.numfila.DataPropertyName = "numfila_avion";
            this.numfila.HeaderText = "Numero de filas";
            this.numfila.Name = "numfila";
            this.numfila.ReadOnly = true;
            // 
            // numcolum
            // 
            this.numcolum.DataPropertyName = "numcolumna_avion";
            this.numcolum.HeaderText = "Numero de columnas";
            this.numcolum.Name = "numcolum";
            this.numcolum.ReadOnly = true;
            // 
            // frm_Avion_Aerolinea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 734);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Avion_Aerolinea";
            this.Text = "Avion_Aerolinea";
            this.Load += new System.EventHandler(this.frm_Avion_Aerolinea_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aerolineas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aviones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TextBox txt_NumColumnas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_NumFilas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Secciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Aerolinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codigoAvion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombreAvion;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_aviones;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_aerolineas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerolin_nom;
        private System.Windows.Forms.TextBox txt_CodigoAerolinea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreAerolinea;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarAvion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarAvion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarAvion;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarAerolinea;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarAerolinea;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarAerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn secciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfila;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcolum;
    }
}