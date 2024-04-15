using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong.DangNhapHeThong
{
    public partial class UCOTP : UserControl
    {
        private string userName;
        public UCOTP()
        {
            InitializeComponent();
            txtOTP.ForeColor = Color.Silver;
        }
        public UCOTP(string data)
        {
            InitializeComponent();
            txtOTP.ForeColor = Color.Silver;

            this.userName = data;
           

        }
        private void UCOTP_Load(object sender, EventArgs e)
        {
        }
        private void txtOTP_Enter(object sender, EventArgs e)
        {
            if (txtOTP.Text == "ví dụ:142320")
            {
                txtOTP.Text = "";
                txtOTP.ForeColor = Color.Black;
            }
        }
        private void txtOTP_Leave(object sender, EventArgs e)
        {
            if (txtOTP.Text == "")
            {
                txtOTP.Text = "ví dụ:142320";
                txtOTP.ForeColor = Color.Silver;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            UserControl newControl = new UCPhoneNumber();

            // Thiết lập các thuộc tính và vị trí cho UserControl mới
            newControl.Dock = DockStyle.Fill;
            newControl.Parent = Parent;

            // Hiển thị UserControl mới
            newControl.Show();
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text.Length == 6)
            {
                Hide();
                UserControl newControl = new UCDoiMatKhau(userName);

                // Thiết lập các thuộc tính và vị trí cho UserControl mới
                newControl.Dock = DockStyle.Fill;
                newControl.Parent = Parent;

                // Hiển thị UserControl mới
                newControl.Show();
            }
            else
            {
                MessageBox.Show("Mã otp không hợp lệ!.");
            }
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNote_Click(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
