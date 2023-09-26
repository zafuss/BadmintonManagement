using BadmintonManagement.Models;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    public class UserServices

    {
        static ModelBadmintonManage context = new ModelBadmintonManage();

        public static List<C_User> GetAllUser()
        {
            return context.C_User.ToList();
        }

        public static C_User GetUser(string username)
        {

            return context.C_User.FirstOrDefault(x => x.Username == username);
        }
        public static C_User GetUserByEmail(string email)
        {

            return context.C_User.FirstOrDefault(x => x.Email == email);
        }

        public static bool IS_UsernameExist(string username)
        {
            return context.C_User.Any(x => x.Username == username);
        }
        public static bool IS_EmailExist(string email)
        {
            return context.C_User.Any(x => x.Email == email);
        }
        public static void CreateAdminAccount()
        {
            C_User user = new C_User()
            {
                Username = "admin",
                C_Password = Security.Encrypt("admin"),
                C_Name = "admin",
                Email = "email",
                PhoneNumber = "1234567890",
                C_Role = "Admin",
                Status = "Kích hoạt"


            };
            C_User tmp = GetUser(user.Username);
            if (tmp == null)
            {

                context.C_User.AddOrUpdate(user);
                context.SaveChanges();
            }


        }
        public static void AddUser(C_User user, Action bindGrid)
        {
            try
            {

                Validator.UserValidator(user);
                string password = Security.Encrypt(user.C_Password);
                user.C_Password = password;
                if (IS_UsernameExist(user.Username))
                {
                    throw new Exception("User đã tồn tại trong hệ thống");
                }
                if (IS_UsernameExist(user.Email))
                {
                    throw new Exception("Email đã tồn tại trong hệ thống");
                }
                OTPService.SendActiveOTP(user.Email, () =>
                {
                    // Hàm callback này được gọi khi SendActiveOTP đã hoàn thành.
                    context.C_User.AddOrUpdate(user);
                    context.SaveChanges();
                    MessageBox.Show("Thêm user thành công!", "Thông báo");

                    bindGrid();
                });


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        public static void UpdateUser(C_User user, string currentEmail)
        {
            Validator.UserValidator(user);
            if (IS_UsernameExist(user.Email) && user.Email != currentEmail)
            {
                throw new Exception("Email đã tồn tại trong hệ thống");
            }
            var password = Security.Encrypt(user.C_Password);
            user.C_Password = password;
            context.C_User.AddOrUpdate(user);
            context.SaveChanges();
        }

        public static void DisableUser(string username)
        {
            C_User tmpUser = GetUser(username);
            if (tmpUser.Status == "Kích hoạt")
                tmpUser.Status = "Vô hiệu hoá";
            else tmpUser.Status = "Kích hoạt";
            context.C_User.AddOrUpdate(tmpUser);
            context.SaveChanges();
        }
        public static void EnableUser(C_User user)
        {
            C_User tmpUser = GetUser(user.Username);
            tmpUser.Status = "Kích hoạt";
            context.C_User.AddOrUpdate(tmpUser);
            context.SaveChanges();
        }

        private static void SaveCurrentUser(string username)
        {
            var userList = GetAllUser();
            foreach (var item in userList)
            {
                if (username == item.Username)
                {
                    Properties.Settings.Default.Username = item.Username;
                    Properties.Settings.Default.Email = item.Email;
                    Properties.Settings.Default.PhoneNumber = item.PhoneNumber;
                    Properties.Settings.Default.Role = item.C_Role;
                    Properties.Settings.Default._Name = item.C_Name;

                }
            }
        }
        public static void DeleteCurrentUser()
        {

            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Email = "";
            Properties.Settings.Default.PhoneNumber = "";
            Properties.Settings.Default.Role = "";
            Properties.Settings.Default._Name = "";
        }

        public static void LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Fields cannot be empty!");
            }
            else
            {
                var userList = GetAllUser();
                bool isSuccess = false;
                foreach (var get in userList)
                {
                    string usernameres = get.Username;
                    string passwordres = get.C_Password;
                    if (username == usernameres || Security.Encrypt(password) == passwordres)
                    {
                        isSuccess = true;
                        SaveCurrentUser(username);
                    }
                }
                if (!isSuccess) throw new Exception("Sai tên tài khoản hoặc mật khẩu");
            }
        }
    }
}
