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
    public partial class IncomeReportForm : Form
    {
        public IncomeReportForm()
        {
            InitializeComponent();
            
        }
        Form activeForm = null;
        private void OpenChilForm(Form chilForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = chilForm;
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;    
            chilForm.Dock = DockStyle.Fill;
            pnlIncome.Controls.Add(chilForm);
            pnlIncome.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChilForm(new IncomeForm());
        }
    }
}
