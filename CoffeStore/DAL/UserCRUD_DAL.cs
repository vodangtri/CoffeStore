using CoffeStore.DTO;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CoffeStore.DAL
{

    internal class UserCRUD_DAL: DatabaseAccess
    {
        public string getIdByUsername_DAL(string name)
        {
            return getIdByUsername_DA_DAL(name);
        }
        public string getNameNVById_DAL( string IdNhanvien)
        {
            return getNameNVById_DA_DAL(IdNhanvien);
        }
        public void ChangePassword_DAL(string username, string newPassword)
        {
            ChangePassword_DA_DAL(username, newPassword);
        }
        public string LayHoTenDAL(string id)
        {
            return LayHoTenDA_DAL(id);
        }
        public string LayNgaySinhDAL(string id) {
            return LayNgaySinhDA_DAL(id);
        }
        public string LayEmailDAL(string id) {
            return LayEmailDA_DAL(id);
        }
        public string LayPhoneNumberDAL(string id) {
            return LayPhoneNumberDA_DAL(id);
        }
        public string LayDiaChiDAL(string id)
        {
            return LayDiaChiDA_DAL(id);
        }
        public string LayUserRoleDAL(string id) {
            return LayUserRoleDA_DAL(id);
        }
        public void UpdateInfomationUserDAL(string userId,string userName, DateTime datetime,string email,string sdt,string diaChi,string userRole)
        {
            UpdateInfomationUserDA_DAL(userId, userName, datetime, email, sdt, diaChi, userRole);
        }
        public int TonTaiMatKhauDAL(string id,string txtmatkhaucu) {
            return TonTaiMatKhauDA_DAL(id,txtmatkhaucu);
        }
        public void UpdatePasswordDAL(string id, string txtmatkhaumoi) {
            UpdatePasswordDA_DAL(id, txtmatkhaumoi);
        }
    }
}
