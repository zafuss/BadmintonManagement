﻿using BadmintonManagement.Database;
using BadmintonManagement.Forms.AuthorizationForms;
using BadmintonManagement.Function.CourtService;
using BadmintonManagement.Forms.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonManagement.Models;
using BadmintonManagement.Forms.ReservationCourt;

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
            new CourtService().createBranch();
            new CourtService().createCourt();
            UserServices.CreateTestAccounts();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReservationForm());
            //Application.Run(new ManageUser());
            //Application.Run(new IncomeForm());

        }
    }
}
