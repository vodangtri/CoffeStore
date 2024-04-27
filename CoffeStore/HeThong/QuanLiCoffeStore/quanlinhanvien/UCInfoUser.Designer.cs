namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiNhanVien
{
    partial class UCInfoUser
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
            this.dtgvLoadUser = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLoadUser
            // 
            this.dtgvLoadUser.BackgroundColor = System.Drawing.Color.White;
            this.dtgvLoadUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoadUser.GridColor = System.Drawing.Color.White;
            this.dtgvLoadUser.Location = new System.Drawing.Point(106, 156);
            this.dtgvLoadUser.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.dtgvLoadUser.Name = "dtgvLoadUser";
            this.dtgvLoadUser.RowHeadersWidth = 62;
            this.dtgvLoadUser.Size = new System.Drawing.Size(1224, 738);
            this.dtgvLoadUser.TabIndex = 10;
            this.dtgvLoadUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoadUser_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(928, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "+Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 917);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UCInfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvLoadUser);
            this.Name = "UCInfoUser";
            this.Size = new System.Drawing.Size(1570, 1050);
            this.Load += new System.EventHandler(this.UCInfoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoadUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLoadUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
    }
}
