namespace Aerolineas_AirFly.GUI
{
    partial class frm_FondoPantalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FondoPantalla));
            this.pic_FondoPantalla = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FondoPantalla)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_FondoPantalla
            // 
            this.pic_FondoPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_FondoPantalla.Image = ((System.Drawing.Image)(resources.GetObject("pic_FondoPantalla.Image")));
            this.pic_FondoPantalla.Location = new System.Drawing.Point(0, 0);
            this.pic_FondoPantalla.Name = "pic_FondoPantalla";
            this.pic_FondoPantalla.Size = new System.Drawing.Size(1234, 734);
            this.pic_FondoPantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FondoPantalla.TabIndex = 0;
            this.pic_FondoPantalla.TabStop = false;
            // 
            // frm_FondoPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 734);
            this.Controls.Add(this.pic_FondoPantalla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_FondoPantalla";
            this.Text = "FondoPantalla";
            ((System.ComponentModel.ISupportInitialize)(this.pic_FondoPantalla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_FondoPantalla;
    }
}