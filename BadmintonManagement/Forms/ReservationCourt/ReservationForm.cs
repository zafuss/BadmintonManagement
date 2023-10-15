using BadmintonManagement.Forms.Court;
using BadmintonManagement.Forms.ReservationCourt.BookingForm;
using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt
{
    public partial class ReservationForm : Form
    {
        public static ReservationForm instance;
        public ReservationForm()
        {
            instance = this;
            InitializeComponent();
        }
        DateTime st;
        DateTime se;
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            dtpStartDay.Value = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
            dtpEndDay.Value = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
            DateTime st = new DateTime(dtpStartDay.Value.Year, dtpStartDay.Value.Month, dtpStartDay.Value.Day, 0, 0, 0);
            DateTime se = new DateTime(dtpEndDay.Value.Year, dtpEndDay.Value.Month, dtpEndDay.Value.Day, 23, 59, 59);
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            bindGrid(listRev);
            pnlFunction.Visible = false;
            pnlSearch.Visible = false;
            bool s = RealTimeCaptureStatusReservation();
            ReloadGridFollowTime(st,se);
            
        }
        ModelBadmintonManage context = new ModelBadmintonManage();
        private string PickStatus(RESERVATION rev)
        {
            int d = rev.C_Status.Value;
            if (d == 0)
                return "Chưa đặt cọc";
            if (d == 1) 
                return "Đã đặt cọc";
            if (d == 2)
                return "Đã nhận sân";
            if (d == 3)
                return "Chưa thanh toán";
            if (d == 4)
                return "Đã thanh toán";
            if (d == 5)
                return "Quá giờ nhận sân";
            if (d == 6)
                return "Đã cọc và quá giờ nhận sân";
            if (d == 7)
                return "Đã hủy";
            return "Cannot get the Status";
        }
        private void bindGrid(List<RESERVATION> listRev)
        {
            
            foreach (RESERVATION item in listRev)
            {
                int i = dgvReservation.Rows.Add();
                dgvReservation.Rows[i].Cells[0].Value = item.ReservationNo;
                dgvReservation.Rows[i].Cells[1].Value = item.Username;
                if (item.PhoneNumber != null)
                {
                    dgvReservation.Rows[i].Cells[2].Value = item.PhoneNumber;
                    dgvReservation.Rows[i].Cells[3].Value = item.CUSTOMER.FullName;
                }
                dgvReservation.Rows[i].Cells[4].Value = item.Deposite;
                dgvReservation.Rows[i].Cells[5].Value = item.CreateDate;
                dgvReservation.Rows[i].Cells[6].Value = item.BookingDate;
                dgvReservation.Rows[i].Cells[7].Value = item.StartTime;
                dgvReservation.Rows[i].Cells[8].Value = item.EndTime;
                dgvReservation.Rows[i].Cells[9].Value = PickStatus(item);
            }
        }
        private void ReloadGridFollowTime(DateTime st, DateTime se)
        {
            for(int i = 0;i<dgvReservation.Rows.Count-1;i++) 
            {
                DateTime p = DateTime.Parse(dgvReservation.Rows[i].Cells[5].Value.ToString());
                int s1 = DateTime.Compare(p,st);
                int s2 = DateTime.Compare(p,se);
                if(s1<=0||s2>=0)
                    dgvReservation.Rows[i].Visible = false;
                else
                    dgvReservation.Rows[i].Visible = true;
            }
        }
        private void ReloadGridFollowTimeByFilter(DateTime st, DateTime se)
        {
            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                DateTime p = DateTime.Parse(dgvReservation.Rows[i].Cells[5].Value.ToString());

                int s1 = DateTime.Compare(p, st);
                int s2 = DateTime.Compare(p, se);
                if (s1 <= 0 || s2 >= 0)
                    dgvReservation.Rows[i].Visible = false;
            }
        }
        private void dtpStartDay_ValueChanged(object sender, EventArgs e)
        {
            st = new DateTime(dtpStartDay.Value.Year, dtpStartDay.Value.Month, dtpStartDay.Value.Day, 0, 0, 0);
            ReloadGridFollowTime(st,se);
        }
        private void dtpEndDay_ValueChanged(object sender, EventArgs e)
        {
            se = new DateTime(dtpEndDay.Value.Year, dtpEndDay.Value.Month, dtpEndDay.Value.Day, 23, 59, 59);
            ReloadGridFollowTime(st,se);
        }
        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (pnlFunction.Visible)
                pnlFunction.Visible = false;
            else
                pnlFunction.Visible = true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (pnlSearch.Visible)
                pnlSearch.Visible = false;
            else
                pnlSearch.Visible = true;
        }
        private bool CheckContain(DataGridViewRow row)
        {
            for(int d =0;d<dgvReservation.ColumnCount;d++) 
            {
                if (row.Cells[d].Value.ToString().ToLower().Contains(txtSearchByPhoneNumber.Text.ToLower()))
                    return true;
            }
            return false;
        }
        private void txtSearchByPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ReloadGrid();
            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                if (dgvReservation.Rows[i].Cells[0].Value != null)
                {
                    if (CheckContain(dgvReservation.Rows[i])==true)
                        dgvReservation.Rows[i].Visible = true;
                    else
                        dgvReservation.Rows[i].Visible = false;
                }
              /*  else
                {
                    if (txtSearchByPhoneNumber.TextLength > 0)
                        dgvReservation.Rows[i].Visible = false;
                    else
                        dgvReservation.Rows[i].Visible = true;
                }*/
            }
            ReloadGridFollowTimeByFilter(st, se);
        }
        private void txtSearchByPhoneNumber_Click(object sender, EventArgs e)
        {
            txtSearchByPhoneNumber.SelectAll();
        }
        private void LoadRev(int i)
        {
            ReloadGrid();
            ReloadGridFollowTime(st,se);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetCustomerInformation frm = new GetCustomerInformation();
            frm.ReloadRev = new GetCustomerInformation.ChangeRev(LoadRev);
            frm.ShowDialog();
        }
        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReservation.Rows.Count < 2)
                    throw new Exception("No data");
                if (dgvReservation.SelectedRows.Count == 0)
                    throw new Exception("Please pick a RevNo to view");
                int i = dgvReservation.SelectedRows.Count - 1;
                Booking frm = new Booking(dgvReservation.SelectedRows[i].Cells[0].Value.ToString());
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void EraseRF_Detail(RESERVATION rev)
        {
            List<RF_DETAIL> listrf = rev.RF_DETAIL.ToList();
            foreach (RF_DETAIL rf in listrf)
            {
                context.RF_DETAIL.Remove(rf);
                context.SaveChanges();
            }
            context.RESERVATION.AddOrUpdate(rev);
            context.SaveChanges();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Có thật sự muốn hủy","Caution",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvReservation.SelectedRows[0].Cells[9].Value = "Đã hủy";
                int i = dgvReservation.SelectedRows.Count - 1;
                string str = dgvReservation.SelectedRows[i].Cells[0].Value.ToString();
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == str);
                rev.C_Status = 7;
                EraseRF_Detail(rev);
                btnCancel.Enabled = false;
                MessageBox.Show("Đã hủy");
            }
        }
        private void dgvReservation_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservation.SelectedRows.Count < 1)
                return;

            if (dgvReservation.Rows[dgvReservation.Rows.Count - 1].Selected)
            {
                btnCancel.Enabled = false;
                btnAcceptDeposition.Enabled = false;
                btnGot.Enabled = false;
                btnRevReceipt.Enabled = false;
            }
            else
            {
                string str = dgvReservation.SelectedRows[0].Cells[9].Value.ToString();
                if (str == "Đã thanh toán")
                    btnRevReceipt.Text = "Xem hóa đơn";
                else
                    btnRevReceipt.Text = "Lập hóa đơn";
                switch (str)
                {
                    case "Chưa đặt cọc":
                        btnCancel.Enabled = true;
                        btnAcceptDeposition.Enabled = true;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Đã đặt cọc":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = true;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Đã nhận sân":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = true;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Chưa thanh toán":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = true;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Đã thanh toán":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = true;
                        btnRevReceipt.Text = "Xem hóa đơn";
                        break;
                    case "Quá giờ nhận sân":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Đã cọc và quá giờ nhận sân":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    case "Đã hủy":
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                    default:
                        btnCancel.Enabled = false;
                        btnAcceptDeposition.Enabled = false;
                        btnGot.Enabled = false;
                        btnRevReceipt.Enabled = false;
                        btnRevReceipt.Text = "Lập hóa đơn";
                        break;
                }
            }
        }
        private void ReloadGrid()
        {
            dgvReservation.Rows.Clear();
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            bindGrid(listRev);
        }
        private void btnAcceptDeposition_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Có xác nhận đặt cọc?", "Caution", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            RESERVATION rev = new RESERVATION();
            int i = dgvReservation.SelectedRows.Count - 1;
            string str = dgvReservation.SelectedRows[i].Cells[0].Value.ToString();
            rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == str);
            rev.C_Status = 1;
            dgvReservation.SelectedRows[i].Cells[9].Value = "Đã đặt cọc";
            context.RESERVATION.AddOrUpdate(rev);
            context.SaveChanges();
            btnGot.Enabled = true;
            btnAcceptDeposition .Enabled = false;
            MessageBox.Show("Đặt cọc thành công","Thông báo");
            
        }
        private void ChangeReservationStatus(string revNo)
        {
            RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == revNo);
            rev.C_Status = 4;
            context.RESERVATION.AddOrUpdate(rev);
            context.SaveChanges();
        }
        private void LoadRevStat(string revNo)
        {
            ChangeReservationStatus(revNo);
            int index = dgvReservation.SelectedRows.Count - 1;
            dgvReservation.SelectedRows[index].Cells[9].Value = "Đã thanh toán";
            btnRevReceipt.Text = "Xem hóa đơn";
            if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
            {
                CourtForm.Instance.ReLoad();
            }
        }
        private void btnRevReceipt_Click(object sender, EventArgs e)
        {
            int i = dgvReservation.SelectedRows.Count-1;
            string str1 = dgvReservation.SelectedRows[i].Cells[0].Value.ToString();
            string str2 = dgvReservation.SelectedRows[i].Cells[9].Value.ToString();
            RevReceipt frm = new RevReceipt(str1,str2);
            frm.RevStat = new RevReceipt.ChangeRevStat(LoadRevStat);
            frm.ShowDialog();  
        }
        DateTime tempStart;
        DateTime tempEnd;
        private void chbThisMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (chbThisMonth.Checked)
            {
                tempStart = st;
                tempEnd = se;
                DateTime d = DateTime.Now;
                st = new DateTime(d.Year, d.Month, 1, 0, 0, 0);
                se = new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month), 23, 59, 59);
                ReloadGridFollowTime(st, se);
                dtpStartDay.Value = st;
                dtpEndDay.Value = se;
            }
            else
            {
                st = tempStart;
                se = tempEnd;
                dtpStartDay.Value = tempStart;
                dtpEndDay.Value = tempEnd;
                ReloadGridFollowTime(st, se);
            }
        }
        private void btnOverTime_Click(object sender, EventArgs e)
        {
            for(int i= 0; i <dgvReservation.Rows.Count-1; i++) 
            {
                if (dgvReservation.Rows[i].Cells[9].Value.ToString() == "Đã cọc và quá giờ nhận sân"|| dgvReservation.Rows[i].Cells[9].Value.ToString() == "Quá giờ nhận sân")
                    dgvReservation.Rows[i].Visible = true;
                else
                    dgvReservation.Rows[i].Visible=false;
            }
            ReloadGridFollowTimeByFilter(st,se);
        }
        
        private bool RealTimeCaptureStatusReservation()
        {
            bool change = false;
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            foreach(RESERVATION rev in listRev)
            {
                DateTime d = rev.StartTime.Value;
                int s = DateTime.Compare(d.Date, DateTime.Now.Date);
                if(rev.C_Status == 2 && DateTime.Compare(rev.EndTime.Value,DateTime.Now)<=0)
                {
                    rev.C_Status = 3;
                    if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
                    {
                        CourtForm.Instance.ReLoad();
                    }
                }
                else
                if (s > 0 || rev.C_Status>1)
                    continue;
                if(s==0)
                {
                    if ((d.Hour * 60 + d.Minute - DateTime.Now.Hour * 60 - DateTime.Now.Minute) < -30)
                    {
                        if(rev.C_Status==0)
                            rev.C_Status = 5;
                        else if(rev.C_Status==1)
                            rev.C_Status = 6;
                        EraseRF_Detail(rev);
                        context.RESERVATION.AddOrUpdate(rev);
                        context.SaveChanges();
                        change = true;
                    }
                }
                else if(s<0)
                {
                    if (rev.C_Status == 0)
                        rev.C_Status = 5;
                    else if( rev.C_Status==1)
                        rev.C_Status = 6;
                    EraseRF_Detail(rev);
                    context.RESERVATION.AddOrUpdate(rev);
                    context.SaveChanges();
                    change = true;
                }
            }
            return change;
        }
        private void tmrCheck_Tick(object sender, EventArgs e)
        {
            if (RealTimeCaptureStatusReservation())
            {
                ReloadGrid();
                ReloadGridFollowTime(st, se);
            }     
        }
        private void btnCancelFilter_Click(object sender, EventArgs e)
        {
            ReloadGridFollowTime(st, se);
        }
        private void btnNotYetAccepted_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                if (dgvReservation.Rows[i].Cells[9].Value.ToString() == "Chưa đặt cọc" || dgvReservation.Rows[i].Cells[9].Value.ToString() == "Đã đặt cọc")
                    dgvReservation.Rows[i].Visible = true;
                else
                    dgvReservation.Rows[i].Visible = false;
            }
            ReloadGridFollowTimeByFilter(st, se);
        }
        private void btnNotYetDeposited_Click(object sender, EventArgs e)
        {
            for(int i = 0;i< dgvReservation.Rows.Count -1;i++)
            {
                if (dgvReservation.Rows[i].Cells[9].Value.ToString() == "Chưa đặt cọc")
                    dgvReservation.Rows[i].Visible = true;
                else
                    dgvReservation.Rows[i].Visible = false;
            }
            ReloadGridFollowTimeByFilter(st,se);
        }

        private void btnNotYetPayed_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                if (dgvReservation.Rows[i].Cells[9].Value.ToString() == "Chưa thanh toán"|| dgvReservation.Rows[i].Cells[9].Value.ToString() == "Đã nhận sân")
                    dgvReservation.Rows[i].Visible = true;
                else
                    dgvReservation.Rows[i].Visible = false;
            }
            ReloadGridFollowTimeByFilter(st, se);
        }
        private void btnGot_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Có xác nhận nhận sân?", "Caution", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            RESERVATION rev = new RESERVATION();
            int i = dgvReservation.SelectedRows.Count - 1;
            string str = dgvReservation.SelectedRows[i].Cells[0].Value.ToString();
            rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == str);
            if (DateTime.Compare(DateTime.Now,rev.StartTime.Value)>=0)
            {
                rev.C_Status = 2;
                dgvReservation.SelectedRows[i].Cells[9].Value = "Đã nhận sân";
                context.RESERVATION.AddOrUpdate(rev);
                context.SaveChanges();
                btnRevReceipt.Enabled = true;
                btnGot.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa đến giờ nhận sân","Thông báo");
            }
        }
        private void btnCancel_EnabledChanged_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Enabled==true)
                btn.ForeColor = Color.Black;
            else
                btn.ForeColor = Color.White;
        }
    }
}
