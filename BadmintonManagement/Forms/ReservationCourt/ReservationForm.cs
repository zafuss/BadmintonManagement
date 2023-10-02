using BadmintonManagement.Forms.ReservationCourt.BookingForm;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ReservationForm()
        {
            InitializeComponent();
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
            dtpStartDay.Value = DateTime.Now;
            dtpEndDay.Value = DateTime.Now;
           
            List<RESERVATION> listRev = context.RESERVATION.ToList();
            bindGrid(listRev);
            pnlFunction.Visible = true;
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
                return "Đã thanh toán";
            if (d == 4)
                return "Quá giờ nhận sân";
            if (d == 5)
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
                DateTime d = item.CreateDate.Value;
                
                dgvReservation.Rows[i].Cells[5].Value = item.CreateDate;
                dgvReservation.Rows[i].Cells[6].Value = item.BookingDate;
                dgvReservation.Rows[i].Cells[7].Value = PickStatus(item);

            }
        }

        private void loadRevData(string revNo, string userName, string phoneNumber, string courtID, decimal deposite, DateTime createDate, DateTime bookingDate)
        {
            ModelBadmintonManage context = new ModelBadmintonManage();
            RESERVATION rev = new RESERVATION();
            rev.ReservationNo = revNo;
            rev.Username = userName;
            rev.PhoneNumber = phoneNumber;
            rev.Deposite = deposite;
            rev.BookingDate = bookingDate;
            rev.CreateDate = createDate;
            context.RESERVATION.Add(rev);
            context.SaveChanges();

        }

        private void dtpStartDay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvReservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpEndDay_ValueChanged(object sender, EventArgs e)
        {
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

        private void txtSearchByPhoneNumber_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dgvReservation.Rows.Count - 1; i++)
            {
                if (dgvReservation.Rows[i].Cells[2].Value != null)
                {
                    if (dgvReservation.Rows[i].Cells[2].Value.ToString().Contains(txtSearchByPhoneNumber.Text))
                        dgvReservation.Rows[i].Visible = true;
                    else
                        dgvReservation.Rows[i].Visible = false;
                }
                else
                {
                    if (txtSearchByPhoneNumber.TextLength > 0)
                        dgvReservation.Rows[i].Visible = false;
                    else
                        dgvReservation.Rows[i].Visible = true;
                }

            }
        }
        private void txtSearchByPhoneNumber_Click(object sender, EventArgs e)
        {
            txtSearchByPhoneNumber.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GetCustomerInformation frm = new GetCustomerInformation();
            frm.Show();
        }

        private void btnDetailRF_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvReservation.Rows.Count < 2)
                    throw new Exception("No data");
                if (dgvReservation.SelectedRows.Count == 0)
                    throw new Exception("Please pick a RevNo to view");
                Booking frm = new Booking(dgvReservation.SelectedRows[0].Cells[0].Value.ToString());
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Có thật sự muốn hủy","Caution",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvReservation.SelectedRows[0].Cells[7].Value = "Đã hủy";
                string str = dgvReservation.SelectedRows[0].Cells[0].Value.ToString();
                RESERVATION rev = context.RESERVATION.FirstOrDefault(p => p.ReservationNo == str);
                rev.C_Status = 5;
                List<RF_DETAIL> listrf = context.RF_DETAIL.ToList(); 
                foreach(RF_DETAIL rf in listrf)
                {
                    if(rf.ReservationNo == rev.ReservationNo)
                        context.RF_DETAIL.Remove(rf);
                    context.SaveChanges();
                }
                context.RESERVATION.AddOrUpdate(rev);
                context.SaveChanges();
                btnCancel.Enabled = false;
                MessageBox.Show("Đã hủy");
            }
        }

        private void dgvReservation_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservation.SelectedRows.Count < 1)
                return;
            if (dgvReservation.Rows[dgvReservation.Rows.Count-1].Selected)
                btnCancel.Enabled = false;
            else if (dgvReservation.SelectedRows[0].Cells[7].Value.ToString() == "Chưa đặt cọc")
                btnCancel.Enabled = true;
            else
                btnCancel.Enabled = false;
        }
    }
}
