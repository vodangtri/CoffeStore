using CoffeStore.BLL;
using System;
using System.Data.SqlClient;
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
    }
}
