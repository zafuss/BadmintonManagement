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
        ModelBadmintonManage _modelbadmintonManage = new ModelBadmintonManage();
        List<RF_DETAIL> _rfDetail = new ModelBadmintonManage().RF_DETAIL.ToList();
        List<COURT> _court = new ModelBadmintonManage().COURT.ToList();
        List<RESERVATION> _reservation = new ModelBadmintonManage().RESERVATION.ToList();

        public List<RF_DETAIL> getRFDetail()    
        {
            return _rfDetail;
        }


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

            string tmp = "";
            string tmp1 = "";

            while (dataReader.Read())
            {
                tmp = String.Format("{0:HH:mm}", dataReader.GetValue(0));
                tmp1 = String.Format("{0:HH:mm}", dataReader.GetValue(1));
                listtime.Add(tmp);
                listtime.Add(tmp1);
            }
            return listtime;
        }


        public List<InfoCourt> getCourtByRF()
        {
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            string sql = @"select c.CourtID,c.CourtName,c.BranchID , c.BranchName , b.FullName, b.PhoneNumber , b.ReservationNo , b.StartTime , b.EndTime , c._Status
                            from (	select c.CourtID , c.CourtName , c.BranchID , br.BranchName, c._Status
		                            from COURT c , BRANCH br 
		                            where c.BranchID = br.BranchID and c._Status != 'Disable' ) c
                            Left Join (select rf.CourtID , tmp.FullName , tmp.PhoneNumber , rf.ReservationNo,tmp.StartTime,tmp.EndTime
			                            from RF_DETAIL rf ,		(select reser.ReservationNo , a.FullName , a.PhoneNumber , FORMAT(reser.StartTime, 'HH:mm') as StartTime , FORMAT(reser.EndTime, 'HH:mm') as EndTime
									                            from RESERVATION reser , CUSTOMER a
									                            where Cast(reser.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE) and 
									                            FORMAT(CURRENT_TIMESTAMP , 'HH:mm') < FORMAT(reser.EndTime, 'HH:mm') and 
									                            FORMAT(CURRENT_TIMESTAMP , 'HH:mm') >= FORMAT(reser.StartTime, 'HH:mm')  and 
									                            a.PhoneNumber = reser.PhoneNumber) tmp
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
                infoCourt.Status = dataReader.GetValue(9).ToString();

                listInfor.Add(infoCourt);
            }
            return listInfor;
            conn.Close();
        }


        public int getCountDetail()
        {
            return _rfDetail.Count();
        }
        public Control DisplayRFDetailUser(int count, InfoCourt infoCourt, double _widht, double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = infoCourt.CourtId +"+"+infoCourt.Reservationno;
            Type controlType = typeof(CustomPanel);
            Font font = new Font("Segoe UI", 12);

            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));


            Label lblCourtName = new Label();
            lblCourtName.Text = infoCourt.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 10);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            Label lblStartTime = new Label();
            if (infoCourt.Reservationno != string.Empty)
                lblStartTime.Text = infoCourt.Starttime;
            else
                lblStartTime.Text = "00:00";
            //lblStartTime.Text = infoCourt.Starttime;
            lblStartTime.Location = new Point(Convert.ToInt32(x * 1.5 / 12), Convert.ToInt32(y * 8 / 10));
            lblStartTime.TextAlign = ContentAlignment.MiddleLeft;
            //lblStartTime.Size = new Size(Convert.ToInt32(x), 25);

            Label lblEndTime = new Label();
            if (infoCourt.Reservationno != string.Empty)
                lblEndTime.Text = infoCourt.Endtime;
            else
                lblEndTime.Text = "00:00";
            lblEndTime.Location = new Point(Convert.ToInt32(x * 7 / 10), Convert.ToInt32(y * 8 / 10));
            Size lblEndTimeText = TextRenderer.MeasureText(lblEndTime.Text, font);
            lblEndTime.TextAlign = ContentAlignment.MiddleRight;
            lblEndTime.Size = new Size(lblEndTimeText.Width, lblEndTimeText.Height);
            //lblEndTime.Size = new Size(Convert.ToInt32(x), 25);

            CustomPicBox picStatusCourt = new CustomPicBox();
            picStatusCourt.Name = infoCourt.CourtId + "+" + infoCourt.Reservationno;
            picStatusCourt.Image = Properties.Resources.Use;
            picStatusCourt.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatusCourt.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3 / 5));
            picStatusCourt.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));

            if(infoCourt.Status == "Maintaince")
            {
                picStatusCourt.Image = Properties.Resources.Maintainace;
            }
            else
            {
                if (infoCourt.Reservationno != string.Empty)
                {
                    picStatusCourt.Image = Properties.Resources.Used;
                }
                else 
                {
                    picStatusCourt.Image = Properties.Resources.Use;
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

        public RF_DETAIL FindRFDetailByID(string idcourt,string idrf )
        {
            _modelbadmintonManage = new ModelBadmintonManage();
            RF_DETAIL rF_DETAIL = _modelbadmintonManage.RF_DETAIL.FirstOrDefault(p => p.CourtID.ToLower().Contains(idcourt.ToLower()) 
            && p.ReservationNo.ToLower().Contains(idrf));
            return rF_DETAIL;
        }

        public InfoCourt FindinforCourt(string idcourt,string idrf , List<InfoCourt> infoCourts)
        {
            InfoCourt infoCourt = infoCourts.FirstOrDefault( p => p.CourtId == idcourt && p.Reservationno == idrf);
            return infoCourt;
        }
    }
}
