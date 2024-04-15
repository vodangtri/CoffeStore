using CoffeStore.BLL;
using System;
using System.Windows.Forms;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class TichDiem : Form
    {
        string id;
        bool btnTichDiemClicked = false;

        public TichDiem(string IdOrder)
        {
            InitializeComponent();
            id = IdOrder;
        }

        private void lblDiem_Click(object sender, EventArgs e)
        {

        }

        TichDiemBLL Diem = new TichDiemBLL();
        private void btnTichDiem_Click(object sender, EventArgs e)
        {
            if (!btnTichDiemClicked)
            {
                btnTichDiemClicked = true;

                string tichDiem = txtTichDiem.Text;
                if (txtTichDiem.Text.Length == 10)
                {
                    Diem.TichDiem_BLL(int.Parse(txtTichDiem.Text));
                    lblDiem.Text = Diem.LayDiem_BLL(int.Parse(txtTichDiem.Text));
                }
                else
                {
                    MessageBox.Show("Yêu cầu số điện thoại có đủ 10 số.", "Thông báo");
                }
            }
        }
   
    private void TichDiem_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(id);
        }
        private void txtTichDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
