
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
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustArea = new System.Windows.Forms.TextBox();
            this.txtCustContactNo = new System.Windows.Forms.TextBox();
            this.btnCustInsert = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dptAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dptAppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewPackages = new System.Windows.Forms.Button();
            this.gbGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Appointment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "ContactNo";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(238, 85);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 24);
            this.txtCustName.TabIndex = 8;
            // 
            // txtCustArea
            // 
            this.txtCustArea.Location = new System.Drawing.Point(238, 139);
            this.txtCustArea.Name = "txtCustArea";
            this.txtCustArea.Size = new System.Drawing.Size(100, 24);
            this.txtCustArea.TabIndex = 11;
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Location = new System.Drawing.Point(238, 190);
            this.txtCustContactNo.Name = "txtCustContactNo";
            this.txtCustContactNo.Size = new System.Drawing.Size(100, 24);
            this.txtCustContactNo.TabIndex = 13;
            // 
            // btnCustInsert
            // 
            this.btnCustInsert.Location = new System.Drawing.Point(171, 471);
            this.btnCustInsert.Name = "btnCustInsert";
            this.btnCustInsert.Size = new System.Drawing.Size(94, 30);
            this.btnCustInsert.TabIndex = 15;
            this.btnCustInsert.Text = "Add";
            this.btnCustInsert.UseVisualStyleBackColor = true;
            this.btnCustInsert.Click += new System.EventHandler(this.btnCustInsert_Click);
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
            this.gbGender.Location = new System.Drawing.Point(130, 249);
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
            // dptAppointmentDate
            // 
            this.dptAppointmentDate.CustomFormat = "  dd / MM / yyyy";
            this.dptAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptAppointmentDate.Location = new System.Drawing.Point(238, 363);
            this.dptAppointmentDate.Name = "dptAppointmentDate";
            this.dptAppointmentDate.Size = new System.Drawing.Size(143, 24);
            this.dptAppointmentDate.TabIndex = 18;
            this.dptAppointmentDate.Value = new System.DateTime(2021, 5, 7, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Select Date";
            // 
            // dptAppointmentTime
            // 
            this.dptAppointmentTime.CustomFormat = "hh:mm:ss";
            this.dptAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dptAppointmentTime.Location = new System.Drawing.Point(238, 410);
            this.dptAppointmentTime.Name = "dptAppointmentTime";
            this.dptAppointmentTime.ShowUpDown = true;
            this.dptAppointmentTime.Size = new System.Drawing.Size(83, 24);
            this.dptAppointmentTime.TabIndex = 20;
            this.dptAppointmentTime.Value = new System.DateTime(2021, 4, 2, 14, 23, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select Time";
            // 
            // btnViewPackages
            // 
            this.btnViewPackages.Location = new System.Drawing.Point(536, 214);
            this.btnViewPackages.Name = "btnViewPackages";
            this.btnViewPackages.Size = new System.Drawing.Size(169, 65);
            this.btnViewPackages.TabIndex = 22;
            this.btnViewPackages.Text = "View Packages";
            this.btnViewPackages.UseVisualStyleBackColor = true;
            this.btnViewPackages.Click += new System.EventHandler(this.btnViewPackages_Click);
            // 
            // Insert_AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 549);
            this.Controls.Add(this.btnViewPackages);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dptAppointmentTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dptAppointmentDate);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.btnCustInsert);
            this.Controls.Add(this.txtCustContactNo);
            this.Controls.Add(this.txtCustArea);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Insert_AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert_Customer";
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustArea;
        private System.Windows.Forms.TextBox txtCustContactNo;
        private System.Windows.Forms.Button btnCustInsert;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dptAppointmentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dptAppointmentTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewPackages;
    }
}