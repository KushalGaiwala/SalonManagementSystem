
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
            this.components = new System.ComponentModel.Container();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvCustomerDetails = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustNewContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dB_SalonManagementSystemDataSet = new SalonManagementSystem.DB_SalonManagementSystemDataSet();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter = new SalonManagementSystem.DB_SalonManagementSystemDataSetTableAdapters.tblCustomerTableAdapter();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SalonManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustLName
            // 
            this.txtCustLName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustLName.Location = new System.Drawing.Point(209, 167);
            this.txtCustLName.Name = "txtCustLName";
            this.txtCustLName.Size = new System.Drawing.Size(100, 22);
            this.txtCustLName.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "LastName";
            // 
            // txtCustArea
            // 
            this.txtCustArea.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustArea.Location = new System.Drawing.Point(209, 326);
            this.txtCustArea.Name = "txtCustArea";
            this.txtCustArea.Size = new System.Drawing.Size(100, 22);
            this.txtCustArea.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Area";
            // 
            // txtCustContactNo
            // 
            this.txtCustContactNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustContactNo.Location = new System.Drawing.Point(209, 87);
            this.txtCustContactNo.MaxLength = 10;
            this.txtCustContactNo.Name = "txtCustContactNo";
            this.txtCustContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtCustContactNo.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 38;
            this.label7.Text = "ContactNo";
            // 
            // lblAlertExists
            // 
            this.lblAlertExists.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAlertExists.AutoSize = true;
            this.lblAlertExists.Location = new System.Drawing.Point(182, 114);
            this.lblAlertExists.Name = "lblAlertExists";
            this.lblAlertExists.Size = new System.Drawing.Size(160, 17);
            this.lblAlertExists.TabIndex = 37;
            this.lblAlertExists.Text = "Customer Already Exists";
            this.lblAlertExists.Visible = false;
            // 
            // gbGender
            // 
            this.gbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Location = new System.Drawing.Point(104, 208);
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
            this.txtCustFName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustFName.Location = new System.Drawing.Point(209, 137);
            this.txtCustFName.Name = "txtCustFName";
            this.txtCustFName.Size = new System.Drawing.Size(100, 22);
            this.txtCustFName.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "FirstName";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "INSERT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(209, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 40);
            this.button2.TabIndex = 45;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerDetails
            // 
            this.dgvCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerDetails.AutoGenerateColumns = false;
            this.dgvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dgvCustomerDetails.DataSource = this.tblCustomerBindingSource;
            this.dgvCustomerDetails.Location = new System.Drawing.Point(413, 54);
            this.dgvCustomerDetails.Name = "dgvCustomerDetails";
            this.dgvCustomerDetails.RowHeadersWidth = 51;
            this.dgvCustomerDetails.RowTemplate.Height = 24;
            this.dgvCustomerDetails.Size = new System.Drawing.Size(725, 508);
            this.dgvCustomerDetails.TabIndex = 46;
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
            this.txtCustNewContactNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustNewContactNo.Location = new System.Drawing.Point(209, 354);
            this.txtCustNewContactNo.MaxLength = 10;
            this.txtCustNewContactNo.Name = "txtCustNewContactNo";
            this.txtCustNewContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtCustNewContactNo.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "New ContactNo";
            // 
            // dB_SalonManagementSystemDataSet
            // 
            this.dB_SalonManagementSystemDataSet.DataSetName = "DB_SalonManagementSystemDataSet";
            this.dB_SalonManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.dB_SalonManagementSystemDataSet;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "area";
            this.areaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            this.areaDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contactno";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "contactno";
            this.contactnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            this.contactnoDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 574);
            this.Controls.Add(this.txtCustNewContactNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCustomerDetails);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.Enter += new System.EventHandler(this.Customer_Enter);
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_SalonManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCustomerDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustNewContactNo;
        private System.Windows.Forms.Label label3;
        private DB_SalonManagementSystemDataSet dB_SalonManagementSystemDataSet;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private DB_SalonManagementSystemDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
    }
}