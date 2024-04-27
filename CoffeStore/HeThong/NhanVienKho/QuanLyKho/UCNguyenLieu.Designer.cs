namespace CoffeStore.HeThong.NhanVienKho.QuanLyKho
{
    partial class UCNguyenLieu
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
            this.btnCheckItem = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnChangeItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckItem
            // 
            this.btnCheckItem.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnCheckItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckItem.Location = new System.Drawing.Point(417, 682);
            this.btnCheckItem.Name = "btnCheckItem";
            this.btnCheckItem.Size = new System.Drawing.Size(148, 59);
            this.btnCheckItem.TabIndex = 0;
            this.btnCheckItem.Text = "Kiểm tra";
            this.btnCheckItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Location = new System.Drawing.Point(722, 687);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(130, 55);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Thêm";
            this.btnAddItems.UseVisualStyleBackColor = false;
            this.btnAddItems.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangeItem
            // 
            this.btnChangeItem.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnChangeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeItem.Location = new System.Drawing.Point(994, 688);
            this.btnChangeItem.Name = "btnChangeItem";
            this.btnChangeItem.Size = new System.Drawing.Size(131, 53);
            this.btnChangeItem.TabIndex = 2;
            this.btnChangeItem.Text = "Sửa";
            this.btnChangeItem.UseVisualStyleBackColor = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.Location = new System.Drawing.Point(1266, 687);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(133, 52);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "Xóa";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1298, 640);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UCNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnChangeItem);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnCheckItem);
            this.Name = "UCNguyenLieu";
            this.Size = new System.Drawing.Size(1819, 784);
            this.Load += new System.EventHandler(this.UCNguyenLieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckItem;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnChangeItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
