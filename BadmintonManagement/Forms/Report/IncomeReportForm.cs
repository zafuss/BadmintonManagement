using Microsoft.Reporting.WinForms;
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
    public partial class IncomeReportForm : Form
    {
        public IncomeReportForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

            //rptIncome.LocalReport.ReportPath = "IncomeReport.rdlc";
            //this.rptIncome.RefreshReport();
            rptIncome.Visible = false;
            
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            rptIncome.Visible=true;
            rptIncome.LocalReport.ReportPath = "IncomeReport.rdlc";
            this.rptIncome.RefreshReport();
        }
    }
}
