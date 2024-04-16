using CoffeStore.HeThong.DangNhapHeThong;
using CoffeStore.HeThong.NhanVienBanHang;
using CoffeStore.HeThong.NhanVienBanHang.GioHang;
using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using CoffeStore.HeThong.NhanVienKho;
using CoffeStore.HeThong.QuanLiCoffeStore.DoanhThu;
using CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon;
using System;
using System.Windows.Forms;

namespace CoffeStore.HeThong.QuanLiCoffeStore
{
    public partial class QuanLi : Form
    {

        private string userID;
        Func func;


        private void QuanLi_Load(object sender, EventArgs e)
        {
            UserControl newControl = new UCQLTK();
            pnlMain.Controls.Add(newControl);

        }
        public QuanLi()
        {

            InitializeComponent();
            func = new Func(this);
           
        }

        public QuanLi(string userID)
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

        public class Func
        {
            private QuanLi quanLi;
            private BanHang banHang;
            private Kho kho;
            private UCLogin login;
            private UCQLTD menu;
            private UCQLTK tk;
            private UCThucDon menu2;
            private UCDatMon order;
            private UCGioHang cart;

            public Func(QuanLi main)
            {
                this.quanLi = main;
            }

            public Func(BanHang main)
            {
                this.banHang = main;
            }
            public Func(Kho main)
            {
                this.kho = main;
            }
            public Func()
            {

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void pnlThucDon_Paint(object sender, PaintEventArgs e)
        {

        }



        private void pnlQLTD_Paint(object sender, PaintEventArgs e)
        {

        }
        private UCQLTK taikhoan;
        public static String name2 = "taikhoan";

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UCQLTK ucQLTK = new UCQLTK();
            pnlMain.Controls.Add(ucQLTK);

        }

        private void btnTD_Click(object sender, EventArgs e)
        {

            pnlMain.Controls.Clear();
            UserControl newControl = new UCQLTD();
            pnlMain.Controls.Add(newControl);


        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            UserControl newControl = new UCDoanhThu();

            pnlMain.Controls.Add(newControl);
        }
    }
}
