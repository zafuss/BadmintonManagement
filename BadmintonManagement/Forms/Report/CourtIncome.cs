
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
        SqlConnection conn1;
        SqlCommand cmd1 = new SqlCommand();
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public CourtIncome()
        {
            InitializeComponent();
        }

        private void ReceiptFormReport_Load(object sender, EventArgs e)
        {
            rptCourtIncome.Visible = false;
        }

        private void IncomeCourtReportMonth()
        {
            string month1 = dtpMonth.Value.Month.ToString();
            string year1 = dtpMonth.Value.Year.ToString();
            if (conn == null)
                conn = new SqlConnection(str);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"select R1.ReceiptNo,convert(varchar,R1._Date,105) as Ngay,C.PhoneNumber,C.FullName,U._Name,R1.Total
                                from RECEIPT R1,RESERVATION R2,CUSTOMER C,_USER U
                                where R1.ReservationNo = R2.ReservationNo and R1.Username= U.Username and R2.PhoneNumber = C.PhoneNumber 
                                and convert(varchar,month(R1._Date)) = '" + month1 + @"' and convert(varchar,year(R1._Date)) = '" + year1+"'";
 
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CourtIncomeReport> list = new List<CourtIncomeReport>();
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
            Microsoft.Reporting.WinForms.ReportParameter[] param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Tháng " + dtpMonth.Text)
            };

            rptCourtIncome.LocalReport.ReportPath = "CourtIncomeReport.rdlc";
            var sour = new ReportDataSource("CourtIncomeReport", list);
            rptCourtIncome.LocalReport.DataSources.Clear();
            rptCourtIncome.LocalReport.DataSources.Add(sour);
            rptCourtIncome.LocalReport.SetParameters(param1);
         

        }
        private void IncomeCourtReportDay()
        {
            string starDay = dtbStart.Value.AddDays(-1).ToString();
            string enDay = dtpEnd.Value.AddDays(1).ToString();
            if (conn1 == null)
                conn1 = new SqlConnection(str);
            if (conn1.State == ConnectionState.Closed)
                conn1.Open();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = @"select R1.ReceiptNo,convert(varchar,R1._Date,105) as Ngay,C.PhoneNumber,C.FullName,U._Name,R1.Total
                                from RECEIPT R1,RESERVATION R2,CUSTOMER C,_USER U
                                where R1.ReservationNo = R2.ReservationNo and R1.Username= U.Username and R2.PhoneNumber = C.PhoneNumber 
		                                and R1._Date between '" + starDay + "' and '" + enDay + "'";

            cmd1.Connection = conn1;
            SqlDataReader reader1 = cmd1.ExecuteReader();
            List<CourtIncomeReport> list = new List<CourtIncomeReport>();
            while (reader1.Read())
            {
                CourtIncomeReport court = new CourtIncomeReport();
                court.ReceiptNo = reader1.GetString(0);
                court.CreateDate = reader1.GetString(1);
                court.PhoneNumber = reader1.GetString(2);
                court.FullName = reader1.GetString(3);
                court.EmployeeName1 = reader1.GetString(4);
                court.Total = reader1.GetDecimal(5);

                list.Add(court);
            }
            reader1.Close();
            if (list.Count < 1)
                throw new Exception("Khong có doanh thu trong thời gian này");
            Microsoft.Reporting.WinForms.ReportParameter[] param1 = new Microsoft.Reporting.WinForms.ReportParameter[1]
            {
                    new Microsoft.Reporting.WinForms.ReportParameter("DeliveryDateStr","Từ ngày" + dtbStart.Text + " đến ngày " + dtpEnd.Text)
            };

            rptCourtIncome.LocalReport.ReportPath = "CourtIncomeReport.rdlc";
            var sour = new ReportDataSource("CourtIncomeReport", list);
            rptCourtIncome.LocalReport.DataSources.Clear();
            rptCourtIncome.LocalReport.DataSources.Add(sour);
            rptCourtIncome.LocalReport.SetParameters(param1);


        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbMonth.Checked == false && rdbDay.Checked == false)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptCourtIncome.Visible = true;
                if (rdbMonth.Checked == true)
                {
                    IncomeCourtReportMonth();
                }
                else
                {
                    IncomeCourtReportDay();
                }
                this.rptCourtIncome.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }

        
    
}
