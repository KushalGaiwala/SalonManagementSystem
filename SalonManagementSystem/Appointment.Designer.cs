
namespace SalonManagementSystem
{
    partial class Appointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Appointment));
            this.dgvAppointmentDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAppointmentId = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchContactNo = new System.Windows.Forms.Label();
            this.txtSearchContactNo = new System.Windows.Forms.TextBox();
            this.txtCustContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPackage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGetDetail = new System.Windows.Forms.Button();
            this.btnSearchGet = new System.Windows.Forms.Button();
            this.dtpSearchDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAppointmentDetail
            // 
            this.dgvAppointmentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentDetail.Location = new System.Drawing.Point(352, 96);
            this.dgvAppointmentDetail.Name = "dgvAppointmentDetail";
            this.dgvAppointmentDetail.RowHeadersWidth = 51;
            this.dgvAppointmentDetail.RowTemplate.Height = 24;
            this.dgvAppointmentDetail.Size = new System.Drawing.Size(882, 507);
            this.dgvAppointmentDetail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appointment ID";
            // 
            // txtAppointmentId
            // 
            this.txtAppointmentId.Location = new System.Drawing.Point(148, 96);
            this.txtAppointmentId.Name = "txtAppointmentId";
            this.txtAppointmentId.Size = new System.Drawing.Size(141, 22);
            this.txtAppointmentId.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(123, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 46);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search By:";
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "All",
            "Customer",
            "Date"});
            this.cbSearch.Location = new System.Drawing.Point(441, 53);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 24);
            this.cbSearch.TabIndex = 6;
            this.cbSearch.Text = "All";
            this.cbSearch.SelectedValueChanged += new System.EventHandler(this.cbSearch_SelectedValueChanged);
            // 
            // lblSearchContactNo
            // 
            this.lblSearchContactNo.AutoSize = true;
            this.lblSearchContactNo.Location = new System.Drawing.Point(637, 60);
            this.lblSearchContactNo.Name = "lblSearchContactNo";
            this.lblSearchContactNo.Size = new System.Drawing.Size(82, 17);
            this.lblSearchContactNo.TabIndex = 7;
            this.lblSearchContactNo.Text = "Contact No:";
            this.lblSearchContactNo.Visible = false;
            // 
            // txtSearchContactNo
            // 
            this.txtSearchContactNo.Location = new System.Drawing.Point(725, 53);
            this.txtSearchContactNo.Name = "txtSearchContactNo";
            this.txtSearchContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtSearchContactNo.TabIndex = 8;
            this.txtSearchContactNo.Text = " ";
            this.txtSearchContactNo.Visible = false;
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Location = new System.Drawing.Point(148, 163);
            this.txtCustContactNo.Name = "txtCustContactNo";
            this.txtCustContactNo.Size = new System.Drawing.Size(141, 22);
            this.txtCustContactNo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer Number";
            // 
            // cbPackage
            // 
            this.cbPackage.FormattingEnabled = true;
            this.cbPackage.Location = new System.Drawing.Point(148, 211);
            this.cbPackage.Name = "cbPackage";
            this.cbPackage.Size = new System.Drawing.Size(141, 24);
            this.cbPackage.TabIndex = 14;
            this.cbPackage.SelectedValueChanged += new System.EventHandler(this.cbPackage_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Package";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CustomFormat = "  dd / MM / yyyy";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(148, 263);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2021, 3, 1, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(164, 22);
            this.dtpAppointmentDate.TabIndex = 19;
            this.dtpAppointmentDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // cbAppointmentTime
            // 
            this.cbAppointmentTime.FormattingEnabled = true;
            this.cbAppointmentTime.Items.AddRange(new object[] {
            "9:00:00",
            "9:30:00",
            "10:00:00",
            "10:30:00",
            "11:00:00",
            "11:30:00",
            "12:00:00",
            "12:30:00",
            "01:00:00",
            "01:30:00",
            "02:00:00",
            "02:30:00",
            "03:00:00",
            "03:30:00",
            "04:00:00",
            "04:30:00",
            "05:00:00",
            "05:30:00",
            "06:00:00",
            "06:30:00",
            "07:00:00",
            "07:30:00",
            "08:00:00",
            "08:30:00"});
            this.cbAppointmentTime.Location = new System.Drawing.Point(148, 309);
            this.cbAppointmentTime.Name = "cbAppointmentTime";
            this.cbAppointmentTime.Size = new System.Drawing.Size(141, 24);
            this.cbAppointmentTime.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Time";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(148, 366);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(141, 22);
            this.txtTotalAmount.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Total";
            // 
            // txtGetDetail
            // 
            this.txtGetDetail.Location = new System.Drawing.Point(295, 92);
            this.txtGetDetail.Name = "txtGetDetail";
            this.txtGetDetail.Size = new System.Drawing.Size(46, 31);
            this.txtGetDetail.TabIndex = 39;
            this.txtGetDetail.Text = "Get";
            this.txtGetDetail.UseVisualStyleBackColor = true;
            this.txtGetDetail.Click += new System.EventHandler(this.txtGetDetail_Click);
            // 
            // btnSearchGet
            // 
            this.btnSearchGet.Location = new System.Drawing.Point(831, 46);
            this.btnSearchGet.Name = "btnSearchGet";
            this.btnSearchGet.Size = new System.Drawing.Size(46, 31);
            this.btnSearchGet.TabIndex = 40;
            this.btnSearchGet.Text = "Get";
            this.btnSearchGet.UseVisualStyleBackColor = true;
            this.btnSearchGet.Visible = false;
            this.btnSearchGet.Click += new System.EventHandler(this.btnSearchGet_Click);
            // 
            // dtpSearchDate
            // 
            this.dtpSearchDate.CustomFormat = "  dd / MM / yyyy";
            this.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSearchDate.Location = new System.Drawing.Point(670, 46);
            this.dtpSearchDate.MinDate = new System.DateTime(2021, 4, 22, 0, 0, 0, 0);
            this.dtpSearchDate.Name = "dtpSearchDate";
            this.dtpSearchDate.Size = new System.Drawing.Size(141, 22);
            this.dtpSearchDate.TabIndex = 42;
            this.dtpSearchDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            this.dtpSearchDate.Visible = false;
            // 
            // lblSearchDate
            // 
            this.lblSearchDate.AutoSize = true;
            this.lblSearchDate.Location = new System.Drawing.Point(617, 53);
            this.lblSearchDate.Name = "lblSearchDate";
            this.lblSearchDate.Size = new System.Drawing.Size(38, 17);
            this.lblSearchDate.TabIndex = 41;
            this.lblSearchDate.Text = "Date";
            this.lblSearchDate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Appointment Details";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 46);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(242, 526);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(99, 46);
            this.btnDone.TabIndex = 45;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(148, 440);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(141, 22);
            this.txtStatus.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Status";
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 615);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpSearchDate);
            this.Controls.Add(this.lblSearchDate);
            this.Controls.Add(this.btnSearchGet);
            this.Controls.Add(this.txtGetDetail);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbAppointmentTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPackage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchContactNo);
            this.Controls.Add(this.lblSearchContactNo);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtAppointmentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppointmentDetail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.AppointmentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppointmentDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lblSearchContactNo;
        private System.Windows.Forms.TextBox txtSearchContactNo;
        private System.Windows.Forms.TextBox txtCustContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPackage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cbAppointmentTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtGetDetail;
        private System.Windows.Forms.Button btnSearchGet;
        private System.Windows.Forms.DateTimePicker dtpSearchDate;
        private System.Windows.Forms.Label lblSearchDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
    }
}