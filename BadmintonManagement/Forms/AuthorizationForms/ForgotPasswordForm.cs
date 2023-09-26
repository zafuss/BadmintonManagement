using BadmintonManagement.Database;
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
    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
        
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (!UserServices.IS_EmailExist(txtEmail.Text))
                lblError.Text = "Email không tồn tại!";
            else
            {
                lblError.Text = "";
                OTPService.SendForgotPasswordOTP(txtEmail.Text);
                this.Close();
            }
        }
    }
}
