using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Report
{
    public partial class ServiceReceiptForm : Form
    {
        public ServiceReceiptForm()
        {
            InitializeComponent();
        }

        private void ServiceReceiptForm_Load(object sender, EventArgs e)
        {

            rptServiceReceipt.Visible = false;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            rptServiceReceipt.Visible = true;
            rptServiceReceipt.LocalReport.ReportPath = "ServiceReceiptReport.rdlc";
            this.rptServiceReceipt.RefreshReport();
        }
    }
}
