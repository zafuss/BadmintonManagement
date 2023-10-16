using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint;
using BadmintonManagement.Forms.Service.ServiceReceipt.Print;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Receipt
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
        }
        ModelBadmintonManage context = new ModelBadmintonManage();
        DateTime st;
        DateTime se;
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            List<RECEIPT> listREC = context.RECEIPT.ToList();
            List<SERVICE_RECEIPT> listSERREC = context.SERVICE_RECEIPT.ToList();
            BindGrid(listREC,listSERREC);
            DateTime d = DateTime.Now;
            dtpFrom.Value = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
            dtpTo.Value = new DateTime(d.Year,d.Month,d.Day,23,59,59);
        }
        private void BindGrid(List<RECEIPT> listREC,List<SERVICE_RECEIPT> listSERREC)
        {
            dgvInfo.Rows.Clear();
            foreach(RECEIPT rec in listREC) 
            {
                int i = dgvInfo.Rows.Add();
                int d = 0;
                dgvInfo.Rows[i].Cells[d++].Value = rec.ReceiptNo;
                dgvInfo.Rows[i].Cells[d++].Value = rec.C_Date;
                dgvInfo.Rows[i].Cells[d++].Value = rec.Username;
                dgvInfo.Rows[i].Cells[d++].Value = rec.RESERVATION.PhoneNumber;
            }
            foreach(SERVICE_RECEIPT serrec in listSERREC)
            {
                int i = dgvInfo.Rows.Add();
                int d = 0;
                dgvInfo.Rows[i].Cells[d++].Value = serrec.ServiceReceiptNo;
                dgvInfo.Rows[i].Cells[d++].Value = serrec.CreateDate;
                dgvInfo.Rows[i].Cells[d++].Value = serrec.Username;
                dgvInfo.Rows[i].Cells[d++].Value = serrec.PhoneNumber;
            }
        }
        Form activeForm = null;
        private void OpenForm(Form frm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = frm;
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnlPrintReceipt.Controls.Add(frm);
            frm.Show();
        }
        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvInfo.SelectedRows.Count - 1;
            string str = dgvInfo.SelectedRows[i].Cells[0].Value.ToString();
            if (context.RECEIPT.Any(p => p.ReceiptNo == str))
            {
                str = context.RECEIPT.FirstOrDefault(p => p.ReceiptNo == str).ReservationNo.ToString();
                OpenForm(new RevReceiptPrint(str));
            }
            else
                OpenForm(new SerRecPrint(str));
        }
        private bool CheckContain(DataGridViewRow row)
        {
            for (int d = 0; d < dgvInfo.ColumnCount; d++)
            {
                if (row.Cells[d].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    return true;
            }
            return false;
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInfo.Rows.Count; i++)
            {
                if (CheckContain(dgvInfo.Rows[i]) == true)
                    dgvInfo.Rows[i].Visible = true;
                else
                    dgvInfo.Rows[i].Visible = false;
            }
            ReloadGridFolowTime(st,se);
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.SelectAll();
        }
        private void ReloadGridWhenTimeChanged(DateTime st, DateTime se)
        {
            foreach (DataGridViewRow row in dgvInfo.Rows)
            {
                DateTime d = DateTime.Parse(row.Cells[1].Value.ToString());
                if (DateTime.Compare(d,st) <= 0 || DateTime.Compare(d,se) >= 0)
                    row.Visible = false;
                else 
                    row.Visible = true;
            }
            txtSearch.Text = string.Empty;
        }
        private void ReloadGridFolowTime(DateTime st,DateTime se)
        {
            foreach(DataGridViewRow row in dgvInfo.Rows)
            {
                DateTime d = DateTime.Parse(row.Cells[1].Value.ToString());
                if (DateTime.Compare(d,st)<=0||DateTime.Compare(d,se)>=0)
                    row.Visible = false;
            }
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = dtpFrom.Value;
            st = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0);
            ReloadGridWhenTimeChanged(dtpFrom.Value,dtpTo.Value);
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime d= dtpTo.Value;
            se = new DateTime(d.Year, d.Month, d.Day, 23, 59, 59);
            ReloadGridWhenTimeChanged(dtpFrom.Value,dtpTo.Value);
        }
        private void btnGetAll_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvInfo.Rows)
                row.Visible= true;
        }

        private void panelHeader_SizeChanged(object sender, EventArgs e)
        {
            panelHeader.Controls.Clear();
            double width = (panelHeader.Width);
            double height = (panelHeader.Height) / 4;

            Label label = new Label();
            label.Location = new Point(0, Convert.ToInt32(height));
            label.Size = new Size(Convert.ToInt32(width), 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Danh Sách Hóa Đơn";
            label.Font = new Font("Segoe UI", 24, FontStyle.Bold);

            panelHeader.Controls.Add(label);
        }
    }
}
