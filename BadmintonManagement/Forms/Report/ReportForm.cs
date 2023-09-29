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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            
        }
        Form activeForm = null;
        private void OpenChilForm(Form chilForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;    
            chilForm.Dock = DockStyle.Fill;
            pnlViewreport.Controls.Add(chilForm);
            pnlViewreport.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();

        }

        
        private void btnIncome_Click(object sender, EventArgs e)
        {
            OpenChilForm(new IncomeReportForm());
            btnIncome.BackColor = Color.LightGray;
            btnReceipt.BackColor = SystemColors.Control;
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            OpenChilForm(new ReceiptReportForm());
            btnReceipt.BackColor = Color.LightGray;
            btnIncome.BackColor = SystemColors.Control;
        }
    }
}
