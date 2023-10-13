using BadmintonManagement.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BadmintonManagement.Forms.Court
{
    public partial class CourtCalendar : Form
    {
        public CourtCalendar()
        {
            InitializeComponent();
            BindCalendar();
            Title();

        }

        private void Title()
        {
            pnlTitle.Controls.Clear();
            double width = (pnlTitle.Width);
            double height = (pnlTitle.Height) / 4;
            Label label = new Label();
            label.Location = new Point(0, Convert.ToInt32(height));
            label.Size = new Size(Convert.ToInt32(width), 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Lịch Đặt Sân";
            label.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            pnlTitle.Controls.Add(label);
        }
        private void BindCalendar()
        {
            lstvCalender.Items.Clear();
            lstvCalender.Groups.Clear();
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";


            string sql = @"	select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
								from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
								FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
														FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
														from RESERVATION reser , CUSTOMER a 
														where a.PhoneNumber = reser.PhoneNumber) 
														tmp , COURT a
								where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID";


            List<COURT> list = new ModelBadmintonManage().COURT.ToList();
            foreach (var item in list)
            {
                ListViewGroup Court = new ListViewGroup(item.CourtName);
                lstvCalender.Groups.Add(Court);

                SqlConnection conn;
                conn = new SqlConnection(connectString);
                conn.Open();

                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@courtID", item.CourtID);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dataReader.GetString(0);
                    lvi.SubItems.Add(dataReader.GetString(1));
                    lvi.SubItems.Add(dataReader.GetString(2));
                    lvi.SubItems.Add(dataReader.GetString(3));
                    lvi.SubItems.Add(dataReader.GetString(4));
                    lvi.SubItems.Add(dataReader.GetString(5));
                    lvi.SubItems.Add(dataReader.GetString(6));
                    lvi.Group = Court;
                    lstvCalender.Items.Add(lvi);
                }
            }
        }

        private void BindCalendar(DateTime starttime , DateTime endtime)
        {
            lstvCalender.Items.Clear();
            lstvCalender.Groups.Clear();
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";


            string sql = @"select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
                            from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
							FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
						                            FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
						                            from RESERVATION reser , CUSTOMER a 
						                            where a.PhoneNumber = reser.PhoneNumber and 
													CONVERT(datetime,reser.BookingDate,103) between @_date1 and @_date2 ) 
													tmp , COURT a
                            where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID";

            List<COURT> list = new ModelBadmintonManage().COURT.ToList();
            foreach (var item in list)
            {
                ListViewGroup Court = new ListViewGroup(item.CourtName);
                lstvCalender.Groups.Add(Court);

                SqlConnection conn;
                conn = new SqlConnection(connectString);
                conn.Open();

                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@courtID", item.CourtID);
                cmd.Parameters.AddWithValue("@_date1", starttime);
                cmd.Parameters.AddWithValue("@_date2", endtime);
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = dataReader.GetString(0);
                    lvi.SubItems.Add(dataReader.GetString(1));
                    lvi.SubItems.Add(dataReader.GetString(2));
                    lvi.SubItems.Add(dataReader.GetString(3));
                    lvi.SubItems.Add(dataReader.GetString(4));
                    lvi.SubItems.Add(dataReader.GetString(5));
                    lvi.SubItems.Add(dataReader.GetString(6));
                    lvi.Group = Court;
                    lstvCalender.Items.Add(lvi);
                }
            }
        }

        private void rdoCheckDay_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCheckDay.Checked == true)
            {
                DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                BindCalendar(dateTime, dateTime);
            }
            else
            {
                BindCalendar();
            }
        }

        private void rdoCheckWeek_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCheckWeek.Checked == true)
            {
                DateTime now = DateTime.Now;
                DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek + 1);
                DateTime endOfWeek = startOfWeek.AddDays(6);
                BindCalendar(startOfWeek, endOfWeek);
            }
            else 
            { 
                BindCalendar();
            }
        }

        private void rdoCheckMonth_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoCheckMonth.Checked == true)
            {
                var lastdayofmont = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                DateTime dayStartMonth= DateTime.Parse(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("dd/MM/yyyy"));
                DateTime dayEndMonth = DateTime.Parse(new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastdayofmont).ToString("dd/MM/yyyy"));
                BindCalendar(dayStartMonth, dayEndMonth);
            }
            else
            {
                BindCalendar();
            }
        }


        private void dtmEndDate_ValueChanged(object sender, EventArgs e)
        {
            rdoCheckDay.Checked = rdoCheckMonth.Checked = rdoCheckWeek.Checked = false;
            DateTime dateS = DateTime.Parse(dtmStartDate.Value.ToString("dd/MM/yyyy"));
            DateTime dateE = DateTime.Parse(dtmEndDate.Value.ToString("dd/MM/yyyy")).AddDays(1);
            BindCalendar(dateS, dateE);
        }

        private void pnlTitle_SizeChanged(object sender, EventArgs e)
        {
            Title();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Muốn Thoát","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoCheckDay.Checked = rdoCheckMonth.Checked = rdoCheckWeek.Checked = false;
        }

        private void dtmStartDate_ValueChanged(object sender, EventArgs e)
        {
            rdoCheckDay.Checked = rdoCheckMonth.Checked = rdoCheckWeek.Checked = false;
            DateTime dateS = DateTime.Parse(dtmStartDate.Value.ToString("dd/MM/yyyy"));
            DateTime dateE = DateTime.Parse(dtmEndDate.Value.ToString("dd/MM/yyyy")).AddDays(1);
            BindCalendar(dateS, dateE);
        }
    }
}
