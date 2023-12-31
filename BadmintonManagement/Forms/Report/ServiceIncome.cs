﻿using BadmintonManagement.Database;
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
                cmd.CommandText = @"select T1.ServiceReceiptNo,T1.NgayLap,C.PhoneNumber,C.FullName,T1._Name,T1.Total
                                    from (select S1.ServiceReceiptNo,convert(varchar,S1.CreateDate,105) as NgayLap,U._Name,S1.Total, S1.PhoneNumber
                                        from SERVICE_RECEIPT S1,_USER U
                                        where  U.Username = S1.Username
		                                    and convert(varchar,month(s1.CreateDate)) = '"+month1+@"' 
									        and convert(varchar,year(s1.CreateDate)) = '"+year1+@"') T1 left join CUSTOMER C on C.PhoneNumber = T1.PhoneNumber";
            }
            else
            {
                param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeStrr","Từ ngày "+dtbStart.Text +" đến ngày "+dtpEnd.Text)
                };
                DateTime starDay = DateTime.Parse(dtbStart.Value.AddDays(-1).ToString("dd/MM/yyyy"));
                DateTime endDay = DateTime.Parse(dtpEnd.Value.AddDays(1).ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@_date3", starDay);
                cmd.Parameters.AddWithValue("@_date4", endDay);
                //  truy vấn SQL để lấy dữ liệu doanh thu 
                cmd.CommandText = @"select T1.ServiceReceiptNo,T1.NgayLap,C.PhoneNumber,C.FullName,T1._Name,T1.Total
                                    from (select S1.ServiceReceiptNo,convert(varchar,S1.CreateDate,105) as NgayLap,U._Name,S1.Total, S1.PhoneNumber
                                        from SERVICE_RECEIPT S1,_USER U
                                        where  U.Username = S1.Username
		                                    and CONVERT(datetime,s1.CreateDate,103) between @_date3 and @_date4 ) T1 left join CUSTOMER C on C.PhoneNumber = T1.PhoneNumber";
		                                   
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
                if (reader.GetValue(2).ToString() == string.Empty)
                    court.PhoneNumber = "";
                else
                    court.PhoneNumber = reader.GetString(2);
                if (reader.GetValue(3).ToString() == string.Empty)
                    court.FullName = "";
                else
                    court.FullName = reader.GetString(3);
                court.EmployeeName1 = reader.GetString(4);
                court.Total = reader.GetDecimal(5);

                list.Add(court);
            }
            reader.Close();
            
            // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // Đặt tham số báo cáo và refresh ReportViewer để hiển thị dữ liệu.
            rptServiceReceipt.LocalReport.ReportPath = "ServiceReport.rdlc";
            var sour = new ReportDataSource("ServiceIncomeReport", list);
            rptServiceReceipt.LocalReport.DataSources.Clear();
            rptServiceReceipt.LocalReport.DataSources.Add(sour);
            rptServiceReceipt.LocalReport.SetParameters(param);

            this.rptServiceReceipt.RefreshReport();
            if (list.Count < 1)
            {
                throw new Exception("Khong có doanh thu trong thời gian này");
            }
        }
        // Load form Doanh thu dịch vụ
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                if (!rdbDay.Checked && !rdbMonth.Checked)
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
