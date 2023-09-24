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
    public partial class ManageUser : Form
    {
        string selectedUsername = "";
        string selectedEmail = "";
        string selectedRole = "";
        List<User> userList;
        public ManageUser()
        {
            InitializeComponent();

        }

        private void BindGrid()
        {
            dgvUsers.Rows.Clear();
            userList = FirebaseHelper.UserList();
            foreach (var item in userList)
            {
                int index = dgvUsers.Rows.Add();
                dgvUsers.Rows[index].Cells[0].Value = item.Username;
                dgvUsers.Rows[index].Cells[1].Value = item.Email;
                dgvUsers.Rows[index].Cells[2].Value = item.PhoneNumber;
                dgvUsers.Rows[index].Cells[3].Value = item.Role;


            }
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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selectedRow = e.RowIndex;
                txtRegUsername.Text = dgvUsers.Rows[selectedRow].Cells[0].Value.ToString();
                txtRegEmail.Text = dgvUsers.Rows[selectedRow].Cells[1].Value.ToString();
                txtRegPhoneNumber.Text = dgvUsers.Rows[selectedRow].Cells[2].Value.ToString();
                selectedUsername = txtRegUsername.Text;
                selectedEmail = txtRegEmail.Text;
                selectedRole = dgvUsers.Rows[selectedRow].Cells[3].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                    Role = selectedRole,

                };
                FirebaseHelper.UpdateUser(user, selectedUsername, selectedEmail);
       
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            try
            {
                FirebaseHelper.DeleteUser(selectedUsername);
                MessageBox.Show("Xoá user thành công!");
                BindGrid();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }
    }
}
