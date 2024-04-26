using CoffeStore.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        public string IdOrder { get; set; }
        public string NgayLap { get; set; }
        public string ThoiGian { get; set; }
        public string IdNhanvien {  get; set; }

        ListOrder_BLL listOrder = new ListOrder_BLL();

        private void Bill_Load(object sender, EventArgs e)
        {
            // Hiển thị dữ liệu lên các textbox tương ứng
            lblId.Text = IdOrder;
            lblDay.Text = NgayLap;
            lblTime.Text = ThoiGian;
            load_Bill();
        

         }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (MessageBox.Show("Tích điểm không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TichDiem tichDiem = new TichDiem(IdOrder);
                tichDiem.ShowDialog();
            }

            HoaDonBLL hd_BLL = new HoaDonBLL();
            hd_BLL.TaoHoaDon_BLL(IdNhanvien);
            hd_BLL.HoaDon_BLL(IdOrder);

            HoaDon hd = new HoaDon(IdOrder, "direct payment");
            hd.IdOrder = IdOrder;
            hd.NgayLap = NgayLap;
            hd.ThoiGian = ThoiGian;
            hd.IdNhanvien = IdNhanvien;
            hd.ShowDialog();

        }

        private void btnTTOnline_Click(object sender, EventArgs e)
        {
             this.Hide();
            if (MessageBox.Show("Tích điểm không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TichDiem tichDiem = new TichDiem(IdOrder);
                tichDiem.ShowDialog();
            }

            HoaDonBLL hd_BLL = new HoaDonBLL();
            hd_BLL.TaoHoaDon_BLL(IdNhanvien);
            hd_BLL.HoaDon_BLL(IdOrder);

            HoaDon hd = new HoaDon(IdOrder, "online payment");
            hd.IdOrder = IdOrder;
            hd.NgayLap = NgayLap;
            hd.ThoiGian = ThoiGian;
            hd.IdNhanvien = IdNhanvien;
            hd.ShowDialog();

        }

        public void load_Bill()
        {

            // Lấy dữ liệu từ cơ sở dữ liệu và cập nhật DataGridView
            DataTable dataTable = listOrder.Bill_BLL(IdOrder);
            dtgvListOrder.DataSource = dataTable;
            dtgvListOrder.AutoResizeColumns();
            dtgvListOrder.AutoGenerateColumns = true; // Cho phép tự động sinh tên cột từ tên cột trong DataTable

            dtgvListOrder.Columns["IDGioHang"].HeaderText = "ID";
            dtgvListOrder.Columns["IDGioHang"].Width = 100; // Thiết lập chiều rộng cho cột
            //dtgvListOrder.Columns["IDGioHang"].DefaultCellStyle.Font = new Font("Arial", 14); // Thiết lập font chữ và kích thước

            dtgvListOrder.Columns["NameItems"].HeaderText = "Tên hàng";
            dtgvListOrder.Columns["NameItems"].Width = 200; // Thiết lập chiều rộng cho cột
          //  dtgvListOrder.Columns["NameItems"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvListOrder.Columns["Quantity"].HeaderText = "Số lượng";
            dtgvListOrder.Columns["Quantity"].Width = 80; // Thiết lập chiều rộng cho cột
           // dtgvListOrder.Columns["Quantity"].DefaultCellStyle.Font = new Font("Arial", 14);

            dtgvListOrder.Columns["Price"].HeaderText = "Giá";
            dtgvListOrder.Columns["Price"].Width = 120; // Thiết lập chiều rộng cho cột
           // dtgvListOrder.Columns["Price"].DefaultCellStyle.Font = new Font("Arial", 14);
            dtgvListOrder.ScrollBars = ScrollBars.Vertical;
        }
        string idGioHang, nameItems;
        int quantity, price;

        private void dtgvListOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo chỉ xử lý khi click vào một dòng hợp lệ
            {
                DataGridViewRow selectedRow = dtgvListOrder.Rows[e.RowIndex];

                // Lấy giá trị của các cột trong dòng được chọn
                idGioHang = selectedRow.Cells["IDGioHang"].Value.ToString();
                nameItems = selectedRow.Cells["NameItems"].Value.ToString();
                quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                price = Convert.ToInt32(selectedRow.Cells["Price"].Value);
                string message = $"ID Giỏ hàng: {idGioHang}\nTên hàng: {nameItems}\nSố lượng: {quantity}\nGiá: {price}";
                MessageBox.Show(message, "Thông tin dòng được chọn");

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa món này không?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                listOrder.DeleteItems(idGioHang, quantity, IdOrder);

                load_Bill();
            }
        }
        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            //  BaseFont bf = BaseFont.CreateFont("C:\\fonts\\vuArial.ttf",
            //       BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            BaseFont bf = BaseFont.CreateFont("fonts\\vuArial.ttf",
       BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            // khỏi tạo font chữ
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 14);
            iTextSharp.text.Font boldFont = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD); // Font in đậm cho "Đơn đặt món"
            if (dtgvListOrder.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(dtgvListOrder.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;


                            foreach (DataGridViewColumn column in dtgvListOrder.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                                pdfTable.AddCell(cell);

                            }

                            foreach (DataGridViewRow row in dtgvListOrder.Rows)
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


                                Paragraph BILL = new Paragraph("Đơn đặt món", boldFont);
                                BILL.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(BILL);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph numberBill = new Paragraph("Mã đơn: " + lblId.Text, font);
                                numberBill.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(numberBill);
                                pdfDoc.Add(new Paragraph("\n"));

                                Paragraph date = new Paragraph("Ngày lập: " + lblDay.Text, font);
                                date.Alignment = Element.ALIGN_LEFT;
                                pdfDoc.Add(date);
                                pdfDoc.Add(new Paragraph("\n"));

                                pdfDoc.Add(dash);
                                pdfDoc.Add(new Paragraph("\n"));

                                pdfDoc.Add(pdfTable);

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

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

    }
}
