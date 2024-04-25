using CoffeStore.BLL;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong.DangNhapHeThong
{
    public partial class UCDoiMatKhau : UserControl
    {
        public UCDoiMatKhau()
        {
            InitializeComponent();
        }

        private string userName;

        public UCDoiMatKhau(string data)
        {
            InitializeComponent();
            userName = data;
          
        }
        private void txtEnterPassword_Leave(object sender, EventArgs e)
        {

                txtEnterPassword.ForeColor = Color.Silver;
                txtEnterPassword.UseSystemPasswordChar = false;
  
        }
        private void txtEnterPassword_Enter(object sender, EventArgs e)
        {

                txtEnterPassword.ForeColor = Color.Silver;
                txtEnterPassword.UseSystemPasswordChar = true;
 
        }
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {

            txtConfirmPassword.ForeColor = Color.Silver;
            txtConfirmPassword.UseSystemPasswordChar = false;

        }
        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {

            txtConfirmPassword.ForeColor = Color.Silver;
            txtConfirmPassword.UseSystemPasswordChar = true;

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mật khẩu và mật khẩu xác nhận có giống nhau không
            if (txtEnterPassword.Text == txtConfirmPassword.Text)
            {
                // Nếu giống nhau, cập nhật mật khẩu trong cơ sở dữ liệu
                string username = userName; // Giả sử _data chứa username
                string newPassword = txtEnterPassword.Text;
                ChangePassword(username, newPassword);
                MessageBox.Show("Cập nhật mật khẩu thành công");

                Hide();
                UserControl newControl = new UCLogin();

                newControl.Dock = DockStyle.Fill;
                newControl.Parent = Parent;

                newControl.Show();
            }
            else
            {
                // Nếu không giống nhau, hiển thị thông báo lỗi
                MessageBox.Show("Mật khẩu nhập không khớp.");
            }
        }
        UserBLL user = new UserBLL();
        public void ChangePassword(string username, string newPassword)
        {
            user.ChangePassword_BLL(username, newPassword);
        }


        private void pbLogo_Click(object sender, EventArgs e)
        {

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

        }

        private void lblEnterPassword_Click(object sender, EventArgs e)
        {

        }

        private void UCDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtEnterPassword.Text.Length > 0)
            {
                btnShowPassword.SendToBack();
                btnHidePassword.BringToFront();
                txtEnterPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHidePassword_Click(object sender, EventArgs e)
        {

            btnShowPassword.BringToFront();
            txtEnterPassword.UseSystemPasswordChar = true;
        }
        private void btnShowComfirmPassword_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text.Length > 0)
            {
                btnHideComfirmPassword.BringToFront();
                txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnHideComfirmPassword_Click(object sender, EventArgs e)
        {

            btnShowComfirmPassword.BringToFront();
            txtConfirmPassword.UseSystemPasswordChar = true;
        }

       
    }
}
