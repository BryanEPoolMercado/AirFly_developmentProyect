namespace AirFly.GUI
{
    partial class frmAviso_salida_app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAviso_salida_app));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_si = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_no = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_si
            // 
            this.btn_si.Activecolor = System.Drawing.Color.Gray;
            this.btn_si.BackColor = System.Drawing.Color.Gray;
            this.btn_si.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_si.BorderRadius = 0;
            this.btn_si.ButtonText = "Si";
            this.btn_si.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_si.DisabledColor = System.Drawing.Color.Silver;
            this.btn_si.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_si.Iconimage = null;
            this.btn_si.Iconimage_right = null;
            this.btn_si.Iconimage_right_Selected = null;
            this.btn_si.Iconimage_Selected = null;
            this.btn_si.IconMarginLeft = 0;
            this.btn_si.IconMarginRight = 0;
            this.btn_si.IconRightVisible = true;
            this.btn_si.IconRightZoom = 0D;
            this.btn_si.IconVisible = true;
            this.btn_si.IconZoom = 90D;
            this.btn_si.IsTab = false;
            this.btn_si.Location = new System.Drawing.Point(293, 222);
            this.btn_si.Margin = new System.Windows.Forms.Padding(4);
            this.btn_si.Name = "btn_si";
            this.btn_si.Normalcolor = System.Drawing.Color.Gray;
            this.btn_si.OnHovercolor = System.Drawing.Color.Crimson;
            this.btn_si.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_si.selected = false;
            this.btn_si.Size = new System.Drawing.Size(181, 65);
            this.btn_si.TabIndex = 14;
            this.btn_si.Text = "Si";
            this.btn_si.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_si.Textcolor = System.Drawing.Color.White;
            this.btn_si.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.Activecolor = System.Drawing.Color.Gray;
            this.btn_no.BackColor = System.Drawing.Color.Gray;
            this.btn_no.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_no.BorderRadius = 0;
            this.btn_no.ButtonText = "No";
            this.btn_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_no.DisabledColor = System.Drawing.Color.Silver;
            this.btn_no.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_no.Iconimage = null;
            this.btn_no.Iconimage_right = null;
            this.btn_no.Iconimage_right_Selected = null;
            this.btn_no.Iconimage_Selected = null;
            this.btn_no.IconMarginLeft = 0;
            this.btn_no.IconMarginRight = 0;
            this.btn_no.IconRightVisible = true;
            this.btn_no.IconRightZoom = 0D;
            this.btn_no.IconVisible = true;
            this.btn_no.IconZoom = 90D;
            this.btn_no.IsTab = false;
            this.btn_no.Location = new System.Drawing.Point(30, 222);
            this.btn_no.Margin = new System.Windows.Forms.Padding(4);
            this.btn_no.Name = "btn_no";
            this.btn_no.Normalcolor = System.Drawing.Color.Gray;
            this.btn_no.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.btn_no.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_no.selected = false;
            this.btn_no.Size = new System.Drawing.Size(181, 65);
            this.btn_no.TabIndex = 13;
            this.btn_no.Text = "No";
            this.btn_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_no.Textcolor = System.Drawing.Color.White;
            this.btn_no.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(116, 158);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(292, 25);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "Esta seguro que desea salir?";
            // 
            // frmAviso_salida_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(523, 300);
            this.Controls.Add(this.btn_si);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAviso_salida_app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAviso_salida_app";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_si;
        private Bunifu.Framework.UI.BunifuFlatButton btn_no;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}