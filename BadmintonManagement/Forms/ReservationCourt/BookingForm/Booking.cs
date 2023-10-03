using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.BookingForm
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        string PN;
        string FN;
        string EM;
        string revNo = string.Empty;
        bool isNew;
        public Booking(string phoneNumnber, string fullName, string email)
        {
            InitializeComponent();
            PN = phoneNumnber;
            FN = fullName; 
            EM = email;
        }

       
        public Booking(string reservationNo)
        {
            InitializeComponent();
            revNo = reservationNo;
        }
        
        ModelBadmintonManage context = new ModelBadmintonManage();

        private void RandomRevNo()
        {
            Random random = new Random();
            revNo = random.Next(1000, 9999).ToString();
            while(context.RESERVATION.Any(p=>p.ReservationNo == revNo))
                revNo = random.Next(1000,9999).ToString();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            if(revNo == string.Empty)
            {
                RandomRevNo();
                isNew = true;
            }  
            else
            {
                List<RF_DETAIL> listRFD = context.RF_DETAIL.Where(p=>p.ReservationNo == revNo).ToList();
                BindGrid(listRFD);
                if(context.RESERVATION.FirstOrDefault(p=>p.ReservationNo == revNo).C_Status==5)
                {
                    btnAcept.Enabled = false;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                }    
                isNew = false;
            }
            dtpDate.Value = DateTime.Now;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            FillcboCourtName();
        }
        private void BindGrid(List<RF_DETAIL> listRFD)
        {
            foreach(RF_DETAIL item in listRFD)
            {
                int d = 0;
                if (dgvRF_Detail.Rows.Count ==1)
                {
                    dgvRF_Detail.Rows[0].Cells[d++].Value = item.ReservationNo;
                    dgvRF_Detail.Rows[0].Cells[d++].Value = item.COURT.CourtName;
                    dgvRF_Detail.Rows[0].Cells[d++].Value = item.StartTime;
                    dgvRF_Detail.Rows[0].Cells[d++].Value = item.EndTime;
                    dgvRF_Detail.Rows[0].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;
                }
                else
                {
                    int i = dgvRF_Detail.Rows.Add();
                    dgvRF_Detail.Rows[i].Cells[d++].Value = item.ReservationNo;
                    dgvRF_Detail.Rows[i].Cells[d++].Value = item.COURT.CourtName;
                    dgvRF_Detail.Rows[i].Cells[d++].Value = item.StartTime;
                    dgvRF_Detail.Rows[i].Cells[d++].Value = item.EndTime;
                    dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;
                }
            }
        }
        private bool Check_dgvRF_DETAIL_Time_For_Court(COURT c)
        {
            if(dgvRF_Detail.Rows.Count==1)
                return false;
            for(int i=0 ;i< dgvRF_Detail.Rows.Count-1;i++)
            {
                if (c.CourtName == dgvRF_Detail.Rows[i].Cells[1].Value.ToString())
                    return true;
            }
            return false;
        }
        private bool Check_DB_Time_For_Court(COURT c)
        {
            DateTime ds = dtpStartTime.Value;
            DateTime de = dtpEndTime.Value;
            if ((c.RF_DETAIL.Any(p => DateTime.Compare(p.StartTime.Value,ds) <= 1 && c.RF_DETAIL.Any(p=>DateTime.Compare(p.EndTime.Value,de)>=1))))
                return true;
            return false;
        }
        private void FillcboCourtName()
        {
            cboCourt.Items.Clear();
            cboCourt.AutoCompleteCustomSource.Clear();
            foreach (COURT item in context.COURT)
            {
                if(Check_DB_Time_For_Court(item)==true||Check_dgvRF_DETAIL_Time_For_Court(item)==true)
                    continue;
                cboCourt.Items.Add(item.CourtName);
                cboCourt.AutoCompleteCustomSource.Add(item.CourtName);
            }
            cboCourt.SelectedIndex= 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int dt = DateTime.Compare(dtpEndTime.Value, dtpStartTime.Value);
            if (dt <= 0)
            {
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
                dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
                MessageBox.Show("Giờ bắt đầu phải sớm hơn giờ kết thúc");
                return;
            }
            if((dtpEndTime.Value.Hour*60+dtpEndTime.Value.Minute - dtpStartTime.Value.Hour*60 - dtpStartTime.Value.Minute)<60)
            {
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
                dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
                MessageBox.Show("Giờ thuê tối thiểu 1 tiếng");
                return;
            }
            int i = dgvRF_Detail.Rows.Add();
            int d= 0;
            dgvRF_Detail.Rows[i].Cells[d++].Value = revNo;
            dgvRF_Detail.Rows[i].Cells[d++].Value = cboCourt.Text;
            dgvRF_Detail.Rows[i].Cells[d++].Value = dtpStartTime.Value;
            dgvRF_Detail.Rows[i].Cells[d++].Value = dtpEndTime.Value;
            dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;
            txtDeopsite.Text = DepositeCalculation().ToString();
            FillcboCourtName();
        }
        private decimal DepositeCalculation()
        {
            return (dgvRF_Detail.Rows.Count-1) * 50000;
        }
        private void btnAcept_Click(object sender, EventArgs e)
        {
            if(isNew == true) 
            {
                RESERVATION rev = new RESERVATION();
                rev.ReservationNo = revNo;
                rev.Username = context.C_USER.FirstOrDefault().Username;
                rev.PhoneNumber = PN;
                rev.CreateDate = DateTime.Now;
                rev.BookingDate = dtpDate.Value;
                rev.Deposite = Decimal.Parse(txtDeopsite.Text);
                rev.C_Status = 0;
                context.RESERVATION.Add(rev);
                context.SaveChanges();
            }
            foreach (DataGridViewRow row in dgvRF_Detail.Rows)
            {
                if (row.Index == dgvRF_Detail.Rows.Count - 1)
                    break;
                RF_DETAIL rfd = new RF_DETAIL();
                rfd.ReservationNo = row.Cells[0].Value.ToString();
                string str = row.Cells[1].Value.ToString();
                rfd.CourtID = context.COURT.FirstOrDefault(p=>p.CourtName == str).CourtID;
                DateTime d = DateTime.Parse(row.Cells[2].Value.ToString());
                rfd.StartTime = d;
                d = DateTime.Parse(row.Cells[3].Value.ToString());
                rfd.EndTime = d;
                rfd.PriceID = context.PRICE.FirstOrDefault().PriceID;
                context.RF_DETAIL.Add(rfd);
                context.SaveChanges();
            }
            this.Close();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, dtpStartTime.Value.Second);
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, dtpEndTime.Value.Second);
        }

        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            FillcboCourtName();
        }
    }
}
