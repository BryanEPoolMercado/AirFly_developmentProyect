namespace Aerolineas_AirFly.GUI
{
    partial class frm_Moneda_Tarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Moneda_Tarjeta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_ClaveMoneda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EliminarMoneda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarMoneda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarMoneda = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_NombreMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Moneda = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_Tarjeta = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.txt_ClaveTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_EliminarTarjeta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_ActualizarTarjeta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AgregarTarjeta = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_NombreTarjeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clavemoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_ValorMoneda = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarjeta)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 20);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1234, 702);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bunifuCards1);
            this.tabPage2.Controls.Add(this.dgv_Moneda);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 673);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "     Moneda    ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards1.Controls.Add(this.txt_ValorMoneda);
            this.bunifuCards1.Controls.Add(this.txt_ClaveMoneda);
            this.bunifuCards1.Controls.Add(this.label3);
            this.bunifuCards1.Controls.Add(this.btn_EliminarMoneda);
            this.bunifuCards1.Controls.Add(this.btn_ActualizarMoneda);
            this.bunifuCards1.Controls.Add(this.btn_AgregarMoneda);
            this.bunifuCards1.Controls.Add(this.txt_NombreMoneda);
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(4, 7);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = false;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1215, 245);
            this.bunifuCards1.TabIndex = 1;
            // 
            // txt_ClaveMoneda
            // 
            this.txt_ClaveMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClaveMoneda.Location = new System.Drawing.Point(299, 41);
            this.txt_ClaveMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveMoneda.Name = "txt_ClaveMoneda";
            this.txt_ClaveMoneda.Size = new System.Drawing.Size(87, 26);
            this.txt_ClaveMoneda.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Clave:";
            // 
            // btn_EliminarMoneda
            // 
            this.btn_EliminarMoneda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarMoneda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarMoneda.BorderRadius = 0;
            this.btn_EliminarMoneda.ButtonText = "Eliminar";
            this.btn_EliminarMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarMoneda.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarMoneda.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarMoneda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarMoneda.Iconimage")));
            this.btn_EliminarMoneda.Iconimage_right = null;
            this.btn_EliminarMoneda.Iconimage_right_Selected = null;
            this.btn_EliminarMoneda.Iconimage_Selected = null;
            this.btn_EliminarMoneda.IconMarginLeft = 0;
            this.btn_EliminarMoneda.IconMarginRight = 0;
            this.btn_EliminarMoneda.IconRightVisible = false;
            this.btn_EliminarMoneda.IconRightZoom = 0D;
            this.btn_EliminarMoneda.IconVisible = false;
            this.btn_EliminarMoneda.IconZoom = 40D;
            this.btn_EliminarMoneda.IsTab = false;
            this.btn_EliminarMoneda.Location = new System.Drawing.Point(636, 176);
            this.btn_EliminarMoneda.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarMoneda.Name = "btn_EliminarMoneda";
            this.btn_EliminarMoneda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarMoneda.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarMoneda.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarMoneda.selected = false;
            this.btn_EliminarMoneda.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarMoneda.TabIndex = 18;
            this.btn_EliminarMoneda.Text = "Eliminar";
            this.btn_EliminarMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarMoneda.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarMoneda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarMoneda.Click += new System.EventHandler(this.btn_EliminarMoneda_Click);
            // 
            // btn_ActualizarMoneda
            // 
            this.btn_ActualizarMoneda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarMoneda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarMoneda.BorderRadius = 0;
            this.btn_ActualizarMoneda.ButtonText = "Actualizar";
            this.btn_ActualizarMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarMoneda.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarMoneda.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarMoneda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarMoneda.Iconimage")));
            this.btn_ActualizarMoneda.Iconimage_right = null;
            this.btn_ActualizarMoneda.Iconimage_right_Selected = null;
            this.btn_ActualizarMoneda.Iconimage_Selected = null;
            this.btn_ActualizarMoneda.IconMarginLeft = 0;
            this.btn_ActualizarMoneda.IconMarginRight = 0;
            this.btn_ActualizarMoneda.IconRightVisible = false;
            this.btn_ActualizarMoneda.IconRightZoom = 0D;
            this.btn_ActualizarMoneda.IconVisible = false;
            this.btn_ActualizarMoneda.IconZoom = 40D;
            this.btn_ActualizarMoneda.IsTab = false;
            this.btn_ActualizarMoneda.Location = new System.Drawing.Point(455, 176);
            this.btn_ActualizarMoneda.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarMoneda.Name = "btn_ActualizarMoneda";
            this.btn_ActualizarMoneda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarMoneda.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarMoneda.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarMoneda.selected = false;
            this.btn_ActualizarMoneda.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarMoneda.TabIndex = 17;
            this.btn_ActualizarMoneda.Text = "Actualizar";
            this.btn_ActualizarMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarMoneda.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarMoneda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarMoneda.Click += new System.EventHandler(this.btn_ActualizarMoneda_Click);
            // 
            // btn_AgregarMoneda
            // 
            this.btn_AgregarMoneda.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarMoneda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarMoneda.BorderRadius = 0;
            this.btn_AgregarMoneda.ButtonText = "Agregar";
            this.btn_AgregarMoneda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarMoneda.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarMoneda.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarMoneda.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarMoneda.Iconimage")));
            this.btn_AgregarMoneda.Iconimage_right = null;
            this.btn_AgregarMoneda.Iconimage_right_Selected = null;
            this.btn_AgregarMoneda.Iconimage_Selected = null;
            this.btn_AgregarMoneda.IconMarginLeft = 0;
            this.btn_AgregarMoneda.IconMarginRight = 0;
            this.btn_AgregarMoneda.IconRightVisible = false;
            this.btn_AgregarMoneda.IconRightZoom = 0D;
            this.btn_AgregarMoneda.IconVisible = false;
            this.btn_AgregarMoneda.IconZoom = 40D;
            this.btn_AgregarMoneda.IsTab = false;
            this.btn_AgregarMoneda.Location = new System.Drawing.Point(274, 176);
            this.btn_AgregarMoneda.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarMoneda.Name = "btn_AgregarMoneda";
            this.btn_AgregarMoneda.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarMoneda.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarMoneda.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarMoneda.selected = false;
            this.btn_AgregarMoneda.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarMoneda.TabIndex = 16;
            this.btn_AgregarMoneda.Text = "Agregar";
            this.btn_AgregarMoneda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarMoneda.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarMoneda.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarMoneda.Click += new System.EventHandler(this.btn_AgregarMoneda_Click);
            // 
            // txt_NombreMoneda
            // 
            this.txt_NombreMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreMoneda.Location = new System.Drawing.Point(299, 88);
            this.txt_NombreMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreMoneda.Name = "txt_NombreMoneda";
            this.txt_NombreMoneda.Size = new System.Drawing.Size(187, 26);
            this.txt_NombreMoneda.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de moneda:";
            // 
            // dgv_Moneda
            // 
            this.dgv_Moneda.AllowUserToAddRows = false;
            this.dgv_Moneda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Moneda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Moneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Moneda.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Moneda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Moneda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Moneda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Moneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Moneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavemoneda,
            this.moneda,
            this.valor});
            this.dgv_Moneda.DoubleBuffered = true;
            this.dgv_Moneda.EnableHeadersVisualStyles = false;
            this.dgv_Moneda.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Moneda.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Moneda.Location = new System.Drawing.Point(4, 260);
            this.dgv_Moneda.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Moneda.Name = "dgv_Moneda";
            this.dgv_Moneda.ReadOnly = true;
            this.dgv_Moneda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Moneda.Size = new System.Drawing.Size(1218, 409);
            this.dgv_Moneda.TabIndex = 2;
            this.dgv_Moneda.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Moneda_CellMouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_Tarjeta);
            this.tabPage1.Controls.Add(this.bunifuCards2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 673);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Tarjeta    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Tarjeta
            // 
            this.dgv_Tarjeta.AllowUserToAddRows = false;
            this.dgv_Tarjeta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Tarjeta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Tarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tarjeta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Tarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Tarjeta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Tarjeta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Tarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.tarjeta});
            this.dgv_Tarjeta.DoubleBuffered = true;
            this.dgv_Tarjeta.EnableHeadersVisualStyles = false;
            this.dgv_Tarjeta.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Tarjeta.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Tarjeta.Location = new System.Drawing.Point(1, 257);
            this.dgv_Tarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Tarjeta.Name = "dgv_Tarjeta";
            this.dgv_Tarjeta.ReadOnly = true;
            this.dgv_Tarjeta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Tarjeta.Size = new System.Drawing.Size(1218, 412);
            this.dgv_Tarjeta.TabIndex = 3;
            this.dgv_Tarjeta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Tarjeta_CellMouseClick);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuCards2.Controls.Add(this.txt_ClaveTarjeta);
            this.bunifuCards2.Controls.Add(this.label4);
            this.bunifuCards2.Controls.Add(this.btn_EliminarTarjeta);
            this.bunifuCards2.Controls.Add(this.btn_ActualizarTarjeta);
            this.bunifuCards2.Controls.Add(this.btn_AgregarTarjeta);
            this.bunifuCards2.Controls.Add(this.txt_NombreTarjeta);
            this.bunifuCards2.Controls.Add(this.label6);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(2, 4);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = false;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1220, 245);
            this.bunifuCards2.TabIndex = 2;
            // 
            // txt_ClaveTarjeta
            // 
            this.txt_ClaveTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClaveTarjeta.Location = new System.Drawing.Point(299, 41);
            this.txt_ClaveTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveTarjeta.Name = "txt_ClaveTarjeta";
            this.txt_ClaveTarjeta.Size = new System.Drawing.Size(87, 26);
            this.txt_ClaveTarjeta.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Clave:";
            // 
            // btn_EliminarTarjeta
            // 
            this.btn_EliminarTarjeta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_EliminarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarTarjeta.BorderRadius = 0;
            this.btn_EliminarTarjeta.ButtonText = "Eliminar";
            this.btn_EliminarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarTarjeta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_EliminarTarjeta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_EliminarTarjeta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarTarjeta.Iconimage")));
            this.btn_EliminarTarjeta.Iconimage_right = null;
            this.btn_EliminarTarjeta.Iconimage_right_Selected = null;
            this.btn_EliminarTarjeta.Iconimage_Selected = null;
            this.btn_EliminarTarjeta.IconMarginLeft = 0;
            this.btn_EliminarTarjeta.IconMarginRight = 0;
            this.btn_EliminarTarjeta.IconRightVisible = false;
            this.btn_EliminarTarjeta.IconRightZoom = 0D;
            this.btn_EliminarTarjeta.IconVisible = false;
            this.btn_EliminarTarjeta.IconZoom = 40D;
            this.btn_EliminarTarjeta.IsTab = false;
            this.btn_EliminarTarjeta.Location = new System.Drawing.Point(636, 176);
            this.btn_EliminarTarjeta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_EliminarTarjeta.Name = "btn_EliminarTarjeta";
            this.btn_EliminarTarjeta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_EliminarTarjeta.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_EliminarTarjeta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_EliminarTarjeta.selected = false;
            this.btn_EliminarTarjeta.Size = new System.Drawing.Size(149, 33);
            this.btn_EliminarTarjeta.TabIndex = 18;
            this.btn_EliminarTarjeta.Text = "Eliminar";
            this.btn_EliminarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarTarjeta.Textcolor = System.Drawing.Color.White;
            this.btn_EliminarTarjeta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarTarjeta.Click += new System.EventHandler(this.btn_EliminarTarjeta_Click);
            // 
            // btn_ActualizarTarjeta
            // 
            this.btn_ActualizarTarjeta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_ActualizarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ActualizarTarjeta.BorderRadius = 0;
            this.btn_ActualizarTarjeta.ButtonText = "Actualizar";
            this.btn_ActualizarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ActualizarTarjeta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_ActualizarTarjeta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_ActualizarTarjeta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_ActualizarTarjeta.Iconimage")));
            this.btn_ActualizarTarjeta.Iconimage_right = null;
            this.btn_ActualizarTarjeta.Iconimage_right_Selected = null;
            this.btn_ActualizarTarjeta.Iconimage_Selected = null;
            this.btn_ActualizarTarjeta.IconMarginLeft = 0;
            this.btn_ActualizarTarjeta.IconMarginRight = 0;
            this.btn_ActualizarTarjeta.IconRightVisible = false;
            this.btn_ActualizarTarjeta.IconRightZoom = 0D;
            this.btn_ActualizarTarjeta.IconVisible = false;
            this.btn_ActualizarTarjeta.IconZoom = 40D;
            this.btn_ActualizarTarjeta.IsTab = false;
            this.btn_ActualizarTarjeta.Location = new System.Drawing.Point(455, 176);
            this.btn_ActualizarTarjeta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_ActualizarTarjeta.Name = "btn_ActualizarTarjeta";
            this.btn_ActualizarTarjeta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_ActualizarTarjeta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_ActualizarTarjeta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_ActualizarTarjeta.selected = false;
            this.btn_ActualizarTarjeta.Size = new System.Drawing.Size(149, 33);
            this.btn_ActualizarTarjeta.TabIndex = 17;
            this.btn_ActualizarTarjeta.Text = "Actualizar";
            this.btn_ActualizarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ActualizarTarjeta.Textcolor = System.Drawing.Color.White;
            this.btn_ActualizarTarjeta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarTarjeta.Click += new System.EventHandler(this.btn_ActualizarTarjeta_Click);
            // 
            // btn_AgregarTarjeta
            // 
            this.btn_AgregarTarjeta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AgregarTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AgregarTarjeta.BorderRadius = 0;
            this.btn_AgregarTarjeta.ButtonText = "Agregar";
            this.btn_AgregarTarjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarTarjeta.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AgregarTarjeta.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AgregarTarjeta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AgregarTarjeta.Iconimage")));
            this.btn_AgregarTarjeta.Iconimage_right = null;
            this.btn_AgregarTarjeta.Iconimage_right_Selected = null;
            this.btn_AgregarTarjeta.Iconimage_Selected = null;
            this.btn_AgregarTarjeta.IconMarginLeft = 0;
            this.btn_AgregarTarjeta.IconMarginRight = 0;
            this.btn_AgregarTarjeta.IconRightVisible = false;
            this.btn_AgregarTarjeta.IconRightZoom = 0D;
            this.btn_AgregarTarjeta.IconVisible = false;
            this.btn_AgregarTarjeta.IconZoom = 40D;
            this.btn_AgregarTarjeta.IsTab = false;
            this.btn_AgregarTarjeta.Location = new System.Drawing.Point(274, 176);
            this.btn_AgregarTarjeta.Margin = new System.Windows.Forms.Padding(5);
            this.btn_AgregarTarjeta.Name = "btn_AgregarTarjeta";
            this.btn_AgregarTarjeta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_AgregarTarjeta.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(203)))), ((int)(((byte)(104)))));
            this.btn_AgregarTarjeta.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AgregarTarjeta.selected = false;
            this.btn_AgregarTarjeta.Size = new System.Drawing.Size(149, 33);
            this.btn_AgregarTarjeta.TabIndex = 16;
            this.btn_AgregarTarjeta.Text = "Agregar";
            this.btn_AgregarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarTarjeta.Textcolor = System.Drawing.Color.White;
            this.btn_AgregarTarjeta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarTarjeta.Click += new System.EventHandler(this.btn_AgregarTarjeta_Click);
            // 
            // txt_NombreTarjeta
            // 
            this.txt_NombreTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreTarjeta.Location = new System.Drawing.Point(299, 88);
            this.txt_NombreTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreTarjeta.Name = "txt_NombreTarjeta";
            this.txt_NombreTarjeta.Size = new System.Drawing.Size(187, 26);
            this.txt_NombreTarjeta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre de la tarjeta:";
            // 
            // clavemoneda
            // 
            this.clavemoneda.DataPropertyName = "id_moneda";
            this.clavemoneda.HeaderText = "Clave";
            this.clavemoneda.Name = "clavemoneda";
            this.clavemoneda.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "nombre_moneda";
            this.moneda.HeaderText = "Moneda";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor_moneda";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "id_tarjeta";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // tarjeta
            // 
            this.tarjeta.DataPropertyName = "nombre_tarjeta";
            this.tarjeta.HeaderText = "Tarjeta";
            this.tarjeta.Name = "tarjeta";
            this.tarjeta.ReadOnly = true;
            // 
            // txt_ValorMoneda
            // 
            this.txt_ValorMoneda.Location = new System.Drawing.Point(656, 89);
            this.txt_ValorMoneda.Name = "txt_ValorMoneda";
            this.txt_ValorMoneda.Size = new System.Drawing.Size(100, 22);
            this.txt_ValorMoneda.TabIndex = 39;
            // 
            // frm_Moneda_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 722);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Moneda_Tarjeta";
            this.Text = "Moneda_Tarjeta";
            this.Load += new System.EventHandler(this.frm_Moneda_Tarjeta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarjeta)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.TextBox txt_ClaveMoneda;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarMoneda;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarMoneda;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarMoneda;
        private System.Windows.Forms.TextBox txt_NombreMoneda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Moneda;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Tarjeta;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.TextBox txt_ClaveTarjeta;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_EliminarTarjeta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_ActualizarTarjeta;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AgregarTarjeta;
        private System.Windows.Forms.TextBox txt_NombreTarjeta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavemoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjeta;
        private System.Windows.Forms.TextBox txt_ValorMoneda;
    }
}