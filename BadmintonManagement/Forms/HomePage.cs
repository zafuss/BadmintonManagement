﻿using BadmintonManagement.Forms;
using BadmintonManagement.Forms.Court;
using BadmintonManagement.Forms.Customer;
using BadmintonManagement.Forms.Price;
using BadmintonManagement.Forms.Receipt;
using BadmintonManagement.Forms.Report;
using BadmintonManagement.Forms.ReservationCourt;
using BadmintonManagement.Forms.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.AuthorizationForms
{
    public partial class HomePage : Form
    {
        private Form activeForm = null;
        Image closeImage, closeImageAct;
        public HomePage()
        {
            InitializeComponent();
        }
       
        private void btnAdminManageUser_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            manageUser.Show();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        //private void HomePage_Load(object sender, EventArgs e)
        //{
        //    if (Properties.Settings.Default.Role == "Admin")
        //    {
        //        btnAdminManageUser.Visible = true;
        //        btnAdminManageUser.Enabled = true;
        //    } else
        //    {
        //        btnAdminManageUser.Visible = false;
        //        btnAdminManageUser.Enabled = false;
        //    }

        //}

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?","Xác nhận",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                this.Close();
        }

        private int CheckExist(Form form)
        {
            for(int i = 0;i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text == form.Text.Trim())
                        return i;
               
            }
            return -1;
        }
        private void AddTabPages(Form form)
        {
            int checkExist = CheckExist(form);
            if (checkExist >= 0)
            {
                if(tabControl.SelectedTab == tabControl.TabPages[checkExist])
                {

                }
                else
                {
                    tabControl.SelectedTab = tabControl.TabPages[checkExist];
                }
            }
            else
            {
                TabPage newTab = new TabPage(form.Text.Trim());
                tabControl.TabPages.Add(newTab);
                form.TopLevel = false;
                form.Parent = newTab;
                tabControl.SelectedTab = tabControl.TabPages[tabControl.TabCount - 1];
                form.Show();
                form.Dock = DockStyle.Fill;

            }
        }
        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0;i < tabControl.TabCount; i++)
            {
                Rectangle rect = tabControl.GetTabRect(i);
                Rectangle imageRect = new Rectangle(rect.Right - closeImage.Width, rect.Top + (rect.Height - closeImage.Height) / 2, closeImage.Width, closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    tabControl.TabPages.Remove(tabControl.SelectedTab);
                }
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Size mySize = new System.Drawing.Size(20, 20);
            Bitmap bitmap = new Bitmap(Properties.Resources.closeAct);
            Bitmap btm = new Bitmap(bitmap, mySize);
            closeImageAct = btm;

            Bitmap bitmap1 = new Bitmap(Properties.Resources.close);
            Bitmap btm2 = new Bitmap(bitmap1, mySize);
            closeImage = btm2;
            tabControl.Padding = new Point(30);

        }


        private void btnUser_Click(object sender, EventArgs e)
        {
            AddTabPages(new ManageUser());
        }

        private void btnCourt_Click(object sender, EventArgs e)
        {
            AddTabPages(new CourtForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddTabPages(new CustomerForm());
        }

        private void btnService_Click_1(object sender, EventArgs e)
        {
            AddTabPages(new ServiceForm());
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            AddTabPages(new ReservationForm());
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            AddTabPages(new ReceiptForm());
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            AddTabPages(new PriceForm());
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            AddTabPages(new IncomeReportForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rect = tabControl.GetTabRect(e.Index);
            Rectangle imageRect =  new Rectangle(rect.Right -closeImage.Width,rect.Top + (rect.Height-closeImage.Width)/2,closeImage.Width,closeImage.Height);
            rect.Size = new Size(rect.Width + 24, 38);
            Font font;
            Brush brush = Brushes.Black;
            StringFormat strFormat = new StringFormat(StringFormat.GenericDefault);
            if (tabControl.SelectedTab == tabControl.TabPages[e.Index])
            {
                e.Graphics.DrawImage(closeImage, imageRect);
                font = new Font("Segoe UI", 12,FontStyle.Bold);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font,brush, rect,strFormat);
            }
            else
            {
                e.Graphics.DrawImage(closeImage, imageRect);
                //font = new Font("Arial", 9, FontStyle.Strikeout);
                font = new Font("Segoe UI", 11, FontStyle.Regular);
                e.Graphics.DrawString(tabControl.TabPages[e.Index].Text, font, brush, rect, strFormat);
            }

        }


        
    }
}
