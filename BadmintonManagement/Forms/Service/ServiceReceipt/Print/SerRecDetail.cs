using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.Service.ServiceReceipt.Print
{
    public class SerRecDetail
    {
        public string ServiceReceiptNo { get; set; }
        public string ServiceID { get; set; }
        public int? Quantity { get; set; }
        public string ServiceName { get; set; }
        public decimal? Total { get; set; }
    }
}