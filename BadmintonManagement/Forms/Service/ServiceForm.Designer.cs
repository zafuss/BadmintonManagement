﻿namespace BadmintonManagement.Forms.Service
{
    partial class ServiceForm
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
            this.btnServiceReceipt = new System.Windows.Forms.Button();
            this.pnlListReceip = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReceiptServices = new System.Windows.Forms.Button();
            this.pnlChild = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlListReceip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnServiceReceipt);
            this.panel1.Controls.Add(this.pnlListReceip);
            this.panel1.Controls.Add(this.btnReceiptServices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 741);
            this.panel1.TabIndex = 0;
            // 
            // btnServiceReceipt
            // 
            this.btnServiceReceipt.BackColor = System.Drawing.Color.LightGray;
            this.btnServiceReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceReceipt.FlatAppearance.BorderSize = 0;
            this.btnServiceReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceReceipt.Location = new System.Drawing.Point(0, 125);
            this.btnServiceReceipt.Name = "btnServiceReceipt";
            this.btnServiceReceipt.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnServiceReceipt.Size = new System.Drawing.Size(239, 40);
            this.btnServiceReceipt.TabIndex = 3;
            this.btnServiceReceipt.Text = "Quản lý dịch vụ";
            this.btnServiceReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceReceipt.UseVisualStyleBackColor = false;
            this.btnServiceReceipt.Click += new System.EventHandler(this.btnServiceReceipt_Click_1);
            // 
            // pnlListReceip
            // 
            this.pnlListReceip.Controls.Add(this.btnDetail);
            this.pnlListReceip.Controls.Add(this.btnAdd);
            this.pnlListReceip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListReceip.Location = new System.Drawing.Point(0, 40);
            this.pnlListReceip.Name = "pnlListReceip";
            this.pnlListReceip.Size = new System.Drawing.Size(239, 85);
            this.pnlListReceip.TabIndex = 2;
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.LightGray;
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Location = new System.Drawing.Point(0, 40);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnDetail.Size = new System.Drawing.Size(239, 40);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Xem hóa đơn";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(239, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm hóa đơn";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReceiptServices
            // 
            this.btnReceiptServices.BackColor = System.Drawing.Color.LightGray;
            this.btnReceiptServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiptServices.FlatAppearance.BorderSize = 0;
            this.btnReceiptServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiptServices.Location = new System.Drawing.Point(0, 0);
            this.btnReceiptServices.Name = "btnReceiptServices";
            this.btnReceiptServices.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReceiptServices.Size = new System.Drawing.Size(239, 40);
            this.btnReceiptServices.TabIndex = 1;
            this.btnReceiptServices.Text = "Danh sách hoá đơn dịch vụ";
            this.btnReceiptServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceiptServices.UseVisualStyleBackColor = false;
            this.btnReceiptServices.Click += new System.EventHandler(this.btnReceiptServices_Click);
            // 
            // pnlChild
            // 
            this.pnlChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChild.Location = new System.Drawing.Point(239, 0);
            this.pnlChild.Name = "pnlChild";
            this.pnlChild.Size = new System.Drawing.Size(1018, 741);
            this.pnlChild.TabIndex = 2;
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 741);
            this.Controls.Add(this.pnlChild);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ServiceForm";
            this.Text = "Dịch vụ";
            this.Load += new System.EventHandler(this.ServiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.pnlListReceip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlChild;
        private System.Windows.Forms.Button btnReceiptServices;
        private System.Windows.Forms.Panel pnlListReceip;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnServiceReceipt;
    }
}