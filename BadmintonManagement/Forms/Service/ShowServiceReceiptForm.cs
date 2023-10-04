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

        private void BindGrid()
        {
            serviceReceiptList = ServiceReceiptServices.GetAllServiceReceipt();
            foreach (var item in serviceReceiptList)
            {          
                int index = dgvServiceReceipt.Rows.Add();
                dgvServiceReceipt.Rows[index].Cells[0].Value = item.ServiceReceiptNo;
                dgvServiceReceipt.Rows[index].Cells[1].Value = item.CreateDate;
                dgvServiceReceipt.Rows[index].Cells[2].Value = item.C_USER.C_Name;
                dgvServiceReceipt.Rows[index].Cells[3].Value = item.PhoneNumber;
                dgvServiceReceipt.Rows[index].Cells[4].Value = item.Total;
            }
        }
    }
}
