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
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.pnlViewreport = new System.Windows.Forms.Panel();
            this.pnlReceiptReport = new System.Windows.Forms.Panel();
            this.btnCourtReceipt = new System.Windows.Forms.Button();
            this.btnServiceReceipt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlIncome.SuspendLayout();
            this.pnlReceiptReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.pnlReceiptReport);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 403);
            this.panel1.TabIndex = 0;
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.LightGray;
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Location = new System.Drawing.Point(0, 31);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnReceipt.Size = new System.Drawing.Size(123, 31);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "Thống kê hóa đơn";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.Color.LightGray;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Location = new System.Drawing.Point(0, 0);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnIncome.Size = new System.Drawing.Size(123, 31);
            this.btnIncome.TabIndex = 2;
            this.btnIncome.Text = "Thống kê doanh thu";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // pnlIncome
            // 
            this.pnlIncome.Controls.Add(this.pnlViewreport);
            this.pnlIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIncome.Location = new System.Drawing.Point(123, 0);
            this.pnlIncome.Margin = new System.Windows.Forms.Padding(2);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(654, 403);
            this.pnlIncome.TabIndex = 1;
            // 
            // pnlViewreport
            // 
            this.pnlViewreport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlViewreport.Location = new System.Drawing.Point(0, 0);
            this.pnlViewreport.Name = "pnlViewreport";
            this.pnlViewreport.Size = new System.Drawing.Size(654, 403);
            this.pnlViewreport.TabIndex = 1;
            // 
            // pnlReceiptReport
            // 
            this.pnlReceiptReport.Controls.Add(this.btnServiceReceipt);
            this.pnlReceiptReport.Controls.Add(this.btnCourtReceipt);
            this.pnlReceiptReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReceiptReport.Location = new System.Drawing.Point(0, 62);
            this.pnlReceiptReport.Name = "pnlReceiptReport";
            this.pnlReceiptReport.Size = new System.Drawing.Size(123, 63);
            this.pnlReceiptReport.TabIndex = 4;
            // 
            // btnCourtReceipt
            // 
            this.btnCourtReceipt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCourtReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCourtReceipt.FlatAppearance.BorderSize = 0;
            this.btnCourtReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourtReceipt.Location = new System.Drawing.Point(0, 0);
            this.btnCourtReceipt.Name = "btnCourtReceipt";
            this.btnCourtReceipt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCourtReceipt.Size = new System.Drawing.Size(123, 30);
            this.btnCourtReceipt.TabIndex = 0;
            this.btnCourtReceipt.Text = "Hóa đơn sân";
            this.btnCourtReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCourtReceipt.UseVisualStyleBackColor = false;
            this.btnCourtReceipt.Click += new System.EventHandler(this.btnCourtReceipt_Click);
            // 
            // btnServiceReceipt
            // 
            this.btnServiceReceipt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnServiceReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceReceipt.FlatAppearance.BorderSize = 0;
            this.btnServiceReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceReceipt.Location = new System.Drawing.Point(0, 30);
            this.btnServiceReceipt.Name = "btnServiceReceipt";
            this.btnServiceReceipt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnServiceReceipt.Size = new System.Drawing.Size(123, 30);
            this.btnServiceReceipt.TabIndex = 1;
            this.btnServiceReceipt.Text = "Hóa đơn dịch vụ";
            this.btnServiceReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceReceipt.UseVisualStyleBackColor = false;
            this.btnServiceReceipt.Click += new System.EventHandler(this.btnServiceReceipt_Click);
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
            this.pnlIncome.ResumeLayout(false);
            this.pnlReceiptReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Panel pnlViewreport;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Panel pnlReceiptReport;
        private System.Windows.Forms.Button btnServiceReceipt;
        private System.Windows.Forms.Button btnCourtReceipt;
    }
}