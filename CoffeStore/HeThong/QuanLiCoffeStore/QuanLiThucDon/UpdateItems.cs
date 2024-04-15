using CoffeStore.BLL;
using System;
using System.Windows.Forms;

namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon
{
    public partial class UpdateItems : Form
    {
        public UpdateItems()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPicture_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTrangThai_TextChanged(object sender, EventArgs e)
        {

        }
        public string ItemID { get; set; }
        public string ItemPicture { get; set; }
        public string ItemTitle { get; set; }
        public int ItemPrice { get; set; }
        public int ItemQuantity { get; set; }




        private void UpdateItems_Load(object sender, EventArgs e)
        {
        // Hiển thị dữ liệu lên các textbox tương ứng
            txtId.Text = ItemID;
            txtPicture.Text = ItemPicture;
           
            txtName.Text = ItemTitle;
            txtPrice.Text = ItemPrice.ToString();
            txtQuantity.Text = ItemQuantity.ToString();
        }
        ItemsBLL itemsBLL = new ItemsBLL();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

            string Id = txtId.Text;
            string Picture = txtPicture.Text;
            string Name = txtName.Text;
            int Price = int.Parse(txtPrice.Text);
            int Quantity = int.Parse(txtQuantity.Text);
            itemsBLL.UpdateInfomationBLL(Id, Picture, Name, Price,Quantity);

            this.Hide();

            //uCThucDon.Clea();

        }

    }
}
