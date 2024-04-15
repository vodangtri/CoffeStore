namespace CoffeStore.HeThong.DangNhapHeThong
{
    partial class UCDoiMatKhau
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
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterPassword.Location = new System.Drawing.Point(156, 547);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.Size = new System.Drawing.Size(422, 38);
            this.txtEnterPassword.TabIndex = 30;
            this.txtEnterPassword.TextChanged += new System.EventHandler(this.txtEnterPassword_TextChanged);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.BackColor = System.Drawing.Color.Goldenrod;
            this.btnTieptuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieptuc.Location = new System.Drawing.Point(156, 731);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(422, 59);
            this.btnTieptuc.TabIndex = 29;
            this.btnTieptuc.Text = "Xác nhận";
            this.btnTieptuc.UseVisualStyleBackColor = false;
            this.btnTieptuc.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(147, 418);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(433, 54);
            this.lblNote.TabIndex = 28;
            this.lblNote.Text = "Cập nhật mật khẩu";
            this.lblNote.Click += new System.EventHandler(this.lblNote_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CoffeStore.Properties.Resources.logo2;
            this.pbLogo.Location = new System.Drawing.Point(207, 103);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(308, 296);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 27;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(156, 643);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(422, 38);
            this.txtConfirmPassword.TabIndex = 32;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.Location = new System.Drawing.Point(151, 515);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(173, 29);
            this.lblEnterPassword.TabIndex = 33;
            this.lblEnterPassword.Text = "Nhập mật khẩu";
            this.lblEnterPassword.Click += new System.EventHandler(this.lblEnterPassword_Click);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(151, 611);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(215, 29);
            this.lblConfirmPassword.TabIndex = 34;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu";
            this.lblConfirmPassword.Click += new System.EventHandler(this.lblConfirmPassword_Click);
            // 
            // UCDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtEnterPassword);
            this.Controls.Add(this.btnTieptuc);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.pbLogo);
            this.Name = "UCDoiMatKhau";
            this.Size = new System.Drawing.Size(743, 1055);
            this.Load += new System.EventHandler(this.UCDoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.Button btnTieptuc;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}
