namespace BadmintonManagement.Forms.Report
{
    partial class ReportForm
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
            this.btnReservationReport = new System.Windows.Forms.Button();
            this.btnCustomerReport = new System.Windows.Forms.Button();
            this.pnlReceiptReport = new System.Windows.Forms.Panel();
            this.btnServiceIncome = new System.Windows.Forms.Button();
            this.btnCourtIncome = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnChartIncome = new System.Windows.Forms.Button();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.pnlViewreport = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlReceiptReport.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnReservationReport);
            this.panel1.Controls.Add(this.btnCustomerReport);
            this.panel1.Controls.Add(this.pnlReceiptReport);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Controls.Add(this.btnChartIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 403);
            this.panel1.TabIndex = 0;
            // 
            // btnReservationReport
            // 
            this.btnReservationReport.BackColor = System.Drawing.Color.LightGray;
            this.btnReservationReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservationReport.FlatAppearance.BorderSize = 0;
            this.btnReservationReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservationReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnReservationReport.Location = new System.Drawing.Point(0, 154);
            this.btnReservationReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnReservationReport.Name = "btnReservationReport";
            this.btnReservationReport.Size = new System.Drawing.Size(127, 29);
            this.btnReservationReport.TabIndex = 6;
            this.btnReservationReport.Text = "Thống kê phiếu đặt sân";
            this.btnReservationReport.UseVisualStyleBackColor = false;
            this.btnReservationReport.Click += new System.EventHandler(this.btnReservationReport_Click);
            // 
            // btnCustomerReport
            // 
            this.btnCustomerReport.BackColor = System.Drawing.Color.LightGray;
            this.btnCustomerReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerReport.FlatAppearance.BorderSize = 0;
            this.btnCustomerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerReport.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnCustomerReport.Location = new System.Drawing.Point(0, 125);
            this.btnCustomerReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerReport.Name = "btnCustomerReport";
            this.btnCustomerReport.Size = new System.Drawing.Size(127, 29);
            this.btnCustomerReport.TabIndex = 5;
            this.btnCustomerReport.Text = "Thống kê khách hàng";
            this.btnCustomerReport.UseVisualStyleBackColor = false;
            this.btnCustomerReport.Click += new System.EventHandler(this.btnCustomerReport_Click_1);
            // 
            // pnlReceiptReport
            // 
            this.pnlReceiptReport.Controls.Add(this.btnServiceIncome);
            this.pnlReceiptReport.Controls.Add(this.btnCourtIncome);
            this.pnlReceiptReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceiptReport.Location = new System.Drawing.Point(0, 62);
            this.pnlReceiptReport.Name = "pnlReceiptReport";
            this.pnlReceiptReport.Size = new System.Drawing.Size(127, 63);
            this.pnlReceiptReport.TabIndex = 4;
            // 
            // btnServiceIncome
            // 
            this.btnServiceIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServiceIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceIncome.FlatAppearance.BorderSize = 0;
            this.btnServiceIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceIncome.Location = new System.Drawing.Point(0, 30);
            this.btnServiceIncome.Name = "btnServiceIncome";
            this.btnServiceIncome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnServiceIncome.Size = new System.Drawing.Size(127, 30);
            this.btnServiceIncome.TabIndex = 1;
            this.btnServiceIncome.Text = "Doanh thu dịch vụ";
            this.btnServiceIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceIncome.UseVisualStyleBackColor = false;
            this.btnServiceIncome.Click += new System.EventHandler(this.btnServiceIncome_Click);
            // 
            // btnCourtIncome
            // 
            this.btnCourtIncome.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCourtIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourtIncome.FlatAppearance.BorderSize = 0;
            this.btnCourtIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourtIncome.Location = new System.Drawing.Point(0, 0);
            this.btnCourtIncome.Name = "btnCourtIncome";
            this.btnCourtIncome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCourtIncome.Size = new System.Drawing.Size(127, 30);
            this.btnCourtIncome.TabIndex = 0;
            this.btnCourtIncome.Text = "Doanh thu sân";
            this.btnCourtIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourtIncome.UseVisualStyleBackColor = false;
            this.btnCourtIncome.Click += new System.EventHandler(this.btnCourtIncome_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.LightGray;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Location = new System.Drawing.Point(0, 31);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(127, 31);
            this.btnIncome.TabIndex = 3;
            this.btnIncome.Text = "Thống kê doanh thu";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // btnChartIncome
            // 
            this.btnChartIncome.BackColor = System.Drawing.Color.LightGray;
            this.btnChartIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChartIncome.FlatAppearance.BorderSize = 0;
            this.btnChartIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChartIncome.Location = new System.Drawing.Point(0, 0);
            this.btnChartIncome.Name = "btnChartIncome";
            this.btnChartIncome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnChartIncome.Size = new System.Drawing.Size(127, 31);
            this.btnChartIncome.TabIndex = 2;
            this.btnChartIncome.Text = "Biểu đồ doanh thu";
            this.btnChartIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChartIncome.UseVisualStyleBackColor = false;
            this.btnChartIncome.Click += new System.EventHandler(this.btnChartIncome_Click);
            // 
            // pnlIncome
            // 
            this.pnlIncome.Controls.Add(this.pnlViewreport);
            this.pnlIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncome.Location = new System.Drawing.Point(127, 0);
            this.pnlIncome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(650, 403);
            this.pnlIncome.TabIndex = 1;
            // 
            // pnlViewreport
            // 
            this.pnlViewreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewreport.Location = new System.Drawing.Point(0, 0);
            this.pnlViewreport.Name = "pnlViewreport";
            this.pnlViewreport.Size = new System.Drawing.Size(650, 403);
            this.pnlViewreport.TabIndex = 1;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 403);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "Thống Kê";
            this.panel1.ResumeLayout(false);
            this.pnlReceiptReport.ResumeLayout(false);
            this.pnlIncome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Button btnChartIncome;
        private System.Windows.Forms.Panel pnlViewreport;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel pnlReceiptReport;
        private System.Windows.Forms.Button btnServiceIncome;
        private System.Windows.Forms.Button btnCourtIncome;
        private System.Windows.Forms.Button btnCustomerReport;
        private System.Windows.Forms.Button btnReservationReport;
    }
}