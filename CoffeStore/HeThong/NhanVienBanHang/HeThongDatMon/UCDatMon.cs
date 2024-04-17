using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon
{
    public partial class UCDatMon : UserControl
    {
        Func func = new Func();
        public UCDatMon()
        {

            InitializeComponent();
            UCThucDon refreshedUC = new UCThucDon();
           pnlThucDon.Controls.Add(refreshedUC);

        }
        private void pnlThucDon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlQLTD_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
