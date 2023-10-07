using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt
{
    public partial class RevReceipt : Form
    {
        public RevReceipt()
        {
            InitializeComponent();
        }
        string revNo;
        public RevReceipt(string reservationNo)
        {
            InitializeComponent();
            revNo = reservationNo;
        }
        ModelBadmintonManage context = new ModelBadmintonManage();

        private string ReceiptNoGenerator()
        {
            string str = DateTime.Now.Date.ToString().Substring(0,10);
            //List<RECEIPT> listRec = context.RECEIPT.Where(p=>p.C_Date.Value.ToString().Contains(str)).ToList();
            int i = context.RECEIPT.Count(p => p.C_Date.Value.ToString().Contains(str));
            return "Rec" + string.Format("{0:ddMMyy}", DateTime.Now) + string.Format("{0:0000}", i);
        }
        private void RevReceipt_Load(object sender, EventArgs e)
        {
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
            dtpTimePublish.Value = DateTime.Now;
            txtReceiptNo.Text = ReceiptNoGenerator();
            txtDeposite.Text = rev.Deposite.Value.ToString();
            txtTotal.Text = GetTheTotal(rev).ToString();
            List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.ReservationNo == revNo).ToList();
            BindGrid(listRF);
        }
        private decimal GetTheTotal(RESERVATION rev)
        {
            decimal total = 0;
            foreach(RF_DETAIL rf in rev.RF_DETAIL)
            {
                total += GetTheDetailMoney(rf);
            }
            return total - rev.Deposite.Value;
        }
        private decimal GetTheDetailMoney(RF_DETAIL rf)
        {
            DateTime d1 = rf.RESERVATION.StartTime.Value;
            DateTime d2 = rf.RESERVATION.EndTime.Value;
            decimal p = (decimal)(d2.Hour*60 + d2.Minute - d1.Hour*60 -d1.Minute)/60;
            return p*rf.PRICE.PriceTag.Value;
        }
        private void BindGrid(List<RF_DETAIL> listRF)
        {
            listRF = context.RF_DETAIL.Where(p=>p.ReservationNo==revNo).ToList();
            foreach (RF_DETAIL item in listRF)
            {
                int i = dgvRF_Detail.Rows.Add();
                int d = 0;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.ReservationNo;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.COURT.CourtName;
                dgvRF_Detail.Rows[i].Cells[d++].Value = GetTheDetailMoney(item); 
            }
        }
        private float GetTheExtraTime(RF_DETAIL rf)
        {
            DateTime d = DateTime.Now;
            if(DateTime.Compare(d,rf.RESERVATION.EndTime.Value)<=0)
                return 0;
            
        }

        private RECEIPT AcceptReceipt()
        {
            RECEIPT rec = new RECEIPT();
            rec.ReceiptNo = txtReceiptNo.Text;
            rec.C_Date = DateTime.Now;
            rec.ReservationNo = revNo;
            rec.Total = Decimal.Parse(txtTotal.Text);

        }
        private void btnPayMent_Click(object sender, EventArgs e)
        {

        }
    }
}
