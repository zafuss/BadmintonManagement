namespace BadmintonManagement.Forms.Court
{
    partial class AddCourtForm
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

        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.cboCourtID = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCourtName = new System.Windows.Forms.Label();
            this.lblBranchID = new System.Windows.Forms.Label();
            this.lblCourtID = new System.Windows.Forms.Label();
            this.cboBranchID = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtCourtName = new System.Windows.Forms.TextBox();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.cboCourtID);
            this.grpInformation.Controls.Add(this.btnChange);
            this.grpInformation.Controls.Add(this.btnDelete);
            this.grpInformation.Controls.Add(this.btnAdd);
            this.grpInformation.Controls.Add(this.lblStatus);
            this.grpInformation.Controls.Add(this.lblCourtName);
            this.grpInformation.Controls.Add(this.lblBranchID);
            this.grpInformation.Controls.Add(this.lblCourtID);
            this.grpInformation.Controls.Add(this.cboBranchID);
            this.grpInformation.Controls.Add(this.cboStatus);
            this.grpInformation.Controls.Add(this.txtCourtName);
            this.grpInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformation.Location = new System.Drawing.Point(0, 0);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(398, 337);
            this.grpInformation.TabIndex = 0;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Thông Tin Sân";
            // 
            // cboCourtID
            // 
            this.cboCourtID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCourtID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCourtID.FormattingEnabled = true;
            this.cboCourtID.Location = new System.Drawing.Point(186, 44);
            this.cboCourtID.Name = "cboCourtID";
            this.cboCourtID.Size = new System.Drawing.Size(197, 36);
            this.cboCourtID.TabIndex = 15;
            this.cboCourtID.SelectedIndexChanged += new System.EventHandler(this.cboCourtID_SelectedIndexChanged);
            this.cboCourtID.TextChanged += new System.EventHandler(this.cboCourtID_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(300, 279);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(87, 37);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Sửa";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 279);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 37);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 37);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(101, 28);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "Trạng Thái";
            // 
            // lblCourtName
            // 
            this.lblCourtName.AutoSize = true;
            this.lblCourtName.Location = new System.Drawing.Point(21, 112);
            this.lblCourtName.Name = "lblCourtName";
            this.lblCourtName.Size = new System.Drawing.Size(78, 28);
            this.lblCourtName.TabIndex = 10;
            this.lblCourtName.Text = "Tên Sân";
            // 
            // lblBranchID
            // 
            this.lblBranchID.AutoSize = true;
            this.lblBranchID.Location = new System.Drawing.Point(22, 225);
            this.lblBranchID.Name = "lblBranchID";
            this.lblBranchID.Size = new System.Drawing.Size(118, 28);
            this.lblBranchID.TabIndex = 9;
            this.lblBranchID.Text = "Tên Khu Vực";
            // 
            // lblCourtID
            // 
            this.lblCourtID.AutoSize = true;
            this.lblCourtID.Location = new System.Drawing.Point(21, 44);
            this.lblCourtID.Name = "lblCourtID";
            this.lblCourtID.Size = new System.Drawing.Size(77, 28);
            this.lblCourtID.TabIndex = 1;
            this.lblCourtID.Text = "Mã Sân";
            // 
            // cboBranchID
            // 
            this.cboBranchID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBranchID.FormattingEnabled = true;
            this.cboBranchID.Location = new System.Drawing.Point(186, 217);
            this.cboBranchID.Name = "cboBranchID";
            this.cboBranchID.Size = new System.Drawing.Size(200, 36);
            this.cboBranchID.TabIndex = 3;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(186, 158);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(200, 36);
            this.cboStatus.TabIndex = 2;
            // 
            // txtCourtName
            // 
            this.txtCourtName.Location = new System.Drawing.Point(186, 106);
            this.txtCourtName.Name = "txtCourtName";
            this.txtCourtName.Size = new System.Drawing.Size(200, 34);
            this.txtCourtName.TabIndex = 1;
            this.txtCourtName.TextChanged += new System.EventHandler(this.txtCourtName_TextChanged);
            // 
            // AddCourtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 337);
            this.Controls.Add(this.grpInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddCourtForm";
            this.Text = "CourtForm";
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        
        //#region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCourtName;
        private System.Windows.Forms.Label lblBranchID;
        private System.Windows.Forms.ComboBox cboBranchID;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtCourtName;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCourtID;
        private System.Windows.Forms.ComboBox cboCourtID;
    }
}