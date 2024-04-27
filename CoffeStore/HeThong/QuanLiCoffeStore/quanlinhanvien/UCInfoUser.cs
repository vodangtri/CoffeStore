using CoffeStore.BLL;
using CoffeStore.HeThong.NhanVienBanHang.GioHang;
using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeStore.HeThong.QuanLiCoffeStore.QuanLiNhanVien
{
    public partial class UCInfoUser : UserControl
    {
        string id = null;
        public UCInfoUser(string userID)
        {
            id= userID;
            InitializeComponent();
        }

        private void UCInfoUser_Load(object sender, EventArgs e)
        {
            load_User();
        }

        string fullname, email, phonenumber, birthday, diachi, userrole;

        private void dtgvLoadUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi click vào một dòng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvLoadUser.Rows[e.RowIndex];

                // Lấy giá trị của các cột trong dòng được chọn
                fullname = selectedRow.Cells["FullName"].Value.ToString();
                email = selectedRow.Cells["Email"].Value.ToString();
                phonenumber = selectedRow.Cells["PhoneNumber"].Value.ToString();
                birthday = selectedRow.Cells["BirthDay"].Value.ToString();
                diachi = selectedRow.Cells["DiaChi"].Value.ToString();
                userrole = selectedRow.Cells["UserRole"].Value.ToString();
                string message = $"fullname: {fullname}\nemail: {email}\nphonenumber: {phonenumber}\nbirthday: {birthday}\n diachi: {diachi}\nuserrole: {userrole}";
                MessageBox.Show(message, "Thông tin dòng được chọn");

            }
        }
        UserBLL userBLL = new UserBLL();
        public void load_User()
        {

            // Lấy dữ liệu từ cơ sở dữ liệu và cập nhật DataGridView
            DataTable dataTable = userBLL.GetInfoUser(id);
            dtgvLoadUser.DataSource = dataTable;
            dtgvLoadUser.AutoResizeColumns();
            dtgvLoadUser.AutoGenerateColumns = true; // Cho phép tự động sinh tên cột từ tên cột trong DataTable

            dtgvLoadUser.Columns["FullName"].HeaderText = "Họ Và tên";
            dtgvLoadUser.Columns["FullName"].Width = 100; // Thiết lập chiều rộng cho cột
            //dtgvListOrder.Columns["IDGioHang"].DefaultCellStyle.Font = new Font("Arial", 14); // Thiết lập font chữ và kích thước

            dtgvLoadUser.Columns["Email"].HeaderText = "Email";
            dtgvLoadUser.Columns["Email"].Width = 200; // Thiết lập chiều rộng cho cột
                                                           //  dtgvListOrder.Columns["NameItems"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvLoadUser.Columns["PhoneNumber"].HeaderText = "Số Điện thoại";
            dtgvLoadUser.Columns["PhoneNumber"].Width = 80; // Thiết lập chiều rộng cho cột
                                                         // dtgvListOrder.Columns["Quantity"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvLoadUser.Columns["BirthDay"].HeaderText = "Ngày sinh";
            dtgvLoadUser.Columns["BirthDay"].Width = 120; // Thiết lập chiều rộng cho cột
                                                       // dtgvListOrder.Columns["Price"].DefaultCellStyle.Font = new Font("Arial", 14);
            dtgvLoadUser.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgvLoadUser.Columns["Diachi"].Width = 120;

            dtgvLoadUser.Columns["UserRole"].HeaderText = "Vai trò";
            dtgvLoadUser.Columns["UserRole"].Width = 120;


            dtgvLoadUser.ScrollBars = ScrollBars.Vertical;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInfoUser addInfoUser = new AddInfoUser();
            addInfoUser.ShowDialog();
        }
    }
}
