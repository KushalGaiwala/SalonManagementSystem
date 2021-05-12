
namespace SalonManagementSystem
{
    partial class Insert_AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insert_AppointmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustFName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPackages = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblAlertExists = new System.Windows.Forms.Label();
            this.txtCustContactNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustLName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAppointmentTime = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMaxAppointment = new System.Windows.Forms.ComboBox();
            this.lblAppointmentAlert = new System.Windows.Forms.Label();
            this.dgvAppointmentDetail = new System.Windows.Forms.DataGridView();
            this.cbServiceChoice = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // txtCustFName
            // 
            this.txtCustFName.Location = new System.Drawing.Point(150, 134);
            this.txtCustFName.Name = "txtCustFName";
            this.txtCustFName.Size = new System.Drawing.Size(100, 24);
            this.txtCustFName.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(16, 40);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 22);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(39, 244);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 95);
            this.gbGender.TabIndex = 17;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(108, 40);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(78, 22);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.CustomFormat = "  dd / MM / yyyy";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(147, 358);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2021, 4, 22, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(121, 24);
            this.dtpAppointmentDate.TabIndex = 18;
            this.dtpAppointmentDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select Time";
            // 
            // dgvPackages
            // 
            this.dgvPackages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Enabled = false;
            this.dgvPackages.Location = new System.Drawing.Point(308, 84);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.ReadOnly = true;
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(691, 241);
            this.dgvPackages.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Packages";
            // 
            // cbPackages
            // 
            this.cbPackages.Enabled = false;
            this.cbPackages.FormattingEnabled = true;
            this.cbPackages.Location = new System.Drawing.Point(548, 52);
            this.cbPackages.Name = "cbPackages";
            this.cbPackages.Size = new System.Drawing.Size(121, 26);
            this.cbPackages.TabIndex = 24;
            this.cbPackages.SelectedValueChanged += new System.EventHandler(this.selectedValueChanged_cbPackages);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(899, 54);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 24);
            this.txtTotalPrice.TabIndex = 26;
            // 
            // lblAlertExists
            // 
            this.lblAlertExists.AutoSize = true;
            this.lblAlertExists.Location = new System.Drawing.Point(123, 81);
            this.lblAlertExists.Name = "lblAlertExists";
            this.lblAlertExists.Size = new System.Drawing.Size(170, 18);
            this.lblAlertExists.TabIndex = 27;
            this.lblAlertExists.Text = "Customer Already Exists";
            this.lblAlertExists.Visible = false;
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Location = new System.Drawing.Point(150, 54);
            this.txtCustContactNo.MaxLength = 10;
            this.txtCustContactNo.Name = "txtCustContactNo";
            this.txtCustContactNo.Size = new System.Drawing.Size(100, 24);
            this.txtCustContactNo.TabIndex = 29;
            this.txtCustContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustContactNo_KeyPress);
            this.txtCustContactNo.Leave += new System.EventHandler(this.txtCustContactNo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "ContactNo";
            // 
            // txtCustArea
            // 
            this.txtCustArea.Location = new System.Drawing.Point(150, 194);
            this.txtCustArea.Name = "txtCustArea";
            this.txtCustArea.Size = new System.Drawing.Size(100, 24);
            this.txtCustArea.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Area";
            // 
            // txtCustLName
            // 
            this.txtCustLName.Location = new System.Drawing.Point(150, 164);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(100, 24);
            this.txtCustLName.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "LastName";
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
            this.cbAppointmentTime.Location = new System.Drawing.Point(147, 402);
            this.cbAppointmentTime.Name = "cbAppointmentTime";
            this.cbAppointmentTime.Size = new System.Drawing.Size(121, 26);
            this.cbAppointmentTime.TabIndex = 34;
            this.cbAppointmentTime.SelectedValueChanged += new System.EventHandler(this.cbAppointmentTime_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(825, 618);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 18);
            this.label10.TabIndex = 38;
            this.label10.Text = "Max Appointment";
            // 
            // cbMaxAppointment
            // 
            this.cbMaxAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMaxAppointment.DisplayMember = "5";
            this.cbMaxAppointment.FormattingEnabled = true;
            this.cbMaxAppointment.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbMaxAppointment.Location = new System.Drawing.Point(953, 610);
            this.cbMaxAppointment.Name = "cbMaxAppointment";
            this.cbMaxAppointment.Size = new System.Drawing.Size(46, 26);
            this.cbMaxAppointment.TabIndex = 37;
            // 
            // lblAppointmentAlert
            // 
            this.lblAppointmentAlert.AutoSize = true;
            this.lblAppointmentAlert.BackColor = System.Drawing.Color.Red;
            this.lblAppointmentAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentAlert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAppointmentAlert.Location = new System.Drawing.Point(143, 431);
            this.lblAppointmentAlert.Name = "lblAppointmentAlert";
            this.lblAppointmentAlert.Size = new System.Drawing.Size(142, 20);
            this.lblAppointmentAlert.TabIndex = 39;
            this.lblAppointmentAlert.Text = "Appointment Alert";
            this.lblAppointmentAlert.Visible = false;
            // 
            // dgvAppointmentDetail
            // 
            this.dgvAppointmentDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointmentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentDetail.Enabled = false;
            this.dgvAppointmentDetail.Location = new System.Drawing.Point(308, 331);
            this.dgvAppointmentDetail.Name = "dgvAppointmentDetail";
            this.dgvAppointmentDetail.ReadOnly = true;
            this.dgvAppointmentDetail.RowHeadersWidth = 51;
            this.dgvAppointmentDetail.RowTemplate.Height = 24;
            this.dgvAppointmentDetail.Size = new System.Drawing.Size(691, 273);
            this.dgvAppointmentDetail.TabIndex = 40;
            // 
            // cbServiceChoice
            // 
            this.cbServiceChoice.FormattingEnabled = true;
            this.cbServiceChoice.Items.AddRange(new object[] {
            "Service",
            "Package"});
            this.cbServiceChoice.Location = new System.Drawing.Point(421, 52);
            this.cbServiceChoice.Name = "cbServiceChoice";
            this.cbServiceChoice.Size = new System.Drawing.Size(121, 26);
            this.cbServiceChoice.TabIndex = 41;
            // 
            // cbCategory
            // 
            this.cbCategory.Enabled = false;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "All",
            "Category"});
            this.cbCategory.Location = new System.Drawing.Point(675, 52);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 26);
            this.cbCategory.TabIndex = 42;
            // 
            // Insert_AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 648);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbServiceChoice);
            this.Controls.Add(this.dgvAppointmentDetail);
            this.Controls.Add(this.lblAppointmentAlert);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbMaxAppointment);
            this.Controls.Add(this.cbAppointmentTime);
            this.Controls.Add(this.txtCustLName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustContactNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlertExists);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPackages);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Insert_AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Appointment";
            this.Load += new System.EventHandler(this.Insert_AppointmentForm_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustFName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPackages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblAlertExists;
        private System.Windows.Forms.TextBox txtCustContactNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustLName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAppointmentTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMaxAppointment;
        private System.Windows.Forms.Label lblAppointmentAlert;
        private System.Windows.Forms.DataGridView dgvAppointmentDetail;
        private System.Windows.Forms.ComboBox cbServiceChoice;
        private System.Windows.Forms.ComboBox cbCategory;
    }
}