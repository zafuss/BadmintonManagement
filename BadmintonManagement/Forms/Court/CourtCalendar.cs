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

        //Title của form
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

        //Hàm để hiện thị tất cả các lịch sân
        private void BindCalendar()
        {
            //Xóa hết một thu trong listview
            lstvCalender.Items.Clear();
            lstvCalender.Groups.Clear();

            //Tên máy và tên cơ sở dữ liệu
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            //Câu lệnh truy vấn sql
            string sql = @"	select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
								from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
								FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
														FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
														from RESERVATION reser , CUSTOMER a 
														where a.PhoneNumber = reser.PhoneNumber) 
														tmp , COURT a
								where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID";

            //List sân trong cơ sở dữ liệu
            List<COURT> list = new ModelBadmintonManage().COURT.ToList();
            foreach (var item in list)
            {
                //Tạo một listviewgroup
                ListViewGroup Court = new ListViewGroup(item.CourtName);
                //Thêm listviewGroup 
                lstvCalender.Groups.Add(Court);

                SqlConnection conn;
                conn = new SqlConnection(connectString);
                conn.Open();

                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(sql, conn);

                //Truyền mã sân vào trong câu lệnh sql
                cmd.Parameters.AddWithValue("@courtID", item.CourtID);
                dataReader = cmd.ExecuteReader();

                //Lấy thông tin từ sql truyền vào listview
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

        private void BindCalendarAvailable()
        {
            //Xóa hết một thu trong listview
            lstvCalender.Items.Clear();
            lstvCalender.Groups.Clear();

            //Tên máy và tên cơ sở dữ liệu
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            //Câu lệnh truy vấn sql
            string sql = @"select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
                            from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
							FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
						                            FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
						                            from RESERVATION reser , CUSTOMER a 
						                            where a.PhoneNumber = reser.PhoneNumber and 
													CONVERT(datetime,reser.BookingDate,103) >= Cast(CURRENT_TIMESTAMP  as DATE)  ) 
													tmp , COURT a
                            where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID";

            //List sân trong cơ sở dữ liệu
            List<COURT> list = new ModelBadmintonManage().COURT.ToList();
            foreach (var item in list)
            {
                //Tạo một listviewgroup
                ListViewGroup Court = new ListViewGroup(item.CourtName);
                //Thêm listviewGroup 
                lstvCalender.Groups.Add(Court);

                SqlConnection conn;
                conn = new SqlConnection(connectString);
                conn.Open();

                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(sql, conn);

                //Truyền mã sân vào trong câu lệnh sql
                cmd.Parameters.AddWithValue("@courtID", item.CourtID);
                dataReader = cmd.ExecuteReader();

                //Lấy thông tin từ sql truyền vào listview
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

        //Hàm để hiện thị tất cả các lịch sân dựa trên ngày tháng truyền vào
        private void BindCalendar(DateTime starttime , DateTime endtime)
        {
            //Xóa hết một thu trong listview
            lstvCalender.Items.Clear();
            lstvCalender.Groups.Clear();

            //Tên máy và tên cơ sở dữ liệu
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            //Câu lệnh truy vấn sql
            string sql = @"select rf.ReservationNo , tmp.FullName , tmp.PhoneNumber ,tmp.[Ngay Choi], tmp.StartTime,tmp.EndTime , tmp.[Tong gio choi]
                            from RF_DETAIL rf ,		(select reser.ReservationNo, a.FullName , a.PhoneNumber , FORMAT(reser.BookingDate, 'dd/MM/yyyy')as[Ngay Choi] , 
							FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime , 
						                            FORMAT( DATEADD(MINUTE,DATEDIFF(MINUTE,reser.StartTime,reser.EndTime),'00:00'), 'HH:mm') as [Tong gio choi]
						                            from RESERVATION reser , CUSTOMER a 
						                            where a.PhoneNumber = reser.PhoneNumber and 
													CONVERT(datetime,reser.BookingDate,103) between @_date1 and @_date2 ) 
													tmp , COURT a
                            where rf.ReservationNo = tmp.ReservationNo and rf.CourtID = a.CourtID and rf.CourtID = @courtID";

            //List sân trong cơ sở dữ liệu
            List<COURT> list = new ModelBadmintonManage().COURT.ToList();
            foreach (var item in list)
            {
                //Tạo một listviewgroup
                ListViewGroup Court = new ListViewGroup(item.CourtName);
                lstvCalender.Groups.Add(Court);

                SqlConnection conn;
                conn = new SqlConnection(connectString);
                conn.Open();

                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(sql, conn);

                //Truyền mã sân vào trong câu lệnh sql
                cmd.Parameters.AddWithValue("@courtID", item.CourtID);

                //Truyền ngày bắt đầu vào câu lệnh sql
                cmd.Parameters.AddWithValue("@_date1", starttime);

                //Truyền ngày kết thúc vào câu lệnh sql
                cmd.Parameters.AddWithValue("@_date2", endtime);
                dataReader = cmd.ExecuteReader();

                //Lấy thông tin từ sql truyền vào listview
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
            //Kiểm tra radiobutton day có được click không
            if(rdoCheckDay.Checked == true)
            {
                //Lấy ra ngày hiện tại 
                DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

                //Bind lại list view dựa trên thông tin truyền vào
                BindCalendar(dateTime, dateTime);
            }
            else
            {
                //Bind tất cả dự liệu trong danh sách
                BindCalendar();
            }
        }

        private void rdoCheckWeek_CheckedChanged(object sender, EventArgs e)
        {
            //Kiểm tra radiobutton week có được click không
            if(rdoCheckWeek.Checked == true)
            {
                DateTime now = DateTime.Now;

                //Lấy ra ngày bắt của tuần hiện tại
                DateTime startOfWeek = now.AddDays(-(int)now.DayOfWeek + 1);

                //Lấy ra ngày kết thúc của tuần hiện tại
                DateTime endOfWeek = startOfWeek.AddDays(6);

                //Bind lại list view dựa trên thông tin truyền vào
                BindCalendar(startOfWeek, endOfWeek);
            }
            else 
            { 
                //Bind tất cả dự liệu trong danh sách
                BindCalendar();
            }
        }

        private void rdoCheckMonth_CheckedChanged(object sender, EventArgs e)
        {
            //Kiểm tra radiobutton Month có được click không
            if (rdoCheckMonth.Checked == true)
            {
                //Lấy ra ngày cuối cùng trong tháng hiện tại
                var lastdayofmont = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                //Lấy ra ngày đầu tiên trong tháng hiện tại
                DateTime dayStartMonth= DateTime.Parse(new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToString("dd/MM/yyyy"));

                //Lấy ra ngày cuối cùng trong tháng hiện tại
                DateTime dayEndMonth = DateTime.Parse(new DateTime(DateTime.Now.Year, DateTime.Now.Month, lastdayofmont).ToString("dd/MM/yyyy"));

                //Bind lại list view dựa trên thông tin truyền vào
                BindCalendar(dayStartMonth, dayEndMonth);
            }
            else
            {
                //Bind tất cả dự liệu trong danh sách
                BindCalendar();
            }
        }


        private void dtmEndDate_ValueChanged(object sender, EventArgs e)
        {
            rdoCheckDay.Checked = rdoCheckMonth.Checked = rdoCheckWeek.Checked = false;
            DateTime dateS = DateTime.Parse(dtmStartDate.Value.ToString("dd/MM/yyyy"));
            DateTime dateE = DateTime.Parse(dtmEndDate.Value.ToString("dd/MM/yyyy")).AddDays(1);

            //Bind lại list view dựa trên thông tin truyền vào
            BindCalendar(dateS, dateE);
        }
        private void dtmStartDate_ValueChanged(object sender, EventArgs e)
        {
            rdoCheckDay.Checked = rdoCheckMonth.Checked = rdoCheckWeek.Checked = false;
            DateTime dateS = DateTime.Parse(dtmStartDate.Value.ToString("dd/MM/yyyy"));
            DateTime dateE = DateTime.Parse(dtmEndDate.Value.ToString("dd/MM/yyyy")).AddDays(1);

            //Bind lại list view dựa trên thông tin truyền vào
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
            dtmEndDate.Value = dtmStartDate.Value = DateTime.Now;
            BindCalendarAvailable();
        }

    }
}
