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

namespace BadmintonManagement.Function.CourtService
{
    public class CourtService
    {
        private ModelBadmintonManage _modelBadmintonManage = new ModelBadmintonManage();
        private List<COURT> _courts = new ModelBadmintonManage().COURT.ToList();
        private List<BRANCH> _branchs = new ModelBadmintonManage().BRANCH.ToList();

        public void createCourt()
        {
            DateTime dateTime = new DateTime(2023,10,15);
            COURT courtSTD001 = new COURT()
            {
                CourtID = "STD001",
                CourtName = "Sân 1",
                C_Status = "Use",
                BranchID = "TD001",
                StartDate = new DateTime(2023, 10, 15),
            };
            COURT courtSTD002 = new COURT()
            {
                CourtID = "STD002",
                CourtName = "Sân 2",
                C_Status = "Used",
                BranchID = "TD001",
                StartDate = new DateTime(2023, 11, 15),
            };
            COURT courtSTD003 = new COURT()
            {
                CourtID = "STD003",
                CourtName = "Sân 3",
                C_Status = "Maintaince",
                BranchID = "TD001",
                StartDate = new DateTime(2023, 12, 15),
            };


            COURT courtSBT001 = new COURT()
            {
                CourtID = "SBT001",
                CourtName = "Sân 1",
                C_Status = "Use",
                BranchID = "BT001",
                StartDate = new DateTime(2023, 12, 17),
            };
            COURT courtSBT002 = new COURT()
            {
                CourtID = "SBT002",
                CourtName = "Sân 2",
                C_Status = "Used",
                BranchID = "BT001",
                StartDate = new DateTime(2023, 12, 27),
            };
            COURT courtSBT003 = new COURT()
            {
                CourtID = "SBT003",
                CourtName = "Sân 3",
                C_Status = "Disable",
                BranchID = "BT001",
                StartDate = new DateTime(2023, 12, 25),
            };

            if (!checkCourtID(courtSBT001.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSBT001);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkCourtID(courtSBT002.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSBT002);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkCourtID(courtSBT003.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSBT003);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkCourtID(courtSTD001.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSTD001);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkCourtID(courtSTD002.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSTD002);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkCourtID(courtSTD003.CourtID))
            {
                _modelBadmintonManage.COURT.Add(courtSTD003);
                _modelBadmintonManage.SaveChanges();
            }
        }

        public void createBranch()
        {
            BRANCH branchTD = new BRANCH()
            {
                BranchID = "TD001",
                BranchName = "Thủ Đức",
                C_Address = "Long Trường Quận 9 ",
            };

            BRANCH branchBT = new BRANCH()
            {
                BranchID = "BT001",
                BranchName = "Bình Thạnh",
                C_Address = "Gần Hutech",
            };

            if (!checkBranchID(branchTD.BranchID))
            {
                _modelBadmintonManage.BRANCH.Add(branchTD);
                _modelBadmintonManage.SaveChanges();
            }

            if (!checkBranchID(branchBT.BranchID))
            {
                _modelBadmintonManage.BRANCH.Add(branchBT);
                _modelBadmintonManage.SaveChanges();
            }
        }

        public Control DisplayCourt(int count, COURT court , double _widht , double _heigth)
        {
            double x = (_widht) / (3.4);
            double y = (_heigth) / (3.4);
            String namePnl = "pnl" + court.CourtID;
            Type controlType = typeof(Panel);
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = namePnl;

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));

            Label lblCourtName = new Label();
            lblCourtName.Text = court.CourtName;
            lblCourtName.Location = new Point(Convert.ToInt32(x * 1 / 5), 0);
            lblCourtName.TextAlign = ContentAlignment.MiddleCenter;
            lblCourtName.Size = new Size(Convert.ToInt32(x * 3 / 5), 25);

            Label lblStartDate = new Label();
            lblStartDate.Text = "Ngay HD " + court.StartDate.Value.ToString("dd/MM/yyyy");
            lblStartDate.Location = new Point(0, Convert.ToInt32(y) - Convert.ToInt32(y * 1 / 8));
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            lblStartDate.Size = new Size(Convert.ToInt32(x), 25);

            PictureBox picStatusCourt = new PictureBox();
            picStatusCourt.Image = Properties.Resources.Use;
            picStatusCourt.SizeMode = PictureBoxSizeMode.StretchImage;
            picStatusCourt.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3 / 5));
            picStatusCourt.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));

            if (court.C_Status == "Use")
            {
                picStatusCourt.Image = Properties.Resources.Use;
            }
            else if (court.C_Status == "Used")
            {
                picStatusCourt.Image = Properties.Resources.Used;
            }
            else if (court.C_Status == "Maintaince")
            {
                picStatusCourt.Image = Properties.Resources.Maintainace;
            }

            if (count > 2)
            {
                int _surplus = (int)(count / 3);
                if (count % 3 == 0)
                {
                    newControl.Location = new Point(0, Convert.ToInt32(y + y * 0.2) * _surplus);
                }
                else if (count % 3 == 1)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2), Convert.ToInt32(y + y * 0.2) * _surplus);
                }
                else if (count % 3 == 2)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2) * 2, Convert.ToInt32(y + y * 0.2) * _surplus);
                }
            }
            else
            {
                if (count == 0)
                {
                    newControl.Location = new Point(0, 0);
                }
                else if (count == 1)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2), 0);
                }
                else if (count == 2)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2) * 2, 0);
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
            List<COURT> tmp = _modelBadmintonManage.COURT.Where(p => p.C_Status != "Disable").ToList();
            //List<COURT> tmp = new List<COURT>();
            //foreach (var item in _courts)
            //{
            //    if(item.C_Status != "Disable")
            //        tmp.Add(item);
            //}
            return tmp;
        }
        public List<BRANCH> getBranch()
        {
            _branchs = new ModelBadmintonManage().BRANCH.ToList();
            return _branchs;
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
    }
}
