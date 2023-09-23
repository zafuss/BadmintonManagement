using BadmintonManagement.Models;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public static void LoginUser(string username, string password)
        {
            try
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
                                MessageBox.Show("Welcome " + username);
                                isSuccess = true;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");

            }

        }
    }
}
