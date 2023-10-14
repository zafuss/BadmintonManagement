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
        public List<InfoCourt> listInfo = new RFDetailService().getCourtByRF();
        public HashSet<string> loadCourt = new RFDetailService().getListTimeinDay();
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
            tmrCountDown.Start();
            //Title();
            new CourtService().publicDay();
            btnUser.BackColor = SystemColors.ButtonShadow;
        }

        //private void Title()
        //{
        //    pnlFunction.Controls.Clear();
        //    double width = (pnlFunction.Width);
        //    double height = (pnlFunction.Height) / 12;
        //    Label label = new Label();
        //    label.Location = new Point(0, Convert.ToInt32(height));
        //    label.Size = new Size(Convert.ToInt32(width), 50);
        //    label.TextAlign = ContentAlignment.MiddleCenter;
        //    label.Text = "Chức Năng";
        //    label.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        //    pnlFunction.Controls.Add(label);
        //}
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}", DateTime.Now.ToString("HH:mm:ss")); 

            loadCourt = new RFDetailService().getListTimeinDay();
           
            if (loadCourt.Count != 0)
            {
                DateTime dateTime = new DateTime();
                foreach (var item in loadCourt)
                {
                    dateTime = DateTime.Parse(item);
                    if (label1.Text == dateTime.ToString("HH:mm:ss"))
                    {
                        pnlDisplayCourt.Controls.Clear();
                        pnlDisplayCourt.Refresh();
                        this.Refresh();
                        ReLoad();
                    }
                }
            }
        }


        public void Reset()
        {
            txtBranchName.Text = txtCourtName.Text = txtNameCustom.Text = txtPhoneNumber.Text = "";
            txtStartTime.Text = txtEndTime.Text = "00:00";
        }

        string _name = "";
        private void ControlHoverEnterHandler(object sender, EventArgs e)
        {
            CustomPanel hoverPanel = sender as CustomPanel;
            if (hoverPanel != null)
            {
                //hoverPanel.BorderStyle = BorderStyle.FixedSingle;
                //hoverPanel.BorderColor = Color.Red;
                hoverPanel.BorderRadius = 15;
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
                    //item.BorderStyle = BorderStyle.FixedSingle;
                    item.BorderColor = Color.Red;
                    item.BorderRadius = 15;
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
                        //item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                        item.BorderRadius = 15;

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
                        //item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                        item.BorderRadius = 15;
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
                //RF_DETAIL rf_detail = new RFDetailService().FindRFDetailByID(listid[0], listid[1]);
                listInfo = new RFDetailService().getCourtByRF();
                InfoCourt infoCourt = new InfoCourt();
                if (listid.Count > 1) 
                {
                    infoCourt = new RFDetailService().FindinforCourt(listid[0], listid[1], listInfo);
                    displayUser(infoCourt);
                }
                else
                {
                    Reset();
                }
               
                foreach (CustomPanel item in pnlDisplayCourt.Controls)
                {
                    if (item.Name == pictureBoxName)
                    {
                        _name = pictureBoxName;
                        //item.BorderStyle = BorderStyle.FixedSingle;
                        item.BorderColor = Color.Red;
                        item.BorderRadius = 15;
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

        private void displayUser(InfoCourt infoCourt)
        {
            txtNameCustom.Text = infoCourt.NameCustom;
            txtCourtName.Text = infoCourt.CourtName;
            txtBranchName.Text = infoCourt.BranhName;
            txtPhoneNumber.Text = infoCourt.Phonenumber;
            txtStartTime.Text = infoCourt.Starttime;
            txtEndTime.Text = infoCourt.Endtime;
        }

        private void fill()
        {
            AddCourtForm addCourtForm = new AddCourtForm();
            addCourtForm.TopLevel = false;
            //addCourtForm.AutoScroll = true;
            pnlAdmin.AutoScroll = true;
            pnlAdmin.Controls.Add(addCourtForm);
            addCourtForm.AutoScaleMode = AutoScaleMode.Inherit; 
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

        public void ReLoad()
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();

            //MessageBox.Show(count.ToString());
            RFDetailService rf = new RFDetailService();
            List<InfoCourt> listInfo = rf.getCourtByRF();
            count = listInfo.Count();
            UserShow(listInfo, count);

            //this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
        }

        public void UserShow(List<InfoCourt> infoCourts,int count)
        {
            flagUser = true;
            flagAdmin = false;

            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;
            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new RFDetailService().DisplayRFDetailUser(i, infoCourts[i], width, heigth));
                pnlDisplayCourt.Controls[i].Controls[3].Click += ControlClickHandler;
                pnlDisplayCourt.Click += ControlDoubleClickHandler;
                pnlDisplayCourt.Controls[i].Controls[3].MouseHover += PicMouseHoverHandler;

                pnlDisplayCourt.Controls[i].MouseHover += ControlHoverEnterHandler;
                pnlDisplayCourt.Controls[i].MouseLeave += ControlHoverLeaveHandler;
            }
            //MessageBox.Show("VCL");
        }

        int count = new CourtService().getCountCourtDisable();
        public void ShowCourt(List<COURT> newCourt, int count)
        {
            flagAdmin = true;
            flagUser = false;
            
            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
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
            listInfo = new RFDetailService().getCourtByRF();
            count = listInfo.Count();
            UserShow(listInfo, count);
            btnUser.BackColor = SystemColors.ButtonShadow;
            btnCalendar.BackColor = Color.LightGray;
            btnAdmin.BackColor = Color.LightGray;
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
                listInfo = new RFDetailService().getCourtByRF();
                count = listInfo.Count();
                UserShow(listInfo, count);
            }


            foreach (CustomPanel item in pnlDisplayCourt.Controls)
            {
                if (item.Name == _name)
                {
                    //item.BorderStyle = BorderStyle.FixedSingle;
                    item.BorderColor = Color.Red;
                    item.BorderRadius = 15;
                }
                else
                {
                    item.BorderStyle = BorderStyle.None;
                    item.BorderColor = System.Drawing.Color.Transparent;
                }
            }

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            pnlDisplayCourt.Controls.Clear();
            pnlDisplayCourt.Refresh();
            showSubMenu(pnlAdmin);
            newCourt = new CourtService().getListCourtWithOutDisable();
            count = newCourt.Count();
            ShowCourt(newCourt, count);
            btnUser.BackColor = Color.LightGray;
            btnCalendar.BackColor = Color.LightGray;
            btnAdmin.BackColor = SystemColors.ButtonShadow; ;
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            btnUser.BackColor = Color.LightGray;
            btnCalendar.BackColor = SystemColors.ButtonShadow;
            btnAdmin.BackColor = Color.LightGray;
            CourtCalendar courtCalendar = new CourtCalendar();
            courtCalendar.Show();
        }
    }
}
