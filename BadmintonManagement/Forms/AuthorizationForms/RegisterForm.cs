using BadmintonManagement.Database;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.AuthorizationForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegUsername.Text == "" || txtRegPassword.Text == "" || txtRegPhoneNumber.Text == "" || txtRegEmail.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                User user = new User()
                {
                    Username = txtRegUsername.Text,
                    Password = txtRegPassword.Text,
                    PhoneNumber = txtRegPhoneNumber.Text,
                    Email = txtRegEmail.Text,
                    Role = "Staff"

                };
                FirebaseHelper.RegisterUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void lblBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
