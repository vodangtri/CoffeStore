using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.NhanVienKho
{
    public partial class Kho : Form
    {
        public Kho()
        {
            InitializeComponent();
        }

        private void Kho_Load(object sender, EventArgs e)
        {

        }
        public string userID;
        Func func = new Func();
        public Kho(string userID)
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
