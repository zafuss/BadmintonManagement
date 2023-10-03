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
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.clnRevNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeposite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBookingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEndDay = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tESTRESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESERVATIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSanCauLongDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rFDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLSanCauLongDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.pnlFunction = new System.Windows.Forms.Panel();
            this.btnDetailRF = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.txtSearchByPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tESTRESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanCauLongDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFDETAILBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanCauLongDataSetBindingSource1)).BeginInit();
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
            this.clnBookingDate,
            this.clnStatus});
            this.dgvReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReservation.Location = new System.Drawing.Point(3, 16);
            this.dgvReservation.MultiSelect = false;
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.Size = new System.Drawing.Size(934, 574);
            this.dgvReservation.TabIndex = 0;
            this.dgvReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellContentClick);
            this.dgvReservation.SelectionChanged += new System.EventHandler(this.dgvReservation_SelectionChanged);
            // 
            // clnRevNo
            // 
            this.clnRevNo.HeaderText = "Số phiếu";
            this.clnRevNo.Name = "clnRevNo";
            this.clnRevNo.ReadOnly = true;
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
            // clnBookingDate
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.clnBookingDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clnBookingDate.HeaderText = "Ngày nhận";
            this.clnBookingDate.Name = "clnBookingDate";
            this.clnBookingDate.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Tình trạng";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // dtpEndDay
            // 
            this.dtpEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDay.Location = new System.Drawing.Point(585, 16);
            this.dtpEndDay.Name = "dtpEndDay";
            this.dtpEndDay.Size = new System.Drawing.Size(200, 26);
            this.dtpEndDay.TabIndex = 4;
            this.dtpEndDay.ValueChanged += new System.EventHandler(this.dtpEndDay_ValueChanged);
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDay.Location = new System.Drawing.Point(318, 16);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDay.TabIndex = 5;
            this.dtpStartDay.ValueChanged += new System.EventHandler(this.dtpStartDay_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReservation);
            this.groupBox1.Location = new System.Drawing.Point(217, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 593);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt sân";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlSearch);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.pnlFunction);
            this.groupBox2.Controls.Add(this.btnFunction);
            this.groupBox2.Location = new System.Drawing.Point(-4, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 614);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.button3);
            this.pnlSearch.Controls.Add(this.button2);
            this.pnlSearch.Controls.Add(this.button1);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(3, 257);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(212, 123);
            this.pnlSearch.TabIndex = 7;
            this.pnlSearch.Visible = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "Chưa đặt cọc";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Chưa nhận sân";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quá giờ nhận sân";
            this.button1.UseVisualStyleBackColor = true;
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
            this.pnlFunction.Controls.Add(this.btnDetailRF);
            this.pnlFunction.Controls.Add(this.btnCancel);
            this.pnlFunction.Controls.Add(this.btnUpdate);
            this.pnlFunction.Controls.Add(this.btnAdd);
            this.pnlFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFunction.Location = new System.Drawing.Point(3, 56);
            this.pnlFunction.Name = "pnlFunction";
            this.pnlFunction.Size = new System.Drawing.Size(212, 161);
            this.pnlFunction.TabIndex = 5;
            this.pnlFunction.Visible = false;
            // 
            // btnDetailRF
            // 
            this.btnDetailRF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetailRF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailRF.Location = new System.Drawing.Point(0, 120);
            this.btnDetailRF.Name = "btnDetailRF";
            this.btnDetailRF.Size = new System.Drawing.Size(212, 40);
            this.btnDetailRF.TabIndex = 3;
            this.btnDetailRF.Text = "Xem chi tiết";
            this.btnDetailRF.UseVisualStyleBackColor = true;
            this.btnDetailRF.Click += new System.EventHandler(this.btnDetailRF_Click);
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
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(0, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(212, 40);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.txtSearchByPhoneNumber.Location = new System.Drawing.Point(892, 16);
            this.txtSearchByPhoneNumber.Name = "txtSearchByPhoneNumber";
            this.txtSearchByPhoneNumber.Size = new System.Drawing.Size(262, 26);
            this.txtSearchByPhoneNumber.TabIndex = 1;
            this.txtSearchByPhoneNumber.Text = "Nhập số điện thoại để tìm kiếm";
            this.txtSearchByPhoneNumber.Click += new System.EventHandler(this.txtSearchByPhoneNumber_Click);
            this.txtSearchByPhoneNumber.TextChanged += new System.EventHandler(this.txtSearchByPhoneNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(802, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tiềm kiếm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(540, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Từ";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 650);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.tESTRESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESERVATIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanCauLongDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rFDETAILBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLSanCauLongDataSetBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       

        

        #endregion
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.BindingSource qLSanCauLongDataSetBindingSource;

        private System.Windows.Forms.BindingSource rESERVATIONBindingSource;

        private System.Windows.Forms.BindingSource rFDETAILBindingSource;
        private System.Windows.Forms.DateTimePicker dtpEndDay;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.BindingSource qLSanCauLongDataSetBindingSource1;

        private System.Windows.Forms.BindingSource tESTRESERVATIONBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Panel pnlFunction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchByPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDetailRF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRevNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDeposite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBookingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}