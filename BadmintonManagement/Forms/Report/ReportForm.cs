﻿using System;
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
            btnChartIncome.BackColor = SystemColors.ButtonShadow;
            btnIncome.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            OpenChilForm(new FormIncome());
            btnReportSerVice.BackColor = Color.LightGray;
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

        private void btnChartIncome_Click(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnChartIncome.BackColor = SystemColors.ButtonShadow;
            btnIncome.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            btnReportSerVice.BackColor = Color.LightGray;
            OpenChilForm(new FormIncome());
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            HiddenButom();
            btnIncome.BackColor = SystemColors.ButtonShadow;
            btnChartIncome.BackColor = Color.LightGray;
            btnCustomerReport.BackColor = Color.LightGray;
            btnReportSerVice.BackColor = Color.LightGray;
        }

        private void btnServiceIncome_Click(object sender, EventArgs e)
        {
            btnServiceIncome.BackColor = SystemColors.ButtonShadow;
            btnCourtIncome.BackColor = Color.LightGray;
            OpenChilForm(new ServiceIncome());
        }

        private void btnCourtIncome_Click(object sender, EventArgs e)
        {
            btnCourtIncome.BackColor = SystemColors.ButtonShadow;
            btnServiceIncome.BackColor = Color.LightGray;
            OpenChilForm(new CourtIncome());
        }

        private void btnCustomerReport_Click_1(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnCustomerReport.BackColor = SystemColors.ButtonShadow;
            btnChartIncome.BackColor = Color.LightGray;
            btnIncome.BackColor = Color.LightGray;
            btnReportSerVice.BackColor = Color.LightGray;
            OpenChilForm(new CustomerReport());
        }

        private void btnReportSerVice_Click(object sender, EventArgs e)
        {
            HiddenReceipt();
            btnReportSerVice.BackColor = SystemColors.ButtonShadow;
            btnCustomerReport.BackColor = Color.LightGray;
            btnChartIncome.BackColor = Color.LightGray;
            btnIncome.BackColor = Color.LightGray;
            OpenChilForm(new ReportService());
        }
    }
}
