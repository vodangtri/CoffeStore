using CoffeStore.BLL;
using CoffeStore.DAL;
using CoffeStore.HeThong.QuanLiTaiKhoan;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiThucDon
{
    public partial class UCQLTK : UserControl
    {
        string userId,userName, birthDay, email, sdt, diaChi, userRole;
        UserBLL userBLL = new UserBLL();
        public UCQLTK(string id)
        {
            userId = id;
            
            InitializeComponent();
            txtfullname.Text = userBLL.LayHoTen(id);

            txtbirthday.Text = userBLL.LayNgaySinh(id);

            txtemail.Text = userBLL.LayEmail(id);

            txtsdt.Text = userBLL.LayPhoneNumber(id);

            txtdiachi.Text = userBLL.LayDiaChi(id);

            txtuserrole.Text = userBLL.LayUserRole(id);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtfullname.ReadOnly = false;
            txtbirthday.ReadOnly = false;
            txtemail.ReadOnly = false;
            txtsdt.ReadOnly = false;
            txtdiachi.ReadOnly = false;
            txtuserrole.ReadOnly = false;

        }

        private void btndoimatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau(userId);
            doiMatKhau.ShowDialog();
        }

        private void pnlQLTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, System.EventArgs e)
        {


        }

        private void txtbirthday_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtsdt_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void btncapnhat_Click(object sender, System.EventArgs e)
        {
            userName = txtfullname.Text;
            birthDay = txtbirthday.Text;
            email = txtemail.Text;
            sdt = txtsdt.Text;
            diaChi = txtdiachi.Text;
            userRole = txtuserrole.Text;
            DateTime datetime = DateTime.Parse(birthDay);

            userBLL.UpdateInfomationUserBLL(userId,userName, datetime, email, sdt, diaChi, userRole);
            
         //   this.Hide();
          //  this.Show();
            txtfullname.ReadOnly = true;
            txtbirthday.ReadOnly = true;
            txtemail.ReadOnly = true;
            txtsdt.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            txtuserrole.ReadOnly = true;
        }
    }
}
