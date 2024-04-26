using CoffeStore.BLL;
using CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static CoffeStore.HeThong.QuanLiCoffeStore.QuanLi;

namespace CoffeStore.HeThong.NhanVienBanHang.GioHang
{
    public partial class UCGioHang : UserControl
    {
        string idNhanvien;
        public UCGioHang(string userId)
        {
            InitializeComponent();
            idNhanvien = userId;

        }
        public string idOrder { get;set ; }
        public UCGioHang()
        {
           
        }

        private void UCGioHang_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(idNhanvien);
            Menu_UCGioHang(flpGioHang);
        }
       /*public Image resizeImage(Image image, int width, int height)
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
        ItemsCart_BLL itemsCart = new ItemsCart_BLL();
        string nameItems;
        int priceItems, quantityItems;
        private FlowLayoutPanel Menu_UCGioHang(FlowLayoutPanel flpGioHang)
        {

            
            if (itemsCart.ItemsCart() != null)
            {
                DataTable itemsTable = itemsCart.ItemsCart();
                int rowCount = itemsTable.Rows.Count;
                // MessageBox.Show("Số lượng hàng dữ liệu: " + rowCount.ToString());

                foreach (DataRow row in itemsCart.ItemsCart().Rows)
                {


                    CoffeStore.DTO.CartDTO newCartItem = new CoffeStore.DTO.CartDTO();


                    newCartItem.IDItems = row["IDItems"].ToString();
                  
                    newCartItem.Picture = row["Picture"].ToString();
                    newCartItem.NameItems = row["NameItems"].ToString();
                    newCartItem.Price = int.Parse((row["Price"]).ToString());
                   
                    string tenp = newCartItem.Picture;
                    UCItems Item = new UCItems();


                    Item.ImageLink = tenp;

                    // Sử dụng đường dẫn cục bộ để tạo Bitmap
                  string localImagePath = newCartItem.Picture; // Giả sử Picture chứa đường dẫn cục bộ
                   using (var stream = new FileStream(localImagePath, FileMode.Open))
                   {
                        Item.Picture = Bitmap.FromStream(stream);
                       // Item.Picture = resizeImage(Item.Picture, 255, 143);
                    }



                    Item.ID = newCartItem.IDItems;
                    Item.Title = newCartItem.NameItems;
                    Item.Price = newCartItem.Price;


                    foreach (DataRow r in itemsCart.getQuantityOfItems_BLL(newCartItem.IDItems).Rows)
                    {
                        Item.TotalQuantity = int.Parse(r["Quantity"].ToString());
                        break;
                    }
                    nameItems = Item.Title;
                    priceItems = Item.Price;
                    quantityItems = Item.TotalQuantity;
                    flpGioHang.Controls.Add(Item);

                }

                return flpGioHang;
            }

            else
            {
                MessageBox.Show("Không có dữ liệu");
                return null;
            }
        }
 
        private void btnBill_Click(object sender, EventArgs e)
        {

            itemsCart.createOrder_BLL(idNhanvien);

            flpGioHang.Controls.Clear();
         
        }

        private void flpGioHang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {

            itemsCart.AddBillBLL();


            this.Hide();
            UserControl newControl = new UCListOrder(true);

            newControl.Dock = DockStyle.Fill;
            newControl.Parent = Parent;
            newControl.Show();


        }
    


        private void btnListBill_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserControl newControl = new UCListOrder(false);

            newControl.Dock = DockStyle.Fill;
            newControl.Parent = Parent;

            newControl.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
