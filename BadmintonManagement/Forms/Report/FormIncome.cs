using BadmintonManagement.Database;
using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt;
using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
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
    public partial class FormIncome : Form
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        SqlConnection conn1;
        SqlCommand cmd1 = new SqlCommand();
        //  khởi tạo chuỗi kết nối cơ sở dữ liệu SQL Server
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public FormIncome()
        {
            InitializeComponent();
            
        }

        // lấy dữ liệu doanh thu sân từ hóa đơn đưa lên reportviewer
        private void IncomeCourt()
        {
            reportViewer1.LocalReport.DataSources.Clear();
            string year = dtpYear.Text;
            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            // Set command type thành text, truy vấn SQL để lấy dữ liệu doanh thu 
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select T1.Thang, (T1.Total + T.Total) as Total
                                    from (	select convert(int,Month(R._Date)) as Thang,sum(R.Total) as Total 
		                                    from RECEIPT R
		                                    where convert(varchar,year(R._Date)) = " + year + @"
		                                    group by convert(int,Month(R._Date))) T1 , (select convert(int ,month(S.CreateDate)) as Thang,sum(S.Total) as Total 
													                                    from SERVICE_RECEIPT S
													                                    where convert(varchar,year(S.CreateDate)) = " + year + @"
													                                    group by convert(int,Month(S.CreateDate))) T
                                    where T1.Thang = T.Thang
                                    order by T1.Thang ";
            
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<IncomeYear> list = new List<IncomeYear>();
            // Đọc dữ liệu từ SqlDataReader và điền vào danh sách.
            while (reader.Read())
            {
                int moth = reader.GetInt32(0);
                decimal tatol = reader.GetDecimal(1);
                IncomeYear income = new IncomeYear();
                income.Year = moth;
                income.Tatol = tatol;
                list.Add(income);
            }
            reader.Close();
            if (list.Count < 1)
            {
                //this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.RefreshReport();
                throw new Exception("Khong có doanh thu trong thời gian này");
                
            }
            // khởi tạo và gán các tham số
            Microsoft.Reporting.WinForms.ReportParameter[] param1 = new Microsoft.Reporting.WinForms.ReportParameter[2]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("nam",dtpYear.Text),
                    new Microsoft.Reporting.WinForms.ReportParameter("month", dtpMonth.Text)
            };
            // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // Đặt tham số báo cáo và refresh ReportViewer để hiển thị dữ liệu.
            reportViewer1.LocalReport.ReportPath = "ReportIncome.rdlc";
            var sour = new ReportDataSource("DataSetIncome", list);
            reportViewer1.LocalReport.DataSources.Add(sour);
            reportViewer1.LocalReport.SetParameters(param1);
            this.reportViewer1.RefreshReport();
            
        }

        // lấy dữ liệu danh sách hóa đơn dịch vụ
        private void IncomeService1()
        {
            
            cmd1.Parameters.Clear();
            string month = "";
            string year = dtpYear.Text;
            month = dtpMonth.Text;
            int t = int.Parse(month);
            if (conn1 == null)
                conn1 = new SqlConnection(str);
            if (conn1.State == ConnectionState.Closed)
                conn1.Open();
            // Set command type thành text, truy vấn SQL để lấy dữ liệu doanh thu 
            
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = @"select cast(round((T1.Total/(T1.Total+T.Total))*100,2) as decimal(18,2)) as San,cast((100-round((T1.Total/(T1.Total+T.Total))*100,2)) as decimal(18,2)) as dichvu
                             from (	select convert(int,Month(R._Date)) as Thang,sum(R.Total) as Total 
		                            from RECEIPT R
		                            where convert(varchar,year(R._Date)) = "+year+ 
                                    @"group by convert(int,Month(R._Date))) T1 , (select convert(int ,month(S.CreateDate)) as Thang,sum(S.Total) as Total 
													                            from SERVICE_RECEIPT S
													                            where convert(varchar,year(S.CreateDate)) = "+year+ @"
													                            group by convert(int,Month(S.CreateDate))) T
                            where T1.Thang = T.Thang and T1.Thang =  @thang";
            
            cmd1.Parameters.AddWithValue("@thang", t);
            cmd1.Connection = conn1;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            
            List<IncomeSer>  list1 = new List<IncomeSer>();
            // Đọc dữ liệu từ SqlDataReader và điền vào danh sách.
            while (reader1.Read())
            {
              
                decimal perCourt = reader1.GetDecimal(0);
                decimal perService = reader1.GetDecimal(1);
                IncomeSer incomeSer = new IncomeSer();
                incomeSer.PerCourt = perCourt;
                incomeSer.PerSer = perService;
                list1.Add(incomeSer);
                    
            }
            reader1.Close();
            if (list1.Count < 1)
            {
                
                throw new Exception("Không có doanh thu trong thời gian này");
                
            }
            // Set ReportPath cho ReportViewer.
            // Tạo ReportDataSource với dữ liệu từ list
            // refresh ReportViewer để hiển thị dữ liệu.
            reportViewer1.LocalReport.ReportPath = "ReportIncome.rdlc";
            var sour1 = new ReportDataSource("DataSetMonth", list1);
            reportViewer1.LocalReport.DataSources.Add(sour1);
            this.reportViewer1.RefreshReport();
        }
        // Load biểu đồ khi load form
        private void FormIncome_Load(object sender, EventArgs e)
        {
            try
            {
                IncomeCourt();
                IncomeService1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // cập nhật biểu đồ khi thay đổi năm 
        private void dtpYear_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                IncomeCourt();
                IncomeService1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //cập nhật biểu đồ khi thay đổi tháng
        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                
                IncomeCourt();
                IncomeService1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
