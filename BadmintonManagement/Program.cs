using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using BadmintonManagement.Forms.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonManagement.Models;
using BadmintonManagement.Forms.ReservationCourt;
using BadmintonManagement.Forms.ReservationCourt.ReservationReceipt;
using System.IO;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Configuration;
using BadmintonManagement.Properties;

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
            Settings.Default.isDBInited = DatabaseInitial.CheckDBExists();
            Settings.Default.Save();
            if (Settings.Default.isDBInited != true)
            {
                DatabaseInitial.CreateDatabase();
                DatabaseInitial.RunSqlScriptFile("DBInsertQuery.sql");
                Settings.Default.isDBInited = true;
                Settings.Default.Save();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            
        }
    }
}
