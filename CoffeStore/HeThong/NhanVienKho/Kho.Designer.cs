namespace CoffeStore.HeThong.NhanVienKho
{
    partial class Kho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxuatnguyenlieu = new System.Windows.Forms.Button();
            this.btnControlItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnxuatnguyenlieu);
            this.panel1.Controls.Add(this.btnControlItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 1050);
            this.panel1.TabIndex = 1;
            // 
            // btnxuatnguyenlieu
            // 
            this.btnxuatnguyenlieu.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnxuatnguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatnguyenlieu.Location = new System.Drawing.Point(0, 416);
            this.btnxuatnguyenlieu.Name = "btnxuatnguyenlieu";
            this.btnxuatnguyenlieu.Size = new System.Drawing.Size(354, 90);
            this.btnxuatnguyenlieu.TabIndex = 3;
            this.btnxuatnguyenlieu.Text = "Xuất nguyên liệu";
            this.btnxuatnguyenlieu.UseVisualStyleBackColor = false;
            this.btnxuatnguyenlieu.Click += new System.EventHandler(this.btnxuatnguyenlieu_Click);
            // 
            // btnControlItem
            // 
            this.btnControlItem.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnControlItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlItem.Location = new System.Drawing.Point(0, 302);
            this.btnControlItem.Name = "btnControlItem";
            this.btnControlItem.Size = new System.Drawing.Size(354, 89);
            this.btnControlItem.TabIndex = 2;
            this.btnControlItem.Text = "Quản lí nguyên liệu";
            this.btnControlItem.UseVisualStyleBackColor = false;
            this.btnControlItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel2.Location = new System.Drawing.Point(352, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1449, 1065);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoffeStore.Properties.Resources.logo_koBackground;
            this.pictureBox1.Location = new System.Drawing.Point(56, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(0, 962);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(351, 76);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 1050);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.Kho_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnControlItem;
        private System.Windows.Forms.Button btnxuatnguyenlieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
    }
}