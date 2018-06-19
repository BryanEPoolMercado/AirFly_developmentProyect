namespace Aerolineas_AirFly.GUI
{
    partial class frm_ReservacionVuelos
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btn_buscarvuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dt_FechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.cmb_ruta = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.dgv_Moneda = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(306, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haga una reservacion";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.btn_buscarvuelo);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards2.Controls.Add(this.dt_FechaVuelo);
            this.bunifuCards2.Controls.Add(this.cmb_ruta);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 51);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(898, 139);
            this.bunifuCards2.TabIndex = 2;
            // 
            // btn_buscarvuelo
            // 
            this.btn_buscarvuelo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_buscarvuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_buscarvuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarvuelo.BorderRadius = 0;
            this.btn_buscarvuelo.ButtonText = "Buscar vuelo";
            this.btn_buscarvuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarvuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_buscarvuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_buscarvuelo.Iconimage = null;
            this.btn_buscarvuelo.Iconimage_right = null;
            this.btn_buscarvuelo.Iconimage_right_Selected = null;
            this.btn_buscarvuelo.Iconimage_Selected = null;
            this.btn_buscarvuelo.IconMarginLeft = 0;
            this.btn_buscarvuelo.IconMarginRight = 0;
            this.btn_buscarvuelo.IconRightVisible = true;
            this.btn_buscarvuelo.IconRightZoom = 0D;
            this.btn_buscarvuelo.IconVisible = true;
            this.btn_buscarvuelo.IconZoom = 90D;
            this.btn_buscarvuelo.IsTab = false;
            this.btn_buscarvuelo.Location = new System.Drawing.Point(687, 32);
            this.btn_buscarvuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscarvuelo.Name = "btn_buscarvuelo";
            this.btn_buscarvuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_buscarvuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_buscarvuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_buscarvuelo.selected = false;
            this.btn_buscarvuelo.Size = new System.Drawing.Size(185, 70);
            this.btn_buscarvuelo.TabIndex = 10;
            this.btn_buscarvuelo.Text = "Buscar vuelo";
            this.btn_buscarvuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscarvuelo.Textcolor = System.Drawing.Color.White;
            this.btn_buscarvuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(26, 89);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 24);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Fecha:";
            // 
            // dt_FechaVuelo
            // 
            this.dt_FechaVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_FechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaVuelo.Location = new System.Drawing.Point(100, 84);
            this.dt_FechaVuelo.Name = "dt_FechaVuelo";
            this.dt_FechaVuelo.Size = new System.Drawing.Size(111, 29);
            this.dt_FechaVuelo.TabIndex = 6;
            // 
            // cmb_ruta
            // 
            this.cmb_ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ruta.FormattingEnabled = true;
            this.cmb_ruta.Location = new System.Drawing.Point(369, 32);
            this.cmb_ruta.Name = "cmb_ruta";
            this.cmb_ruta.Size = new System.Drawing.Size(213, 32);
            this.cmb_ruta.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(290, 34);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(58, 24);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Ruta:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards1.Controls.Add(this.dgv_Moneda);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(11, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(904, 569);
            this.bunifuCards1.TabIndex = 1;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Moneda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Moneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Moneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origen,
            this.destino,
            this.fecha,
            this.hora,
            this.aerolinea,
            this.boton});
            this.dgv_Moneda.DoubleBuffered = true;
            this.dgv_Moneda.EnableHeadersVisualStyles = false;
            this.dgv_Moneda.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Moneda.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Moneda.Location = new System.Drawing.Point(3, 197);
            this.dgv_Moneda.Name = "dgv_Moneda";
            this.dgv_Moneda.ReadOnly = true;
            this.dgv_Moneda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Moneda.Size = new System.Drawing.Size(898, 369);
            this.dgv_Moneda.TabIndex = 3;
            // 
            // origen
            // 
            this.origen.HeaderText = "Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // aerolinea
            // 
            this.aerolinea.HeaderText = "Aerolinea";
            this.aerolinea.Name = "aerolinea";
            this.aerolinea.ReadOnly = true;
            // 
            // boton
            // 
            this.boton.HeaderText = "";
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_ReservacionVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 596);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_ReservacionVuelos";
            this.Text = "ReservacionVuelos";
            this.Load += new System.EventHandler(this.frm_ReservacionVuelos_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_buscarvuelo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DateTimePicker dt_FechaVuelo;
        private System.Windows.Forms.ComboBox cmb_ruta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerolinea;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
    }
}