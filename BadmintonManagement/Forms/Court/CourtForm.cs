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
        public bool flag = false;
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

        private void Test()
        {
            double x = (this.pnlDisplayCourt.Width) / (3.4);
            double y = (this.pnlDisplayCourt.Height) / (3.4);
            Panel panel = new Panel();
            PictureBox pictureBox = new PictureBox();
            Label lbl = new Label();
            lbl.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl.Location = new Point(Convert.ToInt32(x * 1 / 10), Convert.ToInt32(y * 9 / 10));

            Label lbl2 = new Label();
            lbl2.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl2.Location = new Point(Convert.ToInt32(x * 6 / 10), Convert.ToInt32(y * 9 / 10));
            panel.Location = new Point(0, 0);
            panel.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            pictureBox.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3 / 5));
            pictureBox.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));
            pictureBox.Image = Properties.Resources.Use;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            panel.Controls.Add(lbl2);
            panel.Controls.Add(lbl);
            panel.Controls.Add(pictureBox);
            pnlDisplayCourt.Controls.Add(panel);
        }

        private void Control_MouseEnter(object sender, EventArgs e)
        {
            
            MessageBox.Show("Test");
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        {
            
            
        }
        private void ControlClickHandler(object sender, EventArgs e)
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
                pnlDisplayCourt.Controls.Add(new CourtService().DisplayCourtAdmin(i, newCourt[i],width,heigth));
                pnlDisplayCourt.Controls[i].Controls[2].Click += ControlClickHandler;
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
            pnlDisplayCourt.Controls.Clear();
            ShowCourt();
        }
    }
}
