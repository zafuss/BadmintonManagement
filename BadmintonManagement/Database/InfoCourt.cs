using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class InfoCourt
    {
        private string _courtId;
        private string _courtName;
        private string _status;
        private string _nameCustom;
        private string _phonenumber;
        private string _branhId;
        private string _branhName;
        private DateTime _starttime;
        private DateTime _endtime;

        public string CourtId { get => _courtId; set => _courtId = value; }
        public string CourtName { get => _courtName; set => _courtName = value; }
        public string Status { get => _status; set => _status = value; }
        public string NameCustom { get => _nameCustom; set => _nameCustom = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }
        public string BranhId { get => _branhId; set => _branhId = value; }
        public string BranhName { get => _branhName; set => _branhName = value; }
        public DateTime Starttime { get => _starttime; set => _starttime = value; }
        public DateTime Endtime { get => _endtime; set => _endtime = value; }
    }
}
