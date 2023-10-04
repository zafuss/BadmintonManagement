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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
