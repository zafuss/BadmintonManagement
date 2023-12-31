﻿using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        
        //sự kiện xảy ra khi nhấn quên mật khẩu
        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm form = new ForgotPasswordForm(); 
            form.Show();  
        }

        //sự kiện xảy ra khi nhấn vào nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "Username" || txtPassword.Text == "Password")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");

                UserServices.LoginUser(txtUser.Text, txtPassword.Text);
                //FirebaseHelper.LoginUser(txtUser.Text, txtPassword.Text);
                HomePage homePage = new HomePage();
                this.Hide();
                homePage.Show();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

       
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.ForeColor = Color.Black;
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.ForeColor = Color.DarkGray;
                txtUser.Text = "Username";
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.PasswordChar = '●';
                txtPassword.ForeColor = Color.Black;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.Text = "Password";
            }
        }

        private void picShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            picShowPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
            picShowPassword.Image = Properties.Resources.hidden_password;
            if (txtPassword.Text == "Password")
                txtPassword.PasswordChar = '\0';
        }

        //sự kiện xayr a khi nhấn nút thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }


        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
