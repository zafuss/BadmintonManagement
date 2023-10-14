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

namespace BadmintonManagement.Forms.Service.ServiceReceipt.Print
{
    public partial class SerRecPrint : Form
    {
        public SerRecPrint()
        {
            InitializeComponent();
        }
        string serviceRecNo;
        public SerRecPrint(string serviceRecNo)
        {
            InitializeComponent();
            this.serviceRecNo = serviceRecNo;
        }
        private void SerRecPrint_Load(object sender, EventArgs e)
        {
            this.rpvPrint.RefreshReport();
        }

        private void ShowReport()
        {
            ModelBadmintonManage context = new ModelBadmintonManage();
            string sql = @"select s.ServiceReceiptNo,s.CreateDate,s.Total,s.PhoneNumber,s.Username,c.FullName
                            from SERVICE_RECEIPT s left join CUSTOMER c on s.PhoneNumber = c.PhoneNumber
                            where s.ServiceReceiptNo =" + @"'" + serviceRecNo + @"'";
            List<SerRec> listSR = context.Database.SqlQuery<SerRec>(sql).ToList();
            var srDS = new ReportDataSource("SerSec", listSR);
            sql = @"select *
                    from SERVICE_DETAIL
                    where ServiceReceiptNo =" + @"'" + serviceRecNo + @"'";
            List<SerRecDetail> listSRD = context.Database.SqlQuery<SerRecDetail>(sql).ToList();
            var listSRDDS = new ReportDataSource("SerRecDetail", listSRD);
            rpvPrint.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpvPrint.LocalReport.ReportPath = "";
            rpvPrint.LocalReport.DataSources.Clear();
            rpvPrint.LocalReport.DataSources.Add(srDS);
            rpvPrint.LocalReport.DataSources.Add(listSRDDS);
            rpvPrint.RefreshReport();
        }
    }
}
