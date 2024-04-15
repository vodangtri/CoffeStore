using CoffeStore.HeThong.DangNhapHeThong;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong
{
    public partial class UCPhoneNumber : UserControl
    {
        public string userName;
     
       public UCPhoneNumber() {
            
            InitializeComponent();
            txtPhoneNumber.ForeColor = Color.Silver;
        }
      
        public UCPhoneNumber(string data)
        {
            InitializeComponent();
            txtPhoneNumber.ForeColor = Color.Silver;

            this.userName = data;
           
   
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length == 10)
            {
                Hide();
                UserControl newControl = new UCOTP(userName);

                // Thiết lập các thuộc tính và vị trí cho UserControl mới
                newControl.Dock = DockStyle.Fill;
                newControl.Parent = Parent;

                // Hiển thị UserControl mới
                newControl.Show();
            }
            else
            {
                MessageBox.Show("Yêu cầu số điện thoại có đủ 10 số.");
            }
        }
    


    private void UCPhoneNumber_Load(object sender, EventArgs e)
        {
          //  MessageBox.Show(_data);
        }

        private void txtPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "Số điện thoại")
            {
                txtPhoneNumber.Text = "";
                txtPhoneNumber.ForeColor = Color.Black;
            }
        }
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text == "")
            {
                txtPhoneNumber.Text = "Số điện thoại";
                txtPhoneNumber.ForeColor = Color.Silver;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
  
 
    }
}
