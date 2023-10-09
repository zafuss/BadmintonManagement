using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.BookingForm
{
    public partial class GetCustomerInformation : Form
    {
       
        public GetCustomerInformation()
        {
            InitializeComponent();
        }
        ModelBadmintonManage context = new ModelBadmintonManage();

        private void GetCustomerInformation_Load(object sender, EventArgs e)
        {
          
            List<CUSTOMER> listCus = context.CUSTOMER.ToList();
            fillAutoCompleteSourcebyPhone(listCus);
        }
        public delegate void ChangeRev(int i);
        public ChangeRev ReloadRev;

        private void fillAutoCompleteSourcebyPhone(List<CUSTOMER> listCus)
        {
            foreach (CUSTOMER customer in listCus)
            {
                txtPhoneNumber.AutoCompleteCustomSource.Add(customer.PhoneNumber);
            }
           
        }
        private void LoadCus(int i)
        {
            ReloadRev(i);
           
        }
        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            
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
                txtFullName.Text = context.CUSTOMER.FirstOrDefault(p => p.PhoneNumber == txtPhoneNumber.Text).FullName;
                txtFullName.ReadOnly = true;
                txtEmail.Text = context.CUSTOMER.FirstOrDefault(p => p.PhoneNumber == txtPhoneNumber.Text).Email;
                txtEmail.ReadOnly = true;
            }
            else
            {
               
                txtFullName.ReadOnly = false;
                txtEmail.ReadOnly = false;
            }
                
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(CheckExistPhoneNumber())
            {
                Booking frm = new Booking(txtPhoneNumber.Text,txtFullName.Text,txtEmail.Text);
                frm.ReloadBK = new Booking.ChangeBK(LoadCus);
                frm.ShowDialog();
                this.Close();
                
            }
            else
            {
                //Chọn lưu mới
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
