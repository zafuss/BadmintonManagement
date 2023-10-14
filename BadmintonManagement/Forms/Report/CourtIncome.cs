
using BadmintonManagement.Database;
using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Activities.Expressions;
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
    public partial class CourtIncome : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        //  khởi tạo chuỗi kết nối cơ sở dữ liệu SQL Server
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public CourtIncome()
        {
            InitializeComponent();
        }
        
        private void ReceiptFormReport_Load(object sender, EventArgs e)
        {
            rptCourtIncome.Visible = false;
        }
        // lấy dữ liệu doanh thu sân từ hóa đơn đưa lên reportviewer
        private void IncomeCourtReportMonth()
        {
            
            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandType = CommandType.Text;
            Microsoft.Reporting.WinForms.ReportParameter[] param1;
            // kiểm tra nếu thống kê theo tháng và theo ngày
            if (rdbMonth.Checked == true)
            {
                param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Tháng " + dtpMonth.Text)
                };
                string month1 = dtpMonth.Value.Month.ToString();
                string year1 = dtpMonth.Value.Year.ToString();
                //  truy vấn SQL để lấy dữ liệu doanh thu 
                cmd.CommandText = @"select R1.ReceiptNo,convert(varchar,R1._Date,105) as Ngay,C.PhoneNumber,C.FullName,U._Name,R1.Total
                                from RECEIPT R1,RESERVATION R2,CUSTOMER C,_USER U
                                where R1.ReservationNo = R2.ReservationNo and R1.Username= U.Username and R2.PhoneNumber = C.PhoneNumber 
                                and convert(varchar,month(R1._Date)) = '" + month1 + @"' and convert(varchar,year(R1._Date)) = '" + year1 + "'";

            }
            else
            {
                param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Từ ngày" + dtbStart.Text + " đến ngày " + dtpEnd.Text)
                };
                string starDay = dtbStart.Value.AddDays(-1).ToString();
                string enDay = dtpEnd.Value.AddDays(1).ToString();
                //  truy vấn SQL để lấy dữ liệu doanh thu 
                cmd.CommandText = @"select R1.ReceiptNo,convert(varchar,R1._Date,105) as Ngay,C.PhoneNumber,C.FullName,U._Name,R1.Total
                                from RECEIPT R1,RESERVATION R2,CUSTOMER C,_USER U
                                where R1.ReservationNo = R2.ReservationNo and R1.Username= U.Username and R2.PhoneNumber = C.PhoneNumber 
		                                and R1._Date between '" + starDay + "' and '" + enDay + "'";
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
                throw new Exception("Không có doanh thu trong thời gian này");
            // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // Đặt tham số báo cáo và refresh ReportViewer để hiển thị dữ liệu.
            rptCourtIncome.LocalReport.ReportPath = "CourtIncomeReport.rdlc";
            var sour = new ReportDataSource("CourtIncomeReport", list);
            rptCourtIncome.LocalReport.DataSources.Clear();
            rptCourtIncome.LocalReport.DataSources.Add(sour);
            rptCourtIncome.LocalReport.SetParameters(param1);
            this.rptCourtIncome.RefreshReport();

        }
        
        // load form thống kê doanh thu sân
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbMonth.Checked == false && rdbDay.Checked == false)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptCourtIncome.Visible = true;
                IncomeCourtReportMonth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }

        
    
}
