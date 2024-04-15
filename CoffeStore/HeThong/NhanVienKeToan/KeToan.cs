using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.NhanVienKeToan
{
    public partial class KeToan : Form
    {
        public KeToan()
        {
            InitializeComponent();
        }

        private void KeToan_Load(object sender, EventArgs e)
        {

        }
        public string userID;
        Func func = new Func();
        public KeToan(string userID)
        {
            InitializeComponent();
            func = new Func(this);
            this.userID = userID;
            this.FormClosed += new FormClosedEventHandler(Login_FormClosed); // thêm sự kiện FormClosed
        }
        // Sự kiện FormClosed
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
