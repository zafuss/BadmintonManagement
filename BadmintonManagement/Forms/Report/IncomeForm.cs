using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Report
{
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

            this.incomeOfYearTableAdapter.Fill(this.incomeOfYear._IncomeOfYear, int.Parse(dtpYear.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
