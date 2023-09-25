using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserServices.CreateAdminAccount();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new HomePage());
            //Application.Run(new ManageUser());

        }
    }
}
