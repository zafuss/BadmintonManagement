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
        //Khởi Tạo một đối tượng modelbadminton
        private ModelBadmintonManage _modelBadmintonManage = new ModelBadmintonManage();
        //Tạo một List court chứa thông tin từ đối tượng model
        private List<COURT> _courts = new ModelBadmintonManage().COURT.ToList();
        //Tạo một List branch chứa thông tin từ đối tượng model
        private List<BRANCH> _branchs = new ModelBadmintonManage().BRANCH.ToList();

        public void publicDay()
        {
            //COURT cOURT = new COURT();
            //for ( int i = 0 ; i < _courts.Count ; i++ )
            //{
            //    if(_courts[i].StartDate > DateTime.Now ) 
            //    {
            //        cOURT = _courts[i];
            //        cOURT.C_Status = "Available";
            //        _modelBadmintonManage.COURT.AddOrUpdate(cOURT);
            //    }

            //     if (String.Format("{0:dd:MM:yyyy}", _courts[i].StartDate) == DateTime.Now.ToString("dd:MM:yyyy"))
            //    {
            //        cOURT = _courts[i];
            //        cOURT.C_Status = "Using";
            //        _modelBadmintonManage.COURT.AddOrUpdate(cOURT);
            //    }
            //}
            //_modelBadmintonManage.SaveChanges();
        }

        //Hàm để hiện thị sân dựa
        public Control DisplayCourtAdmin(int count, COURT court , double _widht , double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = court.CourtID;
            Font font = new Font("Segoe UI", 12);
            //Tạo một custompanel để chứa các control
            Type controlType = typeof(CustomPanel);
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;  

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));

            //Tạo một label để hiện thị Tên Sân
            Label lblCourtName = new Label();
            lblCourtName.Text = court.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 10);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            //Tạo một label để hiện thị ngày hoạt động của sân
            Label lblStartDate = new Label();
            lblStartDate.Text = "Ngay HD " + court.StartDate.Value.ToString("dd/MM/yyyy");
            lblStartDate.Location = new Point(Convert.ToInt32(x * 1 / 10), Convert.ToInt32(y * 4.2 / 5));
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            Size lblStartDateText = TextRenderer.MeasureText(lblStartDate.Text, font); 
            lblStartDate.Size = new Size(Convert.ToInt32(x*4/5), lblStartDateText.Height);
            //lblStartDate.Size = new Size(lblStartDateText.Width, lblStartDateText.Height);

            //Tạo một picturebox để hiện thị sân
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

        //Hàm trả về đối tượng badmintonmodel
        public ModelBadmintonManage getModelBadmintonManage()
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            return _modelBadmintonManage;
        }

        //Hàm để thêm mới một đối tượng court vào cơ sở dữ liệu
        public void InsertCourt(COURT newCourt)
        {
            _modelBadmintonManage.COURT.AddOrUpdate(newCourt);
            _modelBadmintonManage.SaveChanges();
        }

        //Hàm trả về tất cả các sân từ cơ sở dữ liệu
        public List<COURT> getListCourt()
        {
            return _courts;
        }

        //Hàm trả về các sân đang hoạt động từ cơ sở dữ liệu
        public List<COURT> getListCourtWithOutDisable()
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _modelBadmintonManage.COURT.Where(p => p.C_Status != "Disable" ).ToList();
            return tmp;
        }

        //Hàm trả về tên các sân dựa theo biến truyền vào 
        public List<COURT> getListNameCourt(string name)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _courts.Where(p => p.C_Status != "Disable" && p.CourtName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >=0 ).ToList();
            return tmp;
        }

        //Hàm trả về tên các nhánh dựa theo biến truyền vào 
        public List<COURT> getBranchName(string name)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            List<COURT> tmp = _courts.Where(p => p.C_Status != "Disable" && p.BRANCH.BranchName.Equals(name,StringComparison.OrdinalIgnoreCase)).ToList();
            return tmp;
        }

        //Hàm trả về tất cả các nhánh có trong cơ sở dữ liệu
        public List<BRANCH> getBranch()
        {
            _branchs = new ModelBadmintonManage().BRANCH.ToList();
            return _branchs;
        }

        //Hàm Lấy ra tất cả các tên nhánh có trong danh sách
        public List<String> getBrachName()
        {
            List<String> tmp = new List<String>();
            foreach ( BRANCH item in _branchs )
            {
                tmp.Add(item.BranchName);
            }
            return tmp;
        }

        //Hàm trả về số lượng sân có trong cơ sở dữ liệu
        public int getCountCourt()
        {
            _courts = new ModelBadmintonManage().COURT.ToList();
            return _courts.Count();
        }

        //Hàm trả về số lượng sân khả dụng trong cơ sở dữ liệu
        public int getCountCourtDisable()
        {
            return getListCourtWithOutDisable().Count();
        }

        //Hàm trả về Mã sân dựa theo tên truyền vào
        public string GetBranchID(string branchName)
        {
            _branchs = new ModelBadmintonManage().BRANCH.ToList();

            BRANCH tmp = _branchs.FirstOrDefault(p => p.BranchName.Equals(branchName));
            return tmp.BranchID;
        }

        //Hàm chuyển đổi UTF16 thành UTF8
        public string RemoveDiacritics(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
               .Replace('đ', 'd').Replace('Đ', 'D');
        }

        //Hàm sinh tự động mã sân
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

        //Hàm Kiểm tra mã sân có trong cơ sở dữ liệu không
        public bool checkCourtID(string courtID)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(courtID.ToLower()));
            if (court == null)
                return false;
            return true;
        }

        //Hàm kiểm tra nhánh có trong cơ sở dữ liệu không
        public bool checkBranchID(string courtID)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(courtID.ToLower()));
            if (branch == null)
                return false;
            return true;
        }

        //Hàm tìm kiếm Mã sân 
        public COURT FindCourtByID(string id)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(id.ToLower()));
            return court;
        }

        //Hàm tìm kiếm nhánh
        public BRANCH FindBranchByID(string id)
        {
            _modelBadmintonManage = new ModelBadmintonManage();
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(id.ToLower()));
            return branch;
        }

        //Hàm trả về số lượng thời gian đặt sân trong danh sách
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
