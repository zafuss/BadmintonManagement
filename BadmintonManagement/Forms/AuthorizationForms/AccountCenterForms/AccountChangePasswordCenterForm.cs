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
    public partial class AccountChangePasswordCenterForm : Form
    {
        public AccountChangePasswordCenterForm()
        {
            InitializeComponent();
        }

        private void txtCurrentPassword_Enter(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == "Mật khẩu hiện tại")
            {
                txtCurrentPassword.PasswordChar = '●';
                txtCurrentPassword.ForeColor = Color.Black;
                txtCurrentPassword.Text = "";
            }
        }

        private void txtCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text == "")
            {
                txtCurrentPassword.PasswordChar = '\0';
                txtCurrentPassword.ForeColor = Color.DarkGray;
                txtCurrentPassword.Text = "Mật khẩu hiện tại";
            }
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


        private void picShowCurrentPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtCurrentPassword.PasswordChar = '\0';
            picShowCurrentPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowCurrentPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtCurrentPassword.PasswordChar = '●';
            picShowCurrentPassword.Image = Properties.Resources.hidden_password;
            if (txtCurrentPassword.Text == "Mật khẩu hiện tại")
                txtCurrentPassword.PasswordChar = '\0';
        }
        private void picShowNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
            picShowNewPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtNewPassword.PasswordChar = '●';
            picShowNewPassword.Image = Properties.Resources.hidden_password;
            if (txtNewPassword.Text == "Mật khẩu mới")
                txtNewPassword.PasswordChar = '\0';
        }

        private void picShowConfirmNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            txtConfirmNewPassword.PasswordChar = '\0';
            picShowConfirmNewPassword.Image = Properties.Resources.visibale_password;

        }

        private void picShowConfirmNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtConfirmNewPassword.PasswordChar = '●';
            picShowConfirmNewPassword.Image = Properties.Resources.hidden_password;
            if (txtNewPassword.Text == "Nhập lại mật khẩu mới")
                txtNewPassword.PasswordChar = '\0';
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                C_USER tmpUser = UserServices.GetUser(Properties.Settings.Default.Username);
                if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (tmpUser.C_Password != Security.Encrypt(txtCurrentPassword.Text))
                    throw new Exception("Mật khẩu hiện tại không đúng!");
                Validator.ResetPasswordValidator(txtNewPassword.Text, txtConfirmNewPassword.Text);
                tmpUser.C_Password = txtNewPassword.Text;
                UserServices.UpdateUser(tmpUser, tmpUser.Email, null, null, true);
                MessageBox.Show("Cập nhật mật khẩu thành công!\nVui lòng đăng nhập lại!", "Thông báo");
                UserServices.LogoutUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
