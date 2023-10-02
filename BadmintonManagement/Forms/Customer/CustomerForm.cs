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
            Custom();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();
            HideSubmenu();
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
            HideSubmenu();
        }
        private void dgrv_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[index];
            AddCustomerForm.instance.textbox1.Text = row.Cells[0].Value.ToString();
            AddCustomerForm.instance.textbox2.Text = row.Cells[1].Value.ToString();
            AddCustomerForm.instance.textbox3.Text = row.Cells[2].Value.ToString();
        }
        private void Custom()
        {
            panel_SubMenu.Visible = false;

        }
        private void HideSubmenu()
        {
            if(panel_SubMenu.Visible == true)
            {
                panel_SubMenu.Visible = false;
            }
        }
        private void ShowSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;

            }
        }
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panel_SubMenu);

        }
    }
}
