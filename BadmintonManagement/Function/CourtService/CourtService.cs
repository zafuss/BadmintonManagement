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
        private List<COURT> _courts = new ModelBadmintonManage().COURTs.ToList();
        private List<BRANCH> _branchs = new ModelBadmintonManage().BRANCHes.ToList();

        public ModelBadmintonManage getModelBadmintonManage()
        {
            return _modelBadmintonManage;
        }

        public void InsertCourt(COURT newCourt)
        {
            _modelBadmintonManage.COURTs.AddOrUpdate(newCourt);
            _modelBadmintonManage.SaveChanges();
        }

        public List<COURT> getListCourt()
        {
            return _courts;
        }

        public List<BRANCH> getBranch()
        {
            return _branchs;
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
            COURT court = _modelBadmintonManage.COURTs.FirstOrDefault(p => p.CourtID.ToLower().Contains(courtID.ToLower()));
            if (court == null)
                return false;
            return true;
        }

        public COURT FindCourtByID(string id)
        {
            COURT court = _modelBadmintonManage.COURTs.FirstOrDefault(p => p.CourtID.ToLower().Contains(id.ToLower()));
            return court;
        }

    }
}
