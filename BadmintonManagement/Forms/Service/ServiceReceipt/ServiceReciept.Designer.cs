namespace BadmintonManagement.Forms.Service.ServiceReceipt
{
    partial class ServiceReciept
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecNo = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvServiceDetail = new System.Windows.Forms.DataGridView();
            this.clnServiceRecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntServiceRecDetail = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng";
            // 
            // txtRecNo
            // 
            this.txtRecNo.Location = new System.Drawing.Point(317, 45);
            this.txtRecNo.Name = "txtRecNo";
            this.txtRecNo.ReadOnly = true;
            this.txtRecNo.Size = new System.Drawing.Size(383, 26);
            this.txtRecNo.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(317, 116);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(383, 26);
            this.txtUser.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumber.Location = new System.Drawing.Point(317, 186);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(383, 26);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(317, 249);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(383, 26);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(317, 315);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(383, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // dgvServiceDetail
            // 
            this.dgvServiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnServiceRecNo,
            this.clnServiceName,
            this.clnQuantity,
            this.clnPrice,
            this.clnTotal});
            this.dgvServiceDetail.Location = new System.Drawing.Point(12, 393);
            this.dgvServiceDetail.Name = "dgvServiceDetail";
            this.dgvServiceDetail.Size = new System.Drawing.Size(1171, 353);
            this.dgvServiceDetail.TabIndex = 10;
            // 
            // clnServiceRecNo
            // 
            this.clnServiceRecNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnServiceRecNo.HeaderText = "Số hóa đơn";
            this.clnServiceRecNo.Name = "clnServiceRecNo";
            this.clnServiceRecNo.ReadOnly = true;
            // 
            // clnServiceName
            // 
            this.clnServiceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnServiceName.HeaderText = "Tên dịch vụ";
            this.clnServiceName.Name = "clnServiceName";
            this.clnServiceName.ReadOnly = true;
            // 
            // clnQuantity
            // 
            this.clnQuantity.HeaderText = "Số lượng";
            this.clnQuantity.Name = "clnQuantity";
            this.clnQuantity.ReadOnly = true;
            // 
            // clnPrice
            // 
            this.clnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPrice.HeaderText = "Đơn giá";
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnTotal
            // 
            this.clnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTotal.HeaderText = "Thành tiền";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // bntServiceRecDetail
            // 
            this.bntServiceRecDetail.Location = new System.Drawing.Point(815, 295);
            this.bntServiceRecDetail.Name = "bntServiceRecDetail";
            this.bntServiceRecDetail.Size = new System.Drawing.Size(128, 61);
            this.bntServiceRecDetail.TabIndex = 11;
            this.bntServiceRecDetail.Text = "Chọn dịch vụ";
            this.bntServiceRecDetail.UseVisualStyleBackColor = true;
            this.bntServiceRecDetail.Click += new System.EventHandler(this.bntServiceRecDetail_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(1019, 295);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(125, 61);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // ServiceReciept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1195, 764);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.bntServiceRecDetail);
            this.Controls.Add(this.dgvServiceDetail);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtRecNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceReciept";
            this.Text = "ServiceReciept";
            this.Load += new System.EventHandler(this.ServiceReciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecNo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvServiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceRecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.Button bntServiceRecDetail;
        private System.Windows.Forms.Button btnPayment;
    }
}