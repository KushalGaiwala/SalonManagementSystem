
namespace SalonManagementSystem
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Sp_Get_Appointment_ContactWiseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_SalonManagementSystem = new SalonManagementSystem.DS_SalonManagementSystem();
            this.rvReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Sp_Get_Appointment_ContactWiseTableAdapter = new SalonManagementSystem.DS_SalonManagementSystemTableAdapters.Sp_Get_Appointment_ContactWiseTableAdapter();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Get_Appointment_ContactWiseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_SalonManagementSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // Sp_Get_Appointment_ContactWiseBindingSource
            // 
            this.Sp_Get_Appointment_ContactWiseBindingSource.DataMember = "Sp_Get_Appointment_ContactWise";
            this.Sp_Get_Appointment_ContactWiseBindingSource.DataSource = this.DS_SalonManagementSystem;
            // 
            // DS_SalonManagementSystem
            // 
            this.DS_SalonManagementSystem.DataSetName = "DS_SalonManagementSystem";
            this.DS_SalonManagementSystem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvReportView
            // 
            this.rvReportView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Sp_Get_Appointment_ContactWiseBindingSource;
            this.rvReportView.LocalReport.DataSources.Add(reportDataSource2);
            this.rvReportView.LocalReport.ReportEmbeddedResource = "SalonManagementSystem.Report.rdlc";
            this.rvReportView.Location = new System.Drawing.Point(0, 34);
            this.rvReportView.Name = "rvReportView";
            this.rvReportView.ServerReport.BearerToken = null;
            this.rvReportView.Size = new System.Drawing.Size(802, 418);
            this.rvReportView.TabIndex = 0;
            // 
            // Sp_Get_Appointment_ContactWiseTableAdapter
            // 
            this.Sp_Get_Appointment_ContactWiseTableAdapter.ClearBeforeFill = true;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(160, 6);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(100, 22);
            this.txtContactNo.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(266, 5);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Contact No";
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(360, 5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.rvReportView);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sp_Get_Appointment_ContactWiseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_SalonManagementSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReportView;
        private System.Windows.Forms.BindingSource Sp_Get_Appointment_ContactWiseBindingSource;
        private DS_SalonManagementSystem DS_SalonManagementSystem;
        private DS_SalonManagementSystemTableAdapters.Sp_Get_Appointment_ContactWiseTableAdapter Sp_Get_Appointment_ContactWiseTableAdapter;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrint;
    }
}