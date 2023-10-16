using System.Configuration;

namespace BadmintonManagement.Forms.Price
{
    partial class ApplyFactor
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
            this.dtpStarTime = new System.Windows.Forms.DateTimePicker();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.chbMonday = new System.Windows.Forms.CheckBox();
            this.pnlWeekDay = new System.Windows.Forms.Panel();
            this.chbSunday = new System.Windows.Forms.CheckBox();
            this.chbSaturday = new System.Windows.Forms.CheckBox();
            this.chbFriday = new System.Windows.Forms.CheckBox();
            this.chbThursday = new System.Windows.Forms.CheckBox();
            this.chbWednesday = new System.Windows.Forms.CheckBox();
            this.chbTuesday = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTime = new System.Windows.Forms.DataGridView();
            this.clnNumericOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStarTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlWeekDay.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStarTime
            // 
            this.dtpStarTime.CustomFormat = "HH:mm";
            this.dtpStarTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStarTime.Location = new System.Drawing.Point(210, 128);
            this.dtpStarTime.Name = "dtpStarTime";
            this.dtpStarTime.Size = new System.Drawing.Size(86, 26);
            this.dtpStarTime.TabIndex = 0;
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "HH:mm";
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(210, 170);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(86, 26);
            this.dtpEndTime.TabIndex = 1;
            // 
            // chbMonday
            // 
            this.chbMonday.AutoSize = true;
            this.chbMonday.Location = new System.Drawing.Point(36, 39);
            this.chbMonday.Name = "chbMonday";
            this.chbMonday.Size = new System.Drawing.Size(80, 24);
            this.chbMonday.TabIndex = 2;
            this.chbMonday.Text = "Thứ hai";
            this.chbMonday.UseVisualStyleBackColor = true;
            this.chbMonday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // pnlWeekDay
            // 
            this.pnlWeekDay.Controls.Add(this.chbSunday);
            this.pnlWeekDay.Controls.Add(this.chbSaturday);
            this.pnlWeekDay.Controls.Add(this.chbFriday);
            this.pnlWeekDay.Controls.Add(this.chbThursday);
            this.pnlWeekDay.Controls.Add(this.chbWednesday);
            this.pnlWeekDay.Controls.Add(this.chbTuesday);
            this.pnlWeekDay.Controls.Add(this.chbMonday);
            this.pnlWeekDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWeekDay.Location = new System.Drawing.Point(0, 0);
            this.pnlWeekDay.Name = "pnlWeekDay";
            this.pnlWeekDay.Size = new System.Drawing.Size(182, 692);
            this.pnlWeekDay.TabIndex = 3;
            // 
            // chbSunday
            // 
            this.chbSunday.AutoSize = true;
            this.chbSunday.Location = new System.Drawing.Point(36, 312);
            this.chbSunday.Name = "chbSunday";
            this.chbSunday.Size = new System.Drawing.Size(95, 24);
            this.chbSunday.TabIndex = 8;
            this.chbSunday.Text = "Chủ Nhật";
            this.chbSunday.UseVisualStyleBackColor = true;
            this.chbSunday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbSaturday
            // 
            this.chbSaturday.AutoSize = true;
            this.chbSaturday.Location = new System.Drawing.Point(36, 264);
            this.chbSaturday.Name = "chbSaturday";
            this.chbSaturday.Size = new System.Drawing.Size(84, 24);
            this.chbSaturday.TabIndex = 7;
            this.chbSaturday.Text = "Thứ bảy";
            this.chbSaturday.UseVisualStyleBackColor = true;
            this.chbSaturday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbFriday
            // 
            this.chbFriday.AutoSize = true;
            this.chbFriday.Location = new System.Drawing.Point(36, 218);
            this.chbFriday.Name = "chbFriday";
            this.chbFriday.Size = new System.Drawing.Size(85, 24);
            this.chbFriday.TabIndex = 6;
            this.chbFriday.Text = "Thứ sáu";
            this.chbFriday.UseVisualStyleBackColor = true;
            this.chbFriday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbThursday
            // 
            this.chbThursday.AutoSize = true;
            this.chbThursday.Location = new System.Drawing.Point(36, 174);
            this.chbThursday.Name = "chbThursday";
            this.chbThursday.Size = new System.Drawing.Size(90, 24);
            this.chbThursday.TabIndex = 5;
            this.chbThursday.Text = "Thứ năm";
            this.chbThursday.UseVisualStyleBackColor = true;
            this.chbThursday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbWednesday
            // 
            this.chbWednesday.AutoSize = true;
            this.chbWednesday.Location = new System.Drawing.Point(36, 128);
            this.chbWednesday.Name = "chbWednesday";
            this.chbWednesday.Size = new System.Drawing.Size(73, 24);
            this.chbWednesday.TabIndex = 4;
            this.chbWednesday.Text = "Thứ tư";
            this.chbWednesday.UseVisualStyleBackColor = true;
            this.chbWednesday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // chbTuesday
            // 
            this.chbTuesday.AutoSize = true;
            this.chbTuesday.Location = new System.Drawing.Point(36, 85);
            this.chbTuesday.Name = "chbTuesday";
            this.chbTuesday.Size = new System.Drawing.Size(77, 24);
            this.chbTuesday.TabIndex = 3;
            this.chbTuesday.Text = "Thứ ba";
            this.chbTuesday.UseVisualStyleBackColor = true;
            this.chbTuesday.CheckedChanged += new System.EventHandler(this.chbMonday_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTime);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(426, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 692);
            this.panel2.TabIndex = 4;
            // 
            // dgvTime
            // 
            this.dgvTime.AllowUserToAddRows = false;
            this.dgvTime.AllowUserToDeleteRows = false;
            this.dgvTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumericOrder,
            this.clnStarTime,
            this.clnEndTime});
            this.dgvTime.Location = new System.Drawing.Point(82, 104);
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTime.Size = new System.Drawing.Size(560, 440);
            this.dgvTime.TabIndex = 7;
            // 
            // clnNumericOrder
            // 
            this.clnNumericOrder.HeaderText = "Mã áp dụng";
            this.clnNumericOrder.Name = "clnNumericOrder";
            this.clnNumericOrder.ReadOnly = true;
            // 
            // clnStarTime
            // 
            this.clnStarTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnStarTime.HeaderText = "Giờ bắt đầu";
            this.clnStarTime.Name = "clnStarTime";
            this.clnStarTime.ReadOnly = true;
            // 
            // clnEndTime
            // 
            this.clnEndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnEndTime.HeaderText = "Giờ kết thúc";
            this.clnEndTime.Name = "clnEndTime";
            this.clnEndTime.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(210, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thẻm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(210, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 35);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ApplyFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlWeekDay);
            this.Controls.Add(this.dtpEndTime);
            this.Controls.Add(this.dtpStarTime);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ApplyFactor";
            this.Text = "Điều chỉnh khung thời gian áp dụng";
            this.Load += new System.EventHandler(this.ApplyFactor_Load);
            this.pnlWeekDay.ResumeLayout(false);
            this.pnlWeekDay.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpStarTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.CheckBox chbMonday;
        private System.Windows.Forms.Panel pnlWeekDay;
        private System.Windows.Forms.CheckBox chbSunday;
        private System.Windows.Forms.CheckBox chbSaturday;
        private System.Windows.Forms.CheckBox chbFriday;
        private System.Windows.Forms.CheckBox chbThursday;
        private System.Windows.Forms.CheckBox chbWednesday;
        private System.Windows.Forms.CheckBox chbTuesday;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumericOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStarTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEndTime;
        private System.Windows.Forms.Button btnClose;
    }
}