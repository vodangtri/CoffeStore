using CoffeStore.BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Reflection.Emit;
using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using static System.Net.Mime.MediaTypeNames;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class HoaDon : Form
    {
        private bool isButtonClicked = false;
        string id;
        string paymentMethods;
     
        public HoaDon(string IdOrder, string payment_methods)
        {
            InitializeComponent();
            id = IdOrder;
            paymentMethods = payment_methods;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoaDon_FormClosing);
        }
        public string IdOrder { get; set; }
        public string NgayLap { get; set; }
        public string ThoiGian { get; set; }
        public string IdNhanvien { get; set; }
        private void dtgvBillinf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void HoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isButtonClicked)
            {
                MessageBox.Show("Vui lòng nhấn vào 'In Hóa Đơn' trước khi đóng form!");
                e.Cancel = true; // This will cancel the close event
            }
        }
        UserBLL user =new UserBLL();
        HoaDonBLL hd_BLL = new HoaDonBLL();
        string IdHoaDon;
        string tenNhanvien;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(paymentMethods);
            if (hd_BLL.HoaDon(IdOrder) != null)
            {
                DataTable itemsTable = hd_BLL.HoaDon(IdOrder);
                int rowCount = itemsTable.Rows.Count;
                // MessageBox.Show("Số lượng hàng dữ liệu: " + rowCount.ToString());

                foreach (DataRow row in hd_BLL.HoaDon(IdOrder).Rows)
                {
                    CoffeStore.DTO.HoaDonDTO hd = new CoffeStore.DTO.HoaDonDTO();

                    lblId.Text = row["HD_IDHoaDon"].ToString();
                    IdHoaDon= row["HD_IDHoaDon"].ToString();
                    lblDay.Text = row["HD_NgayLap"].ToString();
                    lblTime.Text = row["HD_ThoiGian"].ToString();
                    lblIdNhanvien.Text = user.getNameNVById(row["HD_IdNhanvien"].ToString());
                    tenNhanvien = lblIdNhanvien.Text;
                    break;
                }
            }

            ListHoaDon();
            lblTien.Text = hd_BLL.tinhTongTien(IdHoaDon);
      
            lblTongCong.Text = (double.Parse(lblTien.Text)).ToString();
            
        }

        public string tinhTienGiamGia(string IdHoaDon,string tienTamTinh)
        {
            int soLuong=hd_BLL.SoLuongVoucher(IdHoaDon);
            double tienGiam = (int.Parse(tienTamTinh)*(0.3 * soLuong));
            return tienGiam.ToString();
        }
        HoaDonBLL hoadon = new HoaDonBLL();
        public void ListHoaDon()
        {

            // Lấy dữ liệu từ cơ sở dữ liệu và cập nhật DataGridView
            DataTable dataTable = hoadon.ListHoaDon(IdHoaDon);
            dtgvBillinf.DataSource = dataTable;
            dtgvBillinf.AutoResizeColumns();
            dtgvBillinf.AutoGenerateColumns = true; // Cho phép tự động sinh tên cột từ tên cột trong DataTable

            dtgvBillinf.Columns["NameItems"].HeaderText = "Tên";
            dtgvBillinf.Columns["NameItems"].Width = 200; // Thiết lập chiều rộng cho cột
          //  dtgvBillinf.Columns["NameItems"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvBillinf.Columns["Quantity"].HeaderText = "Số lượng";
            dtgvBillinf.Columns["Quantity"].Width = 80; // Thiết lập chiều rộng cho cột
           // dtgvBillinf.Columns["Quantity"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvBillinf.Columns["Price"].HeaderText = "Giá";
            dtgvBillinf.Columns["Price"].Width = 120; // Thiết lập chiều rộng cho cột
           // dtgvBillinf.Columns["Price"].DefaultCellStyle.Font = new Font("Arial", 14);
            dtgvBillinf.ScrollBars = ScrollBars.Vertical;
        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblTien_Click(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            GiamGia giamgia = new GiamGia(IdHoaDon);
            giamgia.ShowDialog();
            lblTienGiamGia.Text = tinhTienGiamGia(IdHoaDon, lblTien.Text);
        }

        private void lblTienGiamGia_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblTongCong.Text = (double.Parse(lblTien.Text) - double.Parse(lblTienGiamGia.Text)).ToString();
        }

        ListOrder_BLL listOrder = new ListOrder_BLL();
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

            hd_BLL.ThemVaoDoanhThu(IdHoaDon,paymentMethods, tenNhanvien, double.Parse(lblTongCong.Text));
            isButtonClicked = true;
            ListOrder_BLL listOrder = new ListOrder_BLL();
            listOrder.Thanhtoan(IdOrder);
            BaseFont bf = BaseFont.CreateFont("C:\\fonts\\vuArial.ttf",
                                   BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            // khỏi tạo font chữ
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 14);
            iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
            if (dtgvBillinf.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                 sfd.FileName = lblId.Text + ".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Không thể ghi dữ liệu tới ổ đĩa. Mô tả lỗi:" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dtgvBillinf.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in dtgvBillinf.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                pdfTable.AddCell(cell);

                            }

                            foreach (DataGridViewRow row in dtgvBillinf.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    if (cell.Value != null)
                                    {
                                        //pdfTable.AddCell(cell.Value.ToString());
                                        PdfPCell t = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                                        pdfTable.AddCell(t);
                                    }
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A5, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();

                                Paragraph dash = new Paragraph("______________________________________________________________");
                                dash.Alignment = Element.ALIGN_CENTER;

                                Paragraph nameShop = new Paragraph("21 Tea & Coffee", boldFont);
                                nameShop.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(nameShop);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph addrShop = new Paragraph("Địa chỉ: 1A Tôn Thất Tùng Nha Trang, Khánh Hòa Province, Vietnam", font);
                                addrShop.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(addrShop);
                                pdfDoc.Add(new Paragraph("\n"));


                                Paragraph BILL = new Paragraph("HÓA ĐƠN", boldFont);
                                BILL.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(BILL);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph numberBill = new Paragraph("Mã hóa đơn: " + lblId.Text, font);
                                numberBill.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(numberBill);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph date = new Paragraph("Ngày thanh toán: " + lblDay.Text +"     "+ lblTime.Text, font);
                                date.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(date);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph emp = new Paragraph("Nhân viên: " + lblIdNhanvien.Text, font);
                                emp.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(emp);
                                pdfDoc.Add(dash);
                                pdfDoc.Add(new Paragraph("\n"));

                                pdfDoc.Add(pdfTable);

                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph Money = new Paragraph("Tổng tiền: " + lblTien.Text + " đ", font);
                                Money.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(Money);
                                pdfDoc.Add(new Paragraph("\n"));
                                Paragraph dis = new Paragraph("Giảm: - " + lblTienGiamGia.Text + " đ", font);
                                dis.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(dis);
                                pdfDoc.Add(new Paragraph("\n"));
                                Paragraph totalMoney = new Paragraph("Thanh toán: " + lblTongCong.Text + " đ", font);
                                totalMoney.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(totalMoney);

                                pdfDoc.Add(new Paragraph("\n"));
                                Paragraph _dash = new Paragraph("__________________________o0o__________________________");
                                _dash.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(_dash);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Dữ liệu Export thành công!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Mô tả lỗi :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có bản ghi nào được Export!!!", "Info");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
