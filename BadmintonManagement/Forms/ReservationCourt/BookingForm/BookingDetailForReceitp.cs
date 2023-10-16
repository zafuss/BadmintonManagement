using BadmintonManagement.Forms.Price;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Forms.ReservationCourt.BookingForm
{
    [Serializable]
    public class BookingDetailForReceitp
    {
        public BookingDetailForReceitp() { }
        public string ReservationNo { get; set; }
        public decimal Total { get; set; }
        public string PriceID {  get; set; }
        public List<TimeApplyFactor> TFactor { get; set; }
        public List<WeekDay> WDay { get; set; }
    }
}
