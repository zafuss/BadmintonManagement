namespace BadmintonManagement.Forms.Report
{
    partial class ReportService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptService = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptService
            // 
            this.rptService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptService.Location = new System.Drawing.Point(0, 0);
            this.rptService.Name = "rptService";
            this.rptService.ServerReport.BearerToken = null;
            this.rptService.Size = new System.Drawing.Size(710, 411);
            this.rptService.TabIndex = 1;
            this.rptService.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ReportService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 411);
            this.Controls.Add(this.rptService);
            this.Name = "ReportService";
            this.Text = "ReportService";
            this.Load += new System.EventHandler(this.ReportService_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rptService;
    }
}