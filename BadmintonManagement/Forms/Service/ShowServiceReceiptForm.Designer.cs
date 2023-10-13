namespace BadmintonManagement.Forms.Service
{
    partial class ShowServiceReceiptForm
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
            this.dgvServiceReceipt = new System.Windows.Forms.DataGridView();
            this.clnSRNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReceipt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServiceReceipt
            // 
            this.dgvServiceReceipt.AllowUserToAddRows = false;
            this.dgvServiceReceipt.AllowUserToDeleteRows = false;
            this.dgvServiceReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnSRNo,
            this.clnCreateDate,
            this.clnPhoneNumber,
            this.clnUser,
            this.clnTotal});
            this.dgvServiceReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceReceipt.Location = new System.Drawing.Point(0, 145);
            this.dgvServiceReceipt.MultiSelect = false;
            this.dgvServiceReceipt.Name = "dgvServiceReceipt";
            this.dgvServiceReceipt.ReadOnly = true;
            this.dgvServiceReceipt.RowHeadersWidth = 51;
            this.dgvServiceReceipt.RowTemplate.Height = 27;
            this.dgvServiceReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceReceipt.Size = new System.Drawing.Size(1057, 596);
            this.dgvServiceReceipt.TabIndex = 0;
            this.dgvServiceReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceReceipt_CellClick);
            // 
            // clnSRNo
            // 
            this.clnSRNo.HeaderText = "Số hoá đơn";
            this.clnSRNo.MinimumWidth = 6;
            this.clnSRNo.Name = "clnSRNo";
            this.clnSRNo.ReadOnly = true;
            this.clnSRNo.Width = 150;
            // 
            // clnCreateDate
            // 
            this.clnCreateDate.HeaderText = "Ngày lập";
            this.clnCreateDate.MinimumWidth = 6;
            this.clnCreateDate.Name = "clnCreateDate";
            this.clnCreateDate.ReadOnly = true;
            this.clnCreateDate.Width = 125;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.HeaderText = "SĐT khách hàng";
            this.clnPhoneNumber.MinimumWidth = 6;
            this.clnPhoneNumber.Name = "clnPhoneNumber";
            this.clnPhoneNumber.ReadOnly = true;
            this.clnPhoneNumber.Width = 200;
            // 
            // clnUser
            // 
            this.clnUser.HeaderText = "Nhân viên lập phiếu";
            this.clnUser.MinimumWidth = 6;
            this.clnUser.Name = "clnUser";
            this.clnUser.ReadOnly = true;
            this.clnUser.Width = 250;
            // 
            // clnTotal
            // 
            this.clnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTotal.HeaderText = "Tổng tiền";
            this.clnTotal.MinimumWidth = 6;
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 145);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hoá đơn dịch vụ";
            // 
            // ShowServiceReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 741);
            this.Controls.Add(this.dgvServiceReceipt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ShowServiceReceiptForm";
            this.Text = "ShowServiceReceiptForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceReceipt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServiceReceipt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSRNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
    }
}