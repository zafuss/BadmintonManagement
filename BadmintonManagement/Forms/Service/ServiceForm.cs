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
    public partial class ServiceForm : Form
    {
        List<C_SERVICE> serviceList;
        string selectedServiceID;
        string selectedServiceName;
        public ServiceForm()
        {
            InitializeComponent();
        }

        private void ServiceForm_Load(object sender, EventArgs e)
        {
            BindGrid();
            btnDelService.Enabled = false;
        }

        private void refreshTextBox()
        {
            btnDelService.Enabled = false;
            txtServiceID.Text = txtUnit.Text = txtPrice.Text = nmrQuantity.Text = txtServiceName.Text = "";
        }

        private void BindGrid()
        {
            dgvServices.Rows.Clear();
            //userList = FirebaseHelper.UserList();
            serviceList = ServiceServices.GetAllService();
            foreach (var item in serviceList)
            {
                int index = dgvServices.Rows.Add();
                dgvServices.Rows[index].Cells[0].Value = item.ServiceID;
                dgvServices.Rows[index].Cells[1].Value = item.ServiceName;
                dgvServices.Rows[index].Cells[2].Value = item.Unit;
                dgvServices.Rows[index].Cells[3].Value = item.Price;
                dgvServices.Rows[index].Cells[4].Value = item.Quantity;
                dgvServices.Rows[index].Cells[5].Value = item.C_Status == "Enabled" ? "Kích hoạt" : "Vô hiệu hoá";


            }
            refreshTextBox();
        }



        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity;
                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                    throw new Exception("Đơn giá không hợp lệ!");
                if (!int.TryParse(nmrQuantity.Text, out quantity))
                    throw new Exception("Số lượng không hợp lệ!");
                if (txtServiceID.Text == "" || txtServiceName.Text == "" || txtUnit.Text == "" || nmrQuantity.Text == "" || txtPrice.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                C_SERVICE service = new C_SERVICE()
                {
                    ServiceID = txtServiceID.Text.ToUpper(),
                    ServiceName = txtServiceName.Text,
                    Unit = txtUnit.Text,
                    Quantity = quantity,
                    Price = price

                };
                //FirebaseHelper.RegisterUser(user);
                ServiceServices.AddSerivce(service, () => BindGrid());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void dgvServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int selectedRow = e.RowIndex;
                txtServiceID.Text = selectedServiceID = dgvServices.Rows[selectedRow].Cells[0].Value.ToString();
                txtServiceName.Text = selectedServiceName = dgvServices.Rows[selectedRow].Cells[1].Value.ToString();
                txtUnit.Text = dgvServices.Rows[selectedRow].Cells[2].Value.ToString();
                txtPrice.Text = dgvServices.Rows[selectedRow].Cells[3].Value.ToString();
                nmrQuantity.Text = dgvServices.Rows[selectedRow].Cells[4].Value.ToString();

                btnDelService.Enabled = true;
                if (dgvServices.Rows[selectedRow].Cells[5].Value.ToString() == "Vô hiệu hoá")
                    btnDelService.Text = "Kích hoạt";
                else
                    btnDelService.Text = "Vô hiệu hoá";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity;
                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                    throw new Exception("Đơn giá không hợp lệ!");
                if (!int.TryParse(nmrQuantity.Text, out quantity))
                    throw new Exception("Số lượng không hợp lệ!");
                if (txtServiceName.Text == "" || txtServiceID.Text == "" || nmrQuantity.Text == "" || txtPrice.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!");
                C_SERVICE service = new C_SERVICE()
                {
                    ServiceID = txtServiceID.Text.ToUpper(),
                    ServiceName = txtServiceName.Text,
                    Unit = txtUnit.Text,
                    Quantity = quantity,
                    Price = price

                };
               ServiceServices.UpdateService(service, selectedServiceID, selectedServiceName);
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btnDelService_Click(object sender, EventArgs e)
        {
            try
            {
                //FirebaseHelper.DeleteUser(selectedUsername);
                ServiceServices.DisableService(selectedServiceName);
                MessageBox.Show("Thay đổi trạng thái dịch vụ thành công!");
                BindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvServices.CurrentCell = null;

            foreach (DataGridViewRow row in dgvServices.Rows)
            {
                if (row.Cells["clnServiceName"].Value != null)
                {
                    if (row.Cells["clnServiceName"].Value.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        row.Visible = true;
                        row.Selected = false;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtSearch);
            double width = (panel2.Width);
            double height = (panel2.Height) / 2.5;

            Label label = new Label();
            label.Location = new Point(0, Convert.ToInt32(height));
            label.Size = new Size(Convert.ToInt32(width), 50);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = "Danh Sách Dịch vụ";
            label.Font = new Font("Segoe UI", 24, FontStyle.Bold);

            panel2.Controls.Add(label);
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))   
                e.Handled = true;
        }

 
    }
}
