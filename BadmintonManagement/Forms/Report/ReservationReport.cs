using BadmintonManagement.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonManagement.Forms.Report
{
    
    public partial class ReservationReport : Form
    {
        ModelBadmintonManage context = new ModelBadmintonManage();
        public ReservationReport()
        {
            InitializeComponent();
        }

        private void ReservationReport_Load(object sender, EventArgs e)
        {
            rptReservation.Visible = false;
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rdbDay.Checked && !rdbMonth.Checked)
                    throw new Exception("Vui lòng chọn thời gian thống kê");
                rptReservation.Visible = true;
                if (rdbMonth.Checked)
                {
                    Microsoft.Reporting.WinForms.ReportParameter[] param = new Microsoft.Reporting.WinForms.ReportParameter[1]
                    {
                        new Microsoft.Reporting.WinForms.ReportParameter("StringDate","Tháng "+dtpMonth.Text)
                    };

                    List<RESERVATION> reservations = context.RESERVATION.ToList();
                    reservations = reservations.Where(p=>p.CreateDate.Value.ToString("MM/yyyy") == dtpMonth.Text).ToList(); 
                    rptReservation.LocalReport.ReportPath = "ReservationReport.rdlc";
                    var soure = new ReportDataSource("DataSetReservation", reservations);
                    rptReservation.LocalReport.DataSources.Clear();
                    rptReservation.LocalReport.DataSources.Add(soure);
                    rptReservation.LocalReport.SetParameters(param);
                }


                this.rptReservation.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
