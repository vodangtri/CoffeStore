using CoffeStore.BLL;
using CoffeStore.HeThong.NhanVienBanHang.GioHang;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon
{
    public partial class UCBill : UserControl
    {
        bool check;
        public UCBill(bool bonus)
        {
            InitializeComponent();
            check = bonus;
        }



        private string _idOrder;
        private string _ngayLap;
        private string _thoiGian;
        private string _idNhanvien;
        private string _idGioHang;
        private string _nameItems;
        private int _totalQuantity;
        private int _price;

        [Category("Custom Props")]
        public string IdOrder { get { return _idOrder; } set { _idOrder = value; lblIdOrder.Text = value; } }

        [Category("Custom Props")]
        public string NgayLap { get { return _ngayLap; } set { _ngayLap = value; lblNgayLap.Text = value; } }

        [Category("Custom Props")]
        public string ThoiGian { get { return _thoiGian; } set { _thoiGian = value; lblThoiGian.Text = value; } }

        [Category("Custom Props")]
        public string IdNhanvien { get { return _idNhanvien; } set { _idNhanvien = value; } }

        [Category("Custom Props")]
        public string IdGioHang { get { return _idGioHang; } set { _idGioHang = value; } }

        [Category("Custom Props")]
        public string NameItems { get { return _nameItems; } set { _nameItems = value; } }

        [Category("Custom Props")]
        public int TotalQuantity { get { return _totalQuantity; } set { _totalQuantity = value; } }

        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; } }



        private void UCBill_Load(object sender, EventArgs e)
        {
            if (check == false)
            {
                btnBonus.Visible = false;
            }
        }


        private void btnXem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(IdNhanvien);
            Bill billForm = new Bill();
            billForm.IdOrder = IdOrder;
            billForm.NgayLap = NgayLap;
            billForm.ThoiGian = ThoiGian;
            billForm.IdNhanvien = IdNhanvien;
            billForm.ShowDialog();
        }
        ListOrder_BLL listOrder = new ListOrder_BLL();
        private void btnBonus_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                listOrder.AddToBill_BLL(IdOrder, NgayLap, ThoiGian, IdNhanvien);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            listOrder.HuyDon(IdOrder);
        }
    }
}
