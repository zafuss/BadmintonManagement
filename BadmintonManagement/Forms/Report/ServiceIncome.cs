using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Report
{
    public partial class ServiceIncome : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        public ServiceIncome()
        {
            InitializeComponent();
        }

        private void ServiceReceiptForm_Load(object sender, EventArgs e)
        {

            rptServiceReceipt.Visible = false;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if(!rdbDay.Checked && !rdbMonth.Checked)
                {
                    throw new Exception("Vui lòng nhập thời gian thống kê");
                }
                rptServiceReceipt.Visible = true;
                if (rdbMonth.Checked)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("DateTimeStrr","Tháng "+dtpMonth.Text)
                    };

                    List<SERVICE_RECEIPT> serviceReceipts = context.SERVICE_RECEIPT.ToList();
                    serviceReceipts = serviceReceipts.Where(x => x.CreateDate.Value.ToString("MM/yyyy") == dtpMonth.Text).ToList();
                    rptServiceReceipt.LocalReport.ReportPath = "ServiceReport.rdlc";

                    var soure = new ReportDataSource("DataSetService", serviceReceipts);
                    rptServiceReceipt.LocalReport.DataSources.Clear();
                    rptServiceReceipt.LocalReport.DataSources.Add(soure);
                    rptServiceReceipt.LocalReport.SetParameters(param);
                }
                else
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("DateTimeStrr","Từ ngày "+dtbStart.Text +" đến ngày "+dtpEnd.Text)
                    };

                    List<SERVICE_RECEIPT> serviceReceipts = context.SERVICE_RECEIPT.ToList();
                    serviceReceipts = serviceReceipts.Where(x => x.CreateDate.Value >= dtbStart.Value && x.CreateDate.Value <= dtpEnd.Value).ToList();
                    rptServiceReceipt.LocalReport.ReportPath = "ServiceReport.rdlc";
                    var soure = new ReportDataSource("DataSetService", serviceReceipts);
                    rptServiceReceipt.LocalReport.DataSources.Clear();
                    rptServiceReceipt.LocalReport.DataSources.Add(soure);
                    rptServiceReceipt.LocalReport.SetParameters(param);
                }
                this.rptServiceReceipt.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
