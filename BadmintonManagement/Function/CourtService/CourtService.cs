using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        public ModelBadmintonManage getModelBadmintonManage()
        {
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
            return _branchs;
        }

        public int getCountCourt()
        {
            return _courts.Count();
        }
        public int getCountCourtDisable()
        {
            return getListCourtWithOutDisable().Count();
        }

        public string GetBranchID(string branchName)
        {
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
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(courtID.ToLower()));
            if (court == null)
                return false;
            return true;
        }
        public bool checkBranchID(string courtID)
        {
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(courtID.ToLower()));
            if (branch == null)
                return false;
            return true;
        }

        public COURT FindCourtByID(string id)
        {
            COURT court = _modelBadmintonManage.COURT.FirstOrDefault(p => p.CourtID.ToLower().Contains(id.ToLower()));
            return court;
        }

        public BRANCH FindBranchByID(string id)
        {
            BRANCH branch = _modelBadmintonManage.BRANCH.FirstOrDefault(p => p.BranchID.ToLower().Contains(id.ToLower()));
            return branch;
        }
    }
}
