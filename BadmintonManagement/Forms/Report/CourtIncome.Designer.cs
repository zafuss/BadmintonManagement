namespace BadmintonManagement.Forms.Report
{
    partial class CourtIncome
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtbStart = new System.Windows.Forms.DateTimePicker();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.rptCourtIncome = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowReport);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpMonth);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.dtbStart);
            this.groupBox1.Controls.Add(this.rdbDay);
            this.groupBox1.Controls.Add(this.rdbMonth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(537, 40);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(63, 20);
            this.btnShowReport.TabIndex = 15;
            this.btnShowReport.Text = "Thống kê";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ ngày";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(215, 16);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(123, 20);
            this.dtpMonth.TabIndex = 12;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(413, 40);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(105, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // dtbStart
            // 
            this.dtbStart.CustomFormat = "dd/MM/yyyy";
            this.dtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbStart.Location = new System.Drawing.Point(215, 40);
            this.dtbStart.Name = "dtbStart";
            this.dtbStart.Size = new System.Drawing.Size(123, 20);
            this.dtbStart.TabIndex = 10;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(24, 43);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(121, 17);
            this.rdbDay.TabIndex = 9;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "Thống kê theo ngày";
            this.rdbDay.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(24, 19);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(125, 17);
            this.rdbMonth.TabIndex = 8;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "Thống kê theo tháng";
            this.rdbMonth.UseVisualStyleBackColor = true;
            // 
            // rptCourtIncome
            // 
            this.rptCourtIncome.AutoScroll = true;
            this.rptCourtIncome.AutoSize = true;
            this.rptCourtIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptCourtIncome.Location = new System.Drawing.Point(0, 70);
            this.rptCourtIncome.Name = "rptCourtIncome";
            this.rptCourtIncome.ServerReport.BearerToken = null;
            this.rptCourtIncome.Size = new System.Drawing.Size(720, 380);
            this.rptCourtIncome.TabIndex = 1;
            this.rptCourtIncome.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // CourtIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.rptCourtIncome);
            this.Controls.Add(this.groupBox1);
            this.Name = "CourtIncome";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptFormReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptCourtIncome;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtbStart;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}