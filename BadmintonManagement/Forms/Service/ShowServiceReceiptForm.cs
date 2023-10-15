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
                dgvServiceReceipt.Rows[index].Cells[1].Value = item.CreateDate.ToString("dd/MM/yyyy");
                dgvServiceReceipt.Rows[index].Cells[2].Value = item.PhoneNumber;
                dgvServiceReceipt.Rows[index].Cells[3].Value = item.C_USER.C_Name;
                dgvServiceReceipt.Rows[index].Cells[4].Value = item.Total;
                dgvServiceReceipt.Rows[index].Cells[5].Value = item.Payment;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string find = txtSearch.Text;
            dgvServiceReceipt.Rows.Clear();
            List<SERVICE_RECEIPT> ervice = ServiceReceiptServices.GetAllServiceReceipt();
            foreach (SERVICE_RECEIPT ser in ervice)
            {
                string str = ser.C_USER.C_Name+ser.CUSTOMER+ser.PhoneNumber+ser.CreateDate.ToString("dd/MM/yyyy")+ser.Payment;
                if (str.Contains(find))
                {
                    int index = dgvServiceReceipt.Rows.Add();
                    dgvServiceReceipt.Rows[index].Cells[0].Value = ser.ServiceReceiptNo;
                    dgvServiceReceipt.Rows[index].Cells[1].Value = ser.CreateDate.ToString("dd/MM/yyyy");
                    dgvServiceReceipt.Rows[index].Cells[2].Value = ser.PhoneNumber;
                    dgvServiceReceipt.Rows[index].Cells[3].Value = ser.C_USER.C_Name;
                    dgvServiceReceipt.Rows[index].Cells[4].Value = ser.Total;
                    dgvServiceReceipt.Rows[index].Cells[5].Value = ser.Payment;
                }
                     
            }
            


        }
    }
}
