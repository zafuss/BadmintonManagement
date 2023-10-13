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
    public partial class CustomerReport : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();
        string str = @"data source=(local);initial catalog=BadmintonManagementDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            rptCustomer.Visible = false;
            
        }
        private void CustomerReportMonth()
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
                    new Microsoft.Reporting.WinForms.ReportParameter("DateTimeString","Tháng "+dtpMonth.Text)
                };
                string month1 = dtpMonth.Value.Month.ToString();
                string year1 = dtpMonth.Value.Year.ToString();
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
                string starDay = dtbStart.Value.AddDays(-1).ToString();
                string enDay = dtpEnd.Value.AddDays(1).ToString();
                cmd.CommandText = @"select C.FullName,C.PhoneNumber,C.Email,convert (varchar,count(R.ReservationNo)) as SoLan
                                    from RESERVATION R,CUSTOMER C,RECEIPT R1
                                    where R.PhoneNumber = C.PhoneNumber and R1.ReservationNo = R.ReservationNo 
	                                    and R1._Date > '" + starDay+"' and R1._Date < '" + enDay + "' group by C.FullName,C.PhoneNumber,C.Email ";
            }

            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            List<CountCustomer> list = new List<CountCustomer>();
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
            if (list.Count < 1)
                throw new Exception("Không có khách hàng trong thời gian này");
            rptCustomer.LocalReport.ReportPath = "CustomerReport.rdlc";
            var sour = new ReportDataSource("DataSetCountCustomer", list);
            rptCustomer.LocalReport.DataSources.Clear();
            rptCustomer.LocalReport.DataSources.Add(sour);
            rptCustomer.LocalReport.SetParameters(param);

            this.rptCustomer.RefreshReport();
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
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
