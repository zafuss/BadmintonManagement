using BadmintonManagement.Database;
using BadmintonManagement.Custom;
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
        public List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
        public List<RF_DETAIL> listRF = new RFDetailService().getRFDetail();

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

        public void Reset()
        {
            txtBranchName.Text = txtCourtName.Text = txtNameCustom.Text = txtPhoneNumber.Text = "";
            dtmEndTime.Value = dtmEndTime.Value = DateTime.Now;
        }

        string _name = "";
        private void ControlHoverEnterHandler(object sender, EventArgs e)
        {
            CustomPanel hoverPanel = sender as CustomPanel;
            if (hoverPanel != null)
            {
                hoverPanel.BorderStyle = BorderStyle.FixedSingle;
                hoverPanel.BorderColor = Color.Red;
            }
        }

        private void ControlHoverLeaveHandler(object sender, EventArgs e)
        {
            CustomPanel hoverPanel = sender as CustomPanel;
            if (hoverPanel != null)
            {
                //_name = "";
                //MessageBox.Show(_name);
                
                if (_name == "")
                {
                    hoverPanel.BorderStyle = BorderStyle.None;
                    hoverPanel.BorderColor = System.Drawing.Color.Transparent;
                }
                if (_name != hoverPanel.Name)
                {
                    hoverPanel.BorderStyle = BorderStyle.None;
                    hoverPanel.BorderColor = System.Drawing.Color.Transparent;
                }

            }
            foreach(CustomPanel item in pnlDisplayCourt.Controls)
            {
                if (item.Name == _name)
                {
                    item.BorderStyle = BorderStyle.FixedSingle;
                    item.BorderColor = Color.Red;
                }
                else
                {
                    item.BorderStyle = BorderStyle.None;
                    item.BorderColor = System.Drawing.Color.Transparent;
                }
            }
        }

        private void PicMouseHoverHandler(object sender, EventArgs e)
        {
            CustomPicBox customPicBox = sender as CustomPicBox;
            if( customPicBox != null)
            {
                foreach (CustomPanel item in pnlDisplayCourt.Controls)
                {
                    if(item.Name == customPicBox.Name )
                    {
                        item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                    }
                }
            }
        }

        private void ControlAdminClickHandler(object sender, EventArgs e)
        {
            hideSubMenu();
            pnlAdmin.Visible = true;
            CustomPicBox clickedPictureBox = sender as CustomPicBox;
            if (clickedPictureBox != null)
            {
                string pictureBoxName = clickedPictureBox.Name;
                COURT court = new CourtService().FindCourtByID(pictureBoxName);
                AddCourtForm.Instance.FillCourt(court);
                foreach (CustomPanel item in pnlDisplayCourt.Controls)
                {
                    if (item.Name == pictureBoxName)
                    {
                        _name = pictureBoxName;
                        item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                    }
                    else
                    {
                        item.BorderStyle = BorderStyle.None;
                        item.BorderColor = System.Drawing.Color.Transparent;
                    }
                }
            }
        }

        private void ControlClickHandler(object sender, EventArgs e)
        {
            hideSubMenu();
            pnlUser.Visible = true;
            string pattern = "[^+]+";

            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                string pictureBoxName = clickedPictureBox.Name;
                List<string> listid = new List<string>();
                foreach (Match var in Regex.Matches(pictureBoxName, pattern))
                {
                    listid.Add(var.Value);
                }
                RF_DETAIL rf_detail = new RFDetailService().FindRFDetailByID(listid[0], listid[1]);
                displayUser(rf_detail);
                foreach (CustomPanel item in pnlDisplayCourt.Controls)
                {
                    if (item.Name == pictureBoxName)
                    {
                        _name = pictureBoxName;
                        item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                    }
                    else
                    {
                        item.BorderStyle = BorderStyle.None;
                        item.BorderColor = System.Drawing.Color.Transparent;
                    }
                }
            }
        }

        private void ControlDoubleClickHandler(object sender, EventArgs e)
        {
            //hideSubMenu();
            //CustomPanel hoverPanel = sender as CustomPanel;
            //if (hoverPanel == null)
            //{
            _name = "";
            foreach (CustomPanel item in pnlDisplayCourt.Controls)
            {
                {
                    item.BorderStyle = BorderStyle.None;
                    item.BorderColor = System.Drawing.Color.Transparent;
                }
            }
            pnlAdmin.Visible = false;
            pnlUser.Visible = false;
            if(flagAdmin)
            {
                AddCourtForm.Instance.Reset();
            }
            else
            {
                Reset();
            }
            //}
        }

        private void displayUser(RF_DETAIL rfdetail)
        {
            txtNameCustom.Text = rfdetail.RESERVATION.CUSTOMER.FullName;
            txtCourtName.Text = rfdetail.COURT.CourtName;
            txtBranchName.Text = rfdetail.COURT.BRANCH.BranchName;
            txtPhoneNumber.Text = 0+rfdetail.RESERVATION.CUSTOMER.PhoneNumber;
            dtmStartTime.Text = rfdetail.RESERVATION.StartTime.ToString();
            dtmEndTime.Text = rfdetail.RESERVATION.EndTime.ToString(); 
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

        public void UserShow(List<RF_DETAIL> listRF,int count)
        {
            flagUser = true;
            flagAdmin = false;
            

            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;

            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new RFDetailService().DisplayRFDetailUser(i, listRF[i], width, heigth));
                pnlDisplayCourt.Controls[i].Controls[3].Click += ControlClickHandler;
                pnlDisplayCourt.Click += ControlDoubleClickHandler;
                pnlDisplayCourt.Controls[i].Controls[3].MouseHover += PicMouseHoverHandler;

                pnlDisplayCourt.Controls[i].MouseHover += ControlHoverEnterHandler;
                pnlDisplayCourt.Controls[i].MouseLeave += ControlHoverLeaveHandler;
            }
            
        }

        int count = new CourtService().getCountCourtDisable();
        public void ShowCourt(List<COURT> newCourt, int count)
        {
            flagAdmin = true;
            flagUser = false;
            
            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;
            pnlDisplayCourt.Controls.Clear();
            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new CourtService().DisplayCourtAdmin(i, newCourt[i],width,heigth));
                pnlDisplayCourt.Controls[i].Controls[2].Click += ControlAdminClickHandler;
                pnlDisplayCourt.Click += ControlDoubleClickHandler;
                pnlDisplayCourt.Controls[i].Controls[2].MouseHover += PicMouseHoverHandler;

                pnlDisplayCourt.Controls[i].MouseHover += ControlHoverEnterHandler;
                pnlDisplayCourt.Controls[i].MouseLeave += ControlHoverLeaveHandler;
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
            listRF = new RFDetailService().getRFDetail();
            count = listRF.Count();
            UserShow(listRF,count);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            showSubMenu(pnlAdmin);
            newCourt = new CourtService().getListCourtWithOutDisable();
            count = newCourt.Count();
            ShowCourt(newCourt,count);
        }

    

        private void pnlDisplayCourt_SizeChanged(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            if(flagAdmin == true)
            {
                newCourt = new CourtService().getListCourtWithOutDisable();
                count = newCourt.Count();
                ShowCourt(newCourt, count); 
            }
            else 
            {
                listRF = new RFDetailService().getRFDetail();
                count = listRF.Count();
                UserShow(listRF, count);
            }


            foreach (CustomPanel item in pnlDisplayCourt.Controls)
            {
                if (item.Name == _name)
                {
                    item.BorderStyle = BorderStyle.FixedSingle;
                    item.BorderColor = Color.Red;
                }
                else
                {
                    item.BorderStyle = BorderStyle.None;
                    item.BorderColor = System.Drawing.Color.Transparent;
                }
            }

        }
    }
}
