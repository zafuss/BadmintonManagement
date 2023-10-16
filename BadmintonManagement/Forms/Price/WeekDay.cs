using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.Price
{
    [Serializable]
    public class WeekDay
    {
        public WeekDay() { }

        public DayOfWeek Day { get; set; }
    }
}
