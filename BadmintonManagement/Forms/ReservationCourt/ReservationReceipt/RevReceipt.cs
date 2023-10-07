using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
        bool isNew;
        public RevReceipt(string reservationNo, string status)
        {
            InitializeComponent();
            revNo = reservationNo;
            if(status == "Đã thanh toán")
                isNew = false;
        }
        public delegate void ChangeRevStat(int i);
        public ChangeRevStat RevStat;
        ModelBadmintonManage context = new ModelBadmintonManage();

        private string ReceiptNoGenerator()
        { 
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = new DateTime(d1.Year, d1.Month, d1.Day, 23, 59, 59);
            string s = context.RECEIPT.Count(p => DateTime.Compare(p.C_Date.Value, d1) >= 0 && DateTime.Compare(p.C_Date.Value, d2) <= 0).ToString();
            while(s.Length <4)
            {
                s = 0 + s;
            }
            return "Rec" + string.Format("{0:ddMMyy}", DateTime.Now) + s;
        }
        private void RevReceipt_Load(object sender, EventArgs e)
        {
            if(isNew)
            {
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
                dtpTimePublish.Value = DateTime.Now;
                txtReceiptNo.Text = ReceiptNoGenerator();
                txtDeposite.Text = rev.Deposite.Value.ToString();
                txtTotal.Text = GetTheTotal(rev).ToString();
                txtExtraTime.Text = GetTheExtraTime().ToString();
                List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.ReservationNo == revNo).ToList();
                BindGrid(listRF);
            }
            else
            {
                RECEIPT rec = context.RECEIPT.FirstOrDefault(p=>p.ReservationNo == revNo);
                dtpTimePublish.Value = rec.C_Date.Value;
                txtReceiptNo.Text = rec.ReceiptNo;
                txtDeposite.Text = rec.RESERVATION.Deposite.Value.ToString();
                txtTotal.Text = rec.Total.Value.ToString();
                txtExtraTime.Text = rec.ExtraTime.Value.ToString();
                List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.ReservationNo == revNo).ToList();
                BindGrid(listRF);
                btnPayment.Enabled = false;
            }
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
            return (p + Decimal.Parse(GetTheExtraTime().ToString())) * rf.RESERVATION.PRICE.PriceTag.Value;
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
        private float GetTheExtraTime()
        {
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
            DateTime d = DateTime.Now;
            DateTime revTime = rev.EndTime.Value;
            if(DateTime.Compare(d,rev.EndTime.Value)<=0)
                return 0;
            float p = d.Hour * 60 + d.Minute - revTime.Hour * 60 - revTime.Minute;
            p = p / 30;
            if(p>=1)
            {
                if (p > 4)
                    return 4;
                return p;
            }
            return 0;
        }

        private void AcceptReceipt()
        {
            RECEIPT rec = new RECEIPT();
            rec.ReceiptNo = txtReceiptNo.Text;
            rec.C_Date = DateTime.Now;
            rec.ReservationNo = revNo;
            rec.Total = Decimal.Parse(txtTotal.Text);
            rec.Username = Properties.Settings.Default.Username;
            rec.ExtraTime = float.Parse(txtExtraTime.Text);
            context.RECEIPT.Add(rec);
            context.SaveChanges();
        }
        private void ChangeReservationStatus()
        {
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p=>p.ReservationNo == revNo);
            rev.C_Status = 4;
            context.RESERVATION.AddOrUpdate(rev);
            context.SaveChanges();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            ChangeReservationStatus();
            AcceptReceipt();
            int i = 1;
            RevStat(i);
            this.Close();
        }
    }
}
