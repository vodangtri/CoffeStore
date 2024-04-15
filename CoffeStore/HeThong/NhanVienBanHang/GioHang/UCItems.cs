using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class UCItems : UserControl
    {
        public UCItems()
        {
            InitializeComponent();
        }

        private string _imgLink;
        private string _id;
        private string _userID;
        private int _totalQuantity;
        private string _title;
        private int _price;
        private string _status;
        private Image _pic;

        [Category("Custom Props")]
        public string ImageLink { get { return _imgLink; } set { _imgLink = value; } }
        [Category("Custom Props")]
        public string ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]

        //    public string UserID { get { return _userID; } set { _userID = value; } }
        //  [Category("Custom Props")]
        public string Title { get { return _title; } set { _title = value; lblTitle.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int TotalQuantity { get { return _totalQuantity; } set { _totalQuantity = value; quantity.Text = value.ToString(); } }
        [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pbImage.Image = value; } }

        private void UCItems_Load(object sender, EventArgs e)
        {

        }

        private void ldlDVT_Click(object sender, EventArgs e)
        {

        }
    }
}
