using CoffeStore.DAL;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeStore.BLL
{
    internal class UserBLL
    {
        UserCRUD_DAL data = new UserCRUD_DAL();
        public string getIdByUsername(string name)
        {

            return data.getIdByUsername_DAL(name);
        }
        public string getNameNVById(string IdNhanvien) {
            return data.getNameNVById_DAL(IdNhanvien);
        }
        public void ChangePassword_BLL(string username, string newPassword)
        {
            data.ChangePassword_DAL(username, newPassword);
        }
        public string LayHoTen(string id)
        {
            return data.LayHoTenDAL(id);
        }
        public string LayNgaySinh(string id) {
            return data.LayNgaySinhDAL(id);
        }
        public string LayEmail(string id) {
            return data.LayEmailDAL(id);
        }
        public string LayPhoneNumber(string id){
            return data.LayPhoneNumberDAL(id);
        }
        public string LayDiaChi(string id) {
            return data.LayDiaChiDAL(id);
        }
        public string LayUserRole(string id) {
            return data.LayUserRoleDAL(id);
        }
        public void  UpdateInfomationUserBLL(string userId, string userName, DateTime datetime, string email,string sdt,string diaChi,string userRole) {
            data.UpdateInfomationUserDAL(userId,userName, datetime, email, sdt, diaChi, userRole);
        }
        public int TonTaiMatKhau(string id,string txtmatkhaucu) {
            return data.TonTaiMatKhauDAL(id, txtmatkhaucu);
        }
        public void UpdatePassword(string id,string txtmatkhaumoi) {
            data.UpdatePasswordDAL(id, txtmatkhaumoi);
        }
    }
}
