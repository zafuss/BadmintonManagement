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
            CreatePanel();
            customPanel();
        }

        private void CreatePanel()
        {
            double x = (this.pnlDisplayCourt.Width) / (3.4);
            double y = (this.pnlDisplayCourt.Height) / (3.4);
            Panel panel = new Panel();
            panel.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel.Location = new Point(0,0);
            panel.BackColor = Color.Black;
            pnlDisplayCourt.Controls.Add(panel);

            Panel panel1 = new Panel();
            panel1.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel1.BackColor = Color.Orange;
            panel1.Location = new Point(Convert.ToInt32(x + x*0.2), Convert.ToInt32(0));
            pnlDisplayCourt.Controls.Add(panel1);

            Panel panel2 = new Panel();
            panel2.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel2.BackColor = Color.Blue;
            panel2.Location = new Point(Convert.ToInt32(x*2 + x * 0.2*2), Convert.ToInt32(0));
            pnlDisplayCourt.Controls.Add(panel2);

            Panel panel3 = new Panel();
            panel3.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel3.Location = new Point(0, Convert.ToInt32(y + y * 0.2));
            panel3.BackColor = Color.Black;
            pnlDisplayCourt.Controls.Add(panel3);

            Panel panel4 = new Panel();
            panel4.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel4.BackColor = Color.Orange;
            panel4.Location = new Point(Convert.ToInt32(x + x * 0.2 ), Convert.ToInt32(y + y * 0.2));
            pnlDisplayCourt.Controls.Add(panel4);

            Panel panel5 = new Panel();
            panel5.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel5.BackColor = Color.Blue;
            panel5.Location = new Point(Convert.ToInt32(x * 2 + x * 0.2 * 2), Convert.ToInt32(y + y * 0.2));
            pnlDisplayCourt.Controls.Add(panel5);

            Panel panel6 = new Panel();
            panel6.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel6.Location = new Point(0, Convert.ToInt32(y *2 + y * 0.2*2));
            panel6.BackColor = Color.Black;
            pnlDisplayCourt.Controls.Add(panel6);

            Panel panel7 = new Panel();
            panel7.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel7.BackColor = Color.Orange;
            panel7.Location = new Point(Convert.ToInt32(x + x * 0.2), Convert.ToInt32(y*2 + y * 0.2*2));
            pnlDisplayCourt.Controls.Add(panel7);

            Panel panel8 = new Panel();
            panel8.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel8.BackColor = Color.Blue;
            panel8.Location = new Point(Convert.ToInt32(x * 2 + x * 0.2 * 2), Convert.ToInt32(y*2 + y * 0.2 * 2));
            pnlDisplayCourt.Controls.Add(panel8);


            Panel panel9 = new Panel();
            panel9.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel9.Location = new Point(0, Convert.ToInt32(y * 3 + y * 0.2 * 3));
            panel9.BackColor = Color.Black;
            pnlDisplayCourt.Controls.Add(panel9);

            Panel panel10 = new Panel();
            panel10.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel10.BackColor = Color.Orange;
            panel10.Location = new Point(Convert.ToInt32(x + x * 0.2), Convert.ToInt32(y * 3 + y * 0.2 * 3));
            pnlDisplayCourt.Controls.Add(panel10);

            Panel panel11 = new Panel();
            panel11.Size = new Size(Convert.ToInt32(x), Convert.ToInt32(y));
            panel11.BackColor = Color.Blue;
            panel11.Location = new Point(Convert.ToInt32(x * 2 + x * 0.2 * 2), Convert.ToInt32(y * 3 + y * 0.2 * 3));
            pnlDisplayCourt.Controls.Add(panel11);
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
            CreatePanel();
        }
    }
}
