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
        string selectedPhoneNumber = "";
        List<C_USER> userList;
        public ManageUser()
        {
            InitializeComponent();
            btnDelUser.Enabled = false;
        }

        private void refreshTextBox()
        {
            txtName.Text = txtRegEmail.Text = txtRegPassword.Text = txtRegPhoneNumber.Text = txtRegRepeatPass.Text = txtRegUsername.Text = "";
        }

        private void BindGrid()
        {
            dgvUsers.Rows.Clear();
            //userList = FirebaseHelper.UserList();
            userList = UserServices.GetAllUser();
            foreach (var item in userList)
            {
                int index = dgvUsers.Rows.Add();
                dgvUsers.Rows[index].Cells[0].Value = item.Username;
                dgvUsers.Rows[index].Cells[1].Value = item.C_Name;
                dgvUsers.Rows[index].Cells[2].Value = item.Email;
                dgvUsers.Rows[index].Cells[3].Value = item.PhoneNumber;
                dgvUsers.Rows[index].Cells[4].Value = item.C_Role;
                dgvUsers.Rows[index].Cells[5].Value = item.C_Status == "Enabled" ? "Kích hoạt" : "Vô hiệu hoá";


            }
            refreshTextBox();
        }

        private async void  btnReg_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegUsername.Text == "" || txtRegPassword.Text == "" || txtRegPhoneNumber.Text == "" || txtRegEmail.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (txtRegPassword.Text != txtRegRepeatPass.Text)
                    throw new Exception("Mật khẩu không trùng khớp!");
                C_USER user = new C_USER()
                {
                    Username = txtRegUsername.Text,
                    C_Name = txtName.Text,
                    C_Password = txtRegPassword.Text,
                    PhoneNumber = txtRegPhoneNumber.Text,
                    Email = txtRegEmail.Text,
                    C_Role = "Staff",
                    C_Status = "Enabled"

                };
                //FirebaseHelper.RegisterUser(user);
                UserServices.AddUser(user, () => BindGrid());
                
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
                txtName.Text = dgvUsers.Rows[selectedRow].Cells[1].Value.ToString();
                txtRegEmail.Text = dgvUsers.Rows[selectedRow].Cells[2].Value.ToString();
                txtRegPhoneNumber.Text = dgvUsers.Rows[selectedRow].Cells[3].Value.ToString();
                txtRegPassword.Text = "";
                txtRegRepeatPass.Text = "";
                selectedUsername = txtRegUsername.Text;
                selectedEmail = txtRegEmail.Text;
                selectedRole = dgvUsers.Rows[selectedRow].Cells[4].Value.ToString();
                selectedPhoneNumber = txtRegPhoneNumber.Text;
                btnDelUser.Enabled = true;
                if (dgvUsers.Rows[selectedRow].Cells[5].Value.ToString() == "Vô hiệu hoá")
                    btnDelUser.Text = "Kích hoạt";
                else
                    btnDelUser.Text = "Vô hiệu hoá";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRegUsername.Text == "" || txtRegPassword.Text == "" || txtRegPhoneNumber.Text == "" || txtRegEmail.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                if (txtRegUsername.Text != selectedUsername)
                    throw new Exception("Không thể thay đổi username!");
                if (txtRegPassword.Text != txtRegRepeatPass.Text)
                    throw new Exception("Mật khẩu không trùng khớp!");
                C_USER user = new C_USER()
                {
                    Username = txtRegUsername.Text,
                    C_Password = txtRegPassword.Text,
                    PhoneNumber = txtRegPhoneNumber.Text,
                    C_Name = txtName.Text,  
                    Email = txtRegEmail.Text,
                    C_Role = selectedRole,
                    C_Status = "Enabled"

                };
                //FirebaseHelper.UpdateUser(user, selectedUsername, selectedEmail);
                UserServices.UpdateUser(user, selectedEmail, selectedUsername, selectedPhoneNumber);
                MessageBox.Show("Cập nhật user thành công!", "Thông báo");
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
                //FirebaseHelper.DeleteUser(selectedUsername);
                UserServices.DisableUser(selectedUsername);
                MessageBox.Show("Thay đổi trạng thái user thành công!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvUsers.CurrentCell = null;

            foreach (DataGridViewRow row in dgvUsers.Rows)
            {
                if (row.Cells["clnName"].Value != null)
                {
                    if (row.Cells["clnName"].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        row.Visible = true;
                        row.Selected = false;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtSearch);
            double width = (panel2.Width);
            double height = (panel2.Height)/4;

            Label label = new Label();
            label.Location = new Point(0, Convert.ToInt32(height));
            label.Size = new Size(Convert.ToInt32(width),50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Danh Sách Tài Khoản";
            label.Font = new Font("Segoe UI",24 ,FontStyle.Bold );

            panel2.Controls.Add(label); 
        }
    }
}
