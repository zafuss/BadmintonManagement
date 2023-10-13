using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadmintonManagement.Database
{
    public class ReportServiceInStoge
    {
        private string serviceID;
        private string serviceName;
        private string unit;
        private string quantity;

        public ReportServiceInStoge()
        {
        }

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string Unit { get => unit; set => unit = value; }
        public string Quantity { get => quantity; set => quantity = value; }
    }
}
