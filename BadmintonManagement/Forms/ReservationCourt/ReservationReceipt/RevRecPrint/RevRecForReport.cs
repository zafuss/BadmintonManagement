using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public class RevRecForReport
    {
        public string ServiceReceiptNo { get; set; }

        public DateTime? CreateDate { get; set; }

        public decimal? Total { get; set; }

        public string PhoneNumber { get; set; }

        public string Username { get; set; }

        public decimal? RealChagre { get; set; }
    }
}
