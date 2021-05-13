
namespace SalonManagementSystem
{
    partial class Insert_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_Employee));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpContactNo = new System.Windows.Forms.TextBox();
            this.txtEmpFName = new System.Windows.Forms.TextBox();
            this.lblEmpFName = new System.Windows.Forms.Label();
            this.txtEmpLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEmpDOB = new System.Windows.Forms.DateTimePicker();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtHouseNo = new System.Windows.Forms.TextBox();
            this.lblHouseNo = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.lblPincode = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpExp = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.txtEmpSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpProof = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpDOJ = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAlertExists = new System.Windows.Forms.Label();
            this.btnEmpStatus = new System.Windows.Forms.Button();
            this.txtEmpProofId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbWorkingStatus = new System.Windows.Forms.GroupBox();
            this.rbWorkingNo = new System.Windows.Forms.RadioButton();
            this.rbWorkingYes = new System.Windows.Forms.RadioButton();
            this.dgvEmployeeDetail = new System.Windows.Forms.DataGridView();
            this.gbGender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbWorkingStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(562, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // txtEmpContactNo
            // 
            this.txtEmpContactNo.Location = new System.Drawing.Point(132, 49);
            this.txtEmpContactNo.Name = "txtEmpContactNo";
            this.txtEmpContactNo.Size = new System.Drawing.Size(180, 22);
            this.txtEmpContactNo.TabIndex = 2;
            this.txtEmpContactNo.Leave += new System.EventHandler(this.txtEmpContactNo_Leave);
            // 
            // txtEmpFName
            // 
            this.txtEmpFName.Location = new System.Drawing.Point(132, 87);
            this.txtEmpFName.Name = "txtEmpFName";
            this.txtEmpFName.Size = new System.Drawing.Size(180, 22);
            this.txtEmpFName.TabIndex = 4;
            // 
            // lblEmpFName
            // 
            this.lblEmpFName.AutoSize = true;
            this.lblEmpFName.Location = new System.Drawing.Point(12, 87);
            this.lblEmpFName.Name = "lblEmpFName";
            this.lblEmpFName.Size = new System.Drawing.Size(76, 17);
            this.lblEmpFName.TabIndex = 3;
            this.lblEmpFName.Text = "First Name";
            // 
            // txtEmpLName
            // 
            this.txtEmpLName.Location = new System.Drawing.Point(132, 125);
            this.txtEmpLName.Name = "txtEmpLName";
            this.txtEmpLName.Size = new System.Drawing.Size(180, 22);
            this.txtEmpLName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date Of Birth";
            // 
            // dtpEmpDOB
            // 
            this.dtpEmpDOB.CustomFormat = " dd / MM / yyyy";
            this.dtpEmpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmpDOB.Location = new System.Drawing.Point(132, 164);
            this.dtpEmpDOB.Name = "dtpEmpDOB";
            this.dtpEmpDOB.Size = new System.Drawing.Size(144, 22);
            this.dtpEmpDOB.TabIndex = 8;
            this.dtpEmpDOB.Value = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(15, 197);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(242, 69);
            this.gbGender.TabIndex = 9;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(128, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 5;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(11, 30);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 4;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHouseNo.Location = new System.Drawing.Point(117, 32);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(180, 22);
            this.txtHouseNo.TabIndex = 11;
            // 
            // lblHouseNo
            // 
            this.lblHouseNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHouseNo.AutoSize = true;
            this.lblHouseNo.Location = new System.Drawing.Point(8, 37);
            this.lblHouseNo.Name = "lblHouseNo";
            this.lblHouseNo.Size = new System.Drawing.Size(71, 17);
            this.lblHouseNo.TabIndex = 10;
            this.lblHouseNo.Text = "House No";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStreet.Location = new System.Drawing.Point(117, 75);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(180, 22);
            this.txtStreet.TabIndex = 13;
            // 
            // lblStreet
            // 
            this.lblStreet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(8, 75);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Street";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPincode);
            this.groupBox1.Controls.Add(this.lblPincode);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Controls.Add(this.lblCity);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Controls.Add(this.lblHouseNo);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.txtHouseNo);
            this.groupBox1.Controls.Add(this.lblStreet);
            this.groupBox1.Location = new System.Drawing.Point(12, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 233);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            // 
            // txtPincode
            // 
            this.txtPincode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPincode.Location = new System.Drawing.Point(117, 191);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(180, 22);
            this.txtPincode.TabIndex = 19;
            // 
            // lblPincode
            // 
            this.lblPincode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPincode.AutoSize = true;
            this.lblPincode.Location = new System.Drawing.Point(8, 191);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(59, 17);
            this.lblPincode.TabIndex = 18;
            this.lblPincode.Text = "Pincode";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCity.Location = new System.Drawing.Point(117, 153);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(180, 22);
            this.txtCity.TabIndex = 17;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(8, 153);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 17);
            this.lblCity.TabIndex = 16;
            this.lblCity.Text = "City";
            // 
            // txtArea
            // 
            this.txtArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtArea.Location = new System.Drawing.Point(117, 115);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(180, 22);
            this.txtArea.TabIndex = 15;
            // 
            // lblArea
            // 
            this.lblArea.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(8, 115);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Date Of Join";
            // 
            // txtEmpExp
            // 
            this.txtEmpExp.Location = new System.Drawing.Point(129, 545);
            this.txtEmpExp.Name = "txtEmpExp";
            this.txtEmpExp.Size = new System.Drawing.Size(165, 22);
            this.txtEmpExp.TabIndex = 21;
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(9, 545);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(78, 17);
            this.lblExp.TabIndex = 20;
            this.lblExp.Text = "Experience";
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Location = new System.Drawing.Point(129, 583);
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.Size = new System.Drawing.Size(165, 22);
            this.txtEmpSalary.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Salary";
            // 
            // txtEmpProof
            // 
            this.txtEmpProof.Location = new System.Drawing.Point(129, 623);
            this.txtEmpProof.Name = "txtEmpProof";
            this.txtEmpProof.Size = new System.Drawing.Size(165, 22);
            this.txtEmpProof.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Proof";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(16, 768);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(107, 51);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Insert";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpDOJ
            // 
            this.dtpDOJ.CustomFormat = " dd / MM / yyyy";
            this.dtpDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOJ.Location = new System.Drawing.Point(129, 508);
            this.dtpDOJ.Name = "dtpDOJ";
            this.dtpDOJ.Size = new System.Drawing.Size(147, 22);
            this.dtpDOJ.TabIndex = 20;
            this.dtpDOJ.Value = new System.DateTime(2021, 4, 25, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(129, 768);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 51);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAlertExists
            // 
            this.lblAlertExists.AutoSize = true;
            this.lblAlertExists.Location = new System.Drawing.Point(166, 29);
            this.lblAlertExists.Name = "lblAlertExists";
            this.lblAlertExists.Size = new System.Drawing.Size(110, 17);
            this.lblAlertExists.TabIndex = 28;
            this.lblAlertExists.Text = "Employee Exists";
            this.lblAlertExists.Visible = false;
            // 
            // btnEmpStatus
            // 
            this.btnEmpStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpStatus.Location = new System.Drawing.Point(242, 768);
            this.btnEmpStatus.Name = "btnEmpStatus";
            this.btnEmpStatus.Size = new System.Drawing.Size(123, 51);
            this.btnEmpStatus.TabIndex = 29;
            this.btnEmpStatus.Text = "Change Status";
            this.btnEmpStatus.UseVisualStyleBackColor = true;
            this.btnEmpStatus.Visible = false;
            this.btnEmpStatus.Click += new System.EventHandler(this.btnEmpStatus_Click);
            // 
            // txtEmpProofId
            // 
            this.txtEmpProofId.Location = new System.Drawing.Point(129, 656);
            this.txtEmpProofId.Name = "txtEmpProofId";
            this.txtEmpProofId.Size = new System.Drawing.Size(165, 22);
            this.txtEmpProofId.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Proof ID";
            // 
            // gbWorkingStatus
            // 
            this.gbWorkingStatus.Controls.Add(this.rbWorkingNo);
            this.gbWorkingStatus.Controls.Add(this.rbWorkingYes);
            this.gbWorkingStatus.Enabled = false;
            this.gbWorkingStatus.Location = new System.Drawing.Point(15, 684);
            this.gbWorkingStatus.Name = "gbWorkingStatus";
            this.gbWorkingStatus.Size = new System.Drawing.Size(261, 69);
            this.gbWorkingStatus.TabIndex = 10;
            this.gbWorkingStatus.TabStop = false;
            this.gbWorkingStatus.Text = "Working Status";
            this.gbWorkingStatus.Visible = false;
            // 
            // rbWorkingNo
            // 
            this.rbWorkingNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbWorkingNo.AutoSize = true;
            this.rbWorkingNo.Location = new System.Drawing.Point(127, 29);
            this.rbWorkingNo.Name = "rbWorkingNo";
            this.rbWorkingNo.Size = new System.Drawing.Size(107, 21);
            this.rbWorkingNo.TabIndex = 5;
            this.rbWorkingNo.Text = "Not Working";
            this.rbWorkingNo.UseVisualStyleBackColor = true;
            // 
            // rbWorkingYes
            // 
            this.rbWorkingYes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbWorkingYes.AutoSize = true;
            this.rbWorkingYes.Checked = true;
            this.rbWorkingYes.Location = new System.Drawing.Point(21, 29);
            this.rbWorkingYes.Name = "rbWorkingYes";
            this.rbWorkingYes.Size = new System.Drawing.Size(107, 21);
            this.rbWorkingYes.TabIndex = 4;
            this.rbWorkingYes.TabStop = true;
            this.rbWorkingYes.Text = "Still Working";
            this.rbWorkingYes.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeeDetail
            // 
            this.dgvEmployeeDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployeeDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeDetail.Location = new System.Drawing.Point(388, 49);
            this.dgvEmployeeDetail.Name = "dgvEmployeeDetail";
            this.dgvEmployeeDetail.RowHeadersWidth = 51;
            this.dgvEmployeeDetail.RowTemplate.Height = 24;
            this.dgvEmployeeDetail.Size = new System.Drawing.Size(1003, 770);
            this.dgvEmployeeDetail.TabIndex = 32;
            // 
            // Insert_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1403, 831);
            this.Controls.Add(this.dgvEmployeeDetail);
            this.Controls.Add(this.gbWorkingStatus);
            this.Controls.Add(this.txtEmpProofId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEmpStatus);
            this.Controls.Add(this.lblAlertExists);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDOJ);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtEmpProof);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmpExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.dtpEmpDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpFName);
            this.Controls.Add(this.lblEmpFName);
            this.Controls.Add(this.txtEmpContactNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insert_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Details";
            this.Load += new System.EventHandler(this.Insert_Employee_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbWorkingStatus.ResumeLayout(false);
            this.gbWorkingStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpContactNo;
        private System.Windows.Forms.TextBox txtEmpFName;
        private System.Windows.Forms.Label lblEmpFName;
        private System.Windows.Forms.TextBox txtEmpLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEmpDOB;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtHouseNo;
        private System.Windows.Forms.Label lblHouseNo;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPincode;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpExp;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.TextBox txtEmpSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpProof;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpDOJ;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblAlertExists;
        private System.Windows.Forms.Button btnEmpStatus;
        private System.Windows.Forms.TextBox txtEmpProofId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbWorkingStatus;
        private System.Windows.Forms.RadioButton rbWorkingNo;
        private System.Windows.Forms.RadioButton rbWorkingYes;
        private System.Windows.Forms.DataGridView dgvEmployeeDetail;
    }
}