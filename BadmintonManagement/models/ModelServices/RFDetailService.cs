using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonManagement.Custom;
using System.Data.SqlClient;
using FireSharp.Extensions;

namespace BadmintonManagement.Database
{
    public class RFDetailService
    {
        //Khởi Tạo một đối tượng modelbadminton
        ModelBadmintonManage _modelbadmintonManage = new ModelBadmintonManage();
        //Tạo một List rfdetail chứa thông tin từ đối tượng model
        List<RF_DETAIL> _rfDetail = new ModelBadmintonManage().RF_DETAIL.ToList();

        //Hàm trả về danh sách rf detail
        public List<RF_DETAIL> getRFDetail()    
        {
            return _rfDetail;
        }

        //Hàm lấy ra một danh sách thời gian hiện tại dựa trên lịch đặt sân
        public HashSet<string> getListTimeinDay()
        {
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            string sql = @"select FORMAT(rf.StartTime, 'HH:mm:ss') as StartTime , FORMAT(rf.EndTime, 'HH:mm:ss') as EndTime
                            from RESERVATION rf
                            where Cast(rf.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) 
		                            and FORMAT(CURRENT_TIMESTAMP , 'HH:mm:ss') <= FORMAT(rf.EndTime, 'HH:mm:ss')";
            SqlConnection conn;
            conn = new SqlConnection(connectString);
            conn.Open();    

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            HashSet<string> listtime = new HashSet<string>();

            string starttime = "";
            string endtime = "";

            while (dataReader.Read())
            {
                starttime = String.Format("{0:HH:mm}", dataReader.GetValue(0));
                endtime = String.Format("{0:HH:mm}", dataReader.GetValue(1));
                listtime.Add(starttime);
                listtime.Add(endtime);
            }
            return listtime;
        }

        //Hàm trả về một class info court
        public List<InfoCourt> getCourtByRF()
        {
            //tên máy và tên database
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            //Câu lệnh truy vấn sql để lấy ra thông tin
            string sql = @"select c.CourtID,c.CourtName,c.BranchID , c.BranchName , b.FullName, b.PhoneNumber , b.ReservationNo , b.StartTime , b.EndTime  , b._Status , CASE 
																																				When c._Status = 'Maintenance' then 'Maintenance'
																																				When b.ReservationNo is NULL then 'Available'
																																				When b.ReservationNo is not NULL then 'Using'
																																				When b._Status = 3 then 'OvTime'
																																				END as Status
                            from (	select c.CourtID , c.CourtName , c.BranchID , br.BranchName, c._Status
		                            from COURT c , BRANCH br 
		                            where c.BranchID = br.BranchID and c._Status != 'Available' and c._Status != 'Disable') c
                            Left Join (select rf.CourtID , tmp.FullName , tmp.PhoneNumber , rf.ReservationNo,tmp.StartTime,tmp.EndTime , tmp._Status
			                            from RF_DETAIL rf ,		(select reser.ReservationNo , a.FullName , a.PhoneNumber , FORMAT(reser.StartTime, 'HH:mm') as StartTime , 
																FORMAT(reser.EndTime, 'HH:mm') as EndTime , reser._Status
																from RESERVATION reser , CUSTOMER a
																where (Cast(reser.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) and 
																FORMAT(CURRENT_TIMESTAMP , 'HH:mm') < FORMAT(reser.EndTime, 'HH:mm') and 
																FORMAT(CURRENT_TIMESTAMP , 'HH:mm') >= FORMAT(reser.StartTime, 'HH:mm')  and 
																a.PhoneNumber = reser.PhoneNumber) or (a.PhoneNumber = reser.PhoneNumber and reser._Status = 3 )) tmp
			                            where rf.ReservationNo = tmp.ReservationNo
			                            )  b 
                            on b.CourtID = c.CourtID";

            SqlConnection conn;
            conn = new SqlConnection(connectString);
            conn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();

            List<InfoCourt> listInfor = new List<InfoCourt>();
            InfoCourt infoCourt = new InfoCourt();
            //Lấy dự liệu từ cơ sơ dữ liệu truyền vào list infocourt
            while (dataReader.Read())
            {
                infoCourt = new InfoCourt();
                infoCourt.CourtId = dataReader.GetValue(0).ToString();
                infoCourt.CourtName = dataReader.GetValue(1).ToString();
                infoCourt.BranhId = dataReader.GetValue(1).ToString();
                infoCourt.BranhName = dataReader.GetValue(3).ToString();
                infoCourt.NameCustom = dataReader.GetValue(4).ToString();
                infoCourt.Phonenumber = dataReader.GetValue(5).ToString();
                infoCourt.Reservationno = dataReader.GetValue(6).ToString();
                infoCourt.Starttime = dataReader.GetValue(7).ToString();
                infoCourt.Endtime =  dataReader.GetValue(8).ToString();
                infoCourt.StatusOV = dataReader.GetValue(9).ToString();
                infoCourt.Status = dataReader.GetValue(10).ToString();
                listInfor.Add(infoCourt);
            }
            return listInfor;
        }

        //Hàm đếm số lượng rf detail trong cơ sở dữ liệu
        public int getCountDetail()
        {
            return _rfDetail.Count();
        }

        //Hàm để hiện thị sân của nhân viên
        public Control DisplayRFDetailUser(int count, InfoCourt infoCourt, double _widht, double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = infoCourt.CourtId +"+"+infoCourt.Reservationno;
            Type controlType = typeof(CustomPanel);
            Font font = new Font("Segoe UI", 12);
            //Tạo một custompanel để chứa các control
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;
            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));

            //Tạo một label để chứa tên sân
            Label lblCourtName = new Label();
            lblCourtName.Text = infoCourt.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 10);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            //Tạo một label để chứa thời gian bắt đầu
            Label lblStartTime = new Label();
            //Nếu sân đó có phiếu đặt sân 
            if (infoCourt.Reservationno != string.Empty)
                //Thì lấy thời gian bắt đầu trong cơ sở dữ liệu
                lblStartTime.Text = infoCourt.Starttime;
            else
                //Nếu không có thì để thời gian là 00:00
                lblStartTime.Text = "00:00";
            //lblStartTime.Text = infoCourt.Starttime;
            lblStartTime.Location = new Point(Convert.ToInt32(x * 1.5 / 12), Convert.ToInt32(y * 8 / 10));
            lblStartTime.TextAlign = ContentAlignment.MiddleLeft;
            //lblStartTime.Size = new Size(Convert.ToInt32(x), 25);

            //Tạo một label để chứa tên sân
            Label lblEndTime = new Label();
            //Nếu sân đó có phiếu đặt sân 
            if (infoCourt.Reservationno != string.Empty)
                //Thì lấy thời gian kết thúc trong cơ sở dữ liệu
                lblEndTime.Text = infoCourt.Endtime;
            else
                //Nếu không có thì để thời gian là 00:00
                lblEndTime.Text = "00:00";
            lblEndTime.Location = new Point(Convert.ToInt32(x * 7 / 10), Convert.ToInt32(y * 8 / 10));
            Size lblEndTimeText = TextRenderer.MeasureText(lblEndTime.Text, font);
            lblEndTime.TextAlign = ContentAlignment.MiddleRight;
            lblEndTime.Size = new Size(lblEndTimeText.Width, lblEndTimeText.Height);
            //lblEndTime.Size = new Size(Convert.ToInt32(x), 25);

            //Tạo một picturebox để chứa hình sân
            CustomPicBox picStatusCourt = new CustomPicBox();
            picStatusCourt.Name = infoCourt.CourtId + "+" + infoCourt.Reservationno;
            //picStatusCourt.Image = Properties.Resources.Use;
            picStatusCourt.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatusCourt.Size = new Size(Convert.ToInt32(x *  3 / 5), Convert.ToInt32(y * 2.5 / 5));
            picStatusCourt.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));
            picStatusCourt.BorderStyle = BorderStyle.None;
            picStatusCourt.BorderColor = Color.Transparent;

            if(infoCourt.Status == "Maintenance")
            {
                picStatusCourt.Image = Properties.Resources.badminton_court_maintenance;
            }
            else
            {
                if (infoCourt.StatusOV == "3" || infoCourt.Status == "OvTime")
                {
                    picStatusCourt.Image = Properties.Resources.badminton_court_timeout;
                }
                else if (infoCourt.Status == "Using" )
                {
                    picStatusCourt.Image = Properties.Resources.badminton_court_using;
                }
                else 
                {
                    picStatusCourt.Image = Properties.Resources.badminton_court_available;
                }
            }
            
            if (count > 2)
            {
                int _surplus = (int)(count / 3);
                if (count % 3 == 0)
                {
                    newControl.Location = new Point(10, Convert.ToInt32(y + y * 0.2) * _surplus);
                }
                else if (count % 3 == 1)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2), Convert.ToInt32(y + y * 0.2) * _surplus);
                }
                else if (count % 3 == 2)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2 - 10) * 2, Convert.ToInt32(y + y * 0.2) * _surplus);
                }
            }
            else
            {
                if (count == 0)
                {
                    newControl.Location = new Point(10, 0);
                }
                else if (count == 1)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2), 0);
                }
                else if (count == 2)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2 - 10) * 2, 0);
                }
            }

            newControl.Controls.Add(lblStartTime);
            newControl.Controls.Add(lblEndTime);
            newControl.Controls.Add(lblCourtName);
            newControl.Controls.Add(picStatusCourt);


            return newControl;
        }

        //Hàm trả về một rf detail dựa trên mã sân và mã rf
        public RF_DETAIL FindRFDetailByID(string idcourt,string idrf )
        {
            _modelbadmintonManage = new ModelBadmintonManage();
            RF_DETAIL rF_DETAIL = _modelbadmintonManage.RF_DETAIL.FirstOrDefault(p => p.CourtID.ToLower().Contains(idcourt.ToLower()) 
            && p.ReservationNo.ToLower().Contains(idrf));
            return rF_DETAIL;
        }

        //Hàm trả về List rf detail dựa trên mã sân và mã rf
        public InfoCourt FindinforCourt(string idcourt,string idrf , List<InfoCourt> infoCourts)
        {
            InfoCourt infoCourt = infoCourts.FirstOrDefault( p => p.CourtId == idcourt && p.Reservationno == idrf);
            return infoCourt;
        }
    }
}
