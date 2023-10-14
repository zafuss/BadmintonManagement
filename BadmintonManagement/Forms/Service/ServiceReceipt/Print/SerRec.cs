using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.Service.ServiceReceipt.Print
{
    public class SerRec
    {
        public string ServiceReceiptNo { get; set; }
        public DateTime? CreateDate { get; set; }
        public decimal? Total { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
    }
}
