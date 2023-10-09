using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public delegate void ChangeBK(int i);
        public ChangeBK ReloadBK;
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
        private string RandomRevNo()
        {
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = new DateTime(d1.Year,d1.Month,d1.Day,23,59,59);
            string s = context.RESERVATION.Count(p=> DateTime.Compare(p.CreateDate.Value,d1)>=0 && DateTime.Compare(p.CreateDate.Value, d2)<=0).ToString();
            while (s.Length < 4)
            {
                s = 0 + s;
            }
            return "Rev" + string.Format("{0:ddMMyy}", DateTime.Now) + s;
             
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            if(revNo == string.Empty)
            {
                revNo = RandomRevNo();
                isNew = true;
            }  
            else
            {
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
                List<RF_DETAIL> listRFD = rev.RF_DETAIL.ToList();
                BindGrid(listRFD);
                txtDeopsite.Text = rev.Deposite.Value.ToString();
                btnAcept.Enabled = false;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                cboCourt.Enabled = false;
                dtpDate.Enabled = false;
                dtpStartTime.Enabled = false;
                dtpEndTime.Enabled = false;
                isNew = false;
            }
            dtpDate.Value = DateTime.Now;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpEndTime.CustomFormat = "HH:mm";
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 5, 0, 0);
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 6, 0, 0);
            FillcboCourtName();
            
        }
        private void BindGrid(List<RF_DETAIL> listRFD)
        {
            foreach(RF_DETAIL item in listRFD)
            {
                int d = 0;
                int i = dgvRF_Detail.Rows.Add();
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.ReservationNo;
                dgvRF_Detail.Rows[i].Cells[d++].Value = item.COURT.CourtName;
                dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault().PriceTag;              
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
        private bool Check_DB_Exist_Time_For_Court(COURT c)
        {
            DateTime ds = dtpStartTime.Value;
            DateTime de = dtpEndTime.Value;
            List<RF_DETAIL> listRF = context.RF_DETAIL.Where(p => p.CourtID == c.CourtID).ToList();
            foreach(RF_DETAIL rf in listRF)
            {
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == rf.ReservationNo);
                int d2 = DateTime.Compare(ds, rev.EndTime.Value);
                int d3 = DateTime.Compare(de, rev.StartTime.Value);
                if (d2 >= 0 || d3 <= 0)
                    continue;
                else
                    return true;
            }
            return false;
        }
        private void FillcboCourtName()
        {
            cboCourt.Items.Clear();
            cboCourt.AutoCompleteCustomSource.Clear();
            foreach (COURT item in context.COURT)
            {
                if(Check_DB_Exist_Time_For_Court(item)==true||Check_dgvRF_DETAIL_Time_For_Court(item)==true)
                    continue;
                cboCourt.Items.Add(item.CourtName);
                cboCourt.AutoCompleteCustomSource.Add(item.CourtName);
            }
            if (cboCourt.Items.Count == 0)
            {
                cboCourt.Text = string.Empty;
                cboCourt.Enabled = false;
                /*MessageBox.Show("Không còn sân khả dụng, vui lòng chọn khung giờ hoặc ngày khác");
                btnSave.Enabled = false;*/
            }
            else
            {
                cboCourt.SelectedIndex = 0;
                cboCourt.Enabled = true;
                //btnSave.Enabled = true;
            }
                
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(DateTime.Compare( dtpStartTime.Value,DateTime.Now)<0)
            {
                MessageBox.Show("Thời gian không phù hợp");
                return;
            }
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
            dgvRF_Detail.Rows[i].Cells[d++].Value = context.PRICE.FirstOrDefault(p=>p.C_Status==1).PriceTag;
            txtDeopsite.Text = DepositeCalculation().ToString();
            FillcboCourtName();
            dtpEndTime.Enabled = false;
            dtpStartTime.Enabled = false;
            if(cboCourt.Items.Count==0)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }
        private decimal DepositeCalculation()
        {
            if (dgvRF_Detail.Rows.Count == 1)
                return 0;
            decimal total = 0;
            DateTime d1 = dtpStartTime.Value;
            DateTime d2 = dtpEndTime.Value;
            decimal p = (decimal)(d2.Hour * 60 + d2.Minute - d1.Hour * 60 - d1.Minute) / 60;
            for(int i=0;i<dgvRF_Detail.Rows.Count-1;i++)
            {
                total += (decimal)dgvRF_Detail.Rows[i].Cells[2].Value * p;
            }
            return Math.Round(total * 30 / 100);
        }
        private void btnAcept_Click(object sender, EventArgs e)
        {          
            if(dgvRF_Detail.Rows.Count==1)
            {
                if (MessageBox.Show("Không thể thêm phiếu đặt sân vì chưa có thông tin, bạn có muốn thoát","Caution",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                    return;
                }
                else
                    return;
            }
            if(isNew == true) 
            {
                DateTime d = dtpDate.Value;
                RESERVATION rev = new RESERVATION();
                try
                {
                    rev.ReservationNo = revNo;
                    rev.Username = Properties.Settings.Default.Username;
                    rev.PhoneNumber = PN;
                    rev.CreateDate = DateTime.Now;
                    rev.BookingDate = d.Date;
                    rev.StartTime = new DateTime(d.Year, d.Month, d.Day, dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, 0);
                    rev.EndTime = new DateTime(d.Year, d.Month, d.Day, dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, 0);
                    rev.Deposite = Decimal.Parse(txtDeopsite.Text);
                    rev.C_Status = 0;
                    rev.PriceID = context.PRICE.FirstOrDefault(p => p.C_Status == 1).PriceID;
                    context.RESERVATION.Add(rev);
                    context.SaveChanges();
                }
                catch (Exception ex) 
                { MessageBox.Show(ex.Message); }
              
            }
            foreach (DataGridViewRow row in dgvRF_Detail.Rows)
            {
                if (row.Index == dgvRF_Detail.Rows.Count - 1)
                    break;
                RF_DETAIL rfd = new RF_DETAIL();
                rfd.ReservationNo = row.Cells[0].Value.ToString();
                string str = row.Cells[1].Value.ToString();
                rfd.CourtID = context.COURT.FirstOrDefault(p => p.CourtName == str).CourtID;
                context.RF_DETAIL.Add(rfd);
                context.SaveChanges();
            }
            int i = 1;
            ReloadBK(i);
            this.Close();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if(DateTime.Compare(dtpDate.Value.Date,DateTime.Now.Date)<0)
            {
                MessageBox.Show("Thời gian sai quy định");
                dtpDate.Value = DateTime.Now;
            }
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpStartTime.Value.Hour, dtpStartTime.Value.Minute, dtpStartTime.Value.Second);
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpEndTime.Value.Hour, dtpEndTime.Value.Minute, dtpEndTime.Value.Second);
           
        }
        private void dtpStartTime_ValueChanged(object sender, EventArgs e)
        {
            if (dtpEndTime.Value.Hour < 6)
            {
                //MessageBox.Show("Nhập thời gian kết thúc sai quy định ");
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 6, 0, 0);

            }
            if (dtpEndTime.Value.Hour > 22)
            {
                //MessageBox.Show("Nhập thời gian kết thúc sai quy định ");
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 22, 0, 0);
            }
            if (dtpStartTime.Value.Hour < 5)
            {
                //MessageBox.Show("Nhập thời gian bắt đầu sai quy định ");
                dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 5, 0, 0);
            }
            if (dtpStartTime.Value.Hour > 21)
            {
                //MessageBox.Show("Nhập thời gian bắt đầu sai quy định ");
                dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 21, 0, 0);
            }
            if(dtpEndTime.Value.Hour <= dtpStartTime.Value.Hour)
            {
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpStartTime.Value.Hour + 1, 0, 0);
            }
            FillcboCourtName();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvRF_Detail.Rows.Clear();
            txtDeopsite.Text = "0";
            dtpStartTime.Enabled = true;
            dtpEndTime.Enabled = true;
            dtpDate.Enabled = true;
            cboCourt.Enabled = true;
            FillcboCourtName();
        }
    }
}
