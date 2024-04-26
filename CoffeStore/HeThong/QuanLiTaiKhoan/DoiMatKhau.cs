using CoffeStore.BLL;
using CoffeStore.HeThong.DangNhapHeThong;
using iTextSharp.text.pdf.codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeStore.HeThong.QuanLiTaiKhoan
{
    public partial class DoiMatKhau : Form
    {
        string id = null;
        public DoiMatKhau(string userId)
        {
            id = userId;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtmatkhaucu_TextChanged(object sender, EventArgs e)
        {

        }
        UserBLL userBLL = new UserBLL();
        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            Boolean checkNewPassword = false,checkOldPassword=false;
            if (userBLL.TonTaiMatKhau(id, txtmatkhaucu.Text) == 0)
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            else
            {
                checkOldPassword = true;
                if (txtmatkhaumoi.Text == txtmatkhaumoi2.Text)
                {
                    checkNewPassword = true;
                }
                else
                {
                    MessageBox.Show("Mật khẩu mới không hợp lệ");
                }

            }
            // Kiểm tra xem mật khẩu và mật khẩu xác nhận có giống nhau không


            if(checkNewPassword && checkOldPassword )
            {
                userBLL.UpdatePassword(id, txtmatkhaumoi.Text);
                MessageBox.Show("Cập nhật mật khẩu thành công");
                this.Hide();
            }
            
        }


        private void DoiMatKhau_Load(object sender, EventArgs e)
        {

        }
       /* private void txtmatkhaucu_Leave(object sender, EventArgs e)
        {

            txtmatkhaucu.ForeColor = Color.Silver;
            txtmatkhaucu.UseSystemPasswordChar = false;

        }*/
        private void txtmatkhaucu_Enter(object sender, EventArgs e)
        {

            txtmatkhaucu.ForeColor = Color.Silver;
            txtmatkhaucu.UseSystemPasswordChar = true;

        }
       /* private void txtmatkhaumoi_Leave(object sender, EventArgs e)
        {

            txtmatkhaumoi.ForeColor = Color.Silver;
            txtmatkhaumoi.UseSystemPasswordChar = false;

        }*/
        private void txtmatkhaumoi_Enter(object sender, EventArgs e)
        {

            txtmatkhaumoi.ForeColor = Color.Silver;
            txtmatkhaumoi.UseSystemPasswordChar = true;

        }
        /*private void txtmatkhaumoi2_Leave(object sender, EventArgs e)
        {

            txtmatkhaumoi2.ForeColor = Color.Silver;
            txtmatkhaumoi2.UseSystemPasswordChar = false;

        }*/
        private void txtmatkhaumoi2_Enter(object sender, EventArgs e)
        {

            txtmatkhaumoi2.ForeColor = Color.Silver;
            txtmatkhaumoi2.UseSystemPasswordChar = true;

        }


        private void btnShowComfirmNewPassword_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi2.Text.Length > 0)
            {
                btnShowComfirmNewPassword.SendToBack();
                btnHideComfirmNewPassword.BringToFront();
                txtmatkhaumoi2.UseSystemPasswordChar = false;
            }
        }
        private void btnHideComfirmNewPassword_Click(object sender, EventArgs e)
        {
            btnShowComfirmNewPassword.BringToFront();
            txtmatkhaumoi2.UseSystemPasswordChar = true;
        }

        private void btnShowNewPassword_Click(object sender, EventArgs e)
        {
            if (txtmatkhaumoi.Text.Length > 0)
            {
                btnShowNewPassword.SendToBack();
                btnHideNewPassword.BringToFront();
                txtmatkhaumoi.UseSystemPasswordChar = false;
            }
        }
        private void btnHideNewPassword_Click(object sender, EventArgs e)
        {
            btnShowNewPassword.BringToFront();
            txtmatkhaumoi.UseSystemPasswordChar = true;
        }

        private void btnShowOldPassword_Click(object sender, EventArgs e)
        {
            if (txtmatkhaucu.Text.Length > 0)
            {
                btnShowOldPassword.SendToBack();
                btnHideOldPassword.BringToFront();
                txtmatkhaucu.UseSystemPasswordChar = false;
            }
        }

        private void btnHideOldPassword_Click(object sender, EventArgs e)
        {
            btnShowOldPassword.BringToFront();
            txtmatkhaucu.UseSystemPasswordChar = true;
        }

        private void txtmatkhaumoi2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
