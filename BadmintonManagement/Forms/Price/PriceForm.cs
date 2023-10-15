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

namespace BadmintonManagement.Forms.Price
{
    public partial class PriceForm : Form
    {
        List<PRICE> prices;
        public PriceForm()
        {
            InitializeComponent();
        }

        private void PriceForm_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 1;
            BindGrid();
        }
        private void RefreshTexbox()
        {
            txtPriceID.Text = txtPriceTag.Text = txtDateFactor.Text = txtTimeFactor.Text=string.Empty;
            cmbStatus.SelectedIndex = 1;
        }
        private void BindGrid()
        {
            dgvPrices.Rows.Clear();
            prices = PriceServices.GetAllPrice();
            foreach (PRICE price in prices) 
            {
                int index = dgvPrices.Rows.Add();
                dgvPrices.Rows[index].Cells[0].Value = price.PriceID;
                dgvPrices.Rows[index].Cells[1].Value = price.PriceTag;
                dgvPrices.Rows[index].Cells[2].Value = price.TimeFactor;
                dgvPrices.Rows[index].Cells[3].Value = price.DateFactor;
                if (price.C_Status == 0)
                    dgvPrices.Rows[index].Cells[4].Value = "Không áp dụng";
                else if (price.C_Status == 1)
                    dgvPrices.Rows[index].Cells[4].Value = "Áp dụng";
            }
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            try
            {
                float timeFactor, dateFactor;
                decimal priceTag;
                if (!decimal.TryParse(txtPriceTag.Text, out priceTag))
                    throw new Exception("Đơn giá không hợp lệ!");
                if (!float.TryParse(txtTimeFactor.Text, out timeFactor))
                    throw new Exception("Hệ số thời gian không hợp lệ!");
                if (!float.TryParse(txtDateFactor.Text, out dateFactor))
                    throw new Exception("Hệ số ngày không hợp lệ!");
                if (txtDateFactor.Text == "" || txtPriceID.Text == "" || txtPriceTag.Text == "" || txtTimeFactor.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");

                PRICE price = new PRICE();
                price.PriceID = txtPriceID.Text.ToUpper();
                price.PriceTag = decimal.Parse(txtPriceTag.Text);
                price.TimeFactor = timeFactor;
                price.DateFactor = dateFactor;
                if (cmbStatus.Text == "Không áp dụng")
                    price.C_Status = 0;
                else if (cmbStatus.Text == "Áp dụng")
                    price.C_Status = 1;
                PriceServices.AddPrice(price);
                BindGrid();        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPrices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.RowIndex >= 0)
                {
                    int index = e.RowIndex;
                    txtPriceID.Text = dgvPrices.Rows[index].Cells[0].Value.ToString();
                    txtPriceTag.Text = dgvPrices.Rows[index].Cells[1].Value.ToString();
                    txtTimeFactor.Text = dgvPrices.Rows[index].Cells[2].Value.ToString();
                    txtDateFactor.Text = dgvPrices.Rows[index].Cells[3].Value.ToString();
                    cmbStatus.Text = dgvPrices.Rows[index].Cells[4].Value.ToString();   
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUsedPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
