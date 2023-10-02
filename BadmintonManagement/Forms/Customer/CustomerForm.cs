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
            dataGridViewCustomer.Rows.Clear();
            foreach(var item in customers)
            {
                int row = dataGridViewCustomer.Rows.Add();
                dataGridViewCustomer.Rows[row].Cells[0].Value = item.PhoneNumber;
                dataGridViewCustomer.Rows[row].Cells[1].Value = item.FullName;
                dataGridViewCustomer.Rows[row].Cells[2].Value = item.Email;

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
                dataGridViewCustomer.Rows.Add(txtPhoneNumber.Text, txtFullName.Text, txtEmail.Text);
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
            foreach(DataGridViewRow dataGridViewRow in dataGridViewCustomer.SelectedRows)
            {
                DialogResult dr = MessageBox.Show("Xác nhận xóa khách hàng này?", "YES/NO", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes) 
                { 
                    dataGridViewCustomer.Rows.RemoveAt(dataGridViewRow.Index);
                    RemoveCustomerToDB();
                    MessageBox.Show("Xóa khách hàng thành công !", "Thông báo", MessageBoxButtons.OK);
                }
            }    
        }
        
        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            index = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGridViewCustomer.Rows[index];
            txtPhoneNumber.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtFullName.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridViewRow.Cells[2].Value.ToString();
        }
        private void UpdateCustomerToDB()
        {
            foreach (DataGridViewRow dataGridViewRow in dataGridViewCustomer.SelectedRows)
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
            DataGridViewRow dataGridViewRow = dataGridViewCustomer.Rows[index];
            dataGridViewRow.Cells[0].Value = txtPhoneNumber.Text;
            dataGridViewRow.Cells[1].Value = txtFullName.Text;
            dataGridViewRow.Cells[2].Value = txtEmail.Text;
            UpdateCustomerToDB();
        }
        private void txtSearchFullName_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewCustomer.Rows.Count - 1; i++)
            {
                if (dataGridViewCustomer.Rows[i].Cells[1].Value.ToString().ToLower().Contains(txtSearchFullName.Text.ToLower())==true)
                    dataGridViewCustomer.Rows[i].Visible = true;
                else
                    dataGridViewCustomer.Rows[i].Visible = false;
            }    
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
        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            btnUpdate.BackColor = Color.White;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Gray;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor= Color.White;
        }

        
    }
}
