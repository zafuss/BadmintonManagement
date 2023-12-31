﻿namespace BadmintonManagement.Forms.Service.ServiceReceipt
{
    partial class ServiceReceiptDetail
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.clnServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudTaken = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvServiceDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaken)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnServiceName,
            this.clnQuantity,
            this.clnUnit,
            this.clnPrice});
            this.dgvService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvService.Location = new System.Drawing.Point(397, 0);
            this.dgvService.MultiSelect = false;
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvService.Size = new System.Drawing.Size(671, 362);
            this.dgvService.TabIndex = 1;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // clnServiceName
            // 
            this.clnServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnServiceName.HeaderText = "Tên dịch vụ";
            this.clnServiceName.MinimumWidth = 6;
            this.clnServiceName.Name = "clnServiceName";
            this.clnServiceName.ReadOnly = true;
            // 
            // clnQuantity
            // 
            this.clnQuantity.HeaderText = "Số lượng tồn";
            this.clnQuantity.MinimumWidth = 6;
            this.clnQuantity.Name = "clnQuantity";
            this.clnQuantity.ReadOnly = true;
            this.clnQuantity.Width = 140;
            // 
            // clnUnit
            // 
            this.clnUnit.HeaderText = "ĐVT";
            this.clnUnit.MinimumWidth = 6;
            this.clnUnit.Name = "clnUnit";
            this.clnUnit.ReadOnly = true;
            this.clnUnit.Width = 125;
            // 
            // clnPrice
            // 
            this.clnPrice.HeaderText = "Giá";
            this.clnPrice.MinimumWidth = 6;
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            this.clnPrice.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(73, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 42);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(73, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 42);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(215, 252);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(99, 42);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudTaken);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 228);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nudTaken
            // 
            this.nudTaken.Enabled = false;
            this.nudTaken.Location = new System.Drawing.Point(152, 106);
            this.nudTaken.Name = "nudTaken";
            this.nudTaken.Size = new System.Drawing.Size(174, 30);
            this.nudTaken.TabIndex = 13;
            this.nudTaken.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(152, 160);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(174, 30);
            this.txtTotal.TabIndex = 12;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(152, 48);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.Size = new System.Drawing.Size(174, 30);
            this.txtServiceName.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên dịch vụ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.btnAccept);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 362);
            this.panel2.TabIndex = 16;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(215, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 42);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvServiceDetail
            // 
            this.dgvServiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clnUsedQuantity,
            this.clnUsedPrice,
            this.clnTotal});
            this.dgvServiceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceDetail.Name = "dgvServiceDetail";
            this.dgvServiceDetail.RowHeadersWidth = 51;
            this.dgvServiceDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceDetail.Size = new System.Drawing.Size(1068, 308);
            this.dgvServiceDetail.TabIndex = 2;
            this.dgvServiceDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceDetail_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "tên dịch vụ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clnUsedQuantity
            // 
            this.clnUsedQuantity.HeaderText = "Số lượng";
            this.clnUsedQuantity.MinimumWidth = 6;
            this.clnUsedQuantity.Name = "clnUsedQuantity";
            this.clnUsedQuantity.ReadOnly = true;
            this.clnUsedQuantity.Width = 125;
            // 
            // clnUsedPrice
            // 
            this.clnUsedPrice.HeaderText = "Giá";
            this.clnUsedPrice.MinimumWidth = 6;
            this.clnUsedPrice.Name = "clnUsedPrice";
            this.clnUsedPrice.ReadOnly = true;
            this.clnUsedPrice.Width = 125;
            // 
            // clnTotal
            // 
            this.clnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTotal.HeaderText = "Thành tiền";
            this.clnTotal.MinimumWidth = 6;
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvService);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 362);
            this.panel3.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvServiceDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 308);
            this.panel1.TabIndex = 18;
            // 
            // ServiceReceiptDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1068, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceReceiptDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn Dịch Vụ";
            this.Load += new System.EventHandler(this.ServiceReceiptDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTaken)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudTaken;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvServiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}