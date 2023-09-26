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
    public partial class ResetPasswordForm : Form
    {
        C_User user;
        string currentEmail;
        public ResetPasswordForm(C_User user, string currentEmail)
            
        {
            this.currentEmail = currentEmail;
            this.user = user;
            InitializeComponent();
        }

        private void btnEnterOTP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text == "" || txtConfirmNewPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                Validator.ResetPasswordValidator(txtNewPassword.Text, txtConfirmNewPassword.Text);
                user.C_Password = txtNewPassword.Text;
                UserServices.UpdateUser(user, currentEmail);
                Close();
                MessageBox.Show("Thay đổi mật khẩu thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }

        }
    }
}
