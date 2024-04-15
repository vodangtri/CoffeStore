using System.Data;

namespace CoffeStore.DAL
{
    internal class HoaDonDAL:DatabaseAccess
    {
        public void TaoHoaDon_DAL(string IdNhanvien)
        {
            TaoHoaDon_DA_DAL(IdNhanvien);
        }
        public void HoaDon_DAL(string IdOrder)
        {
            HoaDon_DA_DAL(IdOrder);
        }
        public DataTable HoaDon__DAL(string IdOrder)
        {
            return HoaDonDADAL(IdOrder);
        }
        public DataTable ListHoaDonDAL(string IdHoaDon)
        {
            return ListHoaDon_DA_DAL(IdHoaDon);
        }
        public string tinhTongTien_DAL(string IdHoaDon)
        {
            return tinhTongTien_DA_DAL(IdHoaDon);
        }

        public string LaySoLuongVoucher_DAL(int sdt)
        {
            return LaySoLuongVoucher_DA_DAL(sdt);
        }
        public void ApplyVoucher_DAL(string idHD,string sdt,string soLuongVoucher)
        {
            ApplyVoucher_DA_DAL(idHD,sdt, soLuongVoucher);
        }
        public int SoLuongVoucher_DAL(string IdHoaDon)
        {
            return SoLuongVoucher_DA_DAL(IdHoaDon);
        }
        public void ThemVaoDoanhThu_DAL(string IdHoaDon, string paymentMethods,string tenNhanvien, double tongTien)
        {
            ThemVaoDoanhThu_DA_DAL(IdHoaDon, paymentMethods, tenNhanvien,tongTien);
        }
    }
}
