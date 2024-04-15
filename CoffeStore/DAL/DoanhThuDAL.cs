using System.Data;

namespace CoffeStore.DAL
{
    internal class DoanhThuDAL:DatabaseAccess
    {
        public DataTable DoanhThu_DAL(string start, string end)
        {
            return DoanhThu_DA_DAL(start,end);
        }
        public int TongDoanhThu_DAL(string  startDateString,string endDateString)
        {
            return TongDoanhThu_DA_DAL(startDateString, endDateString);
        }
    }
}
