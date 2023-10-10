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
    public partial class AccountCenterForm : Form
    {
        public AccountCenterForm()
        {
            InitializeComponent();
            panel3.Enabled = false;
            LoadData();
        }

        private void LoadData()
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtName.Text = Properties.Settings.Default._Name;
            txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
            txtRole.Text = Properties.Settings.Default.Role;
            txtEmail.Text = Properties.Settings.Default.Email;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxChangePassword.Checked)
            {
                panel3.Enabled = true;
            }
            else
            {
                panel3.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                C_USER tmpUser = UserServices.GetUser(txtUsername.Text);
                if (txtCurrentPassword.Text == "" || txtNewPassword.Text == "" || txtRepeatCurrentPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (tmpUser.C_Password != Security.Encrypt(txtCurrentPassword.Text))
                    throw new Exception("Mật khẩu hiện tại không đúng!");
                Validator.ResetPasswordValidator(txtNewPassword.Text, txtRepeatCurrentPassword.Text);
                tmpUser.C_Password = txtNewPassword.Text;
                UserServices.UpdateUser(tmpUser, tmpUser.Email, null, null);
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
