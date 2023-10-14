using BadmintonManagement.Forms.Service.ServiceReceipt.Print;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
        public ServiceRec(string serviceRecNo)
        {
            InitializeComponent();
            this.serviceRecNo = serviceRecNo;
            isNew = false;
        }
        string serviceRecNo;
        bool isNew=true;
        private void BindGrid(List<SERVICE_DETAIL> listSD)
        {
            dgvServiceDetail.Rows.Clear();
            foreach(SERVICE_DETAIL item in listSD) 
            {
                int index = dgvServiceDetail.Rows.Add();
                int d = 0;
                dgvServiceDetail.Rows[index].Cells[d++].Value = item.C_SERVICE.ServiceName;
                dgvServiceDetail.Rows[index].Cells[d++].Value = item.Quantity;
                dgvServiceDetail.Rows[index].Cells[d++].Value = item.C_SERVICE.Price;
                dgvServiceDetail.Rows[index].Cells[d++].Value = item.Quantity*item.C_SERVICE.Price;
            }
        }
        ModelBadmintonManage context = new ModelBadmintonManage();
        public delegate void ChangeServiceReceipt(int i);
        public ChangeServiceReceipt ReloadShowServiceReceipt;
        private string GenerateServiceRecNo()
        {
            DateTime d1 = DateTime.Now.Date;
            DateTime d2 = new DateTime(d1.Year, d1.Month, d1.Day, 23, 59, 59);
            string s = context.SERVICE_RECEIPT.Count(p => DateTime.Compare(p.CreateDate.Value, d1) >= 0 && DateTime.Compare(p.CreateDate.Value, d2) <= 0).ToString();
            while (s.Length < 4)
            {
                s = 0 + s;
            }
            return "Ser" + string.Format("{0:ddMMyy}", DateTime.Now) + s;
        }
        private void ServiceReciept_Load(object sender, EventArgs e)
        {
            if(isNew == true) 
            {
                txtRecNo.Text = GenerateServiceRecNo();
                txtUser.Text = Properties.Settings.Default.Username;
                FillCustomerPhoneNumber();
                txtTotal.Text = GetTheTotal().ToString();
            }
            else
            {
                if (serviceRecNo == null)
                {
                    MessageBox.Show("Lỗi không tìm được hóa đơn", "Thông báo");
                    this.Close();
                    return;
                }
                SERVICE_RECEIPT s = context.SERVICE_RECEIPT.FirstOrDefault(p => p.ServiceReceiptNo == serviceRecNo);
                BindGrid(s.SERVICE_DETAIL.ToList());
                txtRecNo.Text = s.ServiceReceiptNo;
                txtUser.Text = s.Username;
                if (s.PhoneNumber == null)
                {
                    txtPhoneNumber.Text = string.Empty;
                    txtCustomerName.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                }
                else
                {
                    txtPhoneNumber.Text = s.PhoneNumber;
                    if (s.CUSTOMER.FullName == null)
                        txtCustomerName.Text = string.Empty;
                    else
                        txtCustomerName.Text = s.CUSTOMER.FullName;
                    if (s.CUSTOMER.Email == null)
                        txtEmail.Text = string.Empty;
                    else
                        txtEmail.Text = s.CUSTOMER.Email;
                }
                txtRecNo.Enabled = false;
                txtTotal.Text = s.Total.ToString();
                btnPayment.Visible = false;
                btnServiceRecDetail.Visible = false;
                txtPhoneNumber.Enabled = false;
                txtCustomerName.Enabled = false;
                txtEmail.Enabled = false;
                btnPrint.Visible = true;
            }
            
        }
        private decimal GetTheTotal()
        {
            decimal total = 0;
            foreach(DataGridViewRow row in dgvServiceDetail.Rows)
            {
                if (row.Cells[0].Value == null)
                    break;
                total += Decimal.Parse(row.Cells[3].Value.ToString());
            }
            return total;
        }
        private void LoadServiceDetailGrid(DataGridViewRowCollection dgv)
        {
            dgvServiceDetail.Rows.Clear();
            for(int i =0; i<dgv.Count-1;i++)
            {
                dgvServiceDetail.Rows.Add();
                dgvServiceDetail.Rows[i].Cells[0].Value = dgv[i].Cells[0].Value;
                dgvServiceDetail.Rows[i].Cells[1].Value = dgv[i].Cells[1].Value;
                dgvServiceDetail.Rows[i].Cells[2].Value = dgv[i].Cells[2].Value;
                dgvServiceDetail.Rows[i].Cells[3].Value = dgv[i].Cells[3].Value;
            }
            txtTotal.Text = GetTheTotal().ToString();
        }
        private void bntServiceRecDetail_Click(object sender, EventArgs e)
        {
            ServiceReceiptDetail frm = new ServiceReceiptDetail(dgvServiceDetail.Rows);
            frm.GetDataFromGrid = new ServiceReceiptDetail.DataFromGrid(LoadServiceDetailGrid);
            frm.ShowDialog();
        }
        private void FillCustomerPhoneNumber()
        {
            foreach(CUSTOMER item in context.CUSTOMER)
            {
                txtPhoneNumber.AutoCompleteCustomSource.Add(item.PhoneNumber);
            }
        }
        private bool CheckExistPhoneNumber()
        {
            if (context.CUSTOMER.Any(p => p.PhoneNumber == txtPhoneNumber.Text))
                return true;
            return false;
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (CheckExistPhoneNumber())
            {
                txtCustomerName.Text = context.CUSTOMER.FirstOrDefault(p => p.PhoneNumber == txtPhoneNumber.Text).FullName;
                txtCustomerName.ReadOnly = true;
                txtEmail.Text = context.CUSTOMER.FirstOrDefault(p => p.PhoneNumber == txtPhoneNumber.Text).Email;
                txtEmail.ReadOnly = true;
            }
            else
            {

                txtCustomerName.ReadOnly = false;
                txtEmail.ReadOnly = false;
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Ban có muốn xác nhận thanh toán?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if (CheckExistPhoneNumber() == false)
                {
                    if (txtPhoneNumber.Text != string.Empty)
                    {
                        CUSTOMER c = new CUSTOMER();
                        c.PhoneNumber = txtPhoneNumber.Text;
                        c.FullName = txtCustomerName.Text;
                        c.Email = txtEmail.Text;
                        context.CUSTOMER.Add(c);
                        context.SaveChanges();
                    }
                }
                SERVICE_RECEIPT sr = new SERVICE_RECEIPT();
                sr.ServiceReceiptNo = txtRecNo.Text;
                sr.Username = Properties.Settings.Default.Username;
                sr.CreateDate = DateTime.Now;
                sr.Total = GetTheTotal();
                if(txtPhoneNumber.Text != string.Empty)
                    sr.PhoneNumber = txtPhoneNumber.Text;
                context.SERVICE_RECEIPT.Add(sr);
                context.SaveChanges();
                foreach(DataGridViewRow row in dgvServiceDetail.Rows)
                {
                    if (row.Cells[0].Value == null)
                        break;
                    SERVICE_DETAIL sd = new SERVICE_DETAIL();
                    sd.ServiceReceiptNo = sr.ServiceReceiptNo;
                    string serviceName = row.Cells[0].Value.ToString();
                    sd.ServiceID = context.C_SERVICE.FirstOrDefault(p => p.ServiceName == serviceName).ServiceID;
                    sd.Quantity = int.Parse(row.Cells[1].Value.ToString());
                    context.SERVICE_DETAIL.Add(sd);
                    context.SaveChanges();
                    C_SERVICE ser = context.C_SERVICE.FirstOrDefault(p => p.ServiceName == serviceName);
                    ser.Quantity = ser.Quantity.Value - sd.Quantity.Value;
                    context.C_SERVICE.AddOrUpdate(ser);
                    context.SaveChanges();
                }
                ReloadShowServiceReceipt(1);
                this.Close();
                SerRecPrint frm = new SerRecPrint(txtRecNo.Text);
                frm.ShowDialog();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SerRecPrint frm = new SerRecPrint(txtRecNo.Text);
            frm.ShowDialog();
        }
    }
}
