using CoffeStore.DAL;

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
            data.ChangePassword_DAL(username,newPassword);
        }
    }
}
