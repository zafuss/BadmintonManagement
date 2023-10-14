using BadmintonManagement.Models;
using BadmintonManagement.Database;
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
using System.Web;
using System.Activities.Expressions;

namespace BadmintonManagement.Forms.Court
{
    public partial class AddCourtForm : Form
    {
        public static AddCourtForm Instance; 
        private List<string> status = new List<string>()
        {
           "Đã Đi Vào Hoạt Động","Bảo Trì"
        };

        public AddCourtForm()
        {
            Instance = this;
            InitializeComponent();
            Loading();
            Reset();
            var acsc = new AutoCompleteStringCollection();
            acsc.AddRange(new CourtService().getBrachName().ToArray());
            txtCourtName.AutoCompleteCustomSource = acsc;
            txtCourtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
           
            //txtCourtName.Text = acsc[1].ToString();
        }
        public void Reset()
        {
            txtCourtName.Text = "";
            cboBranchID.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboCourtID.SelectedIndex = -1;
        }
        private void Loading()
        {
            FillcboStatus(status);
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

        public void FillCourt(COURT newCourt)
        {
            cboCourtID.Text = newCourt.CourtID;
            cboStatus.Text = newCourt.C_Status;
            txtCourtName.Text = newCourt.CourtName;
            cboBranchID.Text = newCourt.BRANCH.BranchName;
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
                newCourt.C_Status = "Using";
            }
            else
            {
                newCourt.C_Status = "Maintenance";
            }

            newCourt.CourtName = txtCourtName.Text;
            newCourt.StartDate = DateTime.Now;
            newCourt.BranchID = new CourtService().GetBranchID(cboBranchID.Text);
            return newCourt;
        }
        List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();

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

            //if (txtCourtName.Text == "")
            //{
            //    int count = newCourt.Count();
            //    if(cboCourtID.Text == "")
            //        CourtForm.Instance.ShowCourt(newCourt, count);
            //    else 
            //    {
            //        newCourt = new CourtService().
            //    }
            //}
            //else 
            //{
            //    newCourt = new CourtService().getListNameCourt(txtCourtName.Text);
            //    int count = newCourt.Count();
            //    if( count != 0 ) 
            //        CourtForm.Instance.ShowCourt(newCourt, count);

            //}
        }

        
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCourtName.Text == "")
                    return;
                if (cboCourtID.Text == string.Empty || !new CourtService().checkCourtID(cboCourtID.Text))
                {

                    
                    {
                        COURT tmpCourt = SetCourt();
                        new CourtService().InsertCourt(tmpCourt);
                        MessageBox.Show("Thêm sân thành công!", "Thông báo");
                        Loading();
                        Reset();
                        if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
                        {
                            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
                            int count = newCourt.Count();
                            new CourtService().publicDay();
                            CourtForm.Instance.ShowCourt(newCourt, count);
                            CourtForm.Instance.Reset();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Thêm sân không thành công!", "Thông báo");
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
                    throw new Exception("Xoá sân thành công!");
                }
                else if ( new CourtService().CountCourt(cboCourtID.Text) != 0)
                {
                    throw new Exception("Xoá sân không thành công!");
                }
                else 
                {
                    DialogResult result = MessageBox.Show("Vô hiệu hoá sân đã chọn?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        tmp.C_Status = "Disable";
                        new CourtService().InsertCourt(tmp);
                        MessageBox.Show("Vô hiệu hoá sân thành công!");
                        Loading();
                        Reset();
                        if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
                        {
                            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
                            int count = newCourt.Count();
                            CourtForm.Instance.ShowCourt(newCourt, count);
                            CourtForm.Instance.Reset();
                        }
                    }
                    
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
                    throw new Exception("Chỉnh sửa sân không thành công!");
                }
                else
                {
                    DateTime dateTime = DateTime.Now;
                    //if (tmp.C_Status == "Using" && cboStatus.SelectedIndex != 2)
                    //{
                    //    throw new Exception("San Da Di Vao Hoat Dong");
                    //}
                   
                    
                    {
                        tmp = SetCourt();
                        new CourtService().InsertCourt(tmp);
                        Loading();
                        Reset();
                        MessageBox.Show("Chỉnh sửa thông tin sân thành công!");
                        if (Application.OpenForms["CourtForm"] != null && !Application.OpenForms["CourtForm"].IsDisposed)
                        {
                            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
                            int count = newCourt.Count();
                            new CourtService().publicDay();
                            CourtForm.Instance.ShowCourt(newCourt, count);
                            CourtForm.Instance.Reset();
                        }
                    }
                        
                    
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
                    cboBranchID.Text = court.BRANCH.BranchName;
                    if (court.C_Status == "Using")
                    {
                        cboStatus.SelectedIndex = 0;
                    }
                    else if (court.C_Status == "Maintenance")
                    {
                        cboStatus.SelectedIndex = 1;
                    }
                }
            }
            else if( cboCourtID.Text == "")
            {
                cboBranchID.Enabled = true;
                Reset();
            }

        }

        private void cboCourtID_TextChanged(object sender, EventArgs e)
        {
            if (cboCourtID.Text != "")
            {
                COURT court = new CourtService().FindCourtByID(cboCourtID.Text);
                if (court != null)
                {
                    cboBranchID.Enabled = false;
                }
                else
                {
                    cboBranchID.Enabled = true;
                }
            }
        }

   
    }
}
