using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Customer
{
    public partial class AddCustomerForm : Form
    {
        public static AddCustomerForm instance;
        public TextBox textbox1, textbox2, textbox3;
        public AddCustomerForm()
        {
            InitializeComponent();
            instance = this;
            textbox1 = txt_PhoneNumber;
            textbox2 = txt_FullName;
            textbox3 = txt_Email;
        }

        /*private void btn_Update_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dataGridViewRow = CustomerForm.instance.dataGridView.Rows[index];
            dataGridViewRow.Cells[0].Value = AddCustomerForm.instance.textbox1.Text;
            dataGridViewRow.Cells[1].Value = AddCustomerForm.instance.textbox2.Text;
            dataGridViewRow.Cells[2].Value = AddCustomerForm.instance.textbox3.Text;
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
        }*/

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CustomerForm.instance.dataGridView.Rows.Add(txt_Email.Text, txt_FullName.Text, txt_FullName.Text, txt_PhoneNumber.Text);
            MessageBox.Show("Thêm sinh viên thành công !", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
