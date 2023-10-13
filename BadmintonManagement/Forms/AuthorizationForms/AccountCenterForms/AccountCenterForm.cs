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
    public partial class AccountCenterForm : Form
    {
        Form activeForm = null;
        public AccountCenterForm()
        {
            InitializeComponent();
            OpenChildForm(new AccountInformationCenterForm());
            btnAccountInformation.BackColor = SystemColors.ButtonShadow;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChild.Controls.Add(childForm);
            pnlChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAccountInformation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountInformationCenterForm());
            btnAccountInformation.BackColor = SystemColors.ButtonShadow;
            btnChangePassword.BackColor = Color.LightGray;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AccountChangePasswordCenterForm());
            btnChangePassword.BackColor = SystemColors.ButtonShadow;
            btnAccountInformation.BackColor = Color.LightGray;
        }
    }

}
