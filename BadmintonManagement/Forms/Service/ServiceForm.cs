using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonManagement.Forms.Service.ServiceReceipt;

namespace BadmintonManagement.Forms.Service
{
    public partial class ServiceForm : Form
    {
        Form activeForm = null;
        public ServiceForm()
        {
            InitializeComponent();
            
            
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

        private void btnCreateServiceReceipt_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageServiceForm());
            //btnCreateServiceReceipt.BackColor = SystemColors.ButtonShadow;
            btnServiceReceipt.BackColor = Color.LightGray;
            btnReceiptServices.BackColor = Color.LightGray;
        }
        string serviceRecNo;
        private void LoadServiceRecNo(string serviceRecNo)
        {
            this.serviceRecNo = serviceRecNo;
        }
        private void btnReceiptServices_Click(object sender, EventArgs e)
        {
            ShowServiceReceiptForm frm = new ShowServiceReceiptForm();
            frm.TheChosenServiceReceipt = new ShowServiceReceiptForm.GetTheChosenServiceReceipt(LoadServiceRecNo);
            OpenChildForm(frm);
            btnReceiptServices.BackColor = SystemColors.ButtonShadow;
            btnServiceReceipt.BackColor = Color.LightGray;
            //btnCreateServiceReceipt.BackColor= Color.LightGray; 
            pnlListReceip.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ServiceRec frm = new ServiceRec();
            frm.ReloadShowServiceReceipt = new ServiceRec.ChangeServiceReceipt(LoadTheShowedReceipt);
            frm.ShowDialog();
        }
        private void LoadTheShowedReceipt(int i)
        {
            btnReceiptServices.PerformClick();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            ServiceRec frm = new ServiceRec(serviceRecNo);
            frm.ShowDialog();
        }
        private void btnServiceReceipt_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ManageServiceForm());
            btnServiceReceipt.BackColor = SystemColors.ButtonShadow;
            btnReceiptServices.BackColor = Color.LightGray;
            pnlListReceip.Visible = false;
        }
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            btnReceiptServices.PerformClick();
            pnlListReceip.Visible = false;
        }

       
    }
}
