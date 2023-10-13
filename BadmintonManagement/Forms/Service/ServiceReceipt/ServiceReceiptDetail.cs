using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
        public ServiceReceiptDetail(DataGridViewRowCollection dgvc)
        {
            InitializeComponent();
            BindGridService();
            BindGridServiceDetail(dgvc);
        }
        private void BindGridServiceDetail(DataGridViewRowCollection dgvc)
        {
            
            if (dgvc.Count > 1)
            {
                foreach (DataGridViewRow row in dgvc)
                {
                    if (row.Cells[0].Value == null)
                        return;
                    int index = dgvServiceDetail.Rows.Add();
                    for(int d=0;d<dgvServiceDetail.Columns.Count;d++)
                        dgvServiceDetail.Rows[index].Cells[d].Value = row.Cells[d].Value;
                    int j = ServiceIndex(row.Cells[0].Value.ToString());
                    if (j == -1) continue;
                    dgvService.Rows[j].Cells[1].Value = decimal.Parse(dgvService.Rows[j].Cells[1].Value.ToString()) - decimal.Parse(row.Cells[1].Value.ToString());
                }
            }
        }
        public delegate void DataFromGrid(DataGridViewRowCollection dgvc);
        public DataFromGrid GetDataFromGrid;
        ModelBadmintonManage context = new ModelBadmintonManage();
        private void ServiceReceiptDetail_Load(object sender, EventArgs e)
        {
            
        }
        private void BindGridService()
        {
            List<C_SERVICE> listService = context.C_SERVICE.ToList();
            foreach(C_SERVICE item in listService)
            {
                if(item.C_Status == "Enabled")
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
        private int ServiceIndex(string serviceName)
        {
            for (int i = 0; i < dgvService.Rows.Count - 1; i++)
            {
                if (serviceName == dgvService.Rows[i].Cells[0].Value.ToString())
                    return i;
            }
            return -1;
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvService.SelectedRows.Count-1;
            if (dgvService.SelectedRows[i].Index == dgvService.Rows.Count - 1)
            {
                txtServiceName.Text = string.Empty;
                nudTaken.Text = "0";
                nudTaken.Enabled = false;
                return;
            }
            txtServiceName.Text = dgvService.SelectedRows[i].Cells[0].Value.ToString();
            nudTaken.Maximum = decimal.Parse(dgvService.SelectedRows[i].Cells[1].Value.ToString());
            nudTaken.Text = "0";
            nudTaken.Enabled = true;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            C_SERVICE service = context.C_SERVICE.FirstOrDefault(p => p.ServiceName == txtServiceName.Text);
            txtTotal.Text = (service.Price*nudTaken.Value).ToString();
        }

        private int ExistedServiceDetail(string serviceName)
        {
            for(int i =0;i<dgvServiceDetail.Rows.Count-1;i++)
            {
                if (serviceName == dgvServiceDetail.Rows[i].Cells[0].Value.ToString())
                    return i;
            }
            return -1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtServiceName.Text == string.Empty||nudTaken.Value == 0) 
            {
                MessageBox.Show("Vui lòng chọn dịch vụ khả dụng","Thông báo");
            }
            else
            {
                int index = ExistedServiceDetail(txtServiceName.Text);
                int serviceIndex = ServiceIndex(txtServiceName.Text);
                if (index==-1)
                {
                    index = dgvServiceDetail.Rows.Add();
                    int d = 0;
                    dgvServiceDetail.Rows[index].Cells[d++].Value = txtServiceName.Text;
                    dgvServiceDetail.Rows[index].Cells[d++].Value = nudTaken.Value;
                    dgvServiceDetail.Rows[index].Cells[d++].Value = context.C_SERVICE.FirstOrDefault(p => p.ServiceName == txtServiceName.Text).Price;
                    dgvServiceDetail.Rows[index].Cells[d++].Value = decimal.Parse(txtTotal.Text);
                    dgvService.Rows[serviceIndex].Cells[1].Value =  decimal.Parse(dgvService.Rows[serviceIndex].Cells[1].Value.ToString()) - nudTaken.Value;
                    nudTaken.Text = "0";
                }
                else
                {
                    dgvServiceDetail.Rows[index].Cells[1].Value = decimal.Parse(dgvServiceDetail.Rows[index].Cells[1].Value.ToString()) + nudTaken.Value;
                    dgvServiceDetail.Rows[index].Cells[2].Value = decimal.Parse(dgvService.Rows[serviceIndex].Cells[3].Value.ToString());
                    dgvServiceDetail.Rows[index].Cells[3].Value = decimal.Parse(dgvServiceDetail.Rows[index].Cells[2].Value.ToString()) + decimal.Parse(txtTotal.Text);
                    dgvService.Rows[serviceIndex].Cells[1].Value = decimal.Parse(dgvService.Rows[serviceIndex].Cells[1].Value.ToString()) - nudTaken.Value;
                    nudTaken.Text = "0";
                }
              
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn lưu","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes) 
            {
                GetDataFromGrid(dgvServiceDetail.Rows);
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(dgvServiceDetail.Rows.Count == 1)
            {
                MessageBox.Show("Không có thông tin để xóa", "Thông báo");
                return;
            }
            if(dgvServiceDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn chi tiết dịch vụ để xóa", "Thông báo");
                return;
            }
            int index = dgvServiceDetail.SelectedRows[dgvServiceDetail.SelectedRows.Count - 1].Index;
            DataGridViewRow row = dgvServiceDetail.Rows[index];
            if(row.Cells[0].Value == null)
            {
                MessageBox.Show("Hàng không có chi tiết dịch vụ để xóa", "Thông báo");
                return;
            }
            int j = ServiceIndex(row.Cells[0].Value.ToString());
            dgvService.Rows[j].Cells[1].Value = decimal.Parse(dgvService.Rows[j].Cells[1].Value.ToString()) + decimal.Parse(row.Cells[1].Value.ToString());
            dgvServiceDetail.Rows.Remove(row);
        }
    }
}
