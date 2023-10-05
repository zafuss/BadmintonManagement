﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt
{
    public partial class RevReceipt : Form
    {
        public RevReceipt()
        {
            InitializeComponent();
        }
        string revNo;
        public RevReceipt(string reservationNo)
        {
            InitializeComponent();
            revNo = reservationNo;
        }

        private void RevReceipt_Load(object sender, EventArgs e)
        {
            dtpTimePublish.Value = DateTime.Now;
            string revReceiptNo = "Rec"+ revNo.Substring(3);
            txtReceiptNo.Text = revReceiptNo;
        }
    }
}
