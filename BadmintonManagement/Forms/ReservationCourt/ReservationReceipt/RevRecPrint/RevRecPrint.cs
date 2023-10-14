using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt.RevRecPrint
{
    public partial class RevRecPrint : Form
    {
        public RevRecPrint()
        {
            InitializeComponent();
        }

        private void RevRecPrint_Load(object sender, EventArgs e)
        {

            this.rpvPrint.RefreshReport();
           
        }
    }
}
