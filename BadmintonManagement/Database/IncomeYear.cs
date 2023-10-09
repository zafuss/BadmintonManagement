using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class IncomeYear
    {
        private int year;
        private decimal tatol;

        public IncomeYear()
        {
        }

        public int Year { get => year; set => year = value; }
        public decimal Tatol { get => tatol; set => tatol = value; }
    }
}
