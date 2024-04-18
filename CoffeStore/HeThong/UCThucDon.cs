using CoffeStore.BLL;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CoffeStore.HeThong
{
    public partial class UCThucDon : UserControl
    {

        public UCThucDon()
        {
            InitializeComponent();
        }



      /*  public Image resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                using (var wrapMode = new System.Drawing.Imaging.ImageAttributes())
                {
                    wrapMode.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }*/

        private FlowLayoutPanel Menu_UCThucDon(FlowLayoutPanel flowLayoutPanel1)
        {
           
            ItemsBLL itemsBLL = new ItemsBLL();
            if (itemsBLL.Items_BLL()!=null)
            {
                DataTable itemsTable = itemsBLL.Items_BLL();
         //       int rowCount = itemsTable.Rows.Count;
                // MessageBox.Show("Số lượng hàng dữ liệu: " + rowCount.ToString());
      
                foreach (DataRow row in itemsBLL.Items_BLL().Rows)
                {
                    

                    CoffeStore.DTO.ItemsDTO newMenuItem = new CoffeStore.DTO.ItemsDTO();


                    newMenuItem.ID = row["ID"].ToString();
                    newMenuItem.Picture = row["Picture"].ToString();
                    newMenuItem.NameItems = row["NameItems"].ToString();
                    newMenuItem.Price = int.Parse((row["Price"]).ToString());
                    newMenuItem.TrangThai = row["TrangThai"].ToString();
                    string tenp = newMenuItem.Picture;
                    ItemsBH Item1 = new ItemsBH();
                    ItemsQL Item2 = new ItemsQL();
                    
                    var parent = this.FindForm(); // Trả về đối tượng của form chứa user control hiện tại.
                    var findControl = parent.Controls.Find("UCThucDon", true).FirstOrDefault();
                    string fullPath = parent.Text;
                    int lastIndex = fullPath.LastIndexOf('.') + 1; // Tìm vị trí cuối cùng của dấu chấm và cộng thêm 1
                    string text = fullPath.Substring(lastIndex); // Lấy phần chuỗi từ vị trí cuối cùng của dấu chấm trở đi
                    if (findControl != null)
                    {
                        if (fullPath == "BanHang")
                        {
                            Item1.ImageLink = tenp;

                            // Sử dụng đường dẫn cục bộ để tạo Bitmap
                            string localImagePath = newMenuItem.Picture; // Giả sử Picture chứa đường dẫn cục bộ
                            using (var stream = new FileStream(localImagePath, FileMode.Open))
                            {
                                Item1.Picture = Bitmap.FromStream(stream);
                                //   Item1.Picture = resizeImage(Item1.Picture, 255, 143);
                            }

                            Item1.ID = newMenuItem.ID;
                            Item1.Title = newMenuItem.NameItems;
                            Item1.Price = newMenuItem.Price;


                            foreach (DataRow r in itemsBLL.getTotalQuantityOfItemsBLL(newMenuItem.ID).Rows)
                            {
                                Item1.TotalQuantity = int.Parse(r["Quantity"].ToString());
                                int num = Item1.TotalQuantity;
                                Item1.SoLuong(num);
                                break;
                            }
                            flowLayoutPanel1.Controls.Add(Item1);
                        }
                        else if(fullPath == "QuanLi")
                        {
                            Item2.ImageLink = tenp;

                            // Sử dụng đường dẫn cục bộ để tạo Bitmap
                              string localImagePath = newMenuItem.Picture; // Giả sử Picture chứa đường dẫn cục bộ
                              using (var stream = new FileStream(localImagePath, FileMode.Open))
                              {
                                  Item2.Picture = Bitmap.FromStream(stream);
                                //  Item2.Picture = resizeImage(Item2.Picture, 255, 143);
                              }
               

                            Item2.ID = newMenuItem.ID;
                            Item2.Title = newMenuItem.NameItems;
                            Item2.Price = newMenuItem.Price;


                            foreach (DataRow r in itemsBLL.getTotalQuantityOfItemsBLL(newMenuItem.ID).Rows)
                            {
                                Item2.TotalQuantity = int.Parse(r["Quantity"].ToString());
                                break;
                            }
                            flowLayoutPanel1.Controls.Add(Item2);
                        }
                    }
                    
                }

                return flowLayoutPanel1;
            }

             else
            {
                MessageBox.Show("Không có dữ liệu");
                return null;
            }
        }

        private void UCThucDon_Load(object sender, EventArgs e)
        {
            Menu_UCThucDon(flowLayoutPanel1);
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.Padding = new Padding(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu_UCThucDon(flowLayoutPanel1);
        }

        public void Clea()
        {
            flowLayoutPanel1.Controls.Clear();
            Menu_UCThucDon(flowLayoutPanel1);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
