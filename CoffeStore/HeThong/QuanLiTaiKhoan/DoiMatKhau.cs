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

            }
            // Kiểm tra xem mật khẩu và mật khẩu xác nhận có giống nhau không
            if (txtmatkhaumoi.Text == txtmatkhaumoi2.Text)
            {
                checkNewPassword = true;
            }
            else
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ");
            }

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
    }
}
