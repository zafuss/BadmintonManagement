using BadmintonManagement.Database;
using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        //  khởi tạo chuỗi kết nối cơ sở dữ liệu SQL Server
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public ServiceIncome()
        {
            InitializeComponent();
        }

        private void ServiceReceiptForm_Load(object sender, EventArgs e)
        {

            rptServiceReceipt.Visible = false;
        }
        // lấy dữ liệu lượt khách hàng đưa lên reportviewer
        private void IncomeCourtReportMonth()
        {
            
            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandType = CommandType.Text;
            Microsoft.Reporting.WinForms.ReportParameter[] param;
            if (rdbMonth.Checked)
            {
                param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeStrr","Tháng "+dtpMonth.Text)
                };
                string month1 = dtpMonth.Value.Month.ToString();
                string year1 = dtpMonth.Value.Year.ToString();
                //  truy vấn SQL để lấy dữ liệu doanh thu 
                cmd.CommandText = @"select S1.ServiceReceiptNo,convert(varchar,S1.CreateDate,105) as NgayLap,C.FullName,S1.PhoneNumber,U._Name,S1.Total
                                    from SERVICE_RECEIPT S1,_USER U,CUSTOMER C
                                    where  S1.PhoneNumber = C.PhoneNumber and U.Username = S1.Username
		                                    and convert(varchar,month(s1.CreateDate)) = '"+month1+"' and convert(varchar,year(s1.CreateDate)) = '" + year1 +"'";
            }
            else
            {
                param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeStrr","Từ ngày "+dtbStart.Text +" đến ngày "+dtpEnd.Text)
                };
                string starDay = dtbStart.Value.AddDays(-1).ToString();
                string enDay = dtpEnd.Value.AddDays(1).ToString();
                //  truy vấn SQL để lấy dữ liệu doanh thu 
                cmd.CommandText = @"select S1.ServiceReceiptNo,convert(varchar,S1.CreateDate,105) as NgayLap,C.FullName,S1.PhoneNumber,U._Name,S1.Total
                                    from SERVICE_RECEIPT S1,_USER U,CUSTOMER C
                                    where  S1.PhoneNumber = C.PhoneNumber and U.Username = S1.Username
		                                    and s1.CreateDate  > '" + starDay +"' and '" + enDay +"' > s1.CreateDate";
            }
          
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CourtIncomeReport> list = new List<CourtIncomeReport>();
            // Đọc dữ liệu từ SqlDataReader và điền vào danh sách.
            while (reader.Read())
            {
                CourtIncomeReport court = new CourtIncomeReport();
                court.ReceiptNo = reader.GetString(0);
                court.CreateDate = reader.GetString(1);
                court.PhoneNumber = reader.GetString(2);
                court.FullName = reader.GetString(3);
                court.EmployeeName1 = reader.GetString(4);
                court.Total = reader.GetDecimal(5);

                list.Add(court);
            }
            reader.Close();
            if (list.Count < 1)
                throw new Exception("Khong có doanh thu trong thời gian này");
            // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // Đặt tham số báo cáo và refresh ReportViewer để hiển thị dữ liệu.
            rptServiceReceipt.LocalReport.ReportPath = "ServiceReport.rdlc";
            var sour = new ReportDataSource("ServiceIncomeReport", list);
            rptServiceReceipt.LocalReport.DataSources.Clear();
            rptServiceReceipt.LocalReport.DataSources.Add(sour);
            rptServiceReceipt.LocalReport.SetParameters(param);

            this.rptServiceReceipt.RefreshReport();
        }
        // Load form Doanh thu dịch vụ
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if(!rdbDay.Checked && !rdbMonth.Checked)
                {
                    throw new Exception("Vui lòng nhập thời gian thống kê");
                }
                rptServiceReceipt.Visible = true;

                IncomeCourtReportMonth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
