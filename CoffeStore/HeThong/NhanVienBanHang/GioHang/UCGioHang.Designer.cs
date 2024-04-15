namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    partial class UCGioHang
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
            this.flpGioHang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBill = new System.Windows.Forms.Button();
            this.btnListBill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpGioHang
            // 
            this.flpGioHang.AutoScroll = true;
            this.flpGioHang.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.flpGioHang.Location = new System.Drawing.Point(55, 70);
            this.flpGioHang.Name = "flpGioHang";
            this.flpGioHang.Size = new System.Drawing.Size(1551, 887);
            this.flpGioHang.TabIndex = 0;
            this.flpGioHang.Paint += new System.Windows.Forms.PaintEventHandler(this.flpGioHang_Paint);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Goldenrod;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBill.Location = new System.Drawing.Point(1411, 13);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(143, 56);
            this.btnBill.TabIndex = 1;
            this.btnBill.Text = "Đặt món";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.btnAddBill);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Location = new System.Drawing.Point(0, 963);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1609, 92);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddBill
            // 
            this.btnAddBill.BackColor = System.Drawing.Color.Coral;
            this.btnAddBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddBill.Location = new System.Drawing.Point(1156, 13);
            this.btnAddBill.Name = "btnAddBill";
            this.btnAddBill.Size = new System.Drawing.Size(249, 56);
            this.btnAddBill.TabIndex = 2;
            this.btnAddBill.Text = "Thêm vào đơn";
            this.btnAddBill.UseVisualStyleBackColor = false;
            this.btnAddBill.Click += new System.EventHandler(this.btnAddBill_Click);
            // 
            // btnListBill
            // 
            this.btnListBill.BackColor = System.Drawing.Color.Orange;
            this.btnListBill.FlatAppearance.BorderSize = 0;
            this.btnListBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListBill.Location = new System.Drawing.Point(1305, 17);
            this.btnListBill.Name = "btnListBill";
            this.btnListBill.Size = new System.Drawing.Size(249, 47);
            this.btnListBill.TabIndex = 3;
            this.btnListBill.Text = "Danh Sách đặt món";
            this.btnListBill.UseVisualStyleBackColor = false;
            this.btnListBill.Click += new System.EventHandler(this.btnListBill_Click);
            // 
            // UCGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.btnListBill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpGioHang);
            this.Name = "UCGioHang";
            this.Size = new System.Drawing.Size(1609, 1055);
            this.Load += new System.EventHandler(this.UCGioHang_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGioHang;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListBill;
        private System.Windows.Forms.Button btnAddBill;
    }
}
