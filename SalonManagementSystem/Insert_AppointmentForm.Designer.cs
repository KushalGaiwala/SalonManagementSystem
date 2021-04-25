
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustFName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAppointmentTime = new System.Windows.Forms.DateTimePicker();
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
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName";
            // 
            // txtCustFName
            // 
            this.txtCustFName.Location = new System.Drawing.Point(123, 134);
            this.txtCustFName.Name = "txtCustFName";
            this.txtCustFName.Size = new System.Drawing.Size(100, 24);
            this.txtCustFName.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbMale
            // 
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
            this.gbGender.Location = new System.Drawing.Point(12, 244);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 95);
            this.gbGender.TabIndex = 17;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
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
            this.dtpAppointmentDate.Location = new System.Drawing.Point(120, 358);
            this.dtpAppointmentDate.MinDate = new System.DateTime(2021, 4, 22, 0, 0, 0, 0);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(143, 24);
            this.dtpAppointmentDate.TabIndex = 18;
            this.dtpAppointmentDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Date";
            // 
            // dtpAppointmentTime
            // 
            this.dtpAppointmentTime.CustomFormat = "hh:mm:ss";
            this.dtpAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentTime.Location = new System.Drawing.Point(120, 405);
            this.dtpAppointmentTime.MinDate = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            this.dtpAppointmentTime.Name = "dtpAppointmentTime";
            this.dtpAppointmentTime.ShowUpDown = true;
            this.dtpAppointmentTime.Size = new System.Drawing.Size(83, 24);
            this.dtpAppointmentTime.TabIndex = 20;
            this.dtpAppointmentTime.Value = new System.DateTime(2021, 4, 7, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select Time";
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Enabled = false;
            this.dgvPackages.Location = new System.Drawing.Point(271, 111);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(502, 349);
            this.dgvPackages.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Packages";
            // 
            // cbPackages
            // 
            this.cbPackages.FormattingEnabled = true;
            this.cbPackages.Location = new System.Drawing.Point(404, 79);
            this.cbPackages.Name = "cbPackages";
            this.cbPackages.Size = new System.Drawing.Size(121, 26);
            this.cbPackages.TabIndex = 24;
            this.cbPackages.SelectedValueChanged += new System.EventHandler(this.selectedValueChanged_cbPackages);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 25;
            this.label8.Text = "Total";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Enabled = false;
            this.txtTotalPrice.Location = new System.Drawing.Point(603, 81);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 24);
            this.txtTotalPrice.TabIndex = 26;
            // 
            // lblAlertExists
            // 
            this.lblAlertExists.AutoSize = true;
            this.lblAlertExists.Location = new System.Drawing.Point(95, 84);
            this.lblAlertExists.Name = "lblAlertExists";
            this.lblAlertExists.Size = new System.Drawing.Size(170, 18);
            this.lblAlertExists.TabIndex = 27;
            this.lblAlertExists.Text = "Customer Already Exists";
            this.lblAlertExists.Visible = false;
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Location = new System.Drawing.Point(122, 57);
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
            this.label7.Location = new System.Drawing.Point(11, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "ContactNo";
            // 
            // txtCustArea
            // 
            this.txtCustArea.Location = new System.Drawing.Point(123, 194);
            this.txtCustArea.Name = "txtCustArea";
            this.txtCustArea.Size = new System.Drawing.Size(100, 24);
            this.txtCustArea.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Area";
            // 
            // txtCustLName
            // 
            this.txtCustLName.Location = new System.Drawing.Point(123, 164);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(100, 24);
            this.txtCustLName.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 32;
            this.label9.Text = "LastName";
            // 
            // Insert_AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 549);
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
            this.Controls.Add(this.dtpAppointmentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCustFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Insert_AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Appointment";
            this.Load += new System.EventHandler(this.Insert_AppointmentForm_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpAppointmentTime;
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
    }
}