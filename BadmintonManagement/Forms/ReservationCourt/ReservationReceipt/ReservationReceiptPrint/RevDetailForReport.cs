using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public class RevDetailForReport
    {
        public string ReservationNo { get; set; }
        public string CourtID { get; set; }
        public string Note { get; set; }
        public string CourtName { get; set; }
        public decimal? PriceTag { get; set; }
        public decimal? Total { get; set; }
    }
}
