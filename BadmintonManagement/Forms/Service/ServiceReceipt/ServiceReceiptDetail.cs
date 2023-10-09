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
    public partial class ServiceReceiptDetail : Form
    {
        public ServiceReceiptDetail()
        {
            InitializeComponent();
        }
        ModelBadmintonManage context = new ModelBadmintonManage();
        private void ServiceReceiptDetail_Load(object sender, EventArgs e)
        {

        }
        private void BindGrid()
        {
            List<C_SERVICE> listService = 
        }
    }
}
