namespace Aerolineas_AirFly.GUI
{
    partial class frm_MisReservaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MisReservaciones));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_MisReservaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Origen_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_pasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo_vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MisReservaciones)).BeginInit();
            this.panel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCards1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 91);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1234, 145);
            this.bunifuCards1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(460, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mis reservaciones";
            // 
            // dgv_MisReservaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_MisReservaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_MisReservaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_MisReservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_MisReservaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_MisReservaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_MisReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MisReservaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Origen_vuelo,
            this.Destino_vuelo,
            this.Fecha_vuelo,
            this.Num_pasajeros,
            this.costo_vuelo});
            this.dgv_MisReservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MisReservaciones.DoubleBuffered = true;
            this.dgv_MisReservaciones.EnableHeadersVisualStyles = false;
            this.dgv_MisReservaciones.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.dgv_MisReservaciones.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_MisReservaciones.Location = new System.Drawing.Point(0, 236);
            this.dgv_MisReservaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_MisReservaciones.Name = "dgv_MisReservaciones";
            this.dgv_MisReservaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_MisReservaciones.Size = new System.Drawing.Size(1234, 498);
            this.dgv_MisReservaciones.TabIndex = 8;
            // 
            // Origen_vuelo
            // 
            this.Origen_vuelo.HeaderText = "Origen";
            this.Origen_vuelo.Name = "Origen_vuelo";
            // 
            // Destino_vuelo
            // 
            this.Destino_vuelo.HeaderText = "Destino";
            this.Destino_vuelo.Name = "Destino_vuelo";
            // 
            // Fecha_vuelo
            // 
            this.Fecha_vuelo.HeaderText = "Fecha";
            this.Fecha_vuelo.Name = "Fecha_vuelo";
            // 
            // Num_pasajeros
            // 
            this.Num_pasajeros.HeaderText = "Num. pasajeros";
            this.Num_pasajeros.Name = "Num_pasajeros";
            // 
            // costo_vuelo
            // 
            this.costo_vuelo.HeaderText = "Costo";
            this.costo_vuelo.Name = "costo_vuelo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 91);
            this.panel1.TabIndex = 9;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards2.Controls.Add(this.bunifuFlatButton2);
            this.bunifuCards2.Controls.Add(this.bunifuFlatButton1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(367, 20);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(560, 71);
            this.bunifuCards2.TabIndex = 10;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cancelar reservacion";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(279, 9);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Crimson;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(277, 55);
            this.bunifuFlatButton2.TabIndex = 2;
            this.bunifuFlatButton2.Text = "Cancelar reservacion";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Ver boleto";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(-1, 9);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(277, 55);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "Ver boleto";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_MisReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 734);
            this.Controls.Add(this.dgv_MisReservaciones);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MisReservaciones";
            this.Text = "MisReservaciones";
            this.bunifuCards1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MisReservaciones)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_MisReservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_pasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo_vuelo;
        private System.Windows.Forms.Panel panel1;
    }
}