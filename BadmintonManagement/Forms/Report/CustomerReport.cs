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
    public partial class CustomerReport : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        //  khởi tạo chuỗi kết nối cơ sở dữ liệu SQL Server
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            rptCustomer.Visible = false;
            
        }
        // lấy dữ liệu lượt khách hàng đưa lên reportviewer
        private void CustomerReportMonth()
        {
            
            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandType = CommandType.Text;
            Microsoft.Reporting.WinForms.ReportParameter[] param;
            // kiểm tra nếu thống kê theo tháng và theo ngày
            if (rdbMonth.Checked)
            {
                param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeString","Tháng "+dtpMonth.Text)
                };
                string month1 = dtpMonth.Value.Month.ToString();
                string year1 = dtpMonth.Value.Year.ToString();
                //  truy vấn SQL để lấy dữ liệu lượt khách theo tháng
                cmd.CommandText = @"select C.FullName,C.PhoneNumber,C.Email,convert (varchar,count(R.ReservationNo)) as SoLan
                                    from RESERVATION R,CUSTOMER C,RECEIPT R1
                                    where R.PhoneNumber = C.PhoneNumber and R1.ReservationNo = R.ReservationNo and CONVERT(varchar,month(R1._Date))= '"+month1+"'  and CONVERT(varchar,year(R1._Date))= '"+year1+
                                    "' group by C.FullName,C.PhoneNumber,C.Email";
            }
            else
            {
                param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                {
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeString","Từ ngày "+dtbStart.Text +" đến ngày "+dtpEnd.Text)
                };
                DateTime starDay = DateTime.Parse(dtbStart.Value.AddDays(-1).ToString("dd/MM/yyyy"));
                DateTime endDay = DateTime.Parse(dtpEnd.Value.AddDays(1).ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@_date5", starDay);
                cmd.Parameters.AddWithValue("@_date6", endDay);
                //  truy vấn SQL để lấy dữ liệu lượt khách theo ngày
                cmd.CommandText = @"select C.FullName,C.PhoneNumber,C.Email,convert (varchar,count(R.ReservationNo)) as SoLan
                                    from RESERVATION R,CUSTOMER C,RECEIPT R1
                                    where R.PhoneNumber = C.PhoneNumber and R1.ReservationNo = R.ReservationNo 
	                                    and CONVERT(datetime,R1._Date,103) between @_date5 and @_date6 
                                    group by C.FullName,C.PhoneNumber,C.Email ";
            }

            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CountCustomer> list = new List<CountCustomer>();
            // Đọc dữ liệu từ SqlDataReader và điền vào danh sách.
            while (reader.Read())
            {
                CountCustomer customer = new CountCustomer();
                customer.FullName = reader.GetString(0);
                customer.PhoneNumber = reader.GetString(1);
                customer.Email  = reader.GetString(2);
                customer.Solan = reader.GetString(3);

                list.Add(customer);
            }
            reader.Close();
            
                // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // Đặt tham số báo cáo và refresh ReportViewer để hiển thị dữ liệu.
            rptCustomer.LocalReport.ReportPath = "CustomerReport.rdlc";
            var sour = new ReportDataSource("DataSetCountCustomer", list);
            rptCustomer.LocalReport.DataSources.Clear();
            rptCustomer.LocalReport.DataSources.Add(sour);
            rptCustomer.LocalReport.SetParameters(param);

            this.rptCustomer.RefreshReport();
            if (list.Count < 1)
            {
                throw new Exception("Không có khách hàng trong thời gian này");
            }
        }

        // load form thống kê lượt khách
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                cmd.Parameters.Clear();
                if (!rdbDay.Checked && !rdbMonth.Checked)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptCustomer.Visible = true;
                CustomerReportMonth();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
