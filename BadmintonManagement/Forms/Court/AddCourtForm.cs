﻿using BadmintonManagement.Models;
using BadmintonManagement.Function.CourtService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BadmintonManagement.Forms.Court
{
    public partial class AddCourtForm : Form
    {
        private List<string> _status = new List<string>()
        {
           "Chưa Được Sử Dụng","Đang Sử Dụng","Bảo Trì"
        };

        public AddCourtForm()
        {
            InitializeComponent();
            Loading();
            Reset();
        }
        private void Reset()
        {
            txtCourtName.Text = "";
            dtmStartDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cboBranchID.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboCourtID.SelectedIndex = -1;
        }
        private void Loading()
        {
            FillcboStatus(_status);
            FillcboBranch(new CourtService().getBranch());
            FillcboCourt(new CourtService().getListCourt());
        }

        private void FillcboCourt(List<COURT> courts)
        {
            courts.Insert(0, new COURT());
            this.cboCourtID.DataSource = courts.Where(p => p.C_Status != "Disable").ToList();
            this.cboCourtID.DisplayMember = "CourtID";
            this.cboCourtID.ValueMember = "CourtID";
        }

        private void FillcboStatus(List<string> status)
        {
            this.cboStatus.DataSource = status;
            cboStatus.SelectedIndex = 0; 
        }

        private void FillcboBranch(List<BRANCH> branchs)
        {
            this.cboBranchID.DataSource = branchs;
            this.cboBranchID.DisplayMember = "BranchName";
            this.cboBranchID.ValueMember = "BranchID";
        }


        private void txtCourtName_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"[@#$%^~&`|'""{}\[\]\-\\_\\()!*+=?.,><:;//]";
            if (Regex.IsMatch(txtCourtName.Text, pattern))
            {
                if (txtCourtName.TextLength == 0)
                {
                    txtCourtName.Text = "";
                }
                else
                {
                    txtCourtName.Text = txtCourtName.Text.Remove(txtCourtName.TextLength - 1);
                    txtCourtName.SelectionStart = txtCourtName.Text.Length;
                }
            }
        }

        private COURT SetCourt()
        {
            COURT newCourt = new COURT();
            if (cboCourtID.Text == string.Empty)
            {
                newCourt.CourtID = new CourtService().GetCourtID(cboBranchID.Text);
            }
            else
            {
               newCourt.CourtID = cboCourtID.Text;
            }

            if (cboStatus.SelectedIndex == 0)
            {
                newCourt.C_Status = "Used";
            }
            else if (cboStatus.SelectedIndex == 1)
            {
                newCourt.C_Status = "Use";
            }
            else
            {
                newCourt.C_Status = "Maintaince";
            }

            newCourt.CourtName = txtCourtName.Text;
            newCourt.StartDate = dtmStartDate.Value;
            newCourt.BranchID = new CourtService().GetBranchID(cboBranchID.Text);
            return newCourt;
        }

 
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourtName.Text == "")
                    return;
                if (cboCourtID.Text == string.Empty || !new CourtService().checkCourtID(cboCourtID.Text))
                {
                    COURT tmpCourt = SetCourt();
                    new CourtService().InsertCourt(tmpCourt);
                    MessageBox.Show("Them Thanh Cong");
                    Loading();
                    Reset();
                }
                else
                {
                    MessageBox.Show("Them Khong Thanh Cong");
                }               
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboBranchID.Text == string.Empty)
                { return; }
                COURT tmp = new CourtService().FindCourtByID(cboCourtID.Text);
                if ( tmp == null)
                {
                    throw new Exception("Xoa Khong Thanh Cong");
                }
                else 
                {
                    tmp.C_Status = "Disable";
                    new CourtService().InsertCourt(tmp);
                    MessageBox.Show("Xoa Thanh Cong");
                    Loading();
                    Reset();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboBranchID.Text == string.Empty)
                { return; }
                COURT tmp = new CourtService().FindCourtByID(cboCourtID.Text);
                if (tmp == null)
                {
                    throw new Exception("Sua Khong Thanh Cong");
                }
                else
                {
                    tmp = SetCourt();
                    new CourtService().InsertCourt(tmp);
                    MessageBox.Show("Sua Thanh Cong");
                    Loading();
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void cboCourtID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCourtID.Text != "")
            {
                COURT court = new CourtService().FindCourtByID(cboCourtID.Text);
                if( court != null )
                {
                    txtCourtName.Text = court.CourtName;
                    dtmStartDate.Text = court.StartDate.ToString();
                    cboBranchID.Text = court.BRANCH.BranchName;
                    if (court.C_Status.ToLower() == "used")
                    {
                        cboStatus.SelectedIndex = 0;
                    }
                    else if (court.C_Status.ToLower() == "use")
                    {
                        cboStatus.SelectedIndex = 1;
                    }
                    else if (court.C_Status.ToLower() == "maintaince")
                    {
                        cboStatus.SelectedIndex = 2;
                    }
                }
            }
            else if( cboCourtID.Text == "")
            {
                Reset();
            }
            
        }
    }
}