﻿namespace CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon
{
    partial class UCDatMon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlQLTD = new System.Windows.Forms.Panel();
            this.pnlThucDon = new System.Windows.Forms.Panel();
            this.pnlQLTD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQLTD
            // 
            this.pnlQLTD.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlQLTD.Controls.Add(this.pnlThucDon);
            this.pnlQLTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQLTD.Location = new System.Drawing.Point(0, 0);
            this.pnlQLTD.Name = "pnlQLTD";
            this.pnlQLTD.Size = new System.Drawing.Size(1609, 1055);
            this.pnlQLTD.TabIndex = 8;
            this.pnlQLTD.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLTD_Paint);
            // 
            // pnlThucDon
            // 
            this.pnlThucDon.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlThucDon.Location = new System.Drawing.Point(63, 62);
            this.pnlThucDon.Name = "pnlThucDon";
            this.pnlThucDon.Size = new System.Drawing.Size(1546, 938);
            this.pnlThucDon.TabIndex = 6;
            this.pnlThucDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThucDon_Paint);
            // 
            // UCDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQLTD);
            this.Name = "UCDatMon";
            this.Size = new System.Drawing.Size(1609, 1055);
            this.pnlQLTD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQLTD;
        private System.Windows.Forms.Panel pnlThucDon;
    }
}
