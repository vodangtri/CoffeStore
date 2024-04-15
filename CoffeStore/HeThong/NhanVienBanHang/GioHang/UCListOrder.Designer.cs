namespace CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon
{
    partial class UCListOrder
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
            this.flpListOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpListOrder
            // 
            this.flpListOrder.AutoScroll = true;
            this.flpListOrder.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.flpListOrder.Location = new System.Drawing.Point(55, 139);
            this.flpListOrder.Name = "flpListOrder";
            this.flpListOrder.Size = new System.Drawing.Size(1499, 916);
            this.flpListOrder.TabIndex = 1;
            this.flpListOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.flpListOrder_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1345, 91);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách đặt món chưa thanh toán";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UCListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpListOrder);
            this.Name = "UCListOrder";
            this.Size = new System.Drawing.Size(1609, 1055);
            this.Load += new System.EventHandler(this.UCListOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpListOrder;
        private System.Windows.Forms.Label label1;
    }
}
