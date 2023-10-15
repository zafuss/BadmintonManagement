namespace BadmintonManagement.Forms.ReservationCourt.ReservationReceipt
{
    partial class RevReceipt
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
            this.txtReceiptNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTimePublish = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtraTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvRF_Detail = new System.Windows.Forms.DataGridView();
            this.clnRevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCourtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeposite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.rdoEBanking = new System.Windows.Forms.RadioButton();
            this.rdoCash = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRF_Detail)).BeginInit();
            this.grpPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(222, 47);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.ReadOnly = true;
            this.txtReceiptNo.Size = new System.Drawing.Size(200, 26);
            this.txtReceiptNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày lập";
            // 
            // dtpTimePublish
            // 
            this.dtpTimePublish.Enabled = false;
            this.dtpTimePublish.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimePublish.Location = new System.Drawing.Point(222, 90);
            this.dtpTimePublish.Name = "dtpTimePublish";
            this.dtpTimePublish.Size = new System.Drawing.Size(200, 26);
            this.dtpTimePublish.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phí thời gian thêm";
            // 
            // txtExtraTime
            // 
            this.txtExtraTime.Location = new System.Drawing.Point(222, 144);
            this.txtExtraTime.Name = "txtExtraTime";
            this.txtExtraTime.ReadOnly = true;
            this.txtExtraTime.Size = new System.Drawing.Size(100, 26);
            this.txtExtraTime.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng tiền phải trả";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(222, 255);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 7;
            // 
            // dgvRF_Detail
            // 
            this.dgvRF_Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRF_Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnRevNo,
            this.clnCourtName,
            this.clnMoney});
            this.dgvRF_Detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRF_Detail.Location = new System.Drawing.Point(0, 307);
            this.dgvRF_Detail.Name = "dgvRF_Detail";
            this.dgvRF_Detail.Size = new System.Drawing.Size(899, 367);
            this.dgvRF_Detail.TabIndex = 8;
            // 
            // clnRevNo
            // 
            this.clnRevNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnRevNo.HeaderText = "Phiếu đặt sân";
            this.clnRevNo.Name = "clnRevNo";
            this.clnRevNo.ReadOnly = true;
            // 
            // clnCourtName
            // 
            this.clnCourtName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCourtName.HeaderText = "Tên sân";
            this.clnCourtName.Name = "clnCourtName";
            this.clnCourtName.ReadOnly = true;
            // 
            // clnMoney
            // 
            this.clnMoney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnMoney.HeaderText = "Thành tiền";
            this.clnMoney.Name = "clnMoney";
            this.clnMoney.ReadOnly = true;
            // 
            // txtDeposite
            // 
            this.txtDeposite.Location = new System.Drawing.Point(222, 202);
            this.txtDeposite.Name = "txtDeposite";
            this.txtDeposite.ReadOnly = true;
            this.txtDeposite.Size = new System.Drawing.Size(100, 26);
            this.txtDeposite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền cọc";
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(772, 261);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(127, 40);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(772, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(127, 40);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.rdoEBanking);
            this.grpPayment.Controls.Add(this.rdoCash);
            this.grpPayment.Location = new System.Drawing.Point(477, 53);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(200, 228);
            this.grpPayment.TabIndex = 13;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Phương thức thanh toán";
            // 
            // rdoEBanking
            // 
            this.rdoEBanking.AutoSize = true;
            this.rdoEBanking.Location = new System.Drawing.Point(6, 55);
            this.rdoEBanking.Name = "rdoEBanking";
            this.rdoEBanking.Size = new System.Drawing.Size(129, 24);
            this.rdoEBanking.TabIndex = 1;
            this.rdoEBanking.TabStop = true;
            this.rdoEBanking.Text = "Chuyển khoản";
            this.rdoEBanking.UseVisualStyleBackColor = true;
            // 
            // rdoCash
            // 
            this.rdoCash.AutoSize = true;
            this.rdoCash.Location = new System.Drawing.Point(6, 25);
            this.rdoCash.Name = "rdoCash";
            this.rdoCash.Size = new System.Drawing.Size(88, 24);
            this.rdoCash.TabIndex = 0;
            this.rdoCash.TabStop = true;
            this.rdoCash.Text = "Tiền mặt";
            this.rdoCash.UseVisualStyleBackColor = true;
            // 
            // RevReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 674);
            this.Controls.Add(this.grpPayment);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.txtDeposite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRF_Detail);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtExtraTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpTimePublish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReceiptNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RevReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn phiếu đặt sân";
            this.Load += new System.EventHandler(this.RevReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRF_Detail)).EndInit();
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReceiptNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTimePublish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtraTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvRF_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCourtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMoney;
        private System.Windows.Forms.TextBox txtDeposite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpPayment;
        private System.Windows.Forms.RadioButton rdoEBanking;
        private System.Windows.Forms.RadioButton rdoCash;
    }
}