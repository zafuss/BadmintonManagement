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

        //lấy tất cả user từ db
        public static List<C_USER> GetAllUser()
        {
            return context.C_USER.ToList();
        }

        //lấy user từ db bằng username
        public static C_USER GetUser(string username)
        {

            return context.C_USER.FirstOrDefault(x => x.Username == username);
        }

        //lấy user từ db bằng email
        public static C_USER GetUserByEmail(string email)
        {

            return context.C_USER.FirstOrDefault(x => x.Email == email);
        }

        //kiểm tra username truyền vào đã tồn tại ở một user khác trong csdl hay chưa
        public static bool IS_UsernameExist(string username)
        {
            return context.C_USER.Any(x => x.Username == username);
        }

        //kiểm tra email trueyefn vào đã tồn tại ở một user khác trong csdl hay chưa
        public static bool IS_EmailExist(string email)
        {
            return context.C_USER.Any(x => x.Email == email);
        }

        //kiểm tra số điện thoại truyền vào đã tồn tại ở một user khác trong csdl hay chưa
        public static bool IS_PhoneNumberExist(string phoneNumber)
        {
            return context.C_USER.Any(x => x.PhoneNumber == phoneNumber);
        }

        //thêm user vào db
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

        //chỉnh sửa user
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
            if (isPasswordChanged)
                user.C_Password = password;
            context.C_USER.AddOrUpdate(user);
            context.SaveChanges();
            OTPService.SendChangedInformationMail(user.Email, newPassword);
        }

        //vô hiệu hoá user
        public static void DisableUser(string username)
        {
            if (username == "admin")
                throw new Exception("Không thể vô hiệu hoá admin");
            C_USER tmpUser = GetUser(username);
            if (tmpUser.C_Status == "Enabled")
                tmpUser.C_Status = "Disabled";
            else tmpUser.C_Status = "Enabled";
            context.C_USER.AddOrUpdate(tmpUser);
            context.SaveChanges();
            OTPService.SendDisabledMail(tmpUser.Email);
        }

        //kích hoạt user
        public static void EnableUser(C_USER user)
        {
            C_USER tmpUser = GetUser(user.Username);
            tmpUser.C_Status = "Enabled";
            context.C_USER.AddOrUpdate(tmpUser);
            context.SaveChanges();
        }


        //lưu user đã đăng nhập vào app properties
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

        //xoá thông tin user đã đăng nhập tại app properties
        public static void DeleteCurrentUser()
        {

            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Email = "";
            Properties.Settings.Default.PhoneNumber = "";
            Properties.Settings.Default.Role = "";
            Properties.Settings.Default._Name = "";
            Properties.Settings.Default.Save();
        }


        // đăng nhập tài khoản
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

        // đăng xuất tài khoản
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
