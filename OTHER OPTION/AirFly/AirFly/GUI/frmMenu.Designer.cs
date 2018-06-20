namespace AirFly.GUI
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnComprarBoleto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBuscarVuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMisBoletos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Admin = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_indicador = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnl_indicador);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.panel1.Controls.Add(this.btnMisBoletos);
            this.panel1.Controls.Add(this.btnBuscarVuelo);
            this.panel1.Controls.Add(this.btnComprarBoleto);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 118);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(943, 42);
            this.panel2.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.White;
            this.btnInicio.BackColor = System.Drawing.Color.White;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = null;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 90D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(12, 63);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.White;
            this.btnInicio.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(147, 46);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnComprarBoleto
            // 
            this.btnComprarBoleto.Activecolor = System.Drawing.Color.White;
            this.btnComprarBoleto.BackColor = System.Drawing.Color.White;
            this.btnComprarBoleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComprarBoleto.BorderRadius = 0;
            this.btnComprarBoleto.ButtonText = "Comprar boleto";
            this.btnComprarBoleto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarBoleto.DisabledColor = System.Drawing.Color.Gray;
            this.btnComprarBoleto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnComprarBoleto.Iconimage = null;
            this.btnComprarBoleto.Iconimage_right = null;
            this.btnComprarBoleto.Iconimage_right_Selected = null;
            this.btnComprarBoleto.Iconimage_Selected = null;
            this.btnComprarBoleto.IconMarginLeft = 0;
            this.btnComprarBoleto.IconMarginRight = 0;
            this.btnComprarBoleto.IconRightVisible = true;
            this.btnComprarBoleto.IconRightZoom = 0D;
            this.btnComprarBoleto.IconVisible = true;
            this.btnComprarBoleto.IconZoom = 90D;
            this.btnComprarBoleto.IsTab = false;
            this.btnComprarBoleto.Location = new System.Drawing.Point(165, 63);
            this.btnComprarBoleto.Name = "btnComprarBoleto";
            this.btnComprarBoleto.Normalcolor = System.Drawing.Color.White;
            this.btnComprarBoleto.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnComprarBoleto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnComprarBoleto.selected = false;
            this.btnComprarBoleto.Size = new System.Drawing.Size(147, 46);
            this.btnComprarBoleto.TabIndex = 2;
            this.btnComprarBoleto.Text = "Comprar boleto";
            this.btnComprarBoleto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnComprarBoleto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnComprarBoleto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarBoleto.Click += new System.EventHandler(this.btnComprarBoleto_Click);
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.Activecolor = System.Drawing.Color.White;
            this.btnBuscarVuelo.BackColor = System.Drawing.Color.White;
            this.btnBuscarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarVuelo.BorderRadius = 0;
            this.btnBuscarVuelo.ButtonText = "Buscar vuelos";
            this.btnBuscarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscarVuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscarVuelo.Iconimage = null;
            this.btnBuscarVuelo.Iconimage_right = null;
            this.btnBuscarVuelo.Iconimage_right_Selected = null;
            this.btnBuscarVuelo.Iconimage_Selected = null;
            this.btnBuscarVuelo.IconMarginLeft = 0;
            this.btnBuscarVuelo.IconMarginRight = 0;
            this.btnBuscarVuelo.IconRightVisible = true;
            this.btnBuscarVuelo.IconRightZoom = 0D;
            this.btnBuscarVuelo.IconVisible = true;
            this.btnBuscarVuelo.IconZoom = 90D;
            this.btnBuscarVuelo.IsTab = false;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(318, 63);
            this.btnBuscarVuelo.Name = "btnBuscarVuelo";
            this.btnBuscarVuelo.Normalcolor = System.Drawing.Color.White;
            this.btnBuscarVuelo.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnBuscarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscarVuelo.selected = false;
            this.btnBuscarVuelo.Size = new System.Drawing.Size(147, 46);
            this.btnBuscarVuelo.TabIndex = 3;
            this.btnBuscarVuelo.Text = "Buscar vuelos";
            this.btnBuscarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscarVuelo.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVuelo.Click += new System.EventHandler(this.btnBuscarVuelo_Click);
            // 
            // btnMisBoletos
            // 
            this.btnMisBoletos.Activecolor = System.Drawing.Color.White;
            this.btnMisBoletos.BackColor = System.Drawing.Color.White;
            this.btnMisBoletos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMisBoletos.BorderRadius = 0;
            this.btnMisBoletos.ButtonText = "Mis boletos";
            this.btnMisBoletos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisBoletos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMisBoletos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMisBoletos.Iconimage = null;
            this.btnMisBoletos.Iconimage_right = null;
            this.btnMisBoletos.Iconimage_right_Selected = null;
            this.btnMisBoletos.Iconimage_Selected = null;
            this.btnMisBoletos.IconMarginLeft = 0;
            this.btnMisBoletos.IconMarginRight = 0;
            this.btnMisBoletos.IconRightVisible = true;
            this.btnMisBoletos.IconRightZoom = 0D;
            this.btnMisBoletos.IconVisible = true;
            this.btnMisBoletos.IconZoom = 90D;
            this.btnMisBoletos.IsTab = false;
            this.btnMisBoletos.Location = new System.Drawing.Point(471, 63);
            this.btnMisBoletos.Name = "btnMisBoletos";
            this.btnMisBoletos.Normalcolor = System.Drawing.Color.White;
            this.btnMisBoletos.OnHovercolor = System.Drawing.Color.DarkGray;
            this.btnMisBoletos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMisBoletos.selected = false;
            this.btnMisBoletos.Size = new System.Drawing.Size(147, 46);
            this.btnMisBoletos.TabIndex = 4;
            this.btnMisBoletos.Text = "Mis boletos";
            this.btnMisBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMisBoletos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMisBoletos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisBoletos.Click += new System.EventHandler(this.btnMisBoletos_Click);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(868, 63);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.DarkGray;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(47, 46);
            this.bunifuFlatButton5.TabIndex = 5;
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.SetToolTip(this.bunifuFlatButton5, "Administración General");
            // 
            // pnl_indicador
            // 
            this.pnl_indicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.pnl_indicador.Location = new System.Drawing.Point(12, 110);
            this.pnl_indicador.Name = "pnl_indicador";
            this.pnl_indicador.Size = new System.Drawing.Size(147, 7);
            this.pnl_indicador.TabIndex = 6;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(909, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "AirFly";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 523);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirFly";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscarVuelo;
        private Bunifu.Framework.UI.BunifuFlatButton btnComprarBoleto;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnMisBoletos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.ToolTip Admin;
        private System.Windows.Forms.Panel pnl_indicador;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}