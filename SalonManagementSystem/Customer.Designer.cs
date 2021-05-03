
namespace SalonManagementSystem
{
    partial class Customer
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
            this.txtCustLName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustContactNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAlertExists = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtCustFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustNewContactNo = new System.Windows.Forms.TextBox();
            this.lblNewContactNo = new System.Windows.Forms.Label();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustLName
            // 
            this.txtCustLName.Location = new System.Drawing.Point(207, 140);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(100, 22);
            this.txtCustLName.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "LastName";
            // 
            // txtCustArea
            // 
            this.txtCustArea.Location = new System.Drawing.Point(207, 293);
            this.txtCustArea.Name = "txtCustArea";
            this.txtCustArea.Size = new System.Drawing.Size(100, 22);
            this.txtCustArea.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Area";
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Location = new System.Drawing.Point(207, 54);
            this.txtCustContactNo.MaxLength = 10;
            this.txtCustContactNo.Name = "txtCustContactNo";
            this.txtCustContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtCustContactNo.TabIndex = 39;
            this.txtCustContactNo.Leave += new System.EventHandler(this.txtCustContactNo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "ContactNo";
            // 
            // lblAlertExists
            // 
            this.lblAlertExists.AutoSize = true;
            this.lblAlertExists.Location = new System.Drawing.Point(180, 81);
            this.lblAlertExists.Name = "lblAlertExists";
            this.lblAlertExists.Size = new System.Drawing.Size(160, 17);
            this.lblAlertExists.TabIndex = 37;
            this.lblAlertExists.Text = "Customer Already Exists";
            this.lblAlertExists.Visible = false;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(102, 175);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(200, 95);
            this.gbGender.TabIndex = 36;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(108, 40);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(16, 40);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtCustFName
            // 
            this.txtCustFName.Location = new System.Drawing.Point(207, 104);
            this.txtCustFName.Name = "txtCustFName";
            this.txtCustFName.Size = new System.Drawing.Size(100, 22);
            this.txtCustFName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "FirstName";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(98, 386);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 40);
            this.btnInsert.TabIndex = 44;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(207, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 40);
            this.btnUpdate.TabIndex = 45;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Customer Details";
            // 
            // txtCustNewContactNo
            // 
            this.txtCustNewContactNo.Location = new System.Drawing.Point(207, 331);
            this.txtCustNewContactNo.MaxLength = 10;
            this.txtCustNewContactNo.Name = "txtCustNewContactNo";
            this.txtCustNewContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtCustNewContactNo.TabIndex = 49;
            this.txtCustNewContactNo.Visible = false;
            // 
            // lblNewContactNo
            // 
            this.lblNewContactNo.AutoSize = true;
            this.lblNewContactNo.Location = new System.Drawing.Point(96, 337);
            this.lblNewContactNo.Name = "lblNewContactNo";
            this.lblNewContactNo.Size = new System.Drawing.Size(105, 17);
            this.lblNewContactNo.TabIndex = 48;
            this.lblNewContactNo.Text = "New ContactNo";
            this.lblNewContactNo.Visible = false;
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(413, 54);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.RowHeadersWidth = 51;
            this.dgvCustomerDetails.RowTemplate.Height = 24;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(725, 554);
            this.dgvCustomerDetails.TabIndex = 46;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 620);
            this.Controls.Add(this.txtCustNewContactNo);
            this.Controls.Add(this.lblNewContactNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomerDetails);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtCustLName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCustArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustContactNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAlertExists);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.txtCustFName);
            this.Controls.Add(this.label2);
            this.Name = "Customer";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustLName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCustArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustContactNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAlertExists;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtCustFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustNewContactNo;
        private System.Windows.Forms.Label lblNewContactNo;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
    }
}