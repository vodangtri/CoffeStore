using CoffeStore.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeStore.HeThong.QuanLiCoffeStore.DoanhThu
{
    public partial class UCDoanhThu : UserControl
    {
        public UCDoanhThu()
        {
            InitializeComponent();
        }

        private void UCDoanhThu_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        DoanhThuBLL revenue = new DoanhThuBLL();
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            string startDateString = startDate.ToShortDateString();
            string endDateString = endDate.ToShortDateString();

            LoadRevenue(startDateString, endDateString);
            lblTongTien.Text = TongTien(startDateString,endDateString).ToString();
        }
        public int TongTien(string startDateString, string endDateString)
        {
            return revenue.TongDoanhThu_BLL(startDateString, endDateString);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {

        }
        public void LoadRevenue(string startDateString, string endDateString)
        {
            DataTable dataTable = revenue.DoanhThu_BLL(startDateString, endDateString);
            dtgvRevenueinf.DataSource = dataTable;
            dtgvRevenueinf.AutoResizeColumns();
            dtgvRevenueinf.AutoGenerateColumns = true; // Cho phép tự động sinh tên cột từ tên cột trong DataTable

            dtgvRevenueinf.Columns["HD_IDHoaDon"].HeaderText = "ID Hóa đơn";
            dtgvRevenueinf.Columns["HD_IDHoaDon"].Width = 80; // Thiết lập chiều rộng cho cột
            dtgvRevenueinf.Columns["HD_IDHoaDon"].DefaultCellStyle.Font = new Font("Arial", 14); // Thiết lập font chữ và kích thước

            dtgvRevenueinf.Columns["NgayLap"].HeaderText = "Ngày lập (tháng/ngày/năm)";
            dtgvRevenueinf.Columns["NgayLap"].Width = 80; // Thiết lập chiều rộng cho cột
            dtgvRevenueinf.Columns["NgayLap"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvRevenueinf.Columns["TenNhanvien"].HeaderText = "Tên nhân viên";
            dtgvRevenueinf.Columns["TenNhanvien"].Width = 100; // Thiết lập chiều rộng cho cột
            dtgvRevenueinf.Columns["TenNhanvien"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvRevenueinf.Columns["TongtienHD"].HeaderText = "Tổng tiền";
            dtgvRevenueinf.Columns["TongtienHD"].Width = 80; // Thiết lập chiều rộng cho cột
            dtgvRevenueinf.Columns["TongtienHD"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvRevenueinf.Columns["GhiChu"].HeaderText = "Ghi chú";
            dtgvRevenueinf.Columns["GhiChu"].Width = 200; // Thiết lập chiều rộng cho cột
            dtgvRevenueinf.Columns["GhiChu"].DefaultCellStyle.Font = new Font("Arial", 14);
            dtgvRevenueinf.ScrollBars = ScrollBars.Vertical;
        }
        private void dtgvRevenueinf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
