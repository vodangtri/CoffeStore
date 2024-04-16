using CoffeStore.BLL;
using CoffeStore.DTO;
using CoffeStore.HeThong.NhanVienBanHang;
using CoffeStore.HeThong.NhanVienKho;
using CoffeStore.HeThong.QuanLiCoffeStore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoffeStore.HeThong.DangNhapHeThong
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
            txtUsername.ForeColor = Color.Silver;
            txtPassword.ForeColor = Color.Silver;
            // Đặt kích thước ban đầu cho TextBox
            txtUsername.Size = new Size(350, 300); // Ví dụ: Kích thước ban đầu là 100x20

            // Đặt thuộc tính AutoSize thành true
            txtUsername.AutoSize = true;

            txtPassword.Size = new Size(350, 300); // Ví dụ: Kích thước ban đầu là 100x20

            // Đặt thuộc tính AutoSize thành true
            txtPassword.AutoSize = true;
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
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Silver;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UCLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
        Login login;
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            User tk = new User();
            UserBLL ehe = new UserBLL();
            tk.UserName = txtUsername.Text;
            tk.UserPassword = txtPassword.Text;

            LoginBLL tkBLL = new LoginBLL();

            if (tkBLL.checkLoginData_Login_BLL(tk) == "Vui lòng nhập tên tài khoản")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (tkBLL.checkLoginData_Login_BLL(tk) == "Vui lòng nhập mật khẩu")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            else if (tkBLL.checkLoginData_Login_BLL(tk) == "Thông tin đăng nhập không chính xác!")
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!");
                return;
            }
            else
            {
                if (ehe.getIdByUsername(tk.UserName).ToString().Contains('S'))
                {
                    BanHang newMain = new BanHang(ehe.getIdByUsername(tk.UserName).ToString());
                    this.Parent.Parent.Hide();//cửa sổ login hiện tại sẽ ẩn đi
                    newMain.ShowDialog();//cửa số bán hàng hiển thị lên
                }
                else if (ehe.getIdByUsername(tk.UserName).ToString().Contains('M'))
                {

                    QuanLi newMain = new QuanLi(ehe.getIdByUsername(tk.UserName).ToString());
                    
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                    
                }
                else if (ehe.getIdByUsername(tk.UserName).ToString().Contains('W'))
                {

                    Kho newMain = new Kho(ehe.getIdByUsername(tk.UserName).ToString());
                    this.Parent.Parent.Hide();
                    newMain.ShowDialog();
                }
                return;
            }
        }
        public static String name = "quenmatkhau";
        public event Action Something;

        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void btnPassword_Click(object sender, EventArgs e)
        {
            Hide();
            ShowNewControl();
        }
        private void ShowNewControl()
        {
            // Tạo UserControl mới
            // Tạo UserControl mới
            UserControl newControl = new UCUsername();

            // Thiết lập các thuộc tính và vị trí cho UserControl mới
            newControl.Dock = DockStyle.Fill;
            newControl.Parent = Parent;

            // Hiển thị UserControl mới
            newControl.Show();
        }
    }
}
