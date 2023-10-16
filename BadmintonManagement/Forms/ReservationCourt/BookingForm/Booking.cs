using BadmintonManagement.Forms.Court;
using BadmintonManagement.Forms.Price;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
        public static Booking Instance;
        public Booking()
        {
            Instance = this;
            InitializeComponent();
        }
        public static List<BookingDetailForReceitp> listBDFR;
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
            string s = context.RESERVATION.Count(p=> DateTime.Compare(p.CreateDate,d1)>=0 && DateTime.Compare(p.CreateDate, d2)<=0).ToString();
            while (s.Length < 4)
            {
                s = 0 + s;
            }
            return "Rev" + string.Format("{0:ddMMyy}", DateTime.Now) + s;
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadFileBooking();
            //UpdateBookingDetailForReceipt();
            SaveFile(listBDFR);
            if(revNo == string.Empty)
            {
                revNo = RandomRevNo();
                isNew = true;
                dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute+5, 0);
                dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, DateTime.Now.Hour+1, DateTime.Now.Minute+5, 0);
            }  
            else
            {
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
                List<RF_DETAIL> listRFD = rev.RF_DETAIL.ToList();
                BindGrid(listRFD);
                dtpStartTime.Value = rev.StartTime;
                dtpEndTime.Value = rev.EndTime;
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
                //RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == rf.ReservationNo);
                int d2 = DateTime.Compare(ds, rf.RESERVATION.EndTime);
                int d3 = DateTime.Compare(de, rf.RESERVATION.StartTime);
                if (d2 >= 0 || d3 <= 0)
                    continue;
                else
                    return true;
            }
            return false;
        }
        private bool Check_Court_status(COURT item)
        {
            if(item.C_Status == "Disable"||item.C_Status=="Maintenance")
                return true;
            return false;
        }
        private void FillcboCourtName()
        {
            cboCourt.Items.Clear();
            cboCourt.AutoCompleteCustomSource.Clear();
            context = new ModelBadmintonManage();
            foreach (COURT item in context.COURT)
            {
                if(Check_DB_Exist_Time_For_Court(item)==true||Check_dgvRF_DETAIL_Time_For_Court(item)==true||Check_Court_status(item) == true)
                    continue;
                cboCourt.Items.Add(item.CourtName);
                cboCourt.AutoCompleteCustomSource.Add(item.CourtName);
            }
            if (cboCourt.Items.Count == 0)
            {
                cboCourt.Text = string.Empty;
                cboCourt.Enabled = false;
            }
            else
            {
                cboCourt.SelectedIndex = 0;
                cboCourt.Enabled = true;
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
        private decimal GetTheExactTimeFactoredMinutes(DateTime st , DateTime se)
        {
            decimal d1 = st.Hour*60 + st.Minute;
            decimal d2 = se.Hour * 60 + se.Minute;
            decimal timeFactor = (decimal)context.PRICE.FirstOrDefault(p => p.PriceID == PriceForm.GBPriceID).TimeFactor;
            decimal dayFactor;
            if (ApplyFactor.weekDay.Any(p => p.Day == DateTime.Now.DayOfWeek))
                dayFactor = (decimal)context.PRICE.FirstOrDefault(p => p.PriceID == PriceForm.GBPriceID).DateFactor;
            else
                dayFactor = 1;
            foreach (TimeApplyFactor item in ApplyFactor.timeApplyFactors)
            {
                decimal d3 = item.StartTime;
                decimal d4 = item.EndTime;
                if (d1 > d4 || d2 < d3)
                    continue;
                if(d1 <= d3)
                {
                    if (d2 >= d4)
                        return (d2 - d1 + (d4 - d3) * (timeFactor - 1)) * dayFactor;
                    else
                        return (d2 - d1 + (d2 - d3) * (timeFactor-1)) * dayFactor;
                }
                else
                {
                    if(d2 >= d4)
                        return (d2 - d1 + (d4 - d1) * (timeFactor-1)) * dayFactor;
                    else
                        return (d2-d1)*timeFactor * dayFactor;
                }
            }
            return d2 - d1;
        }
        private decimal ProvisionOfTotal()
        {
            if (dgvRF_Detail.Rows.Count == 1)
                return 0;
            decimal total = 0;
            DateTime d1 = dtpStartTime.Value;
            DateTime d2 = dtpEndTime.Value;
            decimal p = GetTheExactTimeFactoredMinutes(dtpStartTime.Value, dtpEndTime.Value);
            for (int i = 0; i < dgvRF_Detail.Rows.Count - 1; i++)
            {
                total += (decimal)dgvRF_Detail.Rows[i].Cells[2].Value * p/60;
            }
            return Math.Round(total);
        }
        private decimal DepositeCalculation()
        {
            if(dgvRF_Detail.Rows.Count == 1)
                return 0;
            return (dgvRF_Detail.Rows.Count-1) * 40000;
            //return Math.Round(ProvisionOfTotal()*20/100);
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
                    if (PN != string.Empty)
                        rev.PhoneNumber = PN;
                    else
                        rev.PhoneNumber = null;
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
            BookingDetailForReceitp item = new BookingDetailForReceitp();
            item.ReservationNo = revNo;
            item.TFactor = ApplyFactor.timeApplyFactors;
            item.WDay = ApplyFactor.weekDay;
            item.PriceID = PriceForm.GBPriceID;
            item.Total = ProvisionOfTotal();
            listBDFR.Add(item);
            SaveFile(listBDFR);
            int i = 1;
            ReloadBK(i);
            this.Close();
            if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
            {
                CourtForm.Instance.ReLoad();
            }
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void LoadFileBooking()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Binary file|*.dat";
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(parentDirectory, "BookingDetailForReceipt", "BookingDetailForReceipt");
            listBDFR = IOHelper.Load<BookingDetailForReceitp>(filePath);
        }
        private void SaveFile(List<BookingDetailForReceitp> T)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Binary file|*.dat";
            string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(parentDirectory, "BookingDetailForReceipt", "BookingDetailForReceipt");
            IOHelper.Save(filePath, T);
        }
       /* public static void UpdateBookingDetailForReceipt()
        {
            ModelBadmintonManage context = new ModelBadmintonManage();
            List<BookingDetailForReceitp> tempt = listBDFR.ToList();
            foreach(BookingDetailForReceitp item in listBDFR)
            {
                if(context.RESERVATION.Any(p=>p.ReservationNo == item.ReservationNo))
                {
                    tempt.Remove(item);
                }
            }
            listBDFR.Clear();
            listBDFR = tempt.ToList();
        }*/
    }
}
