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
            BindGridService();
        }
        private void BindGridService()
        {
            List<C_SERVICE> listService = context.C_SERVICE.ToList();
            foreach(C_SERVICE item in listService)
            {
                int i = dgvService.Rows.Add();
                int d = 0;
                dgvService.Rows[i].Cells[d++].Value = item.ServiceName;
                dgvService.Rows[i].Cells[d++].Value = item.Quantity;
                dgvService.Rows[i].Cells[d++].Value = item.Unit;
                dgvService.Rows[i].Cells[d++].Value = item.Price;
            }
        }
    }
}
