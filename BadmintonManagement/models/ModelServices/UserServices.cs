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

        public static List<C_USER> GetAllUser()
        {
            return context.C_USER.ToList();
        }

        public static C_USER GetUser(string username)
        {

            return context.C_USER.FirstOrDefault(x => x.Username == username);
        }
        public static C_USER GetUserByEmail(string email)
        {

            return context.C_USER.FirstOrDefault(x => x.Email == email);
        }

        public static bool IS_UsernameExist(string username)
        {
            return context.C_USER.Any(x => x.Username == username);
        }
        public static bool IS_EmailExist(string email)
        {
            return context.C_USER.Any(x => x.Email == email);
        }
        public static bool IS_PhoneNumberExist(string phoneNumber)
        {
            return context.C_USER.Any(x => x.PhoneNumber == phoneNumber);
        }
        public static void AddUser(C_USER user, Action bindGrid)
        {
            try
            {

                Validator.UserValidator(user);
                string passBeforeEncrypt = user.C_Password;
                string password = Security.Encrypt(user.C_Password);
                user.C_Password = password;

                if (IS_PhoneNumberExist(user.PhoneNumber))
                {
                    throw new Exception("Số điện thoại này đã tồn tại trong hệ thống");
                }
                if (IS_UsernameExist(user.Username))
                {
                    throw new Exception("User đã tồn tại trong hệ thống");
                }
                if (IS_EmailExist(user.Email))
                {
                    throw new Exception("Email đã tồn tại trong hệ thống");
                }
                OTPService.SendFirstEmail(user, passBeforeEncrypt, () =>
                {
                    // Hàm callback này được gọi khi SendActiveOTP đã hoàn thành.
                    context.C_USER.AddOrUpdate(user);
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

        public static void UpdateUser(C_USER user, string currentEmail, string currentUsername, string currentPhoneNumber, bool isPasswordChanged)
        {
            string newPassword = null;
            if (isPasswordChanged)
                newPassword = user.C_Password.ToString();
            if (currentUsername != null)
                if (currentUsername != user.Username)
                    throw new Exception("Không thể thay đổi username!");
            Validator.UserValidator(user);
            if (currentPhoneNumber != null)
                if (IS_PhoneNumberExist(user.PhoneNumber) && user.PhoneNumber != currentPhoneNumber)
                {
                    throw new Exception("Số điện thoại này đã tồn tại trong hệ thống");
                }
            if (IS_EmailExist(user.Email) && user.Email != currentEmail)
            {
                throw new Exception("Email đã tồn tại trong hệ thống");
            }
            var password = Security.Encrypt(user.C_Password);
            user.C_Password = password;
            context.C_USER.AddOrUpdate(user);
            context.SaveChanges();
            OTPService.SendChangedInformationMail(user.Email, newPassword);
        }

        public static void DisableUser(string username)
        {
            C_USER tmpUser = GetUser(username);
            if (tmpUser.C_Status == "Enabled")
                tmpUser.C_Status = "Disabled";
            else tmpUser.C_Status = "Enabled";
            context.C_USER.AddOrUpdate(tmpUser);
            context.SaveChanges();
            OTPService.SendDisabledMail(tmpUser.Email);
        }
        public static void EnableUser(C_USER user)
        {
            C_USER tmpUser = GetUser(user.Username);
            tmpUser.C_Status = "Enabled";
            context.C_USER.AddOrUpdate(tmpUser);
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
                    Properties.Settings.Default.Save();
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
            Properties.Settings.Default.Save();
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
                    if (username == usernameres && Security.Encrypt(password) == passwordres)
                    {
                        if (get.C_Status == "Disabled") throw new Exception("Tài khoản đã bị vô hiệu hoá, vui lòng liên hệ admin để biết thêm chi tiết");
                        isSuccess = true;
                        SaveCurrentUser(username);
                    }
                }
                if (!isSuccess) throw new Exception("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        public static void LogoutUser()
        {
            DeleteCurrentUser();
            LoginForm loginForm = new LoginForm();
            foreach (Form form in Application.OpenForms)
            {
                form.Hide();
            };
            loginForm.Show();
        }
    }
}
