using BadmintonManagement.Forms.AuthorizationForms;
using BadmintonManagement.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Database
{
    public class FirebaseHelper
    {

        public FirebaseHelper() { }

        public static FirebaseHelper Instance { get { return new FirebaseHelper(); } }
        static IFirebaseClient client;
        static IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "3RfGHjl0WstKaBxz97OBNu1ZNzVSwO6fasOHiHvb",
            BasePath = "https://badmintonmanagement-default-rtdb.firebaseio.com/"
        };

        public static void FirebaseInit()
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check your connection!");
            }
        }

        public static List<User> UserList()
        {
            List<User> users = new List<User>();
            FirebaseResponse response = client.Get("Users/");
            Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
            if (result != null)
                foreach (var get in result)
                {
                    User user = new User()
                    {
                        Username = get.Value.Username,
                        Password = get.Value.Password,
                        Email = get.Value.Email,
                        PhoneNumber = get.Value.PhoneNumber,
                        Role = get.Value.Role,

                    };
                    users.Add(user);

                }
            return users;
        }

        public static void RegisterUser(User user)
        {
            try
            {
                if (user is null)
                {
                    throw new ArgumentNullException(nameof(user));
                }
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
                if (result != null)
                    foreach (var get in result)
                    {
                        string usernameres = get.Value.Username;

                        if (user.Username == usernameres)
                            throw new Exception("User này đã tồn tại trong hệ thống!");

                    }

                FirebaseResponse regResponse = client.Set("Users/" + user.Username, user);
                User res = regResponse.ResultAs<User>();


                MessageBox.Show("Đăng ký thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
        public static void UpdateUser(User user, string selectedUsername, string selectedEmail)
        {
            try
            {
                if (user is null)
                {
                    throw new ArgumentNullException(nameof(user));
                }
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
                if (result != null)
                    foreach (var get in result)
                    {
                        string usernameres = get.Value.Username;
                        string useremailres = get.Value.Email;
                        if (user.Username == usernameres && user.Username != selectedUsername)
                            throw new Exception("Username này đã tồn tại trong hệ thống!");
                        if (user.Email == useremailres && user.Email != selectedEmail)
                            throw new Exception("Email này đã tồn tại trong hệ thống!");

                    }

                FirebaseResponse regResponse = client.Update("Users/" + user.Username, user);
                User res = regResponse.ResultAs<User>();


                MessageBox.Show("Cập nhật thông tin user thành công!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private static void SaveCurrentUser(string username)
        {
            var userList = UserList();
            foreach (var item in userList)
            {
                if (username == item.Username)
                {
                    Properties.Settings.Default.Username = item.Username;
                    Properties.Settings.Default.Email = item.Email;
                    Properties.Settings.Default.PhoneNumber = item.PhoneNumber;
                    Properties.Settings.Default.Role = item.Role;
                }
            }
        }


        public static void LoginUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Fields cannot be empty!");
            }
            else
            {
                bool isSuccess = false;
                FirebaseResponse response = client.Get("Users/");

                Dictionary<string, User> result = response.ResultAs<Dictionary<string, User>>();
                if (result != null)
                {

                    foreach (var get in result)
                    {
                        string usernameres = get.Value.Username;
                        string passwordres = get.Value.Password;
                        if (username == usernameres || password == passwordres)
                        {
                            //MessageBox.Show("Welcome " + username);

                            isSuccess = true;
                            SaveCurrentUser(username);

                        }


                    }
                    if (!isSuccess) throw new Exception("Sai tên tài khoản hoặc mật khẩu");
                }

                else
                {
                    throw new Exception("Không tìm thấy user");
                }
            }

        }

        public static void DeleteUser(string username)
        {
            try
            {
                FirebaseResponse response = client.Delete("Users/" + username);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Thông báo");
            }
        }
    }
}
