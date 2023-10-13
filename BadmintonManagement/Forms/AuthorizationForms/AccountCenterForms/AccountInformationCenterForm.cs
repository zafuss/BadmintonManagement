using BadmintonManagement.Database;
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

namespace BadmintonManagement.Forms.AuthorizationForms
{
    public partial class AccountInformationCenterForm : Form
    {
        public AccountInformationCenterForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtName.Text = Properties.Settings.Default._Name;
            txtPhoneNumber.Text = Properties.Settings.Default.PhoneNumber;
            txtRole.Text = Properties.Settings.Default.Role;
            txtEmail.Text = Properties.Settings.Default.Email;
        }

     
        


    }
}
