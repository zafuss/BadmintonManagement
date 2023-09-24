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
                if (txtUser.Text == "Username" || txtPassword.Text == "Password")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                FirebaseHelper.LoginUser(txtUser.Text, txtPassword.Text);   
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
                
        }

        // Change text in textbox  
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "Username")
            {
                txtUser.ForeColor = Color.Black;
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if( txtUser.Text == "")
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
            picShowPassword.Image = Properties.Resources.hidden_password;

        }

        private void picShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.PasswordChar = '●';
            picShowPassword.Image = Properties.Resources.visibale_password;
            if (txtPassword.Text == "Password")
                txtPassword.PasswordChar = '\0';
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
