using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonManagement.Custom;

namespace BadmintonManagement.Database
{
    public class RFDetailService
    {
        ModelBadmintonManage _modelbadmintonManage = new ModelBadmintonManage();
        List<RF_DETAIL> _rfDetail = new ModelBadmintonManage().RF_DETAIL.ToList();

        public List<RF_DETAIL> getRFDetail()
        {
            return _rfDetail;
        }

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


            if (rf_detail.COURT.C_Status == "Use")
            {
                picStatusCourt.Image = Properties.Resources.Use;
            }
            else if (rf_detail.COURT.C_Status == "Used")
            {
                picStatusCourt.Image = Properties.Resources.Used;
            }
            else if (rf_detail.COURT.C_Status == "Maintaince")
            {
                picStatusCourt.Image = Properties.Resources.Maintainace;
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
