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
    public partial class CustomerReport : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            rptCustomer.Visible = false;
            
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rdbDay.Checked && !rdbMonth.Checked)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptCustomer.Visible = true;
                if(rdbMonth.Checked)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("DateTimeString","Tháng "+dtpMonth.Text)
                    };

                    List<CUSTOMER> customers = context.CUSTOMER.ToList();
                    rptCustomer.LocalReport.ReportPath = "CustomerReport.rdlc";

                    var soure = new ReportDataSource("DataSetCustomer", customers);
                    rptCustomer.LocalReport.DataSources.Clear();
                    rptCustomer.LocalReport.DataSources.Add(soure);
                    rptCustomer.LocalReport.SetParameters(param);
                }
                

                this.rptCustomer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
