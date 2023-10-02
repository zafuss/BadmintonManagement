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
                isNew = false;
            }
            dtpDate.Value = DateTime.Now;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            List<COURT> listCourt = context.COURT.ToList();
            fillcboCourtName(listCourt);
        }
        
        private void BindGrid(List<RF_DETAIL> listRFD)
        {
            foreach(RF_DETAIL item in listRFD)
            {
                int i = dgvRF_Detail.Rows.Add();
                int d = 0;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.ReservationNo;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.COURT.CourtName;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.StartTime;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.EndTime;
                dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;
            }
           
        }
        private void fillcboCourtName(List<COURT> listCourt)
        {

            cboCourt.DataSource = listCourt;
            cboCourt.DisplayMember = "CourtName";
            cboCourt.ValueMember = "CourtID";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = dgvRF_Detail.Rows.Add();
            int d= 0;
            dgvRF_Detail.Rows[i].Cells[d++].Value = revNo;
            dgvRF_Detail.Rows[i].Cells[d++].Value = cboCourt.Text;
            dgvRF_Detail.Rows[i].Cells[d++].Value = dtpStartTime.Value;
            dgvRF_Detail.Rows[i].Cells[d++].Value = dtpEndTime.Value;
            dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;
            txtDeopsite.Text = DepositeCalculation().ToString();
        }
        private decimal DepositeCalculation()
        {
            return (dgvRF_Detail.Rows.Count-1) * 60000;
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
                rev.Deposite = 0;
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
    }
}
