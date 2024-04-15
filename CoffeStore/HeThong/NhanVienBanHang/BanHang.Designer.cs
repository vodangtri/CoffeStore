namespace CoffeStore.HeThong.NhanVienBanHang
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(315, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1609, 1055);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThucDon_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeStore.Properties.Resources.logo_koBackground;
            this.pictureBox1.Location = new System.Drawing.Point(59, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pnlSetting);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 1055);
            this.panel1.TabIndex = 1;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlSetting.Controls.Add(this.btnQLTK);
            this.pnlSetting.Controls.Add(this.btnGioHang);
            this.pnlSetting.Controls.Add(this.btnDX);
            this.pnlSetting.Controls.Add(this.btnDatMon);
            this.pnlSetting.Controls.Add(this.pbLogo);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(315, 1055);
            this.pnlSetting.TabIndex = 3;
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnQLTK.FlatAppearance.BorderSize = 0;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.Location = new System.Drawing.Point(3, 885);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(309, 82);
            this.btnQLTK.TabIndex = 6;
            this.btnQLTK.Text = "Quản lí tài khoản";
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnGioHang.FlatAppearance.BorderSize = 0;
            this.btnGioHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGioHang.Location = new System.Drawing.Point(3, 369);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(315, 82);
            this.btnGioHang.TabIndex = 4;
            this.btnGioHang.Text = "Giỏ hàng";
            this.btnGioHang.UseVisualStyleBackColor = false;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // btnDX
            // 
            this.btnDX.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDX.FlatAppearance.BorderSize = 0;
            this.btnDX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.Location = new System.Drawing.Point(0, 973);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(315, 82);
            this.btnDX.TabIndex = 2;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = false;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // btnDatMon
            // 
            this.btnDatMon.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDatMon.FlatAppearance.BorderSize = 0;
            this.btnDatMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDatMon.Location = new System.Drawing.Point(0, 281);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(315, 82);
            this.btnDatMon.TabIndex = 0;
            this.btnDatMon.Text = "Hệ thống đặt món";
            this.btnDatMon.UseVisualStyleBackColor = false;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CoffeStore.Properties.Resources.logo_koBackground;
            this.pbLogo.Location = new System.Drawing.Point(59, 36);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(194, 178);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BanHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Button btnDX;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}