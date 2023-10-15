using BadmintonManagement.Database;
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

namespace BadmintonManagement.Forms.Price
{
    public partial class PriceForm : Form
    {
        List<PRICE> prices;
        public PriceForm()
        {
            InitializeComponent();
        }
        public static string GBPriceID;
        private void PriceForm_Load(object sender, EventArgs e)
        {
            
            BindGrid();
        }
        private void RefreshTexbox()
        {
            txtPriceID.Text = txtPriceTag.Text = txtDateFactor.Text = txtTimeFactor.Text=string.Empty;
            
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
                else
                {
                    dgvPrices.Rows[index].Cells[4].Value = "Áp dụng";
                    GBPriceID = price.PriceID;
                }
                  
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
                price.TimeFactor = Math.Round(timeFactor,2);
                price.DateFactor = Math.Round(dateFactor,2);
                price.C_Status = 0;
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
            int i = dgvPrices.SelectedRows.Count - 1;
            if (dgvPrices.SelectedRows[i].Cells[4].Value.ToString() == "Áp dụng")
            {
                MessageBox.Show("Giá đã được áp dụng","Thông báo");
                return;
            }
            ModelBadmintonManage context = new ModelBadmintonManage();
            PRICE pr = new PRICE();
            string str = dgvPrices.SelectedRows[i].Cells[0].Value.ToString();
            pr = context.PRICE.FirstOrDefault(p => p.PriceID == str);
            pr.C_Status = 1;
            dgvPrices.SelectedRows[i].Cells[4].Value = "Áp dụng";
            GBPriceID = pr.PriceID;
            cmbStatus.SelectedIndex = 1;
            context.PRICE.AddOrUpdate(pr);
            context.SaveChanges();
            List<PRICE> listPR = context.PRICE.Where(p=>p.PriceID!=pr.PriceID).ToList();
            foreach(PRICE item in listPR)
            {
                if(item.C_Status==1)
                {
                    item.C_Status = 0;
                    context.PRICE.AddOrUpdate(item);
                    context.SaveChanges();
                    str = item.PriceID;
                    break;
                }
            }
            foreach(DataGridViewRow row in dgvPrices.Rows) 
            {
                if (row.Cells[0].Value.ToString() == str)
                {
                    row.Cells[4].Value = "Không áp dụng";
                    break;
                }
            }
            //BindGrid();
        }
    }
}
