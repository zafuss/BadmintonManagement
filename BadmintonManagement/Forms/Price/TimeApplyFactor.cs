using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.Price
{
    [Serializable]
    public class TimeApplyFactor
    {
        public TimeApplyFactor() { }

        public int NumericOrder {  get; set; }
        public int StartTime { get; set; }

        public int EndTime { get; set; }
    }
}
