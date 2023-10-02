using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
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
        ModelBadmintonManage context = new ModelBadmintonManage();
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
            try
            {
                if (rdbMonth.Checked == false && rdbDay.Checked == false)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptReceipt.Visible = true;
                if (rdbMonth.Checked == true)
                {
                    
                    Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Tháng "+dtpMonth.Text)
                    };
                    
                    List<RECEIPT> receipts = context.RECEIPT.ToList();
                    receipts = receipts.Where(x => x.C_Date.Value.ToString("MM/yyy") == dtpMonth.Text).ToList();
                    rptReceipt.LocalReport.ReportPath = "ReportReceipt.rdlc";
                    var soure = new ReportDataSource("DataSetReceipt", receipts);
                    rptReceipt.LocalReport.DataSources.Clear();
                    rptReceipt.LocalReport.DataSources.Add(soure);
                    rptReceipt.LocalReport.SetParameters(param);
                    
                }
                else
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Từ ngày "+dtbStart.Text+ " đến ngày "+ dtpEnd.Text)
                    };

                    List<RECEIPT> receipts = context.RECEIPT.ToList();
                    receipts = receipts.Where(x => x.C_Date.Value > dtbStart.Value && x.C_Date.Value < dtpEnd.Value).ToList();
                    rptReceipt.LocalReport.ReportPath = "ReportReceipt.rdlc";
                    var soure = new ReportDataSource("DataSetReceipt", receipts);
                    rptReceipt.LocalReport.DataSources.Clear();
                    rptReceipt.LocalReport.DataSources.Add(soure);
                    rptReceipt.LocalReport.SetParameters(param1);

                }
                this.rptReceipt.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }

        
    
}
