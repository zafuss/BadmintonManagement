﻿using BadmintonManagement.Database;
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
    public partial class ResetPasswordForm : Form
    {
        C_USER user;
        string currentEmail;
        public ResetPasswordForm(C_USER user, string currentEmail)

        {
            this.currentEmail = currentEmail;
            this.user = user;
            InitializeComponent();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "Mật khẩu mới")
            {
                txtNewPassword.PasswordChar = '●';
                txtNewPassword.ForeColor = Color.Black;
                txtNewPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == "")
            {
                txtNewPassword.PasswordChar = '\0';
                txtNewPassword.ForeColor = Color.DarkGray;
                txtNewPassword.Text = "Mật khẩu mới";
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (txtConfirmNewPassword.Text == "Nhập lại mật khẩu mới")
            {
                txtConfirmNewPassword.PasswordChar = '●';
                txtConfirmNewPassword.ForeColor = Color.Black;
                txtConfirmNewPassword.Text = "";
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (txtConfirmNewPassword.Text == "")
            {
                txtConfirmNewPassword.PasswordChar = '\0';
                txtConfirmNewPassword.ForeColor = Color.DarkGray;
                txtConfirmNewPassword.Text = "Nhập lại mật khẩu mới";
            }
        }


        private void picShowNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            picShowPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
            picShowPassword.Image = Properties.Resources.hidden_password;
            if (txtNewPassword.Text == "New Password")
                txtNewPassword.PasswordChar = '\0';
        }

        private void picShowConfirmNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmNewPassword.PasswordChar = '\0';
            picShowPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowConfirmNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmNewPassword.PasswordChar = '●';
            picShowPassword.Image = Properties.Resources.hidden_password;
            if (txtNewPassword.Text == "Confirm New Password")
                txtNewPassword.PasswordChar = '\0';
        }


        private void btnEnterOTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                Validator.ResetPasswordValidator(txtNewPassword.Text, txtConfirmNewPassword.Text);
                user.C_Password = txtNewPassword.Text;
                UserServices.UpdateUser(user, currentEmail, null, null, false);
                Close();
                MessageBox.Show("Thay đổi mật khẩu thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
