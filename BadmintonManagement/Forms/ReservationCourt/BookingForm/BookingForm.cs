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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            dtpStartTime.CustomFormat = "HH:mm";
            dtpEndTime.CustomFormat = "HH:mm";
            dtpEndTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            dtpStartTime.Value = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, 0, 0, 0);
            ModelBadmintonManage context = new ModelBadmintonManage();
            List<COURT> listCourt = context.COURT.ToList();
            fillcboCourtName(listCourt);
        }

        private void fillcboCourtName(List<COURT> listCourt)
        {

            cboCourt.DataSource = listCourt;
            cboCourt.DisplayMember = "CourtName";
            cboCourt.ValueMember = "CourtID";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string revNo = rnd.Next(100, 999).ToString();

        }
    }
}
