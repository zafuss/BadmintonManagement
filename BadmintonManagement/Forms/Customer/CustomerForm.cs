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
        public static CustomerForm instance;
        public DataGridView dataGridView;
        public int index;
        public CustomerForm()
        {
            InitializeComponent();
            instance = this;
            dataGridView = dgrv_Customer;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView.SelectedRows)
            {
                DialogResult dr = MessageBox.Show("Xác nhận xóa sinh viên?", "OK/HỦY", MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    dataGridView.Rows.RemoveAt(item.Index);
                    MessageBox.Show("Xóa sinh viên thành công!");
                }
                
            }
        }

        private void dgrv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[index];
            AddCustomerForm.instance.textbox1.Text = row.Cells[0].Value.ToString();
            AddCustomerForm.instance.textbox2.Text = row.Cells[1].Value.ToString();
            AddCustomerForm.instance.textbox3.Text = row.Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm1 = new AddCustomerForm();
            addCustomerForm1.ShowDialog();
            DataGridViewRow dataGridViewRow = dataGridView.Rows[index];
            dataGridViewRow.Cells[0].Value = AddCustomerForm.instance.textbox1.Text;
            dataGridViewRow.Cells[1].Value = AddCustomerForm.instance.textbox2.Text;
            dataGridViewRow.Cells[2].Value = AddCustomerForm.instance.textbox3.Text;
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);


        }
    }
}
