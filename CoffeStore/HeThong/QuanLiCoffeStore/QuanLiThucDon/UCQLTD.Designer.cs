namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon
{
    partial class UCQLTD
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
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlThucDon = new System.Windows.Forms.Panel();
            this.pnlQLTD.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQLTD
            // 
            this.pnlQLTD.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlQLTD.Controls.Add(this.pnlThucDon);
            this.pnlQLTD.Controls.Add(this.btnAddItems);
            this.pnlQLTD.Controls.Add(this.btnRefresh);
            this.pnlQLTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQLTD.Location = new System.Drawing.Point(0, 0);
            this.pnlQLTD.Name = "pnlQLTD";
            this.pnlQLTD.Size = new System.Drawing.Size(1609, 1055);
            this.pnlQLTD.TabIndex = 7;
            this.pnlQLTD.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlQLTD_Paint);
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddItems.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Location = new System.Drawing.Point(1383, 23);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(214, 49);
            this.btnAddItems.TabIndex = 5;
            this.btnAddItems.Text = "+ Thêm mới";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1219, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(138, 49);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pnlThucDon
            // 
            this.pnlThucDon.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlThucDon.Location = new System.Drawing.Point(63, 78);
            this.pnlThucDon.Name = "pnlThucDon";
            this.pnlThucDon.Size = new System.Drawing.Size(1546, 938);
            this.pnlThucDon.TabIndex = 6;
            this.pnlThucDon.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlThucDon_Paint);
            // 
            // UCQLTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlQLTD);
            this.Name = "UCQLTD";
            this.Size = new System.Drawing.Size(1609, 1055);
            this.pnlQLTD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQLTD;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlThucDon;
    }
}
