using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Service
{
    public partial class ServiceForm : Form
    {
        Form activeForm = null;
        public ServiceForm()
        {
            InitializeComponent();
            OpenChildForm(new ShowServiceReceiptForm());
            btnReceiptServices.BackColor = SystemColors.ButtonShadow;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnServiceReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageServiceForm());
            btnServiceReceipt.BackColor = SystemColors.ButtonShadow;
            btnReceiptServices.BackColor = Color.LightGray;
            btnCreateServiceReceipt.BackColor = Color.LightGray;
        }

        private void btnCreateServiceReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageServiceForm());
            btnCreateServiceReceipt.BackColor = SystemColors.ButtonShadow;
            btnServiceReceipt.BackColor = Color.LightGray;
            btnReceiptServices.BackColor = Color.LightGray;
        }

        private void btnReceiptServices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ShowServiceReceiptForm());
            btnReceiptServices.BackColor = SystemColors.ButtonShadow;
            btnServiceReceipt.BackColor = Color.LightGray;
            btnCreateServiceReceipt.BackColor= Color.LightGray; 
        }
    }
}
