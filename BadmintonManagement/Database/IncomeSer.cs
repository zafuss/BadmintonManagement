using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class IncomeSer
    {
        private decimal perCourt;
        private decimal perSer;

        public IncomeSer()
        {
        }

        public decimal PerCourt { get => perCourt; set => perCourt = value; }
        public decimal PerSer { get => perSer; set => perSer = value; }
    }
}
