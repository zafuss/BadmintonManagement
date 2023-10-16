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
        // pattern để kiểm tra username
        public static string usernamePattern = @"^[a-z0-9_-]{3,15}$";
        // pattern để kiểm tra password
        public static string passwordPattern = @"(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20}";
        // pattern để kiểm tra email
        public static string emailPattern = @"^[_A-Za-z0-9-\\+]+(\\.[_A-Za-z0-9-]+)*@" + "[A-Za-z0-9-]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$";
        // pattern để kiểm tra phoneNumber
        public static string phoneNumberPattern = @"^(0?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])[0-9]{7}$";
        // pattern để kiểm tra tên khách hàng 
        public static string customerNamePattern = @"[@#$%^~&`|'""{}\[\]\-\\_\\()!*+=?.,><:;//]";

        // hàm kiểm tra tính hợp lệ của user
        public static void UserValidator(C_USER user)
        {
            if (!Regex.IsMatch(user.Username, usernamePattern))
                throw new Exception("Tên đăng nhập không hợp lệ!");
            if (!Regex.IsMatch(user.Email, emailPattern))
                throw new Exception("Email không hợp lệ");
            if (!Regex.IsMatch(user.PhoneNumber, phoneNumberPattern))
                throw new Exception("Số điện thoại không hợp lệ");
        }

        // hàm kiểm tra tính hợp lệ của khách hàng
        public static void CustomerValidator(CUSTOMER customer)
        {
            if (Regex.IsMatch(customer.FullName, customerNamePattern))
                throw new Exception("Tên đăng nhập không hợp lệ!");
            if (!Regex.IsMatch(customer.Email, emailPattern))
                throw new Exception("Email không hợp lệ");
            if (!Regex.IsMatch(customer.PhoneNumber, phoneNumberPattern))
                throw new Exception("Số điện thoại không hợp lệ");
        }

        // hàm kiểm tra tính hợp lệ của password
        public static void ResetPasswordValidator(string newPass, string confirmNewPass)
        {
            if (!Regex.IsMatch(newPass, passwordPattern))
                throw new Exception("Mật khẩu không hợp lệ!");
            if (confirmNewPass != newPass)
                throw new Exception("Mật khẩu không trùng khớp");
        }
    }
}
