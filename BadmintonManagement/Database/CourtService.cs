using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BadmintonManagement.Custom;
using System.Data.SqlClient;

namespace BadmintonManagement.Database
{
    public class CourtService
    {
        private ModelBadmintonManage _modelBadmintonManage = new ModelBadmintonManage();
        private List<COURT> _courts = new ModelBadmintonManage().COURT.ToList();
        private List<BRANCH> _branchs = new ModelBadmintonManage().BRANCH.ToList();

        public void publicDay()
        {
            COURT cOURT = new COURT();
            for ( int i = 0 ; i < _courts.Count ; i++ )
            {
                if(_courts[i].StartDate > DateTime.Now ) 
                {
                    cOURT = _courts[i];
                    cOURT.C_Status = "Available";
                    _modelBadmintonManage.COURT.AddOrUpdate(cOURT);
                }
                else if (String.Format("{0:dd:MM:yyyy}", _courts[i].StartDate) == DateTime.Now.ToString("dd:MM:yyyy"))
                {
                    cOURT = _courts[i];
                    cOURT.C_Status = "Using";
                    _modelBadmintonManage.COURT.AddOrUpdate(cOURT);
                }
            }
            _modelBadmintonManage.SaveChanges();
        }
        public Control DisplayCourtAdmin(int count, COURT court , double _widht , double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = court.CourtID;
            Font font = new Font("Segoe UI", 12);
            Type controlType = typeof(CustomPanel);
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;  

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));



            Label lblCourtName = new Label();
            lblCourtName.Text = court.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 10);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            Label lblStartDate = new Label();
            
            lblStartDate.Text = "Ngay HD " + court.StartDate.Value.ToString("dd/MM/yyyy");
            lblStartDate.Location = new Point(Convert.ToInt32(x * 1 / 10), Convert.ToInt32(y * 4.2 / 5));
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            Size lblStartDateText = TextRenderer.MeasureText(lblStartDate.Text, font); 
            lblStartDate.Size = new Size(Convert.ToInt32(x*4/5), lblStartDateText.Height);
            //lblStartDate.Size = new Size(lblStartDateText.Width, lblStartDateText.Height);

            CustomPicBox picStatusCourt = new CustomPicBox();
            picStatusCourt.Name = court.CourtID;
            //picStatusCourt.Image = Properties.Resources.Use;
            picStatusCourt.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatusCourt.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 2.5 / 5));
            picStatusCourt.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));
            picStatusCourt.BorderStyle = BorderStyle.None;
            picStatusCourt.BorderColor = Color.Transparent;

            if (court.C_Status == "Using")
            {
                picStatusCourt.Image = Properties.Resources.badminton_court_using;
            }
            else if (court.C_Status == "Available")
            {
                picStatusCourt.Image = Properties.Resources.badminton_court_available;
            }
            else if (court.C_Status == "Maintenance")
            {
                picStatusCourt.Image = Properties.Resources.badminton_court_maintenance;
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
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2-10) * 2, Convert.ToInt32(y + y * 0.2) * _surplus);
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
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2-10) * 2, 0);
                }
            }

            newControl.Controls.Add(lblStartDate);
            newControl.Controls.Add(lblCourtName);
            newControl.Controls.Add(picStatusCourt);


            return newControl;
        }

        public ModelBadmintonManage getModelBadmintonManage()
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            return _modelBadmintonManage;
        }

        public void InsertCourt(COURT newCourt)
        {
            _modelBadmintonManage.COURT.AddOrUpdate(newCourt);
            _modelBadmintonManage.SaveChanges();
        }

        public List<COURT> getListCourt()
        {
            return _courts;
        }

        public List<COURT> getListCourtWithOutDisable()
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _modelBadmintonManage.COURT.Where(p => p.C_Status != "Disable" || p.C_Status != "Available").ToList();
            return tmp;
        }

        public List<COURT> getListNameCourt(string name)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _courts.Where(p => p.C_Status != "Disable" && p.CourtName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >=0 ).ToList();
            return tmp;
        }

        public List<COURT> getBranchName(string name)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _courts.Where(p => p.C_Status != "Disable" && p.BRANCH.BranchName.Equals(name,StringComparison.OrdinalIgnoreCase)).ToList();
            return tmp;
        }

        public List<BRANCH> getBranch()
        {
            _branchs = new ModelBadmintonManage().BRANCH.ToList();
            return _branchs;
        }

        public List<String> getBrachName()
        {
            List<String> tmp = new List<String>();
            foreach ( BRANCH item in _branchs )
            {
                tmp.Add(item.BranchName);

            }
            return tmp;
        }

        public int getCountCourt()
        {
            _courts = new ModelBadmintonManage().COURT.ToList();
            return _courts.Count();
        }
        public int getCountCourtDisable()
        {
            return getListCourtWithOutDisable().Count();
        }

        public string GetBranchID(string branchName)
        {
            _branchs = new ModelBadmintonManage().BRANCH.ToList();

            BRANCH tmp = _branchs.FirstOrDefault(p => p.BranchName.Equals(branchName));
            return tmp.BranchID;
        }

        public string RemoveDiacritics(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
               .Replace('đ', 'd').Replace('Đ', 'D');
        }

        public string GetCourtID(string branchname)
        {
            string pattern = @"\b\w";
            string CourtID = "S";
            MatchCollection matchCollection = Regex.Matches(branchname, pattern);
            foreach (Match item in matchCollection)
            {
                CourtID += RemoveDiacritics(item.Value.ToUpper());
            }
            string brId = GetBranchID(branchname);
            CourtID += (_courts.Count(p => p.BranchID == brId) + 1).ToString("D3");
            return CourtID;
        }

        public bool checkCourtID(string courtID)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(courtID.ToLower()));
            if (court == null)
                return false;
            return true;
        }
        public bool checkBranchID(string courtID)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(courtID.ToLower()));
            if (branch == null)
                return false;
            return true;
        }

        public COURT FindCourtByID(string id)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(id.ToLower()));
            return court;
        }

        public BRANCH FindBranchByID(string id)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(id.ToLower()));
            return branch;
        }

        public int CountCourt( string id)
        {
            string connectString = @"Data Source=localhost;Initial Catalog=BadmintonManagementDB;Integrated Security=True";
            string sql = @"select rf.CourtID
                        from RF_DETAIL rf 
                        where rf.ReservationNo in (select re.ReservationNo 
					                        from RESERVATION re 
					                        where Cast(re.StartTime as Date) >= Cast(CURRENT_TIMESTAMP  as DATE) )
                        and rf.CourtID = @_idcourt";
            SqlConnection conn;
            conn = new SqlConnection(connectString);
            conn.Open();

            SqlCommand cmd;
            SqlDataReader dataReader;

            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@_idcourt", id);
            cmd.ExecuteNonQuery();
            dataReader = cmd.ExecuteReader();
            int count = 0;
            while (dataReader.Read())
            {
                count++;
            }
            return count;
        }
    }
}
