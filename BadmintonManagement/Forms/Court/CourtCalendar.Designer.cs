namespace BadmintonManagement.Forms.Court
{
    partial class CourtCalendar
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pnlInf = new System.Windows.Forms.Panel();
            this.pnlCalender = new System.Windows.Forms.Panel();
            this.lstvCalender = new System.Windows.Forms.ListView();
            this.clnReservationNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnStartHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnEndHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTotalHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.dtmEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtmStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoCheckWeek = new System.Windows.Forms.RadioButton();
            this.rdoCheckMonth = new System.Windows.Forms.RadioButton();
            this.rdoCheckDay = new System.Windows.Forms.RadioButton();
            this.pnlInf.SuspendLayout();
            this.pnlCalender.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1355, 118);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.SizeChanged += new System.EventHandler(this.pnlTitle_SizeChanged);
            // 
            // pnlInf
            // 
            this.pnlInf.Controls.Add(this.pnlCalender);
            this.pnlInf.Controls.Add(this.pnlButton);
            this.pnlInf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlInf.Location = new System.Drawing.Point(0, 118);
            this.pnlInf.Name = "pnlInf";
            this.pnlInf.Size = new System.Drawing.Size(1355, 599);
            this.pnlInf.TabIndex = 1;
            // 
            // pnlCalender
            // 
            this.pnlCalender.Controls.Add(this.lstvCalender);
            this.pnlCalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalender.Location = new System.Drawing.Point(0, 38);
            this.pnlCalender.Name = "pnlCalender";
            this.pnlCalender.Size = new System.Drawing.Size(1355, 561);
            this.pnlCalender.TabIndex = 1;
            // 
            // lstvCalender
            // 
            this.lstvCalender.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnReservationNo,
            this.clnFullName,
            this.clnPhoneNumber,
            this.clnStartDate,
            this.clnStartHour,
            this.clnEndHour,
            this.clnTotalHour});
            this.lstvCalender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstvCalender.HideSelection = false;
            this.lstvCalender.Location = new System.Drawing.Point(0, 0);
            this.lstvCalender.Margin = new System.Windows.Forms.Padding(2);
            this.lstvCalender.Name = "lstvCalender";
            this.lstvCalender.Size = new System.Drawing.Size(1355, 561);
            this.lstvCalender.TabIndex = 0;
            this.lstvCalender.UseCompatibleStateImageBehavior = false;
            this.lstvCalender.View = System.Windows.Forms.View.Details;
            // 
            // clnReservationNo
            // 
            this.clnReservationNo.Text = "Mã Phiếu";
            this.clnReservationNo.Width = 149;
            // 
            // clnFullName
            // 
            this.clnFullName.Text = "Tên Khách Hàng";
            this.clnFullName.Width = 167;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.Text = "Số Điện Thoại";
            this.clnPhoneNumber.Width = 150;
            // 
            // clnStartDate
            // 
            this.clnStartDate.Text = "Ngày Chơi";
            this.clnStartDate.Width = 127;
            // 
            // clnStartHour
            // 
            this.clnStartHour.Text = "Bắt Đầu";
            this.clnStartHour.Width = 91;
            // 
            // clnEndHour
            // 
            this.clnEndHour.Text = "Kết Thúc";
            this.clnEndHour.Width = 90;
            // 
            // clnTotalHour
            // 
            this.clnTotalHour.Text = "Tổng Giờ Chơi";
            this.clnTotalHour.Width = 151;
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnReset);
            this.pnlButton.Controls.Add(this.dtmEndDate);
            this.pnlButton.Controls.Add(this.dtmStartDate);
            this.pnlButton.Controls.Add(this.btnExit);
            this.pnlButton.Controls.Add(this.rdoCheckWeek);
            this.pnlButton.Controls.Add(this.rdoCheckMonth);
            this.pnlButton.Controls.Add(this.rdoCheckDay);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButton.Location = new System.Drawing.Point(0, 0);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1355, 38);
            this.pnlButton.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReset.Location = new System.Drawing.Point(1062, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(189, 38);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Sân Khả Dụng";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dtmEndDate
            // 
            this.dtmEndDate.CustomFormat = "dd/MM/yyy";
            this.dtmEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtmEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmEndDate.Location = new System.Drawing.Point(814, 0);
            this.dtmEndDate.Name = "dtmEndDate";
            this.dtmEndDate.Size = new System.Drawing.Size(172, 34);
            this.dtmEndDate.TabIndex = 5;
            this.dtmEndDate.ValueChanged += new System.EventHandler(this.dtmEndDate_ValueChanged);
            // 
            // dtmStartDate
            // 
            this.dtmStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmStartDate.CustomFormat = "dd/MM/yyyy";
            this.dtmStartDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtmStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmStartDate.Location = new System.Drawing.Point(644, 0);
            this.dtmStartDate.Name = "dtmStartDate";
            this.dtmStartDate.Size = new System.Drawing.Size(170, 34);
            this.dtmStartDate.TabIndex = 4;
            this.dtmStartDate.ValueChanged += new System.EventHandler(this.dtmStartDate_ValueChanged);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Location = new System.Drawing.Point(1251, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoCheckWeek
            // 
            this.rdoCheckWeek.AutoSize = true;
            this.rdoCheckWeek.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoCheckWeek.Location = new System.Drawing.Point(435, 0);
            this.rdoCheckWeek.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCheckWeek.Name = "rdoCheckWeek";
            this.rdoCheckWeek.Size = new System.Drawing.Size(209, 38);
            this.rdoCheckWeek.TabIndex = 2;
            this.rdoCheckWeek.Text = "Tìm Kiếm Theo Tuần";
            this.rdoCheckWeek.UseVisualStyleBackColor = true;
            this.rdoCheckWeek.CheckedChanged += new System.EventHandler(this.rdoCheckWeek_CheckedChanged);
            // 
            // rdoCheckMonth
            // 
            this.rdoCheckMonth.AutoSize = true;
            this.rdoCheckMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoCheckMonth.Location = new System.Drawing.Point(214, 0);
            this.rdoCheckMonth.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCheckMonth.Name = "rdoCheckMonth";
            this.rdoCheckMonth.Size = new System.Drawing.Size(221, 38);
            this.rdoCheckMonth.TabIndex = 1;
            this.rdoCheckMonth.Text = "Tìm Kiếm Theo Tháng";
            this.rdoCheckMonth.UseVisualStyleBackColor = true;
            this.rdoCheckMonth.CheckedChanged += new System.EventHandler(this.rdoCheckMonth_CheckedChanged);
            // 
            // rdoCheckDay
            // 
            this.rdoCheckDay.AutoSize = true;
            this.rdoCheckDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoCheckDay.Location = new System.Drawing.Point(0, 0);
            this.rdoCheckDay.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCheckDay.Name = "rdoCheckDay";
            this.rdoCheckDay.Size = new System.Drawing.Size(214, 38);
            this.rdoCheckDay.TabIndex = 0;
            this.rdoCheckDay.Text = "Tìm Kiếm Theo Ngày";
            this.rdoCheckDay.UseVisualStyleBackColor = true;
            this.rdoCheckDay.CheckedChanged += new System.EventHandler(this.rdoCheckDay_CheckedChanged);
            // 
            // CourtCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 717);
            this.Controls.Add(this.pnlInf);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourtCalendar";
            this.Text = "Lịch Sân";
            this.pnlInf.ResumeLayout(false);
            this.pnlCalender.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.pnlButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlInf;
        private System.Windows.Forms.Panel pnlCalender;
        private System.Windows.Forms.ListView lstvCalender;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.ColumnHeader clnReservationNo;
        private System.Windows.Forms.ColumnHeader clnFullName;
        private System.Windows.Forms.ColumnHeader clnPhoneNumber;
        private System.Windows.Forms.ColumnHeader clnStartDate;
        private System.Windows.Forms.ColumnHeader clnStartHour;
        private System.Windows.Forms.ColumnHeader clnEndHour;
        private System.Windows.Forms.ColumnHeader clnTotalHour;
        private System.Windows.Forms.DateTimePicker dtmStartDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoCheckWeek;
        private System.Windows.Forms.RadioButton rdoCheckMonth;
        private System.Windows.Forms.RadioButton rdoCheckDay;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DateTimePicker dtmEndDate;
    }
}