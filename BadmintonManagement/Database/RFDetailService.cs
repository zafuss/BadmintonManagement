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


        private Dictionary<string, List<string>> getListRFinDay()
        {
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";

            string sql = @"select * from RESERVATION rf
                           where Cast(rf.StartTime as Date) = Cast(CURRENT_TIMESTAMP  as DATE)";
            SqlConnection conn;
            conn = new SqlConnection(connectString);
            conn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>() { };

            string tmp = "";
            string tmp1 = "";

            while (dataReader.Read())
            {
                tmp = String.Format("{0:HH:mm}", dataReader.GetValue(5));
                tmp1 = String.Format("{0:HH:mm}", dataReader.GetValue(6));
                if (!keyValuePairs.ContainsKey(tmp))
                    keyValuePairs.Add(tmp, new List<string>());
                keyValuePairs[tmp].Add(dataReader.GetValue(0).ToString());

                if (!keyValuePairs.ContainsKey(tmp1))
                    keyValuePairs.Add(tmp1, new List<string>());
                keyValuePairs[tmp1].Add(dataReader.GetValue(0).ToString());

            }
            return  keyValuePairs;
        }


        //private List<InfoCourt> getCourtByRF()
        //{
        //    Dictionary<string, List<string>> keyValuePairs = getListRFinDay();
        //    List<InfoCourt> infoCourts = new List<InfoCourt>();
        //    List<string> listRV = new List<string>();
        //    List<RF_DETAIL> rF_DETAILs = new List<RF_DETAIL>();
        //    foreach (var item in keyValuePairs)
        //    {
        //        string tmp = String.Format("{0:HH:mm}", DateTime.Now);
        //        if (item.Key == tmp)
        //        {
        //            foreach (var item1 in keyValuePairs[item.Key])
        //            {
        //                listRV.Add(item1);
        //            }
        //        }
        //    }

        //    foreach(var item in _rfDetail) 
        //    {
                
        //    }

        //}


        public int getCountDetail()
        {
            return _rfDetail.Count();
        }
        public Control DisplayRFDetailUser(int count, RF_DETAIL rf_detail, double _widht, double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = rf_detail.COURT.CourtID + "+" + rf_detail.ReservationNo;
            Type controlType = typeof(CustomPanel);
            Font font = new Font("Segoe UI", 12);

            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));


            Label lblCourtName = new Label();
            lblCourtName.Text = rf_detail.COURT.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 10);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            Label lblStartTime = new Label();
            
            lblStartTime.Location = new Point(Convert.ToInt32(x * 1 / 12), Convert.ToInt32(y * 8 / 10));
            lblStartTime.TextAlign = ContentAlignment.MiddleCenter;
            //lblStartTime.Size = new Size(Convert.ToInt32(x), 25);

            Label lblEndTime = new Label();
            
            lblEndTime.Location = new Point(Convert.ToInt32(x * 6 / 10), Convert.ToInt32(y * 8 / 10));
            Size lblEndTimeText = TextRenderer.MeasureText(lblEndTime.Text, font);
            lblEndTime.TextAlign = ContentAlignment.MiddleCenter;
            lblEndTime.Size = new Size(lblEndTimeText.Width, lblEndTimeText.Height);
            //lblEndTime.Size = new Size(Convert.ToInt32(x), 25);

            CustomPicBox picStatusCourt = new CustomPicBox();
            picStatusCourt.Name = rf_detail.COURT.CourtID + "+" + rf_detail.ReservationNo;
            picStatusCourt.Image = Properties.Resources.Use;
            picStatusCourt.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatusCourt.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3 / 5));
            picStatusCourt.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));

            if(rf_detail.COURT.C_Status == "Maintaince")
            {
                picStatusCourt.Image = Properties.Resources.Maintainace;
            }
            else
            {
                if (rf_detail.RESERVATION.StartTime <= DateTime.Now && rf_detail.RESERVATION.EndTime >= DateTime.Now)
                {
                    picStatusCourt.Image = Properties.Resources.Use;
                }
                else 
                {
                    picStatusCourt.Image = Properties.Resources.Used;
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
    }
}
