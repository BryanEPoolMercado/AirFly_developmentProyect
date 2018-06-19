namespace Aerolineas_AirFly.GUI
{
    partial class frm_modelo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_modelo1));
            this.ptb_avionmodel1 = new System.Windows.Forms.PictureBox();
            this.cmb_clase_modelo1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avionmodel1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_avionmodel1
            // 
            this.ptb_avionmodel1.Image = ((System.Drawing.Image)(resources.GetObject("ptb_avionmodel1.Image")));
            this.ptb_avionmodel1.Location = new System.Drawing.Point(12, 268);
            this.ptb_avionmodel1.Name = "ptb_avionmodel1";
            this.ptb_avionmodel1.Size = new System.Drawing.Size(776, 170);
            this.ptb_avionmodel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_avionmodel1.TabIndex = 0;
            this.ptb_avionmodel1.TabStop = false;
            // 
            // cmb_clase_modelo1
            // 
            this.cmb_clase_modelo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_clase_modelo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_clase_modelo1.FormattingEnabled = true;
            this.cmb_clase_modelo1.Location = new System.Drawing.Point(344, 34);
            this.cmb_clase_modelo1.Name = "cmb_clase_modelo1";
            this.cmb_clase_modelo1.Size = new System.Drawing.Size(139, 24);
            this.cmb_clase_modelo1.TabIndex = 1;
            this.cmb_clase_modelo1.SelectedIndexChanged += new System.EventHandler(this.cmb_clase_modelo1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione una clase";
            // 
            // pnl_contenedor
            // 
            this.pnl_contenedor.BackColor = System.Drawing.Color.White;
            this.pnl_contenedor.Location = new System.Drawing.Point(77, 197);
            this.pnl_contenedor.Name = "pnl_contenedor";
            this.pnl_contenedor.Size = new System.Drawing.Size(652, 241);
            this.pnl_contenedor.TabIndex = 3;
            // 
            // frm_modelo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_clase_modelo1);
            this.Controls.Add(this.ptb_avionmodel1);
            this.Name = "frm_modelo1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion de asientos";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_avionmodel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_avionmodel1;
        private System.Windows.Forms.ComboBox cmb_clase_modelo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_contenedor;
    }
}