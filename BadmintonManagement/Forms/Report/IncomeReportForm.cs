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
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnlIncomeDate.Visible = false;
            pnlCustomerReport.Visible = false;
        }

        private void HideDateTime()
        {
            if (pnlIncomeDate.Visible == true)
                pnlIncomeDate.Visible = false;
            if (pnlCustomerReport.Visible == true)
                pnlCustomerReport.Visible = false;
        }

        private void ShowDateTime(Panel panel)
        {
            if(panel.Visible == false)
            {
                HideDateTime();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void btnIncomeReport_Click(object sender, EventArgs e)
        {
            ShowDateTime(pnlIncomeDate);
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            ShowDateTime(pnlCustomerReport);
        }

        private void btnDateIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
