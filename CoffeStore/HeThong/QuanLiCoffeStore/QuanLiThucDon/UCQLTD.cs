using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon
{
    public partial class UCQLTD : UserControl
    {
        Func func = new Func();
        private UCThucDon ucmenu;
        public static String name = "menu";
        public UCQLTD()
        {
            InitializeComponent();
            UCThucDon refreshedUC = new UCThucDon();
            pnlThucDon.Controls.Add(refreshedUC);
        }

        private void pnlQLTD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            pnlThucDon.Controls.Clear();
            UCThucDon refreshedUC = new UCThucDon();
            pnlThucDon.Controls.Add(refreshedUC);
        }
        private void btnAddItems_Click(object sender, EventArgs e)
        {
            ThemItems form = new ThemItems();
            form.Show();
        }

        private void pnlThucDon_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
