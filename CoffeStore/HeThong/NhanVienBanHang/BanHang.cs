using CoffeStore.HeThong.NhanVienBanHang.GioHang;
using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon;
using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.NhanVienBanHang
{
    public partial class BanHang : Form
    {
        public string userID;

        Func func = new Func();
        Form loginForm; // thêm biến để lưu trữ cửa sổ đăng nhập
        public BanHang()
        {

        }
        public BanHang(string userID)
        {
            InitializeComponent();
            func = new Func(this);
            this.userID = userID;

            this.FormClosed += new FormClosedEventHandler(Login_FormClosed); // thêm sự kiện FormClosed
                                                                             //this.cl=;
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
          //  Login login = new Login();
            Application.Restart();
        }

        public event Action Something;


        private void BanHang_Load(object sender, EventArgs e)
        {


        }

        private void pnlThucDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {

            pnlMain.Controls.Clear();
            UCDatMon ucDatMon = new UCDatMon();

            pnlMain.Controls.Add(ucDatMon);

        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCQLTK ucQLTK = new UCQLTK();
            // Thêm UCGioHang vào pnlMain
            pnlMain.Controls.Add(ucQLTK);

        }
        // Khởi tạo User control UCGioHang
        public static String nameGioHang = "cart";
        private UCDatMon ucmenu;
        private void btnGioHang_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCGioHang ucGioHang = new UCGioHang(userID);
            // Thêm UCGioHang vào pnlMain
            pnlMain.Controls.Add(ucGioHang);
        }

        private void btnDX_Click(object sender, EventArgs e)
        {

        }
    }
}



 
