using CoffeStore.BLL;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong
{
    public partial class ItemsBH : UserControl
    {

        public ItemsBH()
        {
            InitializeComponent();
           
        }

        private void Items_Load(object sender, EventArgs e)
        {

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

        public string Title { get { return _title; } set { _title = value; lblTitle.Text = value; } }
        [Category("Custom Props")]
        public int Price { get { return _price; } set { _price = value; lblPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int TotalQuantity { get { return _totalQuantity; } set { _totalQuantity = value; quantity.Text = value.ToString(); } }
      [Category("Custom Props")]
        public Image Picture { get { return _pic; } set { _pic = value; pbImage.Image = value; } }




        public void setChoice(Label lbl,Button btn, Boolean flag)
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
            if (TotalQuantity > 0)
            {
                setChoice(lblQuantity2, btnPlus, true);
                this.TotalQuantity = this.TotalQuantity - 1;
            }
        
           // ItemsBH item = new ItemsBH();
      

        }
        int soLuong;
        public void SoLuong(int num)
        {
            soLuong = num;
        }
        
        private void btnSub_Click(object sender, EventArgs e)
        { 
            setChoice(lblQuantity2, btnSub, false);
            if (this.TotalQuantity< soLuong)
            {

                this.TotalQuantity = this.TotalQuantity + 1;
                ItemsBH item = new ItemsBH();
         
            }
          /*  else if (TotalQuantity == 0)
            {
                ItemsBH item = new ItemsBH();
               // item.deleteCartItem_CartTable_BLL(this.ID, this.UserID);
            }*/
        }
        ItemsBLL itemsBLL = new ItemsBLL();
        ItemsCart_BLL itemsCart_BLL = new ItemsCart_BLL();
        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            string idValue = ID;
            int soLuong = TotalQuantity;

            string ItemPicture = ImageLink;
            string ItemTitle = Title;
            int ItemPrice = Price;
            int numItemsOfCart = int.Parse(lblQuantity2.Text);


            if (lblQuantity2.Text == "0")
            {
                MessageBox.Show("Vui lòng chọn số lượng"+ ID);
                return;
            }
            else
            {
                itemsCart_BLL.InsertIntoCart_BLL(idValue, ItemPicture, ItemTitle, ItemPrice, numItemsOfCart);
                itemsBLL.UpdateQuantity_BLL(idValue, soLuong);//cap nhat lai so luong của items trong thuc don
                
            }

            if (TotalQuantity == 0)// neu so luong ==0 thi xoa luon khoi thuc don
            {

                itemsBLL.UpdateInfomationBLL(idValue);
            }

        }


        private void SubItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ldlDVT_Click(object sender, EventArgs e)
        {

        }

        private void lblQuantity2_Click(object sender, EventArgs e)
        {

        }


    }
}
