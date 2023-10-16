namespace BadmintonManagement.Forms.Court
{
    partial class CourtForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.pnlInAdmin = new System.Windows.Forms.Panel();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndTime = new System.Windows.Forms.TextBox();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtNameCustom = new System.Windows.Forms.TextBox();
            this.lblNameCustom = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtCourtName = new System.Windows.Forms.TextBox();
            this.lblCourtName = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnlDisplayCourt = new System.Windows.Forms.Panel();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.pnlInformation.SuspendLayout();
            this.pnlInAdmin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.LightGray;
            this.pnlInformation.Controls.Add(this.pnlAdmin);
            this.pnlInformation.Controls.Add(this.pnlInAdmin);
            this.pnlInformation.Controls.Add(this.btnCalendar);
            this.pnlInformation.Controls.Add(this.pnlUser);
            this.pnlInformation.Controls.Add(this.btnUser);
            this.pnlInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInformation.Location = new System.Drawing.Point(0, 0);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(325, 707);
            this.pnlInformation.TabIndex = 1;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.LightGray;
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 407);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(325, 307);
            this.pnlAdmin.TabIndex = 3;
            // 
            // pnlInAdmin
            // 
            this.pnlInAdmin.BackColor = System.Drawing.Color.LightGray;
            this.pnlInAdmin.Controls.Add(this.btnAdmin);
            this.pnlInAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInAdmin.Location = new System.Drawing.Point(0, 366);
            this.pnlInAdmin.Name = "pnlInAdmin";
            this.pnlInAdmin.Size = new System.Drawing.Size(325, 41);
            this.pnlInAdmin.TabIndex = 6;
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.LightGray;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnAdmin.Size = new System.Drawing.Size(325, 38);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = "Quản Lý Sân";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.LightGray;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.Location = new System.Drawing.Point(0, 328);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(325, 38);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Text = "Xem Lịch Sân";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.AutoScroll = true;
            this.pnlUser.Controls.Add(this.label1);
            this.pnlUser.Controls.Add(this.txtEndTime);
            this.pnlUser.Controls.Add(this.txtStartTime);
            this.pnlUser.Controls.Add(this.txtPhoneNumber);
            this.pnlUser.Controls.Add(this.lblPhoneNumber);
            this.pnlUser.Controls.Add(this.txtNameCustom);
            this.pnlUser.Controls.Add(this.lblNameCustom);
            this.pnlUser.Controls.Add(this.lblEndTime);
            this.pnlUser.Controls.Add(this.lblStartTime);
            this.pnlUser.Controls.Add(this.txtBranchName);
            this.pnlUser.Controls.Add(this.lblBranchName);
            this.pnlUser.Controls.Add(this.txtCourtName);
            this.pnlUser.Controls.Add(this.lblCourtName);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 38);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(325, 290);
            this.pnlUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "1";
            this.label1.Visible = false;
            // 
            // txtEndTime
            // 
            this.txtEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndTime.Location = new System.Drawing.Point(234, 244);
            this.txtEndTime.Name = "txtEndTime";
            this.txtEndTime.ReadOnly = true;
            this.txtEndTime.Size = new System.Drawing.Size(69, 30);
            this.txtEndTime.TabIndex = 14;
            // 
            // txtStartTime
            // 
            this.txtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartTime.Location = new System.Drawing.Point(234, 198);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            this.txtStartTime.Size = new System.Drawing.Size(69, 30);
            this.txtStartTime.TabIndex = 13;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(163, 151);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.ReadOnly = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(140, 34);
            this.txtPhoneNumber.TabIndex = 12;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 157);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblPhoneNumber.Size = new System.Drawing.Size(149, 28);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Số Điện Thoại";
            // 
            // txtNameCustom
            // 
            this.txtNameCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustom.Location = new System.Drawing.Point(163, 104);
            this.txtNameCustom.Name = "txtNameCustom";
            this.txtNameCustom.ReadOnly = true;
            this.txtNameCustom.Size = new System.Drawing.Size(140, 34);
            this.txtNameCustom.TabIndex = 10;
            // 
            // lblNameCustom
            // 
            this.lblNameCustom.AutoSize = true;
            this.lblNameCustom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustom.Location = new System.Drawing.Point(15, 110);
            this.lblNameCustom.Name = "lblNameCustom";
            this.lblNameCustom.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblNameCustom.Size = new System.Drawing.Size(167, 28);
            this.lblNameCustom.TabIndex = 9;
            this.lblNameCustom.Text = "Tên Khách Hàng";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(15, 245);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblEndTime.Size = new System.Drawing.Size(191, 28);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "Thời Gian Kết Thúc";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(15, 200);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblStartTime.Size = new System.Drawing.Size(184, 28);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Thời Gian Bắt Đầu";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchName.Location = new System.Drawing.Point(163, 56);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.ReadOnly = true;
            this.txtBranchName.Size = new System.Drawing.Size(140, 34);
            this.txtBranchName.TabIndex = 3;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBranchName.Location = new System.Drawing.Point(15, 59);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblBranchName.Size = new System.Drawing.Size(100, 28);
            this.lblBranchName.TabIndex = 2;
            this.lblBranchName.Text = "Khu Vực";
            // 
            // txtCourtName
            // 
            this.txtCourtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourtName.Location = new System.Drawing.Point(163, 6);
            this.txtCourtName.Name = "txtCourtName";
            this.txtCourtName.ReadOnly = true;
            this.txtCourtName.Size = new System.Drawing.Size(140, 34);
            this.txtCourtName.TabIndex = 1;
            // 
            // lblCourtName
            // 
            this.lblCourtName.AutoSize = true;
            this.lblCourtName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourtName.Location = new System.Drawing.Point(15, 12);
            this.lblCourtName.Name = "lblCourtName";
            this.lblCourtName.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblCourtName.Size = new System.Drawing.Size(94, 28);
            this.lblCourtName.TabIndex = 0;
            this.lblCourtName.Text = "Tên Sân";
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.LightGray;
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnUser.Size = new System.Drawing.Size(325, 38);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Thông Tin";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnlDisplayCourt
            // 
            this.pnlDisplayCourt.AutoSize = true;
            this.pnlDisplayCourt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisplayCourt.Location = new System.Drawing.Point(325, 0);
            this.pnlDisplayCourt.Name = "pnlDisplayCourt";
            this.pnlDisplayCourt.Size = new System.Drawing.Size(939, 707);
            this.pnlDisplayCourt.TabIndex = 2;
            this.pnlDisplayCourt.SizeChanged += new System.EventHandler(this.pnlDisplayCourt_SizeChanged);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Enabled = true;
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // CourtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 707);
            this.Controls.Add(this.pnlDisplayCourt);
            this.Controls.Add(this.pnlInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CourtForm";
            this.Text = "Quản Lý Sân";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInAdmin.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtCourtName;
        private System.Windows.Forms.Label lblCourtName;
        private System.Windows.Forms.Panel pnlDisplayCourt;
        private System.Windows.Forms.TextBox txtNameCustom;
        private System.Windows.Forms.Label lblNameCustom;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtEndTime;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel pnlInAdmin;
        private System.Windows.Forms.Button btnAdmin;
    }
}