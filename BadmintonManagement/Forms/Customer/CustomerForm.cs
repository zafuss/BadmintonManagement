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
using System.Xml.Linq;

namespace BadmintonManagement.Forms.Customer
{
    public partial class CustomerForm : Form
    {
        
        public int index;
        ModelBadmintonManage context = new ModelBadmintonManage();
        public CustomerForm()
        {
            InitializeComponent();
            
        }
        private void BindDataGrid(List<CUSTOMER> customers)
        {
            dgvCustomer.Rows.Clear();
            foreach(var item in customers)
            {
                int row = dgvCustomer.Rows.Add();
                dgvCustomer.Rows[row].Cells[0].Value = item.PhoneNumber;
                dgvCustomer.Rows[row].Cells[1].Value = item.FullName;
                dgvCustomer.Rows[row].Cells[2].Value = item.Email;

            }
        }
        private void CustomerForm_Load_1(object sender, EventArgs e)
        {
            List<CUSTOMER> cUSTOMERs = context.CUSTOMER.ToList();
            BindDataGrid(cUSTOMERs);
        }
        
        public void InsertCustomerToDB()
        {
            CUSTOMER c = new CUSTOMER();
            c.PhoneNumber = txtPhoneNumber.Text;
            c.FullName = txtFullName.Text;
            c.Email = txtEmail.Text;
            MessageBox.Show("Thêm khách hàng thành công !", "Thông báo", MessageBoxButtons.OK);
            context.CUSTOMER.Add(c);
            context.SaveChanges();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPhoneNumber.Text == " " || txtFullName.Text == " " || txtEmail.Text == " ")
                    throw new Exception("Vui lòng nhập đủ thông tin !");
                dgvCustomer.Rows.Add(txtPhoneNumber.Text, txtFullName.Text, txtEmail.Text);
                InsertCustomerToDB();
                txtPhoneNumber.Text = string.Empty; 
                txtFullName.Text = string.Empty;
                txtEmail.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveCustomerToDB()
        {
            CUSTOMER cUSTOMER = context.CUSTOMER.FirstOrDefault(p => p.PhoneNumber == txtPhoneNumber.Text);
            if(cUSTOMER != null)
            {
                context.CUSTOMER.Remove(cUSTOMER);    
                context.SaveChanges();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow dataGridViewRow in dgvCustomer.SelectedRows)
            {
                DialogResult dr = MessageBox.Show("Xác nhận xóa khách hàng này?", "YES/NO", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes) 
                { 
                    dgvCustomer.Rows.RemoveAt(dataGridViewRow.Index);
                    RemoveCustomerToDB();
                    MessageBox.Show("Xóa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK);
                }
            }    
        }
        
        private void UpdateCustomerToDB()
        {
            foreach (DataGridViewRow dataGridViewRow in dgvCustomer.SelectedRows)
            {
                CUSTOMER c = new CUSTOMER();
                if (c != null)
                {
                    c.PhoneNumber = txtPhoneNumber.Text;
                    c.FullName = txtFullName.Text;
                    c.Email = txtEmail.Text;
                    MessageBox.Show("Cập nhật khách hàng thành công !", "Thông báo", MessageBoxButtons.OK);
                    context.CUSTOMER.Add(c);
                    context.SaveChanges();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow dataGridViewRow = dgvCustomer.Rows[index];
            dataGridViewRow.Cells[0].Value = txtPhoneNumber.Text;
            dataGridViewRow.Cells[1].Value = txtFullName.Text;
            dataGridViewRow.Cells[2].Value = txtEmail.Text;
            UpdateCustomerToDB();
        }
        private void txtSearchFullName_TextChanged1111(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvCustomer.Rows.Count - 1; i++)
                {
                    if (dgvCustomer.Rows[i].Cells[1].Value.ToString().ToLower().Contains(txtSearchFullName.Text.ToLower()) == true)
                        dgvCustomer.Rows[i].Visible = true;
                    else
                        dgvCustomer.Rows[i].Visible = false;
                }
            }
            catch(Exception ex) { }
        }
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gray; ;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.White; 
        }

        private void btnUpdate_MouseHover(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.Gray;

        }
      

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                panelFeatures.Controls.Clear();

                panelFeatures.Controls.Add(label6);
                panelFeatures.Controls.Add(txtSearchFullName);
                double width = (panelFeatures.Width);
                double height = (panelFeatures.Height) / 4;

                Label label = new Label();
                label.Location = new Point(0, Convert.ToInt32(height));
                label.Size = new Size(Convert.ToInt32(width), 50);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Text = "Danh Sách Khách Hàng";
                label.Font = new Font("Segoe UI", 24, FontStyle.Bold);

                panelFeatures.Controls.Add(label);
            }
            catch (Exception ex){ }
        }

        private void dataGridViewCustomer_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0) 
                {
                    int selectedIndex = e.RowIndex;
                    txtPhoneNumber.Text = dgvCustomer.Rows[selectedIndex].Cells[0].Value.ToString();
                    txtFullName.Text = dgvCustomer.Rows[selectedIndex].Cells[1].Value.ToString();
                    txtEmail.Text = dgvCustomer.Rows[selectedIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchFullName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvCustomer.Rows.Count; i++)
                {
                    if (dgvCustomer.Rows[i].Cells[1].Value.ToString().ToLower().Contains(txtSearchFullName.Text.ToLower()) == true)
                        dgvCustomer.Rows[i].Visible = true;
                    else
                        dgvCustomer.Rows[i].Visible = false;
                }
            }
            catch (Exception ex) { }
        }
    }
}
