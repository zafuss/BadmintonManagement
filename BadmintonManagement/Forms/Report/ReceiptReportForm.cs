using System;
using System.Activities.Expressions;
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
    public partial class ReceiptReportForm : Form
    {
        public ReceiptReportForm()
        {
            InitializeComponent();
        }

        private void ReceiptFormReport_Load(object sender, EventArgs e)
        {
            rptReceipt.Visible = false;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            rptReceipt.Visible = true;
            Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Tháng "+dtpMonth.Text)
            };
            rptReceipt.LocalReport.ReportPath = "ReportReceipt.rdlc";
            rptReceipt.LocalReport.SetParameters(param);
            this.rptReceipt.RefreshReport();
        }

       
    }

        
    
}
