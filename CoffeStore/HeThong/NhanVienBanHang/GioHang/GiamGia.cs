using CoffeStore.BLL;
using System;
using System.Windows.Forms;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class GiamGia : Form
    {
        string idHD;
        public GiamGia(string idHoaDon)
        {
            InitializeComponent();
            idHD = idHoaDon;
        }

        private void GiamGia_Load(object sender, EventArgs e)
        {
            MessageBox.Show(idHD);
        }
        HoaDonBLL hd=new HoaDonBLL();
        int soLuongVoucher;
        string sdt;
        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            sdt = txtSDT.Text;
            if (txtSDT.Text.Length == 10)
            {
                lblVoucher.Text = hd.LaySoLuongVoucher(int.Parse(txtSDT.Text));
                soLuongVoucher = int.Parse(hd.LaySoLuongVoucher(int.Parse(txtSDT.Text)));
            }
            else
            {
                MessageBox.Show("Yêu cầu số điện thoại có đủ 10 số.", "Thông báo");
            }
        }
        public void setChoice(Label lbl, Button btn, Boolean flag)
        {
            int n = Int32.Parse(lbl.Text);
            if (flag)
            {
                lbl.Text = (n + 1).ToString();
            }
            else
            {
                if (n > 0)
                {
                    lbl.Text = (n - 1).ToString();
                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblVoucher.Text) < soLuongVoucher)
            {
                setChoice(lblVoucher, btnPlus, true);
               
            }

        }
 
        private void btnSub_Click(object sender, EventArgs e)
        {

            if (int.Parse(lblVoucher.Text)>0)
            {
                setChoice(lblVoucher, btnSub, false);
            }
  
        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }
        HoaDonBLL hoadon = new HoaDonBLL();
        private void btnApDung_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(lblVoucher.Text);
            hoadon.ApplyVoucher(idHD,sdt, lblVoucher.Text);
            this.Hide();
         

        }
    }
}
