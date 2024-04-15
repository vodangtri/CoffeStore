using CoffeStore.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace CoffeStore.HeThong.NhanVienBanHang.HeThongDatMon
{
    public partial class UCListOrder : UserControl
    {
        bool check;
        public UCListOrder(Boolean bonus)
        {
            InitializeComponent();
            check = bonus;
        }

        ListOrder_BLL listOrder = new ListOrder_BLL();

        private FlowLayoutPanel ListOrder(FlowLayoutPanel flpListOrder)
        {


            if (listOrder.ListOrder() != null)
            {
                DataTable listTable = listOrder.ListOrder();

                foreach (DataRow row in listOrder.ListOrder().Rows)
                {


                    CoffeStore.DTO.ListOrderDTO newListOrder = new CoffeStore.DTO.ListOrderDTO();


                    newListOrder.IdOrder = row["IdOrder"].ToString();
                    newListOrder.NgayLap = row["NgayLap"].ToString();
                    newListOrder.ThoiGianLap = row["ThoiGianLap"].ToString();
                    newListOrder.IdNhanvien= row["IdNhanvien"].ToString();

                    UCBill bill = new UCBill(check);

                    bill.IdOrder = newListOrder.IdOrder;
                    bill.ThoiGian = newListOrder.ThoiGianLap;
                    bill.NgayLap = newListOrder.NgayLap;
                    bill.IdNhanvien=newListOrder.IdNhanvien;
                    flpListOrder.Controls.Add(bill);

                }

                return flpListOrder;
            }

            else
            {
                MessageBox.Show("Không có dữ liệu");
                return null;
            }
        }



        private void flpListOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCListOrder_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(check.ToString());
            ListOrder(flpListOrder);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
