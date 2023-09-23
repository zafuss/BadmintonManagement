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

namespace BadmintonManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPassword.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                FirebaseHelper.LoginUser(txtUser.Text, txtPassword.Text);   
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
                
        }
    }
}
