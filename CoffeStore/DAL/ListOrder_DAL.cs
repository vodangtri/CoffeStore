using System.Data;

namespace CoffeStore.DAL
{
    internal class ListOrder_DAL:DatabaseAccess
    {
        public DataTable ListOrderDAL()
        {
            return ListOrder_DA_DAL();
        }
        public DataTable Bill_DAL(string idOrder)
        {
            return Bill_DA_DAL(idOrder);
        }

        public void AddToBill_DAL(string IdOrder, string NgayLap, string ThoiGian, string IdNhanvien)
        {
            AddToBill_DA_DAL(IdOrder, NgayLap, ThoiGian, IdNhanvien);
        }

        public void DeleteItems_DAL(string idGioHang, int quantity,string IdOrder)
        {
            DeleteItems_DA_DAL(idGioHang, quantity, IdOrder);
        }
        public void HuyDon_DAL(string IdOrder)
        {
            HuyDon_DA_DAL(IdOrder);
        }
        public void Thanhtoan_DAL(string IdOrder)
        {
            Thanhtoan_DA_DAL(IdOrder);
        }
     /*   public void HoanThanhDatMon_DAL(string id)
        {
            HoanThanhDatMon_DA_DAL(string id);
        }*/
    }
}
//System.Data.SqlClient.SqlException: 'Ambiguous column name 'Quantity'.'