using CoffeStore.DAL;
using System.Data;

namespace CoffeStore.BLL
{
    internal class HoaDonBLL
    {
        HoaDonDAL hd_DAL = new HoaDonDAL();
        public void TaoHoaDon_BLL(string IdNhanvien) {
            hd_DAL.TaoHoaDon_DAL(IdNhanvien);
        }

        public void HoaDon_BLL(string IdOrder)
        {
            hd_DAL.HoaDon_DAL(IdOrder);
        }

        public DataTable HoaDon(string IdOrder)
        {
            return hd_DAL.HoaDon__DAL(IdOrder);
        }
        public DataTable ListHoaDon(string IdHoaDon)
        {
            return hd_DAL.ListHoaDonDAL(IdHoaDon);
        }

        public string tinhTongTien(string IdHoaDon)
        {
            return hd_DAL.tinhTongTien_DAL(IdHoaDon);
        }
        public string LaySoLuongVoucher(int sdt)
        {
            return hd_DAL.LaySoLuongVoucher_DAL(sdt);
        }
        public void ApplyVoucher(string idHD,string sdt,string soLuongVoucher)
        {
            hd_DAL.ApplyVoucher_DAL(idHD,sdt,soLuongVoucher);
        }
        public int SoLuongVoucher(string IdHoaDon)
        {
            return hd_DAL.SoLuongVoucher_DAL(IdHoaDon);
        }
        public void ThemVaoDoanhThu(string IdHoaDon,string paymentMethods, string tenNhanvien, double tongTien)
        {
            hd_DAL.ThemVaoDoanhThu_DAL(IdHoaDon,paymentMethods, tenNhanvien,tongTien);
        }
    }
}
