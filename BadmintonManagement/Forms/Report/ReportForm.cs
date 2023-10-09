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
            HiddenReceipt();
            btnIncome.BackColor = SystemColors.ButtonShadow;
            btnReceipt.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            btnReservationReport.BackColor = Color.LightGray;
            OpenChilForm(new FormIncome());
            pnlReceiptReport.Visible = false;
            
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

        private void HiddenReceipt()
        {
            if (pnlReceiptReport.Visible)
                pnlReceiptReport.Visible = false;
        }
        
        

        private void HiddenButom()
        {
            if (pnlReceiptReport.Visible)
                pnlReceiptReport.Visible = false;
            else
                pnlReceiptReport.Visible = true;
        }

       
        private void btnIncome_Click(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnIncome.BackColor = SystemColors.ButtonShadow;
            btnReceipt.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            btnReservationReport.BackColor = Color.LightGray;
            OpenChilForm(new FormIncome());
            
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            HiddenButom();
            btnReceipt.BackColor = SystemColors.ButtonShadow;
            btnIncome.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            btnReservationReport.BackColor = Color.LightGray;
        }

        private void btnCourtReceipt_Click(object sender, EventArgs e)
        {
            btnCourtReceipt.BackColor = SystemColors.ButtonShadow;
            btnServiceReceipt.BackColor = Color.LightGray;
            OpenChilForm(new ReceiptReportForm()); 
        }

        private void btnServiceReceipt_Click(object sender, EventArgs e)
        {
            btnServiceReceipt.BackColor = SystemColors.ButtonShadow;
            btnCourtReceipt.BackColor = Color.LightGray;
            OpenChilForm(new ServiceReceiptForm());
            
        }

        private void btnCustomerReport_Click(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnCustomerReport.BackColor = SystemColors.ButtonShadow;
            btnIncome.BackColor = Color.LightGray;
            btnReceipt.BackColor = Color.LightGray;
            btnReservationReport.BackColor = Color.LightGray;
            OpenChilForm(new CustomerReport());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnReservationReport.BackColor = SystemColors.ButtonShadow;
            btnIncome.BackColor = Color.LightGray;
            btnReceipt.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            OpenChilForm(new ReservationReport());
        }
    }
}
