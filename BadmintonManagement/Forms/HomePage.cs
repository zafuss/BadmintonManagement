using BadmintonManagement.Forms.AdminForm;
using BadmintonManagement.Forms.Report;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnAdminManageUser_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Role == "Admin")
            {
                btnAdminManageUser.Visible = true;
                btnAdminManageUser.Enabled = true;
            } else
            {
                btnAdminManageUser.Visible = false;
                btnAdminManageUser.Enabled = false;
            }

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?","Xác nhận",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            IncomeReportForm incomeReportForm = new IncomeReportForm();
            incomeReportForm.MdiParent = this;
            incomeReportForm.Show();
        }
    }
}
