using CoffeStore.DAL;
using System.Data;

namespace CoffeStore.BLL
{
    internal class ListOrder_BLL
    {


        ListOrder_DAL listOrder = new ListOrder_DAL();
        public DataTable ListOrder()
        {
            return listOrder.ListOrderDAL();
        }
        public DataTable Bill_BLL(string idOrder)
        {
            return listOrder.Bill_DAL(idOrder);
        }
        public void AddToBill_BLL(string IdOrder,string  NgayLap,string ThoiGian,string IdNhanvien)
        {
            listOrder.AddToBill_DAL(IdOrder, NgayLap, ThoiGian, IdNhanvien);
        }

        public void DeleteItems(string idGioHang,int quantity,string IdOrder) 
        {
            listOrder.DeleteItems_DAL(idGioHang, quantity, IdOrder);
        }
        public void HuyDon(string IdOrder)
        {
            listOrder.HuyDon_DAL(IdOrder);
        }
        public void Thanhtoan(string IdOrder)
        {
            listOrder.Thanhtoan_DAL(IdOrder);
        }
    }
}
