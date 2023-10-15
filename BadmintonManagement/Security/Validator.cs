using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BadmintonManagement.Models;

namespace BadmintonManagement
{
    public class Validator
    {
        public static string usernamePattern = @"^[a-z0-9_-]{3,15}$";
        public static string passwordPattern = @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20}";
        public static string emailPattern = @"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
        public static string phoneNumberPattern = @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
        public static string customernamPatten = @"[@#$%^~&`|'""{}\[\]\-\\_\\()!*+=?.,><:;//]";
        public static void UserValidator(C_USER user) {
            if (!Regex.IsMatch(user.Username, usernamePattern))
                throw new Exception("Tên đăng nhập không hợp lệ!");
            if (!Regex.IsMatch(user.Email, emailPattern))
                throw new Exception("Email không hợp lệ");
            if (!Regex.IsMatch(user.PhoneNumber, phoneNumberPattern))
                throw new Exception("Số điện thoại không hợp lệ");
        }

        public static void CustomerValidator(CUSTOMER customer)
        {
            if (Regex.IsMatch(customer.FullName, customernamPatten))
                throw new Exception("Tên đăng nhập không hợp lệ!");
            if (!Regex.IsMatch(customer.Email, emailPattern))
                throw new Exception("Email không hợp lệ");
            if (!Regex.IsMatch(customer.PhoneNumber, phoneNumberPattern))
                throw new Exception("Số điện thoại không hợp lệ");
        }

        public static void ResetPasswordValidator(string newPass, string confirmNewPass)
        {
            if (!Regex.IsMatch(newPass, passwordPattern)) 
                throw new Exception("Mật khẩu không hợp lệ!");
            if (confirmNewPass != newPass) 
                throw new Exception("Mật khẩu không trùng khớp");
        }
    }
}
