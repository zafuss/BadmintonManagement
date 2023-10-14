using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public class RevForReport
    {      
        public string ReservationNo { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public decimal? Deposite { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string PriceID { get; set; }
        public int? C_Status { get; set; }
    }
}
