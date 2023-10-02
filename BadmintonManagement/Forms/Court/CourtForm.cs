using BadmintonManagement.Function.CourtService;
using BadmintonManagement.Function.RFDetailService;
using BadmintonManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Court
{
    public partial class CourtForm : Form
    {
        public static CourtForm Instance;
        public bool flagUser = false;
        public bool flagAdmin = false;

        public CourtForm()
        {
            InitializeComponent();
            fill();
            customizeDesign();
            Instance = this;
            if (Properties.Settings.Default.Role != "Admin")
            {
                btnAdmin.Visible = false;
            }
            pnlDisplayCourt.AutoScroll = true;
            //Test();
        }

        private void ControlAdminClickHandler(object sender, EventArgs e)
        {
            hideSubMenu();
            pnlAdmin.Visible = true;
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                string pictureBoxName = clickedPictureBox.Name;
                COURT court = new CourtService().FindCourtByID(pictureBoxName);
                AddCourtForm.Instance.FillCourt(court);
            }
        }

        private void displayUser(RF_DETAIL rfdetail)
        {
            txtNameCustom.Text = rfdetail.RESERVATION.CUSTOMER.FullName;
            txtCourtName.Text = rfdetail.COURT.CourtName;
            txtBranchName.Text = rfdetail.COURT.BRANCH.BranchName;
            txtPhoneNumber.Text = 0+rfdetail.RESERVATION.CUSTOMER.PhoneNumber;
            dtmStartTime.Text = rfdetail.StartTime.ToString();
            dtmEndTime.Text = rfdetail.EndTime.ToString();
        }

        private void ControlClickHandler(object sender, EventArgs e)
        {
            hideSubMenu();
            string pattern = "[^+]+";

            pnlUser.Visible = true;
            PictureBox clickedPictureBox = sender as PictureBox;
            if(clickedPictureBox != null)
            {
                string pictureBoxName = clickedPictureBox.Name;
                List<string> listid = new List<string>();
                foreach(Match var in Regex.Matches(pictureBoxName, pattern))
                {
                    listid.Add(var.Value);
                }
                RF_DETAIL rf_detail = new RFDetailService().FindRFDetailByID(listid[0], listid[1]);
                displayUser(rf_detail);
            }
        }

        private void fill()
        {
            AddCourtForm addCourtForm = new AddCourtForm();
            addCourtForm.TopLevel = false;
            addCourtForm.AutoScroll = true;
            pnlAdmin.Controls.Add(addCourtForm);
            addCourtForm.Show();
        }
        private void customizeDesign()
        {
            pnlUser.Visible = false;
            pnlAdmin.Visible = false;
        }

        private void hideSubMenu()
        {
            if(pnlUser.Visible == true ) 
            { 
                pnlUser.Visible = false;
            }

            if( pnlAdmin.Visible == true )
            {
                pnlAdmin.Visible = false;
            }
        }

        public void UserShow()
        {
            flagUser = true;
            flagAdmin = false;
            List<RF_DETAIL> listRF = new RFDetailService().getRFDetail();
            int count = listRF.Count();

            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;

            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new RFDetailService().DisplayRFDetailUser(i, listRF[i], width, heigth));
                pnlDisplayCourt.Controls[i].Controls[3].Click += ControlClickHandler;
            }
            
        }

        public void ShowCourt()
        {
            flagAdmin = true;
            flagUser = false;
            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
            int count = new CourtService().getCountCourtDisable();

            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;
            pnlDisplayCourt.Controls.Clear();
            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new CourtService().DisplayCourtAdmin(i, newCourt[i],width,heigth));
                pnlDisplayCourt.Controls[i].Controls[2].Click += ControlAdminClickHandler;
            }
            
        }

        private void showSubMenu(Panel panel) {

            if (panel.Visible == false)
            {
                hideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            showSubMenu(pnlUser);
            UserShow();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            showSubMenu(pnlAdmin);
            ShowCourt();
        }


        private void pnlDisplayCourt_SizeChanged(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            if(flagAdmin == true) { ShowCourt(); }
            else { UserShow(); }

        }
    }
}
