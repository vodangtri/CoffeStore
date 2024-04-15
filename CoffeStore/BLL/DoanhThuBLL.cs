using CoffeStore.DAL;
using System.Data;

namespace CoffeStore.BLL
{
    internal class DoanhThuBLL
    {
        DoanhThuDAL revenue = new DoanhThuDAL();
        public DataTable DoanhThu_BLL(string start,string end) { 
            return revenue.DoanhThu_DAL(start, end);
        }
        public int TongDoanhThu_BLL(string startDateString,string endDateString) {
            return revenue.TongDoanhThu_DAL(startDateString,endDateString);
        }
    }
}
