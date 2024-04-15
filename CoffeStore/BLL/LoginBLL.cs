using CoffeStore.DAL;
using CoffeStore.DTO;

namespace CoffeStore.BLL
{
    internal class LoginBLL
    {
        LoginDAL loginDAL = new LoginDAL();

        // Kiểm tra tính hợp lệ của email
        public bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();
            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        public string checkLoginData_Login_BLL(User tk)
        {
            if (tk.UserName == "" || tk.UserName == "Tên đăng nhập")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            else if (tk.UserPassword == "" || tk.UserPassword == "Mật khẩu")
            {
                return "Vui lòng nhập mật khẩu";
            }
            return loginDAL.checkLoginData_Login_DAL(tk);
        }
        public string checkUsername_BLL(User tk)
        {
            if (tk.UserName == "" || tk.UserName == "Tên đăng nhập")
            {
                return "Vui lòng nhập tên tài khoản";
            }
            return loginDAL.checkUsername_DAL(tk);
        }
    }
}
