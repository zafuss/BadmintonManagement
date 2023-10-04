namespace BadmintonManagement.Forms.Report
{
    partial class ReservationReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rptReservation = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtbStart = new System.Windows.Forms.DateTimePicker();
            this.rdbDay = new System.Windows.Forms.RadioButton();
            this.rdbMonth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 108);
            this.panel1.TabIndex = 0;
            // 
            // rptReservation
            // 
            this.rptReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptReservation.Location = new System.Drawing.Point(0, 108);
            this.rptReservation.Name = "rptReservation";
            this.rptReservation.ServerReport.BearerToken = null;
            this.rptReservation.Size = new System.Drawing.Size(1065, 524);
            this.rptReservation.TabIndex = 1;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Location = new System.Drawing.Point(912, 62);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(94, 31);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Thống kê";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MM/yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(364, 25);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(204, 26);
            this.dtpMonth.TabIndex = 4;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(680, 62);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(204, 26);
            this.dtpEnd.TabIndex = 3;
            // 
            // dtbStart
            // 
            this.dtbStart.CustomFormat = "dd/MM/yyyy";
            this.dtbStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbStart.Location = new System.Drawing.Point(364, 62);
            this.dtbStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtbStart.Name = "dtbStart";
            this.dtbStart.Size = new System.Drawing.Size(204, 26);
            this.dtbStart.TabIndex = 2;
            // 
            // rdbDay
            // 
            this.rdbDay.AutoSize = true;
            this.rdbDay.Location = new System.Drawing.Point(78, 66);
            this.rdbDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbDay.Name = "rdbDay";
            this.rdbDay.Size = new System.Drawing.Size(174, 24);
            this.rdbDay.TabIndex = 1;
            this.rdbDay.TabStop = true;
            this.rdbDay.Text = "Thống kê theo ngày";
            this.rdbDay.UseVisualStyleBackColor = true;
            // 
            // rdbMonth
            // 
            this.rdbMonth.AutoSize = true;
            this.rdbMonth.Location = new System.Drawing.Point(78, 29);
            this.rdbMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMonth.Name = "rdbMonth";
            this.rdbMonth.Size = new System.Drawing.Size(181, 24);
            this.rdbMonth.TabIndex = 0;
            this.rdbMonth.TabStop = true;
            this.rdbMonth.Text = "Thống kê theo tháng";
            this.rdbMonth.UseVisualStyleBackColor = true;
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1065, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // ReservationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 632);
            this.Controls.Add(this.rptReservation);
            this.Controls.Add(this.panel1);
            this.Name = "ReservationReport";
            this.Text = "ReservationReport";
            this.Load += new System.EventHandler(this.ReservationReport_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtbStart;
        private System.Windows.Forms.RadioButton rdbDay;
        private System.Windows.Forms.RadioButton rdbMonth;
    }
}