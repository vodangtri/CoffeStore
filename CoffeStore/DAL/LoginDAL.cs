using CoffeStore.DTO;

namespace CoffeStore.DAL
{
    internal class LoginDAL: DatabaseAccess
    {
        // Kiểm tra dữ liệu đăng nhập dựa trên thông tin tài khoản (User)
        public string checkLoginData_Login_DAL(User tk)
        {
            return checkLoginData_DA_DAL(tk);
        }
        public string checkUsername_DAL(User tk)
        {
            return checkUsername_DA_DAL(tk);
        }
    }
}
