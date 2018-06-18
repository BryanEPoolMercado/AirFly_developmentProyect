namespace Aerolineas_AirFly.GUI
{
    partial class InformacionVuelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Moneda = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clavemoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 215);
            this.panel1.TabIndex = 0;
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
            this.dgv_Moneda.Location = new System.Drawing.Point(120, 232);
            this.dgv_Moneda.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Moneda.Name = "dgv_Moneda";
            this.dgv_Moneda.ReadOnly = true;
            this.dgv_Moneda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Moneda.Size = new System.Drawing.Size(446, 243);
            this.dgv_Moneda.TabIndex = 3;
            // 
            // clavemoneda
            // 
            this.clavemoneda.HeaderText = "Clave";
            this.clavemoneda.Name = "clavemoneda";
            this.clavemoneda.ReadOnly = true;
            // 
            // moneda
            // 
            this.moneda.HeaderText = "Seccion";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InformacionVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 502);
            this.Controls.Add(this.dgv_Moneda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InformacionVuelo";
            this.Text = "InformacionVuelo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavemoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewButtonColumn valor;
    }
}