using BadmintonManagement.Database;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Report
{
    public partial class ReportService : Form
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public ReportService()
        {
            InitializeComponent();
        }

        private void ServiceReportMonth()
        {

            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string day = DateTime.Now.ToString("dd/MM/yyyy").Replace("-","/");
            Microsoft.Reporting.WinForms.ReportParameter[] param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
            {
                new ReportParameter("ngaybaocao","Ngày báo cáo: " + day)
            };
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select S.ServiceID,S.ServiceName,s.Unit,convert(varchar,S.Quantity) as SL
                                from _SERVICE S
                                where S._Status = 'Enabled'";
          
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<ReportServiceInStoge> list = new List<ReportServiceInStoge>();
            while (reader.Read())
            {
                ReportServiceInStoge service = new ReportServiceInStoge();
                service.ServiceID = reader.GetString(0);
                service.ServiceName = reader.GetString(1);
                service.Unit = reader.GetString(2);
                service.Quantity = reader.GetString(3);

                list.Add(service);
            }
            reader.Close();
          
            rptService.LocalReport.ReportPath = "ReportServiceInStoge.rdlc";
            var sour = new ReportDataSource("DataSetServiceInStoge", list);
            rptService.LocalReport.DataSources.Clear();
            rptService.LocalReport.DataSources.Add(sour);
            rptService.LocalReport.SetParameters(param1);

            this.rptService.RefreshReport();
        }
        private void ReportService_Load(object sender, EventArgs e)
        {

            try
            {
                ServiceReportMonth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
