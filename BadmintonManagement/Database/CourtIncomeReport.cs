using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class CourtIncomeReport
    {
        private string receiptNo;
        private string createDate;
        private string phoneNumber;
        private string fullName;
        private string EmployeeName;
        private decimal total;

        public CourtIncomeReport()
        {
        }

        public string ReceiptNo { get => receiptNo; set => receiptNo = value; }
        public string CreateDate { get => createDate; set => createDate = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string EmployeeName1 { get => EmployeeName; set => EmployeeName = value; }
        public decimal Total { get => total; set => total = value; }
    }
}
