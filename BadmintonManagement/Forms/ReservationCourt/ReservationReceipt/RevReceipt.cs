using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt;
using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint;
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
            else isNew = true;
        }
        public delegate void ChangeRevStat(string revNo);
        public ChangeRevStat RevStat;
        ModelBadmintonManage context = new ModelBadmintonManage();

        private string ReceiptNoGenerator()
        { 
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = new DateTime(d1.Year, d1.Month, d1.Day, 23, 59, 59);
            string s = context.RECEIPT.Count(p => DateTime.Compare(p.C_Date, d1) >= 0 && DateTime.Compare(p.C_Date, d2) <= 0).ToString();
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
                List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.ReservationNo == revNo).ToList();
                BindGrid(listRF);
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
                dtpTimePublish.Value = DateTime.Now;
                txtReceiptNo.Text = ReceiptNoGenerator();
                txtDeposite.Text = rev.Deposite.Value.ToString();
                txtTotal.Text = (GetTheTotal(rev)-rev.Deposite+GetTheExtraTimeFee()).ToString();
                txtExtraTime.Text = GetTheExtraTimeFee().ToString();
                
            }
            else
            {
                List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.ReservationNo == revNo).ToList();
                BindGrid(listRF);
                RECEIPT rec = context.RECEIPT.FirstOrDefault(p=>p.ReservationNo == revNo);
                dtpTimePublish.Value = rec.C_Date;
                txtReceiptNo.Text = rec.ReceiptNo;
                txtDeposite.Text = rec.RESERVATION.Deposite.Value.ToString();
                txtTotal.Text = (rec.Total.Value-rec.RESERVATION.Deposite).ToString();
                txtExtraTime.Text = GetTheExtraTimeFee().ToString();
                btnPayment.Enabled = false;
                btnPrint.Visible = true;
            }
        }
        private decimal GetTheTotal(RESERVATION rev)
        {

            decimal total = 0;
            foreach(RF_DETAIL rf in rev.RF_DETAIL)
            {
                total += GetTheDetailMoney(rf);
            }
            return total;
        }
        private decimal GetTheDetailMoney(RF_DETAIL rf)
        {
            DateTime d1 = rf.RESERVATION.StartTime;
            DateTime d2 = rf.RESERVATION.EndTime;
            decimal p = (decimal)(d2.Hour*60 + d2.Minute - d1.Hour*60 -d1.Minute)/60;
            return Math.Round((p + Decimal.Parse(GetTheExtraTime().ToString())) * rf.RESERVATION.PRICE.PriceTag);
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
            DateTime revTime = rev.EndTime;
            if(DateTime.Compare(d,rev.EndTime)<=0)
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
        private decimal GetTheExtraTimeFee()
        {
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
            return Math.Round(decimal.Parse(GetTheExtraTime().ToString()) * rev.PRICE.PriceTag);    
        }
 

        private void AcceptReceipt()
        {
            RECEIPT rec = new RECEIPT();
            rec.ReceiptNo = txtReceiptNo.Text;
            rec.C_Date = DateTime.Now;
            rec.ReservationNo = revNo;
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
            rec.Total = GetTheTotal(rev)+GetTheExtraTimeFee();
            rec.Username = Properties.Settings.Default.Username;
            rec.ExtraTime = float.Parse(txtExtraTime.Text);
            context.RECEIPT.Add(rec);
            context.SaveChanges();
        }
       
        private void btnPayment_Click(object sender, EventArgs e)
        {
            AcceptReceipt();
            RevStat(revNo);
            RevReceiptPrint frm = new RevReceiptPrint(revNo);
            frm.ShowDialog();
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RevReceiptPrint frm = new RevReceiptPrint(revNo);
            frm.ShowDialog();
        }
    }
}
