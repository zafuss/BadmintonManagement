using BadmintonManagement.Database;
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

namespace BadmintonManagement.Forms.Service
{
    public partial class ShowServiceReceiptForm : Form
    {
        List<SERVICE_RECEIPT> serviceReceiptList;
        public ShowServiceReceiptForm()
        {
            InitializeComponent();
            BindGrid();
        }
        public delegate void GetTheChosenServiceReceipt(string serviceRecNo);
        public GetTheChosenServiceReceipt TheChosenServiceReceipt;
        private void BindGrid()
        {
            dgvServiceReceipt.Rows.Clear();
            serviceReceiptList = ServiceReceiptServices.GetAllServiceReceipt();
            foreach (var item in serviceReceiptList)
            {   
                int index = dgvServiceReceipt.Rows.Add();
                dgvServiceReceipt.Rows[index].Cells[0].Value = item.ServiceReceiptNo;
                dgvServiceReceipt.Rows[index].Cells[1].Value = item.CreateDate;
                dgvServiceReceipt.Rows[index].Cells[2].Value = item.PhoneNumber;
                dgvServiceReceipt.Rows[index].Cells[3].Value = item.C_USER.C_Name;
                dgvServiceReceipt.Rows[index].Cells[4].Value = item.Total;
            }
        }
        private void LoadGrid(int i)
        {
            BindGrid();
        }
 
        private void dgvServiceReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvServiceReceipt.SelectedRows.Count - 1;
            string serviceRecNo = dgvServiceReceipt.SelectedRows[i].Cells[0].Value.ToString();
            TheChosenServiceReceipt(serviceRecNo);
        }
    }
}
