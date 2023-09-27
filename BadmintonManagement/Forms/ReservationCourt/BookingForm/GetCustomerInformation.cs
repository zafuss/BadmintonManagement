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
    public partial class GetCustomerInformation : Form
    {
        public GetCustomerInformation()
        {
            InitializeComponent();
        }


        private void GetCustomerInformation_Load(object sender, EventArgs e)
        {
           ModelBadmintonManage context = new ModelBadmintonManage();
            List<CUSTOMER> listCus = context.CUSTOMERs.ToList();
            fillAutoCompleteSourcebyPhone(listCus);
        }

        private void fillAutoCompleteSourcebyPhone(List<CUSTOMER> listCus)
        {
            foreach (CUSTOMER customer in listCus)
            {
                txtPhoneNumber.AutoCompleteCustomSource.Add(customer.PhoneNumber);
            }
        }

    }
}
