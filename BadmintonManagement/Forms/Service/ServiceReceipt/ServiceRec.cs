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

namespace BadmintonManagement.Forms.Service.ServiceReceipt
{
    public partial class ServiceRec : Form
    {
        public ServiceRec()
        {
            InitializeComponent();
        }
        ModelBadmintonManage context = new ModelBadmintonManage();
        private string GenerateServiceRecNo()
        {
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = new DateTime(d1.Year, d1.Month, d1.Day, 23, 59, 59);
            string s = context.RECEIPT.Count(p => DateTime.Compare(p.C_Date.Value, d1) >= 0 && DateTime.Compare(p.C_Date.Value, d2) <= 0).ToString();
            while (s.Length < 4)
            {
                s = 0 + s;
            }
            return "Ser" + string.Format("{0:ddMMyy}", DateTime.Now) + s;
        }
        private void ServiceReciept_Load(object sender, EventArgs e)
        {
            txtRecNo.Text = GenerateServiceRecNo();
            txtUser.Text = Properties.Settings.Default.Username;
           
        }

        private void bntServiceRecDetail_Click(object sender, EventArgs e)
        {
            ServiceReceiptDetail frm = new ServiceReceiptDetail();
            frm.ShowDialog();
        }
        private void FillCustomerPhoneNumber()
        {
            foreach(CUSTOMER item in context.CUSTOMER)
            {
                txtPhoneNumber.AutoCompleteCustomSource.Add (item.PhoneNumber);
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
