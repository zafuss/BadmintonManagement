using BadmintonManagement.Function.CourtService;
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

namespace BadmintonManagement.Forms.Court
{
    public partial class CourtForm : Form
    {
        public static CourtForm Instance;
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

        public void ShowCourt()
        {
            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
            int count = new CourtService().getCountCourtDisable();

            double width = this.pnlDisplayCourt.Width;
            double heigth = this.pnlDisplayCourt.Height;

            pnlDisplayCourt.Controls.Clear();
            for (int i = 0; i < count; i++)
            {
                pnlDisplayCourt.Controls.Add(new CourtService().DisplayCourt(i, newCourt[i],width,heigth));
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
            showSubMenu(pnlUser);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlAdmin);
        }

        

        private void pnlDisplayCourt_SizeChanged(object sender, EventArgs e)
        {
            ShowCourt();
        }
    }
}
