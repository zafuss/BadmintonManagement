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
using System.Xml.Linq;

namespace BadmintonManagement.Forms.Customer
{
    public partial class CustomerForm : Form
    {
        List<CUSTOMER> customers = CustomerServices.GetAllService();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load_1(object sender, EventArgs e)
        {
            BindDataGrid(customers);
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

        private void CheckException()
        {
            if (txtEmail.Text == "" || txtPhoneNumber.Text == "" || txtFullName.Text == "")
                throw new Exception("Vui lòng nhập đầy đủ thông tin");

        }
       
        private void Reset()
        {
            txtEmail.Text = txtFullName.Text = txtPhoneNumber.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CheckException();
                CUSTOMER customer = CustomerServices.GetCustomer(txtPhoneNumber.Text);
                if (customer != null)
                    throw new Exception("Số điện thoại khách hàng đã tồn tại");
                else
                {
                    customer = new CUSTOMER();
                    customer.PhoneNumber = txtPhoneNumber.Text;
                    customer.FullName = txtFullName.Text;
                    customer.Email = txtEmail.Text;
                    Validator.CustomerValidator(customer);
                    CustomerServices.AddCustomer(customer);
                }
                customers = CustomerServices.GetAllService();
                BindDataGrid(customers);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CheckException();
                CUSTOMER customer = CustomerServices.GetCustomer(txtPhoneNumber.Text);
                if (customer == null)
                    throw new Exception("Khách hàng không tồn tại");
                else
                {
                    customer.PhoneNumber = txtPhoneNumber.Text;
                    customer.FullName = txtFullName.Text;
                    customer.Email = txtEmail.Text;
                    Validator.CustomerValidator(customer);
                    CustomerServices.UpdateCustomer(customer);
                }
                customers = CustomerServices.GetAllService();
                BindDataGrid(customers);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
