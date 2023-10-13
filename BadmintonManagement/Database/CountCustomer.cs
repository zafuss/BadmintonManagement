using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class CountCustomer
    {
        private string fullName;
        private string phoneNumber;
        private string email;
        private string solan;

        public CountCustomer()
        {
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Solan { get => solan; set => solan = value; }
    }
}
