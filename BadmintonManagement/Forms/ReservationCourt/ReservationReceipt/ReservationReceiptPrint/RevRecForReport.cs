using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public class RevRecForReport
    {
        public string ReceiptNo { get; set; }
        public DateTime? C_Date { get; set; }
        public decimal? Total { get; set; }
        public double? ExtraTime { get; set; }
        public string ReservationNo { get; set; }
        public string Username { get; set; }
        public decimal? RealChagre { get; set; }
        public decimal? ExtraFee { get; set; }
    }
}
