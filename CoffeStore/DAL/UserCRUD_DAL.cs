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
    }
}
