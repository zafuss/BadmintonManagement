using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public partial class RevReceiptPrint : Form
    {
        public RevReceiptPrint()
        {
            InitializeComponent();
        }
        string reservationNo;
        public RevReceiptPrint(string reservationNo)
        {
            InitializeComponent();
            this.reservationNo = reservationNo;
        }

        private void RevRecPrint_Load(object sender, EventArgs e)
        {
            ShowReport();
            this.rpvPrint.RefreshReport();
        }
        private void ShowReport()
        {
            ModelBadmintonManage context = new ModelBadmintonManage();
            string sql = @"select r.ReservationNo,r.Username,r.PhoneNumber,r.Deposite,r.CreateDate,r.BookingDate,r.StartTime,r.EndTime,r.PriceID,r._Status,c.FullName
                            from RESERVATION r left join CUSTOMER c on r.PhoneNumber = c.PhoneNumber
                            where ReservationNo =" + @"'" + reservationNo + @"'";
            List<RevForReport> listRFR = context.Database.SqlQuery<RevForReport>(sql).ToList();
            var RFRDS = new ReportDataSource("RevForReport", listRFR);
            sql = @"select r.ReservationNo,c.CourtID,r.Note,c.CourtName,p.PriceTag, cast((Round((DATEDIFF(MINUTE,e.StartTime,e.EndTime)*p.PriceTag/60),0,0)) as decimal(9,0)) as[Total]
                    from ((RF_DETAIL r inner join RESERVATION e on r.ReservationNo = e.ReservationNo) inner join COURT c on r.CourtID = c.CourtID) inner join PRICE p on e.PriceID = p.PriceID
                    where r.ReservationNo =" + @"'" + reservationNo + @"'";
            List<RevDetailForReport> listRDFR = context.Database.SqlQuery<RevDetailForReport>(sql).ToList() ;
            var RDFRDS = new ReportDataSource("RevDetailForReport", listRDFR);
            sql = @"select r.ReceiptNo,r._Date,r._Date,r.Total,r.ExtraTime,e.ReservationNo,r.Username,(r.Total - e.Deposite) as[RealChagre],Cast(Round((r.ExtraTime*p.PriceTag),0)as decimal)
                    from (RECEIPT r inner join RESERVATION e on r.ReservationNo = e.ReservationNo) inner join PRICE p on e.PriceID = p.PriceID
                    where r.ReservationNo =" + @"'" + reservationNo + @"'";
            List<RevRecForReport> listRRFR = context.Database.SqlQuery<RevRecForReport>(sql).ToList();
            var RRFRDS = new ReportDataSource("RevRecForReport",listRRFR);
            rpvPrint.LocalReport.DataSources.Clear();
            rpvPrint.LocalReport.DataSources.Add(RFRDS);
            rpvPrint.LocalReport.DataSources.Add(RDFRDS);
            rpvPrint.LocalReport.DataSources.Add(RRFRDS);
            rpvPrint.RefreshReport();
        }

        private void rpvPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
