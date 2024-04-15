using CoffeStore.BLL;
using CoffeStore.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong.DangNhapHeThong
{
    public partial class UCUsername : UserControl
    {
        public UCUsername()
        {
            InitializeComponent();
            txtUsername.ForeColor = Color.Silver;
        }
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
                txtUsername.ForeColor = Color.Silver;
            }
        }
        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            string data;
            User tk = new User();
            UserBLL ehe = new UserBLL();
            tk.UserName = txtUsername.Text;

            LoginBLL tkBLL = new LoginBLL();

            if (tkBLL.checkUsername_BLL(tk) == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (tkBLL.checkUsername_BLL(tk) == "Tên đăng nhập này không tồn tại!")
            {
                MessageBox.Show("Tên đăng nhập này không tồn tại!");
                return;
            }
            else
            {
                data = tk.UserName.ToString();
          
                 Hide();
                UserControl newControl = new UCPhoneNumber(data);
                newControl.Parent = Parent;

                // Hiển thị UserControl mới
                newControl.Show();
            }
        }
 


        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Hide();
            ShowNewControl();
        }
        private void ShowNewControl()
        {

        UserControl newControl = new UCLogin();

        // Thiết lập các thuộc tính và vị trí cho UserControl mới
            newControl.Dock = DockStyle.Fill;

            newControl.Parent = Parent;

            newControl.Show();
        }
        private void UCUsername_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
