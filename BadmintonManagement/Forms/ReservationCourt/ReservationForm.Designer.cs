namespace BadmintonManagement.Forms.ReservationCourt
{
    partial class ReservationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.clnRevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeposite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStartime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGot = new System.Windows.Forms.Button();
            this.btnAcceptDeposition = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.btnNotYetPayed = new System.Windows.Forms.Button();
            this.btnNotYetDeposited = new System.Windows.Forms.Button();
            this.btnNotYetAccepted = new System.Windows.Forms.Button();
            this.btnOverTime = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.btnRevReceipt = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.txtSearchByPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbThisMonth = new System.Windows.Forms.CheckBox();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnRevNo,
            this.clnUserName,
            this.clnPhoneNumber,
            this.clnCustomer,
            this.clnDeposite,
            this.clnCreateDate,
            this.clnStartime,
            this.clnEndTime,
            this.clnStatus});
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(3, 16);
            this.dgvReservation.MultiSelect = false;
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.Size = new System.Drawing.Size(934, 534);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.SelectionChanged += new System.EventHandler(this.dgvReservation_SelectionChanged);
            // 
            // clnRevNo
            // 
            this.clnRevNo.HeaderText = "Số phiếu";
            this.clnRevNo.Name = "clnRevNo";
            this.clnRevNo.ReadOnly = true;
            this.clnRevNo.Width = 70;
            // 
            // clnUserName
            // 
            this.clnUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnUserName.HeaderText = "Tên nhân viên";
            this.clnUserName.Name = "clnUserName";
            this.clnUserName.ReadOnly = true;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnPhoneNumber.HeaderText = "Số điện thoại";
            this.clnPhoneNumber.Name = "clnPhoneNumber";
            this.clnPhoneNumber.ReadOnly = true;
            // 
            // clnCustomer
            // 
            this.clnCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnCustomer.HeaderText = "Tên Khách hàng";
            this.clnCustomer.Name = "clnCustomer";
            this.clnCustomer.ReadOnly = true;
            // 
            // clnDeposite
            // 
            this.clnDeposite.HeaderText = "Đặt cọc";
            this.clnDeposite.Name = "clnDeposite";
            this.clnDeposite.ReadOnly = true;
            // 
            // clnCreateDate
            // 
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.clnCreateDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.clnCreateDate.HeaderText = "Ngày đặt";
            this.clnCreateDate.Name = "clnCreateDate";
            this.clnCreateDate.ReadOnly = true;
            // 
            // clnStartime
            // 
            dataGridViewCellStyle2.Format = "HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.clnStartime.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnStartime.HeaderText = "Bắt đầu";
            this.clnStartime.Name = "clnStartime";
            this.clnStartime.ReadOnly = true;
            this.clnStartime.Width = 70;
            // 
            // clnEndTime
            // 
            dataGridViewCellStyle3.Format = "HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.clnEndTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnEndTime.HeaderText = "Kết thúc";
            this.clnEndTime.Name = "clnEndTime";
            this.clnEndTime.ReadOnly = true;
            this.clnEndTime.Width = 70;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Tình trạng";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 150;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(528, 61);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDay.TabIndex = 4;
            this.dtpEndDay.ValueChanged += new System.EventHandler(this.dtpEndDay_ValueChanged);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(261, 61);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDay.TabIndex = 5;
            this.dtpStartDay.ValueChanged += new System.EventHandler(this.dtpStartDay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservation);
            this.groupBox1.Location = new System.Drawing.Point(217, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 553);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt sân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGot);
            this.groupBox2.Controls.Add(this.btnAcceptDeposition);
            this.groupBox2.Controls.Add(this.pnlSearch);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.pnlFunction);
            this.groupBox2.Controls.Add(this.btnFunction);
            this.groupBox2.Location = new System.Drawing.Point(-4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 649);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btnGot
            // 
            this.btnGot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGot.Enabled = false;
            this.btnGot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGot.Location = new System.Drawing.Point(3, 499);
            this.btnGot.Name = "btnGot";
            this.btnGot.Size = new System.Drawing.Size(212, 40);
            this.btnGot.TabIndex = 9;
            this.btnGot.Text = "Xác nhận nhận sân";
            this.btnGot.UseVisualStyleBackColor = true;
            this.btnGot.Click += new System.EventHandler(this.btnGot_Click);
            // 
            // btnAcceptDeposition
            // 
            this.btnAcceptDeposition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcceptDeposition.Enabled = false;
            this.btnAcceptDeposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDeposition.Location = new System.Drawing.Point(3, 459);
            this.btnAcceptDeposition.Name = "btnAcceptDeposition";
            this.btnAcceptDeposition.Size = new System.Drawing.Size(212, 40);
            this.btnAcceptDeposition.TabIndex = 8;
            this.btnAcceptDeposition.Text = "Xác nhận cọc";
            this.btnAcceptDeposition.UseVisualStyleBackColor = true;
            this.btnAcceptDeposition.Click += new System.EventHandler(this.btnAcceptDeposition_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.btnCancelFilter);
            this.pnlSearch.Controls.Add(this.btnNotYetPayed);
            this.pnlSearch.Controls.Add(this.btnNotYetDeposited);
            this.pnlSearch.Controls.Add(this.btnNotYetAccepted);
            this.pnlSearch.Controls.Add(this.btnOverTime);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(3, 257);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(212, 202);
            this.pnlSearch.TabIndex = 7;
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFilter.Location = new System.Drawing.Point(0, 160);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(212, 40);
            this.btnCancelFilter.TabIndex = 5;
            this.btnCancelFilter.Text = "Bỏ lọc";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // btnNotYetPayed
            // 
            this.btnNotYetPayed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetPayed.Location = new System.Drawing.Point(0, 120);
            this.btnNotYetPayed.Name = "btnNotYetPayed";
            this.btnNotYetPayed.Size = new System.Drawing.Size(212, 40);
            this.btnNotYetPayed.TabIndex = 4;
            this.btnNotYetPayed.Text = "Chưa thanh toán";
            this.btnNotYetPayed.UseVisualStyleBackColor = true;
            this.btnNotYetPayed.Click += new System.EventHandler(this.btnNotYetPayed_Click);
            // 
            // btnNotYetDeposited
            // 
            this.btnNotYetDeposited.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetDeposited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetDeposited.Location = new System.Drawing.Point(0, 80);
            this.btnNotYetDeposited.Name = "btnNotYetDeposited";
            this.btnNotYetDeposited.Size = new System.Drawing.Size(212, 40);
            this.btnNotYetDeposited.TabIndex = 2;
            this.btnNotYetDeposited.Text = "Chưa đặt cọc";
            this.btnNotYetDeposited.UseVisualStyleBackColor = true;
            this.btnNotYetDeposited.Click += new System.EventHandler(this.btnNotYetDeposited_Click);
            // 
            // btnNotYetAccepted
            // 
            this.btnNotYetAccepted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetAccepted.Location = new System.Drawing.Point(0, 40);
            this.btnNotYetAccepted.Name = "btnNotYetAccepted";
            this.btnNotYetAccepted.Size = new System.Drawing.Size(212, 40);
            this.btnNotYetAccepted.TabIndex = 1;
            this.btnNotYetAccepted.Text = "Chưa nhận sân";
            this.btnNotYetAccepted.UseVisualStyleBackColor = true;
            this.btnNotYetAccepted.Click += new System.EventHandler(this.btnNotYetAccepted_Click);
            // 
            // btnOverTime
            // 
            this.btnOverTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverTime.Location = new System.Drawing.Point(0, 0);
            this.btnOverTime.Name = "btnOverTime";
            this.btnOverTime.Size = new System.Drawing.Size(212, 40);
            this.btnOverTime.TabIndex = 0;
            this.btnOverTime.Text = "Quá giờ nhận sân";
            this.btnOverTime.UseVisualStyleBackColor = true;
            this.btnOverTime.Click += new System.EventHandler(this.btnOverTime_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(3, 217);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(212, 40);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlFunction
            // 
            this.pnlFunction.Controls.Add(this.btnRevReceipt);
            this.pnlFunction.Controls.Add(this.btnCancel);
            this.pnlFunction.Controls.Add(this.btnDetail);
            this.pnlFunction.Controls.Add(this.btnAdd);
            this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFunction.Location = new System.Drawing.Point(3, 56);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(212, 161);
            this.pnlFunction.TabIndex = 5;
            // 
            // btnRevReceipt
            // 
            this.btnRevReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevReceipt.Enabled = false;
            this.btnRevReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevReceipt.Location = new System.Drawing.Point(0, 120);
            this.btnRevReceipt.Name = "btnRevReceipt";
            this.btnRevReceipt.Size = new System.Drawing.Size(212, 40);
            this.btnRevReceipt.TabIndex = 3;
            this.btnRevReceipt.Text = "Lập hóa đơn";
            this.btnRevReceipt.UseVisualStyleBackColor = true;
            this.btnRevReceipt.Click += new System.EventHandler(this.btnRevReceipt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(0, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(212, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(0, 40);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(212, 40);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(212, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.Location = new System.Drawing.Point(3, 16);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(212, 40);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "Chức năng";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // txtSearchByPhoneNumber
            // 
            this.txtSearchByPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPhoneNumber.Location = new System.Drawing.Point(837, 63);
            this.txtSearchByPhoneNumber.Name = "txtSearchByPhoneNumber";
            this.txtSearchByPhoneNumber.Size = new System.Drawing.Size(262, 26);
            this.txtSearchByPhoneNumber.TabIndex = 1;
            this.txtSearchByPhoneNumber.Text = "Nhập số điện thoại";
            this.txtSearchByPhoneNumber.Click += new System.EventHandler(this.txtSearchByPhoneNumber_Click);
            this.txtSearchByPhoneNumber.TextChanged += new System.EventHandler(this.txtSearchByPhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ";
            // 
            // chbThisMonth
            // 
            this.chbThisMonth.AutoSize = true;
            this.chbThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbThisMonth.Location = new System.Drawing.Point(232, 16);
            this.chbThisMonth.Name = "chbThisMonth";
            this.chbThisMonth.Size = new System.Drawing.Size(229, 24);
            this.chbThisMonth.TabIndex = 14;
            this.chbThisMonth.Text = "Danh sách phiếu theo tháng";
            this.chbThisMonth.UseVisualStyleBackColor = true;
            this.chbThisMonth.CheckedChanged += new System.EventHandler(this.chbThisMonth_CheckedChanged);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Interval = 60000;
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 650);
            this.Controls.Add(this.chbThisMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchByPhoneNumber);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.dtpEndDay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.Text = "Phiếu Đặt Sân";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       

        

        #endregion
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnNotYetDeposited;
        private System.Windows.Forms.Button btnNotYetAccepted;
        private System.Windows.Forms.Button btnOverTime;
        private System.Windows.Forms.TextBox txtSearchByPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRevReceipt;
        private System.Windows.Forms.Button btnAcceptDeposition;
        private System.Windows.Forms.CheckBox chbThisMonth;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.Button btnGot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnNotYetPayed;
        private System.Windows.Forms.Button btnCancelFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStartime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}