﻿namespace BadmintonManagement.Forms.AuthorizationForms
{
    partial class HomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUser = new System.Windows.Forms.ToolStripMenuItem();
            this.sânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuĐặtSânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trungTâmTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCourt = new System.Windows.Forms.ToolStripButton();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnService = new System.Windows.Forms.ToolStripButton();
            this.btnReservation = new System.Windows.Forms.ToolStripButton();
            this.btnReceipt = new System.Windows.Forms.ToolStripButton();
            this.btnReport = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.btnPrice = new System.Windows.Forms.ToolStripButton();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.timerRealTimeStatusCapture = new System.Windows.Forms.Timer(this.components);
            this.tmrRload = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1238, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUser,
            this.sânToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.dịchVụToolStripMenuItem,
            this.phiếuĐặtSânToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.mnPrice,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mnUser
            // 
            this.mnUser.Name = "mnUser";
            this.mnUser.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnUser.Size = new System.Drawing.Size(230, 26);
            this.mnUser.Text = "Tài khoản";
            this.mnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // sânToolStripMenuItem
            // 
            this.sânToolStripMenuItem.Name = "sânToolStripMenuItem";
            this.sânToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.sânToolStripMenuItem.Text = "Sân";
            this.sânToolStripMenuItem.Click += new System.EventHandler(this.btnCourt_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.dịchVụToolStripMenuItem.Text = "Dịch vụ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.btnService_Click_1);
            // 
            // phiếuĐặtSânToolStripMenuItem
            // 
            this.phiếuĐặtSânToolStripMenuItem.Name = "phiếuĐặtSânToolStripMenuItem";
            this.phiếuĐặtSânToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.phiếuĐặtSânToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.phiếuĐặtSânToolStripMenuItem.Text = "Phiếu đặt sân";
            this.phiếuĐặtSânToolStripMenuItem.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // mnPrice
            // 
            this.mnPrice.Name = "mnPrice";
            this.mnPrice.Size = new System.Drawing.Size(230, 26);
            this.mnPrice.Text = "Bảng giá";
            this.mnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trungTâmTàiKhoảnToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // trungTâmTàiKhoảnToolStripMenuItem
            // 
            this.trungTâmTàiKhoảnToolStripMenuItem.Name = "trungTâmTàiKhoảnToolStripMenuItem";
            this.trungTâmTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.trungTâmTàiKhoảnToolStripMenuItem.Text = "Trung tâm tài khoản";
            this.trungTâmTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.trungTâmTàiKhoảnToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCourt,
            this.btnCustomer,
            this.btnService,
            this.btnReservation,
            this.btnReceipt,
            this.btnReport,
            this.btnExit,
            this.toolStripSeparator1,
            this.btnUser,
            this.btnPrice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1238, 59);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCourt
            // 
            this.btnCourt.Image = global::BadmintonManagement.Properties.Resources.court;
            this.btnCourt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCourt.Name = "btnCourt";
            this.btnCourt.Size = new System.Drawing.Size(48, 56);
            this.btnCourt.Text = "Sân";
            this.btnCourt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCourt.Click += new System.EventHandler(this.btnCourt_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Image = global::BadmintonManagement.Properties.Resources.customer__1_;
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(121, 56);
            this.btnCustomer.Text = "Khách Hàng";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnService
            // 
            this.btnService.Image = global::BadmintonManagement.Properties.Resources.service;
            this.btnService.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(83, 56);
            this.btnService.Text = "Dịch Vụ";
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnService.Click += new System.EventHandler(this.btnService_Click_1);
            // 
            // btnReservation
            // 
            this.btnReservation.Image = global::BadmintonManagement.Properties.Resources.reservation;
            this.btnReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(137, 56);
            this.btnReservation.Text = "Phiếu Đặt Sân";
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReservation.ToolTipText = "Phiếu Đặt Sân";
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Image = global::BadmintonManagement.Properties.Resources.paper;
            this.btnReceipt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(94, 56);
            this.btnReceipt.Text = "Hóa Đơn";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnReport
            // 
            this.btnReport.Image = global::BadmintonManagement.Properties.Resources.report;
            this.btnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 56);
            this.btnReport.Text = "Thống Kê";
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = global::BadmintonManagement.Properties.Resources.logout;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 56);
            this.btnExit.Text = "Đăng Xuất";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnUser
            // 
            this.btnUser.Image = global::BadmintonManagement.Properties.Resources.user;
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 56);
            this.btnUser.Text = "Tài Khoản";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Image = global::BadmintonManagement.Properties.Resources.prices1;
            this.btnPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(94, 56);
            this.btnPrice.Text = "Bảng Giá";
            this.btnPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Controls.Add(this.tabControl);
            this.pnlChildForm.Controls.Add(this.panel1);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 87);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1238, 679);
            this.pnlChildForm.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1238, 645);
            this.tabControl.TabIndex = 0;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 645);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 34);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(1070, 4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 28);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "DateTime";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(7, 3);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(125, 28);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "Tennhan vien";
            // 
            // timerRealTimeStatusCapture
            // 
            this.timerRealTimeStatusCapture.Interval = 60000;
            this.timerRealTimeStatusCapture.Tick += new System.EventHandler(this.timerRealTimeStatusCapture_Tick);
            // 
            // tmrRload
            // 
            this.tmrRload.Enabled = true;
            this.tmrRload.Interval = 1000;
            this.tmrRload.Tick += new System.EventHandler(this.tmrRload_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 766);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sân Cầu Lông";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomePage_FormClosed);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlChildForm.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripButton btnService;
        private System.Windows.Forms.ToolStripButton btnReservation;
        private System.Windows.Forms.ToolStripButton btnReceipt;
        private System.Windows.Forms.ToolStripButton btnPrice;
        private System.Windows.Forms.ToolStripButton btnReport;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnCourt;
        private System.Windows.Forms.ToolStripMenuItem mnUser;
        private System.Windows.Forms.ToolStripMenuItem sânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuĐặtSânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnPrice;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Timer timerRealTimeStatusCapture;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrRload;
        private System.Windows.Forms.ToolStripMenuItem trungTâmTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}