using CoffeStore.HeThong.DangNhapHeThong;
using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            UCLogin login = new UCLogin();
            pnlHandle.Controls.Add(login);
        }

        private void pnlHandle_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
