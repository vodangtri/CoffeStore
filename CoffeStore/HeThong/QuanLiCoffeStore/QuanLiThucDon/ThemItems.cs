using CoffeStore.BLL;
using System;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon
{
    public partial class ThemItems : Form
    {
        public ThemItems()
        {
            InitializeComponent();
        }
        public Panel ExternalPanel { get; set; }

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

        Func func;
        ItemsBLL itemsBLL = new ItemsBLL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các trường văn bản
            string picture = txtPicture.Text;
            string nameItems = txtName.Text;
            int price = Convert.ToInt32(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            itemsBLL.InsertToMenu(picture, nameItems,price, quantity);
            this.Hide();

        }

        private void ThemItems_Load(object sender, EventArgs e)
        {

        }
    }
}
