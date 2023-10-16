namespace BadmintonManagement.Forms.Service.ServiceReceipt
{
    partial class ServiceRec
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
            this.dgvServiceDetail = new System.Windows.Forms.DataGridView();
            this.clnServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceRecDetail = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtRecNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbPayment = new System.Windows.Forms.GroupBox();
            this.rdbCreditcard = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServiceDetail
            // 
            this.dgvServiceDetail.AllowUserToDeleteRows = false;
            this.dgvServiceDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnServiceName,
            this.clnQuantity,
            this.clnPrice,
            this.clnTotal});
            this.dgvServiceDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvServiceDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceDetail.Name = "dgvServiceDetail";
            this.dgvServiceDetail.ReadOnly = true;
            this.dgvServiceDetail.RowHeadersWidth = 51;
            this.dgvServiceDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceDetail.Size = new System.Drawing.Size(790, 535);
            this.dgvServiceDetail.TabIndex = 10;
            this.dgvServiceDetail.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvServiceDetail_RowsAdded);
            this.dgvServiceDetail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvServiceDetail_RowsRemoved);
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
            this.clnQuantity.HeaderText = "Số lượng";
            this.clnQuantity.MinimumWidth = 6;
            this.clnQuantity.Name = "clnQuantity";
            this.clnQuantity.ReadOnly = true;
            this.clnQuantity.Width = 125;
            // 
            // clnPrice
            // 
            this.clnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPrice.HeaderText = "Đơn giá";
            this.clnPrice.MinimumWidth = 6;
            this.clnPrice.Name = "clnPrice";
            this.clnPrice.ReadOnly = true;
            // 
            // clnTotal
            // 
            this.clnTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnTotal.HeaderText = "Thành tiền";
            this.clnTotal.MinimumWidth = 6;
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvServiceDetail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(495, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 535);
            this.panel1.TabIndex = 17;
            // 
            // btnServiceRecDetail
            // 
            this.btnServiceRecDetail.Location = new System.Drawing.Point(118, 449);
            this.btnServiceRecDetail.Name = "btnServiceRecDetail";
            this.btnServiceRecDetail.Size = new System.Drawing.Size(109, 44);
            this.btnServiceRecDetail.TabIndex = 11;
            this.btnServiceRecDetail.Text = "Chọn dịch vụ";
            this.btnServiceRecDetail.UseVisualStyleBackColor = true;
            this.btnServiceRecDetail.Click += new System.EventHandler(this.bntServiceRecDetail_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(251, 449);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(124, 44);
            this.btnPayment.TabIndex = 12;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(381, 449);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 44);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(6, 449);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 44);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grbPayment);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnPayment);
            this.groupBox1.Controls.Add(this.btnServiceRecDetail);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.txtRecNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 535);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(206, 249);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 26);
            this.txtEmail.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(206, 307);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(247, 26);
            this.txtTotal.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(206, 188);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(247, 26);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumber.Location = new System.Drawing.Point(206, 128);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(247, 26);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(206, 76);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(247, 26);
            this.txtUser.TabIndex = 6;
            // 
            // txtRecNo
            // 
            this.txtRecNo.Location = new System.Drawing.Point(206, 33);
            this.txtRecNo.Name = "txtRecNo";
            this.txtRecNo.ReadOnly = true;
            this.txtRecNo.Size = new System.Drawing.Size(247, 26);
            this.txtRecNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SDT khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 535);
            this.panel3.TabIndex = 18;
            // 
            // grbPayment
            // 
            this.grbPayment.Controls.Add(this.rdbCash);
            this.grbPayment.Controls.Add(this.rdbCreditcard);
            this.grbPayment.Location = new System.Drawing.Point(29, 353);
            this.grbPayment.Name = "grbPayment";
            this.grbPayment.Size = new System.Drawing.Size(424, 78);
            this.grbPayment.TabIndex = 17;
            this.grbPayment.TabStop = false;
            this.grbPayment.Text = "Chọn hình thức thanh toán";
            // 
            // rdbCreditcard
            // 
            this.rdbCreditcard.AutoSize = true;
            this.rdbCreditcard.Location = new System.Drawing.Point(18, 34);
            this.rdbCreditcard.Name = "rdbCreditcard";
            this.rdbCreditcard.Size = new System.Drawing.Size(129, 24);
            this.rdbCreditcard.TabIndex = 0;
            this.rdbCreditcard.TabStop = true;
            this.rdbCreditcard.Text = "Chuyển khoản";
            this.rdbCreditcard.UseVisualStyleBackColor = true;
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.Location = new System.Drawing.Point(212, 34);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(88, 24);
            this.rdbCash.TabIndex = 1;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Tiền mặt";
            this.rdbCash.UseVisualStyleBackColor = true;
            // 
            // ServiceRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1285, 535);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ServiceRec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập hóa đơn dịch vụ";
            this.Load += new System.EventHandler(this.ServiceReciept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceDetail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbPayment.ResumeLayout(false);
            this.grbPayment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvServiceDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnServiceRecDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtRecNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbPayment;
        private System.Windows.Forms.RadioButton rdbCash;
        private System.Windows.Forms.RadioButton rdbCreditcard;
    }
}