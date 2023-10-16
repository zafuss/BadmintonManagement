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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.txtSearchByPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbThisMonth = new System.Windows.Forms.CheckBox();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.clnRevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeposite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStartime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlFunction.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.clnBookingDate,
            this.clnStartime,
            this.clnEndTime,
            this.clnStatus});
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(6, 34);
            this.dgvReservation.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dgvReservation.MultiSelect = false;
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(1585, 894);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            this.dgvReservation.SelectionChanged += new System.EventHandler(this.dgvReservation_SelectionChanged);
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDay.Location = new System.Drawing.Point(267, 84);
            this.dtpEndDay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(120, 30);
            this.dtpEndDay.TabIndex = 4;
            this.dtpEndDay.ValueChanged += new System.EventHandler(this.dtpEndDay_ValueChanged);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDay.Location = new System.Drawing.Point(70, 85);
            this.dtpStartDay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(120, 30);
            this.dtpStartDay.TabIndex = 5;
            this.dtpStartDay.ValueChanged += new System.EventHandler(this.dtpStartDay_ValueChanged);
            // 
            // txtSearchByPhoneNumber
            // 
            this.txtSearchByPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchByPhoneNumber.Location = new System.Drawing.Point(463, 84);
            this.txtSearchByPhoneNumber.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtSearchByPhoneNumber.Name = "txtSearchByPhoneNumber";
            this.txtSearchByPhoneNumber.Size = new System.Drawing.Size(322, 30);
            this.txtSearchByPhoneNumber.TabIndex = 1;
            this.txtSearchByPhoneNumber.Text = "Tìm kiếm";
            this.txtSearchByPhoneNumber.Click += new System.EventHandler(this.txtSearchByPhoneNumber_Click);
            this.txtSearchByPhoneNumber.TextChanged += new System.EventHandler(this.txtSearchByPhoneNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ";
            // 
            // chbThisMonth
            // 
            this.chbThisMonth.AutoSize = true;
            this.chbThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbThisMonth.Location = new System.Drawing.Point(42, 43);
            this.chbThisMonth.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.chbThisMonth.Name = "chbThisMonth";
            this.chbThisMonth.Size = new System.Drawing.Size(278, 29);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservation);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.groupBox1.Size = new System.Drawing.Size(1597, 935);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt sân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpStartDay);
            this.panel1.Controls.Add(this.chbThisMonth);
            this.panel1.Controls.Add(this.dtpEndDay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearchByPhoneNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1597, 120);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btnGot);
            this.panel2.Controls.Add(this.btnAcceptDeposition);
            this.panel2.Controls.Add(this.pnlSearch);
            this.panel2.Controls.Add(this.btnFilter);
            this.panel2.Controls.Add(this.pnlFunction);
            this.panel2.Controls.Add(this.btnFunction);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 1055);
            this.panel2.TabIndex = 16;
            // 
            // btnGot
            // 
            this.btnGot.BackColor = System.Drawing.Color.LightGray;
            this.btnGot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGot.Enabled = false;
            this.btnGot.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnGot.FlatAppearance.BorderSize = 0;
            this.btnGot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGot.Location = new System.Drawing.Point(0, 482);
            this.btnGot.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnGot.Name = "btnGot";
            this.btnGot.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnGot.Size = new System.Drawing.Size(327, 40);
            this.btnGot.TabIndex = 22;
            this.btnGot.Text = "Xác nhận nhận sân";
            this.btnGot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGot.UseVisualStyleBackColor = true;
            this.btnGot.Click += new System.EventHandler(this.btnGot_Click);
            // 
            // btnAcceptDeposition
            // 
            this.btnAcceptDeposition.BackColor = System.Drawing.Color.LightGray;
            this.btnAcceptDeposition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcceptDeposition.Enabled = false;
            this.btnAcceptDeposition.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAcceptDeposition.FlatAppearance.BorderSize = 0;
            this.btnAcceptDeposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptDeposition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptDeposition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAcceptDeposition.Location = new System.Drawing.Point(0, 442);
            this.btnAcceptDeposition.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAcceptDeposition.Name = "btnAcceptDeposition";
            this.btnAcceptDeposition.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAcceptDeposition.Size = new System.Drawing.Size(327, 40);
            this.btnAcceptDeposition.TabIndex = 21;
            this.btnAcceptDeposition.Text = "Xác nhận cọc";
            this.btnAcceptDeposition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlSearch.Location = new System.Drawing.Point(0, 246);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(327, 196);
            this.pnlSearch.TabIndex = 24;
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancelFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancelFilter.FlatAppearance.BorderSize = 0;
            this.btnCancelFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFilter.Location = new System.Drawing.Point(0, 160);
            this.btnCancelFilter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnCancelFilter.Size = new System.Drawing.Size(327, 40);
            this.btnCancelFilter.TabIndex = 24;
            this.btnCancelFilter.Text = "Bỏ lọc";
            this.btnCancelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // btnNotYetPayed
            // 
            this.btnNotYetPayed.BackColor = System.Drawing.Color.LightGray;
            this.btnNotYetPayed.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetPayed.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNotYetPayed.FlatAppearance.BorderSize = 0;
            this.btnNotYetPayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotYetPayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetPayed.Location = new System.Drawing.Point(0, 120);
            this.btnNotYetPayed.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNotYetPayed.Name = "btnNotYetPayed";
            this.btnNotYetPayed.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnNotYetPayed.Size = new System.Drawing.Size(327, 40);
            this.btnNotYetPayed.TabIndex = 23;
            this.btnNotYetPayed.Text = "Chưa thanh toán";
            this.btnNotYetPayed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotYetPayed.UseVisualStyleBackColor = true;
            this.btnNotYetPayed.Click += new System.EventHandler(this.btnNotYetPayed_Click);
            // 
            // btnNotYetDeposited
            // 
            this.btnNotYetDeposited.BackColor = System.Drawing.Color.LightGray;
            this.btnNotYetDeposited.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetDeposited.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNotYetDeposited.FlatAppearance.BorderSize = 0;
            this.btnNotYetDeposited.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotYetDeposited.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetDeposited.Location = new System.Drawing.Point(0, 80);
            this.btnNotYetDeposited.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNotYetDeposited.Name = "btnNotYetDeposited";
            this.btnNotYetDeposited.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnNotYetDeposited.Size = new System.Drawing.Size(327, 40);
            this.btnNotYetDeposited.TabIndex = 22;
            this.btnNotYetDeposited.Text = "Chưa đặt cọc";
            this.btnNotYetDeposited.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotYetDeposited.UseVisualStyleBackColor = true;
            this.btnNotYetDeposited.Click += new System.EventHandler(this.btnNotYetDeposited_Click);
            // 
            // btnNotYetAccepted
            // 
            this.btnNotYetAccepted.BackColor = System.Drawing.Color.LightGray;
            this.btnNotYetAccepted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotYetAccepted.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNotYetAccepted.FlatAppearance.BorderSize = 0;
            this.btnNotYetAccepted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotYetAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotYetAccepted.Location = new System.Drawing.Point(0, 40);
            this.btnNotYetAccepted.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnNotYetAccepted.Name = "btnNotYetAccepted";
            this.btnNotYetAccepted.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnNotYetAccepted.Size = new System.Drawing.Size(327, 40);
            this.btnNotYetAccepted.TabIndex = 21;
            this.btnNotYetAccepted.Text = "Chưa nhận sân";
            this.btnNotYetAccepted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotYetAccepted.UseVisualStyleBackColor = true;
            this.btnNotYetAccepted.Click += new System.EventHandler(this.btnNotYetAccepted_Click);
            // 
            // btnOverTime
            // 
            this.btnOverTime.BackColor = System.Drawing.Color.LightGray;
            this.btnOverTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOverTime.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnOverTime.FlatAppearance.BorderSize = 0;
            this.btnOverTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverTime.Location = new System.Drawing.Point(0, 0);
            this.btnOverTime.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnOverTime.Name = "btnOverTime";
            this.btnOverTime.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnOverTime.Size = new System.Drawing.Size(327, 40);
            this.btnOverTime.TabIndex = 20;
            this.btnOverTime.Text = "Quá giờ nhận sân";
            this.btnOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOverTime.UseVisualStyleBackColor = true;
            this.btnOverTime.Click += new System.EventHandler(this.btnOverTime_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightGray;
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(0, 206);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnFilter.Size = new System.Drawing.Size(327, 40);
            this.btnFilter.TabIndex = 20;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pnlFunction.Location = new System.Drawing.Point(0, 40);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(327, 166);
            this.pnlFunction.TabIndex = 23;
            // 
            // btnRevReceipt
            // 
            this.btnRevReceipt.BackColor = System.Drawing.Color.LightGray;
            this.btnRevReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRevReceipt.Enabled = false;
            this.btnRevReceipt.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRevReceipt.FlatAppearance.BorderSize = 0;
            this.btnRevReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevReceipt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRevReceipt.Location = new System.Drawing.Point(0, 120);
            this.btnRevReceipt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRevReceipt.Name = "btnRevReceipt";
            this.btnRevReceipt.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnRevReceipt.Size = new System.Drawing.Size(327, 40);
            this.btnRevReceipt.TabIndex = 20;
            this.btnRevReceipt.Text = "Lập hóa đơn";
            this.btnRevReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevReceipt.UseVisualStyleBackColor = true;
            this.btnRevReceipt.Click += new System.EventHandler(this.btnRevReceipt_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(0, 80);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(327, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.LightGray;
            this.btnDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Location = new System.Drawing.Point(0, 40);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnDetail.Size = new System.Drawing.Size(327, 40);
            this.btnDetail.TabIndex = 18;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(327, 40);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.LightGray;
            this.btnFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFunction.FlatAppearance.BorderSize = 0;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunction.Location = new System.Drawing.Point(0, 0);
            this.btnFunction.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnFunction.Size = new System.Drawing.Size(327, 40);
            this.btnFunction.TabIndex = 18;
            this.btnFunction.Text = "Chức năng";
            this.btnFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(327, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1597, 1055);
            this.panel3.TabIndex = 17;
            // 
            // clnRevNo
            // 
            this.clnRevNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnRevNo.HeaderText = "Số phiếu";
            this.clnRevNo.MinimumWidth = 6;
            this.clnRevNo.Name = "clnRevNo";
            this.clnRevNo.ReadOnly = true;
            this.clnRevNo.Width = 140;
            // 
            // clnUserName
            // 
            this.clnUserName.HeaderText = "Tên nhân viên";
            this.clnUserName.MinimumWidth = 100;
            this.clnUserName.Name = "clnUserName";
            this.clnUserName.ReadOnly = true;
            this.clnUserName.Width = 180;
            // 
            // clnPhoneNumber
            // 
            this.clnPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnPhoneNumber.HeaderText = "Số điện thoại";
            this.clnPhoneNumber.MinimumWidth = 6;
            this.clnPhoneNumber.Name = "clnPhoneNumber";
            this.clnPhoneNumber.ReadOnly = true;
            this.clnPhoneNumber.Width = 120;
            // 
            // clnCustomer
            // 
            this.clnCustomer.HeaderText = "Tên Khách hàng";
            this.clnCustomer.MinimumWidth = 100;
            this.clnCustomer.Name = "clnCustomer";
            this.clnCustomer.ReadOnly = true;
            this.clnCustomer.Width = 180;
            // 
            // clnDeposite
            // 
            this.clnDeposite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnDeposite.HeaderText = "Đặt cọc";
            this.clnDeposite.MinimumWidth = 6;
            this.clnDeposite.Name = "clnDeposite";
            this.clnDeposite.ReadOnly = true;
            this.clnDeposite.Width = 120;
            // 
            // clnCreateDate
            // 
            this.clnCreateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Format = "dd/MM/yy";
            this.clnCreateDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.clnCreateDate.HeaderText = "Ngày đặt";
            this.clnCreateDate.MinimumWidth = 6;
            this.clnCreateDate.Name = "clnCreateDate";
            this.clnCreateDate.ReadOnly = true;
            this.clnCreateDate.Width = 110;
            // 
            // clnBookingDate
            // 
            this.clnBookingDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Format = "dd/MM/yy";
            this.clnBookingDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnBookingDate.HeaderText = "Ngày nhận";
            this.clnBookingDate.MinimumWidth = 6;
            this.clnBookingDate.Name = "clnBookingDate";
            this.clnBookingDate.ReadOnly = true;
            this.clnBookingDate.Width = 110;
            // 
            // clnStartime
            // 
            this.clnStartime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Format = "HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.clnStartime.DefaultCellStyle = dataGridViewCellStyle3;
            this.clnStartime.HeaderText = "Bắt đầu";
            this.clnStartime.MinimumWidth = 6;
            this.clnStartime.Name = "clnStartime";
            this.clnStartime.ReadOnly = true;
            this.clnStartime.Width = 85;
            // 
            // clnEndTime
            // 
            this.clnEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Format = "HH:mm";
            dataGridViewCellStyle4.NullValue = null;
            this.clnEndTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.clnEndTime.HeaderText = "Kết thúc";
            this.clnEndTime.MinimumWidth = 6;
            this.clnEndTime.Name = "clnEndTime";
            this.clnEndTime.ReadOnly = true;
            this.clnEndTime.Width = 85;
            // 
            // clnStatus
            // 
            this.clnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clnStatus.HeaderText = "Tình trạng";
            this.clnStatus.MinimumWidth = 6;
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 150;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ReservationForm";
            this.Text = "Phiếu Đặt Sân";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }




        #endregion
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.TextBox txtSearchByPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbThisMonth;
        private System.Windows.Forms.Timer tmrCheck;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGot;
        private System.Windows.Forms.Button btnAcceptDeposition;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Button btnRevReceipt;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnCancelFilter;
        private System.Windows.Forms.Button btnNotYetPayed;
        private System.Windows.Forms.Button btnNotYetDeposited;
        private System.Windows.Forms.Button btnNotYetAccepted;
        private System.Windows.Forms.Button btnOverTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStartime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}