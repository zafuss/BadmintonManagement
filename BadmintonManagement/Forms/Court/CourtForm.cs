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
        public CourtForm()
        {
            InitializeComponent();
            fill();
            customizeDesign();

            if (Properties.Settings.Default.Role != "Admin")
            {
                btnAdmin.Visible = false;
                //btnAdmin.Enabled = false;
            }
            //CreatePanel();
            customPanel();
            //Test();
        }
        private void Test()
        {
            double x = (this.pnlDisplayCourt.Width) / (3.4);
            double y = (this.pnlDisplayCourt.Height) / (3.4);
            String tmp = "pnl" + "0";
            Type controlType = typeof(Panel);
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = tmp;

            newControl.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            newControl.BackColor = Color.Black;
            newControl.Location = new Point(0, 0);


            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.Use;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3/ 5));
            pictureBox.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));
            newControl.Controls.Add(pictureBox);
            pnlDisplayCourt.Controls.Add(newControl);
        }


        private void Test(int count , COURT court)
        {
            double x = (this.pnlDisplayCourt.Width) / (3.4);
            double y = (this.pnlDisplayCourt.Height) / (3.4);
            String tmp = "pnl" + count;
            Type controlType = typeof(Panel);
            Control newControl = (Control)Activator.CreateInstance(controlType);

            newControl.Name = tmp;
            
            newControl.Size  = new Size(Convert.ToInt32(x), Convert.ToInt32(y));


            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.Use;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(Convert.ToInt32(x * 3 / 5), Convert.ToInt32(y * 3 / 5));
            pictureBox.Location = new Point(Convert.ToInt32(x * 1 / 5), Convert.ToInt32(y * 1 / 5));

            if(court.C_Status == "Use")
            {
                pictureBox.Image = Properties.Resources.Use;
            }
            else if(court.C_Status == "Used")
            {
                pictureBox.Image = Properties.Resources.Used;
            }
            else if(court.C_Status == "Maintaince")
            {
                pictureBox.Image = Properties.Resources.Maintainace;
            }

            if ( count > 2)
            {
                int _surplus = (int)(count / 3);
                if( count %3 == 0 )
                {
                    newControl.Location = new Point(0, Convert.ToInt32(y + y * 0.2) * _surplus);
                    //newControl.BackColor = Color.Black;
                }
                else if( count %3 == 1 )
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2) , Convert.ToInt32(y + y * 0.2)*_surplus);
                    //newControl.BackColor = Color.Red;
                }
                else if(count %3 == 2 )
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2) * 2, Convert.ToInt32(y + y * 0.2) * _surplus);
                    //newControl.BackColor = Color.Blue;
                }
            }
            else
            {
                if( count == 0)
                {
                    newControl.Location = new Point(0, 0);
                    //newControl.BackColor = Color.Black;
                }
                else if( count == 1)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2), 0);
                    //newControl.BackColor = Color.Red;
                }
                else if (count == 2)
                {
                    newControl.Location = new Point(Convert.ToInt32(x + x * 0.2)*2, 0);
                    //newControl.BackColor = Color.Blue;
                }
            }

          
            newControl.Controls.Add(pictureBox);


            pnlDisplayCourt.Controls.Add(newControl);
        }

       
        private void customPanel()
        {
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
            //CreatePanel();
            int count = new CourtService().getCountCourtDisable();
            //List<COURT> newCourt = new CourtService().getListCourt();
            List<COURT> newCourt = new CourtService().getListCourtWithOutDisable();
            
            for ( int i = 0; i < count; i++)
            {
                Test(i, newCourt[i]);
            }
        }
    }
}
